//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CounteragentGroups/CounteragentGroupToUpdate.proto
// Note: requires additional types generated from: CounteragentGroups/DepartmentsInGroup.proto
namespace Diadoc.Api.Proto.CounteragentGroups
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CounteragentGroupToUpdate")]
  public partial class CounteragentGroupToUpdate : global::ProtoBuf.IExtensible
  {
    public CounteragentGroupToUpdate() {}
    

    private string _Name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }

    private Diadoc.Api.Proto.CounteragentGroups.CounteragentGroupDepartmentPatch _GroupDepartments = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"GroupDepartments", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.CounteragentGroups.CounteragentGroupDepartmentPatch GroupDepartments
    {
      get { return _GroupDepartments; }
      set { _GroupDepartments = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CounteragentGroupDepartmentPatch")]
  public partial class CounteragentGroupDepartmentPatch : global::ProtoBuf.IExtensible
  {
    public CounteragentGroupDepartmentPatch() {}
    
    private bool _AnyDepartment;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"AnyDepartment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool AnyDepartment
    {
      get { return _AnyDepartment; }
      set { _AnyDepartment = value; }
    }

    private Diadoc.Api.Proto.CounteragentGroups.DepartmentsInGroup _Departments = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Departments", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.CounteragentGroups.DepartmentsInGroup Departments
    {
      get { return _Departments; }
      set { _Departments = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}