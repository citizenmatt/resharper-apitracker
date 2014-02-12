[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ActivityCollector
{
    
    [JetBrains.Annotations.ThreadUnsafeAttribute()]
    [System.ObsoleteAttribute("No usages in ReSharper")]
    public class static ActivityCollector
    {
        public static void Flush() { }
        public static JetBrains.ActivityCollector.ActivityCollector.ActivityEndpoint GetEndpoint() { }
        public class ActivityEndpoint
        {
            public ActivityEndpoint() { }
            public System.IDisposable StartActivity(JetBrains.ActivityCollector.Key name) { }
        }
    }
    public class Key
    {
        public Key(string name) { }
        public string Name { get; }
    }
}
namespace JetBrains.Annotations
{
    
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public class AspChildControlTypeAttribute : System.Attribute
    {
        public AspChildControlTypeAttribute(string tagName, System.Type controlType) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspDataFieldAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspDataFieldsAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspMethodPropertyAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcActionAttribute : System.Attribute
    {
        public AspMvcActionAttribute([JetBrains.Annotations.NotNullAttribute()] string anonymousProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string AnonymousProperty { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcActionSelectorAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcAreaAttribute : JetBrains.Annotations.PathReferenceAttribute
    {
        public AspMvcAreaAttribute([JetBrains.Annotations.NotNullAttribute()] string anonymousProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string AnonymousProperty { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcControllerAttribute : System.Attribute
    {
        public AspMvcControllerAttribute([JetBrains.Annotations.NotNullAttribute()] string anonymousProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string AnonymousProperty { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcDisplayTemplateAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcEditorTemplateAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcMasterAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcModelTypeAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcPartialViewAttribute : JetBrains.Annotations.PathReferenceAttribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All)]
    public sealed class AspMvcSupressViewErrorAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcTemplateAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcViewAttribute : JetBrains.Annotations.PathReferenceAttribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public class AspRequiredAttributeAttribute : System.Attribute
    {
        public AspRequiredAttributeAttribute(string attribute) { }
        public string Attribute { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspTypePropertyAttribute : System.Attribute
    {
        public AspTypePropertyAttribute(bool createConstructorReferences) { }
        [JetBrains.Annotations.PublicAPIAttribute()]
        public bool CreateConstructorReferences { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    [System.ObsoleteAttribute("Use ContractAnnotationAttribute instead")]
    public sealed class AssertionConditionAttribute : System.Attribute
    {
        public AssertionConditionAttribute(JetBrains.Annotations.AssertionConditionType conditionType) { }
        public JetBrains.Annotations.AssertionConditionType ConditionType { get; }
    }
    public enum AssertionConditionType
    {
        IS_TRUE = 0,
        IS_FALSE = 1,
        IS_NULL = 2,
        IS_NOT_NULL = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class AssertionMethodAttribute : System.Attribute { }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(System.Attribute))]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public sealed class BaseTypeRequiredAttribute : System.Attribute
    {
        public BaseTypeRequiredAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type baseType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Type BaseType { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class CanBeNullAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class CannotApplyEqualityOperatorAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public sealed class ContractAnnotationAttribute : System.Attribute
    {
        public ContractAnnotationAttribute([JetBrains.Annotations.NotNullAttribute()] string contract) { }
        public ContractAnnotationAttribute([JetBrains.Annotations.NotNullAttribute()] string contract, bool forceFullStates) { }
        public string Contract { get; }
        public bool ForceFullStates { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class HtmlAttributeValueAttribute : System.Attribute
    {
        public HtmlAttributeValueAttribute([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class HtmlElementAttributesAttribute : System.Attribute
    {
        public HtmlElementAttributesAttribute([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed class ImmutableAttribute : System.Attribute { }
    [System.FlagsAttribute()]
    public enum ImplicitUseKindFlags
    {
        Default = 7,
        Access = 1,
        Assign = 2,
        InstantiatedWithFixedConstructorSignature = 4,
        InstantiatedNoFixedConstructorSignature = 8,
    }
    [System.FlagsAttribute()]
    public enum ImplicitUseTargetFlags
    {
        Default = 1,
        Itself = 1,
        Members = 2,
        WithMembers = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class InstantHandleAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class InvokerParameterNameAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All)]
    public sealed class LinqTunnelAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Module | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.ReturnValue | System.AttributeTargets.GenericParameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class LocalizationRequiredAttribute : System.Attribute
    {
        public LocalizationRequiredAttribute() { }
        public LocalizationRequiredAttribute(bool required) { }
        public bool Required { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class MeansImplicitUseAttribute : System.Attribute
    {
        public MeansImplicitUseAttribute() { }
        public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags) { }
        public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class NoEnumerationAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class NotifyPropertyChangedInvocatorAttribute : System.Attribute
    {
        public NotifyPropertyChangedInvocatorAttribute(string parameterName) { }
        public string ParameterName { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class NotNullAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public class PathReferenceAttribute : System.Attribute
    {
        public PathReferenceAttribute([JetBrains.Annotations.PathReferenceAttribute()] string basePath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string BasePath { get; }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public sealed class PublicAPIAttribute : System.Attribute
    {
        public PublicAPIAttribute([JetBrains.Annotations.NotNullAttribute()] string comment) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Comment { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class PureAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorHelperCommonAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All)]
    public sealed class RazorImportNamespaceAttribute : System.Attribute
    {
        public RazorImportNamespaceAttribute(string name) { }
        [JetBrains.Annotations.PublicAPIAttribute()]
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorLayoutAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorSectionAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorWriteLiteralMethodAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorWriteMethodAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorWriteMethodParameterAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed class ReturnsThreadSafeAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class StringFormatMethodAttribute : System.Attribute
    {
        public StringFormatMethodAttribute(string formatParameterName) { }
        public string FormatParameterName { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    [System.ObsoleteAttribute("Use ContractAnnotationAttribute instead")]
    public sealed class TerminatesProgramAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed class ThreadSafeAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed class ThreadUnsafeAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Module | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.ReturnValue | System.AttributeTargets.GenericParameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class UsedImplicitlyAttribute : System.Attribute
    {
        public UsedImplicitlyAttribute() { }
        public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags) { }
        public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        public JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; }
        public JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public sealed class XamlItemBindingOfItemsControlAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, Inherited=true)]
    public sealed class XamlItemsControlAttribute : System.Attribute { }
}
namespace JetBrains.Application
{
    
    public class static CompanyInfo
    {
        public static readonly string Name;
        public static readonly string NameWithInc;
        public static readonly string NameWithIncNational;
        public static readonly string PlatformProductRegistryKeyName;
        public static readonly string WebsiteUri;
    }
    public interface ISorter<T>
    
    {
        System.Collections.Generic.ICollection<T> Sort(System.Collections.Generic.ICollection<T> unsorted);
    }
}
namespace JetBrains.Application.Progress
{
    
    public interface IProgressIndicator : System.IDisposable
    {
        string CurrentItemText { set; }
        bool IsCanceled { get; }
        string TaskName { get; set; }
        void Advance(double units);
        void Start(int totalWorkUnits);
        void Stop();
    }
    public interface IProgressIndicatorModel
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<double> Fraction { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> IsCanceled { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> IsRunning { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<string> Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<string> StepName { get; }
    }
    public class NullProgressIndicator : JetBrains.Application.Progress.ProgressIndicatorBase
    {
        public static JetBrains.Application.Progress.NullProgressIndicator Instance { get; }
    }
    public class ProcessCancelledException : System.Exception { }
    public class static ProcessCancelledExceptionExtension
    {
        public static bool ContainsProcessCancelledException(this System.Exception ex) { }
    }
    public class ProgressDiagnosticException : System.ApplicationException
    {
        public ProgressDiagnosticException(string message) { }
        public ProgressDiagnosticException(string message, System.Exception innerException) { }
    }
    public class ProgressIndicator : JetBrains.Application.Progress.IProgressIndicator, JetBrains.Application.Progress.IProgressIndicatorModel, System.IDisposable
    {
        public ProgressIndicator(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<double> Fraction { get; }
        public JetBrains.DataFlow.IProperty<bool> IsCanceled { get; }
        public JetBrains.DataFlow.IProperty<bool> IsRunning { get; }
        public JetBrains.DataFlow.IProperty<string> Name { get; }
        public object ReadonlyToken { get; set; }
        public JetBrains.DataFlow.IProperty<string> StepName { get; }
    }
    public abstract class ProgressIndicatorBase : JetBrains.Application.Progress.IProgressIndicator, System.IDisposable
    {
        public static readonly double DefaultEpsilon;
        protected ProgressIndicatorBase([JetBrains.Annotations.NotNullAttribute()] string taskName) { }
        public virtual string CurrentItemText { get; set; }
        protected double Fraction { get; }
        public virtual bool IsCanceled { get; }
        public virtual string TaskName { get; set; }
        protected int TotalWorkUnits { get; }
        public double Units { get; }
        public virtual void Advance(double units) { }
        public virtual void Cancel() { }
        public void Dispose() { }
        public virtual void Start(int totalWorkUnits) { }
        public virtual void Stop() { }
    }
    public class static ProgressIndicatorExtensions
    {
        public static void Advance([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static void Advance([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progressParent, double fUnitsInParentIndicator, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Application.Progress.IProgressIndicator> funcAdvanceSubprogress) { }
        public static void Cancel([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicatorModel progress) { }
        public static void CheckForInterrupt([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.Application.Progress.IProgressIndicator CreateSlowIndicator([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static JetBrains.Application.Progress.IProgressIndicator CreateSlowIndicator([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progressIndicator, System.TimeSpan timeSpan) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("progressParent:null => null; => notnull")]
        public static JetBrains.Application.Progress.IProgressIndicator CreateSubProgress(this JetBrains.Application.Progress.IProgressIndicator progressParent, double fUnitsInParentIndicator) { }
        public static JetBrains.Application.Progress.IProgressIndicator CreateSubProgress([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progressParent) { }
        public static void ForEachWithProgress<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, bool throwOnCancel, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T, JetBrains.Application.Progress.IProgressIndicator> handler) { }
        public static void ForEachWithProgress<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T, JetBrains.Application.Progress.IProgressIndicator> handler) { }
        public static void ForEachWithProgress<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, bool throwOnCancel, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> handler) { }
        public static void ForEachWithProgress<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> handler) { }
        public static void SafeAdvance([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, double units) { }
        public static System.IDisposable SafeStep([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int stepSize) { }
        public static System.IDisposable SafeTotal([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int total) { }
        public static System.IDisposable SafeTotal([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, string taskName, int total) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<TResult> SelectWProgress<TSource, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TResult> selector) { }
        public static void Start([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int totalWorkUnits, [JetBrains.Annotations.NotNullAttribute()] string sTaskName) { }
        public static JetBrains.Application.Progress.IProgressIndicator StartProgress([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int totalWorkUnits) { }
        public static JetBrains.Application.Progress.IProgressIndicator StartProgress([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int totalWorkUnits, [JetBrains.Annotations.NotNullAttribute()] string taskName) { }
        public static void StartStop([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int totalWorkUnits, [JetBrains.Annotations.NotNullAttribute()] string taskName, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static System.IDisposable Step([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, int stepSize) { }
        public static JetBrains.Application.Progress.IProgressIndicator Total([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Application.Progress.IProgressIndicator progress, string taskName, int total) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> WithProgress<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, bool throwOnCancel = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T, JetBrains.Application.Progress.IProgressIndicator>> WithProgressForEvery<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, [JetBrains.Annotations.NotNullAttribute()] string taskname, bool throwOnCancel = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> WithSubProgress<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progress, double fUnitsInParentIndicator, [JetBrains.Annotations.NotNullAttribute()] string taskname, bool throwOnCancel = False) { }
    }
    public class SubProgressIndicator : JetBrains.Application.Progress.ProgressIndicatorBase
    {
        public SubProgressIndicator([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressParent, double fUnitsInParentIndicator) { }
        public override string CurrentItemText { set; }
        public override bool IsCanceled { get; }
        public override string TaskName { get; set; }
        public override void Advance(double units) { }
    }
}
namespace JetBrains
{
    
    public class static BooleanUtil
    {
        public static bool Not(this bool value) { }
        public static System.Func<string, bool> SafeParseBool(bool defaultValue) { }
    }
    public class static Comparer
    {
        public static JetBrains.Comparer<T> Create<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, int> funcComparer) { }
    }
    public sealed class Comparer<T> : System.Collections.Generic.IComparer<T>, System.Collections.IComparer
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Collections.Generic.Comparer<T> Default;
        public Comparer([JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, int> funcComparer) { }
    }
    public class static DictionaryEx
    {
        public static void Add<TKey, TValue>(this System.Collections.Generic.IDictionary<TKey, TValue> thіs, JetBrains.DataFlow.Lifetime lifetime, TKey key, TValue value) { }
        public static bool DictionaryEquals<TKey, TValue>(this System.Collections.Generic.IDictionary<TKey, TValue> thіs, System.Collections.Generic.IDictionary<TKey, TValue> other) { }
        public static int DictionaryGetHashCode<TKey, TValue>(this System.Collections.Generic.IDictionary<TKey, TValue> thіs) { }
        public static TValue GetValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key) { }
        public static TValue GetValueSafe<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key, TValue resultOnFail = null) { }
    }
    public class static EqualityComparer
    {
        public static JetBrains.EqualityComparer<T> Create<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> funcCompare, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, int> funcGetHashCode) { }
    }
    public sealed class EqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Collections.Generic.IEqualityComparer<T> Default;
        public EqualityComparer([JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> funcCompare, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, int> funcGetHashCode) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Func<T, T, bool> FuncCompare { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Func<T, int> FuncGetHashCode { get; }
    }
    public class static NumberUtil
    {
        public static double Clamp(this double value, double min, double max) { }
        public static int Clamp(this int value, int min, int max) { }
        public static string FloatingToStringRoundtrip<T>(T value) { }
        public static bool InRange<T>(this T value, T min, T max)
            where T : System.IComparable { }
        public static bool IsInfinity(this double number) { }
        public static bool IsInfinity(this float number) { }
        public static bool IsNaN(this double number) { }
        public static bool IsNaN(this float value) { }
        public static bool IsNanOrInf(this double number) { }
        public static bool IsNanOrInf(this float number) { }
        public static bool IsNegativeInfinity(this double number) { }
        public static bool IsNegativeInfinity(this float number) { }
        public static bool IsNegativeZero(this double value) { }
        public static bool IsNegativeZero(this float number) { }
        public static bool IsPositiveInfinity(this double number) { }
        public static bool IsPositiveInfinity(this float number) { }
        public static bool IsPositiveZero(this double value) { }
        public static bool IsPositiveZero(this float number) { }
        public static int Kilobytes(this int number) { }
        public static int Megabytes(this int number) { }
    }
    public class static ReflectionUtil
    {
        public static System.Collections.Generic.IEnumerable<T> EnumerateEnumValues<T>() { }
    }
    public class SlruCache<K, V> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<K, V>>, System.Collections.IEnumerable
    
    
    {
        public SlruCache(int capacity) { }
        public SlruCache(int capacity, System.Func<K, V, System.TimeSpan, bool> evictPredicate, System.TimeSpan evictionPeriod) { }
        public SlruCache(int probationaryCapacity, int protectedCapacity) { }
        public SlruCache(System.Collections.Generic.IEqualityComparer<K> comparer, int probationaryCapacity, int protectedCapacity) { }
        public SlruCache([JetBrains.Annotations.NotNullAttribute()] System.Func<K, V> producer) { }
        public SlruCache([JetBrains.Annotations.NotNullAttribute()] System.Func<K, V> producer, int capacity) { }
        public SlruCache([JetBrains.Annotations.NotNullAttribute()] System.Func<K, V> producer, int probationaryCapacity, int protectedCapacity) { }
        public SlruCache([JetBrains.Annotations.NotNullAttribute()] System.Func<K, V> producer, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<K> equalityComparer, int probationaryCapacity, int protectedCapacity, System.Func<K, V, System.TimeSpan, bool> evictPredicate, System.TimeSpan evictionPeriod) { }
        public int Count { get; }
        public void Clear() { }
        public void EvictConditionally() { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K, V>> GetEnumerator() { }
        public V GetValue(K key) { }
        public void Invalidate(K key) { }
        public bool Lookup(K key, out V value) { }
        public void Provide(K key, V value) { }
    }
    public class static StringEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AppendLine([JetBrains.Annotations.NotNullAttribute()] this string s, [JetBrains.Annotations.NotNullAttribute()] string line) { }
        public static bool Contains([JetBrains.Annotations.NotNullAttribute()] this string s, char value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static string FormatEx([JetBrains.Annotations.NotNullAttribute()] this string format, params object[] args) { }
        public static JetBrains.Util.StringSlice Slice([JetBrains.Annotations.NotNullAttribute()] this string s, int start, int length) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.StringSlice> Split([JetBrains.Annotations.NotNullAttribute()] this string s, params char[] separator) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.StringSlice> Split([JetBrains.Annotations.NotNullAttribute()] this string s, char[] separator, System.StringSplitOptions options) { }
        public static T ToEnum<T>([JetBrains.Annotations.NotNullAttribute()] this string s, bool ignoreCase = False)
            where T :  struct { }
        public static T ToEnum<T>([JetBrains.Annotations.CanBeNullAttribute()] this string s, T defaultValue, bool ignoreCase = False)
            where T :  struct { }
        public static System.Nullable<T> ToEnumNullable<T>([JetBrains.Annotations.CanBeNullAttribute()] this string s)
            where T :  struct { }
        public static System.Nullable<T> ToEnumNullableSafe<T>([JetBrains.Annotations.CanBeNullAttribute()] this string s, System.Nullable<T> defaultValue = null, bool ignoreCase = False)
            where T :  struct { }
        public static T ToEnumSafe<T>([JetBrains.Annotations.CanBeNullAttribute()] this string s, T defaultValue = null, bool ignoreCase = False)
            where T :  struct { }
    }
    public class TextChange
    {
        public TextChange(JetBrains.Util.TextRange range, string newText) { }
        public string NewText { get; }
        public JetBrains.Util.TextRange Range { get; }
        public static void ApplyChanges(System.Collections.Generic.IEnumerable<JetBrains.TextChange> changes, System.Action<JetBrains.TextChange> makeChange) { }
        public static int TranslateOffset(System.Collections.Generic.IEnumerable<JetBrains.TextChange> changes, int offset) { }
    }
}
namespace JetBrains.Compression
{
    
    public class IntegerDecoder
    {
        public IntegerDecoder(byte[] buff) { }
        public IntegerDecoder(JetBrains.Compression.IntegerEncoder integerEncoder) { }
        public long FilePointer { get; }
        public int Limit { get; }
        public void Close() { }
        protected int ENSURE() { }
        public void FullBuff(long fromBit) { }
        public void Jump(long bits) { }
        public void Load(long fromBit) { }
        public int Read() { }
        public byte Read0() { }
        public int ReadBinary(int len) { }
        public int ReadBit() { }
        public int ReadGamma() { }
        public int ReadGolomb(int b) { }
        public long ReadPack7() { }
        public int ReadPack7I() { }
        public int ReadUnary() { }
    }
    public class IntegerEncoder
    {
        public IntegerEncoder(int bufferSize) { }
        public int ByteLength { get; }
        public long WrittenBits { get; }
        public void Close() { }
        public void Flush() { }
        public void FlushByte() { }
        public byte[] GetBytes() { }
        public void Write(byte[] b, int off, int len) { }
        public void Write(int b) { }
        public void WriteBinary(int val, int len) { }
        public void WriteBit(int b) { }
        public void WriteGamma(int val) { }
        public void WriteGolomb(int val, int b) { }
        public void WritePack7(long val) { }
        public void WritePack7I(int val) { }
        public void WriteUnary(int k) { }
    }
}
namespace JetBrains.Concurrency
{
    
    public class Fiber : JetBrains.Concurrency.IFiber, System.IDisposable
    {
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Disposables;
        public bool IsCompleted { get; }
        public bool IsPrimary { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Concurrency.IFiber CreateSecondaryFiber([JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void Dispose() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Concurrency.IFiber GetPrimaryFiber() { }
        public void YieldTo() { }
    }
    public class FiberOverThread : JetBrains.Concurrency.IFiber, System.IDisposable
    {
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Disposables;
        public bool IsCompleted { get; }
        protected bool IsDisposed { get; }
        public bool IsPrimary { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Concurrency.FiberOverThread CreateSecondaryFiber([JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void Dispose() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Concurrency.FiberOverThread GetPrimaryFiber() { }
        public void YieldTo() { }
    }
    public interface IFiber : System.IDisposable
    {
        bool IsCompleted { get; }
        bool IsPrimary { get; }
        void YieldTo();
    }
}
namespace JetBrains.DataFlow
{
    
    public enum AddRemove
    {
        Add = 0,
        Remove = 1,
    }
    public class AddRemoveEventArgs<TValue> : JetBrains.DataFlow.EventArgs<TValue>
    
    {
        protected bool myIsAcknowledging;
        public AddRemoveEventArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, TValue value, object cookie) { }
        public JetBrains.DataFlow.AddRemove Action { get; }
        public JetBrains.DataFlow.ICollectionEvents<TValue> Collection { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object Cookie { get; }
        public bool IsAcknowledging { get; }
        public bool IsAdding { get; }
        public bool IsRemoving { get; }
        public static JetBrains.DataFlow.AddRemoveEventArgs<TValue> CreateAcknowledgementArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, object cookie, out System.Action<> funcSetValue) { }
    }
    public class AddRemoveIndexEventArgs<TValue> : JetBrains.DataFlow.AddRemoveEventArgs<TValue>
    
    {
        public AddRemoveIndexEventArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, TValue value, int index, object cookie) { }
        public int Index { get; }
        public static JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue> CreateAcknowledgementArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, object cookie, out System.Action<, > funcSetValueAndIndex) { }
    }
    public class BeforeAddRemoveEventArgs<TValue> : JetBrains.DataFlow.AddRemoveEventArgs<TValue>
    
    {
        public BeforeAddRemoveEventArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, TValue value, object cookie) { }
        public bool Cancel { get; set; }
        public static JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue> CreateAcknowledgementArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, object cookie, out System.Action<> funcSetValue) { }
    }
    public class BeforeAddRemoveIndexEventArgs<TValue> : JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>
    
    {
        public BeforeAddRemoveIndexEventArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, TValue value, int index, object cookie) { }
        public int Index { get; }
        public static JetBrains.DataFlow.BeforeAddRemoveIndexEventArgs<TValue> CreateAcknowledgementArgs(JetBrains.DataFlow.ICollectionEvents<TValue> collection, JetBrains.DataFlow.AddRemove action, object cookie, out System.Action<, > funcSetValueAndIndex) { }
    }
    public class BeforePropertyChangedEventArgs<TValue> : JetBrains.DataFlow.PropertyChangedEventArgs<TValue>
    
    {
        public BeforePropertyChangedEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue old, bool hasold, TValue @new, bool hasnew, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        public bool Cancel { get; set; }
        public static JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue> CreateBoth([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue old, TValue @new, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        public static JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue> CreateNew([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue @new, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        public static JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue> CreateOld([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue old, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
    }
    public class BidirectionalCompositeProperty<TSourceOne, TSourceTwo, TTarget> : JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>
    
    
    
    {
        protected BidirectionalCompositeProperty(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSourceOne> propertySourceOne, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSourceTwo> propertySourceTwo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>.ComposerDelegate composer, [JetBrains.Annotations.NotNullAttribute()] System.Func<TTarget, TSourceOne> decomposerOne, [JetBrains.Annotations.NotNullAttribute()] System.Func<TTarget, TSourceTwo> decomposerTwo) { }
        public static JetBrains.DataFlow.IProperty<TTarget> Create(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IProperty<TSourceOne> propertySourceOne, JetBrains.DataFlow.IProperty<TSourceTwo> propertySourceTwo, JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>.ComposerDelegate composer, [JetBrains.Annotations.NotNullAttribute()] System.Func<TTarget, TSourceOne> decomposerOne, [JetBrains.Annotations.NotNullAttribute()] System.Func<TTarget, TSourceTwo> decomposerTwo) { }
        protected override JetBrains.DataFlow.Property<TTarget> DecorateProperty(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.Property<TTarget> property) { }
    }
    public class static BidirectionalCompositePropertyEx
    {
        public static JetBrains.DataFlow.IProperty<JetBrains.Util.Pair<T1, T2>> Compose<T1, T2>(this JetBrains.DataFlow.IProperty<T1> p1, JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IProperty<T2> p2) { }
    }
    public class CancelEventArgs<TValue> : JetBrains.DataFlow.EventArgs<TValue>
    
    {
        public CancelEventArgs(TValue value) { }
        public bool Cancel { get; set; }
    }
    public class static CollectionBridge
    {
        public static JetBrains.DataFlow.CollectionBridge<TSource, TTarget> BridgeInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> funcConverter = null, [JetBrains.Annotations.CanBeNullAttribute()] object cookie = null) { }
        public enum MappingInfo
        {
            SourceToTarget = 0,
            BothWays = 1,
        }
    }
    public class CollectionBridge<TSource, TTarget>
    
    
    {
        public CollectionBridge([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.CollectionBridge.MappingInfo mappinginfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> funcConverter, [JetBrains.Annotations.CanBeNullAttribute()] object oTaregtModificationCookie) { }
        public bool AllowForeignTargetRemovals { get; set; }
        public JetBrains.DataFlow.CollectionBridge.MappingInfo MappingInfo { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IDictionary<TSource, TTarget> MapSourceToTarget { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IDictionary<TTarget, TSource> MapTargetToSource { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<TSource> Source { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<TTarget> Target { get; }
    }
    public class CollectionEvents<TValue> : JetBrains.DataFlow.ICollectionEvents<TValue>, JetBrains.DataFlow.IViewable<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged, System.Runtime.Serialization.ISerializable
    
    {
        public readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected JetBrains.Util.Concurrency.SpinWaitLock myLock;
        protected readonly JetBrains.Util.ILogger myLogger;
        protected static readonly string ValueNameId;
        protected static readonly string ValueNameIsUniqueItems;
        public CollectionEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<TValue> storage, bool bUniqueItems, JetBrains.Util.ILogger logger = null) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public CollectionEvents([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<TValue> storage, bool bUniqueItems) { }
        public CollectionEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<TValue> storage, bool bUniqueItems) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public CollectionEvents([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public CollectionEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id) { }
        protected CollectionEvents(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> AddRemove { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> BeforeAddRemove { get; }
        public int Count { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.PropertyId<TValue> Id { get; }
        public bool IsNullValuesAllowed { get; }
        public bool IsReadOnly { get; }
        public bool IsUniqueItems { get; }
        public bool SuppressItemErrors { get; set; }
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public bool Add(TValue value, object cookie) { }
        public void Add([JetBrains.Annotations.NotNullAttribute()] TValue item) { }
        public void AddRange(System.Collections.Generic.IEnumerable<TValue> items) { }
        public void Clear() { }
        public bool Contains(TValue item) { }
        public void CopyTo(TValue[] array, int arrayIndex) { }
        protected void FireAddRemove(JetBrains.DataFlow.AddRemove action, TValue value, object cookie) { }
        protected bool FireBeforeAddRemove(JetBrains.DataFlow.AddRemove action, TValue value, object cookie) { }
        protected virtual void FireCollectionChanged(TValue value, JetBrains.DataFlow.AddRemove addremove) { }
        protected virtual void FireCollectionChanged(TValue value, int index, JetBrains.DataFlow.AddRemove addremove) { }
        protected void FirePropertyChanged(string name) { }
        public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected virtual bool InternalAdd(TValue value, object cookie) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected virtual bool InternalRemove(TValue value, object cookie) { }
        public bool Modify(JetBrains.DataFlow.AddRemove action, TValue item, object cookie) { }
        public bool Remove(TValue value, object cookie) { }
        public bool Remove([JetBrains.Annotations.NotNullAttribute()] TValue item) { }
        public TValue[] ToArray() { }
        public System.Collections.Generic.List<TValue> ToList() { }
        public override string ToString() { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, TValue> viewer) { }
    }
    public class static CollectionValidator
    {
        public static void CreateReadonlyValidator<TItem>(this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        public static void CreateThreadAffinityValidator<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.CollectionEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.CollectionEvents<TValue> thіs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.CollectionEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.CollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ICollectionEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ICollectionEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ListEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ListEvents<TValue> thіs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ListEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ListEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IListEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TValue> thіs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IListEvents<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.DictionaryEvents<TKey, TValue> EnsureReadonly<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.DictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.DictionaryEvents<TKey, TValue> EnsureReadonly<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.DictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> EnsureReadonly<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> EnsureReadonly<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.CollectionEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.CollectionEvents<TItem> thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.CollectionEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.CollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ICollectionEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ICollectionEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ListEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ListEvents<TItem> thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ListEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ListEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IListEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TItem> thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IListEvents<TItem> EnsureThisThread<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.DictionaryEvents<TKey, TValue> EnsureThisThread<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.DictionaryEvents<TKey, TValue> thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.DictionaryEvents<TKey, TValue> EnsureThisThread<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.DictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> EnsureThisThread<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> EnsureThisThread<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IDictionaryEvents<TKey, TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class CompositeProperty<TSourceOne, TSourceTwo, TTarget>
    
    
    
    {
        protected static readonly JetBrains.DataFlow.StandardPreconditions.ReadonlyToken myReadonlyToken;
        protected CompositeProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSourceOne> propertySourceOne, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSourceTwo> propertySourceTwo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>.ComposerDelegate composer) { }
        public JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>.ComposerDelegate Composer { get; }
        public JetBrains.DataFlow.IProperty<TSourceOne> SourceOne { get; }
        public JetBrains.DataFlow.IProperty<TSourceTwo> SourceTwo { get; }
        protected JetBrains.DataFlow.IProperty<TTarget> Target { get; }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static JetBrains.DataFlow.IProperty<TTarget> Create(JetBrains.DataFlow.IProperty<TSourceOne> propertySourceOne, JetBrains.DataFlow.IProperty<TSourceTwo> propertySourceTwo, JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>.ComposerDelegate composer) { }
        public static JetBrains.DataFlow.IProperty<TTarget> Create(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IProperty<TSourceOne> propertySourceOne, JetBrains.DataFlow.IProperty<TSourceTwo> propertySourceTwo, JetBrains.DataFlow.CompositeProperty<TSourceOne, TSourceTwo, TTarget>.ComposerDelegate composer) { }
        protected virtual JetBrains.DataFlow.Property<TTarget> DecorateProperty(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.Property<TTarget> property) { }
        public delegate TTarget ComposerDelegate<TSourceOne, TSourceTwo, TTarget>(TSourceOne valueOne, TSourceTwo valueTwo);
    }
    [System.FlagsAttribute()]
    public enum DataFlowDirection
    {
        None = 0,
        FromSource = 1,
        FromTarget = 2,
        BothWays = 3,
    }
    public class static DataFlowEx
    {
        public static JetBrains.DataFlow.ISimpleSignal AccumulateChange<E, T>(this JetBrains.DataFlow.ICollectionEvents<E> col, JetBrains.DataFlow.Lifetime lifetime, System.Func<E, JetBrains.DataFlow.ISignal<T>> changeSignal) { }
        public static void AddLifetime([JetBrains.Annotations.NotNullAttribute()] this System.ComponentModel.IContainer thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.LifetimeDefinition lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime DefineWinFormsLifetime([JetBrains.Annotations.NotNullAttribute()] this System.Windows.Forms.Control thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime DefineWinFormsLifetime([JetBrains.Annotations.NotNullAttribute()] this System.Windows.Forms.Control thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime parentLifetime) { }
        public static void OnSignal<TSignal>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IPropertyBinding binding, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<TSignal> signal, JetBrains.DataFlow.DataFlowDirection direction) { }
    }
    public class DependencyPropertyChangeSink<TValue> : System.Windows.DependencyObject
    
    {
        public static readonly System.Windows.DependencyProperty ValueProperty;
        public DependencyPropertyChangeSink([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject owner, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty property, bool isVarianceAllowed = False) { }
        public JetBrains.DataFlow.IProperty<TValue> Property { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public TValue Value { get; set; }
        public static bool CheckDependencyPropertyType([JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject dependencyobject, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty dependencyproperty, bool isVarianceAllowed = False) { }
        public static JetBrains.DataFlow.PropertyId<TValue> CreatePropertyId([JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject owner, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty property) { }
    }
    public class static DependencyPropertyWrapper
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject dependencyobject, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty dependencyproperty, bool bSinkEvents) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Windows.UIElement owner, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty dependencyproperty, [JetBrains.Annotations.CanBeNullAttribute()] System.Windows.RoutedEvent @event) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto<TSource>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> propSource, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject doTarget, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty dpropTarget) { }
        public static void FlowInto<TSource>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> propSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject doTarget, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty dpropTarget) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> propSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject doTarget, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty dpropTarget, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FConvert) { }
    }
    public class DictionaryEvents<TKey, TValue> : JetBrains.DataFlow.CollectionEvents<System.Collections.Generic.KeyValuePair<TKey, TValue>>, JetBrains.DataFlow.ICollectionEvents<System.Collections.Generic.KeyValuePair<TKey, TValue>>, JetBrains.DataFlow.IDictionaryEvents<TKey, TValue>, JetBrains.DataFlow.IViewable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
    
    
    {
        public DictionaryEvents(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<System.Collections.Generic.KeyValuePair<TKey, TValue>> id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<TKey, TValue> storage, bool bNullKeysAllowed, bool bNullValuesAllowed, JetBrains.Util.ILogger logger = null) { }
        public DictionaryEvents([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public DictionaryEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id) { }
        public DictionaryEvents([JetBrains.Annotations.NotNullAttribute()] string id, bool bNullKeysAllowed, bool bNullValuesAllowed) { }
        public DictionaryEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, bool bNullKeysAllowed, bool bNullValuesAllowed) { }
        protected DictionaryEvents(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public bool NullPairKeysAllowed { get; }
        public bool NullPairValuesAllowed { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public void Add(TKey key, TValue value) { }
        public bool ContainsKey(TKey key) { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected override bool InternalAdd(System.Collections.Generic.KeyValuePair<TKey, TValue> value, object cookie) { }
        protected override bool InternalRemove(System.Collections.Generic.KeyValuePair<TKey, TValue> value, object cookie) { }
        public bool Remove(TKey key) { }
        public void set_Item(TKey key, object cookie, TValue value) { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public TValue TryGetValue(TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> funcCreateIfMissing) { }
    }
    public class static Disposable
    {
        public static readonly System.IDisposable Empty;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable CreateAction([JetBrains.Annotations.NotNullAttribute()] System.Action closing) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable CreateAction_FinalizableFreeThreaded([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Action closing, [JetBrains.Annotations.CanBeNullAttribute()] string messageFinalization = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable CreateBracket([JetBrains.Annotations.NotNullAttribute()] System.Action opening, [JetBrains.Annotations.NotNullAttribute()] System.Action closing, bool trapExceptions = True) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable CreateBracket_FinalizableFreeThreaded([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Action opening, [JetBrains.Annotations.NotNullAttribute()] System.Action closing, [JetBrains.Annotations.CanBeNullAttribute()] string messageFinalization = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable CreateBracket_FinalizableSingleThreaded([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Action opening, [JetBrains.Annotations.NotNullAttribute()] System.Action closing, [JetBrains.Annotations.CanBeNullAttribute()] string messageFinalization = null) { }
        public static System.IDisposable CreateCompositeDisposable<T>(params System.Func<>[] disposables)
            where T : System.IDisposable { }
        public class EmptyDisposable : System.IDisposable
        {
            public void Dispose() { }
        }
        public class FinallyException : System.ApplicationException
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly string Id;
            public override string StackTrace { get; }
            public static JetBrains.DataFlow.Disposable.FinallyException Create([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Exception innerException, [JetBrains.Annotations.CanBeNullAttribute()] string sOriginatingStackTrace) { }
            public static void LogMissedDispose(string id, string message, string sOriginatingStackTrace) { }
            public static void LogMissedDispose(string id) { }
        }
    }
    public class static EternalLifetime
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.LifetimeDefinition Definition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime Instance { get; }
    }
    public class EventArgs<TValue> : System.EventArgs
    
    {
        protected TValue myValue;
        public EventArgs(TValue value) { }
        public TValue Value { get; }
    }
    public interface ICollectionEvents<TValue> : JetBrains.DataFlow.IViewable<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
    
    {
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> AddRemove { get; }
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> BeforeAddRemove { get; }
        new int Count { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.PropertyId<TValue> Id { get; }
        bool Add(TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
        void AddRange([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TValue> items);
        bool Modify(JetBrains.DataFlow.AddRemove action, TValue item, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
        bool Remove(TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
        [JetBrains.Annotations.NotNullAttribute()]
        TValue[] ToArray();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.List<TValue> ToList();
    }
    public class static ICollectionEventsEx
    {
        public static void Add<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        public static void AddItemUnderLifetime<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeOuter, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, JetBrains.DataFlow.LifetimeDefinition, TItem> FCreateItem) { }
        public static void BeginAdd<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeAsyncOperation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue item) { }
        public static JetBrains.DataFlow.IProperty<int> CreateCount<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.DataFlow.IProperty<bool> CreateIsEmpty<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.DataFlow.IProperty<bool> CreateIsNotEmpty<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static void DisposeEachItem<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime)
            where TValue : System.IDisposable { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> FConvert = null, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, bool> FFilter = null, [JetBrains.Annotations.CanBeNullAttribute()] object cookie = null) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, TSource, TTarget> FConvert, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, bool> FFilter = null, [JetBrains.Annotations.CanBeNullAttribute()] object cookie = null) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> FConvert = null, [JetBrains.Annotations.CanBeNullAttribute()] object cookie = null) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, TSource, TTarget> FConvert = null, [JetBrains.Annotations.CanBeNullAttribute()] object cookie = null) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TTarget> target) { }
        public static void FlowIntoGrouped_NoReplay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> source, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.GroupingEventHost gehost, System.TimeSpan delay, bool bReplicateInitialValuesImmediately, [JetBrains.Annotations.CanBeNullAttribute()] object token) { }
        public static void FlowIntoGrouped_NoReplay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> source, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TValue> target, [JetBrains.Annotations.NotNullAttribute()] System.Action FAssertCanExecuteNow, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Action> FExecuteGrouped, bool bReplicateInitialValuesImmediately, [JetBrains.Annotations.CanBeNullAttribute()] object token) { }
        public static void FlowIntoGuarded_NoReplay<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> source, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard reega, bool bReplicateInitialValuesImmediately, [JetBrains.Annotations.CanBeNullAttribute()] object token) { }
        public static void FlowIntoSorted<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TItem> target, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IComparer<TItem> comparer) { }
        public static void ForEachItem<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, TValue> FHandler) { }
        public static void ForEachItem<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, TValue, object> FHandler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime GetLifetimeOfItem<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, JetBrains.DataFlow.Lifetime lifetime, TItem item) { }
        public static void LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string prefix) { }
        public static void LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] object logprefix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IListEvents<TItem> OrderByLive<TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IComparer<TItem> comparer) { }
    }
    public class static ICollectionEventsEx_ObsoleteWithoutLifetime
    {
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static void BeginAdd<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> coll, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable BridgeInto_Guarded_Slow<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard reega, [JetBrains.Annotations.CanBeNullAttribute()] object token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable PushForEachItem<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ICollectionEvents<TValue> coll, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, System.IDisposable> handler) { }
    }
    public class static ICollectionSignalEx
    {
        public static void Advise_Add<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> FHandler) { }
        public static void Advise_Add<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_Remove<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> FHandler) { }
        public static void Advise_Remove<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> FHandler) { }
    }
    public class static ICollectionSignalEx_ObsoleteWithoutLifetime
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_Add<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_Remove<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_Remove<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> handler) { }
    }
    public interface IDictionaryEvents<TKey, TValue> : JetBrains.DataFlow.ICollectionEvents<System.Collections.Generic.KeyValuePair<TKey, TValue>>, JetBrains.DataFlow.IViewable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
    
    
    {
        TValue TryGetValue(TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> funcCreateIfMissing);
    }
    public interface IHaveUntypedProperty
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IUntypedProperty AsUntyped { get; }
    }
    public interface IListEvents<TValue> : JetBrains.DataFlow.ICollectionEvents<TValue>, JetBrains.DataFlow.IViewable<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.Generic.IList<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged
    
    {
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> AddRemove { get; }
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveIndexEventArgs<TValue>> BeforeAddRemove { get; }
        bool Modify(JetBrains.DataFlow.AddRemove action, TValue item, int index, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
        bool Modify(JetBrains.DataFlow.AddRemove action, System.Func<TValue> funcGetItemIfAdding, int index, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
    }
    public class InOutEventArgs<TIn, TOut> : System.EventArgs
    
    
    {
        public InOutEventArgs(TIn @in, TOut @out) { }
        public InOutEventArgs(TIn @in) { }
        public TIn In { get; }
        public TOut Out { get; set; }
    }
    public interface IProperty<TValue> : JetBrains.DataFlow.IHaveUntypedProperty, System.IDisposable
    
    {
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> BeforeChange { get; }
        JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> Change { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.PropertyId<TValue> Id { get; }
        bool IsNullValueAllowed { get; }
        TValue Value { get; set; }
        TValue GetValue();
        TValue GetValue([JetBrains.Annotations.CanBeNullAttribute()] object cookie);
        bool SetValue(TValue value);
        bool SetValue(TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
    }
    public interface IPropertyBag
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IUntypedPropertyBag AsUntyped { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IDictionaryEvents<JetBrains.DataFlow.PropertyId, JetBrains.DataFlow.IUntypedProperty> Properties { get; }
        bool Contains<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id);
        T Get<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<T> GetOrCreateProperty<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id, T defaultvalue = null, System.Nullable<bool> isNullValueAllowed = null);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<T> GetProperty<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id);
        bool Remove<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id);
        void Set<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id, [JetBrains.Annotations.CanBeNullAttribute()] T value);
        bool TryGet<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id, [JetBrains.Annotations.CanBeNullAttribute()] out T value);
        [JetBrains.Annotations.CanBeNullAttribute()]
        T TryGet<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<T> id);
    }
    public class static IPropertyBagEx
    {
        public static void LogChanges([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IPropertyBag thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string prefix) { }
    }
    public interface IPropertyBinding : System.IDisposable
    {
        JetBrains.DataFlow.DataFlowDirection Direction { get; }
        JetBrains.DataFlow.IUntypedProperty Source { get; }
        JetBrains.DataFlow.IUntypedProperty Target { get; }
        void CopySourceToTarget();
        void CopyTargetToSource();
    }
    public interface IPropertyBinding<TSource, TTarget> : System.IDisposable
    
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IPropertyBinding AsUntyped { get; }
        JetBrains.DataFlow.DataFlowDirection Direction { get; }
        JetBrains.DataFlow.IProperty<JetBrains.DataFlow.IProperty<TSource>> Source { get; }
        JetBrains.DataFlow.IProperty<JetBrains.DataFlow.IProperty<TTarget>> Target { get; }
        void CopySourceToTarget();
        void CopyTargetToSource();
    }
    public class static IPropertyEx
    {
        public static void BeginSetValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue value, object cookie = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TTarget> Cast<TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IUntypedProperty propSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.DataFlow.IUntypedProperty CreateUntypedProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id, [JetBrains.Annotations.CanBeNullAttribute()] object value, System.Nullable<bool> isNullValueAllowed, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void DisposeEachValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime)
            where TValue : System.IDisposable { }
        public static void FlowDeferredInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target) { }
        public static void FlowDeferredInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target) { }
        public static void FlowInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FConverter) { }
        [System.ObsoleteAttribute("Please use FlowIntoViaGroupingEvent instead")]
        public static void FlowInto_Grouped<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.GroupingEvent grouper, JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token = null) { }
        public static void FlowIntoReadonly<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FConverter, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        public static void FlowIntoReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target, JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        public static void FlowIntoViaGroupingEvent<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.GroupingEvent grouper, bool prolongate = False, JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token = null) { }
        public static void ForEachValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, TValue> FHandler) { }
        public static void ForEachValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TValue, bool> FCondition, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, TValue> FHandler) { }
        public static void ForEachValue_NotNull<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, TValue> FHandler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> Invert([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<bool> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static void LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string prefix) { }
        public static void LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] object logprefix) { }
        public static void LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public static void LogChangesAndStacktraces<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> MakeFlag<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> prop, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, bool> FCondition, [JetBrains.Annotations.NotNullAttribute()] string sConditionName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> MakeFlag_NotNull<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> prop, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TTarget> OfType<TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IUntypedProperty propSource, JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TTarget> Select<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> propSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string comment, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FSelect) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TTarget> Select<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> propSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string comment, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, TSource, TTarget> FSelect) { }
        public static void SetValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, TValue value, object cookie = null) { }
        public static void SetValueUnderLifetime<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifeOuter, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, TValue> FCreateValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Type TryGetPropertyType([JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        [System.ObsoleteAttribute(@"Very questionable behavior in terms of how a wait should be done on various threads. Seems very domain-specific here. Also missing documentation. Also, valuecondition parameter is not nice because it's more property-style to first call Select() to make it a valid boolean.")]
        public static bool WaitForValue<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<T> property, JetBrains.DataFlow.OuterLifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<T> valueCondition, int waitIntervalBetweenChecksMillis = 100) { }
        public static void WhenFalse([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<bool> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime> FHandler) { }
        public static void WhenNotNull<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<T> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, T> FHandler)
            where T :  class { }
        public static void WhenTrue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<bool> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime> FHandler) { }
    }
    public class static IPropertyEx_ObsoleteWithoutLifetime
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> converter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] string prefix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable LogChanges<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] object logprefix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use ForEachValue overload with lifetime.")]
        public static System.IDisposable PushForEachValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, System.IDisposable> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use SetValue overload with lifetime.")]
        public static System.IDisposable PushValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use SetValue overload with lifetime.")]
        public static System.IDisposable PushValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, TValue value) { }
    }
    public class static IPropertySignalEx
    {
        public static void Advise_FallingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_FallingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_FallingFrontHasNew([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<bool>> signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        public static void Advise_HasNew<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_HasNew<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_HasOld<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_HasOld<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_NewNotNull<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_NewNotNull<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_RaisingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_RaisingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> FHandler) { }
        public static void Advise_When<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, TValue valueWhen, [JetBrains.Annotations.NotNullAttribute()] System.Action FHandler) { }
        public static void Advise_When<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, bool> FFilter, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> FHandler) { }
    }
    public class static IPropertySignalEx_ObsoleteWithoutLifetime
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_FallingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_FallingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_FallingFrontHasNew([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<bool>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_HasNew<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_HasNew<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_NoAcknowledgement<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_RaisingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_RaisingFront<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_When<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, bool> filter, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> handler) { }
    }
    public interface ISignal<TValue> : System.IDisposable
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IUntypedSignal AsUntyped { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.PropertyId<TValue> Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<TValue> Property { get; }
        void Advise([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> handler);
        void Fire([JetBrains.Annotations.NotNullAttribute()] TValue value);
        void Fire([JetBrains.Annotations.NotNullAttribute()] TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
    }
    public class static ISignalEx
    {
        public static void Advise<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        public static void Advise_InOut<TIn, TOut>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<TIn, TOut>> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<TIn, TOut> F) { }
        public static void BeginFire([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISimpleSignal thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher) { }
        public static void BeginFire<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue value) { }
        public static void BeginFire<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        public static TValue Fire<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.OutEventArgs<TValue>> thіs) { }
        public static TOut FireInOut<TIn, TOut>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<TIn, TOut>> thіs, TIn @in, TOut outDefault) { }
        public static TOut FireInOut<TIn, TOut>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<TIn, TOut>> thіs, TIn @in) { }
        public static void FlowDeferredInto<TSource>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISimpleSignal target) { }
        public static void FlowInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISimpleSignal target) { }
        public static void FlowInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<TValue> target) { }
        public static void FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FConvert) { }
        public static void FlowInto([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISimpleSignal source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISimpleSignal target) { }
        public static void LogFirings<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string prefix) { }
        public static void LogFirings<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] object logprefix) { }
        public static void LogFirings<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
    }
    public class static ISignalEx_ObsoleteWithoutLifetime
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] System.Action handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> handler) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable Advise_InOut<TIn, TOut>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<TIn, TOut>> signal, [JetBrains.Annotations.NotNullAttribute()] System.Func<TIn, TOut> F) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static void BeginFire([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISimpleSignal signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static void BeginFire<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue value) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static void BeginFire<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, TValue value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowDeferredInto<TSource>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISimpleSignal target) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISimpleSignal target) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<TValue> target) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> converter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static System.IDisposable FlowInto([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISimpleSignal source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISimpleSignal target) { }
    }
    public interface ISimpleSignal : JetBrains.DataFlow.ISignal<bool>, System.IDisposable
    {
        void Fire();
    }
    public interface IUntypedProperty : System.IDisposable
    {
        object AsTyped { get; }
        JetBrains.DataFlow.IUntypedSignal BeforeChange { get; }
        JetBrains.DataFlow.IUntypedSignal Change { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.PropertyId Id { get; }
        bool IsNullValueAllowed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Type PropertyType { get; }
        [System.ObsoleteAttribute("Bind to the property lifetime.")]
        public event System.EventHandler Disposed;
        object GetValue([JetBrains.Annotations.CanBeNullAttribute()] object cookie);
        bool SetValue(object value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
    }
    public interface IUntypedPropertyBag
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IDictionaryEvents<JetBrains.DataFlow.PropertyId, JetBrains.DataFlow.IUntypedProperty> Properties { get; }
        bool Contains([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id);
        [JetBrains.Annotations.CanBeNullAttribute()]
        object Get([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IUntypedProperty GetOrCreateProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id, object defaultvalue, System.Nullable<bool> isNullValueAllowed);
        bool Remove([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id);
        void Set([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id, [JetBrains.Annotations.CanBeNullAttribute()] object value);
        bool TryGet([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id, [JetBrains.Annotations.CanBeNullAttribute()] out object value);
        [JetBrains.Annotations.CanBeNullAttribute()]
        object TryGet([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId id);
    }
    public interface IUntypedSignal : System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Type ArgumentType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.PropertyId Id { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IUntypedProperty Property { get; }
        void Advise([JetBrains.Annotations.NotNullAttribute()] System.Action<object> handler, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime);
        void Fire([JetBrains.Annotations.NotNullAttribute()] object value, [JetBrains.Annotations.CanBeNullAttribute()] object cookie);
    }
    public interface IViewable<TValue>
    
    {
        void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, TValue> viewer);
    }
    public sealed class Lifetime
    {
        public bool IsTerminated { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddAction([JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddBracket([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action FOpening, [JetBrains.Annotations.NotNullAttribute()] System.Action FClosing) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddDispose([JetBrains.Annotations.NotNullAttribute()] System.IDisposable item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddRef([JetBrains.Annotations.NotNullAttribute()] object @object) { }
    }
    public sealed class LifetimeDefinition
    {
        public bool IsTerminated { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public void Terminate() { }
    }
    public class static LifetimeEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Pass lifetime to function instead of disposing of its result. If you really have " +
            "to, use AddDispose().")]
        public static JetBrains.DataFlow.Lifetime Add(this JetBrains.DataFlow.Lifetime thіs, [JetBrains.Annotations.NotNullAttribute()] System.IDisposable item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Pass lifetime to function instead of disposing of its result. If you really have " +
            "to, use AddDispose().")]
        public static JetBrains.DataFlow.Lifetime Add(this JetBrains.DataFlow.Lifetime thіs, params System.IDisposable[] items) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime AddDispose([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Lifetime thіs, [JetBrains.Annotations.NotNullAttribute()] params System.IDisposable[] items) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime AssertEverTerminated([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Lifetime thіs, [JetBrains.Annotations.NotNullAttribute()] string identity) { }
        public static void AssertIsAlive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.OuterLifetime thіs) { }
        public static void AssertIsAlive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Lifetime thіs) { }
        public static void AssertIsAlive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.LifetimeDefinition thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.LifetimeDefinition EnsureEverTerminated_FreeThreaded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.LifetimeDefinition thіs, [JetBrains.Annotations.NotNullAttribute()] string identity) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.LifetimeDefinition EnsureEverTerminated_SingleThreaded([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.LifetimeDefinition thіs, [JetBrains.Annotations.NotNullAttribute()] string identity) { }
        public static void LogAssertIsAlive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.OuterLifetime thіs) { }
        public static void LogAssertIsAlive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Lifetime thіs) { }
        public static void LogAssertIsAlive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.LifetimeDefinition thіs) { }
    }
    public class static Lifetimes
    {
        public static readonly string AnonymousLifetimeId;
        [System.ObsoleteAttribute("Use Define() or Using(), or even better get your lifetime from your owner.")]
        public static JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Create() { }
        [System.ObsoleteAttribute("Use Define() or Using(), or even better get your lifetime from your owner.")]
        public static JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Create(bool finalize) { }
        [System.ObsoleteAttribute("Specify explicitly whether you\'d like to assert that this lifetime is ever termin" +
            "ated. In most cases, this overload was used by mistake. Use Define().")]
        public static JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Create(string id) { }
        [System.ObsoleteAttribute("Use Define(), or even better get your lifetime from your owner. If you would like" +
            " to assert termination, call EnsureEverTerminated on the lifetime.")]
        public static JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Create(string id, bool finalize) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use Define().")]
        public static JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime CreateAtomic([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime> FAtomic) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Will be replaced with CreateIntersection2 so that you\'d be thinking of who termin" +
            "ates the intersection lifetime.")]
        public static JetBrains.DataFlow.Lifetime CreateIntersection([JetBrains.Annotations.NotNullAttribute()] params JetBrains.DataFlow.Lifetime[] lifetimes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.LifetimeDefinition CreateIntersection2([JetBrains.Annotations.NotNullAttribute()] params JetBrains.DataFlow.Lifetime[] lifetimes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.LifetimeDefinition CreateIntersection2([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.DataFlow.Lifetime[] lifetimes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.LifetimeDefinition Define([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] string id = null, [JetBrains.Annotations.CanBeNullAttribute()] [JetBrains.Annotations.InstantHandleAttribute()] System.Action<JetBrains.DataFlow.LifetimeDefinition, JetBrains.DataFlow.Lifetime> FAtomic = null, JetBrains.Util.ILogger logger = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Pass in the parent lifetime.")]
        public static JetBrains.DataFlow.LifetimeDefinition Define([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.LifetimeDefinition, JetBrains.DataFlow.Lifetime> FAtomic) { }
        public static void Synchronize([JetBrains.Annotations.NotNullAttribute()] params JetBrains.DataFlow.LifetimeDefinition[] definitions) { }
        public static void Using([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime> F) { }
        public static TRetVal Using<TRetVal>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.DataFlow.Lifetime, TRetVal> F) { }
    }
    public class static ListBridge
    {
        public static JetBrains.DataFlow.ListBridge<TSource, TTarget> BridgeInto<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IListEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> funcConverter = null, System.Func<TSource, bool> funcFilter = null, JetBrains.DataFlow.ListBridge.MappingInfo mappinginfo = 0, object cookie = null) { }
        public enum MappingInfo
        {
            None = 0,
            TwoWay = 1,
        }
    }
    public class ListBridge<TSource, TTarget>
    
    
    {
        public ListBridge([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IListEvents<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> funcConverter, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, bool> funcFilter, JetBrains.DataFlow.ListBridge.MappingInfo mappinginfo, [JetBrains.Annotations.CanBeNullAttribute()] object oTaregtModificationCookie) { }
        public bool HaveMappingInfo { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IDictionary<TSource, TTarget> MapSourceToTarget { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IDictionary<TTarget, TSource> MapTargetToSource { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.IListEvents<TSource> Source { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.IListEvents<TTarget> Target { get; }
    }
    public class ListEvents<TValue> : JetBrains.DataFlow.CollectionEvents<TValue>, JetBrains.DataFlow.ICollectionEvents<TValue>, JetBrains.DataFlow.IListEvents<TValue>, JetBrains.DataFlow.IViewable<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.Generic.IList<TValue>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.INotifyPropertyChanged, System.Windows.Markup.IAddChild
    
    {
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> storage, bool bUniqueItems, JetBrains.Util.ILogger logger = null) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> storage, bool bUniqueItems) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> storage, bool bUniqueItems) { }
        public ListEvents(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> storage, bool bUniqueItems) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] string id, bool bUniqueItems) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> id, bool bUniqueItems) { }
        public ListEvents([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, bool bUniqueItems) { }
        protected ListEvents(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<TValue>> AddRemove { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforeAddRemoveIndexEventArgs<TValue>> BeforeAddRemove { get; }
        public TValue this[int index] { get; set; }
        protected void FireAddRemove(JetBrains.DataFlow.AddRemove action, TValue value, int index, object cookie) { }
        protected bool FireBeforeAddRemove(JetBrains.DataFlow.AddRemove action, TValue value, int index, object cookie) { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public int IndexOf(TValue item) { }
        public void Insert(int index, TValue item) { }
        protected virtual bool InternalAdd(TValue value, int index, object cookie) { }
        protected override bool InternalAdd(TValue value, object cookie) { }
        protected virtual bool InternalRemove(int index, object cookie) { }
        protected override bool InternalRemove(TValue value, object cookie) { }
        public bool Modify(JetBrains.DataFlow.AddRemove action, TValue item, int index, object cookie) { }
        public bool Modify(JetBrains.DataFlow.AddRemove action, System.Func<TValue> funcGetItemIfAdding, int index, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        public void RemoveAt(int index) { }
    }
    public class static ManualProperty
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> setter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> setter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] string id, TValue initialvalue, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> setter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, TValue initialvalue, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> setter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> getter, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> setter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> getter, [JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> setter) { }
    }
    public enum MarshallingBehaviors
    {
        QueueAlways = 0,
        QueueIfNeeded = 1,
    }
    public class MarshallingPropertyBinding<TSource, TTarget> : JetBrains.DataFlow.PropertyBinding<TSource, TTarget>
    
    
    {
        public MarshallingPropertyBinding(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, JetBrains.DataFlow.IProperty<TSource> source, JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction, System.Func<TSource, TTarget> delegateSourceToTarget, System.Func<TTarget, TSource> delegateTargetToSource) { }
        public MarshallingPropertyBinding(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.JetDispatcher dispatcher, JetBrains.DataFlow.IProperty<TSource> source, JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction) { }
        public MarshallingPropertyBinding(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.JetDispatcher dispatcher, JetBrains.DataFlow.IProperty<TSource> source, JetBrains.DataFlow.IProperty<TTarget> target, System.Func<TSource, TTarget> delegateSourceToTarget, System.Func<TTarget, TSource> delegateTargetToSource) { }
        public MarshallingPropertyBinding(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.JetDispatcher dispatcher, JetBrains.DataFlow.IProperty<TSource> source, JetBrains.DataFlow.IProperty<TTarget> target, System.Func<TSource, TTarget> delegateSourceToTarget) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        public JetBrains.DataFlow.MarshallingBehaviors MarshallingBehavior { get; set; }
        public override void CopySourceToTarget() { }
        public override void CopyTargetToSource() { }
    }
    public class NullProperty<TValue>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.DataFlow.IProperty<TValue> Instance;
    }
    [System.ObsoleteAttribute("Lifetime and LifetimeDefinition are now separated.")]
    public sealed class ObsoleteLifetimeAndDefinitionAtTheSameTime : System.IDisposable
    {
        public readonly JetBrains.DataFlow.Lifetime Lifetime;
        public readonly JetBrains.DataFlow.LifetimeDefinition LifetimeDefinition;
        public ObsoleteLifetimeAndDefinitionAtTheSameTime([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.LifetimeDefinition lifetimeDefinition) { }
        public bool IsEmpty { get; }
        public bool IsTerminated { get; }
        [System.ObsoleteAttribute("Pass lifetime to function instead of disposing of its result. If you really have " +
            "to, use AddDispose().")]
        public JetBrains.DataFlow.Lifetime Add(params System.IDisposable[] disposables) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddAction([JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddBracket([JetBrains.Annotations.NotNullAttribute()] System.Action opening, [JetBrains.Annotations.NotNullAttribute()] System.Action closing) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime AddDispose([JetBrains.Annotations.NotNullAttribute()] System.IDisposable item) { }
        public JetBrains.DataFlow.Lifetime AddRef([JetBrains.Annotations.NotNullAttribute()] object @object) { }
        public void Dispose() { }
        public void Terminate() { }
    }
    public class static ObsoleteLifetimeEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use Lifetimes.Define passing the outer lifetime as a parent lifetime.")]
        public static JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime OpenNested(this JetBrains.DataFlow.Lifetime thіs) { }
    }
    public struct OuterLifetime
    {
        public bool IsTerminated { get; }
    }
    public class OutEventArgs<TOut> : System.EventArgs
    
    {
        public OutEventArgs(TOut @out) { }
        public OutEventArgs() { }
        public TOut Out { get; set; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("Value")]
    public sealed class Property<TValue> : JetBrains.DataFlow.IHaveUntypedProperty, JetBrains.DataFlow.IProperty<TValue>, JetBrains.DataFlow.IUntypedProperty, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ICloneable, System.IDisposable
    
    {
        public Property([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string id) { }
        public Property([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string id) { }
        public Property([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] JetBrains.DataFlow.PropertyId<TValue> id, TValue value) { }
        public Property([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string id, TValue value) { }
        public Property([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string id, TValue value) { }
        public Property([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> id, TValue value, System.Nullable<bool> isNullValueAllowed, JetBrains.Util.ILogger logger = null) { }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.BeforePropertyChangedEventArgs<TValue>> BeforeChange { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.DataFlow.PropertyChangedEventArgs<TValue>> Change { get; }
        public JetBrains.DataFlow.PropertyId<TValue> Id { get; }
        public bool IsNullValueAllowed { get; }
        public TValue Value { get; set; }
        public event System.EventHandler Disposed;
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        public object Clone() { }
        public TValue GetValue() { }
        public TValue GetValue(object cookie) { }
        public bool SetValue(TValue value) { }
        public bool SetValue(TValue value, object cookie) { }
        public override string ToString() { }
    }
    public class PropertyBag : JetBrains.DataFlow.IPropertyBag, JetBrains.DataFlow.IUntypedPropertyBag
    {
        public PropertyBag([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.ILogger logger = null) { }
        public JetBrains.DataFlow.IDictionaryEvents<JetBrains.DataFlow.PropertyId, JetBrains.DataFlow.IUntypedProperty> Properties { get; }
        public bool Contains<T>(JetBrains.DataFlow.PropertyId<T> id) { }
        public T Get<T>(JetBrains.DataFlow.PropertyId<T> id) { }
        public JetBrains.DataFlow.IProperty<T> GetOrCreateProperty<T>(JetBrains.DataFlow.PropertyId<T> id, T defaultvalue, System.Nullable<bool> isNullValueAllowed) { }
        public JetBrains.DataFlow.IProperty<T> GetProperty<T>(JetBrains.DataFlow.PropertyId<T> id) { }
        public bool Remove<T>(JetBrains.DataFlow.PropertyId<T> id) { }
        public void Set<T>(JetBrains.DataFlow.PropertyId<T> id, T value) { }
        public bool TryGet<T>(JetBrains.DataFlow.PropertyId<T> id, out T value) { }
        public T TryGet<T>(JetBrains.DataFlow.PropertyId<T> id) { }
    }
    public class static PropertyBinding
    {
        public static readonly JetBrains.DataFlow.Property<bool> False;
        public static readonly JetBrains.DataFlow.Property<bool> True;
        public static readonly JetBrains.DataFlow.Property<int> Zero;
        public static void Create2<TSource1, TSource2, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource1> source1, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource2> source2, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource1, TSource2, TTarget> FConvert, object token = null) { }
        public static void Create3<TSource1, TSource2, TSource3, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource1> source1, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource2> source2, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource3> source3, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource1, TSource2, TSource3, TTarget> FConvert, object token = null) { }
        public static void Create4<TSource1, TSource2, TSource3, TSource4, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource1> source1, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource2> source2, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource3> source3, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource4> source4, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource1, TSource2, TSource3, TSource4, TTarget> FConvert, object token = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static JetBrains.DataFlow.IProperty<bool> CreateAnd([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcA, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcB) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> CreateAnd([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcA, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcB) { }
        public static void CreateAndMultibinding([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcA, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcB, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> dst) { }
        public static void CreateBidirectional<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FConvertSourceToTarget, [JetBrains.Annotations.NotNullAttribute()] System.Func<TTarget, TSource> FConvertTargetToSource) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("For from-source bindings, use source.FlowInto(target). For others, use overload w" +
            "ith lifetime.")]
        public static JetBrains.DataFlow.PropertyBinding<TSource, TTarget> CreateBidirectional<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target) { }
        public static void CreateBidirectional<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target) { }
        public static void CreateBidirectional<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject targetobject, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty targetproperty, bool isVarianceAllowed = False) { }
        public static void CreateBidirectional<TSource, TTarget>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyObject targetobject, [JetBrains.Annotations.NotNullAttribute()] System.Windows.DependencyProperty targetproperty, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TTarget> FConvertSourceToTarget, [JetBrains.Annotations.NotNullAttribute()] System.Func<TTarget, TSource> FConvertTargetToSource) { }
        public static void CreateCascading<TSourceOwner, TSource, TTarget>(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TSourceOwner> sourceowner, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSourceOwner, JetBrains.DataFlow.IProperty<TSource>> FGetSourceFromOwner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> propSourceWhenNoOwner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction)
            where TSourceOwner :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> CreateIsNotNull<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<T> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> CreateIsNull<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<T> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> CreateNot([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<bool> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<bool> CreateOr([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcA, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcB) { }
        public static void CreateOrMultibinding([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcA, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> srcB, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> dst) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Null<TValue>() { }
    }
    public class PropertyBinding<TSource, TTarget> : JetBrains.DataFlow.IPropertyBinding, JetBrains.DataFlow.IPropertyBinding<TSource, TTarget>, System.IDisposable
    
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Func<TSource, TTarget> myConverterSourceToTarget;
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Func<TTarget, TSource> myConverterTargetToSource;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.DataFlow.Property<JetBrains.DataFlow.DataFlowDirection> myDirection;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.DataFlow.Property<JetBrains.DataFlow.IProperty<TSource>> mySource;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected object mySourceCookie;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.DataFlow.Property<JetBrains.DataFlow.IProperty<TTarget>> myTarget;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected object myTargetCookie;
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public PropertyBinding([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget) { }
        public PropertyBinding([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public PropertyBinding([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TTarget, TSource> delegateTargetToSource) { }
        public PropertyBinding([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TTarget, TSource> delegateTargetToSource) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public PropertyBinding([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction) { }
        public PropertyBinding([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public PropertyBinding([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TTarget, TSource> delegateTargetToSource) { }
        public PropertyBinding(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TTarget, TSource> delegateTargetToSource) { }
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public PropertyBinding([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TTarget, TSource> delegateTargetToSource, [JetBrains.Annotations.CanBeNullAttribute()] object oSourceCookie, [JetBrains.Annotations.CanBeNullAttribute()] object oTargetCookie) { }
        public PropertyBinding([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<TTarget> target, JetBrains.DataFlow.DataFlowDirection direction, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, TTarget> delegateSourceToTarget, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TTarget, TSource> delegateTargetToSource, [JetBrains.Annotations.CanBeNullAttribute()] object oSourceCookie, [JetBrains.Annotations.CanBeNullAttribute()] object oTargetCookie) { }
        public JetBrains.DataFlow.DataFlowDirection Direction { get; set; }
        public JetBrains.DataFlow.IProperty<JetBrains.DataFlow.IProperty<TSource>> Source { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object SourceCookie { get; set; }
        public object Tag { get; set; }
        public JetBrains.DataFlow.IProperty<JetBrains.DataFlow.IProperty<TTarget>> Target { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object TargetCookie { get; set; }
        public virtual void CopySourceToTarget() { }
        public virtual void CopyTargetToSource() { }
        public void Dispose() { }
    }
    public class PropertyBindingDeferred<TValue>
    
    {
        public readonly JetBrains.DataFlow.Property<System.TimeSpan> GracePeriod;
        public readonly JetBrains.DataFlow.ISimpleSignal IncomingCommit;
        public readonly JetBrains.DataFlow.Property<bool> IsPending;
        public PropertyBindingDeferred(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> source, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> target, System.TimeSpan graceperiod, [JetBrains.Annotations.CanBeNullAttribute()] object targetcookie = null) { }
        public JetBrains.DataFlow.IProperty<TValue> Source { get; }
        public JetBrains.DataFlow.IProperty<TValue> Target { get; }
    }
    public class PropertyChangedEventArgs<TValue> : System.EventArgs
    
    {
        protected PropertyChangedEventArgs([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue old, bool hasold, TValue @new, bool hasnew, [JetBrains.Annotations.CanBeNullAttribute()] object cookie) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object Cookie { get; }
        public bool HasNew { get; }
        public bool HasOld { get; }
        public bool IsAcknowledging { get; }
        public TValue New { get; }
        public TValue Old { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Property<TValue> Property { get; }
        public static JetBrains.DataFlow.PropertyChangedEventArgs<TValue> CreateBoth([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue old, TValue @new, object cookie) { }
        public static JetBrains.DataFlow.PropertyChangedEventArgs<TValue> CreateNew([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue @new, object cookie) { }
        public static JetBrains.DataFlow.PropertyChangedEventArgs<TValue> CreateOld([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Property<TValue> property, TValue old, object cookie) { }
    }
    [System.ObsoleteAttribute("remove and use the one-type-param PropertyChangedEventArgs")]
    public class PropertyChangedEventArgs<TIdentity, TValue> : System.EventArgs
    
    
    {
        public PropertyChangedEventArgs([JetBrains.Annotations.CanBeNullAttribute()] TIdentity identity, [JetBrains.Annotations.CanBeNullAttribute()] TValue old, [JetBrains.Annotations.CanBeNullAttribute()] TValue @new) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TIdentity Identity { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TValue New { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TValue Old { get; }
    }
    public class static PropertyChangeEventArgsEx
    {
        public static TValue GetNewOrNull<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.PropertyChangedEventArgs<TValue> args) { }
        public static TValue GetOldOrNull<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.PropertyChangedEventArgs<TValue> args) { }
        public static bool IsRaising([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.PropertyChangedEventArgs<bool> args) { }
    }
    public abstract class PropertyId
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string Id { get; }
        public static JetBrains.DataFlow.PropertyId<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] string id) { }
    }
    public class PropertyId<TValue> : JetBrains.DataFlow.PropertyId, System.IEquatable<JetBrains.DataFlow.PropertyId<TValue>>
    
    {
        public PropertyId([JetBrains.Annotations.NotNullAttribute()] string id) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public override string Id { get; }
        public override bool Equals([JetBrains.Annotations.CanBeNullAttribute()] object obj) { }
        public bool Equals([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> propertyId) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class PropertyValidationException : JetBrains.Util.ValidationException
    {
        public PropertyValidationException([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IUntypedProperty property, [JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.IUntypedProperty Property { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object Value { get; }
    }
    public class static PropertyValidator
    {
        public static void CreateEnumValidator<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static void CreateMaximumValidator<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, TValue max)
            where TValue : System.IComparable<> { }
        public static void CreateMinimumValidator<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, TValue min)
            where TValue : System.IComparable<> { }
        public static void CreateNotEmptyValidator([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<string> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static void CreateReadonlyValidator<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        public static void CreateThreadAffinityValidator<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread) { }
        public static void CreateThreadAffinityValidator<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher) { }
        public static void Freeze<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] string message = "The property has been frozen.") { }
        public static void Freeze<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string message = "The property has been frozen.") { }
    }
    public class static PropertyValidatorFluent
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> CoerceToRange<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, TValue min, TValue max)
            where TValue : System.IComparable<> { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureEnum<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> EnsureEnum<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureInitonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureNotAbove<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, TValue max)
            where TValue : System.IComparable<> { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureNotBelow<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, TValue min)
            where TValue : System.IComparable<> { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureNotOutside<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, TValue min, TValue max)
            where TValue : System.IComparable<> { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Property<TValue> EnsureThisThread<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.Property<TValue> property) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> EnsureThisThread<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IProperty<TValue> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class static RegistryValueProperty
    {
        public static JetBrains.DataFlow.IProperty<TValue> CreatePassive<TValue>([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.Win32.RegistryKey keyRoot, [JetBrains.Annotations.NotNullAttribute()] string sKeyPath, [JetBrains.Annotations.CanBeNullAttribute()] string sDataName, TValue defvalue) { }
    }
    public class SequentialLifetimes
    {
        public SequentialLifetimes([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public void DefineNext([JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.LifetimeDefinition, JetBrains.DataFlow.Lifetime> FNext) { }
        public void Next([JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime> FNext) { }
        public void TerminateCurrent() { }
    }
    public class Signal<TValue> : JetBrains.DataFlow.ISignal<TValue>, JetBrains.DataFlow.IUntypedSignal, JetBrains.DataFlow.StandardPreconditions.IReadOnlyPrecondition, JetBrains.DataFlow.StandardPreconditions.IStandardPrecondition, JetBrains.DataFlow.StandardPreconditions.IThreadAffinityPrecondition, System.IDisposable
    
    {
        protected JetBrains.Util.Concurrency.SpinWaitLock myLock;
        public Signal([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public Signal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id) { }
        public Signal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<TValue> id, JetBrains.Util.ILogger logger = null) { }
        [System.ObsoleteAttribute("Support for signals-over-properties will be dropped.")]
        public Signal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<TValue> property) { }
        public JetBrains.DataFlow.PropertyId<TValue> Id { get; }
        public JetBrains.DataFlow.IProperty<TValue> Property { get; }
        public void Advise(JetBrains.DataFlow.Lifetime lifetime, System.Action<TValue> handler) { }
        [System.ObsoleteAttribute("Pass in a lifetime; will be made non-idisposable.")]
        public void Dispose() { }
        public void Fire(TValue value) { }
        public void Fire(TValue value, object cookie) { }
        protected virtual void OnAfterAdvise([JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> handler) { }
        protected virtual void OnAfterUnadvise([JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> handler) { }
        protected virtual bool OnBeforeAdvise([JetBrains.Annotations.NotNullAttribute()] System.Action<TValue> handler) { }
        public override string ToString() { }
    }
    public class static SignalValidator
    {
        public static JetBrains.DataFlow.ISignal<TValue> EnsureReadonly<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.SimpleSignal EnsureReadonly([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.SimpleSignal signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token) { }
        public static JetBrains.DataFlow.ISignal<TValue> EnsureThisThread<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.ISignal<TValue> signal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.SimpleSignal EnsureThisThread([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.SimpleSignal signal, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public sealed class SimpleSignal : JetBrains.DataFlow.Signal<bool>, JetBrains.DataFlow.ISignal<bool>, JetBrains.DataFlow.ISimpleSignal, System.IDisposable
    {
        public SimpleSignal([JetBrains.Annotations.NotNullAttribute()] string id) { }
        public SimpleSignal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id) { }
        public SimpleSignal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.PropertyId<bool> id, JetBrains.Util.ILogger logger = null) { }
        public void Fire() { }
    }
    [System.ObsoleteAttribute("Use SequentialLifetimes.")]
    public class SingleDisposable : System.IDisposable
    {
        public SingleDisposable() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.SingleDisposable Clear() { }
        public void Dispose() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.SingleDisposable Put([JetBrains.Annotations.NotNullAttribute()] System.IDisposable @new) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.SingleDisposable Put([JetBrains.Annotations.NotNullAttribute()] System.Func<System.IDisposable> funcNew) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.SingleDisposable PutBracket([JetBrains.Annotations.NotNullAttribute()] System.Action FEnter, [JetBrains.Annotations.NotNullAttribute()] System.Action FLeave) { }
    }
    public class static StackTraceUtil
    {
        public static readonly string NoStackTraceMessage;
        public static bool OptionCaptureStackTraces;
        public static string CaptureAndFormatStackTrace(bool bObeyOptionCaptureStackTraces) { }
        public static string CaptureAndFormatStackTrace() { }
        public static System.Diagnostics.StackFrame[] CaptureStackTrace(bool bObeyOptionCaptureStackTraces) { }
        public static string GetCallerMethodName() { }
        public static string StackFramesToString(params System.Diagnostics.StackFrame[] frames) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.RichText.RichText StackFrameToRichString([JetBrains.Annotations.NotNullAttribute()] System.Diagnostics.StackFrame frame) { }
    }
    public class static Viewable
    {
        public static void MapMany<TKey, TValue, TCollection>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Func<TValue, System.Collections.Generic.IEnumerable<TKey>> keySelector, JetBrains.Util.IOneToManyMap<TKey, TValue, TCollection> dictionary)
        
        
            where TCollection : System.Collections.Generic.ICollection<> { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IViewable<TItem> SelectMany<TItemsProvider, TItem>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DataFlow.IViewable<TItemsProvider> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Func<TItemsProvider, JetBrains.DataFlow.IViewable<TItem>> FGetItemsFromProvider) { }
        public static System.Collections.Generic.IDictionary<TKey, TValue> ToLiveDictionary<TKey, TValue>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Func<TValue, TKey> keySelector) { }
        public static System.Collections.Generic.IEnumerable<TValue> ToLiveEnumerable<TValue>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime) { }
        public static System.Collections.Generic.ICollection<TResult> ToLiveEnumerable<TValue, TResult>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Func<TValue, TResult> projection) { }
        public static System.Collections.Generic.JetHashSet<TResult> ToLiveHashSet<TValue, TResult>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Func<TValue, System.Collections.Generic.IEnumerable<TResult>> keySelector) { }
        public static System.Collections.Generic.JetHashSet<TResult> ToLiveHashSet<TValue, TResult>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Func<TValue, TResult> selector) { }
        public static System.Collections.Generic.List<TValue> ToLiveList<TValue>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime) { }
        public static System.Collections.Generic.IEnumerable<T> ToLiveOrderedEnumerable<T>(this JetBrains.DataFlow.IViewable<T> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Comparison<T> comparer) { }
        public static System.Collections.Generic.IEnumerable<T> ToLiveOrderedEnumerable<T, TAttribute>(this JetBrains.DataFlow.IViewable<T> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Comparison<TAttribute> comparer)
        
            where TAttribute : System.Attribute { }
        public static System.Collections.Generic.IEnumerable<T> ToLiveTopoOrderedEnumerable<T>(this JetBrains.DataFlow.IViewable<T> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Func<T, T, System.Nullable<int>> comparer) { }
        public static void View<TValue>(this JetBrains.DataFlow.IViewable<TValue> viewable, JetBrains.DataFlow.Lifetime lifetime, System.Action<TValue> entered, System.Action<TValue> leaving) { }
    }
    public class ViewableCollection<TValue> : JetBrains.DataFlow.IViewable<TValue>, System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.DataFlow.ViewableCollection<TValue> Empty;
        public ViewableCollection(JetBrains.DataFlow.Lifetime lifetime) { }
        public ViewableCollection(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.ICollection<TValue> collection) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(TValue item) { }
        public void Add(JetBrains.DataFlow.Lifetime lifetime, TValue item) { }
        public void AddRange(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<TValue> items) { }
        public void Clear() { }
        public bool Contains(TValue item) { }
        public void CopyTo(TValue[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }
        public bool Remove(TValue item) { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, TValue> viewer) { }
    }
    public class static WinFormsProperty
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TSource, TValue>(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] TSource source, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> propertyExpression, bool sinkEvents)
            where TSource :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TSource, TValue>([JetBrains.Annotations.NotNullAttribute()] TSource source, [JetBrains.Annotations.NotNullAttribute()] System.Linq.Expressions.Expression<System.Func<TSource, TValue>> propertyExpression, bool sinkEvents)
            where TSource :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use strong-typed overload with lifetime.")]
        public static JetBrains.DataFlow.IProperty<TValue> Create<TValue>([JetBrains.Annotations.NotNullAttribute()] object source, [JetBrains.Annotations.NotNullAttribute()] string propertyName, bool sinkEvents) { }
    }
}
namespace JetBrains.DataFlow.Infra
{
    
    public sealed class SignalWithDelegates<TValue> : JetBrains.DataFlow.Signal<TValue>
    
    {
        public SignalWithDelegates([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
        public System.Action<System.Action<TValue>> AfterAdviseHandler { get; set; }
        public System.Action<System.Action<TValue>> AfterUnadviseHandler { get; set; }
        public System.Func<System.Action<TValue>, bool> BeforeAdviseHandler { get; set; }
        protected override void OnAfterAdvise(System.Action<TValue> handler) { }
        protected override void OnAfterUnadvise(System.Action<TValue> handler) { }
        protected override bool OnBeforeAdvise(System.Action<TValue> handler) { }
    }
}
namespace JetBrains.DataFlow.StandardPreconditions
{
    
    public interface IReadOnlyPrecondition : JetBrains.DataFlow.StandardPreconditions.IStandardPrecondition
    {
        void LockReadOnly([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.StandardPreconditions.ReadonlyToken token);
    }
    public interface IStandardPrecondition { }
    public interface IThreadAffinityPrecondition : JetBrains.DataFlow.StandardPreconditions.IStandardPrecondition
    {
        void AffineToThread([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread);
    }
    public class ReadonlyToken
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string Info;
        public ReadonlyToken([JetBrains.Annotations.NotNullAttribute()] string info) { }
        public override string ToString() { }
    }
    public class static StandardPreconditionOptions
    {
        public static bool UseStandardPreconditionsInHelperMethods;
    }
}
namespace JetBrains.DataStructures
{
    
    public class CyclicBuffer : System.Collections.Generic.ICollection<byte>, System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable
    {
        public CyclicBuffer() { }
        public int Capacity { get; set; }
        public int Count { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataStructures.CyclicBuffer.InputStream Input { get; }
        public bool IsReadOnly { get; }
        public JetBrains.DataStructures.CyclicBuffer.OutputStream Output { get; }
        public void Add(byte item) { }
        public void Clear() { }
        public bool Contains(byte item) { }
        public void CopyTo([JetBrains.Annotations.NotNullAttribute()] byte[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<byte> GetEnumerator() { }
        public bool Remove(byte item) { }
        public class InputStream : System.IO.Stream
        {
            public JetBrains.DataStructures.CyclicBuffer.InputStream.BehaviorFlags Behavior { get; set; }
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
            [System.FlagsAttribute()]
            public enum BehaviorFlags
            {
                WhenFullGrow = 0,
                WhenFullThrow = 1,
            }
        }
        public class OutputStream : System.IO.Stream
        {
            public JetBrains.DataStructures.CyclicBuffer.OutputStream.BehaviorFlags Behavior { get; set; }
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
            [System.FlagsAttribute()]
            public enum BehaviorFlags
            {
                WhenEmptyReadLess = 0,
                WhenEmptyThrow = 1,
            }
        }
    }
    public class static ImmutableArray
    {
        public static JetBrains.DataStructures.ImmutableArray<T> Create<T>(System.Collections.Generic.IEnumerable<T> enumerable) { }
        public static JetBrains.DataStructures.ImmutableArray<T> Create<T>(System.Collections.Generic.ICollection<T> col) { }
        public static JetBrains.DataStructures.ImmutableArray<T> Create<T>(JetBrains.DataStructures.IReadOnlyCollection<T> col) { }
        public static JetBrains.DataStructures.ImmutableArray<T> FromArguments<T>(params T[] array) { }
        public static JetBrains.DataStructures.ImmutableArray<T> ToImmutableArray<T>(this System.Collections.Generic.IEnumerable<T> enumerable) { }
        public static JetBrains.DataStructures.ImmutableArray<T> ToImmutableArray<T>(this System.Collections.Generic.ICollection<T> enumerable) { }
        public static JetBrains.DataStructures.ImmutableArray<T> ToImmutableArray<T>(this JetBrains.DataStructures.IReadOnlyCollection<T> enumerable) { }
    }
    public sealed class ImmutableArray<T> : JetBrains.DataStructures.IReadOnlyCollection<T>, JetBrains.DataStructures.IReadOnlyList<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<JetBrains.DataStructures.ImmutableArray<T>>
    
    {
        public ImmutableArray(System.Collections.Generic.IEnumerable<T> data) { }
        public ImmutableArray(System.Collections.Generic.ICollection<T> col) { }
        public ImmutableArray(JetBrains.DataStructures.IReadOnlyCollection<T> col) { }
        public int Count { get; }
        public static JetBrains.DataStructures.ImmutableArray<T> Empty { get; }
        public bool IsEmpty { get; }
        public T this[int index] { get; }
        public bool Contains(T value) { }
        public bool Equals(JetBrains.DataStructures.ImmutableArray<T> other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public override int GetHashCode() { }
        public int IndexOf(T value) { }
    }
    public interface IReadOnlyCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        int Count { get; }
        bool Contains(T value);
    }
    public interface IReadOnlyList<T> : JetBrains.DataStructures.IReadOnlyCollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        T this[int index] { get; }
        int IndexOf(T value);
    }
    public class static StreamPipe
    {
        public static void Run([JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> funcWriter, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> funcReader) { }
        public class BufferEventArgs : System.EventArgs
        {
            public BufferEventArgs([JetBrains.Annotations.NotNullAttribute()] byte[] buffer, int offset, int count) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public byte[] Buffer { get; }
            public int Count { get; }
            public int Offset { get; }
        }
        public class StreamPipeRun : System.IDisposable
        {
            public readonly JetBrains.DataStructures.CyclicBuffer Buffer;
            public static readonly int MinDemandDefault;
            public StreamPipeRun([JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> funcWriter, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> funcReader) { }
            public int MinDemand { get; set; }
            public void Dispose() { }
            public void Run() { }
        }
    }
    public class static StreamPipeXml
    {
        public static void Run([JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlWriter> FInput, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> FOutput) { }
        public static void Run([JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlWriter> FInput, System.Action<System.Xml.XmlReader, System.Xml.XmlWriter> FTransform, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> FOutput) { }
    }
}
namespace JetBrains.Extension
{
    
    public class static DateTimeEx
    {
        public static string ToRelativeTime(this System.DateTime dateTime) { }
    }
    public class static ICustomAttributeProviderEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TAttribute GetCustomAttribute<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.ICustomAttributeProvider attributeProvider, bool inherit)
            where TAttribute : System.Attribute { }
        public static JetBrains.Util.Pair<TAttribute, System.Type> GetCustomAttributeFromHierarchy<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this System.Type type)
            where TAttribute : System.Attribute { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TAttribute GetCustomAttributeNoInherit<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.ICustomAttributeProvider attrprovider)
            where TAttribute : System.Attribute { }
        public static System.Collections.Generic.IEnumerable<TAttribute> GetCustomAttributes<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.ICustomAttributeProvider attributeProvider, bool inherit) { }
        public static bool HasCustomAttributeNoInherit<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.ICustomAttributeProvider attrprovider)
            where TAttribute : System.Attribute { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TAttribute TryGetCustomAttributeNoInherit<TAttribute>([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.ICustomAttributeProvider attrprovider)
            where TAttribute : System.Attribute { }
    }
    public class static IWin32WindowEx
    {
        public static System.Drawing.Rectangle GetBounds([JetBrains.Annotations.NotNullAttribute()] this System.Windows.Forms.IWin32Window window) { }
        public static bool IsValidWindow([JetBrains.Annotations.CanBeNullAttribute()] this System.Windows.Forms.IWin32Window thіs) { }
        public static System.IDisposable PushDisable([JetBrains.Annotations.NotNullAttribute()] this System.Windows.Forms.IWin32Window window) { }
    }
    public class static SerializationInfoEx
    {
        public static TValue GetValue<TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Runtime.Serialization.SerializationInfo @this, [JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    public class static StreamEx
    {
        public static void CopyStream([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream input, [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream output, int chunksize = 65536) { }
        public static void DeflateCompress([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Compression.DeflateStream> FWriter) { }
        public static void DeflateDecompress([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Compression.DeflateStream> FReader) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IO.Stream EraseAndRewind([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream thіs) { }
        public static int Read([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] byte[] buffer) { }
        public static string ReadTextFromFile(this System.IO.Stream stream, out System.Text.Encoding detectedEncoding) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IO.Stream Rewind([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream thіs) { }
        public static void StreamReader([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.StreamReader> FRead) { }
        public static void StreamWriter([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.StreamWriter> FWrite) { }
        public static void Write([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] byte[] buffer) { }
    }
    public class static SupportInitializeExtensions
    {
        public static System.IDisposable InitScope([JetBrains.Annotations.NotNullAttribute()] this System.ComponentModel.ISupportInitialize component) { }
    }
    public class static TimeSpanEx
    {
        public static System.TimeSpan Div(this System.TimeSpan timespan, double value) { }
        public static System.TimeSpan Max(System.TimeSpan a, System.TimeSpan b) { }
        public static System.TimeSpan Min(System.TimeSpan a, System.TimeSpan b) { }
        public static System.TimeSpan Mul(this System.TimeSpan timespan, double value) { }
    }
    public class static TypeEx
    {
        public static object CoercePrimitiveValueToType([JetBrains.Annotations.CanBeNullAttribute()] object primitive, [JetBrains.Annotations.NotNullAttribute()] System.Type typeTarget, JetBrains.Util.ILogger logger = null) { }
        public static object GetDefaultValue(this System.Type type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetLocalNameFromFullTypeName([JetBrains.Annotations.NotNullAttribute()] string fullname, bool isKeepingOuterClasses) { }
        public static bool IsDefaultValue([JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        public static bool IsDefaultValue(this System.Type type, [JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        public static bool IsDefaultValueOrEmptyString(this System.Type type, [JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        public static bool IsDefaultValueOrEmptyString([JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string QuoteIfNeeded([JetBrains.Annotations.NotNullAttribute()] this System.Type type) { }
    }
}
namespace JetBrains.Interop.Modules
{
    
    public class static ControlPaint
    {
        public static void PaintStatusBarBackground(System.IntPtr hwnd, [JetBrains.Annotations.NotNullAttribute()] System.Drawing.Graphics g, System.Drawing.Rectangle rectArea, System.Drawing.Rectangle rectClip) { }
    }
}
namespace JetBrains.Reflection
{
    
    public class static ReflectionExtensions
    {
        public static readonly System.Reflection.Assembly Mscorlib;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Linq.Expressions.LambdaExpression CreateFieldAccessExpression<TContainingType>(string fieldName) { }
        public static System.Collections.Generic.IEnumerable<System.Type> GetAllAssignableToTypes([JetBrains.Annotations.NotNullAttribute()] this System.Type type) { }
        public static System.Collections.Generic.IEnumerable<System.Type> GetBaseClassesAndInterfaces([JetBrains.Annotations.NotNullAttribute()] this System.Type type) { }
        public static T GetDynamicField<T>([JetBrains.Annotations.NotNullAttribute()] this object obj, [JetBrains.Annotations.NotNullAttribute()] string sFieldName) { }
        public static object GetDynamicField([JetBrains.Annotations.NotNullAttribute()] this object obj, [JetBrains.Annotations.NotNullAttribute()] string sFieldName, JetBrains.Util.OnError onerror = null) { }
        public static object GetDynamicFieldOrProperty([JetBrains.Annotations.NotNullAttribute()] this object thіs, [JetBrains.Annotations.NotNullAttribute()] string membername) { }
        public static T GetDynamicProperty<T>([JetBrains.Annotations.NotNullAttribute()] this object reflectedObject, [JetBrains.Annotations.NotNullAttribute()] string propertyName, JetBrains.Util.OnError onerror = null) { }
        public static object GetDynamicProperty([JetBrains.Annotations.NotNullAttribute()] this object reflectedObject, [JetBrains.Annotations.NotNullAttribute()] string propertyName, JetBrains.Util.OnError onerror = null) { }
        public static object GetFieldOrPropertyValue(this object host, string fieldName) { }
        public static TValue GetFieldOrPropertyValue<TValue>(this object host, string fieldName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Reflection.MemberInfo GetInstanceMember<TContainingType>([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.Expression<System.Func<TContainingType, object>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Reflection.MemberInfo GetInstanceMember<TContainingType, TMemberValue>([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.Expression<System.Func<TContainingType, TMemberValue>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetInstanceMemberName<TContainingType>([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.Expression<System.Func<TContainingType, object>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetInstanceMemberName<TContainingType, TMemberValue>([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.Expression<System.Func<TContainingType, TMemberValue>> lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetInstanceMemberName([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.LambdaExpression lambdaexpression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetInstanceMembersChain([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.Expression expression) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetStaticMemberName([JetBrains.Annotations.NotNullAttribute()] this System.Linq.Expressions.Expression<System.Func<object>> lambdaexpression) { }
        public static object InvokeDynamicMethod([JetBrains.Annotations.NotNullAttribute()] this object reflectedObject, [JetBrains.Annotations.NotNullAttribute()] string sMethodName, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        public static T InvokeDynamicMethodInfo<T>([JetBrains.Annotations.NotNullAttribute()] this object reflectedObject, [JetBrains.Annotations.NotNullAttribute()] string sMethodName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        public static object InvokeDynamicMethodInfo([JetBrains.Annotations.NotNullAttribute()] this object reflectedObject, [JetBrains.Annotations.NotNullAttribute()] string sMethodName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        public static object ParseInvariantString([JetBrains.Annotations.NotNullAttribute()] string value, [JetBrains.Annotations.NotNullAttribute()] System.Type type, JetBrains.Util.ILogger logger = null) { }
        public static T ParseInvariantString<T>([JetBrains.Annotations.NotNullAttribute()] string value, JetBrains.Util.ILogger logger = null) { }
        public static void SetDynamicFieldOrProperty([JetBrains.Annotations.NotNullAttribute()] this object thіs, [JetBrains.Annotations.NotNullAttribute()] string membername, [JetBrains.Annotations.CanBeNullAttribute()] object value) { }
        public static void SetDynamicProperty([JetBrains.Annotations.NotNullAttribute()] this object reflectedObject, [JetBrains.Annotations.NotNullAttribute()] string propertyName, object value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToInvariantString([JetBrains.Annotations.NotNullAttribute()] object value, JetBrains.Util.ILogger logger = null) { }
    }
    public class static StringConversion
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.ILogger GetSomeLogger([JetBrains.Annotations.CanBeNullAttribute()] this System.ComponentModel.ITypeDescriptorContext thіs) { }
        public static object ParseInvariantString([JetBrains.Annotations.NotNullAttribute()] string value, [JetBrains.Annotations.NotNullAttribute()] System.Type type, JetBrains.Util.ILogger logger = null) { }
        public static T ParseInvariantString<T>([JetBrains.Annotations.NotNullAttribute()] string value, JetBrains.Util.ILogger logger = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToInvariantString([JetBrains.Annotations.NotNullAttribute()] object value, JetBrains.Util.ILogger logger = null) { }
        public class LoggerTypeDescriptorContext : System.ComponentModel.ITypeDescriptorContext, System.IServiceProvider, System.Windows.Markup.IValueSerializerContext
        {
            public LoggerTypeDescriptorContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger) { }
            [JetBrains.Annotations.NotNullAttribute()]
            protected JetBrains.Util.ILogger Logger { get; }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Dependencies
{
    
    public struct Hash
    {
        public static readonly JetBrains.ReSharper.Psi.Dependencies.Hash ZERO;
        public Hash(int value) { }
        public int Value { get; }
        public static JetBrains.ReSharper.Psi.Dependencies.Hash CommutativeMix(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Dependencies.Hash> values) { }
        public override bool Equals(object obj) { }
        public void Finish() { }
        public override int GetHashCode() { }
        public void PutBool(bool b) { }
        public void PutByte(byte b) { }
        public void PutChar(char c) { }
        public void PutHash(JetBrains.ReSharper.Psi.Dependencies.Hash hash) { }
        public void PutInt(int i) { }
        public void PutString(string s) { }
        public static JetBrains.ReSharper.Psi.Dependencies.Hash[] ReadArray(System.IO.BinaryReader reader) { }
        public static JetBrains.ReSharper.Psi.Dependencies.Hash ReadFrom(System.IO.BinaryReader reader) { }
        public override string ToString() { }
        public static void WriteArray(JetBrains.ReSharper.Psi.Dependencies.Hash[] hashes, System.IO.BinaryWriter writer) { }
        [JetBrains.Annotations.PureAttribute()]
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
}
namespace JetBrains.Text
{
    
    public class ArrayBuffer : JetBrains.Text.IBuffer, JetBrains.Text.IEditableBuffer
    {
        public ArrayBuffer([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public ArrayBuffer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buf) { }
        public ArrayBuffer([JetBrains.Annotations.NotNullAttribute()] char[] buf) { }
        public char this[int index] { get; }
        public int Length { get; }
        public void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
        public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length) { }
        public string GetText(JetBrains.Util.TextRange range) { }
        public string GetText(int start, int length) { }
        public string GetText() { }
        public void Insert(int offset, string text) { }
        public void Remove(int offset, int length) { }
        public void Replace(int offset, int length, string newText) { }
        public void Replace(int offset, int length, JetBrains.Text.BufferRange newText) { }
    }
    public struct BufferRange
    {
        public BufferRange(JetBrains.Text.IBuffer buffer, JetBrains.Util.TextRange range) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public JetBrains.Util.TextRange Range { get; }
        public void CopyTo(char[] destinationArray, int destinationIndex) { }
        public string GetText() { }
    }
    public class BufferTextReader : System.IO.TextReader
    {
        public BufferTextReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer) { }
        public override int Peek() { }
        public override int Read() { }
        public override int Read(char[] buffer, int index, int count) { }
        public override string ReadToEnd() { }
    }
    public class static BufferUtil
    {
        public static bool CompareBufferText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Text.IBuffer buffer, JetBrains.Util.TextRange range, [JetBrains.Annotations.CanBeNullAttribute()] string str, bool caseSensitive = True) { }
        public static int IndexOf(this JetBrains.Text.IBuffer buffer, string pattern, int startIndex = 0) { }
        public static int IndexOfAny(this JetBrains.Text.IBuffer buffer, char[] chars, int startIndex = 0) { }
        public static int LastIndexOf(this JetBrains.Text.IBuffer buffer, string pattern, int startIndex = 0) { }
    }
    public interface IBuffer
    {
        char this[int index] { get; }
        int Length { get; }
        void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range);
        void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length);
        string GetText();
        string GetText(JetBrains.Util.TextRange range);
        string GetText(int start, int length);
    }
    public struct IdentifierMatch
    {
        public readonly int FilterIndex;
        public readonly int TextIndex;
        public IdentifierMatch(int filterIndex, int textIndex) { }
    }
    public class IdentifierMatcher
    {
        public IdentifierMatcher(string filterString, JetBrains.Text.IdentifierMatchingStyle matchingStyle, JetBrains.Text.IdentifierMatchingFlags matchingFlags) { }
        public IdentifierMatcher(string filterString, JetBrains.Text.IdentifierMatchingStyle matchingStyle) { }
        public IdentifierMatcher(string filterString) { }
        public string Filter { get; set; }
        public JetBrains.Text.IdentifierMatchingStyle MatchingStyle { get; }
        public static bool IsLower(char c) { }
        public static bool IsUpper(char c) { }
        public bool Matches(string identifier) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Text.IdentifierMatch> MatchingIndicies(string identifier) { }
    }
    public class static IdentifierMatcherUtils
    {
        public static int CalculateScore(string filter, string name, System.Collections.Generic.IEnumerable<JetBrains.Text.IdentifierMatch> matches, bool lowerHumpsAcc = False) { }
        public static int CalculateScore(JetBrains.Text.IdentifierMatcher pattern, string name, bool lowerHumpsAcc = False) { }
        public static bool CalculateScore(string prefix, string name, out int score) { }
    }
    [System.FlagsAttribute()]
    public enum IdentifierMatchingFlags
    {
        None = 0,
        MatchPrefixCaseInsensitive = 1,
        MatchInsideCaseInsensitive = 2,
        MatchPrefixCaseSensitive = 4,
    }
    public enum IdentifierMatchingStyle
    {
        BeginingOfIdentifier = 0,
        EntireIdentifier = 1,
        MiddleOfIdentifier = 2,
        Default = 0,
    }
    public interface IEditableBuffer : JetBrains.Text.IBuffer
    {
        void Insert(int offset, string text);
        void Remove(int offset, int length);
        void Replace(int offset, int length, string newText);
        void Replace(int offset, int length, JetBrains.Text.BufferRange newText);
    }
    public class ProjectedBuffer : JetBrains.Text.IBuffer
    {
        public ProjectedBuffer(JetBrains.Text.IBuffer underlyingBuffer, JetBrains.Util.TextRange range) { }
        public char this[int index] { get; }
        public int Length { get; }
        public void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
        public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length) { }
        public string GetText() { }
        public string GetText(JetBrains.Util.TextRange range) { }
        public string GetText(int start, int length) { }
    }
    public class StringBuffer : JetBrains.Text.IBuffer
    {
        public StringBuffer([JetBrains.Annotations.NotNullAttribute()] string @string) { }
        public char this[int index] { get; }
        public int Length { get; }
        public void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
        public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length) { }
        public string GetText() { }
        public string GetText(JetBrains.Util.TextRange range) { }
        public string GetText(int start, int length) { }
    }
    public class StringBuilderBuffer : JetBrains.Text.IBuffer
    {
        public StringBuilderBuffer([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder @string) { }
        public char this[int index] { get; }
        public int Length { get; }
        public void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
        public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length) { }
        public string GetText() { }
        public string GetText(JetBrains.Util.TextRange range) { }
        public string GetText(int start, int length) { }
    }
    public class static WordUtil
    {
        public static readonly char[] SpaceDelimeters;
        public static JetBrains.Util.TextRange FindRange(JetBrains.Text.IBuffer s, int pos, System.Predicate<char> predicate) { }
        public static JetBrains.Util.TextRange FindWord(JetBrains.Text.IBuffer s, int pos) { }
        public static JetBrains.Util.TextRange FindWordLeft(JetBrains.Text.IBuffer s, int pos) { }
        public static JetBrains.Util.TextRange FindWordOrStopCharLeft(JetBrains.Text.IBuffer s, int pos) { }
        public static JetBrains.Util.TextRange FindWordOrStopCharRight(JetBrains.Text.IBuffer s, int pos) { }
        public static bool IsDelimiter(char c) { }
        public static bool IsDigit(char c) { }
        public static bool IsHexDigit(char c) { }
        public static bool IsLetter(char c) { }
        public static bool IsLower(char c) { }
        public static bool IsLowerOrDigit(char c) { }
        public static bool IsStopChar(char c) { }
        public static bool IsUpper(char c) { }
        public static bool IsUpperOrDigit(char c) { }
        public static bool IsWordChar(char c) { }
    }
}
namespace JetBrains.Threading
{
    
    public sealed class GroupingEvent
    {
        public static readonly System.TimeSpan MaxInterval;
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.GroupingEventHost Host { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ISimpleSignal Incoming { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ISimpleSignal IncomingDontProlongate { get; }
        public System.TimeSpan Interval { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ISimpleSignal Outgoing { get; }
        public void CancelIncoming() { }
        public JetBrains.DataFlow.IProperty<bool> CreateIsWaitingProperty() { }
        public void FireIncoming() { }
        public void FireIncomingDontProlongate() { }
        public bool IsWaiting() { }
        public override string ToString() { }
    }
    public class GroupingEventHost
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.Threading.ReentrancyGuard ReentrancyGuard;
        public GroupingEventHost(JetBrains.DataFlow.Lifetime lifetime, bool isGuarded) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.GroupingEvent CreateEvent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, System.TimeSpan interval, [JetBrains.Annotations.CanBeNullAttribute()] System.Action FFirstHandler = null) { }
    }
    public class GroupingEventHosts
    {
        public GroupingEventHosts(JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.GroupingEventHost this[JetBrains.Threading.Rgc guarding] { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.GroupingEvent CreateEvent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, System.TimeSpan interval, JetBrains.Threading.Rgc guarding, [JetBrains.Annotations.CanBeNullAttribute()] System.Action FFirstHandler) { }
    }
    public sealed class GuardAttribute : System.Attribute
    {
        public GuardAttribute(JetBrains.Threading.Rgc context) { }
        public JetBrains.Threading.Rgc Context { get; }
    }
    public class JetBarrier : JetBrains.Threading.JetBarrier<object, object>
    {
        public JetBarrier(int partiesNumber, System.Action afterAllPartiesFinishedAction) { }
    }
    public class JetBarrier<TIn> : JetBrains.Threading.JetBarrier<TIn, object>
    
    {
        public JetBarrier(int partiesNumber, System.Action<TIn> afterAllPartiesFinishedAction) { }
    }
    public class JetBarrier<TIn, TOut>
    
    
    {
        public JetBarrier(int partiesNumber, System.Action afterAllPartiesFinishedAction) { }
        public JetBarrier(int partiesNumber, System.Action<TIn> afterAllPartiesFinishedAction) { }
        public JetBarrier(int partiesNumber, System.Func<TIn, TOut> afterAllPartiesFinishedFunction) { }
        public TIn CumulativeInput { get; }
        public TOut Output { get; }
        public bool IsSignaled() { }
        public void Reset(bool releaseWaitingThreads = True) { }
        public void Signal(bool awaitForAllParties = False, int numberOfSignals = 1, System.Func<TIn, TIn> inputUpdater = null, int waitTimeoutMilliseconds = -1) { }
        public void Wait(int waitTimeoutMilliseconds = -1) { }
    }
    public class JetDispatcher
    {
        public static bool OptionTrace;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Threading.Thread Thread;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Threading.JetDispatcher CurrentDispatcher { get; }
        public bool IsAsyncBehaviorProhibited { get; set; }
        public bool IsShutDown { get; }
        public void AssertAccess() { }
        public void AssertAsyncBehaviorSupported() { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public static void AssertFreeThreaded() { }
        public void BeginInvoke([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void BeginInvoke([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void BeginInvokeShutdown() { }
        public void BeginOrInvoke([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void BeginOrInvoke([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public bool CheckAccess() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Threading.JetDispatcher CreateDispatcherThread([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public bool Equals(JetBrains.Threading.JetDispatcher jetDispatcher) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Threading.JetDispatcher FromThread([JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread thread) { }
        public override int GetHashCode() { }
        public void Invoke([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static int PumpMessagesOnce() { }
        public static bool Run([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> condition, System.TimeSpan timeout, bool bThrowOnTimeout) { }
        public static bool Run([JetBrains.Annotations.NotNullAttribute()] System.Func<bool> condition, System.TimeSpan timeout, bool bThrowOnTimeout) { }
        public static void Run(System.TimeSpan timeout) { }
        public static void Run() { }
        public override string ToString() { }
    }
    public class JetDispatcherActionException : System.ApplicationException
    {
        public JetDispatcherActionException([JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
    }
    public class JetFastSemiReenterableRWLock
    {
        public static readonly long NoReadLockMask;
        public static readonly int ReenterLockFactor;
        public static readonly int ReentrantLockFactorShift;
        public static readonly long WriteLockFactor;
        public static readonly int WriteLockFactorShift;
        public JetFastSemiReenterableRWLock() { }
        public bool IsWriteLockHeld { get; }
        public void AcquireRead() { }
        public void AcquireWrite() { }
        public static System.TimeSpan MaxWaitTime() { }
        public void Release() { }
        public bool TryAcquireRead() { }
        public bool TryAcquireWrite() { }
        public JetBrains.Threading.JetFastSemiReenterableRWLock.JetFastSemiReenterableRWLockDisposable UsingReadLock() { }
        public JetBrains.Threading.JetFastSemiReenterableRWLock.JetFastSemiReenterableRWLockDisposable UsingWriteLock() { }
        public struct JetFastSemiReenterableRWLockDisposable : System.IDisposable
        {
            public void Dispose() { }
        }
    }
    public struct MonitorReleaseCookie : System.IDisposable
    {
        public static JetBrains.Threading.MonitorReleaseCookie Create(object @lock) { }
        public void Dispose() { }
    }
    public class RecurrentAlarm : System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsApplicationActive;
        public RecurrentAlarm() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable Create([JetBrains.Annotations.NotNullAttribute()] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void Dispose() { }
    }
    public class ReentrancyGuard
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public bool CanExecuteNow { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Threading.ReentrancyGuard Current { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string CurrentActionName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        public bool IsEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public bool IsExecuting { get; }
        public void AllowNestedExecution([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public void AssertGuarded() { }
        public void Execute([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public bool ExecuteOrQueue([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public int PumpQueue(int limit) { }
        public void Queue([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public bool TryExecute(string name, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public class NoReentrancySynchronizationContext : System.Threading.SynchronizationContext
        {
            public NoReentrancySynchronizationContext() { }
            public NoReentrancySynchronizationContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher) { }
            public override System.Threading.SynchronizationContext CreateCopy() { }
            public override void Post(System.Threading.SendOrPostCallback d, object state) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public static System.IDisposable Push() { }
            public override void Send(System.Threading.SendOrPostCallback d, object state) { }
            public override int Wait(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }
        }
    }
    public class static ReentrancyGuardEx
    {
        public static bool ExecuteOrQueue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.ReentrancyGuard thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static bool ExecuteOrQueueEx([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.ReentrancyGuard thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static bool ExecuteOrQueueEx([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.ReentrancyGuard thіs, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static void Queue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.ReentrancyGuard thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
    }
    public class ReentrancyGuardTimer : System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Disposables;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<System.TimeSpan> Interval;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsApplicationActive;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsEnabled;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISimpleSignal Tick;
        public ReentrancyGuardTimer([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        public void Dispose() { }
        public override string ToString() { }
    }
    public enum Rgc
    {
        NotSpecified = 0,
        Guarded = 1,
        Unguarded = 1,
        Invariant = -1,
        Special = -2,
    }
    public class ThreadAccessException : System.ApplicationException
    {
        public ThreadAccessException() { }
        public ThreadAccessException([JetBrains.Annotations.NotNullAttribute()] System.Threading.Thread threadDesired) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Threading.Thread ThreadDesired { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Threading.Thread ThreadWrong { get; }
    }
    public class ThreadManager : System.IDisposable
    {
        public ThreadManager() { }
        public static JetBrains.Threading.ThreadManager Instance { get; }
        public void Dispose() { }
        public void ExecuteTask(System.Action action, System.Threading.ApartmentState apartmentState = 2) { }
    }
    public class TimedActionsHost
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsApplicationActive;
        public TimedActionsHost([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.JetDispatcher Dispatcher { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Threading.ReentrancyGuard ReentrancyGuard { get; }
        public void Queue([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action, System.TimeSpan interval, JetBrains.Threading.TimedActionsHost.Recurrence recurrence, JetBrains.Threading.Rgc guarding) { }
        public enum Recurrence
        {
            OneTime = 0,
            Recurring = 1,
        }
        public class TimedAction : System.IComparable<JetBrains.Threading.TimedActionsHost.TimedAction>
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.DataFlow.SimpleSignal GottenDirty;
            public TimedAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action action, System.TimeSpan interval, JetBrains.Threading.TimedActionsHost.Recurrence recurrence, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.JetDispatcher dispatcher, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Threading.ReentrancyGuard reega) { }
            public System.Nullable<System.DateTime> Deadline { get; }
            public uint LastExecutedGeneration { get; }
            public string Name { get; }
            public void BeginExecute(uint generation) { }
            public int CompareTo(JetBrains.Threading.TimedActionsHost.TimedAction other) { }
            public void MarshallingComplete([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ICollectionEvents<JetBrains.Threading.TimedActionsHost.TimedAction> queue) { }
            public void Terminated() { }
            public override string ToString() { }
        }
    }
    public class WeakTimer : System.IDisposable
    {
        public readonly JetBrains.DataFlow.IProperty<System.TimeSpan> Interval;
        public readonly JetBrains.DataFlow.IProperty<bool> IsEnabled;
        public readonly JetBrains.DataFlow.ISimpleSignal Tick;
        public WeakTimer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public void Dispose() { }
    }
}
namespace JetBrains.UI
{
    
    public enum Anchoring
    {
        NearWithout = 1,
        NearWithin = 2,
        MiddleWithin = 3,
        FarWithin = 4,
        FarWithout = 5,
    }
    public struct Anchoring2D
    {
        public const int BitsPerDim = 4;
        public const int DimMask = 15;
        public static readonly JetBrains.UI.Anchoring2D Empty;
        public const int HorizontalMask = 15;
        public const int HorizontalShift = 0;
        public int Value;
        public const int VerticalMask = 240;
        public const int VerticalShift = 4;
        public Anchoring2D(int value) { }
        public Anchoring2D(JetBrains.UI.Anchoring horizontal, JetBrains.UI.Anchoring vertical) { }
        public static JetBrains.UI.Anchoring2D[] AnchorAside { get; }
        public static JetBrains.UI.Anchoring2D[] AnchorBottomOrTop { get; }
        public static JetBrains.UI.Anchoring2D[] AnchorLeftOrRightOnly { get; }
        public static JetBrains.UI.Anchoring2D[] AnchorTop { get; }
        public static JetBrains.UI.Anchoring2D[] AnchorTopOrBottom { get; }
        public JetBrains.UI.Anchoring Horizontal { get; set; }
        public bool IsInside { get; }
        public JetBrains.UI.Anchoring Vertical { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static bool IsFar(JetBrains.UI.Anchoring anchoring) { }
        public static bool IsNear(JetBrains.UI.Anchoring anchoring) { }
        public JetBrains.UI.Anchoring2D[] ToArray() { }
        public override string ToString() { }
    }
    public enum ExpectedBackgroundColorHintMode
    {
        Semblance = 0,
        Contrast = 1,
    }
    public class static GraphicsContainer
    {
        public static JetBrains.UI.IGraphicsContainer FromControl(System.Windows.Forms.Control control) { }
        public static JetBrains.UI.IGraphicsContainer FromGetDc(System.IntPtr hwnd) { }
        public static JetBrains.UI.IGraphicsContainer FromGraphics(System.Drawing.Graphics g) { }
        public static JetBrains.UI.IGraphicsContainer FromGraphicsOrControl(System.Drawing.Graphics g, System.Windows.Forms.Control control) { }
        public static JetBrains.UI.IGraphicsContainer FromNothing() { }
        public static JetBrains.UI.IGraphicsContainer FromPainting(System.Windows.Forms.Control control) { }
        public static JetBrains.UI.IGraphicsContainer FromPainting(System.IntPtr hwnd) { }
        public static JetBrains.UI.IGraphicsContainer FromScreen() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Drawing.Graphics SetHighQuality([JetBrains.Annotations.NotNullAttribute()] this System.Drawing.Graphics graphics) { }
    }
    public interface IGraphicsContainer : System.IDisposable
    {
        System.Drawing.Graphics Graphics { get; }
    }
    public class RenderParams : System.ICloneable
    {
        protected static readonly System.Drawing.Font myDefaultFont;
        protected static JetBrains.UI.RichText.TextRenderingMethod myDefaultTextRenderingMethod;
        protected JetBrains.UI.RichText.TextStyle.EffectStyle myEffect;
        protected System.Drawing.Color myEffectColor;
        protected static JetBrains.UI.RenderParams myEmpty;
        protected System.Drawing.Color myExpectedBackgroundColorHint;
        protected JetBrains.UI.ExpectedBackgroundColorHintMode myExpectedBackgroundColorHintMode;
        protected System.Drawing.Font myFont;
        protected System.Drawing.FontStyle myFontStyle;
        protected System.Drawing.Text.HotkeyPrefix myMnemonics;
        protected System.Drawing.Color myNeutralBackgroundColor;
        protected System.Drawing.Color myNeutralForegroundColor;
        protected System.Drawing.Color myOverrideBackgroundColor;
        protected System.Drawing.Color myOverrideForegroundColor;
        protected int myPadding;
        protected bool myReadonly;
        protected JetBrains.UI.RichText.TextRenderingMethod myTextRenderingMethod;
        protected System.Drawing.StringTrimming myTrimming;
        public RenderParams() { }
        protected RenderParams(bool @readonly) { }
        public static System.Drawing.Font DefaultFont { get; }
        public static JetBrains.UI.RichText.TextRenderingMethod DefaultTextRenderingMethod { get; }
        public JetBrains.UI.RichText.TextStyle.EffectStyle Effect { get; set; }
        public System.Drawing.Color EffectColor { get; set; }
        public static JetBrains.UI.RenderParams Empty { get; }
        public System.Drawing.Color ExpectedBackgroundColorHint { get; set; }
        public JetBrains.UI.ExpectedBackgroundColorHintMode ExpectedBackgroundColorHintMode { get; set; }
        public System.Drawing.Font Font { get; set; }
        public System.Drawing.FontStyle FontStyle { get; set; }
        public System.Drawing.Text.HotkeyPrefix Mnemonics { get; set; }
        public System.Drawing.Color NeutralBackgroundColor { get; set; }
        public System.Drawing.Color NeutralForegroundColor { get; set; }
        public System.Drawing.Color OverrideBackgroundColor { get; set; }
        public System.Drawing.Color OverrideForegroundColor { get; set; }
        public int Padding { get; set; }
        public bool Readonly { get; }
        public JetBrains.UI.RichText.TextRenderingMethod TextRenderingMethod { get; set; }
        public System.Drawing.StringTrimming Trimming { get; set; }
        public JetBrains.UI.RenderParams Clone() { }
        public void DumpToXaml(System.Xml.XmlWriter writer) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void ResetColors() { }
        public void SetReadonly() { }
        public override string ToString() { }
    }
}
namespace JetBrains.UI.Application
{
    
    public class LocalReentrancyGuard
    {
        public void Execute([JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public bool TryExecute([JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
    }
    public class LogEventListener : JetBrains.Util.ILogEventListener, System.IEquatable<JetBrains.UI.Application.LogEventListener>
    {
        public LogEventListener() { }
        public LogEventListener([JetBrains.Annotations.NotNullAttribute()] string identity) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Identity { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<string>> OnError;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<System.Exception>> OnException;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.Util.JetTuple<string, JetBrains.Util.LoggingLevel>>> OnMessage;
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.UI.Application.LogEventListener other) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.UI.CrossFramework
{
    
    [System.Windows.Markup.ContentPropertyAttribute("Child")]
    public class JetElementHost : System.Windows.Forms.Control
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<System.Windows.UIElement> Child;
        public JetElementHost([JetBrains.Annotations.NotNullAttribute()] System.Windows.UIElement child) { }
        public JetElementHost() { }
        protected override System.Drawing.Size DefaultSize { get; }
        public override bool Focused { get; }
        public System.Windows.Interop.IKeyboardInputSite HostContainer { get; }
        public System.Windows.Interop.HwndSource HwndSource { get; }
        public System.Windows.Controls.Decorator TopLevelElement { get; }
        protected override void Dispose(bool disposing) { }
        protected override bool IsInputChar(char charCode) { }
        protected override void OnGotFocus(System.EventArgs e) { }
        protected override void OnHandleCreated(System.EventArgs e) { }
        protected override void OnLeave(System.EventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent) { }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) { }
        protected override bool ProcessMnemonic(char charCode) { }
        protected override void Select(bool directed, bool forward) { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
        public class RootDecorator : System.Windows.Controls.Border, System.Windows.Interop.IKeyboardInputSite
        {
            public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<bool, bool>> TabNextRequested;
            public RootDecorator(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.CrossFramework.JetElementHost host) { }
            public System.Windows.Interop.IKeyboardInputSink Sink { get; }
        }
    }
}
namespace JetBrains.UI.Interop
{
    
    public class static Helpers
    {
        public static void BitBlt([JetBrains.Annotations.NotNullAttribute()] System.Void* hdcDestination, [JetBrains.Annotations.NotNullAttribute()] System.Drawing.Bitmap bitmapSource, System.Drawing.Point ptDestinationLocation, [JetBrains.Annotations.CanBeNullAttribute()] System.Void* hdcIntermediate, byte nOpacity, [JetBrains.Annotations.CanBeNullAttribute()] System.Drawing.Rectangle[] rectsSource) { }
        public static bool CanGlassify([JetBrains.Annotations.NotNullAttribute()] System.IntPtr hwnd) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Drawing.Bitmap CreateBitmap([JetBrains.Annotations.NotNullAttribute()] int pixels) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Drawing.Bitmap FlattenAlpha([JetBrains.Annotations.NotNullAttribute()] System.Drawing.Image bmpAltiAliased, byte threshold) { }
        public static JetBrains.Interop.WinApi.WindowExStyles GetWindowExStyle([JetBrains.Annotations.NotNullAttribute()] System.IntPtr hwnd) { }
        public static JetBrains.Interop.WinApi.WindowStyles GetWindowStyle([JetBrains.Annotations.NotNullAttribute()] System.IntPtr hwnd) { }
        public static int MeasureDisplayStringWidth([JetBrains.Annotations.NotNullAttribute()] System.Drawing.Graphics graphics, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] System.Drawing.Font font) { }
        public static int MeasureDisplayStringWidthEffective([JetBrains.Annotations.NotNullAttribute()] System.Drawing.Graphics graphics, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] System.Drawing.Font font) { }
        public static System.Drawing.Bitmap PaintWindowToBitmap([JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.IWin32Window window) { }
        public static void RenderBuffered([JetBrains.Annotations.NotNullAttribute()] this JetBrains.UI.IGraphicsContainer gc, System.Drawing.Rectangle bounds, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Drawing.Graphics> paint, bool bSupportAlphaChannel) { }
        public static void RenderBuffered([JetBrains.Annotations.NotNullAttribute()] this System.Drawing.Graphics g, System.Drawing.Rectangle bounds, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Drawing.Graphics> FPaint, bool bSupportAlphaChannel) { }
        public static void ShowLayered([JetBrains.Annotations.NotNullAttribute()] System.IntPtr hwnd, System.Drawing.Rectangle area, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Drawing.Graphics> funcRender) { }
    }
    public class static HResultsEx
    {
        public static void Assert(this JetBrains.Interop.WinApi.HResults hresult) { }
        public static void Assert(this JetBrains.Interop.WinApi.HResults hresult, [JetBrains.Annotations.NotNullAttribute()] string comment) { }
        public static void AssertSucceeded(this int hresult, [JetBrains.Annotations.NotNullAttribute()] string comment) { }
        public static void AssertSucceeded(this uint hresult, [JetBrains.Annotations.NotNullAttribute()] string comment) { }
        public static void AssertSucceeded(this int hresult) { }
        public static bool Failed(this JetBrains.Interop.WinApi.HResults hresult) { }
        public static bool Succeeded(this JetBrains.Interop.WinApi.HResults hresult) { }
    }
}
namespace JetBrains.UI.RichText
{
    
    public class FontCache : System.IDisposable
    {
        public FontCache() { }
        public void Dispose() { }
        public System.Drawing.Font GetFont(System.Drawing.Font baseFont, System.Drawing.FontStyle style) { }
        public System.IntPtr GetHFont(System.Drawing.Font font) { }
        public System.IntPtr GetHFont(System.Drawing.Font font, System.Drawing.FontStyle fontStyle) { }
    }
    public class RichString : System.IComparable
    {
        public static readonly bool AugmentGdiPlusContext;
        public RichString(int offset, int length, JetBrains.UI.RichText.TextStyle style, JetBrains.UI.RichText.RichText richtext) { }
        public int Length { get; set; }
        public int Offset { get; set; }
        public JetBrains.UI.RichText.RichText RichText { get; }
        public JetBrains.UI.RichText.TextStyle Style { get; set; }
        public string Text { get; }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertValid() { }
        public int CompareTo(object obj) { }
        public int Draw(System.Drawing.Graphics g, System.Drawing.Rectangle rectClip, JetBrains.UI.RenderParams renderparams) { }
        public void Dump(System.Xml.XmlWriter writer) { }
        public int GetIndexFromPoint(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams, int x) { }
        public static System.Windows.Forms.TextFormatFlags GetParameterizedFormat_Gdi(JetBrains.UI.RenderParams renderparams) { }
        public static System.Drawing.StringFormat GetParameterizedFormat_GdiPlus(JetBrains.UI.RenderParams renderparams) { }
        public static System.Drawing.Font GetParametrizedFont(JetBrains.UI.RenderParams renderparams, JetBrains.UI.RichText.TextStyle localstyle) { }
        public System.Drawing.SizeF GetSize(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        public static System.Drawing.SizeF Measure(System.Drawing.Graphics g, string s, System.Drawing.SizeF size, JetBrains.UI.RenderParams renderparams, JetBrains.UI.RichText.TextStyle localstyle) { }
        public static System.Drawing.FontStyle OverrideFontStyle(JetBrains.UI.RenderParams renderparams, JetBrains.UI.RichText.TextStyle localstyle) { }
        public static JetBrains.UI.RichText.TextStyle OverrideTextStyle(JetBrains.UI.RenderParams renderparams, JetBrains.UI.RichText.TextStyle localstyle) { }
        public static void StrikeOut(System.Drawing.Graphics g, System.Drawing.RectangleF rect, System.Drawing.Color effectColor) { }
        public override string ToString() { }
        public static void UnderlineStraight(System.Drawing.Graphics g, System.Drawing.RectangleF rect, System.Drawing.Color effectColor) { }
        public static void UnderlineWeavy(System.Drawing.Graphics g, System.Drawing.RectangleF rect, System.Drawing.Color effectColor) { }
        protected struct AugmentGraphics : System.IDisposable
        {
            public AugmentGraphics(System.Drawing.Graphics graphics, JetBrains.UI.RenderParams renderparams) { }
            public void Dispose() { }
        }
        public enum FormatFlags
        {
            None = 0,
            EndEllipsis = 1,
            ShowMnemonics = 2,
            Mask = 3,
        }
    }
    public class RichText : System.ICloneable
    {
        public RichText(string text, JetBrains.UI.RichText.TextStyle style) { }
        public RichText(string text) { }
        public RichText() { }
        public System.Drawing.Color BackgroundColor { get; }
        public static JetBrains.UI.RichText.RichText Empty { get; }
        public System.Drawing.Color ForegroundColor { get; }
        public bool IsEmpty { get; }
        public int Length { get; }
        public string Text { get; set; }
        public JetBrains.UI.RichText.RichText Append(string s, JetBrains.UI.RichText.TextStyle style) { }
        public JetBrains.UI.RichText.RichText Append(string s) { }
        public JetBrains.UI.RichText.RichText Append(JetBrains.UI.RichText.RichText richText) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertValid() { }
        public void Clear() { }
        public JetBrains.UI.RichText.RichText Clone() { }
        public void Draw(System.Drawing.Graphics g, System.Drawing.Rectangle bounds, JetBrains.UI.RenderParams renderparams) { }
        public string DumpToString() { }
        public void DumpToXaml(System.Xml.XmlWriter writer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.UI.RichText.RichString> GetFormattedParts() { }
        public int GetIndexFromPoint(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams, int x) { }
        public int GetIndexFromPoint(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams, System.Drawing.Point point) { }
        public System.Drawing.Size GetSize(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        public System.Drawing.SizeF GetSizeF(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        public object[] GetUserData(int startOffset, int endOffset) { }
        public JetBrains.UI.RichText.RichText Prepend(string s, JetBrains.UI.RichText.TextStyle style) { }
        public JetBrains.UI.RichText.RichText Prepend(string s) { }
        public JetBrains.UI.RichText.RichText Prepend(JetBrains.UI.RichText.RichText richText) { }
        public void PutUserData(int startOffset, int endOffset, object data) { }
        public void SetBackColor(System.Drawing.Color backColor, int startOffset, int length) { }
        public void SetBackColor(System.Drawing.Color backColor) { }
        public void SetColors(System.Drawing.Color foreColor, System.Drawing.Color backColor) { }
        public void SetColors(System.Drawing.Color foreColor, System.Drawing.Color backColor, int startOffset, int length) { }
        public void SetForeColor(System.Drawing.Color foreColor) { }
        public void SetForeColor(System.Drawing.Color foreColor, int startOffset, int length) { }
        public void SetStyle(JetBrains.UI.RichText.TextStyle style, int startOffset, int length) { }
        public void SetStyle(System.Drawing.FontStyle style, int startOffset, int length) { }
        public void SetStyle(System.Drawing.FontStyle style) { }
        public void SetStyle(JetBrains.UI.RichText.TextStyle style) { }
        public void SetStyle(JetBrains.UI.RichText.TextStyle.EffectStyle effect, System.Drawing.Color effectColor, int startOffset, int length) { }
        public void SetStyle(JetBrains.UI.RichText.TextStyle.EffectStyle effect, System.Drawing.Color effectColor) { }
        public JetBrains.UI.RichText.RichText[] Split(int offset) { }
        public override string ToString() { }
        public JetBrains.UI.RichText.RichText Trim(params char[] trimchars) { }
        public JetBrains.UI.RichText.RichText TrimEnd(params char[] trimchars) { }
        public JetBrains.UI.RichText.RichText TrimStart(params char[] trimchars) { }
    }
    public class RichTextBlock : System.Collections.IEnumerable
    {
        public RichTextBlock() { }
        public RichTextBlock(JetBrains.UI.RichText.RichTextBlockParameters parameters) { }
        public RichTextBlock([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public RichTextBlock([JetBrains.Annotations.NotNullAttribute()] string text, JetBrains.UI.RichText.RichTextBlockParameters parameters) { }
        public RichTextBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText richtext) { }
        public RichTextBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText richtext, JetBrains.UI.RichText.RichTextBlockParameters parameters) { }
        public RichTextBlock(JetBrains.UI.RichText.RichTextBlock block) { }
        public System.Collections.Generic.IList<JetBrains.UI.RichText.RichText> Lines { get; }
        public JetBrains.UI.RichText.RichTextBlockParameters Parameters { get; set; }
        public JetBrains.UI.RichText.RichText RichText { get; set; }
        public string Text { get; set; }
        public int Add(JetBrains.UI.RichText.RichText line) { }
        public void AddLines([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichTextBlock lines) { }
        public void AddLinesCloned(JetBrains.UI.RichText.RichTextBlock lines) { }
        public JetBrains.UI.RichText.RichTextBlock Clone() { }
        public void Draw(System.Drawing.Graphics g, System.Drawing.Rectangle blockRect, JetBrains.UI.RenderParams renderparams) { }
        [System.ObsoleteAttribute("Supply the RenderParams when measuring text.")]
        public void Draw(System.Drawing.Graphics g, System.Drawing.Rectangle blockRect) { }
        public void DumpToXaml(System.Xml.XmlWriter writer) { }
        public System.Collections.IEnumerator GetEnumerator() { }
        public int GetLine(System.Drawing.Point point, System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        [System.ObsoleteAttribute("Supply the RenderParams when measuring text.")]
        public int GetLine(System.Drawing.Point point, System.Drawing.Graphics g) { }
        public int GetOffset(System.Drawing.Graphics g, System.Drawing.Point point, JetBrains.UI.RenderParams renderparams) { }
        [System.ObsoleteAttribute("Supply the RenderParams when measuring text.")]
        public int GetOffset(System.Drawing.Graphics g, System.Drawing.Point point) { }
        public System.Drawing.Size GetSize(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        public System.Drawing.SizeF GetSizeF(System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        [System.ObsoleteAttribute("Supply the RenderParams when measuring text.")]
        public System.Drawing.SizeF GetSizeF(System.Drawing.Graphics g) { }
        public void InsertLine(JetBrains.UI.RichText.RichText line, int index) { }
        public static bool IsNullOrEmpty(JetBrains.UI.RichText.RichTextBlock text) { }
        public void RemoveLine(JetBrains.UI.RichText.RichText line) { }
        public void RemoveLineAt(int index) { }
        public void SplitAndAdd(JetBrains.UI.RichText.RichText value) { }
        public override string ToString() { }
    }
    public class RichTextBlockFormatter
    {
        public static JetBrains.UI.RichText.RichTextBlock Format(JetBrains.UI.RichText.RichTextBlock block, int width, System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
        public static JetBrains.UI.RichText.RichTextBlock Format(JetBrains.UI.RichText.RichText text, int width, System.Drawing.Graphics g, JetBrains.UI.RenderParams renderparams) { }
    }
    public struct RichTextBlockParameters
    {
        public RichTextBlockParameters(int interlineSpacing, System.Drawing.ContentAlignment alignment) { }
        public RichTextBlockParameters(int interlineSpacing) { }
        public System.Drawing.ContentAlignment Alignment { get; set; }
        public static JetBrains.UI.RichText.RichTextBlockParameters Default { get; }
        public int InterlineSpacing { get; set; }
        public void DumpToXaml(System.Xml.XmlWriter writer) { }
        public override string ToString() { }
    }
    [System.ObsoleteAttribute("Possibly, useless.")]
    public class RichTextBlockPresenter
    {
        protected JetBrains.UI.RichText.RichTextBlock myContent;
        protected System.Drawing.Size myDesiredSize;
        protected JetBrains.UI.RichText.RichTextBlock myReflowedContent;
        protected JetBrains.UI.RenderParams myRenderParams;
        protected System.Drawing.Size mySize;
        public RichTextBlockPresenter() { }
        public JetBrains.UI.RichText.RichTextBlock Content { get; }
        public System.Drawing.Size DesiredSize { get; }
        protected JetBrains.UI.RichText.RichTextBlock ReflowedContent { get; }
        public JetBrains.UI.RenderParams RenderParams { get; set; }
        public System.Drawing.Size Size { get; }
        public System.Drawing.Size GetConstrainedSize(System.Drawing.Graphics g, System.Drawing.Size sizeConstraint) { }
        protected void PerformLayout(System.Drawing.Graphics g) { }
        public void SetContent(System.Drawing.Graphics g, JetBrains.UI.RichText.RichTextBlock value) { }
        public void SetSize(System.Drawing.Graphics g, System.Drawing.Size size) { }
    }
    public class static RichTextBlockToHtml
    {
        public static string HtmlEncode(string text) { }
        public static string ToHtml(this JetBrains.UI.RichText.RichTextBlock block) { }
    }
    public class static RichTextEx
    {
        public static bool IsNullOrEmpty([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.UI.RichText.RichText thіs) { }
    }
    public class RichTextParameters
    {
        public RichTextParameters(System.Drawing.Font font) { }
        public RichTextParameters(System.Drawing.Font font, JetBrains.UI.RichText.TextStyle style) { }
        public RichTextParameters(System.Drawing.Font font, JetBrains.UI.RichText.TextStyle style, bool drawEllipsis) { }
        public bool DrawEllipsis { get; set; }
        public System.Drawing.Font Font { get; set; }
        public JetBrains.UI.RichText.TextStyle Style { get; set; }
        public void Dump(System.Xml.XmlWriter writer) { }
    }
    public enum TextRenderingMethod
    {
        GdiPlus = 0,
        Gdi = 1,
    }
    public struct TextStyle : System.IEquatable<JetBrains.UI.RichText.TextStyle>
    {
        public TextStyle(System.Drawing.FontStyle fontStyle, System.Drawing.Color foregroundColor, System.Drawing.Color backgroundColor) { }
        public TextStyle(System.Drawing.FontStyle fontStyle, System.Drawing.Color foregroundColor) { }
        public TextStyle(System.Drawing.FontStyle fontStyle, System.Drawing.Color foregroundColor, System.Drawing.Color backgroundColor, JetBrains.UI.RichText.TextStyle.EffectStyle effect, System.Drawing.Color effectColor) { }
        public TextStyle(System.Drawing.FontStyle fontStyle) { }
        public TextStyle(System.Drawing.Color foregroundColor, System.Drawing.Color backgroundColor) { }
        public System.Drawing.Color BackgroundColor { get; set; }
        public static JetBrains.UI.RichText.TextStyle Default { get; }
        public static System.Drawing.Color DefaultBackgroundColor { get; }
        public static System.Drawing.Color DefaultEffectColor { get; }
        public static System.Drawing.Color DefaultForegroundColor { get; }
        public JetBrains.UI.RichText.TextStyle.EffectStyle Effect { get; set; }
        public System.Drawing.Color EffectColor { get; set; }
        public System.Drawing.FontStyle FontStyle { get; set; }
        public System.Drawing.Color ForegroundColor { get; set; }
        public static JetBrains.UI.RichText.TextStyle Hidden { get; }
        public void Dump(System.Xml.XmlWriter writer) { }
        public bool Equals(JetBrains.UI.RichText.TextStyle other) { }
        public override bool Equals(object obj) { }
        public static JetBrains.UI.RichText.TextStyle FromBackColor(System.Drawing.Color color) { }
        public static JetBrains.UI.RichText.TextStyle FromForeColor(System.Drawing.Color color) { }
        public override int GetHashCode() { }
        public override string ToString() { }
        public enum EffectStyle
        {
            None = 0,
            StraightUnderline = 1,
            WeavyUnderline = 2,
            StrikeOut = 3,
        }
    }
}
namespace JetBrains.Util
{
    
    public class AlgorithmExorigin : JetBrains.Util.InCodeExorigin { }
    public class AlphanumericComparer : System.Collections.Generic.IComparer<string>
    {
        public int Compare(string x, string y) { }
    }
    public struct Alternative<T>
    
    {
        public Alternative(T forTrue, T forFalse) { }
        public T this[bool value] { get; }
    }
    public class AntPatternState
    {
        public AntPatternState(JetBrains.Util.Wildcard[] patternParts, int[] patternPositions) { }
        public AntPatternState(JetBrains.Util.Wildcard[] patternParts) { }
        public int[] PatternPositions { get; }
        public JetBrains.Util.AntPatternState Enter(string component, out JetBrains.Util.AntPatternState.MatchResult match) { }
        public enum MatchResult
        {
            YES = 0,
            NO = 1,
            MAYBELATER = 2,
        }
    }
    public class AntPatternUtil
    {
        public static bool IsFileNameMatch(string pattern, string name) { }
        public static JetBrains.Util.Wildcard[] ParsePattern(string pattern, bool caseSensitive) { }
    }
    public class static ArrayUtil
    {
        public static readonly uint MurmurHashSeed;
        [JetBrains.Annotations.PureAttribute()]
        public static T[] Add<T>(T element, T[] array) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] Add<T>(T[] array, T element) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] Add<T>(T[] array1, params T[] array2) { }
        public static bool Contains<T>(this T[] array, T value, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        [JetBrains.Annotations.PureAttribute()]
        public static TOuter[] Convert<TInner, TOuter>(this TInner[] inner, System.Func<TInner, TOuter> converter) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] CopySegment<T>([JetBrains.Annotations.NotNullAttribute()] this T[] array, int startIndex, int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] CopySegment<T>([JetBrains.Annotations.NotNullAttribute()] this T[] array, int startIndex) { }
        public static bool Equals(System.Array array1, System.Array array2) { }
        public static bool Equals(System.Array array1, System.Array array2, System.Collections.Generic.IEqualityComparer<object> comparer) { }
        public static bool Equals<T>(T[] array1, T[] array2) { }
        public static bool Equals<T>(T[] array1, T[] array2, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static byte[] FromHexString([JetBrains.Annotations.NotNullAttribute()] string hex) { }
        public static int GetHashCode<T>(T[] array) { }
        public static int GetHashCode<T>(System.Collections.Generic.IEnumerable<T> array) { }
        public static int IndexOf<T>(this T[] array, T value, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] InsertAt<T>(T[] array, T element, int position) { }
        public static int MurmurHash3(System.Byte* pData, int nLen, uint seed) { }
        public static int MurmurHash3_Parts(System.Byte* pData1, int nLen1, System.Byte* pData2, int nLen2, uint seed) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] Remove<T>(T[] array, T element) { }
        [JetBrains.Annotations.PureAttribute()]
        public static T[] RemoveAt<T>(T[] array, int index) { }
        public static void Sort<T>([JetBrains.Annotations.NotNullAttribute()] this T[] array, System.Comparison<T> comparison) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToHexString([JetBrains.Annotations.NotNullAttribute()] byte[] buffer) { }
        public class ArrayEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T[]>
        
        {
            public bool Equals(T[] x, T[] y) { }
            public int GetHashCode(T[] obj) { }
        }
    }
    [System.ComponentModel.LocalizableAttribute(false)]
    public class static Assertion
    {
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:false=>void")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert(bool condition, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:false=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert<T>(bool condition, [JetBrains.Annotations.NotNullAttribute()] string message, T arg) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:false=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert<T1, T2>(bool condition, [JetBrains.Annotations.NotNullAttribute()] string message, T1 arg1, T2 arg2) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:false=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert<T1, T2, T3>(bool condition, [JetBrains.Annotations.NotNullAttribute()] string message, T1 arg1, T2 arg2, T3 arg3) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:false=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert(bool condition, [JetBrains.Annotations.NotNullAttribute()] string message, params object[] args) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:null=>void")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertNotNull(object condition, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:null=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertNotNull(object condition, [JetBrains.Annotations.NotNullAttribute()] string message, object arg) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:null=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertNotNull(object condition, [JetBrains.Annotations.NotNullAttribute()] string message, object arg1, object arg2) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:null=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertNotNull(object condition, [JetBrains.Annotations.NotNullAttribute()] string message, object arg1, object arg2, object arg3) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("condition:null=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertNotNull(object condition, [JetBrains.Annotations.NotNullAttribute()] string message, params object[] args) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("=>void")]
        public static void Fail([JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Fail([JetBrains.Annotations.NotNullAttribute()] string message, object arg) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Fail([JetBrains.Annotations.NotNullAttribute()] string message, object arg1, object arg2) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Fail([JetBrains.Annotations.NotNullAttribute()] string message, object arg1, object arg2, object arg3) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("=>void")]
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Fail([JetBrains.Annotations.NotNullAttribute()] string message, params object[] args) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("value:null=>void;=>notnull")]
        public static T NotNull<T>(this T value, [JetBrains.Annotations.NotNullAttribute()] string message)
            where T :  class { }
        [JetBrains.Annotations.ContractAnnotationAttribute("value:null=>void;=>notnull")]
        public static T NotNull<T>(this T value)
            where T :  class { }
        [JetBrains.Annotations.ContractAnnotationAttribute("value:null=>void")]
        public static T NotNull<T>(this System.Nullable<T> value, [JetBrains.Annotations.NotNullAttribute()] string message)
            where T :  struct { }
        [JetBrains.Annotations.ContractAnnotationAttribute("value:null=>void")]
        public static T NotNull<T>(this System.Nullable<T> value)
            where T :  struct { }
        public class AssertionException : System.Exception
        {
            public AssertionException(string message) { }
        }
    }
    public class AssertionExorigin : JetBrains.Util.InCodeExorigin { }
    public enum BeforeOrAfter
    {
        After = 0,
        Before = 1,
    }
    public class BidirectionalMap<TLeft, TRight> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TLeft, TRight>>, System.Collections.IEnumerable
    
    
    {
        public BidirectionalMap(int capacity) { }
        public BidirectionalMap() { }
        public BidirectionalMap(int capacity, System.Collections.Generic.IEqualityComparer<TLeft> leftComparer, System.Collections.Generic.IEqualityComparer<TRight> rightComparer) { }
        public BidirectionalMap(System.Collections.Generic.IEqualityComparer<TLeft> leftComparer, System.Collections.Generic.IEqualityComparer<TRight> rightComparer) { }
        public int Count { get; }
        public System.Collections.Generic.ICollection<TLeft> LeftKeys { get; }
        public System.Collections.Generic.IDictionary<TLeft, TRight> LeftToRight { get; }
        public System.Collections.Generic.ICollection<TRight> RightKeys { get; }
        public System.Collections.Generic.IDictionary<TRight, TLeft> RightToLeft { get; }
        public void Add(TLeft left, TRight right) { }
        public void Clear() { }
        public bool ContainsLeft(TLeft left) { }
        public bool ContainsRight(TRight right) { }
        public System.Collections.IEnumerator GetEnumerator() { }
        public TLeft GetLeftByRight(TRight right) { }
        public TRight GetRightByLeft(TLeft left) { }
        public void RemoveLeft(TLeft left) { }
        public void RemoveMapping(TLeft left, TRight right) { }
        public void RemoveRight(TRight right) { }
        public void SetMapping(TLeft left, TRight right, bool bIgnoreConflicts) { }
        public bool TryGetLeftByRight(TRight right, out TLeft left) { }
        public bool TryGetRightByLeft(TLeft left, out TRight right) { }
    }
    public struct BinarySearchResult<TItem>
    
    {
        public readonly System.Collections.Generic.IList<TItem> Items;
        public readonly int RawResult;
        public readonly TItem SearchTarget;
        public BinarySearchResult([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<TItem> items, TItem searchTarget) { }
        public BinarySearchResult([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TItem> items, TItem searchTarget, int rawresult) { }
        public int HitIndex { get; }
        public TItem HitItem { get; }
        public int InsertAtIndex { get; }
        public bool IsHit { get; }
        public int NearestIndexNotAboveTarget { get; }
        public int NearestIndexNotAboveTargetOrFirst { get; }
        public int NearestIndexNotBelowTarget { get; }
        public int NearestIndexNotBelowTargetOrCount { get; }
        public int NearestIndexNotBelowTargetOrLast { get; }
        public TItem NearestItemNotAboveTarget { get; }
        public TItem NearestItemNotAboveTargetOrFirst { get; }
        public TItem NearestItemNotBelowTarget { get; }
        public TItem NearestItemNotBelowTargetOrLast { get; }
        public int InsertAt(TItem item) { }
    }
    public class static BinarySearchUtil
    {
        public static JetBrains.Util.BinarySearchResult<TItem> BinarySearch<TKey, TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TItem> list, TKey keyLookFor, [JetBrains.Annotations.NotNullAttribute()] System.Func<TItem, TKey> FGetKeyOfItem, System.Collections.Generic.IComparer<TKey> keycomparer = null, int index = 0, int length = -1) { }
        public static JetBrains.Util.BinarySearchResult<TItem> BinarySearch<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TItem> list, TItem itemLookFor, System.Collections.Generic.IComparer<TItem> keycomparer = null, int index = 0, int length = -1) { }
        public static int BinarySearch<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> list, int index, int length, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Locator<T> locator) { }
        public static int BinarySearch<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> list, JetBrains.Util.Locator<T> locator) { }
        public static JetBrains.Util.BinarySearchResult<TItem> BinarySearchEx<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TItem> thіs, TItem item) { }
        public static JetBrains.Util.BinarySearchResult<T> BinarySearchEx<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> list, JetBrains.Util.Locator<T> locator) { }
        public static TValue GetOrCreateValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> list, [JetBrains.Annotations.NotNullAttribute()] TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, TKey> FGetKeyOfItem, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> FCreateIfMissing) { }
        public static bool RemoveValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> list, [JetBrains.Annotations.NotNullAttribute()] TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, TKey> FGetKeyOfItem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TValue TryGetValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TValue> list, [JetBrains.Annotations.NotNullAttribute()] TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue, TKey> FGetKeyOfItem) { }
    }
    public class static BinarySerializers
    {
        public static byte[] ReadByteArray(System.IO.BinaryReader reader) { }
        public static string[] ReadStringCollection(System.IO.BinaryReader reader) { }
        public static System.Collections.Generic.Dictionary<string, string> ReadStringDictionary(System.IO.BinaryReader reader) { }
        public static JetBrains.Util.DataStructures.CompactOneToListMap<string, string> ReadStringOneToList(System.IO.BinaryReader reader) { }
        public static void WriteByteArray(System.IO.BinaryWriter writer, byte[] array) { }
        public static void WriteStringCollection(System.IO.BinaryWriter writer, System.Collections.Generic.ICollection<string> strings) { }
        public static void WriteStringDictionary(System.IO.BinaryWriter writer, System.Collections.Generic.IDictionary<string, string> dict) { }
        public static void WriteStringOneToList(System.IO.BinaryWriter writer, JetBrains.Util.DataStructures.CompactOneToListMap<string, string> map) { }
    }
    public class static BinaryStreamEx
    {
        public static int ReadCompressedInt32(this System.IO.BinaryReader reader) { }
        public static uint ReadCompressedUInt32(this System.IO.BinaryReader reader) { }
        public static void WriteCompressedInt32(this System.IO.BinaryWriter writer, int value) { }
        public static void WriteCompressedUInt32(this System.IO.BinaryWriter writer, uint value) { }
    }
    public class BitArrayUtil
    {
        public static bool[] BoolArrayFromSet(short count, short[] values) { }
        public static System.Collections.BitArray FromSet(short count, short[] values) { }
    }
    public class static BitHacks
    {
        public static int Log2(int x) { }
        public static int NumberOfBitSet(int x) { }
    }
    public delegate void BitsIncreasedHandler(int oldBitsCount, int newBitsCount);
    public class static BooleanBoxes
    {
        public static readonly object False;
        public static readonly object True;
    }
    public class static CharUtil
    {
        public static bool IsHexDigit(char c) { }
        public static bool IsOctDigit(char c) { }
    }
    public class static CodeDomEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.CodeDom.CodeConditionStatement ArgumentNullException([JetBrains.Annotations.NotNullAttribute()] string sParameterName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.CodeDom.CodeTypeReference MakeTypeReference([JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.CodeDom.CodeTypeReference MakeTypeReference<TType>() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.CodeDom.CodeTypeReference MakeTypeReference([JetBrains.Annotations.NotNullAttribute()] string sFullyQualifiedName) { }
        public static void WriteCodeToFile([JetBrains.Annotations.NotNullAttribute()] System.CodeDom.CodeCompileUnit code, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filepath) { }
        public class static CodeDomWalker
        {
            public static System.Collections.Generic.IEnumerable<string> GetTypes(System.CodeDom.CodeTypeDeclaration codefile) { }
        }
    }
    [System.ObsoleteAttribute("No usages in ReSharper")]
    public class CollectionAdapter<T> : System.Collections.ICollection, System.Collections.IEnumerable
    
    {
        public CollectionAdapter(System.Collections.Generic.ICollection<T> genericcollection) { }
        public int Count { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { }
    }
    public class static CollectionUtil
    {
        public static void Add<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, TItem item) { }
        public static void AddRange<TTarget, TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<TTarget> to, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TSource> from)
        
            where TSource : TTarget { }
        public static void AddRange<TTarget, TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<TTarget> to, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TSource> from, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, bool> predicate)
        
            where TSource : TTarget { }
        public static void AddRange<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TItem> items) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TCollection AddRangeFluent<TItem, TCollection>([JetBrains.Annotations.NotNullAttribute()] this TCollection to, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TItem> from)
        
            where TCollection : System.Collections.Generic.ICollection<> { }
        public static void AddRangeSafe<TKey, TValue, TValueElt>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dict, [JetBrains.Annotations.NotNullAttribute()] TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<TValueElt> itemsToAdd, [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> newCollection)
        
            where TValue : System.Collections.Generic.ICollection<> { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AggregateString<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] string separator, [JetBrains.Annotations.CanBeNullAttribute()] [JetBrains.Annotations.InstantHandleAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TResult AggregateString<TSource, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] string separator, [JetBrains.Annotations.CanBeNullAttribute()] [JetBrains.Annotations.InstantHandleAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Text.StringBuilder, TResult> funcConvert) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AggregateString<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] string seed, [JetBrains.Annotations.CanBeNullAttribute()] string separator, [JetBrains.Annotations.CanBeNullAttribute()] [JetBrains.Annotations.InstantHandleAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TResult AggregateString<TSource, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] string seed, [JetBrains.Annotations.CanBeNullAttribute()] string separator, [JetBrains.Annotations.CanBeNullAttribute()] [JetBrains.Annotations.InstantHandleAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Text.StringBuilder, TResult> funcConvert) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AggregateString<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder seed, [JetBrains.Annotations.CanBeNullAttribute()] string separator, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TResult AggregateString<TSource, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder seed, [JetBrains.Annotations.CanBeNullAttribute()] string separator, [JetBrains.Annotations.CanBeNullAttribute()] [JetBrains.Annotations.InstantHandleAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Text.StringBuilder, TResult> funcConvert) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AggregateString<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Text.StringBuilder, TSource, System.Text.StringBuilder> funcAppend) { }
        public static bool Any<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        public static bool AreUnique<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> e) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TItem[] ArrayExcept<TItem>([JetBrains.Annotations.NotNullAttribute()] this TItem[] thіs, TItem item) { }
        public static TItem[] ArrayExcept<TItem>([JetBrains.Annotations.NotNullAttribute()] this TItem[] thіs, TItem item, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEqualityComparer<TItem> comparer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TItem[] ArrayUnion<TItem>([JetBrains.Annotations.NotNullAttribute()] this TItem[] thіs, TItem item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TItem[] ArrayUnion<TItem>([JetBrains.Annotations.NotNullAttribute()] this TItem[] thіs, TItem item, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEqualityComparer<TItem> comparer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T[] AsArray<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<T> AsIList<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<T> AsList<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<T> AsReadOnly<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<T> AsReadOnly<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ReadOnlyCollection<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IDictionary<TKey, TValue> AsReadOnly<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IDictionary<TKey, TValue> AsReadOnly<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ReadOnlyDictionary<TKey, TValue> dictionary) { }
        public static void AssertEquivalentTo([JetBrains.Annotations.NotNullAttribute()] this System.Collections.IEnumerable thіs, [JetBrains.Annotations.NotNullAttribute()] System.Collections.IEnumerable expected) { }
        public static bool CanBeProvenEmptyFast<T>([JetBrains.Annotations.NoEnumerationAttribute()] [JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [System.ObsoleteAttribute("Do not use this method with ICollection<T>, check its Count property.", true)]
        public static bool CanBeProvenEmptyFast<T>(this System.Collections.Generic.ICollection<T> collection) { }
        [System.ObsoleteAttribute("Do not use this method with ICollection, check its Count property.", true)]
        public static bool CanBeProvenEmptyFast(this System.Collections.ICollection collection) { }
        [System.ObsoleteAttribute("Do not use this method with string, check its Length property.", true)]
        public static bool CanBeProvenEmptyFast(this string collection) { }
        public static bool CanBeProvenNonEmptyFast<T>([JetBrains.Annotations.NoEnumerationAttribute()] [JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [System.ObsoleteAttribute("Do not use this method with ICollection<T>, check its Count property.", true)]
        public static bool CanBeProvenNonEmptyFast<T>(this System.Collections.Generic.ICollection<T> collection) { }
        [System.ObsoleteAttribute("Do not use this method with ICollection, check its Count property.", true)]
        public static bool CanBeProvenNonEmptyFast(this System.Collections.ICollection collection) { }
        [System.ObsoleteAttribute("Do not use this method with string, check its Length property.", true)]
        public static bool CanBeProvenNonEmptyFast(this string collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.Stack<T> Clone<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.Stack<T> stack, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<T, T> copyFunc = null) { }
        public static System.Collections.Generic.JetHashSet<T> Clone<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.JetHashSet<T> set) { }
        public static JetBrains.Util.DataStructures.CompactSet<T> Clone<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.DataStructures.CompactSet<T> set) { }
        public static bool CompareCollections<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection1, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<T> collection2) { }
        public static int CompareOrder<T>(T x, T y, [JetBrains.Annotations.NotNullAttribute()] params T[] values) { }
        public static bool CompareSets<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> set1, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<T> set2) { }
        public static void CompareSets<T>(System.Collections.Generic.JetHashSet<T> oldSet, System.Collections.Generic.JetHashSet<T> newSet, System.Collections.Generic.JetHashSet<T> addedItems, System.Collections.Generic.JetHashSet<T> removedItems) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Concat<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, T element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Concat<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, [JetBrains.Annotations.NotNullAttribute()] params T[] elements) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Concat<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, T element, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<T> appendIf) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<TOutput> ConvertAll<TOutput, TInput>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TInput> list)
        
            where TInput : TOutput { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<TOutput> ConvertAll<TOutput, TInput>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TInput> list, System.Func<TInput, TOutput> converter) { }
        public static bool CountIs<T>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, int exactCount) { }
        public static bool CountIs<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, long exactCount) { }
        public static bool CountIs<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, int exactCount) { }
        public static bool CountIs([JetBrains.Annotations.NotNullAttribute()] this string str, int exactCount) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> DefaultIfEmptyLazy<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, [JetBrains.Annotations.NotNullAttribute()] System.Func<T> defaultValueFactory) { }
        public static void DisposeAll<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TItem> items)
            where TItem : System.IDisposable { }
        public static void DoForFirst<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> e, [JetBrains.Annotations.NotNullAttribute()] System.Action<T> action) { }
        public static System.Collections.Generic.IEnumerable<T> EnumerateAll<T>([JetBrains.Annotations.NotNullAttribute()] params System.Collections.Generic.IEnumerable<>[] enumerables) { }
        public static System.Collections.Generic.IEnumerable<T> EnumerateAll<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> enumerables) { }
        public static System.Collections.Generic.IEnumerable<T> EnumerateRecursivelyBfs<T>(T root, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, System.Collections.Generic.IEnumerable<T>> getChildren) { }
        public static System.Collections.Generic.JetHashSet<T> EnumerateRecursivelyBfsDistinct<T>(T root, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, System.Collections.Generic.IEnumerable<T>> FGetChildren) { }
        public static System.Collections.Generic.IEnumerable<T> EnumerateRecursivelyDfs<T>(T t, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, System.Collections.Generic.IEnumerable<T>> getChildren) { }
        public static bool EqualEnumerables<T>(this System.Collections.Generic.IEnumerable<T> left, System.Collections.Generic.IEnumerable<T> right) { }
        public static bool EqualEnumerables<T>(this System.Collections.Generic.IEnumerable<T> left, System.Collections.Generic.ICollection<T> right) { }
        public static bool EqualEnumerables<T>(this System.Collections.Generic.ICollection<T> left, System.Collections.Generic.IEnumerable<T> right) { }
        public static bool EqualEnumerables<T>(this System.Collections.Generic.ICollection<T> left, System.Collections.Generic.ICollection<T> right) { }
        public static bool EqualEnumerables<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<T> right, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> compare) { }
        public static bool EqualEnumerables<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<T> right, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> compare) { }
        public static bool EqualEnumerables<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.ICollection<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<T> right, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> compare) { }
        public static bool EqualEnumerables<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.ICollection<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<T> right, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> compare) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Except<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, T element) { }
        [System.ObsoleteAttribute("Prefer to use method System.Linq.Enumerable.Any")]
        public static bool Exists<T>(this System.Collections.Generic.IEnumerable<T> collection, System.Predicate<T> predicate) { }
        public static T FindRecursively<T>(T t, [JetBrains.Annotations.NotNullAttribute()] System.Converter<T, System.Collections.Generic.IEnumerable<T>> getChildren, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<T> predicate) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TSource FirstOrDefault<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.NotNullAttribute()] TSource defaultValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Nullable<TSource> FirstOrNull<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<TSource, bool> predicate)
            where TSource :  struct { }
        public static void Force<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        public static void ForEach<T>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> action) { }
        [System.ObsoleteAttribute("Use System.Linq.Enumerable.LastOfDefault or System.Linq.Enumerable.Last instead")]
        public static T GetLast<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> l) { }
        [System.ObsoleteAttribute("Use System.Linq.Enumerable.LastOfDefault or System.Linq.Enumerable.Last instead")]
        public static T GetLast<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> e) { }
        public static T GetNext<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> c, T anchor)
            where T :  class { }
        public static TLeft GetOrCreateLeftByRight<TLeft, TRight>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.BidirectionalMap<TLeft, TRight> thіs, TRight right, [JetBrains.Annotations.NotNullAttribute()] System.Func<TRight, TLeft> FCreate) { }
        public static TRight GetOrCreateRightByLeft<TLeft, TRight>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.BidirectionalMap<TLeft, TRight> thіs, TLeft left, [JetBrains.Annotations.NotNullAttribute()] System.Func<TLeft, TRight> FCreate) { }
        public static TValue GetOrCreateValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> funcNew) { }
        public static TValue GetOrCreateValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key, [JetBrains.Annotations.NotNullAttribute()] System.Func<TKey, TValue> funcNew) { }
        public static T GetPrevious<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> c, T anchor)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Quadratisch Praktisch schleht", true)]
        public static System.Collections.Generic.ICollection<T> GetRoots<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> items, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T, bool> incidenceProvider) { }
        public static TValue GetValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key, [JetBrains.Annotations.NotNullAttribute()] string sExceptionText) { }
        public static bool HasAtLeast<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, int minimumCount) { }
        public static bool HasAtLeast<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, long minimumCount) { }
        public static bool HasAtLeast<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, int minimumCount) { }
        public static bool HasAtLeast([JetBrains.Annotations.NotNullAttribute()] this string str, int minimumCount) { }
        public static bool HasMoreThan<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, int exclusiveLowerBound) { }
        public static bool HasMoreThan<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, int exclusiveLowerBound) { }
        public static bool HasMoreThan([JetBrains.Annotations.NotNullAttribute()] this string str, int exclusiveLowerBound) { }
        public static bool HasMultiple<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        public static bool HasMultiple<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        public static bool HasMultiple([JetBrains.Annotations.NotNullAttribute()] this string str) { }
        public static int IndexOf<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> list, [JetBrains.Annotations.NotNullAttribute()] T item, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEqualityComparer<T> comparer, int startSearchFromElement = 0, int howManyElementsToSearch = -1) { }
        public static bool IsEmpty<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        public static bool IsEmpty<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        public static bool IsEmpty<T>(this JetBrains.Util.LocalList<T> collection) { }
        public static bool IsEmpty<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.Stack<T> collection) { }
        public static bool IsEmpty<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.Queue<T> collection) { }
        public static bool IsEquivalentTo<T>(this System.Collections.Generic.IEnumerable<T> x, System.Collections.Generic.IEnumerable<T> y, System.Collections.Generic.IEqualityComparer<T> comparer = null) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null=>true")]
        public static bool IsNullOrEmpty<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null=>true")]
        public static bool IsNullOrEmpty<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        public static bool IsNullOrEmpty<T>(this JetBrains.Util.LocalList<T> collection) { }
        public static bool IsNullOrEmpty<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.Stack<T> collection) { }
        public static bool IsNullOrEmpty<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.Queue<T> collection) { }
        public static bool IsOfSameLengthAs<T, S>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<S> right) { }
        public static bool IsOfSameLengthAs<T, S>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<S> right) { }
        public static bool IsOfSameLengthAs<T, S>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.ICollection<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<S> right) { }
        public static bool IsOfSameLengthAs<T, S>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.ICollection<T> left, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<S> right) { }
        public static bool IsSingle<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        public static bool IsSingle<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        public static bool IsSingle([JetBrains.Annotations.NotNullAttribute()] this string str) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Join<T>([JetBrains.Annotations.NotNullAttribute()] params System.Collections.Generic.IEnumerable<>[] e) { }
        public static int LastIndexOf<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> list, [JetBrains.Annotations.NotNullAttribute()] T item, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEqualityComparer<T> comparer, int startSearchFromElement = -1, int howManyElementsToSearch = -1) { }
        public static int LastIndexOfFuckingMagic<T>(this System.Collections.Generic.List<T> list, T item) { }
        [System.ObsoleteAttribute("Use method System.Linq.Enumerable.Count")]
        public static int Length<T>(this System.Collections.Generic.IEnumerable<T> nodes) { }
        [System.ObsoleteAttribute("Use property ICollection<T>.Count")]
        public static int Length<T>(this System.Collections.Generic.ICollection<T> nodes) { }
        [System.ObsoleteAttribute("Use property string.Length")]
        public static int Length(this string str) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<TValue> Map<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> map, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TKey> keys) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<B> Map<A, B>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<A> @as, [JetBrains.Annotations.NotNullAttribute()] System.Converter<A, B> f) { }
        public static T NextItemOrException<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerator<T> enumerator) { }
        public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<T>> Permute<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> xs, params T[] pre) { }
        public static TItem Pop<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.Stack<TItem> stack, [JetBrains.Annotations.NotNullAttribute()] string exception) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Prepend<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> tail, [JetBrains.Annotations.NotNullAttribute()] params T[] elements) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> Prepend<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> tail, System.Collections.Generic.IEnumerable<T> elements) { }
        public static void ProcessRecursively<T>(T t, [JetBrains.Annotations.NotNullAttribute()] System.Converter<T, System.Collections.Generic.IEnumerable<T>> getChildren, [JetBrains.Annotations.NotNullAttribute()] System.Action<T> action) { }
        public static void RemoveRange<TTarget, TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<TTarget> collection, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TSource> items)
        
            where TSource : TTarget { }
        public static void RemoveWhere<TKey, TValue>(this JetBrains.Util.OneToSetMap<TKey, TValue> map, TKey key, System.Func<TValue, bool> predicate) { }
        public static System.Collections.Generic.IList<T> Reverse<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<T> list) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<TTarget> SafeOfType<TTarget>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.IEnumerable enumerable) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T SameOrNull<T, E>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<E> collection, [JetBrains.Annotations.NotNullAttribute()] System.Func<E, T> func) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IEnumerable<TOut> SelectNotNull<TSource, TOut>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> collection, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, TOut> selector)
        
            where TOut :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Nullable<TOut>> SelectNotNull<TSource, TOut>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> collection, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, System.Nullable<TOut>> selector)
        
            where TOut :  struct { }
        public static bool SequenceAny<T, T1>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T1> second, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T1, bool> predicate) { }
        public static bool SequenceForAll<T, T1>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T1> second, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, T1, bool> predicate) { }
        public static void SequenceForEach<T, T1>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T1> second, [JetBrains.Annotations.NotNullAttribute()] System.Action<T, T1> function) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<T, T1>> SequenceIterate<T, T1>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T1> second) { }
        public static System.Collections.Generic.IEnumerable<TSource> Slice<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TSource> source, int from, int count = -1) { }
        public static System.Collections.Generic.ICollection<T> Sort<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IComparer<T> comparer) { }
        public static System.Collections.Generic.IList<T> Sort<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.NotNullAttribute()] System.Comparison<T> comparer) { }
        public static System.Collections.Generic.IEnumerable<TSource> TakeWhileInclusive<TSource>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<TSource> source, [JetBrains.Annotations.NotNullAttribute()] System.Func<TSource, bool> predicate) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<T> Then<T>([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<T> first, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<T> tail) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T[] ToArray<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Array ToArrayOfType([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<object> source, [JetBrains.Annotations.NotNullAttribute()] System.Type type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IList<TResult> ToIList<T, TResult>([JetBrains.Annotations.NotNullAttribute()] this T[] source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, TResult> selector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IList<TResult> ToIList<T, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.List<T> source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, TResult> selector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IList<TResult> ToIList<T, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, TResult> selector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.List<TResult> ToList<T, TResult>([JetBrains.Annotations.NotNullAttribute()] this T[] source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, TResult> selector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.List<TResult> ToList<T, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.List<T> source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, TResult> selector) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.List<TResult> ToList<T, TResult>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> source, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, TResult> selector) { }
        public static string ToString<T>(System.Collections.Generic.IEnumerable<T> collection, string separator = ", ") { }
        public static bool TryGetFastCount<T>([JetBrains.Annotations.NoEnumerationAttribute()] [JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, out int count) { }
        [System.ObsoleteAttribute("Do not use this method with ICollection<T>, check its Count property.", true)]
        public static bool TryGetFastCount<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.ICollection<T> collection, out int count) { }
        [System.ObsoleteAttribute("Do not use this method with ICollection, check its Count property.", true)]
        public static bool TryGetFastCount([JetBrains.Annotations.NotNullAttribute()] this System.Collections.ICollection collection, out int count) { }
        [System.ObsoleteAttribute("Do not use this method with string, check its Length property.", true)]
        public static bool TryGetFastCount(this string str, out int count) { }
        public static TValue TryGetValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, [JetBrains.Annotations.NotNullAttribute()] TKey key, TValue defaultValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TValue TryGetValue<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Nullable<TValue> TryGetValueNullable<TKey, TValue>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key)
        
            where TValue :  struct { }
        public static T TryPeek<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.Stack<T> stack) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T TryPop<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.Stack<T> stack) { }
        public static System.Collections.Generic.IEnumerable<T> Unfold<T>(T element, System.Func<T, T> next) { }
        public static System.Collections.Generic.IEnumerable<T> Unfold<T>(T element, System.Func<T, T> next, System.Func<T, bool> include) { }
        public static System.Collections.Generic.IEnumerable<T> Union<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection, T element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IEnumerable<T> WhereNotNull<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<T> collection) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Nullable<T>> WhereNotNull<T>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<System.Nullable<T>> collection)
            where T :  struct { }
        public class CastEnumerable<TIn, TOut> : System.Collections.Generic.IEnumerable<TOut>, System.Collections.IEnumerable
            where TIn :  class
            where TOut :  class
        {
            public CastEnumerable(System.Collections.Generic.IEnumerable<TIn> @in) { }
            public System.Collections.Generic.IEnumerator<TOut> GetEnumerator() { }
        }
        public class SupertypeCollection<TIn, TOut> : System.Collections.Generic.ICollection<TOut>, System.Collections.Generic.IEnumerable<TOut>, System.Collections.IEnumerable
            where TIn : TOut
        
        {
            public SupertypeCollection([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<TIn> @in) { }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public void Add(TOut item) { }
            public void Clear() { }
            public bool Contains(TOut item) { }
            public void CopyTo(TOut[] array, int arrayIndex) { }
            public System.Collections.Generic.IEnumerator<TOut> GetEnumerator() { }
            public bool Remove(TOut item) { }
        }
        public class SupertypeEnumerable<TIn, TOut> : System.Collections.Generic.IEnumerable<TOut>, System.Collections.IEnumerable
            where TIn : TOut
        
        {
            public SupertypeEnumerable([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TIn> @in) { }
            public System.Collections.Generic.IEnumerator<TOut> GetEnumerator() { }
        }
        public class SupertypeList<TIn, TOut> : JetBrains.Util.CollectionUtil.SupertypeEnumerable<TIn, TOut>, System.Collections.Generic.ICollection<TOut>, System.Collections.Generic.IEnumerable<TOut>, System.Collections.Generic.IList<TOut>, System.Collections.IEnumerable
            where TIn : TOut
        
        {
            public SupertypeList([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TIn> @in) { }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public TOut this[int index] { get; set; }
            public void Add(TOut item) { }
            public void Clear() { }
            public bool Contains(TOut item) { }
            public void CopyTo(TOut[] array, int arrayIndex) { }
            public int IndexOf(TOut item) { }
            public void Insert(int index, TOut item) { }
            public bool Remove(TOut item) { }
            public void RemoveAt(int index) { }
        }
    }
    public class static ColorParsing
    {
        public static string FindFirstColorNameOccurance(string sentence) { }
        public static System.Nullable<System.Drawing.Color> FromHexOrNamed([JetBrains.Annotations.CanBeNullAttribute()] string color) { }
        public static System.Nullable<System.Drawing.Color> GetColorFromHexString([JetBrains.Annotations.NotNullAttribute()] string hexFormattedColor) { }
        public static System.Nullable<System.Drawing.Color> GetColorFromHexString(string hexFormattedColor, bool allowThreeDigitsFormat) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetColorName(System.Drawing.Color color) { }
        public static System.Nullable<System.Drawing.Color> GetNamedColor([JetBrains.Annotations.CanBeNullAttribute()] string name) { }
        public static string Hex(System.Drawing.Color rgbColor) { }
        public static string HexAlphaAndColor(System.Drawing.Color rgbColor) { }
        public static string HexNoAlpha(System.Drawing.Color rgbColor) { }
        public static System.Drawing.Color ToColor(uint color) { }
        public static uint ToUint(System.Drawing.Color color) { }
        public static uint ToUint(double a, double r, double g, double b) { }
    }
    public class static CommandLineUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string[] ToArray([JetBrains.Annotations.NotNullAttribute()] string args) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToString([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> args) { }
    }
    public delegate int Comparator<in T>(T x, T y);
    public class static CompileUtil
    {
        public static void CompileCs(JetBrains.Util.FileSystemPath sourceFile, JetBrains.Util.FileSystemPath outputFile, string[] references = null, bool generateXmlDoc = False, bool generatePdb = False, string framework = "3.5") { }
        public static void CompileCs(string text, JetBrains.Util.FileSystemPath outputFile, string[] references = null, bool generateXmlDoc = False, bool generatePdb = False, string framework = "3.5") { }
        public static void CompileVb(string text, JetBrains.Util.FileSystemPath outputFile, params string[] references) { }
        public static JetBrains.Util.FileSystemPath FindFrameworkDirectory(string version) { }
        public static string RunCommand(JetBrains.Util.FileSystemPath cmd, string args, bool ignoreNonZeroCode) { }
    }
    public class CompoundException : System.ApplicationException
    {
        public CompoundException() { }
        public CompoundException(params System.Exception[] exceptions) { }
        protected CompoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Collections.Generic.IList<System.Exception> Exceptions { get; }
        public override string Message { get; }
        public void Catch(System.Action action) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Collections.Generic.IList<System.Exception> GetDistinctExceptions() { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { }
    }
    public class CountingLogger : JetBrains.Util.ILogger
    {
        public CountingLogger([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForward) { }
        public bool IsWithAnyExceptions { get; }
        public bool IsWithLoudExceptions { get; }
        public bool IsWithSilentExceptions { get; }
        public int LoggedExceptionAnyKind { get; }
        public int LoggedExceptionsLoud { get; }
        public int LoggedExceptionsSilent { get; }
        public int LoggedMessages { get; }
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
        public void ResetCounters() { }
    }
    public class CultureCookie : System.IDisposable
    {
        public static readonly System.Globalization.CultureInfo TURKISH;
        public void Dispose() { }
        public static System.IDisposable SetCulture(System.Globalization.CultureInfo newCulture) { }
        public static System.IDisposable SetInvariantCulture() { }
        public static void SetInvariantCulture(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public enum DefaultAction
    {
        Commit = 0,
        Rollback = 1,
    }
    public class DelegateComparer : System.Collections.IComparer
    {
        public DelegateComparer(JetBrains.Util.DelegateComparer.Comparison comparison) { }
        public int Compare(object x, object y) { }
        public delegate int Comparison(object left, object right);
    }
    public sealed class DelegatingComparer<TSource, TTarget> : System.Collections.Generic.IComparer<TSource>
    
    
    {
        public int Compare(TSource x, TSource y) { }
        public static JetBrains.Util.DelegatingComparer<TSource, TTarget> Create(System.Func<TSource, TTarget> transformation, System.Collections.Generic.IComparer<TTarget> targetComparer) { }
        public static JetBrains.Util.DelegatingComparer<TSource, TTarget> Create(System.Func<TSource, TTarget> transformation) { }
    }
    public class static DependentEntitiesSortUtil
    {
        public static bool Sort([JetBrains.Annotations.NotNullAttribute()] System.Collections.IList entities, out JetBrains.Util.DependentEntitiesSortUtil.Entity failedOn) { }
        public class Entity
        {
            public readonly System.Collections.Generic.JetHashSet<object> DeclaredIds;
            public readonly System.Collections.ArrayList ReferencedIds;
            public Entity() { }
        }
    }
    [JetBrains.Annotations.ThreadUnsafeAttribute()]
    [System.ObsoleteAttribute("No usages in ReSharper")]
    public class DictionaryWrapper<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
    
    
    {
        public DictionaryWrapper() { }
        protected DictionaryWrapper(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DictionaryWrapper(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public DictionaryWrapper(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public DictionaryWrapper(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public DictionaryWrapper(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public DictionaryWrapper(int capacity) { }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsValue(TValue value) { }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Collections.Generic.KeyValuePair<, >[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void OnDeserialization(object sender) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool Remove(TKey key) { }
        public bool TryGetValue(TKey key, out TValue value) { }
    }
    public class DirectoryScanner
    {
        public DirectoryScanner() { }
        public System.Collections.Generic.IList<string> ExcludePatterns { get; set; }
        public System.Collections.Generic.IList<string> IncludePatterns { get; set; }
        public JetBrains.DataStructures.ImmutableArray<JetBrains.Util.FileSystemPath> FindFiles(JetBrains.Util.DirectoryScanner.IFileSystem fs, JetBrains.Util.DirectoryScanner.IDirectoryEntry root, bool caseSensitive) { }
        public JetBrains.DataStructures.ImmutableArray<JetBrains.Util.FileSystemPath> FindFiles(JetBrains.Util.FileSystemPath root, bool caseSensitive) { }
        public interface IDirectoryEntry
        {
            IFileEntry[] Files { get; }
            string Name { get; }
            JetBrains.Util.DirectoryScanner.IDirectoryEntry Parent { get; }
            IDirectoryEntry[] Subdirectories { get; }
        }
        public interface IFileEntry
        {
            string Name { get; }
            JetBrains.Util.FileSystemPath Path { get; }
        }
        public interface IFileSystem
        {
            bool CaseSensitive { get; }
            JetBrains.Util.DirectoryScanner.IDirectoryEntry Root { get; }
            bool IsPathAbsolute(string path);
            JetBrains.Util.Wildcard[] ParsePathWithWildcards(string path);
        }
        public class RealDirectoryEntry : JetBrains.Util.DirectoryScanner.IDirectoryEntry
        {
            public RealDirectoryEntry(JetBrains.Util.FileSystemPath path) { }
            public IFileEntry[] Files { get; }
            public string Name { get; }
            public JetBrains.Util.DirectoryScanner.IDirectoryEntry Parent { get; }
            public JetBrains.Util.FileSystemPath Path { get; }
            public IDirectoryEntry[] Subdirectories { get; }
            public JetBrains.Util.DirectoryScanner.IFileEntry GetFileEntry(string name) { }
            public JetBrains.Util.DirectoryScanner.IDirectoryEntry GetSubdirectory(string name) { }
        }
        public class RealFileEntry : JetBrains.Util.DirectoryScanner.IFileEntry
        {
            public RealFileEntry(JetBrains.Util.FileSystemPath path) { }
            public string Name { get; }
            public JetBrains.Util.FileSystemPath Path { get; }
        }
        public class RealFileSystem : JetBrains.Util.DirectoryScanner.IFileSystem
        {
            public static readonly JetBrains.Util.DirectoryScanner.IDirectoryEntry ROOT;
            public bool CaseSensitive { get; }
            public JetBrains.Util.DirectoryScanner.IDirectoryEntry Root { get; }
            public bool IsPathAbsolute(string path) { }
            public JetBrains.Util.Wildcard[] ParsePathWithWildcards(string path) { }
        }
        public class RealRootDirectory : JetBrains.Util.DirectoryScanner.IDirectoryEntry
        {
            public IFileEntry[] Files { get; }
            public string Name { get; }
            public JetBrains.Util.DirectoryScanner.IDirectoryEntry Parent { get; }
            public IDirectoryEntry[] Subdirectories { get; }
            public JetBrains.Util.DirectoryScanner.IFileEntry GetFileEntry(string name) { }
            public JetBrains.Util.DirectoryScanner.IDirectoryEntry GetSubdirectory(string name) { }
        }
    }
    public delegate TElement ElementCreator<TKey, TElement>(TKey key);
    public class ElementsCache<TKey, TElement>
    
    
    {
        public ElementsCache(JetBrains.Util.ElementCreator<TKey, TElement> elementCreator) { }
        public JetBrains.Util.ElementCreator<TKey, TElement> ElementCreator { get; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public bool Contains(TKey key) { }
        public virtual void Drop(TKey key) { }
        public TElement Get(TKey key) { }
        protected virtual void OnAfterElementCreated(TKey key, TElement element) { }
        public virtual void Reset() { }
        public bool TryGet(TKey key, out TElement element) { }
    }
    public class static EmptyAction
    {
        public static readonly System.Action Instance;
    }
    public class static EmptyAction<T>
    
    {
        public static readonly System.Action<T> Instance;
    }
    public class static EmptyAction<T1, T2>
    
    
    {
        public static readonly System.Action<T1, T2> Instance;
    }
    public class static EmptyArray
    {
        [JetBrains.Annotations.ReturnsThreadSafeAttribute()]
        public static T[] GetInstance<T>() { }
    }
    public class static EmptyArray<T>
    
    {
        [JetBrains.Annotations.ImmutableAttribute()]
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly T[] Instance;
    }
    public class static EmptyDictionary<TKey, TValue>
    
    
    {
        [JetBrains.Annotations.ImmutableAttribute()]
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Collections.Generic.IDictionary<TKey, TValue> Instance;
    }
    [JetBrains.Annotations.ImmutableAttribute()]
    public class EmptyList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Collections.Generic.IList<T> InstanceList;
        public int Count { get; }
        public bool IsReadOnly { get; }
        public T this[int index] { get; set; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { }
        public void RemoveAt(int index) { }
    }
    public class static EncryptionUtil
    {
        public const string DES_KEY = "ReSharper DES key";
        public static string Decrypt(string encryptedValue) { }
        public static string Encrypt(string settingValue) { }
        public static string GetEncryptedString(string value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetEncryptedString(this JetBrains.Util.DataStructures.ISettingsTable settingsTable, string settingName) { }
        public static string GetEncryptedString(this JetBrains.Util.DataStructures.ISettingsTable settingsTable, string settingName, string defaultValue) { }
        public static string SetEncryptedString(string value) { }
        public static void SetEncryptedString(this JetBrains.Util.DataStructures.ISettingsTable settingsTable, string settingName, string value) { }
        public static string SHA1(this string input) { }
        public static string SHA1(this byte[] input) { }
        public static string ToHexString(this byte[] buf) { }
    }
    public enum EnsureWritableResult
    {
        SUCCESS = 0,
        FAILURE = 1,
        CHANGES_DETECTED = 2,
        CANCELLED = 3,
    }
    public class static EnumEx
    {
        public static T CoerceEnumValueSlow<T>(T value) { }
        public static System.Collections.Generic.IEnumerable<string> GetNamesOfValue([JetBrains.Annotations.NotNullAttribute()] System.Type type, object value) { }
        public static T[] GetValues<T>() { }
        public static bool Has<T>(this System.Enum @enum, T flag)
            where T :  struct { }
        public static bool HasAll<T>(this System.Enum @enum, params T[] flags)
            where T :  struct { }
        public static bool HasAny<T>(this System.Enum @enum, params T[] flags)
            where T :  struct { }
        public static System.Nullable<bool> ToBool(this string stringValue) { }
        public static System.Nullable<TEnum> ToEnum<TEnum>(this string stringValue)
            where TEnum :  struct { }
        public static TEnum ToEnum<TEnum>(this int intValue) { }
        public static int ToInt<TEnum>(TEnum enumValue) { }
        public static ulong UnboxQWord(object o) { }
    }
    public abstract class EnumPattern
    {
        protected EnumPattern([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public virtual bool Equals(object obj) { }
        public virtual int GetHashCode() { }
        public override string ToString() { }
    }
    public class EquatableList<TItem> : JetBrains.Util.IEquatableList<TItem>, System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.Generic.IList<TItem>, System.Collections.IEnumerable, System.IEquatable<JetBrains.Util.EquatableList<TItem>>
    
    {
        public EquatableList([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TItem> storage) { }
        public bool Equals(JetBrains.Util.EquatableList<TItem> other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class static ExceptionEx
    {
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AddData<TException>([JetBrains.Annotations.NotNullAttribute()] this TException exception, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, object value)
            where TException : System.Exception { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AddData<TException>([JetBrains.Annotations.NotNullAttribute()] this TException exception, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<object> FValue)
            where TException : System.Exception { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AddDataIndirect<TException>([JetBrains.Annotations.NotNullAttribute()] this TException exception, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Exception> FAddData)
            where TException : System.Exception { }
    }
    public class ExceptionOrigin { }
    public class static ExceptionRenderer
    {
        public static readonly string RenderedExceptionDataKey;
        public static readonly string RenderedExceptionMessageKey;
        public static readonly string RootExceptionPath;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<System.Exception> GetAllNestedExceptions(this System.Exception ex) { }
        public static JetBrains.Util.ExceptionText RenderException(this System.Exception ex) { }
        public static string RenderOuterExceptionMessageAndData(System.Exception ex) { }
        public class ExData
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Exception Exception;
            public readonly System.Guid Guid;
            public readonly System.Collections.Generic.List<JetBrains.Util.ExceptionRenderer.Line> Lines;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly System.Collections.Generic.List<string> Paths;
            public ExData([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.Util.ExceptionRenderer.ExData> parentstorage, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] params string[] path) { }
            public void AddInnerException(string relprefix, System.Exception exIn) { }
            public void AddLine([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value) { }
            public void AddPath([JetBrains.Annotations.NotNullAttribute()] string path) { }
            public void AddPathLines() { }
            public void DeleteLineExact([JetBrains.Annotations.NotNullAttribute()] params string[] names) { }
            public void DeleteLineSubstring([JetBrains.Annotations.NotNullAttribute()] string substring) { }
            public void DemoteLine(string name) { }
            public bool Equals(JetBrains.Util.ExceptionRenderer.ExData other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            public void PromoteLine(string name) { }
            public class static InnerExceptionReference
            {
                public static System.Guid GetReferencedGuid([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ExceptionRenderer.Line line) { }
                public static bool IsReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ExceptionRenderer.Line line) { }
                public static string MakeReference(System.Guid guidTarget) { }
                public static string MakeReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ExceptionRenderer.ExData target) { }
            }
        }
        public class Line
        {
            public string Name;
            public string Value;
            public Line(string name, string value) { }
            public static JetBrains.Util.ExceptionRenderer.Line Of(string name, string value) { }
        }
    }
    public class ExceptionText
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string FullText;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string Message;
        public ExceptionText([JetBrains.Annotations.NotNullAttribute()] string message, [JetBrains.Annotations.NotNullAttribute()] string fullText) { }
        public override string ToString() { }
    }
    public class static ExprHelper<TEntity>
    
    {
        public static System.Reflection.MemberInfo InfoOf<TResult>(System.Linq.Expressions.Expression<System.Func<TEntity, TResult>> expr) { }
        public static string NameOf<TResult>(System.Linq.Expressions.Expression<System.Func<TEntity, TResult>> expr) { }
        public static System.Reflection.PropertyInfo PropertyInfoOf<TResult>(System.Linq.Expressions.Expression<System.Func<TEntity, TResult>> expr) { }
    }
    public class static FEx
    {
        public static System.Func<TY> Beta<TX, TY>(this System.Func<TX, TY> func, TX value) { }
        public static System.Func<TY> Beta<TX, TY>(this System.Func<TX, TY> FToBeta, System.Func<TX> FGetValue) { }
        public static System.Func<TY, TResult> Beta<TX, TY, TResult>(this System.Func<TX, TY, TResult> func, TX value) { }
        public static System.Func<TX, TResult> Beta<TX, TY, TResult>(this System.Func<TX, TY, TResult> func, TY value) { }
        public static System.Func<TX, TResult> BetaX<TX, TY, TZ, TResult>(this System.Func<TX, TY, TZ, TResult> func, TY y, TZ z) { }
        public static System.Action<TY, TZ> BetaX<TX, TY, TZ>(this System.Action<TX, TY, TZ> func, TX x) { }
        public static System.Action<TY> BetaX<TX, TY>(this System.Action<TX, TY> func, TX x) { }
        public static System.Action<TZ> BetaXY<TX, TY, TZ>(this System.Action<TX, TY, TZ> func, TX x, TY y) { }
        public static System.Action<TY> BetaXZ<TX, TY, TZ>(this System.Action<TX, TY, TZ> func, TX x, TZ z) { }
        public static System.Func<TY, TResult> BetaY<TX, TY, TZ, TResult>(this System.Func<TX, TY, TZ, TResult> func, TX x, TZ z) { }
        public static System.Action<TX, TZ> BetaY<TX, TY, TZ>(this System.Action<TX, TY, TZ> func, TY y) { }
        public static System.Action<TX> BetaY<TX, TY>(this System.Action<TX, TY> func, TY y) { }
        public static System.Action<TX> BetaYZ<TX, TY, TZ>(this System.Action<TX, TY, TZ> func, TY y, TZ z) { }
        public static System.Func<TZ, TResult> BetaZ<TX, TY, TZ, TResult>(this System.Func<TX, TY, TZ, TResult> func, TX x, TY y) { }
        public static System.Action<TX, TY> BetaZ<TX, TY, TZ>(this System.Action<TX, TY, TZ> func, TZ z) { }
        public static T Return<T>(System.Action<System.Func<System.Func<T>, System.Action>> FOuter) { }
    }
    public class static FileSystemDefinition
    {
        public static readonly char AltDirectorySeparatorChar;
        public static readonly string AltDirectorySeparatorString;
        public static readonly char DirectorySeparatorChar;
        public static readonly string DirectorySeparatorString;
        public static readonly char[] InvalidFileNameChars;
        public static readonly char[] InvalidPathChars;
        public static readonly char VolumeSeparatorChar;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath CreateTemporaryDirectory(JetBrains.Util.FileSystemPath parent = null, string prefix = "") { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath CreateTemporaryDirectory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath parent = null, string prefix = "") { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath CreateTemporaryFile(JetBrains.Util.FileSystemPath parent = null, string extensionWithDot = ".bin", string prefix = "", System.Action<System.IO.FileStream> handler = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath CreateTemporaryFile(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath parent = null, string extensionWithDot = ".bin", string prefix = "", System.Action<System.IO.FileStream> handler = null) { }
        public static JetBrains.Util.FileSystemPath[] GetRoots() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetTempPath() { }
    }
    public class FileSystemEntryInfo
    {
        public readonly System.DateTime AccessTimeUtc;
        public readonly System.IO.FileAttributes Attributes;
        public readonly System.DateTime CreationTimeUtc;
        public readonly long Length;
        public readonly System.DateTime ModificationTimeUtc;
        public readonly JetBrains.Util.FileSystemPath Path;
        public FileSystemEntryInfo(JetBrains.Util.FileSystemPath path, System.IO.FileAttributes attributes, System.DateTime modificationTimeUtc, System.DateTime accessTimeUtc, System.DateTime creationTimeUtc, long length) { }
        public bool IsDirectory { get; }
        public bool IsFile { get; }
    }
    public struct FileSystemEvent
    {
        public readonly string ErrorMessage;
        public readonly string Name;
        public readonly string OldName;
        public readonly JetBrains.Util.FileSystemEventType Type;
        public readonly JetBrains.Util.JetFileSystemWatcher Watcher;
        public JetBrains.Util.FileSystemPath FullPath { get; }
        public JetBrains.Util.FileSystemPath OldFullPath { get; }
        public static JetBrains.Util.FileSystemEvent CreateFileChangedEvent(JetBrains.Util.JetFileSystemWatcher watcher, string name) { }
        public static JetBrains.Util.FileSystemEvent CreateFileCreatedEvent(JetBrains.Util.JetFileSystemWatcher watcher, string name) { }
        public static JetBrains.Util.FileSystemEvent CreateFileRemovedEvent(JetBrains.Util.JetFileSystemWatcher watcher, string name) { }
        public static JetBrains.Util.FileSystemEvent CreateFileRenamedEvent(JetBrains.Util.JetFileSystemWatcher watcher, string name, string oldName) { }
        public static JetBrains.Util.FileSystemEvent CreateWatchedDirectoryAbortedEvent(JetBrains.Util.JetFileSystemWatcher watcher) { }
        public static JetBrains.Util.FileSystemEvent CreateWatchedDirectoryDeletedEvent(JetBrains.Util.JetFileSystemWatcher watcher) { }
        public static JetBrains.Util.FileSystemEvent CreateWatcherErrorEvent(JetBrains.Util.JetFileSystemWatcher watcher, string errorMessage) { }
        public static JetBrains.Util.FileSystemEvent CreateWatcherEventsBufferOverflowEvent(JetBrains.Util.JetFileSystemWatcher watcher) { }
    }
    public enum FileSystemEventType
    {
        None = 0,
        FileChanged = 1,
        FileCreated = 2,
        FileRenamed = 3,
        FileRemoved = 4,
        WatcherError = 5,
        WatcherEventsBufferOverflow = 6,
        WatchedDirectoryDeleted = 7,
        WatchedDirectoryAborted = 8,
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Util.FileSystemPathConverter))]
    [System.Windows.Markup.ValueSerializerAttribute(typeof(JetBrains.Util.FileSystemPathSerializer))]
    public sealed class FileSystemPath : System.IEquatable<JetBrains.Util.FileSystemPath>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Util.FileSystemPath Empty;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string FullPath;
        public const string LongPathPrefix = "\\\\?\\";
        public const string LongUncPathPrefix = "\\\\?\\UNC\\";
        public static readonly System.DateTime NonexistentFileDateTime;
        [System.ObsoleteAttribute("The constructor is left for backward compatibility only. Use FileSystemPath.Parse" +
            " or FileSystemPath.TryParse instead")]
        public FileSystemPath([JetBrains.Annotations.NotNullAttribute()] string path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath Directory { get; }
        public JetBrains.Util.FileSystemPath.Existence Exists { get; }
        public bool ExistsDirectory { get; }
        public bool ExistsFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ExtensionNoDot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ExtensionWithDot { get; }
        public string FileAccessPath { get; }
        public System.DateTime FileModificationTimeUtc { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string FirstComponent { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemEntryInfo Info { get; }
        public bool IsAbsolute { get; }
        public bool IsEmpty { get; }
        public bool IsHidden { get; }
        public bool IsLocked { get; }
        public bool IsSystem { get; }
        public bool IsUnc { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string NameWithoutExtension { get; }
        public static void AllowIntern(JetBrains.DataFlow.Lifetime lifetime, int maxEntries = 2147483647) { }
        public static void AllowIntern(bool allowIntern, int maxEntries = 2147483647) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath ChangeExtension([JetBrains.Annotations.CanBeNullAttribute()] string newExtension) { }
        public static void ClearIntern() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath Clone() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath Combine([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath Combine([JetBrains.Annotations.CanBeNullAttribute()] string component) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath CombineWithShortName([JetBrains.Annotations.NotNullAttribute()] string shortName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath ConvertToRelativePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath basePath) { }
        public void CopyFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath destinationFilePath, bool overwrite) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath CreateByCanonicalPath([JetBrains.Annotations.NotNullAttribute()] string path) { }
        public JetBrains.Util.FileSystemPath CreateDirectory() { }
        public void DeleteDirectoryNonRecursive() { }
        public void DeleteFile() { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Util.FileSystemPath other) { }
        public System.IO.FileAttributes GetAttributes() { }
        public JetBrains.Util.StringSlice GetComputerName() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetDeepestCommonParent([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath first, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath second) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetDirectoryEntries(string mask, bool files) { }
        public char GetDriveName() { }
        public long GetFileLength() { }
        public override int GetHashCode() { }
        public JetBrains.Util.FileSystemPath GetLongPath() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string[] GetPathComponents() { }
        public JetBrains.Util.FileSystemPath GetShortPath() { }
        public bool IsPrefixOf([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath otherPath) { }
        public bool IsSuffixOf([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath otherPath) { }
        public void Move([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath destinationFilePath) { }
        public Microsoft.Win32.SafeHandles.SafeFileHandle OpenFileHandle(System.IO.FileMode fileMode, System.IO.FileAccess fileAccess, System.IO.FileShare fileShare = 1) { }
        public System.IO.FileStream OpenStream(System.IO.FileMode mode) { }
        public System.IO.FileStream OpenStream(System.IO.FileMode fileMode, System.IO.FileAccess fileAccess, System.IO.FileShare fileShare = 1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.Util.FileSystemPath Parse([JetBrains.Annotations.NotNullAttribute()] string path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath RemoveFirstComponent() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.FileSystemPath RemovePrefix([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath prefix) { }
        public void SetAttributes(System.IO.FileAttributes fileAttributes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Uri ToDirectoryUri() { }
        public override string ToString() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Uri ToUri() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath TryCombine([JetBrains.Annotations.NotNullAttribute()] string component) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.Util.FileSystemPath TryParse([JetBrains.Annotations.CanBeNullAttribute()] string path) { }
        public bool Unblock() { }
        public enum Existence
        {
            Missing = 0,
            File = 1,
            Directory = 2,
        }
    }
    public class FileSystemPathConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.Util.FileSystemPath>
    {
        public FileSystemPathConverter() { }
    }
    public class static FileSystemPathEx
    {
        public static JetBrains.Util.FileSystemPath AddSuffix([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] string suffix) { }
        public static bool CleanUpChildren([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static void CopyDirectory([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath sourceDirectoryPath, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath destinationDirectoryPath, bool overwrite = True, System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> excludes = null) { }
        public static void Delete(this JetBrains.Util.FileSystemPath path) { }
        public static void DeleteChildren([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static void EnsureWritable([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath fsp) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetChildDirectories([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] string mask = "*", JetBrains.Util.PathSearchFlags flags = 0) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> GetChildFiles([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] string mask = "*", JetBrains.Util.PathSearchFlags flags = 0) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetParentDirectories([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetPath([JetBrains.Annotations.NotNullAttribute()] this System.Reflection.Assembly @this) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("path:null => true")]
        public static bool IsNullOrEmpty([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("path:null => false")]
        public static bool IsRelativeToDriveRoot([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static System.IO.Stream OpenFileForAppend([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static System.IO.Stream OpenFileForAppendExclusive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static System.IO.Stream OpenFileForReading([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static System.IO.Stream OpenFileForReadingExclusive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static System.IO.Stream OpenFileForWriting([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static System.IO.Stream OpenFileForWritingExclusive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string QuoteIfNeeded([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Util.FileSystemPath path) { }
        public static byte[] ReadAllBytes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath file) { }
        public static string ReadAllText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath file, System.Text.Encoding encoding = null) { }
        public static void ReadBinaryStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.BinaryReader> FRead) { }
        public static T ReadBinaryStream<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.IO.BinaryReader, T> FRead) { }
        public static void ReadStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> FRead) { }
        public static T ReadStream<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.IO.Stream, T> FRead) { }
        public static void ReadStreamExclusive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> FRead) { }
        public static void ReadTextStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.StreamReader> FRead, System.Text.Encoding encoding = null) { }
        public static T ReadTextStream<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.IO.StreamReader, T> FRead, System.Text.Encoding encoding = null) { }
        public static JetBrains.Util.FileSystemPath ToAbsolutePath(this JetBrains.Util.FileSystemPath @this, JetBrains.Util.FileSystemPath pathBaseForRelatives) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath ToFileSystemPath([JetBrains.Annotations.NotNullAttribute()] this System.Uri uri) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath ToFileSystemPath(this System.Environment.SpecialFolder specialFolder) { }
        public static System.IO.FileAttributes TryGetAttributes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath filePath) { }
        public static void WriteAllBytes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath file, byte[] bytes) { }
        public static void WriteAllText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath file, string content, System.Text.Encoding encoding = null) { }
        public static void WriteBinaryStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.BinaryWriter> FWrite) { }
        public static void WriteStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> FWrite) { }
        public static void WriteStreamExclusive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.Stream> FWrite) { }
        public static void WriteTextStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.StreamWriter> FWrite) { }
        public static void WriteTextStream([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.FileSystemPath path, System.Text.Encoding encoding, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.StreamWriter> FWrite) { }
    }
    public class static FileSystemPathParser
    {
        public static readonly char DOT;
        public static bool CanBeProvenNormalizedFast([JetBrains.Annotations.NotNullAttribute()] string path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Normalize([JetBrains.Annotations.NotNullAttribute()] string path) { }
    }
    public class FileSystemPathSerializer : JetBrains.Util.Reflection.ValueSerializerBase<JetBrains.Util.FileSystemPath>
    {
        public FileSystemPathSerializer() { }
    }
    public class FileSystemPathTrie<T> : JetBrains.Util.QualifiedNamesTrie<T>
    
    {
        public FileSystemPathTrie(bool preserveNames) { }
        public T this[JetBrains.Util.FileSystemPath path] { get; set; }
        public void Add(JetBrains.Util.FileSystemPath fsp, T o) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T Find(JetBrains.Util.FileSystemPath fsp) { }
        public T FindLongestPrefix(JetBrains.Util.FileSystemPath fsp) { }
        public JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode FindTrieNode(JetBrains.Util.FileSystemPath fsp) { }
        public TrieEntry[] GetChildren(JetBrains.Util.FileSystemPath fsp) { }
        public System.Collections.Generic.IList<T> GetChildrenData(JetBrains.Util.FileSystemPath fsp) { }
        public System.Collections.Generic.IList<T> GetSubTreeData(JetBrains.Util.FileSystemPath fsp) { }
        public void MoveSubtree(JetBrains.Util.FileSystemPath oldPath, JetBrains.Util.FileSystemPath newPath) { }
        public bool Remove(JetBrains.Util.FileSystemPath fsp) { }
        public bool RemoveSubtree(JetBrains.Util.FileSystemPath fsp) { }
    }
    public class static FileSystemUtil
    {
        public static void CopyFolders(JetBrains.Util.FileSystemPath srcFolder, JetBrains.Util.FileSystemPath dstFolder) { }
        public static bool DeleteDir(JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetCurrentDirectory() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetDirectoryNameOfFileAbove([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathStartingPoint, [JetBrains.Annotations.NotNullAttribute()] string sMarkerFileName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetSystemDirectory() { }
        public static System.IDisposable SetCurrentDirectory([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public static void SetCurrentDirectory([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath TryGetDirectoryNameOfFileAbove([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathStartingPoint, [JetBrains.Annotations.NotNullAttribute()] string sMarkerFileName) { }
    }
    public class FilteringEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    
    {
        public FilteringEnumerator([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerator<T> baseEnumerator, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<T> predicate) { }
        public object Current { get; }
        public void Dispose() { }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public class FilteringLogger : JetBrains.Util.ILogger
    {
        public FilteringLogger([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForwardTo, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<System.Exception, JetBrains.Util.ExceptionOrigin, bool> FIsForwardingException, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<System.Exception, JetBrains.Util.ExceptionOrigin, bool> FIsForwardingThrowableException, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<string, JetBrains.Util.LoggingLevel, bool> FIsForwardingMessage) { }
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
        public void LogException(System.Exception ex, JetBrains.Util.ExceptionOrigin origin) { }
        public void LogMessage(string message, JetBrains.Util.LoggingLevel level) { }
        public void LogOrThrowException(System.Exception ex, JetBrains.Util.ExceptionOrigin origin) { }
    }
    public class Foo { }
    public class ForeignCodeExorigin : JetBrains.Util.InCodeExorigin { }
    public class static GuidExtensions
    {
        public static string ToUpperString(this System.Guid guid) { }
        public static System.Guid TryParseGuid(string value) { }
    }
    public interface ICloneable<T> : System.ICloneable
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        T Clone();
    }
    public class static IdentityFunc<T1, T2>
        where T1 : T2
    
    {
        public static readonly System.Converter<T1, T2> Converter;
        public static readonly System.Func<T1, T2> Instance;
    }
    public class IdsMap<TItem>
    
    {
        public IdsMap() { }
        public IdsMap(uint minId, int expectedFilesCount) { }
        public int Count { get; }
        public int IdBits { get; }
        public event JetBrains.Util.BitsIncreasedHandler OnIdBitsIncreased;
        public uint GetIdByItem(TItem item) { }
        public TItem GetItemById(uint id) { }
        public bool HasId(TItem item) { }
    }
    public interface IEquatableList<TItem> : System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.Generic.IList<TItem>, System.Collections.IEnumerable, System.IEquatable<JetBrains.Util.EquatableList<TItem>> { }
    public interface ILogEventListener
    {
        void OnError([JetBrains.Annotations.NotNullAttribute()] string error);
        void OnException([JetBrains.Annotations.NotNullAttribute()] System.Exception ex);
        void OnMessage([JetBrains.Annotations.NotNullAttribute()] string message, JetBrains.Util.LoggingLevel level);
    }
    public interface ILogger
    {
        bool IsEnabled(JetBrains.Util.LoggingLevel level);
        void LogException([JetBrains.Annotations.NotNullAttribute()] System.Exception ex, JetBrains.Util.ExceptionOrigin origin);
        void LogMessage([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string message, JetBrains.Util.LoggingLevel level = 4);
        void LogOrThrowException([JetBrains.Annotations.NotNullAttribute()] System.Exception ex, JetBrains.Util.ExceptionOrigin origin);
    }
    public class static ILoggerEx
    {
        public static void Catch([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ExceptionOrigin origin) { }
        public static TValue Catch<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ExceptionOrigin origin) { }
        public static void CatchAsAlgorithmError([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static TValue CatchAsAlgorithmError<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F) { }
        public static void CatchAsForeignException([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static TValue CatchAsForeignException<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F) { }
        public static void CatchAsOuterDataError([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public static TValue CatchAsOuterDataError<TValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F) { }
        public static void Error([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        public static void Error([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.CanBeNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Error<T1>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message, T1 t1) { }
        public static void Info([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Info<T1>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Info<T1, T2>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1, T2 t2) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Info<T1, T2, T3>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1, T2 t2, T3 t3) { }
        public static bool IsTraceEnabled([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this) { }
        public static bool IsVersboseEnabled([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this) { }
        public static void LogAlgorithmError([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string comment = null) { }
        public static void LogAssertion([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string comment = null) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogBracket([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.LoggingLevel level, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogBracket([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.LoggingLevel level, [JetBrains.Annotations.NotNullAttribute()] string message, params object[] args) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogBracket([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.LoggingLevel level, [JetBrains.Annotations.NotNullAttribute()] string opening, [JetBrains.Annotations.NotNullAttribute()] string closing) { }
        public static void LogExceptionSilently([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        public static void LogForeignException([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string comment = null) { }
        public static void LogMessage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, JetBrains.Util.LoggingLevel level, string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogMessage<T1>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, JetBrains.Util.LoggingLevel level, string message, T1 t1) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogMessage<T1, T2>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, JetBrains.Util.LoggingLevel level, string message, T1 t1, T2 t2) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogMessage<T1, T2, T3>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, JetBrains.Util.LoggingLevel level, string message, T1 t1, T2 t2, T3 t3) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogMessage<T1, T2, T3, T4>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, JetBrains.Util.LoggingLevel level, string message, T1 t1, T2 t2, T3 t3, T4 t4) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void LogMessage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, JetBrains.Util.LoggingLevel level, string message, params object[] args) { }
        public static void LogOuterDataException([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string comment = null) { }
        public static void Trace([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Trace<T1>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Trace<T1, T2>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1, T2 t2) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Trace<T1, T2, T3>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1, T2 t2, T3 t3) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Trace<T1, T2, T3, T4>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, string message, T1 t1, T2 t2, T3 t3, T4 t4) { }
        public static void Verbose([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Warn([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Warn<T1>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message, T1 t1) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Warn<T1, T2>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message, T1 t1, T2 t2) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Warn<T1, T2, T3>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message, T1 t1, T2 t2, T3 t3) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("message")]
        public static void Warn<T1, T2, T3, T4>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.ILogger @this, [JetBrains.Annotations.NotNullAttribute()] string message, T1 t1, T2 t2, T3 t3, T4 t4) { }
    }
    public class InCodeExorigin : JetBrains.Util.ExceptionOrigin { }
    public class static IndentedTextWriterEx
    {
        public static System.IDisposable Indent(this System.CodeDom.Compiler.IndentedTextWriter indentedTextWriter) { }
    }
    public class IndexComparer<T> : System.Collections.Generic.IComparer<T>
    
    {
        public IndexComparer(System.Collections.Generic.IList<T> list) { }
        public IndexComparer(params T[] array) { }
        public int Compare(T x, T y) { }
    }
    public class InformationalExorigin : JetBrains.Util.ExceptionOrigin { }
    public class InternalErrorException : System.ApplicationException
    {
        public InternalErrorException(string details) { }
        public InternalErrorException(string format, params object[] args) { }
        protected InternalErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { }
    }
    public class InvalidPathException : System.Exception
    {
        public InvalidPathException(string path) { }
        public InvalidPathException(string format, params object[] args) { }
    }
    public interface IOneToManyMap<TKey, in TValue, TCollection> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TCollection>>, System.Collections.IEnumerable
    
    
        where TCollection : System.Collections.Generic.ICollection<>
    {
        void Add(TKey key, TValue value);
        TCollection GetValuesSafe(TKey key);
        bool Remove(TKey key, TValue value);
    }
    public class static IOUtil
    {
        public static void CopyDirectory(string directoryPath, string newDirectoryPath) { }
        public static void CopyDirectory(string directoryPath, string newDirectoryPath, bool keepOriginalTimestamps, JetBrains.Util.IOUtil.FileAlreadyExistsPolicy fileAlreadyExistsPolicy) { }
        public static bool IsValidPath(string path) { }
        public enum FileAlreadyExistsPolicy
        {
            ABORT = 0,
            OVERWRITE = 1,
            SKIP = 2,
        }
    }
    public interface IPresentableStructureElement
    {
        object PresentationObject { get; }
    }
    public enum IsDisposedState
    {
        Live = 0,
        Disposing = 1,
        Disposed = 2,
    }
    public interface ITransactionCookie : System.IDisposable
    {
        void AddUndoRedoHandler(JetBrains.Util.IUndoRedoHandler handler);
        JetBrains.Util.TransactionCommitResult Commit(JetBrains.Application.Progress.IProgressIndicator pi);
        void Rollback();
    }
    public interface IUndoRedoHandler
    {
        void Do();
        void Redo();
        void Undo();
    }
    public interface IUserDataHolder
    {
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData();
        [JetBrains.Annotations.CanBeNullAttribute()]
        T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class;
        void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class;
    }
    public class JetFileSystemWatcher : System.IDisposable
    {
        public static int TotalBuffers;
        public JetBrains.Util.FileSystemPath Directory { get; }
        public bool Disposed { get; }
        public JetBrains.Util.PathWildcard Filter { get; }
        public bool IncludeSubdirectories { get; }
        public System.IO.NotifyFilters NotifyFilters { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.JetFileSystemWatcher Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.CanBeNullAttribute()] string filter, System.IO.NotifyFilters notifyFilter, bool includeSubdirectories, JetBrains.Util.JetFileSystemWatcher.IWatcherEvents watcherEvents, out JetBrains.Interop.WinApi.WinError rc) { }
        public void Dispose() { }
        public override string ToString() { }
        public interface IWatcherEvents
        {
            void OnFileSystemChanged(JetBrains.Util.FileSystemEvent[] events);
        }
    }
    public class static JetFunc
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Func<bool> False;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Func<bool> True;
    }
    public class static JetFunc<T>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Func<T, bool> False;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Func<T, T> Identity;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Converter<T, T> IdentityConverter;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Func<T, bool> True;
    }
    public class static JetFunc<T1, T2>
    
    
    {
        public static readonly System.Func<T1, T2, bool> False;
        public static readonly System.Func<T1, T2, bool> True;
    }
    public class static JetPredicate<T>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Predicate<T> False;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly System.Predicate<T> True;
    }
    public class static JetTuple
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.JetTuple<TA> Of<TA>(TA a) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.JetTuple<TA, TB> Of<TA, TB>(TA a, TB b) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.JetTuple<TA, TB, TC> Of<TA, TB, TC>(TA a, TB b, TC c) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.JetTuple<TA, TB, TC, TD> Of<TA, TB, TC, TD>(TA a, TB b, TC c, TD d) { }
    }
    public class JetTuple<TA>
    
    {
        public JetTuple(TA a) { }
        public TA A { get; set; }
        public override string ToString() { }
    }
    public class JetTuple<TA, TB>
    
    
    {
        public JetTuple(TA a, TB b) { }
        public TA A { get; set; }
        public TB B { get; set; }
        public override string ToString() { }
    }
    public class JetTuple<TA, TB, TC>
    
    
    
    {
        public JetTuple(TA a, TB b, TC c) { }
        public TA A { get; set; }
        public TB B { get; set; }
        public TC C { get; set; }
        public override string ToString() { }
    }
    public class JetTuple<TA, TB, TC, TD>
    
    
    
    
    {
        public JetTuple(TA a, TB b, TC c, TD d) { }
        public TA A { get; set; }
        public TB B { get; set; }
        public TC C { get; set; }
        public TD D { get; set; }
        public override string ToString() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Key: {ToString()}")]
    public class Key : JetBrains.Util.Key<object>
    {
        public Key([System.ComponentModel.LocalizableAttribute(false)] string text) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Key: {ToString()}")]
    public class Key<T>
        where T :  class
    {
        public Key([System.ComponentModel.LocalizableAttribute(false)] string text) { }
        public override string ToString() { }
    }
    public class static KeyValuePair
    {
        public static System.Collections.Generic.KeyValuePair<TKey, TValue> Of<TKey, TValue>(TKey key, TValue value) { }
    }
    public class static ListUtil
    {
        public static void Insert<TItem>([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<TItem> thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, int index, TItem item) { }
        public static void Insert([JetBrains.Annotations.NotNullAttribute()] this System.Collections.IList thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, int index, object item) { }
        public static System.Collections.Generic.List<T> SubtractSortedInplace<T>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<T> minuend, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<T> subtrahend)
            where T : System.IComparable<> { }
        public static string ToSortedString<T>(System.Collections.Generic.ICollection<T> list) { }
        public static string ToString<T>(System.Collections.Generic.ICollection<T> list) { }
        public static TValue ValueOrDefault<TKey, TValue>(this System.Collections.Generic.IDictionary<TKey, TValue> dictionary, TKey key) { }
    }
    public struct LocalHashSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public int Count { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.JetHashSet<T> HashSet { get; }
        public bool IsEmpty { get; }
        public bool IsReadOnly { get; }
        public bool Add(T t) { }
        public void AddRange(System.Collections.Generic.IEnumerable<T> array) { }
        public void Clear() { }
        public bool Contains(T t) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.JetHashSet<T>.ElementEnumerator GetEnumerator() { }
        public bool Remove(T element) { }
        public T[] ToArray() { }
        public void UnionWith(System.Collections.Generic.IEnumerable<T> array) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(JetBrains.Util.LocalListDebugView<>))]
    public struct LocalList<T>
    
    {
        public LocalList(int size, bool exact = False) { }
        public LocalList(System.Collections.Generic.IEnumerable<T> enumerable) { }
        public LocalList(T[] array) { }
        public int Capacity { get; }
        public int Count { get; }
        public T this[int index] { get; set; }
        public void Add(T item) { }
        public void AddRange<TSource>(System.Collections.Generic.IEnumerable<TSource> items)
            where TSource : T { }
        public void AddRange(System.Collections.Generic.IEnumerable<T> items) { }
        public void AddRange(JetBrains.Util.LocalList<T> items) { }
        public void AddRange<TSource>(TSource[] items)
            where TSource : T { }
        public void AddRange(System.Collections.Generic.ICollection<T> items) { }
        public bool Any() { }
        public bool Any([JetBrains.Annotations.InstantHandleAttribute()] System.Func<T, bool> predicate) { }
        public void Clear() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains(T item) { }
        [JetBrains.Annotations.PureAttribute()]
        public void CopyTo(T[] array, int arrayIndex) { }
        public T First() { }
        public T FirstOrDefault() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.LocalList<T>.ElementEnumerator GetEnumerator() { }
        [JetBrains.Annotations.PureAttribute()]
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public T Last() { }
        public T LastOrDefault() { }
        public bool Remove(T item) { }
        public void RemoveAt(int index) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public System.Collections.Generic.IList<T> ResultingList() { }
        public T Single() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T[] ToArray() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public TResult[] ToArray<TResult>(System.Func<T, TResult> transform) { }
        public override string ToString() { }
        public struct ElementEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        
        {
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
            public void Reset() { }
        }
        [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
        [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(JetBrains.Util.ResultListDebugView<>))]
        public class ResultList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IEnumerator<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable, System.Collections.IEnumerator, System.IDisposable
        
        {
            public ResultList(T[] array, int count) { }
            public int Count { get; }
            public T Current { get; }
            public bool IsReadOnly { get; }
            public T this[int index] { get; set; }
            public void Add(T item) { }
            public void Clear() { }
            public bool Contains(T item) { }
            public void CopyTo(T[] array, int arrayIndex) { }
            public void Dispose() { }
            public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
            public int IndexOf(T item) { }
            public void Insert(int index, T item) { }
            public bool MoveNext() { }
            public bool Remove(T item) { }
            public void RemoveAt(int index) { }
            public void Reset() { }
            public T[] ToArray() { }
        }
    }
    public struct LocalUserDataHolder : JetBrains.Util.IUserDataHolder
    {
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData() { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        public void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class { }
    }
    public delegate int Locator<in T>(T leftside);
    public struct LogCookie : System.IDisposable
    {
        public LogCookie(string comment) { }
        public void Dispose() { }
        public static void Execute([JetBrains.Annotations.NotNullAttribute()] string comment, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
    }
    public class LoggerException : System.ApplicationException
    {
        public LoggerException(string message = null, System.Exception innerException = null, System.Nullable<int> ignoreFrames = 0, JetBrains.Util.LoggerException.ToStringBehavior toStringBehavior = 0) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        protected LoggerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string StackTrace { get; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Exception WrapException([JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.CanBeNullAttribute()] string comment = null, bool bDumpCurrentStack = True) { }
        public enum ToStringBehavior
        {
            RenderExceptionFullText = 0,
            BaseException = 1,
        }
    }
    public class LoggingEvent { }
    public enum LoggingLevel
    {
        OFF = 0,
        FATAL = 1,
        ERROR = 2,
        WARN = 3,
        NORMAL = 4,
        INFO = 4,
        VERBOSE = 5,
        DEBUG = 5,
        TRACE = 6,
    }
    public enum MbButton : uint
    {
        MB_OK = 0u,
        MB_OKCANCEL = 1u,
        MB_ABORTRETRYIGNORE = 2u,
        MB_YESNOCANCEL = 3u,
        MB_YESNO = 4u,
        MB_RETRYCANCEL = 5u,
        MB_CANCELTRYCONTINUE = 6u,
    }
    public enum MbIcon : uint
    {
        MB_ICONHAND = 16u,
        MB_ICONQUESTION = 32u,
        MB_ICONEXCLAMATION = 48u,
        MB_ICONASTERISK = 64u,
    }
    public class static MessageBox
    {
        public static readonly JetBrains.DataFlow.ListEvents<System.Func<System.IntPtr MessageBoxHandlers;
        public static JetBrains.Interop.WinApi.DialogBoxCommandId ShowCore(System.IntPtr window, [JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption, JetBrains.Interop.WinApi.MessageBoxFlags flags) { }
        public static void ShowError([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption = "") { }
        public static void ShowError([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption, System.IntPtr window) { }
        public static void ShowExclamation([JetBrains.Annotations.NotNullAttribute()] string text, string caption = "") { }
        public static void ShowExclamation([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption, System.IntPtr window) { }
        public static bool ShowExclamationOkCancel([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public static void ShowInfo([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption = "") { }
        public static void ShowInfo([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption, System.IntPtr window) { }
        public static JetBrains.Interop.WinApi.DialogBoxCommandId ShowMessageBox([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption, System.IntPtr window, JetBrains.Util.MbButton button, JetBrains.Util.MbIcon icon) { }
        public static JetBrains.Interop.WinApi.DialogBoxCommandId ShowMessageBox([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] string caption, JetBrains.Util.MbButton button, JetBrains.Util.MbIcon icon) { }
        public static JetBrains.Interop.WinApi.DialogBoxCommandId ShowMessageBox([JetBrains.Annotations.NotNullAttribute()] string text, JetBrains.Util.MbButton button, JetBrains.Util.MbIcon icon) { }
        public static bool ShowYesNo(string text, string caption = "") { }
        public static bool ShowYesNo(string text, string caption, System.IntPtr window) { }
        public static System.Nullable<bool> ShowYesNoCancel(string text, string caption = "") { }
        public static System.Nullable<bool> ShowYesNoCancel(string text, string caption, System.IntPtr window) { }
    }
    public class ModificationCookie : System.IDisposable
    {
        public ModificationCookie(JetBrains.Util.EnsureWritableResult ensureWritableResult) { }
        public ModificationCookie(JetBrains.Util.EnsureWritableResult ensureWritableResult, string message) { }
        public JetBrains.Util.EnsureWritableResult EnsureWritableResult { get; }
        public string Message { get; }
        public event System.EventHandler ModificationFinished;
        public void Dispose() { }
    }
    public class MultiTypeComparer : System.Collections.Generic.IComparer<object>
    {
        public MultiTypeComparer() { }
        public MultiTypeComparer(System.Collections.Generic.IEnumerable<System.Type> typeLinearOrder) { }
        public System.Collections.Generic.IList<System.Type> TypeLinearOrder { get; }
        public int Compare(object x, object y) { }
        public void Compare<T>() { }
        public void Compare<T>(JetBrains.Util.Comparator<T> callback) { }
        protected static System.Type DisambiguateRule(System.Type candidate1, System.Type candidate2, System.Type winner, System.Type loser) { }
        protected virtual System.Type DisambiguateTypeConflict(System.Type t1, System.Type t2) { }
        protected virtual object Unwrap(object wrapper) { }
    }
    public class NamedAutoResetEvent : System.Threading.WaitHandle
    {
        public NamedAutoResetEvent(string name, bool initialState) { }
        public void Reset() { }
        public void Set() { }
    }
    public class static nameof
    {
        public static string Property<TV>(System.Linq.Expressions.Expression<System.Func<TV>> property) { }
    }
    public class static nameof<T>
    
    {
        public static string Property<TV>(System.Linq.Expressions.Expression<System.Func<T, TV>> property) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Module | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.ReturnValue | System.AttributeTargets.GenericParameter | System.AttributeTargets.All)]
    public class NoReorder : System.Attribute { }
    public class static NounUtil
    {
        public static string GetCountString(int argumentIndex) { }
        public static string GetPlural(string singular) { }
        public static string GetSingular(string plural) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToPluralOrSingular([JetBrains.Annotations.NotNullAttribute()] string singular, int count) { }
    }
    public class static NullableEx
    {
        public static System.Nullable<T> ToNullable<T>(this T t)
            where T :  struct { }
    }
    public class OnError
    {
        public static readonly JetBrains.Util.OnError Ignore;
        public static readonly JetBrains.Util.OnError LogException;
        public static readonly JetBrains.Util.OnError LogExceptionSilently;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Util.OnError Throw;
        public OnError([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Exception> handler) { }
        public void Handle([JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.OnError LogAlgorithmError(JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.OnError LogAssertion(JetBrains.Util.ILogger logger) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.OnError ThrowMessage(string message) { }
        public override string ToString() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.OnError WithMessage([JetBrains.Annotations.NotNullAttribute()] string message) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(JetBrains.Util.OneToListMap<, >.OneToListMapDebugView))]
    public class OneToListMap<TKey, TValue> : JetBrains.Util.IOneToManyMap<TKey, TValue, System.Collections.Generic.IList<TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>>, System.Collections.IEnumerable
    
    
    {
        public OneToListMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> enumerable, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public OneToListMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> enumerable, System.Collections.Generic.IEqualityComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer) { }
        public OneToListMap(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public OneToListMap(int capacity, System.Collections.Generic.IEqualityComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer) { }
        public OneToListMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> enumerable) { }
        public OneToListMap(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public OneToListMap(System.Collections.Generic.IEqualityComparer<TKey> keyComparer, System.Collections.Generic.IEqualityComparer<TValue> valueComparer) { }
        public OneToListMap(int capacity) { }
        public OneToListMap() { }
        public int Count { get; }
        public JetBrains.Util.OneToListMap<TKey, TValue>.ValueCollection this[TKey key] { get; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<TValue> Values { get; }
        public void Add(TKey key, TValue value) { }
        public void AddValue(TKey key, TValue value) { }
        public void AddValueRange(TKey key, System.Collections.Generic.IEnumerable<TValue> list) { }
        public void Clear() { }
        public void ClearKey(TKey key) { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsPair(TKey key, TValue value) { }
        public bool ContainsValue(TValue value) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> GetEnumerator() { }
        public JetBrains.Util.ReadOnlyCollection<TValue> GetValuesCollection(TKey key) { }
        public System.Collections.Generic.IList<TValue> GetValuesSafe(TKey key) { }
        public void InsertValue(int index, TKey key, TValue value) { }
        public bool Remove(TKey key, TValue value) { }
        public bool RemoveKey(TKey key) { }
        public bool RemoveValue(TKey key, TValue value) { }
        public bool RemoveValueRange(TKey key, System.Collections.Generic.IEnumerable<TValue> list) { }
        public struct ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.Generic.IList<TValue>, System.Collections.IEnumerable
        
        
        {
            public static JetBrains.Util.OneToListMap<TKey, TValue>.ValueCollection Empty;
            public int Count { get; }
            public bool IsReadOnly { get; }
            public TValue this[int index] { get; set; }
            public void Add(TValue item) { }
            public void Clear() { }
            public bool Contains(TValue item) { }
            public void CopyTo(TValue[] array, int arrayIndex) { }
            public System.Collections.Generic.List<TValue>.Enumerator GetEnumerator() { }
            public int IndexOf(TValue value) { }
            public void Insert(int index, TValue item) { }
            public bool Remove(TValue item) { }
            public void RemoveAt(int index) { }
        }
    }
    public class static OneToListMapExtensions
    {
        public static void Add<TKey, TValue>(this JetBrains.Util.OneToListMap<TKey, TValue> map, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] TKey key, TValue value) { }
        public static void AddRange<TKey, TValue>(this JetBrains.Util.OneToListMap<TKey, TValue> map, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] TKey key, System.Collections.Generic.IEnumerable<TValue> values) { }
        public static void InsertValue<TKey, TValue>(this JetBrains.Util.OneToListMap<TKey, TValue> map, JetBrains.DataFlow.Lifetime lifetime, int index, [JetBrains.Annotations.NotNullAttribute()] TKey key, TValue value) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(JetBrains.Util.OneToSetMap<, >.OneToSetMapDebugView))]
    public class OneToSetMap<TKey, TValue> : JetBrains.Util.IOneToManyMap<TKey, TValue, System.Collections.Generic.ICollection<TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.ICollection<TValue>>>, System.Collections.IEnumerable
    
    
    {
        public OneToSetMap(JetBrains.Util.OneToSetMap<TKey, TValue> other) { }
        public OneToSetMap(System.Collections.Generic.IEqualityComparer<TKey> keyComparer) { }
        public OneToSetMap(int capacity = 0, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<TKey> keyComparer = null, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<TValue> valueComparer = null) { }
        public int Count { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<TValue> this[TKey key] { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.OneToSetMap<TKey, TValue>.ValuesCollection Values { get; }
        public bool Add([JetBrains.Annotations.NotNullAttribute()] TKey key, TValue value) { }
        public bool AddRange([JetBrains.Annotations.NotNullAttribute()] TKey key, System.Collections.Generic.IEnumerable<TValue> values) { }
        public void Clear() { }
        public bool ContainsKey([JetBrains.Annotations.NotNullAttribute()] TKey key) { }
        public bool ContainsPair([JetBrains.Annotations.NotNullAttribute()] TKey key, TValue value) { }
        public JetBrains.Util.OneToSetMapDiff<TKey> Diff(JetBrains.Util.OneToSetMap<TKey, TValue> other) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.ICollection<TValue>>> GetEnumerator() { }
        public System.Collections.Generic.ICollection<TValue> GetValuesSafe(TKey key) { }
        public bool Remove([JetBrains.Annotations.NotNullAttribute()] TKey key, TValue value) { }
        public void RemoveKey([JetBrains.Annotations.NotNullAttribute()] TKey key) { }
        public class ValuesCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
        
        
        {
            public ValuesCollection([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OneToSetMap<TKey, TValue> owner) { }
            public int Count { get; }
            public bool IsReadOnly { get; }
            public void Add(TValue item) { }
            public void Clear() { }
            public bool Contains(TValue item) { }
            public void CopyTo(TValue[] array, int arrayIndex) { }
            public System.Collections.Generic.IEnumerator<TValue> GetEnumerator() { }
            public bool Remove(TValue item) { }
        }
    }
    public class OneToSetMapDiff<TKey>
    
    {
        public OneToSetMapDiff() { }
        public OneToSetMapDiff(System.Collections.Generic.JetHashSet<TKey> newKeys, System.Collections.Generic.JetHashSet<TKey> changedKeys, System.Collections.Generic.JetHashSet<TKey> removedKeys) { }
        public System.Collections.Generic.JetHashSet<TKey> ChangedKeys { get; }
        public bool IsSomethingChanged { get; }
        public System.Collections.Generic.JetHashSet<TKey> NewKeys { get; }
        public System.Collections.Generic.JetHashSet<TKey> RemovedKeys { get; }
    }
    public class static OneToSetMapExtensions
    {
        public static void Add<TKey, TValue>(this JetBrains.Util.OneToSetMap<TKey, TValue> map, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] TKey key, TValue value) { }
    }
    public class OperationResult
    {
        public OperationResult(JetBrains.Util.OperationResultType type, string message) { }
        public string Message { get; }
        public JetBrains.Util.OperationResultType Type { get; }
        public static JetBrains.Util.OperationResult Fail(string failReason) { }
        public static JetBrains.Util.OperationResult Success() { }
    }
    public enum OperationResultType
    {
        Success = 0,
        Fail = 1,
    }
    public class OrderedHashSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    
    {
        public OrderedHashSet(int capacity) { }
        public OrderedHashSet(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public OrderedHashSet() { }
        public OrderedHashSet(System.Collections.Generic.ICollection<T> other) { }
        public OrderedHashSet(System.Collections.Generic.IEnumerable<T> other) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public T this[int index] { get; set; }
        public object SyncRoot { get; }
        public void Add(T item) { }
        public void AddAll(System.Collections.Generic.IEnumerable<T> other) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public bool ContainsAll(System.Collections.Generic.ICollection<T> otherCollection) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public T ElementAt(int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { }
        public void RemoveAll(System.Collections.Generic.ICollection<T> otherCollection) { }
        public void RemoveAt(int index) { }
        public void Sort(System.Collections.Generic.IComparer<T> comparer = null) { }
        public T[] ToArray() { }
    }
    public class OuterWorldExorigin : JetBrains.Util.OutOfCodeExorigin { }
    public class OutOfCodeExorigin : JetBrains.Util.ExceptionOrigin { }
    public class static Pair
    {
        public static System.Collections.Generic.IEnumerable<T1> GetFirsts<T1, T2>(this System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<T1, T2>> pairs) { }
        public static System.Collections.Generic.ICollection<T1> GetFirsts<T1, T2>(this System.Collections.Generic.ICollection<JetBrains.Util.Pair<T1, T2>> pairs) { }
        public static System.Collections.Generic.IEnumerable<T2> GetSeconds<T1, T2>(this System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<T1, T2>> pairs) { }
        public static System.Collections.Generic.ICollection<T2> GetSeconds<T1, T2>(this System.Collections.Generic.ICollection<JetBrains.Util.Pair<T1, T2>> pairs) { }
        public static JetBrains.Util.Pair<T1, T2> Of<T1, T2>(T1 first, T2 second) { }
    }
    public struct Pair<T1, T2>
    
    
    {
        public static readonly System.Collections.Generic.IComparer<JetBrains.Util.Pair<T1, T2>> Comparer;
        public static readonly JetBrains.Util.Pair<T1, T2> Empty;
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.Util.Pair<T1, T2>> EqualityComparer;
        public readonly T1 First;
        public readonly T2 Second;
        public Pair(T1 first, T2 second) { }
        public Pair(T1 first, T2 second, System.Func<T1, T2, int> getHashCodeFunc) { }
        public static int DefaultComparer(JetBrains.Util.Pair<T1, T2> p1, JetBrains.Util.Pair<T1, T2> p2) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsEmpty() { }
        public JetBrains.Util.Pair<T2, T1> Reverse() { }
        public override string ToString() { }
    }
    public class PartialSorter<T>
    
    {
        public PartialSorter() { }
        public System.Collections.Generic.ICollection<T> OrderedContent { get; }
        public void MoveDown(T item) { }
        public void MoveUp(T item) { }
        public void SetContent(System.Collections.Generic.ICollection<T> content) { }
    }
    [System.FlagsAttribute()]
    public enum PathSearchFlags
    {
        RecurseIntoSubdirectories = 1,
        ExcludeHidden = 2,
        ExcludeFiles = 4,
        ExcludeDirectories = 8,
    }
    public class PathWildcard
    {
        public PathWildcard(string pattern, bool caseSensitive) { }
        public bool Matches(string path) { }
    }
    public abstract class PatternLayoutListener : JetBrains.Util.ILogEventListener
    {
        public string Pattern { get; set; }
        public string Format(string message) { }
        public abstract void OnError(string error);
        public abstract void OnException(System.Exception ex);
        public abstract void OnMessage(string message, JetBrains.Util.LoggingLevel level);
    }
    public class static Predicate
    {
        public static bool False() { }
        public static bool True() { }
    }
    public class static ProcessUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<System.Diagnostics.Process> GetChildren([JetBrains.Annotations.NotNullAttribute()] this System.Diagnostics.Process process) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Diagnostics.Process GetParent([JetBrains.Annotations.NotNullAttribute()] this System.Diagnostics.Process process) { }
        public static bool IsRunningElevated() { }
        public static void KillByProcessName([JetBrains.Annotations.NotNullAttribute()] string processName) { }
        public static void KillByProcessName([JetBrains.Annotations.NotNullAttribute()] string processNamePattern, System.Text.RegularExpressions.RegexOptions regexOptions) { }
        public static void KillTree(this System.Diagnostics.Process process) { }
        public static bool ShutdownGracefully([JetBrains.Annotations.NotNullAttribute()] this System.Diagnostics.Process process, JetBrains.Util.ProcessUtil.ShutdownFlags flags, System.TimeSpan timeout) { }
        [System.FlagsAttribute()]
        public enum ShutdownFlags
        {
            WaitSynchronously = 1,
            KillAfterTimeout = 2,
        }
    }
    public class ProfileUtil
    {
        public static void Clear() { }
        public static void Dump(double minimalTime) { }
        public static void StartTimer(object key) { }
        public static void StopTimer(object key) { }
        public static bool TimerWorks(object key) { }
    }
    public class ProjectedCollection<TDst, TSrc> : System.Collections.Generic.ICollection<TDst>, System.Collections.Generic.IEnumerable<TDst>, System.Collections.IEnumerable, System.IDisposable
    
    
    {
        public ProjectedCollection(System.Collections.Generic.ICollection<TSrc> originalCollection, System.Func<TDst, TSrc> mapTo, System.Func<TSrc, TDst> mapFrom, System.Func<System.Collections.Generic.IEnumerator<TSrc>, TDst> enumeratorStateStateMap = null, JetBrains.DataFlow.Lifetime lifetime = null) { }
        public virtual int Count { get; }
        public virtual bool IsReadOnly { get; }
        public System.Collections.Generic.ICollection<TSrc> OriginalCollection { get; }
        public virtual void Add(TDst item) { }
        public virtual void Clear() { }
        public virtual bool Contains(TDst item) { }
        public virtual void CopyTo(TDst[] array, int arrayIndex) { }
        public virtual void Dispose() { }
        public virtual System.Collections.Generic.IEnumerator<TDst> GetEnumerator() { }
        public virtual bool Remove(TDst item) { }
    }
    public class ProjectedEnumerator<TSrc, TDst> : System.Collections.Generic.IEnumerator<TDst>, System.Collections.IEnumerator, System.IDisposable
    
    
    {
        public ProjectedEnumerator(System.Collections.Generic.IEnumerator<TSrc> originalEnumerator, System.Func<System.Collections.Generic.IEnumerator<TSrc>, TDst> mapFromState) { }
        public TDst Current { get; }
        public void Dispose() { }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public class QualifiedNamesTrie<T>
    
    {
        protected JetBrains.Util.QualifiedNamesTrie<T>.Node myRoot;
        public QualifiedNamesTrie() { }
        public QualifiedNamesTrie(bool ignoreCase, char delimiter) { }
        public T this[string qualification] { get; set; }
        public bool Add(string qualification, T data) { }
        public void ClearData(string qualification) { }
        public void CollectChildrenData(string qualification, JetBrains.Util.QualifiedNamesTrie<T>.IDataConsumer consumer) { }
        public void CollectSubTreeData(string qualification, JetBrains.Util.QualifiedNamesTrie<T>.IDataConsumer consumer) { }
        public static string DefaultDataConverter(T data) { }
        public void Dump(System.IO.TextWriter to, System.Func<T, string> dataPresenter) { }
        public T Find(string qualification) { }
        public T FindLongestPrefix(string qualification) { }
        public JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode FindTrieNode(string qualification) { }
        public TrieEntry[] GetChildren(string qualification) { }
        public void MergeWith(JetBrains.Util.QualifiedNamesTrie<T> otherTrie, JetBrains.Util.QualifiedNamesTrie<T>.NodeMergeHandler mergeHandler) { }
        public void MoveSubtree(string oldQualifiedName, string newQualifiedName) { }
        public bool RemoveKey(string qualification) { }
        public bool RemoveSubtree(string qualification) { }
        public interface IDataConsumer<T>
        
        {
            void Add(T data);
        }
        public interface ITrieNode<T>
        
        {
            T Data { get; set; }
            void Accept(JetBrains.Util.QualifiedNamesTrie<T>.ITrieNodeVisitor visitor);
            JetBrains.Util.QualifiedNamesTrie<T>.TrieEntry FindChild(string key);
            TrieEntry[] GetChildren();
        }
        public interface ITrieNodeVisitor<T>
        
        {
            void Visit(JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode trieNode);
        }
        public delegate T NodeMergeHandler<T>(JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode first, JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode second);
        public class TrieEntry<T>
        
        {
            public string Key { get; }
            public JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode TrieNode { get; }
        }
    }
    public class RangeTranslator
    {
        public RangeTranslator() { }
        public bool IsValid { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.RangeTranslator.RangeMap> Maps { get; }
        public JetBrains.Util.TextRange ResultRange { get; }
        public JetBrains.Util.TextRange SourceRange { get; }
        public void EndMapping(int length) { }
        public void EndMapping(JetBrains.Util.TextRange resultRange) { }
        public JetBrains.Util.TextRange GetResultRange(int sourceOffset) { }
        public JetBrains.Util.TextRange GetResultRange(JetBrains.Util.TextRange sourceRange) { }
        public JetBrains.Util.TextRange GetSourceRange(int resultOffset) { }
        public JetBrains.Util.TextRange GetSourceRange(JetBrains.Util.TextRange resultRange) { }
        public void MapCharToChar(int source, int result) { }
        public void MapCharToText(int sourceOffset, int resultOffset, int resultLength) { }
        public void MapTextToChar(int sourceOffset, int sourceLength, int resultOffset) { }
        public void MapTextToText(int sourceOffset, int sourceLength, int resultOffset, int resultLength) { }
        public void MapTextToText(JetBrains.Util.TextRange source, JetBrains.Util.TextRange result) { }
        public void ShiftResult(int delta) { }
        public void ShiftSource(int delta) { }
        public void StartMapping(int length) { }
        public void StartMapping(JetBrains.Util.TextRange sourceRange) { }
        public class RangeMap
        {
            public JetBrains.Util.TextRange ResultRange;
            public JetBrains.Util.TextRange SourceRange;
            public RangeMap(JetBrains.Util.TextRange sourceRange, JetBrains.Util.TextRange resultRange) { }
        }
    }
    public class static ReaderWriterLockHelper
    {
        public static JetBrains.Util.ReaderWriterLockHelper.DisposeReaderLock GetReaderLock(this System.Threading.ReaderWriterLock readerWriterLock) { }
        public static JetBrains.Util.ReaderWriterLockHelper.DisposeWriterLock GetWriterLock(this System.Threading.ReaderWriterLock readerWriterLock) { }
        public static System.IDisposable UpgradeToWriterLock(this System.Threading.ReaderWriterLock readerWriterLock) { }
        public struct DisposeReaderLock : System.IDisposable
        {
            public DisposeReaderLock(System.Threading.ReaderWriterLock @lock) { }
            public void Dispose() { }
        }
        public struct DisposeWriterLock : System.IDisposable
        {
            public DisposeWriterLock(System.Threading.ReaderWriterLock @lock) { }
            public void Dispose() { }
        }
    }
    public class ReadOnlyCollection<T> : JetBrains.DataStructures.IReadOnlyCollection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public ReadOnlyCollection(System.Collections.Generic.ICollection<T> collection) { }
        public int Count { get; }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
    }
    public class ReadOnlyDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        public static readonly JetBrains.Util.ReadOnlyDictionary<TKey, TValue> Empty;
        public ReadOnlyDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool ContainsKey(TKey key) { }
        public void CopyTo(System.Collections.Generic.KeyValuePair<, >[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        public bool Remove(TKey key) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool TryGetValue(TKey key, out TValue value) { }
    }
    public class ReadOnlyList<T> : JetBrains.DataStructures.IReadOnlyCollection<T>, JetBrains.DataStructures.IReadOnlyList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    
    {
        public ReadOnlyList(System.Collections.Generic.IList<T> list) { }
        public int Count { get; }
        public T this[int index] { get; set; }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
    }
    public class RecentItemsList<T>
        where T :  class
    {
        public const int UNLIMITED = 2147483647;
        public RecentItemsList(int maxCount, System.Func<T, bool> itemValidator) { }
        public RecentItemsList(int maxCount = 2147483647) { }
        public int Count { get; }
        public System.Collections.Generic.IList<T> Items { get; }
        public int MaxCount { get; set; }
        public T RecentItem { get; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T file) { }
        public void Remove(T item) { }
    }
    public class RecordAndThrowLogger : JetBrains.Util.ILogger, System.IDisposable
    {
        public RecordAndThrowLogger([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.RecordAndThrowLogger.InformationalExceptions informationalExceptions) { }
        public RecordAndThrowLogger(JetBrains.Util.RecordAndThrowLogger.InformationalExceptions informationalExceptions) { }
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
        public enum InformationalExceptions
        {
            Ignore = 0,
            TreatAsExceptions = 1,
        }
    }
    public class RecordingLogger : JetBrains.Util.ILogger
    {
        public RecordingLogger(JetBrains.Util.RecordingLogger.LogOrThrowExceptions logOrThrowExceptions, JetBrains.Util.RecordingLogger.RecordOrPassMessages recordOrPassMessages, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForwardTo, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IList<System.Type> typesExoriginPassOnly, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IList<System.Type> typesExoriginRecordOnly) { }
        public bool IsWithLoudExceptions { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Util.RecordingLogger.ExceptionWithOrigin> CopyExceptions() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Util.RecordingLogger.ExceptionWithOrigin> CopyExceptionsAndClear() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.CompoundException CopyExceptionsAndClearCompound() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.CompoundException CopyExceptionsCompound() { }
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
        public struct ExceptionWithOrigin
        {
            public System.Exception Exception;
            public JetBrains.Util.ExceptionOrigin Origin;
        }
        public enum LogOrThrowExceptions
        {
            Log = 0,
            Throw = 1,
        }
        public struct MessageWithImportance
        {
            public JetBrains.Util.LoggingLevel Importance;
            public string Message;
        }
        public enum RecordOrPassMessages
        {
            Pass = 0,
            Record = 1,
        }
    }
    public class static Rects
    {
        public static System.Drawing.Size MaxSize { get; }
        public static int AbsMaximum(this System.Drawing.Size size) { }
        public static System.Drawing.Rectangle AlignCenter(System.Drawing.Rectangle source, System.Drawing.Rectangle bounds) { }
        public static System.Windows.Rect AlignCenter(System.Windows.Rect source, System.Windows.Rect bounds) { }
        public static System.Drawing.Rectangle AlignCenter(System.Drawing.Size source, System.Drawing.Rectangle bounds) { }
        public static System.Windows.Rect AlignCenter(System.Windows.Size source, System.Windows.Rect bounds) { }
        public static System.Drawing.Rectangle AlignCenterAndCrop(System.Drawing.Rectangle source, System.Drawing.Rectangle bounds) { }
        public static System.Drawing.Rectangle AlignCenterAndCrop(System.Drawing.Size source, System.Drawing.Rectangle bounds) { }
        public static System.Drawing.Rectangle AlignCenterAndDownscale(System.Drawing.Rectangle source, System.Drawing.Rectangle bounds) { }
        public static System.Windows.Rect AlignCenterAndDownscale(System.Windows.Rect source, System.Windows.Rect bounds) { }
        public static System.Drawing.Rectangle AlignCenterAndDownscale(System.Drawing.Size source, System.Drawing.Rectangle bounds) { }
        public static System.Windows.Rect AlignCenterAndDownscale(System.Windows.Size source, System.Windows.Rect bounds) { }
        public static System.Windows.Rect AlignWithin(this System.Windows.Rect source, System.Windows.Rect bounds) { }
        public static System.Drawing.Rectangle AlignWithinNoResize(this System.Drawing.Rectangle source, System.Drawing.Rectangle bounds) { }
        public static System.Drawing.Rectangle AlignWithinUsingMinSize(this System.Drawing.Rectangle source, System.Drawing.Rectangle bounds, System.Drawing.Size minSize) { }
        public static System.Windows.Point AssertIsReal(this System.Windows.Point pt, [JetBrains.Annotations.CanBeNullAttribute()] string failmessage) { }
        public static System.Windows.Rect AssertIsReal(this System.Windows.Rect rect, [JetBrains.Annotations.CanBeNullAttribute()] string failmessage = null) { }
        public static System.Windows.Size AssertIsReal(this System.Windows.Size size, [JetBrains.Annotations.CanBeNullAttribute()] string failmessage) { }
        public static System.Drawing.Rectangle Attach(ref System.Drawing.Rectangle anchor, System.Windows.Forms.DockStyle dockstyle, int size) { }
        public static System.Drawing.Rectangle Attach(ref System.Drawing.Rectangle anchor, System.Windows.Forms.DockStyle dockstyle, System.Drawing.Size size) { }
        public static System.Drawing.Rectangle Attach(System.Drawing.Rectangle anchor, System.Windows.Forms.DockStyle dockstyle, int size) { }
        public static System.Drawing.Rectangle Attach(System.Drawing.Rectangle anchor, System.Windows.Forms.DockStyle dockstyle, System.Drawing.Size size) { }
        public static System.Drawing.Rectangle ClipSmart(System.Drawing.Rectangle source, System.Drawing.Rectangle bounds) { }
        public static System.Windows.Rect ClipSmart(System.Windows.Rect source, System.Windows.Rect bounds) { }
        public static System.Drawing.Point Collapse(this System.Drawing.Rectangle rectangle, JetBrains.UI.Anchoring2D how) { }
        public static System.Windows.Point Collapse(this System.Windows.Rect rectangle, JetBrains.UI.Anchoring2D how) { }
        [JetBrains.Annotations.PureAttribute()]
        public static System.Drawing.Size Constrain(this System.Drawing.Size source, System.Drawing.Size limit) { }
        public static System.Windows.Size Constrain(this System.Windows.Size source, System.Windows.Size limit) { }
        public static System.Drawing.Rectangle Deflate(this System.Drawing.Rectangle source, int left, int top, int right, int bottom) { }
        public static System.Drawing.Rectangle Deflate(this System.Drawing.Rectangle source, System.Drawing.Size size) { }
        public static System.Windows.Rect Deflate(this System.Windows.Rect source, System.Windows.Size size) { }
        public static System.Drawing.Rectangle Deflate(this System.Drawing.Rectangle source, System.Windows.Forms.Padding padding) { }
        public static System.Windows.Rect Deflate(this System.Windows.Rect source, System.Windows.Thickness thickness) { }
        public static System.Drawing.Rectangle Dock(ref System.Drawing.Rectangle space, System.Windows.Forms.DockStyle dockstyle, int size) { }
        public static System.Windows.Rect Dock(ref System.Windows.Rect space, System.Nullable<System.Windows.Controls.Dock> dock, double size) { }
        public static System.Drawing.Rectangle Dock(ref System.Drawing.Rectangle space, System.Windows.Forms.DockStyle dockstyle, System.Drawing.Size size) { }
        public static System.Windows.Rect Dock(ref System.Windows.Rect space, System.Nullable<System.Windows.Controls.Dock> dock, System.Windows.Size size) { }
        public static System.Drawing.Rectangle Dock(this System.Drawing.Rectangle space, System.Windows.Forms.DockStyle dockstyle, int size) { }
        public static System.Windows.Rect Dock(this System.Windows.Rect space, System.Nullable<System.Windows.Controls.Dock> dock, double size) { }
        public static System.Drawing.Rectangle Dock(this System.Drawing.Rectangle space, System.Windows.Forms.DockStyle dockstyle, System.Drawing.Size size) { }
        public static System.Windows.Rect Dock(this System.Windows.Rect space, System.Nullable<System.Windows.Controls.Dock> dock, System.Windows.Size size) { }
        public static System.Drawing.Size EnsureEmptySize(System.Drawing.Size size) { }
        public static System.Drawing.Rectangle FromLtrbNonnegative(int left, int top, int right, int bottom) { }
        public static System.Windows.Rect FromLtrbNonnegative(double left, double top, double right, double bottom) { }
        public static System.Drawing.Rectangle[] GetBorder(this System.Drawing.Rectangle rect, System.Drawing.Size dim) { }
        public static System.Drawing.Point GetCenter(this System.Drawing.Rectangle rect) { }
        public static System.Drawing.Rectangle Inflate(this System.Drawing.Rectangle source, int left, int top, int right, int bottom) { }
        public static System.Drawing.Rectangle Inflate(this System.Drawing.Rectangle source, System.Drawing.Size size) { }
        public static System.Drawing.Rectangle Inflate(this System.Drawing.Rectangle source, System.Windows.Forms.Padding padding) { }
        public static System.Windows.Rect Inflate(this System.Windows.Rect source, double left, double top, double right, double bottom) { }
        public static System.Windows.Rect Inflate(this System.Windows.Rect source, System.Windows.Size size) { }
        public static System.Windows.Rect Inflate(this System.Windows.Rect source, System.Windows.Thickness padding) { }
        public static bool IsCollapsed(this System.Drawing.Size size) { }
        public static bool IsCollapsed(this System.Windows.Size size) { }
        public static bool IsCollapsed(this System.Drawing.Rectangle rect) { }
        public static bool IsCollapsed(this System.Windows.Rect rect) { }
        public static bool IsCollapsed(this System.Nullable<System.Windows.Rect> rect) { }
        public static bool IsConstrained(this System.Drawing.Size source, System.Drawing.Size limit) { }
        public static bool IsConstrained(this System.Windows.Size source, System.Windows.Size limit) { }
        public static bool IsEmptyArea(this System.Drawing.Size size) { }
        public static bool IsEmptyArea(this System.Drawing.Rectangle rect) { }
        public static bool IsInfinite(this System.Drawing.Size rect) { }
        public static bool IsNanOrInf(this System.Windows.Point pt) { }
        public static bool IsNanOrInf(this System.Windows.Size size) { }
        public static bool IsNanOrInf(this System.Windows.Rect rect) { }
        public static bool IsNormalized(this System.Drawing.Size size) { }
        public static bool IsNormalized(this System.Windows.Size size) { }
        public static bool IsNormalized(this System.Drawing.Rectangle rect) { }
        public static bool IsNormalized(this System.Windows.Rect rect) { }
        public static System.Drawing.Size Max(System.Drawing.Size α, System.Drawing.Size β) { }
        public static System.Windows.Size Max(System.Windows.Size α, System.Windows.Size β) { }
        public static System.Drawing.Size MaxValuesToZeros(this System.Drawing.Size size) { }
        public static System.Drawing.Size Min(System.Drawing.Size α, System.Drawing.Size β) { }
        public static System.Windows.Size Min(System.Windows.Size α, System.Windows.Size β) { }
        public static System.Drawing.Size Negate(this System.Drawing.Size size) { }
        public static System.Drawing.Rectangle Normalize(this System.Drawing.Rectangle rect) { }
        public static System.Windows.Rect Normalize(this System.Windows.Rect rect) { }
        public static System.Drawing.Size Normalize(this System.Drawing.Size size) { }
        public static System.Drawing.Rectangle Offset(this System.Drawing.Rectangle source, System.Drawing.Size offset) { }
        public static System.Drawing.Rectangle Offset(this System.Drawing.Rectangle source, System.Drawing.Point offset) { }
        public static System.Drawing.Rectangle SetBottom(System.Drawing.Rectangle source, int bottom) { }
        public static System.Windows.Rect SetBottom(System.Windows.Rect source, int bottom) { }
        public static void SetBottom(ref System.Drawing.Rectangle source, int bottom) { }
        public static System.Drawing.Rectangle SetLeft(System.Drawing.Rectangle source, int left) { }
        public static void SetLeft(ref System.Drawing.Rectangle source, int left) { }
        public static System.Drawing.Rectangle SetRight(System.Drawing.Rectangle source, int right) { }
        public static void SetRight(ref System.Drawing.Rectangle source, int right) { }
        public static System.Drawing.Rectangle SetTop(System.Drawing.Rectangle source, int top) { }
        public static System.Windows.Rect SetTop(System.Windows.Rect source, int top) { }
        public static void SetTop(ref System.Drawing.Rectangle source, int top) { }
        public static System.Drawing.Size Size(int width, int height) { }
        public static System.Windows.Size Size(double width, double height) { }
        public static System.Drawing.Size Size(System.Drawing.Size size) { }
        public static System.Drawing.Size StackHorizontally(System.Collections.Generic.IEnumerable<System.Drawing.Size> sizes, int gap) { }
        public static System.Drawing.Size StackHorizontally(int gap, params System.Drawing.Size[] sizes) { }
        public static System.Drawing.Size StackVertically(System.Collections.Generic.IEnumerable<System.Drawing.Size> sizes, int gap) { }
        public static System.Drawing.Size StackVertically(int gap, params System.Drawing.Size[] sizes) { }
        public static System.Drawing.Rectangle Unite(System.Drawing.Rectangle one, System.Drawing.Rectangle two) { }
        public static System.Drawing.Rectangle UniteHorizontally(System.Drawing.Rectangle source, System.Drawing.Rectangle other) { }
        public static System.Windows.Rect UniteHorizontally(System.Windows.Rect source, System.Windows.Rect other) { }
        public static System.Drawing.Rectangle UniteVertically(System.Drawing.Rectangle source, System.Drawing.Rectangle other) { }
        public static System.Windows.Rect UniteVertically(System.Windows.Rect source, System.Windows.Rect other) { }
        public static System.Drawing.Size ZerosToMaxValues(this System.Drawing.Size size) { }
        public class RectsComparer : System.Collections.Generic.IComparer<System.Collections.Generic.IEnumerable<System.Drawing.Rectangle>>, System.Collections.Generic.IComparer<System.Drawing.Rectangle>
        {
            public int Compare(System.Collections.Generic.IEnumerable<System.Drawing.Rectangle> alpha, System.Collections.Generic.IEnumerable<System.Drawing.Rectangle> beta) { }
            public int Compare(System.Drawing.Rectangle alpha, System.Drawing.Rectangle beta) { }
        }
    }
    public class RecursiveQualifiedNamesTrieVisitior<T> : JetBrains.Util.QualifiedNamesTrie<T>.ITrieNodeVisitor
    
    {
        protected virtual void ProcessAfterChildren(JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode trieNode) { }
        protected virtual void ProcessBeforeChildren(JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode trieNode) { }
        protected virtual void ProcessChild(JetBrains.Util.QualifiedNamesTrie<T>.TrieEntry childEntry) { }
        public virtual void Visit(JetBrains.Util.QualifiedNamesTrie<T>.ITrieNode trieNode) { }
    }
    public class ReferenceEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
        where T :  class
    {
        public static JetBrains.Util.ReferenceEqualityComparer<T> Default { get; }
        public bool Equals(T x, T y) { }
        public int GetHashCode(T obj) { }
    }
    public class static RegistryKeyEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.Win32.RegistryKey OpenSubKey([JetBrains.Annotations.NotNullAttribute()] this Microsoft.Win32.RegistryKey root, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string subKeyName) { }
    }
    public class RegistryNavigator : System.Xml.XPath.XPathNavigator
    {
        public RegistryNavigator() { }
        public override string BaseURI { get; }
        public override bool HasAttributes { get; }
        public override bool HasChildren { get; }
        public override bool IsEmptyElement { get; }
        public override string LocalName { get; }
        public override string Name { get; }
        public override string NamespaceURI { get; }
        public override System.Xml.XmlNameTable NameTable { get; }
        public override System.Xml.XPath.XPathNodeType NodeType { get; }
        public override string Prefix { get; }
        public override string Value { get; }
        public override string XmlLang { get; }
        public override System.Xml.XPath.XPathNavigator Clone() { }
        public override string GetAttribute(string localName, string namespaceURI) { }
        public override string GetNamespace(string name) { }
        public override bool IsSamePosition(System.Xml.XPath.XPathNavigator other) { }
        public override bool MoveTo(System.Xml.XPath.XPathNavigator other) { }
        public override bool MoveToAttribute(string localName, string namespaceURI) { }
        public override bool MoveToFirst() { }
        public override bool MoveToFirstAttribute() { }
        public override bool MoveToFirstChild() { }
        public override bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope) { }
        public override bool MoveToId(string id) { }
        public override bool MoveToNamespace(string name) { }
        public override bool MoveToNext() { }
        public override bool MoveToNextAttribute() { }
        public override bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope) { }
        public override bool MoveToParent() { }
        public override bool MoveToPrevious() { }
        public bool MoveToPreviousAttribute() { }
        public override void MoveToRoot() { }
    }
    public sealed class RegistryUtil
    {
        public static string GetValue(string xpath) { }
        [System.ObsoleteAttribute("See RegistryHiveAccess class which has registry-view-bound helper methods.")]
        public static Microsoft.Win32.RegistryKey OpenSoftwareKey(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class static ResultExtensions
    {
        public static bool IsFail([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.OperationResult result) { }
        public static bool IsSuccess([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.OperationResult result) { }
    }
    public delegate void Runnable();
    public abstract class SafeDisposable : System.IDisposable
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly System.Diagnostics.StackFrame[] ConstructorInvocationStackFrame;
        protected System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) IsDisposed;
        protected SafeDisposable(bool canCaptureStacktraces) { }
        protected virtual bool WarnOnSecondDispose { get; }
        [JetBrains.Annotations.ThreadUnsafeAttribute()]
        public void Dispose() { }
        [JetBrains.Annotations.ThreadUnsafeAttribute()]
        public static void DisposeIfNecessary(object o) { }
        protected abstract void DisposeUnmanagedResources();
        protected override void Finalize() { }
    }
    public class SeparateThreadRunner
    {
        public SeparateThreadRunner(JetBrains.DataFlow.Lifetime lifetime, string name, System.Action<JetBrains.Util.SeparateThreadRunner> actionToPerform, System.Action<JetBrains.Util.SeparateThreadRunner> actionOnTimeout, System.TimeSpan timeout) { }
    }
    public class static Sizeof
    {
        public static int Type<T>() { }
        public interface IDynamicInterface
        {
            int GetSizeOf<T>();
        }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(JetBrains.Util.SortedOneToListMap<, >.OneToListMapDebugView))]
    public class SortedOneToListMap<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>>, System.Collections.IEnumerable
    
    
    {
        public SortedOneToListMap(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> enumerable, System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedOneToListMap(System.Collections.Generic.IComparer<TKey> comparer) { }
        public SortedOneToListMap() { }
        public int Count { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<TValue> this[TKey key] { get; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public void Add(TKey key, TValue value) { }
        public void AddValue(TKey key, TValue value) { }
        public void AddValueRange(TKey key, System.Collections.Generic.IEnumerable<TValue> list) { }
        public void Clear() { }
        public void ClearKey(TKey key) { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsPair(TKey key, TValue value) { }
        public bool ContainsValue(TValue value) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> GetEnumerator() { }
        public JetBrains.Util.ReadOnlyCollection<TValue> GetValuesCollection(TKey key) { }
        public bool RemoveKey(TKey key) { }
        public bool RemoveValue(TKey key, TValue value) { }
    }
    public class static SortUtil
    {
        public static System.Collections.Generic.IList<TItemInfo> SortByAnchors<TItemInfo, TItem>(System.Collections.Generic.IList<TItemInfo> infos, System.Func<TItemInfo, TItem> itemFunc, System.Func<TItemInfo, TItem> anchorFunc, System.Func<TItemInfo, JetBrains.Util.BeforeOrAfter> beforeFunc) { }
        public static System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> SortFilePaths(System.Collections.ICollection filePaths) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> SortFilePaths(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> filePaths) { }
        public static System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> SortFilePaths(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> filePaths) { }
        public static System.Collections.Generic.ICollection<string> SortStrings(System.Collections.Generic.ICollection<string> strings) { }
        public static System.Collections.Generic.List<T> SparseTopoSort<T>(System.Collections.Generic.IEnumerable<T> items, System.Func<T, System.Collections.Generic.IEnumerable<T>> dependencyProvider) { }
        public static System.Collections.Generic.List<T> TopoSort<T>([JetBrains.Annotations.InstantHandleAttribute()] this System.Collections.Generic.IEnumerable<T> items, [JetBrains.Annotations.InstantHandleAttribute()] System.Func<T, T, System.Nullable<int>> comparer) { }
        public class CycleInTopoSortException : System.Exception { }
        public sealed class FileSystemPathComparer : System.Collections.Generic.IComparer<JetBrains.Util.FileSystemPath>, System.Collections.Generic.IEqualityComparer<JetBrains.Util.FileSystemPath>
        {
            public static readonly JetBrains.Util.SortUtil.FileSystemPathComparer Instance;
            public int Compare(JetBrains.Util.FileSystemPath x, JetBrains.Util.FileSystemPath y) { }
            public bool Equals(JetBrains.Util.FileSystemPath x, JetBrains.Util.FileSystemPath y) { }
            public int GetHashCode(JetBrains.Util.FileSystemPath obj) { }
        }
        public class MissingAnchorException<TItemInfo> : System.Exception
        
        {
            public MissingAnchorException(TItemInfo itemInfo, string message) { }
            public TItemInfo ItemInfo { get; }
        }
    }
    public class static StableSorter
    {
        public static void Sort<T>(System.Collections.Generic.IList<T> list, System.Collections.Generic.IComparer<T> comparer) { }
    }
    public class Statistics
    {
        public System.Collections.Generic.Dictionary<string, System.TimeSpan> Activities { get; }
        public System.Collections.Generic.IDictionary<string, System.Func<object>> Calculators { get; }
        public System.Collections.Generic.IDictionary<string, int> Counters { get; }
        public JetBrains.Util.Statistics.StatisticsActivityCookie Activity(string name) { }
        public static JetBrains.Util.Statistics Allocate(string key) { }
        public static JetBrains.Util.Statistics Allocate(System.Type type) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Calculate(string name, System.Func<object> calculator) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Clear() { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public static void ClearAll() { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Decrement(string name) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Decrement(string name, int value) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void DecrementFormat(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Dump(System.IO.TextWriter writer) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.StatisticsNode> Enumerate() { }
        public static bool HasBreakpoint(string key, string name) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Increment(string name) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Increment(string name, int value) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void IncrementFormat(string format, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public void Resume() { }
        public System.IDisposable Suspend() { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        public static void ToggleBreakpoint(string key, string name) { }
        public struct StatisticsActivityCookie : System.IDisposable
        {
            public void Dispose() { }
        }
    }
    public class StatisticsActivity : JetBrains.Util.StatisticsNode
    {
        public StatisticsActivity(string key, string name, System.TimeSpan stopwatch) { }
        public System.TimeSpan Time { get; }
    }
    public class StatisticsCalculator : JetBrains.Util.StatisticsNode
    {
        public StatisticsCalculator(string key, string name, System.Func<object> calculator) { }
        public object Value { get; }
    }
    public class StatisticsCounter : JetBrains.Util.StatisticsNode
    {
        public StatisticsCounter(string key, string name, int value) { }
        public int Count { get; }
    }
    public class StatisticsGroup
    {
        public StatisticsGroup(string key) { }
        public string Key { get; }
        public JetBrains.UI.RichText.RichText ShortName { get; }
        public bool Equals(JetBrains.Util.StatisticsGroup obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public abstract class StatisticsNode
    {
        protected StatisticsNode(string key, string name) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.StatisticsGroup> Groups { get; }
        public string Key { get; }
        public string Name { get; }
    }
    public sealed class StringEncryption : System.IDisposable
    {
        public StringEncryption(JetBrains.Util.StringEncryption.StringEncryptionMethod method) { }
        public StringEncryption(System.Security.Cryptography.SymmetricAlgorithm serviceProvider) { }
        public string Decrypt(string source, string key) { }
        public void Dispose() { }
        public string Encrypt(string source, string key) { }
        public enum StringEncryptionMethod
        {
            DES = 0,
            RC2 = 1,
            Rijndael = 2,
        }
    }
    public sealed class StringSearcher
    {
        public StringSearcher(string pattern, bool caseSensitive) { }
        public bool CaseSensitive { get; }
        public string Pattern { get; }
        public int Find(JetBrains.Text.IBuffer buffer) { }
        public int Find(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public System.Collections.Generic.IList<int> FindAll(JetBrains.Text.IBuffer buffer) { }
        public System.Collections.Generic.IList<int> FindAll(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.Util.StringSlice.StringSliceConverter))]
    [System.Windows.Markup.ValueSerializerAttribute(typeof(JetBrains.Util.StringSlice.StringSliceSerializer))]
    public struct StringSlice
    {
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.Util.StringSlice> CaseInsensitiveComparer;
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.Util.StringSlice> DefaultComparer;
        public static JetBrains.Util.StringSlice Empty;
        public StringSlice(string s) { }
        public StringSlice(string s, int start, int length) { }
        public bool IsEmpty { get; }
        public char this[int i] { get; }
        public int Length { get; }
        public bool Contains(string value) { }
        public bool EndsWith(string value) { }
        public bool Equals(JetBrains.Util.StringSlice other, System.Collections.Generic.IEqualityComparer<JetBrains.Util.StringSlice> comparer) { }
        public override bool Equals(object obj) { }
        public bool EqualTo(string s) { }
        public bool EqualTo(string s, System.Collections.Generic.IEqualityComparer<JetBrains.Util.StringSlice> comparer) { }
        public override int GetHashCode() { }
        public int IndexOf(char value) { }
        public int IndexOf(char value, int startIndex) { }
        public int IndexOf(char value, int startIndex, int count) { }
        public int IndexOf(string value) { }
        public int IndexOf(string value, int startIndex) { }
        public int IndexOf(string value, int startIndex, int count) { }
        public int IndexOf(string value, System.StringComparison comparisonType) { }
        public int IndexOf(string value, int startIndex, System.StringComparison comparisonType) { }
        public int IndexOf(string value, int startIndex, int count, System.StringComparison comparisonType) { }
        public int IndexOfAny(char[] anyOf) { }
        public int IndexOfAny(char[] anyOf, int startIndex) { }
        public int IndexOfAny(char[] anyOf, int startIndex, int count) { }
        public int LastIndexOf(char value) { }
        public int LastIndexOf(char value, int startIndex) { }
        public int LastIndexOf(char value, int startIndex, int count) { }
        public int LastIndexOf(string value) { }
        public int LastIndexOf(string value, int startIndex) { }
        public int LastIndexOf(string value, int startIndex, int count) { }
        public int LastIndexOf(string value, System.StringComparison comparisonType) { }
        public int LastIndexOf(string value, int startIndex, System.StringComparison comparisonType) { }
        public int LastIndexOf(string value, int startIndex, int count, System.StringComparison comparisonType) { }
        public int LastIndexOfAny(char[] anyOf) { }
        public int LastIndexOfAny(char[] anyOf, int startIndex) { }
        public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }
        public void ProcessString(JetBrains.Util.StringSlice.ProcessStringDelegate action) { }
        public T ProcessString<T>(JetBrains.Util.StringSlice.ProcessStringDelegate<T> action) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.StringSlice> Split(params char[] separator) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.StringSlice> Split(char[] separator, System.StringSplitOptions options) { }
        public JetBrains.Util.StringSlice Substring(int startIndex) { }
        public JetBrains.Util.StringSlice Substring(int startIndex, int length) { }
        public override string ToString() { }
        public delegate void ProcessStringDelegate(System.Char* s, int length);
        public delegate T ProcessStringDelegate<T>(System.Char* s, int length);
        public class StringSliceConverter : JetBrains.Util.Reflection.TypeConverterBase<JetBrains.Util.StringSlice>
        {
            public StringSliceConverter() { }
        }
        public class StringSliceSerializer : JetBrains.Util.Reflection.ValueSerializerBase<JetBrains.Util.StringSlice>
        {
            public StringSliceSerializer() { }
        }
    }
    public class static StringUtil
    {
        public const char DOT = '.';
        public const char GENERIC_DELIMETER = '`';
        public static readonly string HexDigitsformatString;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly char[] NEW_LINE_CHARACTERS;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly string[] NEW_LINE_STRINGS;
        public const char PLUS = '+';
        public const string SDOT = ".";
        public static System.Text.StringBuilder AppendDelimited<T>(this System.Text.StringBuilder builder, System.Collections.Generic.IEnumerable<T> enumerable, System.Func<T, string> presenter, string delimiter) { }
        public static System.Text.StringBuilder AppendDelimited(this System.Text.StringBuilder builder, System.Collections.Generic.IEnumerable<string> enumerable, string delimiter) { }
        public static System.Text.StringBuilder AppendLine([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder sb, [JetBrains.Annotations.NotNullAttribute()] string format, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        public static System.Text.StringBuilder AppendLine([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder sb, [JetBrains.Annotations.NotNullAttribute()] string format, object argA) { }
        public static System.Text.StringBuilder AppendLine([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder sb, [JetBrains.Annotations.NotNullAttribute()] string format, object argA, object argB) { }
        public static System.Text.StringBuilder AppendLine([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder sb, [JetBrains.Annotations.NotNullAttribute()] string format, object argA, object argB, object argC) { }
        public static string Capitalize(this string s) { }
        public static string CapitalizeWords(string s) { }
        public static string Combine(string str1, string str2) { }
        public static bool ContainsNewLine(this string s) { }
        public static int Count(string s, char ch) { }
        public static string CutSpaces(string s) { }
        public static void CutSpaces(string s, System.Text.StringBuilder sb) { }
        public static string Decapitalize(this string s) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string DropMiddleIfLong([JetBrains.Annotations.NotNullAttribute()] string text, int nMaxLen) { }
        public static string EncodeStringForSgml(string s) { }
        public static bool EndsWithNewLine(this string s) { }
        public static System.Collections.Generic.IEnumerable<string> EnumeratePrefixes(string s) { }
        public static bool EqIgnoreCase(string s1, string s2) { }
        public static string Escape(string s) { }
        public static string ExpandTabs(string s, int startOffset, uint tabsize) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static string FormatQuoted([JetBrains.Annotations.NotNullAttribute()] string format, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string FromUtf16HexString([JetBrains.Annotations.NotNullAttribute()] string hex) { }
        public static string FullReplace([JetBrains.Annotations.NotNullAttribute()] this string input, [JetBrains.Annotations.NotNullAttribute()] string oldValue, [JetBrains.Annotations.NotNullAttribute()] string newValue) { }
        public static string[] FullySplitFQName(string fqName) { }
        public static string GenerateRandomName() { }
        public static string GenerateRandomName(int length) { }
        public static string GenerateRandomName(int length, [JetBrains.Annotations.NotNullAttribute()] System.Random rand) { }
        public static string GenerateRandomNameForObject([JetBrains.Annotations.CanBeNullAttribute()] object instance) { }
        public static string GetCommon(string qualified1, string qualified2, out int foundIndex) { }
        public static int GetPlatformIndependentHashCode([JetBrains.Annotations.CanBeNullAttribute()] this string s, bool caseSensistive = True) { }
        public static string GetPrefix(string text, char delim, out JetBrains.Util.TextRange prefixRange) { }
        public static string GetSuffix(string text, char delim, out JetBrains.Util.TextRange suffixRange) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null=>true")]
        public static bool IsEmpty([JetBrains.Annotations.CanBeNullAttribute()] this string s) { }
        public static bool IsEmpty([JetBrains.Annotations.CanBeNullAttribute()] this System.Text.StringBuilder builder) { }
        public static bool IsNewLine(this string s) { }
        public static bool IsNullOrWhitespace([JetBrains.Annotations.CanBeNullAttribute()] this string s) { }
        public static bool IsWhitespace(this string s) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Join(this System.Collections.Generic.IEnumerable<string> strings, string separator) { }
        public static char Last(this string s) { }
        public static string MakeFQName(string[] parts) { }
        public static string MakeFQName(string namespaceName, string className) { }
        public static string MakeTitle(string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string MakeUpperCamelCaseName([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public static string Multiply([JetBrains.Annotations.NotNullAttribute()] this string source, int multiplier) { }
        public static string NextQualification(string partial, string full) { }
        public static string NormalizeWhiteSpace(string s) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Text.StringBuilder Prepend([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder builder, char @char) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Text.StringBuilder Prepend([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder builder, string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string QuoteIfNeeded([JetBrains.Annotations.CanBeNullAttribute()] this string s) { }
        public static string Replace(this string s, System.Func<char, char> replacer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ReplaceNewLines([JetBrains.Annotations.NotNullAttribute()] this string s, string replaceWith = " ") { }
        public static string ShortName(string name) { }
        [System.ObsoleteAttribute("Use \'System.String.Split\' overload with parameter \'options\'")]
        public static string[] Split(string stringToSplit, string delimChars, bool keepEmpty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string[] SplitByNewLine([JetBrains.Annotations.NotNullAttribute()] this string s, int count = 2147483647, System.StringSplitOptions options = 0) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string[] SplitByWords([JetBrains.Annotations.CanBeNullAttribute()] this string text) { }
        public static string SplitCLRName(string name, out string qualificationPrefix) { }
        public static string[] SplitFQName(string fqName) { }
        public static string SplitName(string name, out string qualificationPrefix) { }
        public static bool StartsWith(string what, string withWhat, System.StringComparison comparison) { }
        public static bool StartsWithNewLine(this string s) { }
        public static string StringArrayText(string[] array) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string SubstituteMacros([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<string, string> macros, [JetBrains.Annotations.NotNullAttribute()] string sample) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Times(this int n, [JetBrains.Annotations.NotNullAttribute()] string phrase) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToHexString(this System.IntPtr intptr) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToHexString(System.Void* intptr) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToHexString(this System.UIntPtr uintptr) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToHexString([JetBrains.Annotations.NotNullAttribute()] byte[] buf) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string ToStringIfNonDefault([JetBrains.Annotations.CanBeNullAttribute()] object o) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToStringWithLeading(int value, int maxvalue, System.Globalization.CultureInfo culture) { }
        public static string ToThreadString([JetBrains.Annotations.CanBeNullAttribute()] this System.Threading.Thread thread) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToUtf16HexString([JetBrains.Annotations.NotNullAttribute()] string s) { }
        public static string TrimFQFromStart(string from, string what, System.StringComparison comparison) { }
        public static string TrimFromEnd(this string from, string what) { }
        public static string TrimFromEnd(this string from, string what, System.StringComparison comparison) { }
        public static string TrimFromStart(this string from, string what) { }
        public static string TrimFromStart(this string from, string what, System.StringComparison comparison) { }
        public static string TrimToSingleLineWithMaxLength(this string stringToTrim, int maxLength) { }
        public static string Unquote(string s) { }
    }
    public class StrongToWeakDictionary<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.IDisposable
    
        where TValue :  class
    {
        public StrongToWeakDictionary() { }
        public StrongToWeakDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public StrongToWeakDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public StrongToWeakDictionary(int capacity) { }
        public StrongToWeakDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public StrongToWeakDictionary(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public int Capacity { get; }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
        public TValue this[TKey key] { get; set; }
        public JetBrains.Util.StrongToWeakDictionary<TKey, TValue>.KeyCollection Keys { get; }
        public JetBrains.Util.StrongToWeakDictionary<TKey, TValue>.ValueCollection Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsValue(TValue value) { }
        public void Dispose() { }
        protected override void Finalize() { }
        public JetBrains.Util.StrongToWeakDictionary<TKey, TValue>.PairEnumerator GetEnumerator() { }
        public bool Remove(TKey key) { }
        public void Sweep() { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public sealed class KeyCollection<TKey, TValue> : System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable
        
            where TValue :  class
        {
            public KeyCollection(JetBrains.Util.StrongToWeakDictionary<TKey, TValue> dictionary) { }
            public JetBrains.Util.StrongToWeakDictionary<TKey, TValue>.KeyCollection.KeyEnumerator GetEnumerator() { }
            public struct KeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
            
                where TValue :  class
            {
                public TKey Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
        public struct PairEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
        
            where TValue :  class
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
        public sealed class ValueCollection<TKey, TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
        
            where TValue :  class
        {
            public ValueCollection(JetBrains.Util.StrongToWeakDictionary<TKey, TValue> dictionary) { }
            public JetBrains.Util.StrongToWeakDictionary<TKey, TValue>.ValueCollection.ValueEnumerator GetEnumerator() { }
            public struct ValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            
                where TValue :  class
            {
                public TValue Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
    }
    public class SystemObjectEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>, System.Collections.IEqualityComparer
        where T :  class
    {
        public static readonly JetBrains.Util.SystemObjectEqualityComparer<T> Instance;
    }
    public class TemporaryDirectoryCookie : System.IDisposable
    {
        public JetBrains.Util.FileSystemPath Path { get; }
        public static JetBrains.Util.TemporaryDirectoryCookie CreateFolder(JetBrains.Util.FileSystemPath parentFolder = null) { }
        public void Dispose() { }
        public static JetBrains.Util.TemporaryDirectoryCookie UseFolder(JetBrains.Util.FileSystemPath folderPath) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Range = ({StartOffset}:{EndOffset}), Length = {Length}")]
    public struct TextRange : System.IEquatable<JetBrains.Util.TextRange>
    {
        public static readonly JetBrains.Util.TextRange InvalidRange;
        public TextRange(int startOffset, int endOffset) { }
        public TextRange(int offset) { }
        public int EndOffset { get; }
        public bool IsEmpty { get; }
        public bool IsNormalized { get; }
        public bool IsValid { get; }
        public int Length { get; }
        public int StartOffset { get; }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertContainedIn(JetBrains.Util.TextRange rangeContainer) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertNormalized() { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertValid() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool ContainedIn(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool ContainsCharIndex(int charindex) { }
        [JetBrains.Annotations.PureAttribute()]
        public int DistanceTo(int offset) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Util.TextRange other) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange ExtendLeft(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange ExtendRight(int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.Util.TextRange FromLength(int offset, int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.Util.TextRange FromLength(int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.Util.TextRange FromUnorderedOffsets(int one, int onemore) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.PureAttribute()]
        public int GetMaxOffset() { }
        [JetBrains.Annotations.PureAttribute()]
        public int GetMinOffset() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange Intersect(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Intersects(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool IsLeftTo(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange Join(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange JoinLeft(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange JoinRight(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange Left(int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange Normalized() { }
        public static JetBrains.Util.TextRange Parse(string s) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange Right(int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange SetEndTo(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange SetStartTo(int offset) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange Shift(int delta) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool StrictContainedIn(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool StrictIntersects(JetBrains.Util.TextRange textRange) { }
        [JetBrains.Annotations.PureAttribute()]
        public string ToInvariantString() { }
        public override string ToString() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange TrimLeft(int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange TrimRight(int length) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.TextRange UpdateRange(int changeStartOffset, int oldLength, int newLength, bool greedyToLeft, bool greedyToRight) { }
    }
    public class TextRangeComparer : System.Collections.Generic.IComparer<JetBrains.Util.TextRange>
    {
        public static readonly JetBrains.Util.TextRangeComparer Default;
        public int Compare(JetBrains.Util.TextRange x, JetBrains.Util.TextRange y) { }
    }
    public class static TextRangeEx
    {
        public static bool RangeEndsWith([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range, string value) { }
        public static bool RangeEndsWith([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range, string value, System.StringComparison comparison) { }
        public static bool RangeEquals([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range, string value) { }
        public static bool RangeEquals([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range, string value, System.StringComparison comparison) { }
        public static bool RangeStartsWith([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range, string value) { }
        public static bool RangeStartsWith([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range, string value, System.StringComparison comparison) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Substring([JetBrains.Annotations.NotNullAttribute()] this string str, JetBrains.Util.TextRange range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ToString([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
    }
    [System.ObsoleteAttribute("Inconsistent treatment of line endings due to TextUtil::ReadToEnd, don\'t use unle" +
        "ss you absolutely wish to kill them.")]
    public class TextStreamReader : System.IO.StreamReader
    {
        public TextStreamReader(JetBrains.Util.FileSystemPath fileName) { }
        public override string ReadToEnd() { }
    }
    [System.ObsoleteAttribute("Inconsistent treatment of line endings due to TextUtil::ReadToEnd, don\'t use unle" +
        "ss you absolutely wish to kill them.")]
    public class TextStringReader : System.IO.StringReader
    {
        public TextStringReader(string buffer) { }
        public override string ReadToEnd() { }
    }
    [System.ObsoleteAttribute("Inconsistent treatment of line endings, don\'t use unless you absolutely wish to k" +
        "ill them.")]
    public class TextUtil
    {
        [System.ObsoleteAttribute("Inconsistent treatment of line endings, don\'t use unless you absolutely wish to k" +
            "ill them.")]
        public static string ReadToEnd(System.IO.TextReader reader) { }
    }
    public class TextWriterLogEventListener : JetBrains.Util.ILogEventListener, System.IDisposable
    {
        public TextWriterLogEventListener([JetBrains.Annotations.NotNullAttribute()] System.IO.TextWriter writer) { }
        public bool WereErrors { get; }
        public static JetBrains.Util.TextWriterLogEventListener CreateFileLogger([JetBrains.Annotations.NotNullAttribute()] string identity) { }
        public void Dispose() { }
        public void OnError(string error) { }
        public void OnException(System.Exception ex) { }
        public void OnMessage(string message, JetBrains.Util.LoggingLevel level) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable PushToLogger() { }
    }
    public class ThrowWhatYouCanLogger : JetBrains.Util.ILogger
    {
        public ThrowWhatYouCanLogger([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger loggerForWhatCannotBeThrown) { }
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
    }
    public class TimestampedValue<T>
    
    {
        public TimestampedValue([JetBrains.Annotations.NotNullAttribute()] System.Func<T> evaluator, System.TimeSpan updatePeriod) { }
        public T Value { get; }
    }
    public class TransactionCommitResult
    {
        public TransactionCommitResult(JetBrains.Util.EnsureWritableResult ensureWritableResult, string ensureWritableMessage, bool succeded) { }
        public string EnsureWritableMessage { get; }
        public JetBrains.Util.EnsureWritableResult EnsureWritableResult { get; }
        public bool Succeded { get; }
    }
    public class TypeHierarchyMap<TElement> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, TElement>>, System.Collections.IEnumerable
        where TElement :  class
    {
        public TypeHierarchyMap() { }
        public TElement this[System.Type type] { get; }
        public virtual void Add(System.Type type, TElement element) { }
        protected virtual TElement GetElement(System.Type type) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, TElement>> GetEnumerator() { }
        public virtual System.Type GetRegisteredType(System.Type type) { }
        public virtual void Remove(System.Type type) { }
    }
    public class TypeHierarchyMapCached<TElement> : JetBrains.Util.TypeHierarchyMap<TElement>
        where TElement :  class
    {
        public TypeHierarchyMapCached() { }
        public override void Add(System.Type type, TElement element) { }
        protected override TElement GetElement(System.Type type) { }
        public override System.Type GetRegisteredType(System.Type type) { }
        public override void Remove(System.Type type) { }
    }
    public class static TypeOf
    {
        public static readonly System.Type Boolean;
        public static readonly System.Type Decimal;
        public static readonly System.Type Double;
        public static readonly System.Type Int32;
        public static readonly System.Type Int64;
        public static readonly System.Type Object;
        public static readonly System.Type String;
        public static readonly System.Type UInt64;
    }
    public class UnmanagedBlock : System.IDisposable
    {
        public bool IsDisposed { get; }
        public int Length { get; }
        public System.IntPtr Pointer { get; }
        public static JetBrains.Util.UnmanagedBlock Alloc(int bytes) { }
        public static JetBrains.Util.UnmanagedBlock CreateFromFile(JetBrains.Util.FileSystemPath path) { }
        public static JetBrains.Util.UnmanagedBlock CreateFromStream(System.IO.Stream stream) { }
        public static JetBrains.Util.UnmanagedBlock CreateFromStream(System.IO.Stream stream, int length) { }
        public void Dispose() { }
        public static JetBrains.Util.UnmanagedBlock FromArray(byte[] bytes) { }
        public System.IntPtr GetPointerToOffset(int offset) { }
    }
    public class static UrlUtil
    {
        public static string Encode(string s, System.Text.Encoding encoding) { }
        public static bool IsUnsafe(byte b) { }
    }
    public class UserDataHolder : JetBrains.Util.IUserDataHolder, System.ICloneable
    {
        protected void ClearData() { }
        public virtual object Clone() { }
        public static void CopyUserData(JetBrains.Util.UserDataHolder from, JetBrains.Util.UserDataHolder to) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData() { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        public T GetOrCreateData<T>(JetBrains.Util.Key<T> key, System.Func<T> creator)
            where T :  class { }
        public bool IsEmpty() { }
        public void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class { }
    }
    public class static UserDataHolderExtensions
    {
        public static T GetOrCreateData<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.IUserDataHolder dataHolder, JetBrains.Util.Key<T> key, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T> creator)
            where T :  class { }
        public static T GetOrCreateData<T, TState>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.IUserDataHolder dataHolder, JetBrains.Util.Key<T> key, TState state, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TState, T> creator)
            where T :  class { }
        public static T GetOrCreateData<T, TState1, TState2>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.IUserDataHolder dataHolder, JetBrains.Util.Key<T> key, TState1 state1, TState2 state2, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TState1, TState2, T> creator)
            where T :  class { }
    }
    public class static UserDataObfuscator
    {
        public static string Obfuscate(string text) { }
    }
    public class static Uuid
    {
        public static System.Guid NewUuid(System.Guid namespaceGuid, string value) { }
    }
    public class ValidationException : System.ApplicationException
    {
        public ValidationException(string message) { }
    }
    public class static ValueTypeEx
    {
        public static bool ToBool(this int value) { }
        public static bool ToBool(this uint value) { }
        public static int ToInt(this bool value) { }
    }
    public class WeakCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IDisposable
        where T :  class
    {
        public WeakCollection() { }
        public WeakCollection(System.Collections.Generic.ICollection<T> collection) { }
        public int Capacity { get; }
        public bool IsEmpty { get; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public int CountLive() { }
        public void Dispose() { }
        protected override void Finalize() { }
        public T First() { }
        public T First(System.Func<T, bool> predicate) { }
        public JetBrains.Util.WeakCollection<T>.ElementEnumerator GetEnumerator() { }
        public T Last() { }
        public T Last(System.Func<T, bool> predicate) { }
        public bool Remove(T item) { }
        public void Sweep() { }
        public T[] ToArray() { }
        public System.Collections.Generic.List<T> ToList() { }
        public struct ElementEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            where T :  class
        {
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
    }
    public class WeakHashSet<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IDisposable
        where T :  class
    {
        public WeakHashSet() { }
        public WeakHashSet(System.Collections.Generic.IEnumerable<T> enumerable) { }
        public WeakHashSet(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public WeakHashSet(int capacity) { }
        public WeakHashSet(System.Collections.Generic.IEnumerable<T> enumerable, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public WeakHashSet(System.Collections.Generic.ICollection<T> enumerable, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public WeakHashSet(int capacity, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public int Capacity { get; }
        public System.Collections.Generic.IEqualityComparer<T> Comparer { get; }
        public bool Add(T key) { }
        public void Clear() { }
        public bool Contains(T key) { }
        public void Dispose() { }
        protected override void Finalize() { }
        public JetBrains.Util.WeakHashSet<T>.ElementEnumerator GetEnumerator() { }
        public bool Remove(T key) { }
        public void Sweep() { }
        public struct ElementEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            where T :  class
        {
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Target: {(Target) == null ? \"<DEAD>\" : Target.ToString()}")]
    public struct WeakHolder<T> : System.IDisposable, System.IEquatable<T>
        where T :  class
    {
        public WeakHolder(T target) { }
        public WeakHolder(T target, bool trackResurrection) { }
        public bool Allocated { get; }
        public T Target { get; }
        public void Dispose() { }
        public bool Equals(T other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class WeakReference<T> : System.WeakReference, System.IEquatable<T>
        where T :  class
    {
        public WeakReference(T target) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T Target { get; set; }
        public bool Equals(T other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class WeakToStrongDictionary<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.IDisposable
        where TKey :  class
    
    {
        public WeakToStrongDictionary() { }
        public WeakToStrongDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public WeakToStrongDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public WeakToStrongDictionary(int capacity) { }
        public WeakToStrongDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public WeakToStrongDictionary(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public int Capacity { get; }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
        public TValue this[TKey key] { get; set; }
        public JetBrains.Util.WeakToStrongDictionary<TKey, TValue>.KeyCollection Keys { get; }
        public JetBrains.Util.WeakToStrongDictionary<TKey, TValue>.ValueCollection Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsValue(TValue value) { }
        public void Dispose() { }
        protected override void Finalize() { }
        public JetBrains.Util.WeakToStrongDictionary<TKey, TValue>.PairEnumerator GetEnumerator() { }
        public bool Remove(TKey key) { }
        public void Sweep() { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public sealed class KeyCollection<TKey, TValue> : System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable
            where TKey :  class
        
        {
            public KeyCollection(JetBrains.Util.WeakToStrongDictionary<TKey, TValue> dictionary) { }
            public JetBrains.Util.WeakToStrongDictionary<TKey, TValue>.KeyCollection.KeyEnumerator GetEnumerator() { }
            public struct KeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
                where TKey :  class
            
            {
                public TKey Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
        public struct PairEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
            where TKey :  class
        
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
        public sealed class ValueCollection<TKey, TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
            where TKey :  class
        
        {
            public ValueCollection(JetBrains.Util.WeakToStrongDictionary<TKey, TValue> dictionary) { }
            public JetBrains.Util.WeakToStrongDictionary<TKey, TValue>.ValueCollection.ValueEnumerator GetEnumerator() { }
            public struct ValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                where TKey :  class
            
            {
                public TValue Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
    }
    public class WeakToWeakDictionary<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.IDisposable
        where TKey :  class
        where TValue :  class
    {
        public WeakToWeakDictionary() { }
        public WeakToWeakDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public WeakToWeakDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public WeakToWeakDictionary(int capacity) { }
        public WeakToWeakDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public WeakToWeakDictionary(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public int Capacity { get; }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
        public TValue this[TKey key] { get; set; }
        public JetBrains.Util.WeakToWeakDictionary<TKey, TValue>.KeyCollection Keys { get; }
        public JetBrains.Util.WeakToWeakDictionary<TKey, TValue>.ValueCollection Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsValue(TValue value) { }
        public void Dispose() { }
        protected override void Finalize() { }
        public JetBrains.Util.WeakToWeakDictionary<TKey, TValue>.PairEnumerator GetEnumerator() { }
        public bool Remove(TKey key) { }
        public void Sweep() { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public sealed class KeyCollection<TKey, TValue> : System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable
            where TKey :  class
            where TValue :  class
        {
            public KeyCollection(JetBrains.Util.WeakToWeakDictionary<TKey, TValue> dictionary) { }
            public JetBrains.Util.WeakToWeakDictionary<TKey, TValue>.KeyCollection.KeyEnumerator GetEnumerator() { }
            public struct KeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
                where TKey :  class
                where TValue :  class
            {
                public TKey Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
        public struct PairEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
            where TKey :  class
            where TValue :  class
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
        public sealed class ValueCollection<TKey, TValue> : System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
            where TKey :  class
            where TValue :  class
        {
            public ValueCollection(JetBrains.Util.WeakToWeakDictionary<TKey, TValue> dictionary) { }
            public JetBrains.Util.WeakToWeakDictionary<TKey, TValue>.ValueCollection.ValueEnumerator GetEnumerator() { }
            public struct ValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                where TKey :  class
                where TValue :  class
            {
                public TValue Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
    }
    public class Wildcard
    {
        public Wildcard(string pattern, bool caseSensitive) { }
        public string Pattern { get; }
        public bool IsMatch([JetBrains.Annotations.NotNullAttribute()] string str) { }
        public override string ToString() { }
    }
    public class static XmlEscape
    {
        public static System.Text.StringBuilder AppendXmlAttributeValue([JetBrains.Annotations.NotNullAttribute()] this System.Text.StringBuilder builder, string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string AttributeValue(string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Content(string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string MarkupExtensionAttributeValue(string value, bool wrapInQuotes = True) { }
    }
    public class static XmlReaderEx
    {
        public static void AddLineColumnData([JetBrains.Annotations.CanBeNullAttribute()] this System.Xml.IXmlLineInfo thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        public static void AddLineColumnData([JetBrains.Annotations.CanBeNullAttribute()] this System.Xml.XmlReader thіs, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        public static void AssertAtElement([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] string sElementName) { }
        public static void KeepDepth([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void KeepParentDepth([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void ReadElement([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> funcElem) { }
        public static void ReadElementChildren([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> funcChild) { }
        public static void ReadSiblingElements([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> funcElem) { }
        public static void ReadSubElements([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> action) { }
        public static bool ReadToElementStart([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader) { }
        public static bool ReadToElementStart([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlReader reader, int depth) { }
        public static void ReadXml([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> FRead) { }
        public static void ReadXml([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlReaderSettings settings, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlReader> FRead) { }
    }
    public class XmlRegistrar
    {
        public XmlRegistrar(System.Collections.Specialized.StringDictionary parameterSubstitutions, System.IO.TextReader textReader) { }
        public void Register() { }
        public void Unregister() { }
    }
    public class static XmlUnescape
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string MarkupExtensionValue(string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Value(string value) { }
    }
    public class static XmlUtil
    {
        public static readonly JetBrains.Util.BidirectionalMap<string, char> XmlPredefinedEntities;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Xml.XmlElement> ChildElements([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement parent) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Xml.XmlAttribute CreateAttributeWithNonEmptyValue([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attrName, [JetBrains.Annotations.CanBeNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlElement CreateAttributeWithNonEmptyValueFluent([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attrName, [JetBrains.Annotations.CanBeNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use XmlElement::SetAttribute(string, string).")]
        public static System.Xml.XmlAttribute CreateAttributeWithValue([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attrName, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlElement CreateAttributeWithValueFluent([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attrName, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlElement CreateElement([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlNode parent, [JetBrains.Annotations.NotNullAttribute()] string tagName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlElement CreateLeafElementWithValue([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] string tagName, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string EscapeXmlString([JetBrains.Annotations.NotNullAttribute()] string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string EscapeXmlString([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.Util.RangeTranslator translator) { }
        public static System.Nullable<T> GetAttribute<T>([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName)
            where T :  struct { }
        public static string GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName) { }
        public static T GetAttribute<T>([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, T defaultValue)
            where T :  struct { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, [JetBrains.Annotations.CanBeNullAttribute()] string defaultValue) { }
        public static bool GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, bool defaultValue) { }
        public static System.Guid GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, System.Guid defaultValue) { }
        public static int GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, int defaultValue) { }
        public static int GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, System.Globalization.NumberStyles style, [JetBrains.Annotations.NotNullAttribute()] System.Globalization.NumberFormatInfo numberFormatInfo, int defaultValue) { }
        public static long GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, long defaultValue) { }
        public static double GetAttribute([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName, double defaultValue) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TNode InsertAfterThat<TNode>([JetBrains.Annotations.NotNullAttribute()] this TNode @this, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlNode xmlReference)
            where TNode : System.Xml.XmlNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TNode InsertBeforeThat<TNode>([JetBrains.Annotations.NotNullAttribute()] this TNode @this, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlNode xmlReference)
            where TNode : System.Xml.XmlNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlDocument OwnerDocumentNonNull([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlNode thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlNode ParentNodeNonNull([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlNode thіs) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string ReadAttribute([JetBrains.Annotations.CanBeNullAttribute()] this System.Xml.XmlElement element, [JetBrains.Annotations.NotNullAttribute()] string attributeName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string ReadLeafElementValue([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] string tagName) { }
        public static string ReadLeafElementValue([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Xml.XmlElement SelectElement([JetBrains.Annotations.CanBeNullAttribute()] this System.Xml.XmlElement parent, [JetBrains.Annotations.NotNullAttribute()] string tagName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Xml.XmlElement> SelectElements([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlNode parent, [JetBrains.Annotations.NotNullAttribute()] string xpath, [JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlNamespaceManager namespaceManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<System.Xml.XmlElement> SelectElements([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlNode parent, [JetBrains.Annotations.NotNullAttribute()] string xpath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Xml.XmlElement SelectSingleElement([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlNode parent, [JetBrains.Annotations.NotNullAttribute()] string xpath) { }
        public static bool ShouldEscape(string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeXmlString([JetBrains.Annotations.NotNullAttribute()] string xmlText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string UnescapeXmlString([JetBrains.Annotations.NotNullAttribute()] string xmlText, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.Util.RangeTranslator translator) { }
        public static void UnescapeXmlString([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder result, [JetBrains.Annotations.NotNullAttribute()] string xmlText, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.RangeTranslator translator = null) { }
        public static string XmlElementToString(System.Xml.XmlElement xmlElement) { }
    }
    public class static XmlWriterEx
    {
        public static System.Xml.XmlWriterSettings WriterSettings { get; }
        public static TWriter Attr<TWriter>([JetBrains.Annotations.NotNullAttribute()] this TWriter writer, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] object value)
            where TWriter : System.Xml.XmlWriter { }
        public static System.Xml.XmlWriter CreateWriter([JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream) { }
        public static void Element([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        public static void InElement([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action nested) { }
        public static void InElementNs([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string xmlns, [JetBrains.Annotations.NotNullAttribute()] System.Action nested) { }
        public static System.IDisposable PushElement([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public static System.IDisposable PushElementNs([JetBrains.Annotations.NotNullAttribute()] this System.Xml.XmlWriter writer, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string xmlns) { }
        public static void WriteXml([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlWriter> FWrite) { }
        public static void WriteXml([JetBrains.Annotations.NotNullAttribute()] this System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlWriterSettings settings, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Xml.XmlWriter> FWrite) { }
    }
}
namespace JetBrains.Util.Caches
{
    
    public class static CachedValues
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.ReturnsThreadSafeAttribute()]
        public static JetBrains.Util.Caches.ICachedValue<T> CreateStrongCachedValue<T>([JetBrains.Annotations.CanBeNullAttribute()] T initialValue = null)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.ReturnsThreadSafeAttribute()]
        public static JetBrains.Util.Caches.IParametrizedCachedValue<T, TParam> CreateStrongParametrizedCachedValue<T, TParam>([JetBrains.Annotations.CanBeNullAttribute()] T initialValue = null)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.ReturnsThreadSafeAttribute()]
        public static JetBrains.Util.Caches.ICachedValue<T> CreateWeakCachedValue<T, TCacheItem>([JetBrains.Annotations.NotNullAttribute()] System.Func<T> producer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Caches.IWeakRefRetainerCache<TCacheItem> cache, [JetBrains.Annotations.CanBeNullAttribute()] T initialValue = null, int cacheTouchFrequency = 1)
            where T :  class, TCacheItem { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.ReturnsThreadSafeAttribute()]
        public static JetBrains.Util.Caches.IParametrizedCachedValue<T, TParam> CreateWeakParametrizedCachedValue<T, TParam, TCacheItem>(System.Func<TParam, T> producer, JetBrains.Util.Caches.IWeakRefRetainerCache<TCacheItem> cache, T initialValue = null, int cacheTouchFrequency = 1)
            where T :  class, TCacheItem { }
        [JetBrains.Annotations.ThreadSafeAttribute()]
        public static bool HasValue<T>(this JetBrains.Util.Caches.ICachedValueBase<T> cachedValue)
            where T :  class { }
        [JetBrains.Annotations.ThreadSafeAttribute()]
        public static void SetIfNull<T, TInheritor>(this JetBrains.Util.Caches.ICachedValueBase<T> cachedValue, System.Func<TInheritor> functor)
            where T :  class
            where TInheritor : T { }
        [JetBrains.Annotations.ThreadSafeAttribute()]
        public static void SetIfNull<T, TParam, TInheritor>(this JetBrains.Util.Caches.ICachedValueBase<T> cachedValue, System.Func<TParam, TInheritor> functor, TParam param)
            where T :  class
        
            where TInheritor : T { }
    }
    [JetBrains.Annotations.ThreadSafeAttribute()]
    public class DirectMappedCache<TKey, TValue> : JetBrains.Util.Caches.ICachedBackend<TKey, TValue>, JetBrains.Util.Caches.IDictionaryBasedCache<TKey, TValue>, JetBrains.Util.Caches.IExternalProviderCache<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        public DirectMappedCache(int size, System.Collections.Generic.IEqualityComparer<TKey> comparer = null, JetBrains.Util.Caches.ICacheBackendProvider<TKey, TValue> provider = null) { }
        public void Add(TKey key, TValue val) { }
        public void AddToCache(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKeyInCache(TKey key) { }
        public void Flush(TKey key) { }
        public void Flush() { }
        public TValue GetCachedValue(TKey key) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        public TValue GetOrCreate(TKey key) { }
        public TValue GetOrCreate<TKeyInheritor>(TKeyInheritor key, System.Func<TKeyInheritor, TValue> provider)
            where TKeyInheritor : TKey { }
        public TValue GetOrCreate<TKeyInheritor, TParam>(TKeyInheritor key, TParam param, System.Func<TKeyInheritor, TParam, TValue> provider)
            where TKeyInheritor : TKey { }
        public void Remove(TKey key) { }
        public bool RemoveFromCache(TKey key) { }
        public TKey TryGetInternedKey(TKey key) { }
        public bool TryGetOrCreate(TKey key, out TValue val) { }
    }
    public interface ICacheBackendProvider<TKey, TValue>
    
    
    {
        bool ContainsKey(TKey key);
        void Put(TKey key, TValue val);
        void Remove(TKey key);
        bool TryGetValue(TKey key, out TValue val);
    }
    public interface ICachedBackend<TKey, TValue> : JetBrains.Util.Caches.IDictionaryBasedCache<TKey, TValue>
    
    
    {
        void Add(TKey key, TValue val);
        void Flush(TKey key);
        void Flush();
        void Remove(TKey key);
    }
    public interface ICachedValue<T> : JetBrains.Util.Caches.ICachedValueBase<T>
        where T :  class
    {
        [JetBrains.Annotations.NotNullAttribute()]
        T GetOrCreate();
    }
    public interface ICachedValueBase<T>
        where T :  class
    {
        void Clear();
        void Set([JetBrains.Annotations.NotNullAttribute()] T value);
        [JetBrains.Annotations.CanBeNullAttribute()]
        T TryGet();
    }
    public interface IDictionaryBasedCache<TKey, TValue>
    
    
    {
        void AddToCache(TKey key, TValue value);
        void Clear();
        bool ContainsKeyInCache(TKey key);
        TValue GetOrCreate(TKey key);
        bool RemoveFromCache(TKey key);
        TKey TryGetInternedKey(TKey key);
    }
    public interface IExternalProviderCache<TKey, TValue> : JetBrains.Util.Caches.IDictionaryBasedCache<TKey, TValue>
    
    
    {
        TValue GetOrCreate<TKeyInheritor>(TKeyInheritor key, System.Func<TKeyInheritor, TValue> provider)
            where TKeyInheritor : TKey;
        TValue GetOrCreate<TKeyInheritor, TParam>(TKeyInheritor key, TParam param, System.Func<TKeyInheritor, TParam, TValue> provider)
            where TKeyInheritor : TKey
        ;
    }
    public interface IParametrizedCachedValue<T, in TFunctorParameter> : JetBrains.Util.Caches.ICachedValueBase<T>
        where T :  class
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        T GetOrCreate([JetBrains.Annotations.CanBeNullAttribute()] TFunctorParameter parameter);
        bool GetOrCreate([JetBrains.Annotations.CanBeNullAttribute()] TFunctorParameter parameter, [JetBrains.Annotations.NotNullAttribute()] out T result);
        [JetBrains.Annotations.CanBeNullAttribute()]
        T TryGetSync();
    }
    public interface IWeakCachedValue
    {
        int CacheTouchFrequency { get; set; }
    }
    public interface IWeakRefRetainerCache<in T>
    
    {
        int Count { get; }
        void Clear();
        bool Contains(T item);
        int Evict();
        bool Remove(T item);
        bool Touch(T item);
    }
    [JetBrains.Annotations.ThreadSafeAttribute()]
    public class LRUWeakRefRetainerCache<T> : JetBrains.Util.Caches.IWeakRefRetainerCache<T>
        where T :  class
    {
        public const long EvictionTimerIntervalMillis = 3000;
        public LRUWeakRefRetainerCache(JetBrains.DataFlow.Lifetime lifetime, int capacity, System.Collections.Generic.IEqualityComparer<T> comparer = null, long invalidateTimeInMillis = 0, int invalidationSurvivalThreshold = 0) { }
        public int Count { get; }
        public System.Collections.Generic.IList<T> Items { get; }
        public void Clear() { }
        public bool Contains(T item) { }
        public int Evict() { }
        public bool Remove(T item) { }
        public bool Touch(T item) { }
        public void VerifyCorrect() { }
    }
    public class WeakRefRetainerMultiCache<T> : JetBrains.Util.Caches.IWeakRefRetainerCache<T>
        where T :  class
    {
        public WeakRefRetainerMultiCache([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.Util.Caches.IWeakRefRetainerCache<T>> caches, [JetBrains.Annotations.NotNullAttribute()] System.Func<T, JetBrains.Util.Caches.IWeakRefRetainerCache<T>> dispatcher) { }
        public System.Collections.Generic.IList<JetBrains.Util.Caches.IWeakRefRetainerCache<T>> Caches { get; }
        public int Count { get; }
        public void Clear() { }
        public bool Contains(T item) { }
        public int Evict() { }
        public bool Remove(T item) { }
        public bool Touch(T item) { }
    }
}
namespace JetBrains.Util.Collections
{
    
    [System.ObsoleteAttribute("No usages in ReSharper")]
    public class ComparisonListSorter<T> : JetBrains.Util.Collections.IListSorter<T>
    
    {
        public ComparisonListSorter([JetBrains.Annotations.NotNullAttribute()] System.Comparison<T> comparison) { }
        public T[] Sort(System.Collections.Generic.List<T> list) { }
    }
    [JetBrains.Annotations.ThreadUnsafeAttribute()]
    public class CountingSet<T> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T, int>>, System.Collections.IEnumerable
    
    {
        public CountingSet() { }
        public CountingSet(int capacity) { }
        public CountingSet(int capacity, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public int Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public int GetCount(T item) { }
        public System.Collections.Generic.Dictionary<T, int>.Enumerator GetEnumerator() { }
        public System.Collections.Generic.IEnumerable<T> GetItems() { }
        public int Remove(T item) { }
    }
    [JetBrains.Annotations.ImmutableAttribute()]
    public class EnumerableCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public static readonly System.Collections.Generic.ICollection<T> Empty;
        public EnumerableCollection([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> enumerable, int count) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public bool Remove(T item) { }
    }
    public class static EnumeratorExt
    {
        public static bool Any<TEnumerator>(this TEnumerator source)
            where TEnumerator :  struct, System.Collections.IEnumerator { }
        public static bool CountEq<TEnumerator>(this TEnumerator source, int expectedCount)
            where TEnumerator :  struct, System.Collections.IEnumerator { }
        public static bool CountLeq<TEnumerator>(this TEnumerator source, int expectedCount)
            where TEnumerator :  struct, System.Collections.IEnumerator { }
    }
    public class HashMap<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        public HashMap() { }
        public HashMap(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public HashMap(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public HashMap(int capacity) { }
        public HashMap(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public HashMap(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
        public int Count { get; }
        public TValue this[TKey key] { get; set; }
        public JetBrains.Util.Collections.HashMap<TKey, TValue>.KeyCollection Keys { get; }
        public JetBrains.Util.Collections.HashMap<TKey, TValue>.ValueCollection Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsValue(TValue value) { }
        public JetBrains.Util.Collections.HashMap<TKey, TValue>.PairEnumerator GetEnumerator() { }
        public bool IsEmpty() { }
        public bool Remove(TKey key) { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public sealed class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable
        
        
        {
            public KeyCollection(JetBrains.Util.Collections.HashMap<TKey, TValue> dictionary) { }
            public int Count { get; }
            public void CopyTo(TKey[] array, int arrayIndex) { }
            public JetBrains.Util.Collections.HashMap<TKey, TValue>.KeyCollection.KeyEnumerator GetEnumerator() { }
            public struct KeyEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
            
            
            {
                public TKey Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
        public struct PairEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
        
        
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
        public sealed class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
        
        
        {
            public ValueCollection(JetBrains.Util.Collections.HashMap<TKey, TValue> dictionary) { }
            public int Count { get; }
            public void CopyTo(TValue[] array, int arrayIndex) { }
            public JetBrains.Util.Collections.HashMap<TKey, TValue>.ValueCollection.ValueEnumerator GetEnumerator() { }
            public struct ValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            
            
            {
                public TValue Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
    }
    [System.ObsoleteAttribute("No usages in ReSharper")]
    public interface IListSorter<T>
    
    {
        T[] Sort(System.Collections.Generic.List<T> list);
    }
    public class LazyProcessedCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public LazyProcessedCollection([JetBrains.Annotations.NotNullAttribute()] System.Func<System.Collections.Generic.List<T>, System.Collections.Generic.List<T>> processor) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public bool Remove(T item) { }
    }
    public class LimitedDictionary<TKey, TValue>
    
    
    {
        public LimitedDictionary(int maxCount) { }
        public TValue GetItemWithCache(TKey key, System.Func<TKey, TValue> eval) { }
    }
    public class OrderedCollection<T> : JetBrains.Util.Collections.LazyProcessedCollection<T>
    
    {
        public OrderedCollection([JetBrains.Annotations.NotNullAttribute()] System.Comparison<T> comparer) { }
    }
    public class static WeakCollectionsManager
    {
        public static readonly JetBrains.Util.Statistics Statistics;
    }
}
namespace JetBrains.Util.Collections.JetBinaryTree
{
    
    [System.FlagsAttribute()]
    public enum AdvancedMatchingResults
    {
        NoAction = 0,
        Match = 1,
        VisitLeft = 2,
        VisitRight = 4,
    }
    public enum FindStrategy
    {
        Exactly = 0,
        NearestBelow = 1,
        NearestAbove = 2,
    }
    [JetBrains.Annotations.ThreadUnsafeAttribute()]
    public class JetBinaryTree<TKeyType, TDataType> : JetBrains.Util.ICloneable<JetBrains.Util.Collections.JetBinaryTree.JetBinaryTree<TKeyType, TDataType>>, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TKeyType, TDataType>>, System.Collections.IEnumerable, System.ICloneable
    
    
    {
        public JetBinaryTree(System.Collections.Generic.IComparer<TKeyType> comparer = null) { }
        protected JetBinaryTree(JetBrains.Util.Collections.JetBinaryTree.JetBinaryTree<TKeyType, TDataType> copyFrom) { }
        public int Size { get; }
        public void Add([JetBrains.Annotations.NotNullAttribute()] TKeyType key, [JetBrains.Annotations.NotNullAttribute()] TDataType data) { }
        public void Clear() { }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTree<TKeyType, TDataType> Clone() { }
        public System.Collections.Generic.IEnumerable<TDataType> FindData(System.Func<TKeyType, JetBrains.Util.Collections.JetBinaryTree.AdvancedMatchingResults> comparer) { }
        public TDataType FindData(TKeyType key, JetBrains.Util.Collections.JetBinaryTree.FindStrategy strategy = 0, TDataType defaultData = null, System.Collections.Generic.IComparer<TKeyType> comparer = null) { }
        public TDataType GetData(TKeyType key) { }
        public System.Collections.Generic.IEnumerator<JetBrains.Util.Pair<TKeyType, TDataType>> GetEnumerator() { }
        public TKeyType GetMaxKey() { }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> GetMaxNode() { }
        public TDataType GetMaxValue() { }
        public TKeyType GetMinKey() { }
        public TDataType GetMinValue() { }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> GetNode(TKeyType key) { }
        public void InplaceReplace([JetBrains.Annotations.NotNullAttribute()] TKeyType oldKey, [JetBrains.Annotations.NotNullAttribute()] TKeyType newKey, [JetBrains.Annotations.NotNullAttribute()] TDataType newData) { }
        public bool IsEmpty() { }
        public System.Collections.Generic.IEnumerable<TKeyType> Keys(bool ascending = True) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType>> Nodes(bool ascending = True) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<TKeyType, TDataType>> Pairs(bool ascending = True) { }
        public void Remove([JetBrains.Annotations.NotNullAttribute()] TKeyType key) { }
        public void RemoveMax() { }
        public void RemoveMin() { }
        protected void RotateLeft(JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> x) { }
        protected void RotateRight(JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> x) { }
        public System.Collections.Generic.IEnumerable<TDataType> Values(bool ascending = True) { }
    }
    public class JetBinaryTreeEnumerator<TKeyType, TDataType>
    
    
    {
        public JetBinaryTreeEnumerator(JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> node, bool ascending, JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> sentinelNode) { }
        public TKeyType Key { get; set; }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> Node { get; set; }
        public TDataType Value { get; set; }
        public bool HasMoreElements() { }
        public bool MoveNext() { }
        public TDataType NextElement() { }
    }
    public class JetBinaryTreeException : System.Exception
    {
        public JetBinaryTreeException(string message) { }
    }
    public class JetBinaryTreeNode<TKeyType, TDataType>
    
    
    {
        public JetBinaryTreeNode() { }
        public JetBrains.Util.Collections.JetBinaryTree.NodeColor Color { get; set; }
        public TDataType Data { get; set; }
        public TKeyType Key { get; set; }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> Left { get; set; }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> Parent { get; set; }
        public JetBrains.Util.Collections.JetBinaryTree.JetBinaryTreeNode<TKeyType, TDataType> Right { get; set; }
    }
    public enum NodeColor
    {
        Red = 0,
        Black = 1,
    }
}
namespace JetBrains.Util.Colors
{
    
    public class static ColorManagement
    {
        public static byte MaxHLS { get; }
        public static byte MaxRGB { get; }
        public static byte UndefinedHue { get; }
        public static uint BGR(System.Drawing.Color color) { }
        public static uint BlendTwo(uint rgbA, uint rgbB) { }
        public static byte ConstrainHls(int value) { }
        public static System.Drawing.Color GetAlphaBlendedColor(System.Drawing.Color src, System.Drawing.Color dest, int alpha) { }
        public static byte GetBValue(uint RGB) { }
        public static System.Drawing.Color GetContastedForeground(System.Drawing.Color background, System.Drawing.Color foreground, double contrast = 0.45, double margin = 0.02, double whiteBalance = 0.66) { }
        public static byte GetGValue(uint RGB) { }
        public static byte GetRValue(uint RGB) { }
        public static System.Drawing.Color GetSimilarForeground(System.Drawing.Color foreground, System.Drawing.Color goodForeground) { }
        public static uint HLStoBGR(ushort hue, ushort lum, ushort sat) { }
        public static void HLStoRGB(ushort H, ushort L, ushort S, out byte R, out byte G, out byte B) { }
        public static System.Drawing.Color HLStoRGB(ushort H, ushort L, ushort S) { }
        public static ushort HueToRGB(ushort n1, ushort n2, ushort hue) { }
        public static System.Drawing.Color Invert(System.Drawing.Color color) { }
        public static System.Drawing.Color MakeMonochrome(System.Drawing.Color colorSrc, System.Drawing.Color colorBias = null) { }
        public static System.Windows.Media.Color MakeMonochrome(System.Windows.Media.Color colorSrc, System.Windows.Media.Color colorBias = null) { }
        public static System.Windows.Media.Imaging.BitmapSource MakeMonochrome([JetBrains.Annotations.NotNullAttribute()] System.Windows.Media.Imaging.BitmapSource bmpSrc, System.Windows.Media.Color colorBias = null) { }
        public static System.Drawing.Color MakeSimilarColor(System.Drawing.Color color, System.Drawing.Color pattern, double threshold = 0.3, double offset = 0.07) { }
        public static uint Mix(uint colorA, uint colorB, double fA) { }
        public static System.Drawing.Color Mix(System.Drawing.Color colorA, System.Drawing.Color colorB, double proportion) { }
        public static System.Windows.Media.Color Mix(System.Windows.Media.Color colorA, System.Windows.Media.Color colorB, double proportion) { }
        public static uint RGB(byte R, byte G, byte B) { }
        public static uint RGB(System.Drawing.Color color) { }
        public static uint RGB(System.Windows.Media.Color color) { }
        public static uint RGB2BGR(uint color) { }
        public static void RGBtoHLS(uint lRGBColor, out byte H, out byte L, out byte S) { }
    }
    [System.ObsoleteAttribute("Use structs from JetBrains.Util.Colors.ColorSpaces")]
    public struct HslColor
    {
        public double H { get; set; }
        public double L { get; set; }
        public double S { get; set; }
        public static JetBrains.Util.Colors.HslColor FromRGB(System.Windows.Media.Color rgb) { }
        public static System.Drawing.Color HslToRgb(double alpha, double h, double s, double l) { }
        public static void RgbToHsl(System.Drawing.Color rgbColor, out double hue, out double sat, out double lum) { }
        public System.Windows.Media.Color ToRgb() { }
    }
}
namespace JetBrains.Util.Colors.ColorSpaces
{
    
    public struct CIELab
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.CIELab Empty;
        public CIELab(double l, double a, double b) { }
        public double A { get; set; }
        public double B { get; set; }
        public double L { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public struct CIEXYZ
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.CIEXYZ D65;
        public static readonly JetBrains.Util.Colors.ColorSpaces.CIEXYZ Empty;
        public CIEXYZ(double x, double y, double z) { }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public struct CMYK
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.CMYK Empty;
        public CMYK(double c, double m, double y, double k) { }
        public double Black { get; set; }
        public double Cyan { get; set; }
        public double Magenta { get; set; }
        public double Yellow { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public sealed class ColorSpace
    {
        public static System.Windows.Media.Color CMYKtoColor(float c, float m, float y, float k) { }
        public static System.Windows.Media.Color CMYKtoColor(double c, double m, double y, double k) { }
        public static System.Windows.Media.Color CMYKtoColor(JetBrains.Util.Colors.ColorSpaces.CMYK cmyk) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSB CMYKtoHSB(double c, double m, double y, double k) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSL CMYKtoHSL(double c, double m, double y, double k) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB CMYKtoRGB(double c, double m, double y, double k) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB CMYKtoRGB(JetBrains.Util.Colors.ColorSpaces.CMYK cmyk) { }
        public static JetBrains.Util.Colors.ColorSpaces.YUV CMYKtoYUV(double c, double m, double y, double k) { }
        public static double GetColorDistance(double r1, double g1, double b1, double r2, double g2, double b2) { }
        public static double GetColorDistance(double[] color1, double[] color2) { }
        public static double GetColorDistance(System.Windows.Media.Color c1, System.Windows.Media.Color c2) { }
        public static System.Windows.Media.Color HexToColor(string hexColor) { }
        public static JetBrains.Util.Colors.ColorSpaces.CMYK HSBtoCMYK(double h, double s, double b) { }
        public static System.Windows.Media.Color HSBtoColor(JetBrains.Util.Colors.ColorSpaces.HSB hsb) { }
        public static System.Windows.Media.Color HSBtoColor(double h, double s, double b) { }
        public static System.Windows.Media.Color HSBtoColor(int h, int s, int b) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSL HSBtoHSL(double h, double s, double b) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB HSBtoRGB(JetBrains.Util.Colors.ColorSpaces.HSB hsb) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB HSBtoRGB(double h, double s, double b) { }
        public static JetBrains.Util.Colors.ColorSpaces.YUV HSBtoYUV(double h, double s, double b) { }
        public static JetBrains.Util.Colors.ColorSpaces.CMYK HSLtoCMYK(double h, double s, double l) { }
        public static System.Windows.Media.Color HSLtoColor(double h, double s, double l) { }
        public static System.Windows.Media.Color HSLtoColor(JetBrains.Util.Colors.ColorSpaces.HSL hsl) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSB HSLtoHSB(double h, double s, double l) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB HSLtoRGB(double h, double s, double l) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB HSLtoRGB(JetBrains.Util.Colors.ColorSpaces.HSL hsl) { }
        public static JetBrains.Util.Colors.ColorSpaces.YUV HSLtoYUV(double h, double s, double l) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB LabtoRGB(double l, double a, double b) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB LabtoRGB(JetBrains.Util.Colors.ColorSpaces.CIELab lab) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIEXYZ LabtoXYZ(double l, double a, double b) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIEXYZ LabtoXYZ(JetBrains.Util.Colors.ColorSpaces.CIELab lab) { }
        public static JetBrains.Util.Colors.ColorSpaces.CMYK RGBtoCMYK(int red, int green, int blue) { }
        public static JetBrains.Util.Colors.ColorSpaces.CMYK RGBtoCMYK(System.Windows.Media.Color c) { }
        public static JetBrains.Util.Colors.ColorSpaces.CMYK RGBtoCMYK(JetBrains.Util.Colors.ColorSpaces.RGB rgb) { }
        public static System.Windows.Media.Color RGBtoColor(JetBrains.Util.Colors.ColorSpaces.RGB rGB) { }
        public static string RGBToHex(int r, int g, int b) { }
        public static string RGBToHex(System.Windows.Media.Color c) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSB RGBtoHSB(int red, int green, int blue) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSB RGBtoHSB(JetBrains.Util.Colors.ColorSpaces.RGB rgb) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSB RGBtoHSB(System.Windows.Media.Color c) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSL RGBtoHSL(int red, int green, int blue) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSL RGBtoHSL(JetBrains.Util.Colors.ColorSpaces.RGB rgb) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSL RGBtoHSL(System.Windows.Media.Color c) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIELab RGBtoLab(int red, int green, int blue) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIELab RGBtoLab(JetBrains.Util.Colors.ColorSpaces.RGB rgb) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIELab RGBtoLab(System.Windows.Media.Color color) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIEXYZ RGBtoXYZ(int red, int green, int blue) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIEXYZ RGBtoXYZ(JetBrains.Util.Colors.ColorSpaces.RGB rgb) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIEXYZ RGBtoXYZ(System.Windows.Media.Color c) { }
        public static JetBrains.Util.Colors.ColorSpaces.YUV RGBtoYUV(int red, int green, int blue) { }
        public static JetBrains.Util.Colors.ColorSpaces.YUV RGBtoYUV(System.Windows.Media.Color c) { }
        public static JetBrains.Util.Colors.ColorSpaces.YUV RGBtoYUV(JetBrains.Util.Colors.ColorSpaces.RGB rgb) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIELab XYZtoLab(double x, double y, double z) { }
        public static JetBrains.Util.Colors.ColorSpaces.CIELab XYZtoLab(JetBrains.Util.Colors.ColorSpaces.CIEXYZ xyz) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB XYZtoRGB(double x, double y, double z) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB XYZtoRGB(JetBrains.Util.Colors.ColorSpaces.CIEXYZ xyz) { }
        public static JetBrains.Util.Colors.ColorSpaces.CMYK YUVtoCMYK(double y, double u, double v) { }
        public static System.Windows.Media.Color YUVtoColor(double y, double u, double v) { }
        public static System.Windows.Media.Color YUVtoColor(JetBrains.Util.Colors.ColorSpaces.YUV yuv) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSB YUVtoHSB(double y, double u, double v) { }
        public static JetBrains.Util.Colors.ColorSpaces.HSL YUVtoHSL(double y, double u, double v) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB YUVtoRGB(double y, double u, double v) { }
        public static JetBrains.Util.Colors.ColorSpaces.RGB YUVtoRGB(JetBrains.Util.Colors.ColorSpaces.YUV yuv) { }
    }
    public struct HSB
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.HSB Empty;
        public HSB(double h, double s, double b) { }
        [System.ComponentModel.DescriptionAttribute("Brightness component")]
        public double Brightness { get; set; }
        [System.ComponentModel.DescriptionAttribute("Hue component")]
        public double Hue { get; set; }
        [System.ComponentModel.DescriptionAttribute("Saturation component")]
        public double Saturation { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public struct HSL
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.HSL Empty;
        public HSL(double h, double s, double l) { }
        [System.ComponentModel.DescriptionAttribute("Hue component")]
        public double Hue { get; set; }
        [System.ComponentModel.DescriptionAttribute("Luminance component")]
        public double Luminance { get; set; }
        [System.ComponentModel.DescriptionAttribute("Saturation component")]
        public double Saturation { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public struct RGB
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.RGB Empty;
        public RGB(int R, int G, int B) { }
        [System.ComponentModel.DescriptionAttribute("Blue component.")]
        public int Blue { get; set; }
        [System.ComponentModel.DescriptionAttribute("Green component.")]
        public int Green { get; set; }
        [System.ComponentModel.DescriptionAttribute("Red component.")]
        public int Red { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public struct YUV
    {
        public static readonly JetBrains.Util.Colors.ColorSpaces.YUV Empty;
        public YUV(double y, double u, double v) { }
        public double U { get; set; }
        public double V { get; set; }
        public double Y { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.Util.Concurrency
{
    
    public struct DisposableReadLock : System.IDisposable
    {
        public DisposableReadLock(System.Threading.ReaderWriterLockSlim @lock) { }
        public void Dispose() { }
    }
    public struct DisposableWriteLock : System.IDisposable
    {
        public DisposableWriteLock(System.Threading.ReaderWriterLockSlim @lock) { }
        public void Dispose() { }
    }
    public struct FrugalLocalLazy<T>
        where T :  class, new ()
    {
        public bool IsValueCreated { get; }
        public T GetValue() { }
        public override string ToString() { }
    }
    public class static GroupingEventHostEx
    {
        public static void QueueAtShort([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Threading.GroupingEventHost thіs, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, System.TimeSpan interval, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
    }
    public interface ISync
    {
        void Acquire();
        void Release();
        bool TryAcquire(int timeout);
    }
    public struct LocalLazy<TValue>
    
    {
        public LocalLazy(System.LazyExecutionMode mode) { }
        public LocalLazy([JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> valueFactory, System.LazyExecutionMode mode = 0) { }
        [get: JetBrains.Annotations.PureAttribute()]
        public bool IsValueCreated { get; }
        public TValue GetValue() { }
        [JetBrains.Annotations.PureAttribute()]
        public override string ToString() { }
    }
    public struct LocalLazy<TValue, TFactoryParameter>
    
    
    {
        public LocalLazy([JetBrains.Annotations.NotNullAttribute()] System.Func<TFactoryParameter, TValue> FFactory, TFactoryParameter parameter) { }
        public LocalLazy([JetBrains.Annotations.NotNullAttribute()] System.Func<TFactoryParameter, TValue> FFactory, TFactoryParameter parameter, System.LazyExecutionMode mode) { }
        [get: JetBrains.Annotations.PureAttribute()]
        public bool IsValueCreated { get; }
        public TValue GetValue() { }
        [JetBrains.Annotations.PureAttribute()]
        public override string ToString() { }
    }
    public class LockObject
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IDisposable UsingLock(System.TimeSpan timeout) { }
    }
    public class NativeAutoEvent : JetBrains.Util.Concurrency.NativeEvent
    {
        public NativeAutoEvent(bool initialState, string name) { }
    }
    public abstract class NativeEvent : System.IDisposable
    {
        protected NativeEvent(bool initialState, System.Threading.EventResetMode mode, string name) { }
        public void Dispose() { }
        public bool IsSet() { }
        public void Reset() { }
        public void Set() { }
        public bool WaitOne(int timeout) { }
        public void WaitOne() { }
    }
    public class NativeManualEvent : JetBrains.Util.Concurrency.NativeEvent
    {
        public NativeManualEvent(bool initialState, string name) { }
    }
    public class static ReaderWriterLockSlimEx
    {
        public static void EnterReadLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, System.TimeSpan time) { }
        public static void EnterReadLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, int timeoutms) { }
        public static void EnterUpgradeableReadLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, System.TimeSpan time) { }
        public static void EnterWriteLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, System.TimeSpan time) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable UsingReadLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, System.TimeSpan time) { }
        public static JetBrains.Util.Concurrency.DisposableReadLock UsingReadLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable UsingUpgradeableReadLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, System.TimeSpan time) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable UsingWriteLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs, System.TimeSpan time) { }
        public static JetBrains.Util.Concurrency.DisposableWriteLock UsingWriteLock([JetBrains.Annotations.NotNullAttribute()] this System.Threading.ReaderWriterLockSlim thіs) { }
    }
    public interface ReadWriteLock
    {
        JetBrains.Util.Concurrency.ISync ReadLock { get; }
        JetBrains.Util.Concurrency.ISync WriteLock { get; }
    }
    public class ReentrantWriterPreferenceReadWriteLock : JetBrains.Util.Concurrency.ReadWriteLock
    {
        public ReentrantWriterPreferenceReadWriteLock() { }
        public bool IsWriteLockRequested { get; }
        public JetBrains.Util.Concurrency.ISync ReadLock { get; }
        public JetBrains.Util.Concurrency.ISync WriteLock { get; }
        public bool IsReadLockAcquired(System.Threading.Thread thread) { }
        public bool IsWriteLockAcquired(System.Threading.Thread thread) { }
        public void RestoreWriteLock() { }
        public void TransferWriteLock(System.Threading.Thread anotherThread) { }
    }
    public struct SpinWaitLock
    {
        public static int ApprovedProcessorCount { get; }
        public void Enter() { }
        public void Exit() { }
        public bool TryEnter() { }
    }
    public class static SpinWaitLockExtensions
    {
        public static JetBrains.Util.Concurrency.SpinWaitLockExtensions.SpinWaitLockCookie Acquire(this JetBrains.Util.Concurrency.SpinWaitLock spinWaitLock) { }
        public struct SpinWaitLockCookie : System.IDisposable
        {
            public SpinWaitLockCookie(JetBrains.Util.Concurrency.SpinWaitLock spinWaitLock) { }
            public void Dispose() { }
        }
    }
    public class SpinWaitLockRef
    {
        public void Enter() { }
        public void Exit() { }
        public JetBrains.Util.Concurrency.SpinWaitLockRef.SpinWaitLockRefDispose Push() { }
        public struct SpinWaitLockRefDispose : System.IDisposable
        {
            public SpinWaitLockRefDispose(JetBrains.Util.Concurrency.SpinWaitLockRef owner) { }
            public void Dispose() { }
        }
    }
    public class static SyncExtensions
    {
        public static JetBrains.Util.Concurrency.SyncExtensions.SyncCookie Using(this JetBrains.Util.Concurrency.ISync sync) { }
        public struct SyncCookie : System.IDisposable
        {
            public SyncCookie(JetBrains.Util.Concurrency.ISync sync) { }
            public void Dispose() { }
        }
    }
    public class UnguardedCallbackMerger
    {
        public readonly JetBrains.Threading.ReentrancyGuard ReentrancyGuard;
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public UnguardedCallbackMerger([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.ReentrancyGuard guard, JetBrains.Util.Concurrency.UnguardedCallbackMerger.BehaviorFlags flags) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Invariant)]
        public bool IsExpectingUnguardedCallback { get; }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Special)]
        [System.ObsoleteAttribute("Use overload with lifetime.")]
        public void ExecuteOrQueueOrMerge([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Special)]
        public bool ExecuteOrQueueOrMerge(JetBrains.DataFlow.Lifetime lifetimeQueue, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, [JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public void ExpectUnguardedCallback([JetBrains.Annotations.NotNullAttribute()] System.Action FNested) { }
        [System.FlagsAttribute()]
        public enum BehaviorFlags
        {
            ExecutePendingLeftovers = 0,
            DropPendingLeftovers = 1,
            ProhibitNestedExpectations = 0,
            AllowNestedExpectations = 2,
        }
    }
}
namespace JetBrains.Util.Console
{
    
    [System.FlagsAttribute()]
    public enum ConsoleColor : short
    {
        Black = 0,
        Blue = 1,
        Green = 2,
        Cyan = 3,
        Red = 4,
        Violet = 5,
        Yellow = 6,
        White = 7,
        Intensified = 8,
        Normal = 7,
        BlackBG = 0,
        BlueBG = 16,
        GreenBG = 32,
        CyanBG = 48,
        RedBG = 64,
        VioletBG = 80,
        YellowBG = 96,
        WhiteBG = 112,
        IntensifiedBG = 128,
        Underline = 16384,
        ReverseVideo = -32768,
    }
    public enum ConsoleFlashMode
    {
        NoFlashing = 0,
        FlashOnce = 1,
        FlashUntilResponse = 2,
    }
    public class ConsoleWriter : System.IO.TextWriter
    {
        public ConsoleWriter(System.IO.TextWriter writer, JetBrains.Util.Console.ConsoleColor color, JetBrains.Util.Console.ConsoleFlashMode mode, bool beep) { }
        public bool BeepOnWrite { get; set; }
        public JetBrains.Util.Console.ConsoleColor Color { get; set; }
        public override System.Text.Encoding Encoding { get; }
        public JetBrains.Util.Console.ConsoleFlashMode FlashMode { get; set; }
        protected void Flash() { }
        public override void Write(char value) { }
        public override void Write(string value) { }
        public override void Write(char[] buffer, int index, int count) { }
    }
    public struct Coord
    {
        public short X;
        public short Y;
    }
    public sealed class MyConsole
    {
        public static System.IntPtr Buffer { get; }
        public static JetBrains.Util.Console.Coord BufferSize { get; }
        public static JetBrains.Util.Console.ConsoleColor Color { get; set; }
        public static bool CtrlBreakPressed { get; }
        public static JetBrains.Util.Console.Coord CursorPosition { get; set; }
        public static System.IO.TextWriter Error { get; }
        public static System.IntPtr Handle { get; }
        public static System.IO.TextReader In { get; }
        public static JetBrains.Util.Console.Coord MaximumScreenSize { get; }
        public static System.IO.TextWriter Out { get; }
        public static System.IntPtr ParentHandle { get; set; }
        public static JetBrains.Util.Console.MyConsole.SmallRect ScreenSize { get; }
        public static string Title { get; set; }
        public static bool Visible { get; set; }
        public event JetBrains.Util.Console.MyConsole.HandlerRoutine Break;
        public static void Beep() { }
        public static void Clear() { }
        public static void Flash(bool once) { }
        public void GetWindowPosition(out int x, out int y, out int width, out int height) { }
        public static void Initialize() { }
        public static int LaunchNotepadDialog(string arguments) { }
        public static System.IO.Stream OpenStandardError() { }
        public static System.IO.Stream OpenStandardError(int bufferSize) { }
        public static System.IO.Stream OpenStandardInput() { }
        public static System.IO.Stream OpenStandardInput(int bufferSize) { }
        public static System.IO.Stream OpenStandardOutput() { }
        public static System.IO.Stream OpenStandardOutput(int bufferSize) { }
        public static int Read() { }
        public static string ReadLine() { }
        public void RedirectDebugOutput(bool clear, JetBrains.Util.Console.ConsoleColor color, bool beep) { }
        public void RedirectTraceOutput(bool clear, JetBrains.Util.Console.ConsoleColor color) { }
        public static void SetError(System.IO.TextWriter newError) { }
        public static void SetIn(System.IO.TextReader newIn) { }
        public static void SetOut(System.IO.TextWriter newOut) { }
        public void SetWindowPosition(int x, int y, int width, int height) { }
        public static void Write(string format, object arg0) { }
        public static void Write(string format, object arg0, object arg1) { }
        public static void Write(string format, object arg0, object arg1, object arg2) { }
        public static void Write(string format, params object[] arg) { }
        public static void Write(bool value) { }
        public static void Write(char value) { }
        public static void Write(char[] buffer) { }
        public static void Write(char[] buffer, int index, int count) { }
        public static void Write(double value) { }
        public static void Write(decimal value) { }
        public static void Write(float value) { }
        public static void Write(int value) { }
        public static void Write(uint value) { }
        public static void Write(long value) { }
        public static void Write(ulong value) { }
        public static void Write(object value) { }
        public static void Write(string value) { }
        public static void WriteLine() { }
        public static void WriteLine(bool value) { }
        public static void WriteLine(char value) { }
        public static void WriteLine(char[] buffer) { }
        public static void WriteLine(char[] buffer, int index, int count) { }
        public static void WriteLine(decimal value) { }
        public static void WriteLine(double value) { }
        public static void WriteLine(float value) { }
        public static void WriteLine(int value) { }
        public static void WriteLine(uint value) { }
        public static void WriteLine(long value) { }
        public static void WriteLine(ulong value) { }
        public static void WriteLine(object value) { }
        public static void WriteLine(string value) { }
        public static void WriteLine(string format, object arg0) { }
        public static void WriteLine(string format, object arg0, object arg1) { }
        public static void WriteLine(string format, object arg0, object arg1, object arg2) { }
        public static void WriteLine(string format, params object[] arg) { }
        public struct ConsoleSelectionInfo
        {
            public int Flags;
            public JetBrains.Util.Console.MyConsole.SmallRect Selection;
            public JetBrains.Util.Console.Coord SelectionAnchor;
        }
        public delegate bool HandlerRoutine(int type);
        public struct SmallRect
        {
            public short Bottom;
            public short Left;
            public short Right;
            public short Top;
        }
    }
}
namespace JetBrains.Util.dataStructures
{
    
    public enum Bit
    {
        Zero = 0,
        One = 1,
    }
    public class static Boxed
    {
        public static int Compare<T>(JetBrains.Util.dataStructures.Boxed<T> n1, JetBrains.Util.dataStructures.Boxed<T> n2)
            where T :  struct { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public static bool Equals<T>(JetBrains.Util.dataStructures.Boxed<T> n1, JetBrains.Util.dataStructures.Boxed<T> n2)
            where T :  struct { }
        public static System.Type TryGetUnderlyingType([JetBrains.Annotations.NotNullAttribute()] System.Type boxedtype) { }
    }
    public class Boxed<T> : System.IEquatable<JetBrains.Util.dataStructures.Boxed<T>>
    
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T Value;
        public Boxed(T value) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Util.dataStructures.Boxed<T> other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public struct ByteBuffer
    {
        public System.Byte* Data;
        public int Length;
    }
    public class static ByteBufferEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static byte[] ToArray(this JetBrains.Util.dataStructures.ByteBuffer buffer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IO.UnmanagedMemoryStream ToStream(this JetBrains.Util.dataStructures.ByteBuffer buffer) { }
    }
    public enum CapacityPolicy
    {
        ExactFit = 0,
        FibGrow = 1,
    }
    public class ChunkedMemoryStream : System.IO.Stream
    {
        public static readonly int DefaultChunkSize;
        public ChunkedMemoryStream() { }
        public ChunkedMemoryStream([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<byte[]> buffers) { }
        public ChunkedMemoryStream([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<byte[]> buffers, long offset, long count) { }
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        public override void Flush() { }
        public System.Collections.Generic.IEnumerable<byte[]> GetBuffers() { }
        public override int Read([JetBrains.Annotations.NotNullAttribute()] byte[] buffer, int offset, int count) { }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { }
        public override void SetLength(long value) { }
        public void TrimExcess() { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public struct CompactionPolicy
    {
        public static readonly JetBrains.Util.dataStructures.CompactionPolicy DefaultExactFit;
        public static readonly JetBrains.Util.dataStructures.CompactionPolicy DefaultFibGrow;
        public CompactionPolicy(JetBrains.Util.dataStructures.CompactionPolicyEnum flags, int freeCount) { }
        public CompactionPolicy(JetBrains.Util.dataStructures.CompactionPolicyEnum flags, float freeToAllSizeRatio) { }
        public bool CompactToExactSizeOnManualCompact { get; }
        public JetBrains.Util.dataStructures.CompactionPolicyEnum Flags { get; }
        public int FreeCount { get; }
        public float FreeToAllSizeRatio { get; }
    }
    [System.FlagsAttribute()]
    public enum CompactionPolicyEnum
    {
        Manual = 0,
        Auto = 1,
        CompactWhenEmptyToAllRatioTooHigh = 2,
        CompactWhenFreeCountTooHigh = 4,
        CompactLastChunkOnManualCompact = 8,
        CompactToExactFitOnManualCompact = 16,
    }
    public class ConciseBitArray : JetBrains.Util.SafeDisposable, System.Collections.Generic.ICollection<int>, System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable
    {
        public const int DefaultCapacity = 512;
        public const int DefaultCompactifyThreshold = 16;
        public int Capacity { get; }
        public int CompactifyThreshold { get; set; }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public System.Int32* Ptr { get; }
        public void Add(int item) { }
        public System.Collections.Generic.IEnumerable<int> AsZeroEnumerable() { }
        public int Cardinality() { }
        public void Clear() { }
        public int Compactify(bool reduceCapacity = False) { }
        public bool Contains(int item) { }
        public void CopyTo(int[] array, int arrayIndex) { }
        public static JetBrains.Util.dataStructures.ConciseBitArray CreateEmpty(int initialCapacity = 512) { }
        public static JetBrains.Util.dataStructures.ConciseBitArray CreateFromExisting(int capacity, System.Int32* array) { }
        protected override void DisposeUnmanagedResources() { }
        public bool Get(int i) { }
        public bool GetAndSet(int i) { }
        public bool GetAndSet(int i, JetBrains.Util.dataStructures.Bit bit) { }
        public bool GetAndUnset(int i) { }
        public System.Collections.Generic.IEnumerator<int> GetEnumerator() { }
        public int NumberOfChunks() { }
        public bool Remove(int item) { }
        public void Set(int i) { }
        public void Set(int i, JetBrains.Util.dataStructures.Bit bit) { }
        public void Unset(int i) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public class ConcurrentDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    
    
    {
        public ConcurrentDictionary() { }
        public ConcurrentDictionary(int concurrencyLevel, int capacity) { }
        public ConcurrentDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> collection) { }
        public ConcurrentDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public ConcurrentDictionary(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> collection, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public ConcurrentDictionary(int concurrencyLevel, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> collection, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public ConcurrentDictionary(int concurrencyLevel, int capacity, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>> collection, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public ConcurrentDictionary(int concurrencyLevel, int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public int Count { get; }
        public bool IsEmpty { get; }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public TValue AddOrUpdate(TKey key, System.Func<TKey, TValue> addValueFactory, System.Func<TKey, TValue, TValue> updateValueFactory) { }
        public TValue AddOrUpdate(TKey key, TValue addValue, System.Func<TKey, TValue, TValue> updateValueFactory) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        public TValue GetOrAdd(TKey key, System.Func<TKey, TValue> valueFactory) { }
        public TValue GetOrAdd(TKey key, TValue value) { }
        public System.Collections.Generic.KeyValuePair<, >[] ToArray() { }
        public bool TryAdd(TKey key, TValue value) { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public bool TryRemove(TKey key, out TValue value) { }
        public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue) { }
    }
    public class static FibFinder
    {
        public static readonly int[] FibSeq;
        public static int NextFib(int x) { }
        public static int NextFibIndex(int x) { }
    }
    public class static FinalizerManager
    {
        public static readonly JetBrains.Util.Statistics Statistics;
    }
    public struct FrugalLocalList<TItem> : System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.Generic.IList<TItem>, System.Collections.IEnumerable
    
    {
        public const int LocalItemsCount = 2;
        [get: JetBrains.Annotations.PureAttribute()]
        public int Count { get; }
        [get: JetBrains.Annotations.PureAttribute()]
        public bool IsReadOnly { get; }
        [get: JetBrains.Annotations.PureAttribute()]
        public TItem this[int index] { get; set; }
        public void Add(TItem item) { }
        public void Clear() { }
        public JetBrains.Util.dataStructures.FrugalLocalList<TItem> Clone() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains(TItem item) { }
        [JetBrains.Annotations.PureAttribute()]
        public void CopyTo(TItem[] array, int arrayIndex) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.dataStructures.FrugalLocalList<TItem>.FrugalLocalListEnumerator GetEnumerator() { }
        [JetBrains.Annotations.PureAttribute()]
        public int IndexOf([JetBrains.Annotations.NotNullAttribute()] TItem item) { }
        public void Insert(int index, TItem item) { }
        [JetBrains.Annotations.PureAttribute()]
        public int LastIndexOf([JetBrains.Annotations.NotNullAttribute()] TItem item) { }
        [JetBrains.Annotations.PureAttribute()]
        public int LastIndexOf([JetBrains.Annotations.NotNullAttribute()] TItem item, System.Collections.Generic.IEqualityComparer<TItem> comparer) { }
        public bool Remove(TItem item) { }
        public void RemoveAt(int index) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TItem[] ToArray() { }
        public struct FrugalLocalListEnumerator<TItem> : System.Collections.Generic.IEnumerator<TItem>, System.Collections.IEnumerator, System.IDisposable
        
        {
            public TItem Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
    }
    public class IntSet : System.Collections.Generic.ICollection<int>, System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable
    {
        public const int DefaultMarker = 0;
        public static JetBrains.Util.dataStructures.IntSet Empty;
        public IntSet(int expectedNumberOfElements = 10, int marker = 0, bool treatMarkerAsSetElement = True) { }
        public int Capacity { get; }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(int item) { }
        public void Clear() { }
        public bool Contains(int item) { }
        public void CopyTo(int[] array, int arrayIndex) { }
        public JetBrains.Util.dataStructures.IntSet.IntSetEnumerator GetEnumerator() { }
        public bool Remove(int item) { }
        public struct IntSetEnumerator : System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
        {
            public int Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
            public void Reset() { }
        }
    }
    public class static IntSetExtensions
    {
        public static bool ContainsAll([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.dataStructures.IntSet intSet, int[] values) { }
    }
    public struct MultimapValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
    
    
    {
        public static readonly JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue> EmptyInstance;
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(TValue item) { }
        public void Clear() { }
        public bool Contains(TValue item) { }
        public void CopyTo(TValue[] array, int arrayIndex) { }
        public JetBrains.Util.dataStructures.MultimapValueCollectionEnumerator<TValue> GetEnumerator() { }
        public bool Remove(TValue item) { }
    }
    public struct MultimapValueCollectionEnumerator<TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
    
    {
        public TValue Current { get; }
        public void Dispose() { }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public class OneToListMultimap<TKey, TValue> : JetBrains.Util.IOneToManyMap<TKey, TValue, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>>>, System.Collections.Generic.IDictionary<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>>>, System.Collections.IEnumerable
    
    
    {
        public const int DefaultKeysCapacity = 10;
        public OneToListMultimap(int keyCapacity = 0, System.Collections.Generic.IEqualityComparer<TKey> keyComparer = null, System.Collections.Generic.IEqualityComparer<TValue> valueComparer = null, JetBrains.Util.dataStructures.CapacityPolicy capacityPolicy = 1) { }
        public System.Collections.Generic.IEnumerable<TValue> AllValuesLazy { get; }
        public JetBrains.Util.dataStructures.CompactionPolicy CompactionPolicy { get; set; }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue> this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.IEnumerable<TKey> KeysLazy { get; }
        public System.Collections.Generic.ICollection<JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>> Values { get; }
        public void Add(TKey key, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue> value) { }
        public void Add(TKey key, TValue value) { }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>> item) { }
        public void AddValue(TKey key, TValue value) { }
        public void AddValueRange(TKey key, System.Collections.Generic.IEnumerable<TValue> valuesEnumerable) { }
        public void Clear() { }
        public int Compact() { }
        public int CompactConditionally() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>> item) { }
        public bool ContainsKey(TKey key) { }
        public void CopyTo(System.Collections.Generic.KeyValuePair<, >[] array, int arrayIndex) { }
        public string DebugPrintOrdered() { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>>> GetEnumerator() { }
        public JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue> GetValuesSafe(TKey key) { }
        public bool Remove(TKey key) { }
        public bool Remove(TKey key, TValue value) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.dataStructures.MultimapValueCollection<TKey, TValue>> item) { }
        public bool RemoveValue(TKey key, TValue value) { }
        public int RemoveValueRange(TKey key, System.Collections.Generic.IEnumerable<TValue> valuesEnumerable) { }
        public void SetValueRange(TKey key, System.Collections.Generic.IEnumerable<TValue> valuesEnumerable) { }
        public int StatEmptyCount() { }
        public int StatValueStorageUsed() { }
        public bool TryGetValue(TKey key, out JetBrains.Util.dataStructures.MultimapValueCollection<, > value) { }
    }
    public class static OneToManyEquivalenceComparerEx
    {
        public static bool IsEquivalentTo<TKey, TValue>(this JetBrains.Util.dataStructures.OneToListMultimap<TKey, TValue> x, JetBrains.Util.dataStructures.OneToListMultimap<TKey, TValue> y) { }
    }
    public struct RawCircularBufferHeader
    {
        public JetBrains.Util.dataStructures.RawCircularBufferHeader.UsedBlock BlockHead;
        public JetBrains.Util.dataStructures.RawCircularBufferHeader.UsedBlock BlockTail;
        public static readonly int BufferHeaderSize;
        public readonly int TotalSize;
        public RawCircularBufferHeader(int nTotalSize) { }
        public int FreeSpace { get; }
        public int MaxDataSize { get; }
        public void AssertValid() { }
        public static bool IsEmpty(JetBrains.Util.dataStructures.RawCircularBufferHeader* pBufferHeader) { }
        public static bool TryReadMessage([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.dataStructures.RawCircularBufferHeader* pBufferHeader, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Util.dataStructures.ByteBuffer> FWithBuffer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static byte[] TryReadMessage([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.dataStructures.RawCircularBufferHeader* pBufferHeader) { }
        public static bool TryWriteMessage([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.dataStructures.RawCircularBufferHeader* pBufferHeader, [JetBrains.Annotations.NotNullAttribute()] byte[] data) { }
        public struct MessageHeader
        {
            public uint Magic;
            public static readonly uint MagicValue;
            public static readonly int MessageHeaderSize;
            public int PayloadLength;
        }
        public struct UsedBlock
        {
            public int Length;
            public int Start;
            public bool IsDefined { get; }
            public void AssertValid(int nTotalSize, string sBlockName) { }
        }
    }
    public struct SafeUnmanagedMemory : System.IDisposable
    {
        public System.IntPtr Ptr { get; }
        public System.Byte* RawPtr { get; }
        public static JetBrains.Util.dataStructures.SafeUnmanagedMemory Alloc(int size) { }
        public void Dispose() { }
    }
    public class SimpleTrie<TKey, TValue>
    
    
    {
        public SimpleTrie() { }
        public bool IsEmpty { get; }
        public bool Remove(System.Collections.Generic.IList<TKey> keys) { }
        public void RemoveAllKeyPrefixes([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<TKey> keys) { }
        public void SetValue(System.Collections.Generic.IList<TKey> keys, TValue value) { }
        public bool TryGetValue(System.Collections.Generic.IList<TKey> keys, out TValue value) { }
    }
    public struct StringConcat : JetBrains.Text.IBuffer
    {
        public StringConcat([JetBrains.Annotations.NotNullAttribute()] params string[] parts) { }
        public char this[int index] { get; }
        public int Length { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string[] Parts { get; }
        public void AppendTextTo(System.Text.StringBuilder builder, JetBrains.Util.TextRange range) { }
        public void CopyTo(int sourceIndex, char[] destinationArray, int destinationIndex, int length) { }
        public bool EqualTo(string s) { }
        public string GetText() { }
        public string GetText(JetBrains.Util.TextRange range) { }
        public string GetText(int startOffset, int len) { }
        public bool StartsWith(string s) { }
        public override string ToString() { }
    }
}
namespace JetBrains.Util.DataStructures
{
    
    public struct ChunkArray<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public ChunkArray(int length, int chunkLength) { }
        public ChunkArray(int length) { }
        public ChunkArray(JetBrains.Util.DataStructures.ChunkArray<T> source) { }
        public T this[int index] { get; set; }
        public int Length { get; }
        public void Clear() { }
        public void Fill(T item) { }
        public JetBrains.Util.DataStructures.ChunkArray<T>.Enumerator GetEnumerator() { }
        public JetBrains.Util.DataStructures.ChunkArray<T>.Location GetLocation(int index) { }
        public void Resize(int newLength) { }
        public struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        
        {
            public int Index;
            public Enumerator(T[][] chunks) { }
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
            public void Reset() { }
        }
        public struct Location<T>
        
        {
            public readonly T[] Array;
            public readonly int Offset;
            public Location(T[] array, int offset) { }
            public T Value { get; }
        }
    }
    public class ChunkHashMap<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        public ChunkHashMap() { }
        public ChunkHashMap(System.Collections.Generic.IDictionary<TKey, TValue> dictionary) { }
        public ChunkHashMap(System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public ChunkHashMap(int capacity) { }
        public ChunkHashMap(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public ChunkHashMap(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer) { }
        public System.Collections.Generic.IEqualityComparer<TKey> Comparer { get; }
        public int Count { get; }
        public TValue this[TKey key] { get; set; }
        public JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue>.KeyCollection Keys { get; }
        public JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue>.ValueCollection Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public void Compact() { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsValue(TValue value) { }
        public JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue>.Enumerator GetEnumerator() { }
        public bool IsEmpty() { }
        public bool Remove(TKey key) { }
        public bool TryGetValue(TKey key, out TValue value) { }
        public struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
        
        
        {
            public System.Collections.Generic.KeyValuePair<TKey, TValue> Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
        public sealed class KeyCollection<TKey, TValue> : System.Collections.Generic.ICollection<TKey>, System.Collections.Generic.IEnumerable<TKey>, System.Collections.IEnumerable
        
        
        {
            public KeyCollection(JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue> dictionary) { }
            public int Count { get; }
            public void CopyTo(TKey[] array, int arrayIndex) { }
            public JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue>.KeyCollection.Enumerator GetEnumerator() { }
            public struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TKey>, System.Collections.IEnumerator, System.IDisposable
            
            
            {
                public TKey Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
        public sealed class ValueCollection<TKey, TValue> : System.Collections.Generic.ICollection<TValue>, System.Collections.Generic.IEnumerable<TValue>, System.Collections.IEnumerable
        
        
        {
            public ValueCollection(JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue> dictionary) { }
            public int Count { get; }
            public void CopyTo(TValue[] array, int arrayIndex) { }
            public JetBrains.Util.DataStructures.ChunkHashMap<TKey, TValue>.ValueCollection.Enumerator GetEnumerator() { }
            public struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            
            
            {
                public TValue Current { get; }
                public void Dispose() { }
                public bool MoveNext() { }
            }
        }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(JetBrains.Util.DataStructures.HashSetDebugView<>))]
    public class ChunkHashSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public ChunkHashSet() { }
        public ChunkHashSet([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> enumerable) { }
        public ChunkHashSet([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public ChunkHashSet(int capacity) { }
        public ChunkHashSet([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> enumerable, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public ChunkHashSet([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<T> collection, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public ChunkHashSet(int capacity, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<T> comparer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEqualityComparer<T> Comparer { get; }
        public int Count { get; }
        public bool Add([JetBrains.Annotations.CanBeNullAttribute()] T element) { }
        public void Clear() { }
        public void Compact() { }
        public bool Contains([JetBrains.Annotations.CanBeNullAttribute()] T element) { }
        public void CopyTo([JetBrains.Annotations.NotNullAttribute()] T[] array) { }
        public void CopyTo([JetBrains.Annotations.NotNullAttribute()] T[] array, int arrayIndex) { }
        public void CopyTo([JetBrains.Annotations.NotNullAttribute()] T[] array, int arrayIndex, int count) { }
        public void ExceptWith([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public JetBrains.Util.DataStructures.ChunkHashSet<T>.ElementEnumerator GetEnumerator() { }
        public T GetValue([JetBrains.Annotations.CanBeNullAttribute()] T key) { }
        public T Intern([JetBrains.Annotations.CanBeNullAttribute()] T key, System.Func<T, T> elementFactory = null) { }
        public void IntersectWith([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsSubsetOf([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsSupersetOf([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsSupersetOf([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<T> other) { }
        public bool IsSupersetOf([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.DataStructures.ChunkHashSet<T> other) { }
        public bool Overlaps([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public bool Remove([JetBrains.Annotations.CanBeNullAttribute()] T element) { }
        public int RemoveWhere([JetBrains.Annotations.NotNullAttribute()] System.Func<T, bool> predicate) { }
        public bool SetEquals([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public bool SetEquals([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.DataStructures.ChunkHashSet<T> other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public T[] ToArray() { }
        public bool TryGetValue([JetBrains.Annotations.CanBeNullAttribute()] T key, out T value) { }
        public void UnionWith([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<T> other) { }
        public struct ElementEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
        }
    }
    public class ChunkList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    
    {
        public const int InitialCapacity = 10;
        public ChunkList() { }
        public ChunkList(System.Collections.Generic.IEnumerable<T> items) { }
        public ChunkList(int initialSize) { }
        public int Capacity { get; }
        public virtual int ChunkSize { get; }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public T this[int index] { get; set; }
        public int Add(T item) { }
        public int BinarySearch(System.Func<T, int> comparer) { }
        public void Clear() { }
        public void Compact() { }
        public bool Contains(T item) { }
        public void CopyTo(int srcIndex, T[] dst, int dstIndex, int length) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public JetBrains.Util.DataStructures.ChunkList<T>.Enumerator GetEnumerator() { }
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { }
        public void RemoveAt(int index) { }
        public void RemoveRange(System.Collections.Generic.ICollection<T> toRemove) { }
        public void RemoveRange(int index, int count) { }
        public void Sort(System.Func<T, T, int> comparer) { }
        public struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        
        {
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
            public void Reset() { }
        }
    }
    public class ChunkPackedIntArray
    {
        public ChunkPackedIntArray(int length, int valueBits) { }
        public uint[] this[int index] { get; set; }
        public int Length { get; }
        public int ValueBits { get; }
        public int ValueInts { get; }
        public void Clear() { }
        public uint GetItem(int index, int iSubIndex) { }
        public static JetBrains.Util.DataStructures.ChunkPackedIntArray IncreaseValueBits(JetBrains.Util.DataStructures.ChunkPackedIntArray oldArray, int newValueBits) { }
    }
    public class ChunkSparseArray<T>
    
    {
        public ChunkSparseArray(int initialSize) { }
        public T this[int index] { get; set; }
    }
    public class CollectionReadOnlyException : System.NotSupportedException
    {
        public CollectionReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CollectionReadOnlyException(string message, System.Exception innerException) { }
        public CollectionReadOnlyException(string message) { }
        public CollectionReadOnlyException() { }
    }
    public class CompactIntToIntMap : JetBrains.Util.DataStructures.CompactMapBase<int, int, JetBrains.Util.DataStructures.CompactIntToIntMapStorage, object>
    {
        public CompactIntToIntMap() { }
        public CompactIntToIntMap(int intialSlotCount, double maxLoadFactor) { }
        protected override void ClearStorage(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage) { }
        protected override JetBrains.Util.DataStructures.CompactIntToIntMapStorage CreateStorage(int slotCount) { }
        protected override object GetSlotData(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage, int index) { }
        protected override JetBrains.Util.DataStructures.CompactMapBase<int, int, JetBrains.Util.DataStructures.CompactIntToIntMapStorage, object>.SlotState GetSlotState(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage, int index, out int key) { }
        protected override int GetValue(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage, int index, object data) { }
        protected override void RemoveValue(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage, int index) { }
        protected override void SetKeyAndValue(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage, int index, int key, int value) { }
        protected override void SetValue(JetBrains.Util.DataStructures.CompactIntToIntMapStorage storage, int index, int value) { }
    }
    public struct CompactIntToIntMapStorage
    {
        public readonly JetBrains.Util.DataStructures.ChunkList<int> Keys;
        public readonly JetBrains.Util.DataStructures.ChunkList<int> SlotStates;
        public readonly JetBrains.Util.DataStructures.ChunkList<int> Values;
        public CompactIntToIntMapStorage(int length) { }
        public int GetSlotState(int index) { }
        public void SetSlotState(int index, int state) { }
    }
    public class CompactMap<TKey, TValue> : JetBrains.Util.DataStructures.CompactMapBase<TKey, TValue, JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue>, object>
    
    
    {
        public CompactMap() { }
        public CompactMap(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        public CompactMap(int initialSlotCount) { }
        public CompactMap(int initialSlotCount, System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        public CompactMap(int intialSlotCount, double maxLoadFactor, System.Collections.Generic.IEqualityComparer<TKey> equalityComparer) { }
        protected override void ClearStorage(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage) { }
        protected override JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> CreateStorage(int slotCount) { }
        protected override object GetSlotData(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage, int index) { }
        protected override JetBrains.Util.DataStructures.CompactMapBase<TKey, TValue, JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue>, object>.SlotState GetSlotState(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage, int index, out TKey key) { }
        protected override TValue GetValue(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage, int index, object data) { }
        protected override void RemoveValue(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage, int index) { }
        protected override void SetKeyAndValue(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage, int index, TKey key, TValue value) { }
        protected override void SetValue(JetBrains.Util.DataStructures.CompactMapStorage<TKey, TValue> storage, int index, TValue value) { }
    }
    public abstract class CompactMapBase<TKey, TValue, TStorage, TData> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    
    
    {
        public const int CLEAR_STORAGE_THRESHOLD = 20;
        public const int DEFAULT_INITIAL_SLOT_COUNT = 4;
        public const double DEFAULT_MAX_LOAD_FACTOR = 0.7D;
        protected CompactMapBase(int intialSlotCount, double maxLoadFactor, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEqualityComparer<TKey> equalityComparer, bool shouldValidateKey) { }
        public int Count { get; }
        public System.Collections.Generic.IEqualityComparer<TKey> EqualityComparer { get; }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public double MaxLoadFactor { get; }
        public int SlotCount { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        protected abstract void ClearStorage(TStorage storage);
        public void Compact() { }
        public bool ContainsKey(TKey key) { }
        protected abstract TStorage CreateStorage(int slotCount);
        protected virtual void DoValidateKey(TKey key) { }
        public void DumpStatistics() { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        protected abstract TData GetSlotData(TStorage storage, int index);
        protected abstract JetBrains.Util.DataStructures.CompactMapBase<TKey, TValue, TStorage, TData>.SlotState GetSlotState(TStorage storage, int index, out TKey key);
        protected abstract TValue GetValue(TStorage storage, int index, TData data);
        protected void InitStorage() { }
        public bool Remove(TKey key) { }
        protected abstract void RemoveValue(TStorage storage, int index);
        protected abstract void SetKeyAndValue(TStorage storage, int index, TKey key, TValue value);
        protected abstract void SetValue(TStorage storage, int index, TValue value);
        public bool TryGetValue(TKey key, out TValue value) { }
        protected enum SlotState<TKey, TValue, TStorage, TData>
        
        
        
        
        {
            FREE = 0,
            OCCUPIED = 1,
            REMOVED = 2,
        }
    }
    public struct CompactMapStorage<TKey, TValue>
    
    
    {
        public readonly JetBrains.Util.DataStructures.ChunkList<TKey> Keys;
        public readonly JetBrains.Util.DataStructures.ChunkList<int> SlotStates;
        public readonly JetBrains.Util.DataStructures.ChunkList<TValue> Values;
        public CompactMapStorage(int length) { }
        public int GetSlotState(int index) { }
        public void SetSlotState(int index, int state) { }
    }
    public class CompactOneToListMap<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>>, System.Collections.IEnumerable
    
    
    {
        public CompactOneToListMap(System.Collections.Generic.IEqualityComparer<TKey> equalityComparer = null) { }
        public CompactOneToListMap(int capacity, System.Collections.Generic.IEqualityComparer<TKey> equalityComparer = null) { }
        public System.Collections.Generic.IList<TValue> AllValues { get; }
        public int Count { get; }
        public System.Collections.Generic.IList<TValue> this[TKey key] { get; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public void AddValue(TKey key, TValue value) { }
        public void AddValueRange(TKey key, [JetBrains.Annotations.InstantHandleAttribute()] System.Collections.Generic.IEnumerable<TValue> values) { }
        public void Clear() { }
        public void Compact() { }
        public bool ContainsKey(TKey key) { }
        public bool ContainsPair(TKey key, TValue value) { }
        public bool ContainsValue(TValue value) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> GetEnumerator() { }
        public System.Collections.Generic.IList<TValue> GetValuesSafe(TKey key) { }
        public void RemoveKey(TKey key) { }
        public void RemoveValue(TKey key, TValue value) { }
        public void RemoveValues(TKey key, System.Collections.Generic.ICollection<TValue> valuesToRemove) { }
        public void ReplaceValue(TKey key, TValue oldValue, TValue newValue) { }
    }
    public class CompactOneToSetMap<TKey, TValue> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.DataStructures.CompactSet<TValue>>>, System.Collections.IEnumerable
    
    
    {
        public CompactOneToSetMap(int count = 4, System.Collections.Generic.IEqualityComparer<TKey> comparer = null) { }
        public System.Collections.Generic.IList<TValue> AllValues { get; }
        public int Count { get; }
        public JetBrains.Util.DataStructures.CompactSet<TValue> this[TKey key] { get; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public void Add(TKey key, TValue value) { }
        public void Clear() { }
        public bool ContainsKey(TKey key) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, JetBrains.Util.DataStructures.CompactSet<TValue>>> GetEnumerator() { }
        public JetBrains.Util.DataStructures.CompactSet<TValue> GetValuesSafe(TKey key) { }
        public void Remove(TKey key, TValue value) { }
        public void RemoveKey(TKey key) { }
    }
    public class CompactSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public static readonly JetBrains.Util.DataStructures.CompactSet<T> Empty;
        public CompactSet() { }
        public CompactSet(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public CompactSet(int intialSlotCount, double maxLoadFactor, System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public int Count { get; }
        public System.Collections.Generic.IEqualityComparer<T> EqualityComparer { get; }
        public bool IsReadOnly { get; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public bool Remove(T item) { }
    }
    public class ConvertedCollection<T1, T2> : JetBrains.Util.DataStructures.ConvertedEnumerable<T1, T2>, System.Collections.Generic.ICollection<T2>, System.Collections.Generic.IEnumerable<T2>, System.Collections.IEnumerable
    
    
    {
        public ConvertedCollection(System.Collections.Generic.ICollection<T1> original, System.Converter<T1, T2> converter) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(T2 item) { }
        public void Clear() { }
        public bool Contains(T2 item) { }
        public void CopyTo(T2[] array, int arrayIndex) { }
        public bool Remove(T2 item) { }
    }
    public class ConvertedEnumerable<T1, T2> : System.Collections.Generic.IEnumerable<T2>, System.Collections.IEnumerable
    
    
    {
        public ConvertedEnumerable(System.Collections.Generic.IEnumerator<T1> original, System.Converter<T1, T2> converter) { }
        public ConvertedEnumerable(System.Collections.Generic.IEnumerable<T1> original, System.Converter<T1, T2> converter) { }
        public System.Collections.Generic.IEnumerator<T2> GetEnumerator() { }
    }
    public class ConvertedEnumerator<T1, T2> : System.Collections.Generic.IEnumerator<T2>, System.Collections.IEnumerator, System.IDisposable
    
    
    {
        public ConvertedEnumerator(System.Collections.Generic.IEnumerator<T1> original, System.Converter<T1, T2> converter) { }
        public T2 Current { get; }
        public void Dispose() { }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public class DataIntern<T>
    
    {
        public DataIntern() { }
        public DataIntern(System.Collections.Generic.IEqualityComparer<T> comparer) { }
        public DataIntern(int capacity, System.Collections.Generic.IEqualityComparer<T> comparer = null) { }
        public void Clear() { }
        public void Compact() { }
        public T Intern(T data) { }
        public bool TryGet(T data, out T internedData) { }
    }
    [System.ComponentModel.ImmutableObjectAttribute(true)]
    public class EmptyEnumerator<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerable, System.Collections.IEnumerator, System.IDisposable
    
    {
        public static readonly JetBrains.Util.DataStructures.EmptyEnumerator<T> INSTANCE;
        public T Current { get; }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public class EnumeratorWithEnd<T> : JetBrains.Util.DataStructures.IEnumeratorWithEnd<T>, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    
    {
        public EnumeratorWithEnd(System.Collections.Generic.IEnumerator<T> underlyingEnumerator) { }
        public bool AtEnd { get; }
        public T Current { get; }
        public void Dispose() { }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public struct HybridCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T :  class
    {
        public static readonly JetBrains.Util.DataStructures.HybridCollection<T> Empty;
        public HybridCollection([JetBrains.Annotations.NotNullAttribute()] T item) { }
        public HybridCollection([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<T> items) { }
        public int Count { get; }
        public bool IsEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public T this[int i] { get; }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridCollection<T> Add([JetBrains.Annotations.NotNullAttribute()] T item) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridCollection<T> Add(JetBrains.Util.DataStructures.HybridCollection<T> collection) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Any() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Any([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, bool> predicate) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains([JetBrains.Annotations.NotNullAttribute()] T item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T First() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T FirstOrDefault() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T FirstOrDefault([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, bool> predicate) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridCollection<T>.Enumerator GetEnumerator() { }
        [JetBrains.Annotations.PureAttribute()]
        public int IndexOf([JetBrains.Annotations.NotNullAttribute()] T item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T Last() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T LastOrDefault() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public T LastOrDefault([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, bool> predicate) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridCollection<TCast> OfType<TCast>()
            where TCast :  class, T { }
        [JetBrains.Annotations.PureAttribute()]
        public System.Collections.Generic.IList<T> ResultingList() { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridCollection<T> Where([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, bool> predicate) { }
        public struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            where T :  class
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
            public void Reset() { }
        }
    }
    public struct HybridDistinctCollection<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T :  class
    {
        public static readonly JetBrains.Util.DataStructures.HybridDistinctCollection<T> Empty;
        public HybridDistinctCollection([JetBrains.Annotations.NotNullAttribute()] T data) { }
        public int Count { get; }
        public bool IsEmpty { get; }
        public void Add(T item) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridDistinctCollection<T> Clone() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool Contains(T item) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.DataStructures.HybridDistinctCollection<T>.Enumerator GetEnumerator() { }
        public bool Remove(T item) { }
        [JetBrains.Annotations.PureAttribute()]
        public T[] ToArray() { }
        public struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            where T :  class
        {
            public T Current { get; }
            public void Dispose() { }
            public bool MoveNext() { }
            public void Reset() { }
        }
    }
    public interface IEnumeratorWithEnd<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    
    {
        bool AtEnd { get; }
    }
    public interface ISettingsTable
    {
        bool GetBoolean(string settingName);
        bool GetBoolean(string settingName, bool defaultVal);
        int GetInteger(string settingName);
        int GetInteger(string settingName, int defaultVal);
        string GetString(string settingName);
        string GetString(string settingName, string defaultVal);
        void SetBoolean(string settingName, bool val);
        void SetInteger(string settingName, int val);
        void SetString(string settingName, string val);
    }
    public class MergedCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public MergedCollection(System.Collections.Generic.IEnumerable<System.Collections.Generic.ICollection<T>> collections) { }
        public MergedCollection(System.Collections.Generic.ICollection<T> collection1, System.Collections.Generic.ICollection<T> collection2) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public bool Remove(T item) { }
    }
    public class MergedEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public MergedEnumerable(params System.Collections.Generic.IEnumerable<>[] enumerables) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
    }
    public class MergedEnumerator : System.Collections.IEnumerator, System.IDisposable
    {
        public MergedEnumerator(params System.Collections.IEnumerator[] enumerators) { }
    }
    public class MergedEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
    
    {
        public MergedEnumerator(params System.Collections.Generic.IEnumerator<>[] enumerators) { }
        public T Current { get; }
        public bool MoveNext() { }
        public void Reset() { }
    }
    public class OneToCompactListMap<TKey, TValue> : JetBrains.Util.IOneToManyMap<TKey, TValue, System.Collections.Generic.IList<TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>>, System.Collections.IEnumerable
    
    
    {
        public OneToCompactListMap() { }
        public System.Collections.Generic.IList<TValue> this[TKey key] { get; }
        public int ValueCount { get; }
        public void Add(TKey key, TValue value) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, System.Collections.Generic.IList<TValue>>> GetEnumerator() { }
        public System.Collections.Generic.IList<TValue> GetValuesSafe(TKey key) { }
        public bool Remove(TKey key, TValue value) { }
    }
    public class OrderedDictionary<TKey, TValue> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
    
    
    {
        public OrderedDictionary() { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public TValue this[TKey key] { get; set; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public void Add(TKey key, TValue value) { }
        public void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool ContainsKey(TKey key) { }
        public void CopyTo(System.Collections.Generic.KeyValuePair<, >[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator() { }
        public void Insert(int index, TKey key, TValue value) { }
        public bool Remove(TKey key) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item) { }
        public bool TryGetValue(TKey key, out TValue value) { }
    }
    public struct PackedIntArray
    {
        public PackedIntArray(int length, int valueBits) { }
        public uint[] this[int index] { get; set; }
        public int Length { get; }
        public int ValueBits { get; }
        public int ValueInts { get; }
        public void Clear() { }
        public void CopyTo(JetBrains.Util.DataStructures.PackedIntArray array, int count) { }
        public static JetBrains.Util.DataStructures.PackedIntArray IncreaseValueBits(JetBrains.Util.DataStructures.PackedIntArray oldArray, int newValueBits) { }
    }
    public struct PackedIntArrayList
    {
        public PackedIntArrayList(int valueBits, int initialCapacity) { }
        public JetBrains.Util.DataStructures.PackedIntArrayList Add(uint value, int valueBits) { }
        public System.Collections.Generic.IList<uint> AsReadOnlyList(int valueBits) { }
        public bool Contains(uint value, int valueBits) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.PureAttribute()]
        public int GetCount(int valueBits) { }
        public override int GetHashCode() { }
        public JetBrains.Util.DataStructures.PackedIntArrayList IncreaseValueBits(int oldValueBits, int newValueBits) { }
        public bool Remove(uint value, int valueBits) { }
        public JetBrains.Util.DataStructures.PackedIntArrayList SetCapacity(int capacity, int valueBits) { }
    }
    public class PackedIntKeyMap<TValue> : JetBrains.Util.DataStructures.CompactMapBase<uint, TValue, JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue>, uint>
    
    {
        public PackedIntKeyMap(int keyBits) { }
        public PackedIntKeyMap(int keyBits, int intialSlotCount, double maxLoadFactor) { }
        protected override void ClearStorage(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage) { }
        protected override JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> CreateStorage(int slotCount) { }
        protected override void DoValidateKey(uint key) { }
        protected override uint GetSlotData(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage, int index) { }
        protected override JetBrains.Util.DataStructures.CompactMapBase<uint, TValue, JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue>, uint>.SlotState GetSlotState(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage, int index, out uint key) { }
        protected override TValue GetValue(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage, int index, uint data) { }
        protected override void RemoveValue(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage, int index) { }
        protected override void SetKeyAndValue(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage, int index, uint key, TValue value) { }
        protected override void SetValue(JetBrains.Util.DataStructures.PackedIntKeyMapStorage<TValue> storage, int index, TValue value) { }
    }
    public struct PackedIntKeyMapStorage<TValue>
    
    {
        public readonly JetBrains.Util.DataStructures.ChunkPackedIntArray PackedArray;
        public readonly TValue[] Values;
        public PackedIntKeyMapStorage(int length, int keyBits) { }
    }
    public class PackedIntSet : System.Collections.Generic.ICollection<uint>, System.Collections.Generic.IEnumerable<uint>, System.Collections.IEnumerable
    {
        public const int DEFAULT_INITIAL_SLOT_COUNT = 4;
        public const double DEFAULT_MAX_LOAD_FACTOR = 0.7D;
        public PackedIntSet(int keyBits) { }
        public PackedIntSet(int keyBits, int intialSlotCount, double maxLoadFactor) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public double MaxLoadFactor { get; }
        public int SlotCount { get; }
        public void Add(uint item) { }
        public void Clear() { }
        public void Compact() { }
        public bool Contains(uint item) { }
        public void CopyTo(uint[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<uint> GetEnumerator() { }
        public bool Remove(uint item) { }
    }
    public class PackedIntSetInternal : JetBrains.Util.DataStructures.CompactMapBase<uint, object, JetBrains.Util.DataStructures.ChunkPackedIntArray, object>
    {
        public PackedIntSetInternal(int keyBits) { }
        public PackedIntSetInternal(int keyBits, int intialSlotCount, double maxLoadFactor) { }
        protected override void ClearStorage(JetBrains.Util.DataStructures.ChunkPackedIntArray storage) { }
        protected override JetBrains.Util.DataStructures.ChunkPackedIntArray CreateStorage(int slotCount) { }
        protected override void DoValidateKey(uint key) { }
        protected override object GetSlotData(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index) { }
        protected override JetBrains.Util.DataStructures.CompactMapBase<uint, object, JetBrains.Util.DataStructures.ChunkPackedIntArray, object>.SlotState GetSlotState(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, out uint key) { }
        protected override object GetValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, object data) { }
        protected override void RemoveValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index) { }
        protected override void SetKeyAndValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, uint key, object value) { }
        protected override void SetValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, object value) { }
    }
    public class PackedIntToIntMap : JetBrains.Util.DataStructures.CompactMapBase<uint, uint[], JetBrains.Util.DataStructures.ChunkPackedIntArray, uint[]>
    {
        public PackedIntToIntMap(int keyBits, int valueBits) { }
        public PackedIntToIntMap(int keyBits, int valueBits, int intialSlotCount, double maxLoadFactor) { }
        public int ValueBits { get; }
        public int ValueInts { get; }
        protected override void ClearStorage(JetBrains.Util.DataStructures.ChunkPackedIntArray storage) { }
        protected override JetBrains.Util.DataStructures.ChunkPackedIntArray CreateStorage(int slotCount) { }
        protected override void DoValidateKey(uint key) { }
        protected override uint[] GetSlotData(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index) { }
        protected override JetBrains.Util.DataStructures.CompactMapBase<uint, uint[], JetBrains.Util.DataStructures.ChunkPackedIntArray, uint[]>.SlotState GetSlotState(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, out uint key) { }
        protected override uint[] GetValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, uint[] data) { }
        protected override void RemoveValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index) { }
        protected override void SetKeyAndValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, uint key, uint[] value) { }
        protected override void SetValue(JetBrains.Util.DataStructures.ChunkPackedIntArray storage, int index, uint[] value) { }
    }
    public class PrimeFinder
    {
        public static readonly int[] Table;
        public static int MaxPrime() { }
        public static int NextPrime(int desiredCapacity) { }
    }
    public class ProxySettingsTable : JetBrains.Util.DataStructures.SettingsTable
    {
        public ProxySettingsTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.DataStructures.ISettingsTable originalTable) { }
        protected object LockObject { get; }
        public override bool GetBoolean(string settingName) { }
        public override bool GetBoolean(string settingName, bool defaultVal) { }
        public override int GetInteger(string settingName) { }
        public override int GetInteger(string settingName, int defaultVal) { }
        public override string GetString(string settingName) { }
        public override string GetString(string settingName, string defaultVal) { }
        public override void SetBoolean(string settingName, bool val) { }
        public override void SetInteger(string settingName, int val) { }
        public override void SetString(string settingName, string val) { }
    }
    public class ReadOnlyException : System.Exception
    {
        public ReadOnlyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ReadOnlyException(string message, System.Exception innerException) { }
        public ReadOnlyException(string message) { }
        public ReadOnlyException() { }
    }
    public class RegistrySettingsTable : JetBrains.Util.DataStructures.ProxySettingsTable
    {
        public RegistrySettingsTable(Microsoft.Win32.RegistryKey registryKey, [JetBrains.Annotations.NotNullAttribute()] string rootFullKeyName, [JetBrains.Annotations.NotNullAttribute()] string environmentSuffixWithLeadingSlash, JetBrains.Util.DataStructures.ISettingsTable settings) { }
        public bool Load() { }
        public bool Save() { }
    }
    public class SettingsTable : JetBrains.Util.DataStructures.ISettingsTable
    {
        public SettingsTable() { }
        public SettingsTable(JetBrains.Util.DataStructures.SettingsTable settings) { }
        protected System.Collections.Generic.Dictionary<string, bool> Bools { get; }
        protected System.Collections.Generic.Dictionary<string, int> Ints { get; }
        protected System.Collections.Generic.Dictionary<string, string> Strings { get; }
        public virtual bool GetBoolean(string settingName) { }
        public virtual bool GetBoolean(string settingName, bool defaultVal) { }
        public virtual int GetInteger(string settingName) { }
        public virtual int GetInteger(string settingName, int defaultVal) { }
        public virtual string GetString(string settingName) { }
        public virtual string GetString(string settingName, string defaultVal) { }
        protected static T GetValue<T>(System.Collections.Generic.IDictionary<string, T> dict, string settingName) { }
        protected static T GetValue<T>(System.Collections.Generic.IDictionary<string, T> dict, string settingName, T defautValue) { }
        public virtual void SetBoolean(string settingName, bool val) { }
        public virtual void SetInteger(string settingName, int val) { }
        public virtual void SetString(string settingName, string val) { }
        protected static void SetValue<T>(System.Collections.Generic.IDictionary<string, T> dict, string settingName, T value) { }
    }
    public sealed class ToStringComparer : System.Collections.IComparer
    {
        public static readonly JetBrains.Util.DataStructures.ToStringComparer INSTANCE;
        public int Compare(object x, object y) { }
    }
    public sealed class ToStringComparer<T> : System.Collections.Generic.IComparer<T>
    
    {
        public static readonly JetBrains.Util.DataStructures.ToStringComparer<T> INSTANCE;
        public int Compare(T x, T y) { }
    }
    public struct UncheckedPackedIntArray : System.IEquatable<JetBrains.Util.DataStructures.UncheckedPackedIntArray>
    {
        public UncheckedPackedIntArray(int length, int valueBits) { }
        public UncheckedPackedIntArray(uint[] data) { }
        public uint[] Data { get; }
        public uint[] this[int index, int valueBits] { get; set; }
        public void Clear() { }
        public void CopyTo(JetBrains.Util.DataStructures.UncheckedPackedIntArray array, int count, int valueBits) { }
        public bool Equals(JetBrains.Util.DataStructures.UncheckedPackedIntArray uncheckedPackedIntArray) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.PureAttribute()]
        public int GetCapacity(int valueBits) { }
        public static int GetCapacityByLength(int length, int valueBits) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.PureAttribute()]
        public uint GetItem(int index, int valueBits, int iSubItem) { }
        public static JetBrains.Util.DataStructures.UncheckedPackedIntArray IncreaseValueBits(JetBrains.Util.DataStructures.UncheckedPackedIntArray oldArray, int length, int oldValueBits, int newValueBits) { }
        public static int ValueInts(int valueBits) { }
    }
}
namespace JetBrains.Util.dataStructures.TypedIntrinsics
{
    
    public struct Int32<TType> : System.IComparable, System.IComparable<JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType>>, System.IConvertible, System.IEquatable<JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType>>, System.IFormattable
    
    {
        public static readonly JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> I;
        public static readonly JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> MaxValue;
        public static readonly JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> MinValue;
        public static readonly JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> O;
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Abs(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> α) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> other) { }
        public override int GetHashCode() { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Limited(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> minInclusive, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> maxExclusive) { }
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Max(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> α, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> β) { }
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Min(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> α, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> β) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Minus1() { }
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Parse(string s) { }
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Parse(string s, System.Globalization.NumberStyles style) { }
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Parse(string s, System.IFormatProvider provider) { }
        public static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Parse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider) { }
        public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> Plus1() { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType>> Range(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> start, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> count) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType>> Range(JetBrains.Util.dataStructures.TypedIntrinsics.Int32<TType> count) { }
        public string ToString(string format) { }
        public string ToString(System.IFormatProvider provider) { }
        public string ToString(string format, System.IFormatProvider provider) { }
        public override string ToString() { }
        public static bool TryParse(string s, out JetBrains.Util.dataStructures.TypedIntrinsics.Int32<> result) { }
        public static bool TryParse(string s, System.Globalization.NumberStyles style, System.IFormatProvider provider, out JetBrains.Util.dataStructures.TypedIntrinsics.Int32<> result) { }
    }
}
namespace JetBrains.Util.Diff
{
    
    public class static Diff
    {
        public static System.Collections.Generic.IList<JetBrains.Util.Diff.DiffFragment> Calc(int oldLength, int newLength, JetBrains.Util.Diff.DiffComparer comparer) { }
    }
    public delegate bool DiffComparer(int x, int y);
    public struct DiffFragment
    {
        public DiffFragment(JetBrains.Util.TextRange rangeOld, JetBrains.Util.TextRange rangeNew, JetBrains.Util.Diff.DiffFragmentType fragmentType) { }
        public JetBrains.Util.TextRange RangeNew { get; }
        public JetBrains.Util.TextRange RangeOld { get; }
        public JetBrains.Util.Diff.DiffFragmentType Type { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public enum DiffFragmentType
    {
        EQUAL = 0,
        ADDED = 1,
        DELETED = 2,
        MODIFIED = 3,
    }
}
namespace JetBrains.Util.DnsAPI
{
    
    public struct AAAARecord
    {
        public JetBrains.Util.DnsAPI.IP6Address Address;
        public override string ToString() { }
    }
    public struct ARecord
    {
        public uint Address;
        public override string ToString() { }
    }
    public struct ATMARecord
    {
        public string Address;
        public byte AddressType;
        public override string ToString() { }
    }
    public class DnsException : System.ApplicationException, System.Runtime.Serialization.ISerializable
    {
        public DnsException() { }
        public DnsException(string message) { }
        public DnsException(string message, uint errcode) { }
        public DnsException(string message, System.Exception innerException) { }
        public DnsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public uint ErrorCode { get; }
    }
    public enum DnsQueryReturnCode : ulong
    {
        SUCCESS = 0ul,
        UNSPECIFIED_ERROR = 9000ul,
        MASK = 9000ul,
        FORMAT_ERROR = 9001ul,
        SERVER_FAILURE = 9002ul,
        NAME_ERROR = 9003ul,
        NOT_IMPLEMENTED = 9004ul,
        REFUSED = 9005ul,
        YXDOMAIN = 9006ul,
        YXRRSET = 9007ul,
        NXRRSET = 9008ul,
        NOTAUTH = 9009ul,
        NOTZONE = 9010ul,
        BADSIG = 9016ul,
        BADKEY = 9017ul,
        BADTIME = 9018ul,
        PACKET_FMT_BASE = 9500ul,
        NO_RECORDS = 9501ul,
        BAD_PACKET = 9502ul,
        NO_PACKET = 9503ul,
        RCODE = 9504ul,
        UNSECURE_PACKET = 9505ul,
    }
    [System.FlagsAttribute()]
    public enum DnsRecordType : ushort
    {
        A = 1,
        NS = 2,
        [System.ObsoleteAttribute()]
        MD = 3,
        [System.ObsoleteAttribute()]
        MF = 4,
        CNAME = 5,
        SOA = 6,
        MB = 7,
        MG = 8,
        MR = 9,
        NULL = 10,
        WKS = 11,
        PTR = 12,
        HINFO = 13,
        MINFO = 14,
        MX = 15,
        TEXT = 16,
        RP = 17,
        AFSDB = 18,
        X25 = 19,
        ISDN = 20,
        RT = 21,
        NSAP = 22,
        [System.ObsoleteAttribute()]
        NSAPPTR = 23,
        SIG = 24,
        KEY = 25,
        PX = 26,
        [System.ObsoleteAttribute()]
        GPOS = 27,
        AAAA = 28,
        LOC = 29,
        NXT = 30,
        SRV = 33,
        ATMA = 34,
        TKEY = 249,
        TSIG = 250,
        IXFR = 251,
        AXFR = 252,
        MAILB = 253,
        MAILA = 254,
        ALL = 255,
        ANY = 255,
        WINS = 65281,
        WINSR = 65282,
        NBSTAT = 65282,
    }
    public class DnsRequest
    {
        public DnsRequest() { }
        public DnsRequest(string domain) { }
        public bool AcceptTruncatedResponse { get; set; }
        public bool BypassCache { get; set; }
        public string Domain { get; set; }
        public bool DontResetTTLValues { get; set; }
        public bool NoHostsFile { get; set; }
        public bool NoLocalName { get; set; }
        public bool NoNetbt { get; set; }
        public bool NoRecursion { get; set; }
        public bool QueryCacheOnly { get; set; }
        public bool QueryReturnMessage { get; set; }
        public JetBrains.Util.DnsAPI.DnsServerCollection Servers { get; }
        public bool TreatAsFQDN { get; set; }
        public bool UseTCPOnly { get; set; }
        public bool WireOnly { get; set; }
        public JetBrains.Util.DnsAPI.DnsResponse GetResponse() { }
    }
    public class DnsResponse
    {
        public JetBrains.Util.DnsAPI.ARecord[] ARecords { get; }
        public JetBrains.Util.DnsAPI.MXRecord[] MXRecords { get; }
        public JetBrains.Util.DnsAPI.PTRRecord[] NSRecords { get; }
        public JetBrains.Util.DnsAPI.DnsWrapperCollection RawRecords { get; }
        public System.Collections.ArrayList GetRecords(JetBrains.Util.DnsAPI.DnsRecordType type) { }
    }
    public class DnsServerCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
    {
        public System.Net.IPAddress this[int idx] { get; }
        public void Add(string host) { }
    }
    public struct DnsWrapper : System.IComparable
    {
        public object RecordData;
        public JetBrains.Util.DnsAPI.DnsRecordType RecordType;
        public int CompareTo(object obj) { }
        public bool Equals(JetBrains.Util.DnsAPI.DnsRecordType type) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class DnsWrapperCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.IEnumerable
    {
        public JetBrains.Util.DnsAPI.DnsWrapper this[int i] { get; }
    }
    public struct IP6Address
    {
        public uint IPFrag1;
        public uint IPFrag2;
        public uint IPFrag3;
        public uint IPFrag4;
        public uint IPFrag5;
        public uint IPFrag6;
        public uint IPFrag7;
        public uint IPFrag8;
        public override string ToString() { }
    }
    public struct KEYRecord
    {
        public byte Algorithm;
        public ushort Flags;
        public byte Key;
        public byte Protocol;
        public override string ToString() { }
    }
    public struct LOCRecord
    {
        public uint Altitude;
        public ushort HorPrec;
        public uint Latitude;
        public uint Longitude;
        public ushort Size;
        public ushort VerPrec;
        public ushort Version;
    }
    public struct MINFORecord
    {
        public string ErrorsMailbox;
        public string Mailbox;
        public override string ToString() { }
    }
    public struct MXRecord
    {
        public string Exchange;
        public ushort Pad;
        public ushort Preference;
        public override string ToString() { }
    }
    public struct NULLRecord
    {
        public uint ByteCount;
        public string Data;
        public override string ToString() { }
    }
    public struct NXTRecord
    {
        public string NameNext;
        public byte TypeBitMap;
        public override string ToString() { }
    }
    public struct PTRRecord
    {
        public string HostName;
        public override string ToString() { }
    }
    public struct SIGRecord
    {
        public byte Algorithm;
        public uint Expiration;
        public ushort KeyTag;
        public byte LabelCount;
        public uint OriginalTtl;
        public ushort Pad;
        public byte Signature;
        public string Signer;
        public uint TimeSigned;
        public ushort TypeCovered;
    }
    public struct SOARecord
    {
        public string Administrator;
        public uint DefaultTtl;
        public uint Expire;
        public string PrimaryServer;
        public uint Refresh;
        public uint Retry;
        public uint SerialNo;
        public override string ToString() { }
    }
    public struct SRVRecord
    {
        public string NameNext;
        public ushort Pad;
        public ushort Port;
        public ushort Priority;
        public ushort Weight;
        public override string ToString() { }
    }
    public struct TKEYRecord
    {
        public char AlgNameLength;
        public string Algorithm;
        public System.IntPtr AlgorithmPacket;
        public uint CreateTime;
        public ushort Error;
        public uint ExpireTime;
        public System.IntPtr Key;
        public ushort KeyLength;
        public ushort Mode;
        public System.IntPtr OtherData;
        public ushort OtherLength;
        public bool PacketPointers;
    }
    public struct TSIGRecord
    {
        public char AlgNameLength;
        public string Algorithm;
        public System.IntPtr AlgorithmPacket;
        public long CreateTime;
        public ushort Error;
        public ushort FudgeTime;
        public System.IntPtr Key;
        public ushort KeyLength;
        public ushort OriginalXid;
        public System.IntPtr OtherData;
        public ushort OtherLength;
        public bool PacketPointers;
    }
    public struct TXTRecord
    {
        public string StringArray;
        public uint StringCount;
        public override string ToString() { }
    }
    public struct WINSRecord
    {
        public uint CacheTimeout;
        public uint LookupTimeout;
        public uint MappingFlag;
        public uint ServerCount;
        public System.IntPtr WinsServers;
        public override string ToString() { }
    }
    public struct WINSRRecord
    {
        public uint CacheTimeout;
        public uint LookupTimeout;
        public uint MappingFlag;
        public string ResultDomain;
        public override string ToString() { }
    }
    public struct WKSRecord
    {
        public byte BitMask;
        public uint IpAddress;
        public char Protocol;
        public override string ToString() { }
    }
}
namespace JetBrains.Util.EventBus
{
    
    public class static EventBusExtensions
    {
        public static void Fire<T>([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Util.EventBus.IEventContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.EventBus.EventId<T> eventId, T args) { }
        public static void Fire<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.EventBus.EventId<T> eventId, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.EventBus.IEventContext context, T args) { }
        public static bool IsSubEventOf([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Util.EventBus.EventId id, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.EventBus.EventId parent) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, System.Action<TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.Util.EventBus.EventId, TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.Execution.ExecutionMode executionMode, System.Action<TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.Execution.ExecutionMode executionMode, System.Action<JetBrains.Util.EventBus.EventId, TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.EventId<TEventArgs> eventId, System.Action<TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.EventId<TEventArgs> eventId, System.Action<JetBrains.Util.EventBus.EventId, TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.EventId<TEventArgs> eventId, JetBrains.Util.EventBus.Execution.ExecutionMode executionMode, System.Action<TEventArgs> action) { }
        public static void Subscribe<TEventArgs>(this JetBrains.Util.EventBus.IEventBus bus, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.EventId<TEventArgs> eventId, JetBrains.Util.EventBus.Execution.ExecutionMode executionMode, System.Action<JetBrains.Util.EventBus.EventId, TEventArgs> action) { }
    }
    public abstract class EventId
    {
        protected string myEventName;
        protected JetBrains.Util.EventBus.EventId myParentEvent;
        public string EventName { get; }
        public JetBrains.Util.EventBus.EventId ParentEvent { get; }
        public bool Equals(JetBrains.Util.EventBus.EventId other) { }
        public override bool Equals(object obj) { }
        public abstract System.Type GetEventArgsType();
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public sealed class EventId<TEventArgs> : JetBrains.Util.EventBus.EventId
    
    {
        public EventId(string eventName) { }
        public JetBrains.Util.EventBus.EventId<TSubEventType> CreateSubEvent<TSubEventType>(string eventName)
            where TSubEventType : TEventArgs { }
        public bool Equals(JetBrains.Util.EventBus.EventId<TEventArgs> other) { }
        public override bool Equals(object obj) { }
        public override System.Type GetEventArgsType() { }
        public override int GetHashCode() { }
    }
    public interface IEvent<T>
    
    {
        void Raise(T eventArgs);
    }
    public interface IEventBus : JetBrains.Util.EventBus.IEventContext, System.IDisposable
    {
        JetBrains.Util.EventBus.IEventRef<T> Event<T>(JetBrains.Util.EventBus.EventId<T> eventId);
        JetBrains.Util.EventBus.IEventRef<T> Event<T>();
    }
    public interface IEventContext : System.IDisposable
    {
        void Invoke<T>(JetBrains.Util.EventBus.EventId<T> eventId, T args);
        JetBrains.Util.EventBus.IEventContext InvokeStartFinish<TStartArgs, TFinishArgs>(JetBrains.Util.EventBus.EventId<TStartArgs> startEventId, JetBrains.Util.EventBus.EventId<TFinishArgs> finishEventId, TStartArgs args, System.Func<TFinishArgs> finishArgs);
    }
    public interface IEventRef<T>
    
    {
        void Subscribe(JetBrains.DataFlow.Lifetime lifetime, System.Action<T> handler);
        void Subscribe(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.Util.EventBus.EventId, T> handler);
        void Subscribe(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.Execution.ExecutionMode mode, System.Action<T> handler);
        void Subscribe(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.EventBus.Execution.ExecutionMode mode, System.Action<JetBrains.Util.EventBus.EventId, T> handler);
    }
    public interface IEventSubscribtion
    {
        void Invoke(JetBrains.Util.EventBus.EventId eventId, object eventArgs);
    }
    public interface IEventSubscribtion<T> : JetBrains.Util.EventBus.IEventSubscribtion
    
    {
        void Invoke(JetBrains.Util.EventBus.EventId eventId, T eventArgs);
    }
    public interface ISubscribtionCookie : System.IDisposable { }
}
namespace JetBrains.Util.EventBus.Execution
{
    
    public abstract class ExecutionMode
    {
        public static JetBrains.Util.EventBus.Execution.ExecutionMode Simple;
        public static JetBrains.Util.EventBus.Execution.ExecutionMode ThreadPool;
        public abstract void Execute<T>(System.Action<JetBrains.Util.EventBus.EventId, T> action, JetBrains.Util.EventBus.EventId eventId, T argument);
        public JetBrains.Util.EventBus.Execution.ExecutionMode Grouping(System.TimeSpan minimumTimespan) { }
        public JetBrains.Util.EventBus.Execution.ExecutionMode Grouping(System.TimeSpan minimumTimespan, bool skipFirst) { }
    }
    public class FreeThreadedExecutionMode : JetBrains.Util.EventBus.Execution.ExecutionMode
    {
        public override void Execute<T>(System.Action<JetBrains.Util.EventBus.EventId, T> action, JetBrains.Util.EventBus.EventId eventId, T argument) { }
    }
    public class GroupingExecutionMode : JetBrains.Util.EventBus.Execution.ExecutionMode
    {
        public GroupingExecutionMode([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.EventBus.Execution.ExecutionMode parentExecutionMode, System.TimeSpan minimumInterval, bool skipFirst) { }
        public override void Execute<T>(System.Action<JetBrains.Util.EventBus.EventId, T> action, JetBrains.Util.EventBus.EventId eventId, T argument) { }
    }
    public interface IWork
    {
        void Execute();
    }
    public class SimpleExecutionMode : JetBrains.Util.EventBus.Execution.ExecutionMode
    {
        public override void Execute<T>(System.Action<JetBrains.Util.EventBus.EventId, T> action, JetBrains.Util.EventBus.EventId eventId, T argument) { }
    }
    public class SingleFreeThreadExecutionMode : JetBrains.Util.EventBus.Execution.ExecutionMode
    {
        public SingleFreeThreadExecutionMode(JetBrains.DataFlow.Lifetime lifetime, string threadName) { }
        public void AssertAccess() { }
        public bool CheckAccess() { }
        public void EnsureThread(System.Action action) { }
        public override void Execute<T>(System.Action<JetBrains.Util.EventBus.EventId, T> action, JetBrains.Util.EventBus.EventId eventId, T argument) { }
    }
    public class ThreadUtil
    {
        public ThreadUtil(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public void AssertAccess() { }
        public bool CheckThread() { }
        public void Enqueue(JetBrains.Util.EventBus.Execution.IWork work) { }
    }
}
namespace JetBrains.Util.EventBus.Impl
{
    
    public class EventBusException : System.Exception
    {
        public EventBusException(string message) { }
    }
    public class EventBusImpl : JetBrains.Util.EventBus.IEventBus, JetBrains.Util.EventBus.IEventContext, System.IDisposable
    {
        public EventBusImpl() { }
        public void Dispose() { }
        public JetBrains.Util.EventBus.IEventRef<T> Event<T>(JetBrains.Util.EventBus.EventId<T> eventId) { }
        public JetBrains.Util.EventBus.IEventRef<T> Event<T>() { }
        public void Invoke<T>(JetBrains.Util.EventBus.EventId<T> eventId, T args) { }
        public JetBrains.Util.EventBus.IEventContext InvokeStartFinish<TStartArgs, TFinishArgs>(JetBrains.Util.EventBus.EventId<TStartArgs> startEventId, JetBrains.Util.EventBus.EventId<TFinishArgs> finishEventId, TStartArgs args, System.Func<TFinishArgs> finishArgs) { }
    }
    public class EventImpl<TEventArgs> : JetBrains.Util.EventBus.IEvent<TEventArgs>
    
    {
        public JetBrains.Util.EventBus.EventId<TEventArgs> EventId { get; }
        public void Raise(TEventArgs eventArgs) { }
    }
    public struct EventQueueItem
    {
        public readonly object Args;
        public readonly JetBrains.Util.EventBus.EventId EventId;
        public EventQueueItem(JetBrains.Util.EventBus.EventId eventId, object args) { }
    }
    public class EventSubContextImpl<TEventArgs> : JetBrains.Util.EventBus.IEventContext, System.IDisposable
    
    {
        public EventSubContextImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.EventBus.IEventContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.EventBus.EventId<TEventArgs> finishEventId, [JetBrains.Annotations.NotNullAttribute()] System.Func<TEventArgs> fnishArgs) { }
        public void Dispose() { }
        public void Invoke<T>(JetBrains.Util.EventBus.EventId<T> eventId, T args) { }
        public JetBrains.Util.EventBus.IEventContext InvokeStartFinish<TStartArgs, TFinishArgs>(JetBrains.Util.EventBus.EventId<TStartArgs> startEventId, JetBrains.Util.EventBus.EventId<TFinishArgs> finishEventId, TStartArgs args, System.Func<TFinishArgs> finishArgs) { }
    }
    public sealed class EventSubscribtionImpl<T> : JetBrains.Util.EventBus.IEventSubscribtion, JetBrains.Util.EventBus.IEventSubscribtion<T>, JetBrains.Util.EventBus.ISubscribtionCookie, System.IDisposable
    
    {
        public EventSubscribtionImpl(System.Action<JetBrains.Util.EventBus.EventId, T> action, JetBrains.Util.EventBus.Execution.ExecutionMode executionMode, System.Action<JetBrains.Util.EventBus.Impl.EventSubscribtionImpl<T>> disposed) { }
        public void Dispose() { }
        public void Invoke(JetBrains.Util.EventBus.EventId eventId, T eventArgs) { }
    }
}
namespace JetBrains.Util.Events
{
    
    public class EventDispatcher
    {
        public EventDispatcher() { }
        public void AddListener(System.Delegate listener) { }
        public bool DispatchPendingEvents(System.Delegate listener) { }
        public void RaiseEvent(object sender, System.EventArgs args) { }
        public void RemoveListener(System.Delegate listener) { }
    }
}
namespace JetBrains.Util.Extension
{
    
    public class static BinaryReaderWriterEx
    {
        public static System.Nullable<T> ReadEnum<T>([JetBrains.Annotations.NotNullAttribute()] this System.IO.BinaryReader reader)
            where T :  struct { }
        public static T ReadEnum<T>([JetBrains.Annotations.NotNullAttribute()] this System.IO.BinaryReader reader, T defaultValue)
            where T :  struct { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string ReadNullableString([JetBrains.Annotations.NotNullAttribute()] this System.IO.BinaryReader reader) { }
        public static void WriteEnum<T>([JetBrains.Annotations.NotNullAttribute()] this System.IO.BinaryWriter writer, T enumValue) { }
        public static void WriteNullableString([JetBrains.Annotations.NotNullAttribute()] this System.IO.BinaryWriter writer, [JetBrains.Annotations.CanBeNullAttribute()] string s) { }
    }
}
namespace JetBrains.Util.FilePersistence
{
    
    public class SafeBinaryFileThrowAwayAccess
    {
        public SafeBinaryFileThrowAwayAccess([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath fileName) { }
        public bool Load([JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.BinaryReader> read) { }
        public void Save([JetBrains.Annotations.NotNullAttribute()] System.Action<System.IO.BinaryWriter> write) { }
    }
}
namespace JetBrains.Util.Graph
{
    
    public class ComplexNode<T>
    
    {
        public ComplexNode(System.Collections.Generic.JetHashSet<T> compositeNodes) { }
        public System.Collections.Generic.IEnumerable<T> Constituents { get; }
        public object Element { get; }
        public bool IsComposite { get; }
        public T SingleNode { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class DirectedGraph<T> : JetBrains.Util.Graph.IDirectedGraph<T>
    
    {
        public DirectedGraph() { }
        public System.Collections.Generic.IEnumerable<T> Nodes { get; }
        public void AddDependency(T from, T to) { }
        public System.Collections.Generic.IEnumerable<T> Incoming(T node) { }
        public System.Collections.Generic.IEnumerable<T> Outgoing(T node) { }
        public void RemoveAllIncoming(T node) { }
        public void RemoveAllIncoming(T node, System.Predicate<T> checkIncoming) { }
        public void RemoveDependency(T from, T to) { }
    }
    public struct FactorizedGraph<T> : JetBrains.Util.Graph.IDirectedGraph<JetBrains.Util.Graph.ComplexNode<T>>
    
    {
        public FactorizedGraph(JetBrains.Util.Graph.IDirectedGraph<T> original, System.Collections.Generic.JetHashSet<JetBrains.Util.Graph.ComplexNode<T>> newNodes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Graph.ComplexNode<T>> Nodes { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Graph.ComplexNode<T>> Incoming(JetBrains.Util.Graph.ComplexNode<T> complexNode) { }
        public bool IsValid() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Graph.ComplexNode<T>> Outgoing(JetBrains.Util.Graph.ComplexNode<T> complexNode) { }
    }
    public class static GraphAlgorithms
    {
        public static void DepthFirstSearch<T>(this JetBrains.Util.Graph.IDirectedGraph<T> graph, JetBrains.Util.Graph.GraphAlgorithms.DoBeforeProcessing<T> preProcessing, JetBrains.Util.Graph.GraphAlgorithms.DoAfterProcessing<T> postProcessing) { }
        public static void DFS<T>(JetBrains.Util.Graph.IDirectedGraph<T> graph, T current, System.Collections.Generic.JetHashSet<T> processed, JetBrains.Util.Graph.GraphAlgorithms.DoBeforeProcessing<T> preProcessing, JetBrains.Util.Graph.GraphAlgorithms.DoAfterProcessing<T> postProcessing) { }
        public static void DoNothing<T>(T node) { }
        public static JetBrains.Util.Graph.IDirectedGraph<JetBrains.Util.Graph.ComplexNode<T>> StronglyConnectedComponentsGraph<T>(this JetBrains.Util.Graph.IDirectedGraph<T> graph) { }
        public static System.Collections.Generic.IEnumerable<T> TopologicalSortedOrder<T>(this JetBrains.Util.Graph.IDirectedGraph<T> graph) { }
        public static JetBrains.Util.Graph.IDirectedGraph<T> Transpose<T>(this JetBrains.Util.Graph.IDirectedGraph<T> graph) { }
        public delegate void DoAfterProcessing<T>(T node);
        public delegate void DoBeforeProcessing<T>(T node);
    }
    public interface IDirectedGraph<T>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T> Nodes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T> Incoming([JetBrains.Annotations.NotNullAttribute()] T node);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T> Outgoing([JetBrains.Annotations.NotNullAttribute()] T node);
    }
    public struct TransposedGraph<T> : JetBrains.Util.Graph.IDirectedGraph<T>
    
    {
        public TransposedGraph(JetBrains.Util.Graph.IDirectedGraph<T> original) { }
        public System.Collections.Generic.IEnumerable<T> Nodes { get; }
        public System.Collections.Generic.IEnumerable<T> Incoming(T node) { }
        public System.Collections.Generic.IEnumerable<T> Outgoing(T node) { }
    }
}
namespace JetBrains.Util.Graphs
{
    
    public class static BiparititeGraphAlgorithms
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<T1, T2>> MaximalMatching<T1, T2>(this JetBrains.Util.Graphs.IBipartiteGraph<T1, T2> graph) { }
    }
    public class BipartiteGraph<T1, T2> : JetBrains.Util.Graphs.IBipartiteGraph<T1, T2>
    
    
    {
        public BipartiteGraph() { }
        public System.Collections.Generic.IEnumerable<T1> FirstPartVertices { get; }
        public System.Collections.Generic.IEnumerable<T2> SecondPartVertices { get; }
        public void AddEdge(T1 from, T2 to) { }
        public System.Collections.Generic.IEnumerable<T2> ConnectedVertices(T1 vertice) { }
        public System.Collections.Generic.IEnumerable<T1> ConnectedVertices(T2 vertice) { }
        public bool IsEmpty() { }
        public void RemoveEdge(T1 from, T2 to) { }
        public void RemoveVertice(T1 vertice) { }
        public void RemoveVertice(T2 vertice) { }
    }
    public interface IBipartiteGraph<T1, T2>
    
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T1> FirstPartVertices { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T2> SecondPartVertices { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T2> ConnectedVertices(T1 vertice);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T1> ConnectedVertices(T2 vertice);
    }
}
namespace JetBrains.Util.Interop
{
    
    public struct DpiResolution : System.IEquatable<JetBrains.Util.Interop.DpiResolution>
    {
        public static readonly JetBrains.Util.Interop.DpiResolution CurrentScreenDpi;
        public static readonly JetBrains.Util.Interop.DpiResolution DeviceIndependent96Dpi;
        public static readonly int DeviceIndependent96DpiValue;
        public static readonly JetBrains.Util.Interop.DpiResolution NotSure;
        public DpiResolution(double dpiX, double dpiY) { }
        public double DpiX { get; }
        public double DpiY { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Util.Interop.DpiResolution other) { }
        public override int GetHashCode() { }
    }
    public class static DpiUtil
    {
        public static double DpiFactor { get; }
        public static double DpiHorizontalFactor { get; }
        public static double DpiVerticalFactor { get; }
        public static JetBrains.Util.Interop.DpiResolution ScreenDpi { get; }
    }
    public class FixedBuffer : System.IDisposable
    {
        public FixedBuffer() { }
        public FixedBuffer(int nLengthToAllocateInBytes) { }
        public System.IntPtr Address { get; }
        public bool IsAllocated { get; }
        public int Length { get; }
        public void Allocate(int nLengthInBytes) { }
        public void Dispose() { }
    }
    public class static ImportAddressTableHook
    {
        public static void Install(string sFuncMod, string sFuncName, System.Void* hCallingMod, System.Delegate pNewFunction) { }
        public static void Install(string sFuncMod, string sFuncName, string sCallingMod, System.Delegate pNewFunction) { }
        public static void InstallCore([JetBrains.Annotations.NotNullAttribute()] string sFuncMod, [JetBrains.Annotations.NotNullAttribute()] string sFuncName, [JetBrains.Annotations.NotNullAttribute()] System.Void* hCallingMod, [JetBrains.Annotations.CanBeNullAttribute()] string sCallingMod, [JetBrains.Annotations.NotNullAttribute()] System.Delegate pNewFunction) { }
    }
    public sealed class NativeDll
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Void* ModuleHandle;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string ModuleName;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string ModulePath;
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.Interop.NativeDll.ComObject CreateComObject(System.Guid guidClsid) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.Interop.NativeDll.ComObject CreateComObject<TType>()
            where TType :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TDelegate ImportMethod<TDelegate>([JetBrains.Annotations.NotNullAttribute()] string methodName)
            where TDelegate :  class { }
        public class ComObject
        {
            public readonly System.Guid CLSID;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly object Instance;
            public ComObject([JetBrains.Annotations.NotNullAttribute()] object instance, System.Guid guid) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public TInterface As<TInterface>()
                where TInterface :  class { }
        }
    }
    public class static NativeDllsLoader
    {
        public static JetBrains.Util.FileSystemPath GetDllDirectory(JetBrains.Interop.WinApi.ProcessorArchitecture architecture) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.Interop.NativeDll LoadDll([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string filename, bool setSearchPath = False) { }
    }
    public class static ProcessorArchitectureEx
    {
        public static string ToPresentableString(this JetBrains.Interop.WinApi.ProcessorArchitecture processorArchitecture) { }
    }
    public class static ProcessorUtil
    {
        public static readonly JetBrains.Interop.WinApi.ProcessorArchitecture Architecture;
        public static readonly JetBrains.Interop.WinApi.ProcessorArchitecture NativeArchitecture;
    }
    public class static RegistryEx
    {
        public static JetBrains.Util.Interop.RegistryEx.RegistryHiveAccess InProcessSpecific([JetBrains.Annotations.NotNullAttribute()] this Microsoft.Win32.RegistryKey keyBase) { }
        public static JetBrains.Util.Interop.RegistryEx.RegistryHiveAccess InSystemNative([JetBrains.Annotations.NotNullAttribute()] this Microsoft.Win32.RegistryKey keyBase) { }
        public static JetBrains.Util.Interop.RegistryEx.RegistryHiveAccess InWin32([JetBrains.Annotations.NotNullAttribute()] this Microsoft.Win32.RegistryKey keyBase) { }
        public struct RegistryHiveAccess
        {
            public RegistryHiveAccess([JetBrains.Annotations.NotNullAttribute()] Microsoft.Win32.RegistryKey keyBase, JetBrains.Interop.WinApi.KeyAccessRights keyArchitectureFlag) { }
            public bool CreateKey([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool DeleteKey([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool DeleteValue([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] string dataname, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public System.Nullable<uint> GetDwordValue([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] string dataname, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public string GetStringValue([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] string dataname, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool SetDwordValue([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] string dataname, uint datavalue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool SetStringValue([JetBrains.Annotations.NotNullAttribute()] string subkey, [JetBrains.Annotations.NotNullAttribute()] string dataname, [JetBrains.Annotations.NotNullAttribute()] string datavalue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
        }
    }
    public class static ShellLinkHelper
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly string ExtensionNoDot;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly string ExtensionWithDot;
        public static void CreateLink([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathLnkFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathLinkTarget) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Interop.WinApi.Declarations.Interfaces.IShellLinkW CreateShellLinkComObject() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath ResolveLinkTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathLnk) { }
    }
}
namespace JetBrains.Util.Lazy
{
    
    public class static Lazy
    {
        public static JetBrains.Util.Lazy.Lazy<T> Of<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T> valueFactory) { }
        public static JetBrains.Util.Lazy.Lazy<T> Of<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T> valueFactory, bool isThreadSafe) { }
        public static JetBrains.Util.Lazy.Lazy<T> Of<T>()
            where T : new() { }
        public static JetBrains.Util.Lazy.Lazy<T> Of<T>(bool isThreadSafe) { }
        public static JetBrains.Util.Lazy.Lazy<T> Of<T>(T value) { }
    }
    public abstract class Lazy<T>
    
    {
        public abstract bool IsCreated { get; }
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.Never)]
        public abstract T Value { get; }
        public override string ToString() { }
    }
}
namespace JetBrains.Util.Logging
{
    
    public class ConfiguredLogger : JetBrains.Util.ILogger
    {
        public bool IsEnabled(JetBrains.Util.LoggingLevel level) { }
    }
    public class DebugOutputLogEventListener : JetBrains.Util.ILogEventListener, System.IEquatable<JetBrains.Util.Logging.DebugOutputLogEventListener>
    {
        protected readonly string myPrefix;
        public static bool OptionDontWriteDebugStream;
        public DebugOutputLogEventListener([JetBrains.Annotations.NotNullAttribute()] string prefix) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Util.Logging.DebugOutputLogEventListener debugOutputLogEventListener) { }
        protected static void ExtractPrefix([JetBrains.Annotations.NotNullAttribute()] ref string message, out string prefix) { }
        public override int GetHashCode() { }
        public static void WriteDebugStream([JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] string body) { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class FileLogEventListener : JetBrains.Util.ILogEventListener, System.IDisposable
    {
        public const string FORMAT_FULL = "full";
        public FileLogEventListener(string logFilePath, string format = "full") { }
        public void Dispose() { }
        public void OnError(string error) { }
        public void OnException(System.Exception ex) { }
        public void OnMessage(string message, JetBrains.Util.LoggingLevel level) { }
    }
    public class static Logger
    {
        public static readonly string ErrorMessagePrefix;
        public static readonly string ExceptionMessagePrefix;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.Util.ILogger Interface;
        public static readonly string LogFileExt;
        public static readonly string LogFileNamePrefix;
        public static readonly string LogsSubfolderName;
        public static bool AllowExceptions { get; set; }
        public static JetBrains.Util.LoggingLevel FileLoggingLevel { get; set; }
        public static int IndentLevel { get; set; }
        public static bool IsLoggingEnabled { get; set; }
        public static JetBrains.Util.FileSystemPath LogFile { get; }
        public static JetBrains.Util.FileSystemPath LogFileName { get; set; }
        public static JetBrains.Util.FileSystemPath LogFolderPath { get; }
        public static void Annotate([JetBrains.Annotations.NotNullAttribute()] System.Action F, [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Exception> FCommentException) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable AppendListener([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogEventListener listener) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert(bool condition, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string message) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void Assert(bool condition, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, params object[] args) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [System.Diagnostics.ConditionalAttribute("PROFILE")]
        public static void BeginEvent([JetBrains.Annotations.NotNullAttribute()] string comment) { }
        public static void Catch([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TValue Catch<TValue>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F) { }
        public static void Catch([JetBrains.Annotations.NotNullAttribute()] string comment, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static void CatchIgnore([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TValue CatchIgnoreExceptions<TValue>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F, System.Collections.Generic.JetHashSet<System.Type> exceptionTypesToIgnore) { }
        public static void CatchIgnoreExceptions([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action, System.Collections.Generic.JetHashSet<System.Type> exceptionTypesToIgnore) { }
        public static void CatchSilent([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TValue CatchSilent<TValue>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TValue> F) { }
        public static void CleanupOldLogFiles() { }
        public static void DropException([JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [System.Diagnostics.ConditionalAttribute("PROFILE")]
        public static void EndEvent() { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        public static void Fail([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string messageText) { }
        [JetBrains.Annotations.AssertionMethodAttribute()]
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static void Fail([System.ComponentModel.LocalizableAttribute(false)] string format, params object[] args) { }
        public static void Flush() { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static string FormatStringSafe([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, params object[] args) { }
        public static string GetCurrentPad() { }
        public static string GetLogFileNameWithoutExtension() { }
        public static JetBrains.Util.ILogger GetLogger(System.Type callerType) { }
        public static JetBrains.Util.ILogger GetLogger(string fullClassName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IO.TextWriter GetLogWriter() { }
        public static void Init() { }
        public static void LogError([JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static void LogError([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, params object[] args) { }
        public static void LogException([JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        public static void LogException([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string comment, [JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        public static void LogExceptionEx([JetBrains.Annotations.NotNullAttribute()] System.Exception ex, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string comment, bool bDumpCurrentStack) { }
        public static void LogExceptionSilently([JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        public static void LogMessage(JetBrains.Util.LoggingLevel level, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static void LogMessage(JetBrains.Util.LoggingLevel level, [JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, params object[] args) { }
        public static void LogMessage([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string message) { }
        [JetBrains.Annotations.StringFormatMethodAttribute("format")]
        public static void LogMessage([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string format, params object[] args) { }
        public static void RemoveListener([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogEventListener listener) { }
    }
    public class LoggerConfiguration : JetBrains.Util.JetFileSystemWatcher.IWatcherEvents, System.IDisposable
    {
        public static readonly JetBrains.Util.Logging.LoggerConfiguration Instance;
        public int Timestamp { get; }
        public void Dispose() { }
        public void Initialize(JetBrains.Util.FileSystemPath configurationLocation, bool sync = False) { }
    }
    public class LoggerConfigurationParseException : System.Exception
    {
        public LoggerConfigurationParseException(string str) { }
        public LoggerConfigurationParseException(string str, System.Exception cause) { }
    }
}
namespace JetBrains.Util.Memory
{
    
    public class static MemoryUtil
    {
        public static void CopyMemory(System.Byte* src, System.Byte* dest, int len) { }
        public static JetBrains.Util.Memory.ObjectReference[] GetReachingPath(object obj, object[] roots) { }
        public static ulong GetTotalVirtualMemory() { }
    }
    public class ObjectReference
    {
        public ObjectReference(object obj, System.Reflection.FieldInfo fieldInfo) { }
        public ObjectReference(System.Reflection.FieldInfo fieldInfo) { }
        public System.Reflection.FieldInfo FieldInfo { get; }
        public object Object { get; }
        public override string ToString() { }
    }
}
namespace JetBrains.Util.NamedPipes
{
    
    public sealed class AsyncMessageStreamReader
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.ISignal<System.IO.Stream> MessageReceived;
        public AsyncMessageStreamReader(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Func<bool> FIsCompleteMessageReceived) { }
        public AsyncMessageStreamReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] System.Func<bool> FIsCompleteMessageReceived, int bufferSize) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.IO.Stream BaseStream { get; }
        public void BeginReadMessage() { }
        public void CancelOperation() { }
        public void WaitUtilEOF() { }
    }
    public sealed class AsyncServerPipeMessageReader
    {
        public AsyncServerPipeMessageReader(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.IO.Pipes.NamedPipeServerStream pipe) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ISignal<System.IO.Stream> MessageReceived { get; }
        public void BeginReadMessage() { }
    }
    public sealed class AsyncServerPipeObjectReader<TObject>
    
    {
        public readonly JetBrains.DataFlow.ISignal<TObject> ObjectReceived;
        public AsyncServerPipeObjectReader(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.IO.Pipes.NamedPipeServerStream pipe) { }
        public AsyncServerPipeObjectReader(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.IO.Pipes.NamedPipeServerStream pipe, [JetBrains.Annotations.NotNullAttribute()] System.Func<System.IO.Stream, TObject> FDeserializeObject) { }
        public void BeginReadMessage() { }
    }
}
namespace JetBrains.Util.Reflection
{
    
    public class static CallStackAnnotation
    {
        public static System.Action<System.Action> AnnotateAction(JetBrains.Util.Pair<string, string> stackFrameText) { }
        public static System.Delegate AnnotateDelegate(JetBrains.Util.Pair<string, string> sStackFrameText, bool isWithReturnValue, System.Type[] typeGenericParamsForDelegateInstantiation, System.Func<System.Type[], System.Type[]> FCreateParamsAndRetVal) { }
        public static System.Delegate AnnotateInstanceMethod(System.Type typeTargetMethodOwner, string sTargetMethodName, JetBrains.Util.Pair<string, string> sStackFrameText, System.Type[] typeParamsExceptThis, [JetBrains.Annotations.CanBeNullAttribute()] System.Type typeRetVal) { }
        public static void Ldarg(System.Reflection.Emit.ILGenerator ilgen, int nArgsToLoad) { }
    }
    public class InterfaceImplementation
    {
        public TInterface CreateDelegatingInterfaceImplementation_Emit<TInterface>([JetBrains.Annotations.NotNullAttribute()] TInterface delegatee)
            where TInterface :  class { }
        public static void Ldarg(System.Reflection.Emit.ILGenerator ilgen, int nArgsToLoad, bool[] isRefParam) { }
    }
    public class TypeConverterBase<T> : System.ComponentModel.TypeConverter
    
    {
        public TypeConverterBase([JetBrains.Annotations.NotNullAttribute()] System.Func<System.ComponentModel.ITypeDescriptorContext, System.Globalization.CultureInfo, T, string> FToString, [JetBrains.Annotations.NotNullAttribute()] System.Func<System.ComponentModel.ITypeDescriptorContext, System.Globalization.CultureInfo, string, T> FFromString) { }
        public TypeConverterBase([JetBrains.Annotations.NotNullAttribute()] System.Func<System.Globalization.CultureInfo, T, JetBrains.Util.ILogger, string> FToString, [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Globalization.CultureInfo, string, JetBrains.Util.ILogger, T> FFromString) { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { }
    }
    public class static TypeConverterUtil
    {
        public static T FromStringThruXml<T>(string value, System.Func<System.Xml.XmlElement, T> fromXmlFunc) { }
        public static string ToStringThruXml(System.Action<System.Xml.XmlElement> fillXmlAction, string elmentName = "data") { }
    }
    public class ValueSerializerBase<T> : System.Windows.Markup.ValueSerializer
    
    {
        public ValueSerializerBase([JetBrains.Annotations.NotNullAttribute()] System.Func<System.Windows.Markup.IValueSerializerContext, T, string> FToString, [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Windows.Markup.IValueSerializerContext, string, T> FFromString) { }
        public ValueSerializerBase([JetBrains.Annotations.NotNullAttribute()] System.Func<T, JetBrains.Util.ILogger, string> FToString, [JetBrains.Annotations.NotNullAttribute()] System.Func<string, JetBrains.Util.ILogger, T> FFromString) { }
        public override bool CanConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { }
        public override bool CanConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { }
        public override object ConvertFromString(string value, System.Windows.Markup.IValueSerializerContext context) { }
        public override string ConvertToString(object value, System.Windows.Markup.IValueSerializerContext context) { }
    }
}
namespace JetBrains.Util.Special
{
    
    public class static GeneralUtil
    {
        public static bool Dfs<T>(T root, System.Func<T, bool> action, System.Func<T, System.Collections.Generic.IEnumerable<T>> getChildren, System.Func<T, bool> visitChildren) { }
        public static int EnsureInRange(this int value, int lowerBound, int upperBound) { }
        public static void If(bool condition, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action FTrue, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action FFalse) { }
        public static void If(bool condition, [JetBrains.Annotations.NotNullAttribute()] System.Action FTrue) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("object:null => null")]
        public static TResult IfNotNull<TInput, TResult>([JetBrains.Annotations.CanBeNullAttribute()] this TInput @object, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TInput, TResult> functor)
            where TInput :  class { }
        [JetBrains.Annotations.ContractAnnotationAttribute("object:null => null")]
        public static TResult IfNotNull<TInput, TResult>([JetBrains.Annotations.CanBeNullAttribute()] this System.Nullable<TInput> @object, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<System.Nullable<TInput>, TResult> functor)
            where TInput :  struct { }
        public static TResult IfNotNull<TInput, TResult>([JetBrains.Annotations.CanBeNullAttribute()] this TInput @object, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TInput, TResult> functor, TResult @default)
            where TInput :  class { }
        public static TResult IfNotNull<TInput, TResult>([JetBrains.Annotations.CanBeNullAttribute()] this TInput @object, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<TInput, TResult> functor, [JetBrains.Annotations.NotNullAttribute()] System.Func<TResult> @default)
            where TInput :  class { }
        public static T IfNull<T>([JetBrains.Annotations.CanBeNullAttribute()] this T @object, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T> functor)
            where T :  class { }
        public static bool IsAnyOf<T>(this T t, [JetBrains.Annotations.NotNullAttribute()] params T[] set) { }
        public static System.Collections.Generic.IEnumerable<T> ParentReversedPath<T>(this T node, System.Func<T, T> getParent)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string QuoteIfNeeded([JetBrains.Annotations.CanBeNullAttribute()] this object o) { }
        public static T Return<T>([JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<System.Func<T, T>> action) { }
        public static System.Collections.Generic.IEnumerable<T> SelfAndParentReversedPath<T>(this T node, System.Func<T, T> getParent)
            where T :  class { }
        public static T With<T>(this T control, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> action) { }
        public static void WithDispose<T>(this T disposable, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> action)
            where T : System.IDisposable { }
        public static R WithDispose<T, R>(this T disposable, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<T, R> F)
            where T : System.IDisposable { }
        public static void WithDisposeNotNull<T>([JetBrains.Annotations.CanBeNullAttribute()] this T disposable, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> F)
            where T :  class, System.IDisposable { }
        public static T WithNotNull<T>([JetBrains.Annotations.CanBeNullAttribute()] this T item, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Action<T> F) { }
    }
}
namespace JetBrains.Util.StackTraceParser
{
    
    public class CompositeNode : JetBrains.Util.StackTraceParser.StackTraceNode
    {
        public CompositeNode(JetBrains.Util.TextRange range) { }
        public System.Collections.Generic.List<JetBrains.Util.StackTraceParser.StackTraceNode> Nodes { get; }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public void AppendNode(JetBrains.Util.StackTraceParser.StackTraceNode node) { }
        public override void Dump(System.IO.TextWriter writer) { }
        protected bool Equals(JetBrains.Util.StackTraceParser.CompositeNode other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class IdentifierNode : JetBrains.Util.StackTraceParser.StackTraceNode
    {
        public IdentifierNode(string fullName, JetBrains.Util.TextRange range) { }
        public string Name { get; set; }
        public JetBrains.Util.StackTraceParser.IdentifierNode Qualifier { get; set; }
        public System.Collections.Generic.IList<JetBrains.Util.StackTraceParser.IdentifierNode> TypeParameters { get; set; }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public override void Dump(System.IO.TextWriter writer) { }
        public void DumpQualifier(System.IO.TextWriter writer) { }
        protected bool Equals(JetBrains.Util.StackTraceParser.IdentifierNode other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class IdentifierTokenType : JetBrains.Util.StackTraceParser.WordTokenType
    {
        public IdentifierTokenType() { }
    }
    public class MethodNode : JetBrains.Util.StackTraceParser.StackTraceNode
    {
        public MethodNode(JetBrains.Util.StackTraceParser.IdentifierNode fullName, JetBrains.Util.TextRange range) { }
        public JetBrains.Util.StackTraceParser.IdentifierNode Name { get; }
        public JetBrains.Util.StackTraceParser.ParameterListNode ParameterList { get; set; }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public override void Dump(System.IO.TextWriter writer) { }
        protected bool Equals(JetBrains.Util.StackTraceParser.MethodNode other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class NumberTokenType : JetBrains.Util.StackTraceParser.StackTokenType
    {
        public NumberTokenType(string name) { }
    }
    public enum ParameterKind
    {
        ByVal = 0,
        ByRef = 1,
        Pointer = 2,
    }
    public class ParameterListNode : JetBrains.Util.StackTraceParser.CompositeNode
    {
        public ParameterListNode(JetBrains.Util.TextRange range) { }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public override void Dump(System.IO.TextWriter writer) { }
    }
    public class ParameterNode : JetBrains.Util.StackTraceParser.StackTraceNode
    {
        public ParameterNode(JetBrains.Util.TextRange range, JetBrains.Util.StackTraceParser.IdentifierNode type, JetBrains.Util.StackTraceParser.IdentifierNode name, JetBrains.Util.StackTraceParser.ParameterKind kind, int arrayBounds, JetBrains.Util.StackTraceParser.TextNode value) { }
        public int ArrayBounds { get; }
        public JetBrains.Util.StackTraceParser.ParameterKind Kind { get; }
        public JetBrains.Util.StackTraceParser.IdentifierNode Name { get; }
        public JetBrains.Util.StackTraceParser.IdentifierNode Type { get; }
        public JetBrains.Util.StackTraceParser.TextNode Value { get; }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public override void Dump(System.IO.TextWriter writer) { }
    }
    public class PathNode : JetBrains.Util.StackTraceParser.StackTraceNode
    {
        public PathNode(JetBrains.Util.TextRange range, string path) { }
        public int Column { get; set; }
        public int Line { get; set; }
        public string Path { get; }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public override void Dump(System.IO.TextWriter writer) { }
    }
    public class StackTokenType : System.IEquatable<JetBrains.Util.StackTraceParser.StackTokenType>
    {
        public StackTokenType(string name) { }
        public string Name { get; }
        public bool Equals(JetBrains.Util.StackTraceParser.StackTokenType stackTokenType) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class static StackTokenTypes
    {
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType AMPERSAND;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType ASTERISK;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType COLON;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType COMMA;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType DOT;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType EQUALS;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType EXCLAMATION;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType IDENTIFIER;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType LANGLE;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType LBRACE;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType LBRACKET;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType LPARENTH;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType MINUS;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType NUMBER;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType PATH_SEPARATOR;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType QUOTATION;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType RANGLE;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType RBRACE;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType RBRACKET;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType RPARENTH;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType WHITESPACE;
        public static readonly JetBrains.Util.StackTraceParser.StackTokenType WORD;
    }
    public class StackTraceLexer
    {
        protected JetBrains.Util.StackTraceParser.StackTokenType currTokenType;
        protected const int YYINITIAL = 0;
        public StackTraceLexer(JetBrains.Text.IBuffer buffer) { }
        public StackTraceLexer(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        protected int BufferEnd { get; set; }
        protected int BufferIndex { get; set; }
        protected int BufferStart { get; set; }
        protected int EOFPos { get; set; }
        public int LexemIndent { get; }
        public uint LexerState { get; }
        protected int LexicalState { get; set; }
        public static short NStates { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public string TokenText { get; }
        public JetBrains.Util.StackTraceParser.StackTokenType TokenType { get; }
        public JetBrains.Util.StackTraceParser.StackTokenType _locateToken() { }
        public void Advance() { }
        protected virtual void locateToken() { }
        protected JetBrains.Util.StackTraceParser.StackTokenType makeToken(JetBrains.Util.StackTraceParser.StackTokenType type) { }
        public void RestoreState(JetBrains.Util.StackTraceParser.StackTraceLexer.State pos) { }
        public JetBrains.Util.StackTraceParser.StackTraceLexer.State SaveState() { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
        public struct State
        {
            public int BufferEnd;
            public int BufferIndex;
            public int BufferStart;
            public int LexicalState;
            public JetBrains.Util.StackTraceParser.StackTokenType TokenType;
        }
    }
    public class static StackTraceLexerUtil
    {
        public static string Normalize(string text) { }
    }
    public abstract class StackTraceNode
    {
        protected StackTraceNode(JetBrains.Util.TextRange range) { }
        public JetBrains.Util.TextRange Range { get; }
        public abstract void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor);
        public abstract void Dump(System.IO.TextWriter writer);
        public void UnionRange(JetBrains.Util.TextRange range) { }
    }
    public class StackTraceNodeVisitor
    {
        public virtual void VisitCompositeNode(JetBrains.Util.StackTraceParser.CompositeNode node) { }
        public virtual void VisitIdentifier(JetBrains.Util.StackTraceParser.IdentifierNode node) { }
        public virtual void VisitMethod(JetBrains.Util.StackTraceParser.MethodNode node) { }
        public virtual void VisitParameter(JetBrains.Util.StackTraceParser.ParameterNode node) { }
        public virtual void VisitParameterList(JetBrains.Util.StackTraceParser.ParameterListNode node) { }
        public virtual void VisitPath(JetBrains.Util.StackTraceParser.PathNode node) { }
        public virtual void VisitText(JetBrains.Util.StackTraceParser.TextNode node) { }
    }
    public class StackTraceParser
    {
        public StackTraceParser(JetBrains.Util.StackTraceParser.StackTraceLexer lexer) { }
        public StackTraceParser(JetBrains.Util.StackTraceParser.StackTraceLexer lexer, bool checkForInvalidChars, bool parsePath) { }
        public JetBrains.Util.StackTraceParser.CompositeNode RootNode { get; }
        public void Parse() { }
    }
    public class SymbolTokenType : JetBrains.Util.StackTraceParser.StackTokenType
    {
        public SymbolTokenType(string name) { }
    }
    public class TextNode : JetBrains.Util.StackTraceParser.StackTraceNode
    {
        public TextNode(JetBrains.Util.TextRange range, string text) { }
        public string Text { get; }
        public override void Accept(JetBrains.Util.StackTraceParser.StackTraceNodeVisitor visitor) { }
        public override void Dump(System.IO.TextWriter writer) { }
    }
    public class WhitespaceTokenType : JetBrains.Util.StackTraceParser.StackTokenType
    {
        public WhitespaceTokenType() { }
    }
    public class WordTokenType : JetBrains.Util.StackTraceParser.StackTokenType
    {
        public WordTokenType(string name) { }
    }
}
namespace JetBrains.Util.Supplementary
{
    
    public class Guard
    {
        public Guard(string name) { }
        public JetBrains.DataFlow.IProperty<bool> IsOnDuty { get; }
        public void OffDuty() { }
        public void OnDuty() { }
    }
}
namespace JetBrains.Util.Text
{
    
    public class static BufferRangeEx
    {
        public static bool CompareBufferText(JetBrains.Text.BufferRange b1, JetBrains.Text.BufferRange b2, bool caseSensitive = True) { }
        public static bool CompareBufferText(JetBrains.Text.BufferRange b1, string b2, bool caseSensitive = True) { }
        public static bool StringEquals(this JetBrains.Text.BufferRange range, string str, bool caseSensitive = True) { }
        public static bool StringEquals(this JetBrains.Text.BufferRange range, JetBrains.Text.BufferRange other, bool caseSensitive = True) { }
    }
    public class EncodingUtil
    {
        public static readonly System.Text.Encoding CP1251;
        public static System.Text.Encoding DefaultEncoding;
        public class DefaultEncodingCookie : System.IDisposable
        {
            public DefaultEncodingCookie(System.Text.Encoding encoding) { }
            public void Dispose() { }
        }
    }
}
namespace JetBrains.Util.Threading.Mmf
{
    
    public class SharedMemoryMessageBase
    {
        protected readonly System.Threading.EventWaitHandle _evtRead;
        protected readonly System.Threading.EventWaitHandle _evtWritten;
        protected readonly System.Threading.Mutex _mutexInterlock;
        protected readonly JetBrains.Util.dataStructures.RawCircularBufferHeader* _pBufferHeader;
        protected System.TimeSpan _timeoutForWaits;
        public readonly int MaxMessageSize;
        protected readonly JetBrains.Util.Threading.SynchronizedLifetime myLifetimeSync;
        public readonly string UniqueName;
        public SharedMemoryMessageBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeUnsync, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize, bool isWriter) { }
        protected static string DiagDecodeMessage(byte[] message) { }
        [System.Diagnostics.ConditionalAttribute("NEVER")]
        protected void Trace(string text) { }
    }
    public class SharedMemoryMessageReader : JetBrains.Util.Threading.Mmf.SharedMemoryMessageBase
    {
        public SharedMemoryMessageReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeUnsync, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.Util.dataStructures.ByteBuffer> FRead) { }
    }
    public class SharedMemoryMessageReader<TMessage> : JetBrains.Util.Threading.Mmf.SharedMemoryMessageReader
    
    {
        public SharedMemoryMessageReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.Util.dataStructures.ByteBuffer, TMessage> FDeserializer, [JetBrains.Annotations.NotNullAttribute()] System.Action<TMessage> FRead) { }
        public SharedMemoryMessageReader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize, [JetBrains.Annotations.NotNullAttribute()] System.Action<TMessage> FRead) { }
    }
    public class SharedMemoryMessageWriter : JetBrains.Util.Threading.Mmf.SharedMemoryMessageBase
    {
        public SharedMemoryMessageWriter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeUnsync, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize) { }
        public void SendMessage(byte[] data) { }
    }
    public class SharedMemoryMessageWriter<TMessage> : JetBrains.Util.Threading.Mmf.SharedMemoryMessageWriter
    
    {
        public SharedMemoryMessageWriter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeUnsync, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize, [JetBrains.Annotations.NotNullAttribute()] System.Func<TMessage, byte[]> FSerializer) { }
        public SharedMemoryMessageWriter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeUnsync, [JetBrains.Annotations.NotNullAttribute()] string sUniqueName, int nMaxMessageSize) { }
        public void SendMessage(TMessage message) { }
    }
}
namespace JetBrains.Util.Threading
{
    
    public class SynchronizedLifetime
    {
        public SynchronizedLifetime([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetimeUnsync) { }
        public bool IsTerminated { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.DataFlow.Lifetime AddAction(System.Action F) { }
        public JetBrains.DataFlow.Lifetime AddBracket(System.Action FOpening, System.Action FClosing) { }
        public JetBrains.DataFlow.Lifetime AddDispose(System.IDisposable item) { }
        public JetBrains.DataFlow.Lifetime AddRef(object @object) { }
        public void ExecuteIfNotTerminated([JetBrains.Annotations.NotNullAttribute()] System.Action F) { }
        public TResult ExecuteIfNotTerminated<TResult>([JetBrains.Annotations.NotNullAttribute()] System.Func<TResult> F) { }
    }
}
namespace JetBrains.Util.Util.Src.Concurrency
{
    
    public class ConcurrentFlag
    {
        public ConcurrentFlag() { }
        public ConcurrentFlag(bool isUp) { }
        public void Up() { }
        public void Wait() { }
    }
}
namespace JetBrains.Util.XMath
{
    
    public class BigInteger
    {
        public int dataLength;
        public static readonly int[] primesBelow100000;
        public static readonly JetBrains.Util.XMath.BigInteger Zero;
        public BigInteger() { }
        public BigInteger(long value) { }
        public BigInteger(ulong value) { }
        public BigInteger(JetBrains.Util.XMath.BigInteger bi) { }
        public BigInteger(string value, int radix) { }
        public BigInteger(byte[] inData) { }
        public BigInteger(byte[] inData, int inLen) { }
        public BigInteger(uint[] inData) { }
        public JetBrains.Util.XMath.BigInteger abs() { }
        public int bitCount() { }
        public override bool Equals(object o) { }
        public bool FermatLittleTest(int confidence) { }
        public JetBrains.Util.XMath.BigInteger gcd(JetBrains.Util.XMath.BigInteger bi) { }
        public JetBrains.Util.XMath.BigInteger genCoPrime(int bits, System.Random rand) { }
        public static JetBrains.Util.XMath.BigInteger genPseudoPrime(int bits, int confidence, System.Random rand) { }
        public void genRandomBits(int bits, System.Random rand) { }
        public byte[] getBytes() { }
        public override int GetHashCode() { }
        public int IntValue() { }
        public static bool IsDivisibleByFirstPrimes(JetBrains.Util.XMath.BigInteger thisVal) { }
        public bool isProbablePrime(int confidence) { }
        public bool isProbablePrime() { }
        public static int Jacobi(JetBrains.Util.XMath.BigInteger a, JetBrains.Util.XMath.BigInteger b) { }
        public long LongValue() { }
        public static JetBrains.Util.XMath.BigInteger[] LucasSequence(JetBrains.Util.XMath.BigInteger P, JetBrains.Util.XMath.BigInteger Q, JetBrains.Util.XMath.BigInteger k, JetBrains.Util.XMath.BigInteger n) { }
        public bool LucasStrongTest() { }
        public JetBrains.Util.XMath.BigInteger max(JetBrains.Util.XMath.BigInteger bi) { }
        public JetBrains.Util.XMath.BigInteger min(JetBrains.Util.XMath.BigInteger bi) { }
        public JetBrains.Util.XMath.BigInteger modInverse(JetBrains.Util.XMath.BigInteger modulus) { }
        public JetBrains.Util.XMath.BigInteger modPow(JetBrains.Util.XMath.BigInteger exp, JetBrains.Util.XMath.BigInteger n) { }
        public static void MulDivTest(int rounds) { }
        public bool RabinMillerTest(int confidence) { }
        public static void RSATest(int rounds) { }
        public static void RSATest2(int rounds) { }
        public void setBit(uint bitNum) { }
        public bool SolovayStrassenTest(int confidence) { }
        public JetBrains.Util.XMath.BigInteger sqrt() { }
        public static void SqrtTest(int rounds) { }
        public string ToHexString() { }
        public override string ToString() { }
        public string ToString(int radix) { }
        public void unsetBit(uint bitNum) { }
    }
    public class static StringToBytesConverter
    {
        public static byte[] Ascii(string s) { }
        public static byte[] Old(string s) { }
        public static byte[] Unicode(string s) { }
        public static byte[] Utf8(string s) { }
    }
}
namespace System.Collections.Generic
{
    
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(System.Collections.Generic.HashSetDebugView<>))]
    public class JetHashSet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        public struct ElementEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable { }
    }
    public class static JetHashSetExtensions { }
    public class JetHashSetSorted<TItem> : System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.IEnumerable { }
}
namespace System
{
    
    public delegate void JetAction<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public enum LazyExecutionMode
    {
        NotThreadSafe = 0,
        AllowMultipleThreadSafeExecution = 1,
        EnsureSingleThreadSafeExecution = 2,
    }
}
namespace System.Linq
{
    
    public class static EnumerableExJet { }
}