//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Docflow/PowerOfAttorneyAttachmentStatus.proto
namespace Diadoc.Api.Proto.Docflow
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyAttachmentStatus")]
  public partial class PowerOfAttorneyAttachmentStatus : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyAttachmentStatus() {}
    
    private Diadoc.Api.Proto.Docflow.StatusName _StatusName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"StatusName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Docflow.StatusName StatusName
    {
      get { return _StatusName; }
      set { _StatusName = value; }
    }

    private string _Comment = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Comment
    {
      get { return _Comment; }
      set { _Comment = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"StatusName")]
    public enum StatusName
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PowerOfAttorneyAttached", Value=0)]
      PowerOfAttorneyAttached = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PowerOfAttorneyNotRequired", Value=1)]
      PowerOfAttorneyNotRequired = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PowerOfAttorneyRequired", Value=2)]
      PowerOfAttorneyRequired = 2
    }
  
}