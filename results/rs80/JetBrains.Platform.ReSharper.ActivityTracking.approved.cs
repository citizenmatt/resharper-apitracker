[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ActivityTracking
{
    
    public class ActivityLog : JetBrains.ActivityTracking.Sections.DictionarySection<JetBrains.ActivityTracking.Sections.Section>
    {
        public ActivityLog() { }
        public JetBrains.ActivityTracking.Sections.CountersSection Counters { get; }
        public override JetBrains.ActivityTracking.Sections.Section this[string sectionName] { get; set; }
        public System.Guid LogId { get; }
        public JetBrains.ActivityTracking.Sections.MetadataSection Metadata { get; }
        public System.TimeSpan SessionDuration { get; }
        public System.DateTime StartTime { get; }
        public TSection GetOrCreate<TSection>(string name)
            where TSection : JetBrains.ActivityTracking.Sections.Section, new () { }
    }
    public class ActivityLogsSubmitter
    {
        public ActivityLogsSubmitter(JetBrains.Util.FileSystemPath logsFolder, System.TimeSpan submitLogsInterval) { }
        public void ProcessLogs([JetBrains.Annotations.CanBeNullAttribute()] System.Net.IWebProxy proxy, bool submitFiles) { }
    }
    public class ActivityLogToStringVisitor : JetBrains.ActivityTracking.Sections.ActivityLogVisitor
    {
        public ActivityLogToStringVisitor(System.Text.StringBuilder builder) { }
        public override void VisitDictionary<T>(JetBrains.ActivityTracking.Sections.DictionarySection<T> section) { }
        public override void VisitKeyValuePair<TK, TV>(TK key, TV value) { }
        public override void VisitList<T>(JetBrains.ActivityTracking.Sections.ListSection<T> section) { }
        public override void VisitObject(object o) { }
    }
    public class ActivityTrackingDefaultSettings
    {
        public ActivityTrackingDefaultSettings(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<bool> ActivityTrackingEnabled { get; set; }
        public JetBrains.DataFlow.IProperty<bool> CollectActivityTimingEnabled { get; set; }
        public virtual System.TimeSpan DumpLogsInterval { get; }
        public JetBrains.DataFlow.IProperty<bool> IsSubmittingLogsEnabled { get; set; }
        public virtual System.TimeSpan MaxSessionDuration { get; }
        public virtual System.TimeSpan SubmitLogsInterval { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual System.Net.IWebProxy GetProxy() { }
    }
    public class ActivityTrackingOld
    {
        public ActivityTrackingOld(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath logsPath, JetBrains.ActivityTracking.ActivityTrackingDefaultSettings settings) { }
        protected JetBrains.ActivityTracking.ActivityTrackingDefaultSettings Settings { get; }
        public event System.Action<JetBrains.ActivityTracking.ActivityTrackingOld, JetBrains.ActivityTracking.ActivityLog> SessionStarted;
        public void DumpLog() { }
        public bool IsSessionOpen() { }
        protected virtual void OnSessionStarted() { }
        public void StartSession() { }
        public void StopSession() { }
        protected void SubmitLogs() { }
        public void WithLock(System.Action<JetBrains.ActivityTracking.ActivityLog> handler) { }
    }
    public class static FileUploadUtil
    {
        public static bool UploadFile(JetBrains.Util.FileSystemPath file, string destinationUrl, [JetBrains.Annotations.CanBeNullAttribute()] System.Net.IWebProxy proxy) { }
    }
}
namespace JetBrains.ActivityTracking.obsolete
{
    
    public class ActivityLog2
    {
        public ActivityLog2(System.Guid sessionId, System.Guid uniqueId, System.DateTime startTime, System.Collections.Generic.Dictionary<string, string> metadata, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>> metadata2, System.Collections.Generic.List<JetBrains.ActivityTracking.obsolete.ActivityLogEvent> events, System.Collections.Generic.Dictionary<JetBrains.ActivityTracking.obsolete.Counter, int> counters) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<JetBrains.ActivityTracking.obsolete.ActivityLogEvent> Events { get; }
        public System.Guid SessionId { get; }
        public System.DateTime StartTime { get; }
        public System.Guid UniqueId { get; }
        public int Count(JetBrains.ActivityTracking.obsolete.Counter counter) { }
        public JetBrains.ActivityTracking.obsolete.Counter[] Counters() { }
        public string Metadata(string name) { }
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> Metadata2(string name) { }
        public string[] Metadata2Names() { }
        public string[] MetadataNames() { }
    }
    public class ActivityLog2Serializer
    {
        public JetBrains.ActivityTracking.obsolete.ActivityLog2 Deserialize(System.IO.BinaryReader reader) { }
        public void Serialize(System.IO.BinaryWriter writer, JetBrains.ActivityTracking.obsolete.ActivityLog2 log) { }
    }
    public class ActivityLogBuilder
    {
        public static readonly int Ref;
        public ActivityLogBuilder(System.Guid uniqueId) { }
        public JetBrains.ActivityTracking.obsolete.ActivityLog2 Result { get; }
        public void AddAction(string actionId) { }
        public void AddException(System.Exception ex) { }
        public void AddFeatureUsage(string category, string featureId) { }
        public void AddVsAction(string vsActionId) { }
        public void SetMetadata(string name, string value) { }
        public void SetMetadata(string name, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> value) { }
    }
    public class ActivityLogEvent
    {
        public ActivityLogEvent(System.DateTime time, string eventId, System.Collections.Generic.IDictionary<string, string> properties) { }
        public string EventId { get; }
        public System.Collections.Generic.IDictionary<string, string> Properties { get; }
        public System.DateTime Time { get; }
    }
    public class ActivityLogEventWithDuration : JetBrains.ActivityTracking.obsolete.ActivityLogEvent
    {
        public ActivityLogEventWithDuration(System.DateTime time, string eventId, System.TimeSpan duration, System.Collections.Generic.IDictionary<string, string> properties) { }
        public System.TimeSpan Duration { get; }
    }
    public class ActivityLogSerializerException : System.Exception
    {
        public ActivityLogSerializerException(string message) { }
    }
    public struct Counter
    {
        public Counter(string category, string counterId) { }
        public string Category { get; }
        public string CounterId { get; }
    }
}
namespace JetBrains.ActivityTracking.Sections
{
    
    public class ActivityLogVisitor
    {
        public virtual void Visit(object o) { }
        public virtual void VisitDictionary<T>(JetBrains.ActivityTracking.Sections.DictionarySection<T> section) { }
        public virtual void VisitKeyValuePair<TK, TV>(TK key, TV value) { }
        public virtual void VisitList<T>(JetBrains.ActivityTracking.Sections.ListSection<T> section) { }
        public virtual void VisitObject(object o) { }
    }
    public class CountersSection : JetBrains.ActivityTracking.Sections.DictionarySection<int>
    {
        public void Increment(string counterId) { }
    }
    public class DictionarySection<T> : JetBrains.ActivityTracking.Sections.Section
    
    {
        protected readonly System.Collections.Generic.Dictionary<string, T> Dictionary;
        public DictionarySection() { }
        public DictionarySection(System.Collections.Generic.IDictionary<string, T> properties) { }
        public virtual T this[string name] { get; set; }
        public System.Collections.Generic.Dictionary<string, T>.KeyCollection Keys { get; }
        public override void Accept(JetBrains.ActivityTracking.Sections.ActivityLogVisitor visitor) { }
    }
    public class ListSection<T> : JetBrains.ActivityTracking.Sections.Section
    
    {
        protected readonly System.Collections.Generic.List<T> List;
        public ListSection() { }
        public int Count { get; }
        public T this[int index] { get; set; }
        public override void Accept(JetBrains.ActivityTracking.Sections.ActivityLogVisitor visitor) { }
        public void Add(T item) { }
        public void AddRange(System.Collections.Generic.IEnumerable<T> collection) { }
        public bool Contains(T item) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
        public bool Remove(T item) { }
    }
    public class MetadataSection : JetBrains.ActivityTracking.Sections.DictionarySection<string>
    {
        public MetadataSection(System.Collections.Generic.IDictionary<string, string> properties) { }
    }
    public abstract class Section
    {
        public abstract void Accept(JetBrains.ActivityTracking.Sections.ActivityLogVisitor visitor);
    }
    public class Timing
    {
        public Timing(System.DateTime time, string activityGroup, string activityName) { }
        public Timing(string activityGroup, string activityName) { }
        public string ActivityGroup { get; }
        public string ActivityName { get; }
        public System.DateTime Time { get; }
    }
    public class TimingSection : JetBrains.ActivityTracking.Sections.ListSection<JetBrains.ActivityTracking.Sections.Timing> { }
}
namespace JetBrains.ActivityTracking.Serialization
{
    
    public class ActivityLogSerializer
    {
        public ActivityLogSerializer() { }
        public JetBrains.ActivityTracking.ActivityLog Deserialize(System.IO.BinaryReader reader) { }
        public void Serialize(System.IO.BinaryWriter writer, JetBrains.ActivityTracking.ActivityLog log) { }
    }
    public interface ITypeFormatter
    {
        object Deserialize(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context);
        void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, object o);
    }
    public class LogBinaryDeserializationContext : JetBrains.ActivityTracking.Serialization.LogContextBase
    {
        public LogBinaryDeserializationContext(System.IO.BinaryReader reader, System.Collections.Generic.Dictionary<System.Type, JetBrains.ActivityTracking.Serialization.TypeSerializationInfo> typeSerializationInfos) { }
        public override void Dispose() { }
        public object Read() { }
        public double ReadDoubleRaw() { }
        public void ReadHeader() { }
        public long ReadInt64Raw() { }
        public int ReadIntRaw() { }
        public string ReadStringRaw() { }
    }
    public class LogBinarySerializationContext : JetBrains.ActivityTracking.Serialization.LogContextBase
    {
        protected readonly System.Collections.Generic.Dictionary<System.Type, int> TypeToIndex;
        public LogBinarySerializationContext(System.IO.BinaryWriter binaryWriter, System.Collections.Generic.Dictionary<System.Type, JetBrains.ActivityTracking.Serialization.TypeSerializationInfo> typeSerializationInfo) { }
        public override void Dispose() { }
        public void Write(object o) { }
        protected void Write(object o, System.Type type, JetBrains.ActivityTracking.Serialization.TypeSerializationInfo serializationInfo, int typeIndex) { }
        public void WriteDoubleRaw(double value) { }
        public void WriteHeader(JetBrains.ActivityTracking.ActivityLog log) { }
        public void WriteInt64Raw(long value) { }
        public void WriteIntRaw(int value) { }
        public void WriteStringRaw(string value) { }
    }
    public abstract class LogContextBase : System.IDisposable
    {
        protected System.Collections.Generic.Dictionary<System.Type, JetBrains.ActivityTracking.Serialization.TypeSerializationInfo> TypeSerializationInfo;
        protected LogContextBase(System.Collections.Generic.Dictionary<System.Type, JetBrains.ActivityTracking.Serialization.TypeSerializationInfo> typeSerializationInfo) { }
        public abstract void Dispose();
        protected System.Type GetType(string alias) { }
        protected bool TryFildGenericTypeDefinition(System.Type type) { }
    }
    public struct TypeSerializationInfo
    {
        public static readonly JetBrains.ActivityTracking.Serialization.TypeSerializationInfo Default;
        public TypeSerializationInfo(string typeAlias, System.Type formatterType) { }
        public System.Type FormatterType { get; }
        public string TypeAlias { get; }
    }
}
namespace JetBrains.ActivityTracking.Serialization.Formatters
{
    
    public class CountersFormatter : JetBrains.ActivityTracking.Serialization.Formatters.DictionarySectionFormatter<int>
    {
        protected override JetBrains.ActivityTracking.Sections.DictionarySection<int> CreateInstance() { }
    }
    public class DictionarySectionFormatter<T> : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<JetBrains.ActivityTracking.Sections.DictionarySection<T>>
    
    {
        protected virtual JetBrains.ActivityTracking.Sections.DictionarySection<T> CreateInstance() { }
        protected override JetBrains.ActivityTracking.Sections.DictionarySection<T> Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, JetBrains.ActivityTracking.Sections.DictionarySection<T> o) { }
    }
    public class DoubleFormatter : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<double>
    {
        protected override double Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, double o) { }
    }
    public class IntFormatter : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<int>
    {
        protected override int Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, int o) { }
    }
    public class ListFormatter<T> : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<System.Collections.Generic.List<T>>
    
    {
        protected virtual System.Collections.Generic.List<T> CreateList() { }
        protected override System.Collections.Generic.List<T> Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, System.Collections.Generic.List<T> o) { }
    }
    public class ListSectionFormatter<T> : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<JetBrains.ActivityTracking.Sections.ListSection<T>>
    
    {
        protected virtual JetBrains.ActivityTracking.Sections.ListSection<T> CreateList() { }
        protected override JetBrains.ActivityTracking.Sections.ListSection<T> Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, JetBrains.ActivityTracking.Sections.ListSection<T> o) { }
    }
    public class LogFormatter : JetBrains.ActivityTracking.Serialization.Formatters.DictionarySectionFormatter<JetBrains.ActivityTracking.Sections.Section>
    {
        protected override JetBrains.ActivityTracking.Sections.DictionarySection<JetBrains.ActivityTracking.Sections.Section> CreateInstance() { }
    }
    public class MetadataFormatter : JetBrains.ActivityTracking.Serialization.Formatters.DictionarySectionFormatter<string>
    {
        protected override JetBrains.ActivityTracking.Sections.DictionarySection<string> CreateInstance() { }
    }
    public class StringFormatter : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<string>
    {
        protected override string Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, string o) { }
    }
    public class TimingFormatter : JetBrains.ActivityTracking.Serialization.Formatters.TypeFormatterBase<JetBrains.ActivityTracking.Sections.Timing>
    {
        protected override JetBrains.ActivityTracking.Sections.Timing Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context) { }
        protected override void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, JetBrains.ActivityTracking.Sections.Timing o) { }
    }
    public class TimingSectionFormatter : JetBrains.ActivityTracking.Serialization.Formatters.ListSectionFormatter<JetBrains.ActivityTracking.Sections.Timing>
    {
        protected override JetBrains.ActivityTracking.Sections.ListSection<JetBrains.ActivityTracking.Sections.Timing> CreateList() { }
    }
    public abstract class TypeFormatterBase<T> : JetBrains.ActivityTracking.Serialization.ITypeFormatter
    
    {
        protected abstract T Read(JetBrains.ActivityTracking.Serialization.LogBinaryDeserializationContext context);
        public void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, object o) { }
        protected abstract void Write(JetBrains.ActivityTracking.Serialization.LogBinarySerializationContext context, T o);
    }
}