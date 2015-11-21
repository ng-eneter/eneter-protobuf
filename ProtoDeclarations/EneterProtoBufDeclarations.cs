//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Option: light framework (CF/Silverlight) enabled
    
// Generated from: EneterProtoBufDeclarations.proto
namespace Eneter.ProtoBuf
{
  [global::ProtoBuf.ProtoContract(Name=@"MessageBusMessageProto")]
  public partial class MessageBusMessageProto : global::ProtoBuf.IExtensible
  {
    public MessageBusMessageProto() {}
    
    private int _Request;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Request", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Request
    {
      get { return _Request; }
      set { _Request = value; }
    }
    private string _Id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private byte[] _MessageDataBin;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageDataBin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] MessageDataBin
    {
      get { return _MessageDataBin?? null; }
      set { _MessageDataBin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageDataBinSpecified
    {
      get { return this._MessageDataBin != null; }
      set { if (value == (this._MessageDataBin== null)) this._MessageDataBin = value ? this.MessageDataBin : (byte[])null; }
    }
    private bool ShouldSerializeMessageDataBin() { return MessageDataBinSpecified; }
    private void ResetMessageDataBin() { MessageDataBinSpecified = false; }
    
    private string _MessageDataStr;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MessageDataStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MessageDataStr
    {
      get { return _MessageDataStr?? ""; }
      set { _MessageDataStr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageDataStrSpecified
    {
      get { return this._MessageDataStr != null; }
      set { if (value == (this._MessageDataStr== null)) this._MessageDataStr = value ? this.MessageDataStr : (string)null; }
    }
    private bool ShouldSerializeMessageDataStr() { return MessageDataStrSpecified; }
    private void ResetMessageDataStr() { MessageDataStrSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"MultiTypedMessageProto")]
  public partial class MultiTypedMessageProto : global::ProtoBuf.IExtensible
  {
    public MultiTypedMessageProto() {}
    
    private string _TypeName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"TypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TypeName
    {
      get { return _TypeName; }
      set { _TypeName = value; }
    }
    private byte[] _MessageDataBin;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MessageDataBin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] MessageDataBin
    {
      get { return _MessageDataBin?? null; }
      set { _MessageDataBin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageDataBinSpecified
    {
      get { return this._MessageDataBin != null; }
      set { if (value == (this._MessageDataBin== null)) this._MessageDataBin = value ? this.MessageDataBin : (byte[])null; }
    }
    private bool ShouldSerializeMessageDataBin() { return MessageDataBinSpecified; }
    private void ResetMessageDataBin() { MessageDataBinSpecified = false; }
    
    private string _MessageDataStr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageDataStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MessageDataStr
    {
      get { return _MessageDataStr?? ""; }
      set { _MessageDataStr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageDataStrSpecified
    {
      get { return this._MessageDataStr != null; }
      set { if (value == (this._MessageDataStr== null)) this._MessageDataStr = value ? this.MessageDataStr : (string)null; }
    }
    private bool ShouldSerializeMessageDataStr() { return MessageDataStrSpecified; }
    private void ResetMessageDataStr() { MessageDataStrSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"RpcMessageProto")]
  public partial class RpcMessageProto : global::ProtoBuf.IExtensible
  {
    public RpcMessageProto() {}
    
    private int _Id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private int _Flag;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Flag
    {
      get { return _Flag; }
      set { _Flag = value; }
    }
    private string _OperationName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OperationName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationName
    {
      get { return _OperationName; }
      set { _OperationName = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _SerializedData = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(4, Name=@"SerializedData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> SerializedData
    {
      get { return _SerializedData; }
    }
  
    private string _ErrorType;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ErrorType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ErrorType
    {
      get { return _ErrorType; }
      set { _ErrorType = value; }
    }
    private string _ErrorMessage;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ErrorMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ErrorMessage
    {
      get { return _ErrorMessage; }
      set { _ErrorMessage = value; }
    }
    private string _ErrorDetails;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ErrorDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ErrorDetails
    {
      get { return _ErrorDetails; }
      set { _ErrorDetails = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"EventArgsProto")]
  public partial class EventArgsProto : global::ProtoBuf.IExtensible
  {
    public EventArgsProto() {}
    
    private int _dummy;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"dummy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dummy
    {
      get { return _dummy; }
      set { _dummy = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"WrappedDataProto")]
  public partial class WrappedDataProto : global::ProtoBuf.IExtensible
  {
    public WrappedDataProto() {}
    
    private string _AddedData;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AddedData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string AddedData
    {
      get { return _AddedData; }
      set { _AddedData = value; }
    }
    private byte[] _OriginalDataBin;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OriginalDataBin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] OriginalDataBin
    {
      get { return _OriginalDataBin?? null; }
      set { _OriginalDataBin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool OriginalDataBinSpecified
    {
      get { return this._OriginalDataBin != null; }
      set { if (value == (this._OriginalDataBin== null)) this._OriginalDataBin = value ? this.OriginalDataBin : (byte[])null; }
    }
    private bool ShouldSerializeOriginalDataBin() { return OriginalDataBinSpecified; }
    private void ResetOriginalDataBin() { OriginalDataBinSpecified = false; }
    
    private string _OriginalDataStr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"OriginalDataStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalDataStr
    {
      get { return _OriginalDataStr?? ""; }
      set { _OriginalDataStr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool OriginalDataStrSpecified
    {
      get { return this._OriginalDataStr != null; }
      set { if (value == (this._OriginalDataStr== null)) this._OriginalDataStr = value ? this.OriginalDataStr : (string)null; }
    }
    private bool ShouldSerializeOriginalDataStr() { return OriginalDataStrSpecified; }
    private void ResetOriginalDataStr() { OriginalDataStrSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"BrokerMessageProto")]
  public partial class BrokerMessageProto : global::ProtoBuf.IExtensible
  {
    public BrokerMessageProto() {}
    
    private int _Request;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Request", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Request
    {
      get { return _Request; }
      set { _Request = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _MessageTypes = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(2, Name=@"MessageTypes", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> MessageTypes
    {
      get { return _MessageTypes; }
    }
  
    private byte[] _MessageBin;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageBin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] MessageBin
    {
      get { return _MessageBin?? null; }
      set { _MessageBin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageBinSpecified
    {
      get { return this._MessageBin != null; }
      set { if (value == (this._MessageBin== null)) this._MessageBin = value ? this.MessageBin : (byte[])null; }
    }
    private bool ShouldSerializeMessageBin() { return MessageBinSpecified; }
    private void ResetMessageBin() { MessageBinSpecified = false; }
    
    private string _MessageStr;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MessageStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MessageStr
    {
      get { return _MessageStr?? ""; }
      set { _MessageStr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageStrSpecified
    {
      get { return this._MessageStr != null; }
      set { if (value == (this._MessageStr== null)) this._MessageStr = value ? this.MessageStr : (string)null; }
    }
    private bool ShouldSerializeMessageStr() { return MessageStrSpecified; }
    private void ResetMessageStr() { MessageStrSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"MonitorChannelMessageProto")]
  public partial class MonitorChannelMessageProto : global::ProtoBuf.IExtensible
  {
    public MonitorChannelMessageProto() {}
    
    private int _MessageType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"MessageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int MessageType
    {
      get { return _MessageType; }
      set { _MessageType = value; }
    }
    private byte[] _MessageContentBin;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MessageContentBin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] MessageContentBin
    {
      get { return _MessageContentBin?? null; }
      set { _MessageContentBin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageContentBinSpecified
    {
      get { return this._MessageContentBin != null; }
      set { if (value == (this._MessageContentBin== null)) this._MessageContentBin = value ? this.MessageContentBin : (byte[])null; }
    }
    private bool ShouldSerializeMessageContentBin() { return MessageContentBinSpecified; }
    private void ResetMessageContentBin() { MessageContentBinSpecified = false; }
    
    private string _MessageContentStr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageContentStr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string MessageContentStr
    {
      get { return _MessageContentStr?? ""; }
      set { _MessageContentStr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool MessageContentStrSpecified
    {
      get { return this._MessageContentStr != null; }
      set { if (value == (this._MessageContentStr== null)) this._MessageContentStr = value ? this.MessageContentStr : (string)null; }
    }
    private bool ShouldSerializeMessageContentStr() { return MessageContentStrSpecified; }
    private void ResetMessageContentStr() { MessageContentStrSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"VoidMessageProto")]
  public partial class VoidMessageProto : global::ProtoBuf.IExtensible
  {
    public VoidMessageProto() {}
    
    private int _dummy;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"dummy", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int dummy
    {
      get { return _dummy; }
      set { _dummy = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}