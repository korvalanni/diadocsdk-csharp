//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PowersOfAttorney/PowerOfAttorney.proto
// Note: requires additional types generated from: Content_v3.proto
// Note: requires additional types generated from: Timestamp.proto
// Note: requires additional types generated from: User.proto
namespace Diadoc.Api.Proto.PowersOfAttorney
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyFullId")]
  public partial class PowerOfAttorneyFullId : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyFullId() {}
    
    private string _RegistrationNumber;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RegistrationNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RegistrationNumber
    {
      get { return _RegistrationNumber; }
      set { _RegistrationNumber = value; }
    }
    private string _IssuerInn;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"IssuerInn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string IssuerInn
    {
      get { return _IssuerInn; }
      set { _IssuerInn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorney")]
  public partial class PowerOfAttorney : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorney() {}
    
    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId _FullId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FullId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId FullId
    {
      get { return _FullId; }
      set { _FullId = value; }
    }
    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuer _Issuer;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Issuer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuer Issuer
    {
      get { return _Issuer; }
      set { _Issuer = value; }
    }
    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyConfidant _Confidant;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Confidant", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyConfidant Confidant
    {
      get { return _Confidant; }
      set { _Confidant = value; }
    }
    private Diadoc.Api.Proto.Timestamp _StartAt;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"StartAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Timestamp StartAt
    {
      get { return _StartAt; }
      set { _StartAt = value; }
    }
    private Diadoc.Api.Proto.Timestamp _ExpireAt;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ExpireAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Timestamp ExpireAt
    {
      get { return _ExpireAt; }
      set { _ExpireAt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyIssuer")]
  public partial class PowerOfAttorneyIssuer : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyIssuer() {}
    

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerType _Type = Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerType.UnknownIssuerType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerType.UnknownIssuerType)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerLegalEntity _LegalEntity = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LegalEntity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerLegalEntity LegalEntity
    {
      get { return _LegalEntity; }
      set { _LegalEntity = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerForeignEntity _ForeignEntity = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ForeignEntity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerForeignEntity ForeignEntity
    {
      get { return _ForeignEntity; }
      set { _ForeignEntity = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerIndividualEntity _IndividualEntity = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IndividualEntity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerIndividualEntity IndividualEntity
    {
      get { return _IndividualEntity; }
      set { _IndividualEntity = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerPhysicalEntity _PhysicalEntity = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PhysicalEntity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyIssuerPhysicalEntity PhysicalEntity
    {
      get { return _PhysicalEntity; }
      set { _PhysicalEntity = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyIssuerLegalEntity")]
  public partial class PowerOfAttorneyIssuerLegalEntity : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyIssuerLegalEntity() {}
    
    private string _Inn;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }
    private string _Kpp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Kpp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Kpp
    {
      get { return _Kpp; }
      set { _Kpp = value; }
    }
    private string _OrganizationName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OrganizationName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OrganizationName
    {
      get { return _OrganizationName; }
      set { _OrganizationName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyIssuerForeignEntity")]
  public partial class PowerOfAttorneyIssuerForeignEntity : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyIssuerForeignEntity() {}
    

    private string _Inn = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }

    private string _Kpp = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Kpp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Kpp
    {
      get { return _Kpp; }
      set { _Kpp = value; }
    }
    private string _OrganizationName;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OrganizationName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OrganizationName
    {
      get { return _OrganizationName; }
      set { _OrganizationName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyIssuerIndividualEntity")]
  public partial class PowerOfAttorneyIssuerIndividualEntity : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyIssuerIndividualEntity() {}
    
    private string _Inn;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }

    private Diadoc.Api.Proto.FullName _PersonName = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PersonName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.FullName PersonName
    {
      get { return _PersonName; }
      set { _PersonName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyIssuerPhysicalEntity")]
  public partial class PowerOfAttorneyIssuerPhysicalEntity : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyIssuerPhysicalEntity() {}
    
    private string _Inn;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }

    private Diadoc.Api.Proto.FullName _PersonName = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PersonName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.FullName PersonName
    {
      get { return _PersonName; }
      set { _PersonName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyConfidant")]
  public partial class PowerOfAttorneyConfidant : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyConfidant() {}
    
    private Diadoc.Api.Proto.FullName _PersonName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"PersonName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.FullName PersonName
    {
      get { return _PersonName; }
      set { _PersonName = value; }
    }
    private string _Inn;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyConfidantOrganization _Organization = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Organization", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyConfidantOrganization Organization
    {
      get { return _Organization; }
      set { _Organization = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyConfidantOrganization")]
  public partial class PowerOfAttorneyConfidantOrganization : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyConfidantOrganization() {}
    
    private string _Inn;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }

    private string _Kpp = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Kpp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Kpp
    {
      get { return _Kpp; }
      set { _Kpp = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyToRegister")]
  public partial class PowerOfAttorneyToRegister : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyToRegister() {}
    

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId _FullId = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"FullId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId FullId
    {
      get { return _FullId; }
      set { _FullId = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent _Content = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneySignedContent Content
    {
      get { return _Content; }
      set { _Content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneySignedContent")]
  public partial class PowerOfAttorneySignedContent : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneySignedContent() {}
    
    private Diadoc.Api.Proto.Content_v3 _Content;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Content_v3 Content
    {
      get { return _Content; }
      set { _Content = value; }
    }
    private Diadoc.Api.Proto.Content_v3 _Signature;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Content_v3 Signature
    {
      get { return _Signature; }
      set { _Signature = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyRegisterResult")]
  public partial class PowerOfAttorneyRegisterResult : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyRegisterResult() {}
    
    private string _OperationStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"OperationStatus", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationStatus
    {
      get { return _OperationStatus; }
      set { _OperationStatus = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorney _PowerOfAttorney = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PowerOfAttorney", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorney PowerOfAttorney
    {
      get { return _PowerOfAttorney; }
      set { _PowerOfAttorney = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyStatus _Status = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyStatus Status
    {
      get { return _Status; }
      set { _Status = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyOperationError> _Errors = new global::System.Collections.Generic.List<Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyOperationError>();
    [global::ProtoBuf.ProtoMember(4, Name=@"Errors", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyOperationError> Errors
    {
      get { return _Errors; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyStatus")]
  public partial class PowerOfAttorneyStatus : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyStatus() {}
    
    private string _Status;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Status
    {
      get { return _Status; }
      set { _Status = value; }
    }

    private Diadoc.Api.Proto.Timestamp _LastCheckAt = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LastCheckAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp LastCheckAt
    {
      get { return _LastCheckAt; }
      set { _LastCheckAt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyOperationError")]
  public partial class PowerOfAttorneyOperationError : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyOperationError() {}
    
    private string _Code;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Code
    {
      get { return _Code; }
      set { _Code = value; }
    }
    private string _Text;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Text
    {
      get { return _Text; }
      set { _Text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyIssuerType")]
    public enum PowerOfAttorneyIssuerType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownIssuerType", Value=0)]
      UnknownIssuerType = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LegalEntity", Value=1)]
      LegalEntity = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ForeignEntity", Value=2)]
      ForeignEntity = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IndividualEntity", Value=3)]
      IndividualEntity = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PhysicalEntity", Value=4)]
      PhysicalEntity = 4
    }
  
}