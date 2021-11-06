// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TestServiceProtoFile.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TestServiceProtoFile.proto</summary>
public static partial class TestServiceProtoFileReflection {

  #region Descriptor
  /// <summary>File descriptor for TestServiceProtoFile.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TestServiceProtoFileReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpUZXN0U2VydmljZVByb3RvRmlsZS5wcm90byItCgdUZXN0UmVxEhEKCXVz",
          "ZXJfbmFtZRgBIAEoCRIPCgd1c2VyX2lkGAIgASgFIkkKCFRlc3RSZXNwEhQK",
          "DGNvbXBhbnlfbmFtZRgBIAEoCRITCgtkZXNpZ25hdGlvbhgCIAEoCRISCgpz",
          "YWxhcnlfZXVyGAMgASgFMi0KB1Rlc3RpbmcSIgoLVGVzdFNlcnZpY2USCC5U",
          "ZXN0UmVxGgkuVGVzdFJlc3BiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TestReq), global::TestReq.Parser, new[]{ "UserName", "UserId" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::TestResp), global::TestResp.Parser, new[]{ "CompanyName", "Designation", "SalaryEur" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TestReq : pb::IMessage<TestReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TestReq> _parser = new pb::MessageParser<TestReq>(() => new TestReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TestReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TestServiceProtoFileReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestReq(TestReq other) : this() {
    userName_ = other.userName_;
    userId_ = other.userId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestReq Clone() {
    return new TestReq(this);
  }

  /// <summary>Field number for the "user_name" field.</summary>
  public const int UserNameFieldNumber = 1;
  private string userName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string UserName {
    get { return userName_; }
    set {
      userName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "user_id" field.</summary>
  public const int UserIdFieldNumber = 2;
  private int userId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int UserId {
    get { return userId_; }
    set {
      userId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TestReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TestReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (UserName != other.UserName) return false;
    if (UserId != other.UserId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (UserName.Length != 0) hash ^= UserName.GetHashCode();
    if (UserId != 0) hash ^= UserId.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (UserName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(UserName);
    }
    if (UserId != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(UserId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (UserName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(UserName);
    }
    if (UserId != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(UserId);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (UserName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(UserName);
    }
    if (UserId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(UserId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TestReq other) {
    if (other == null) {
      return;
    }
    if (other.UserName.Length != 0) {
      UserName = other.UserName;
    }
    if (other.UserId != 0) {
      UserId = other.UserId;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          UserName = input.ReadString();
          break;
        }
        case 16: {
          UserId = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          UserName = input.ReadString();
          break;
        }
        case 16: {
          UserId = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class TestResp : pb::IMessage<TestResp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TestResp> _parser = new pb::MessageParser<TestResp>(() => new TestResp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TestResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TestServiceProtoFileReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestResp(TestResp other) : this() {
    companyName_ = other.companyName_;
    designation_ = other.designation_;
    salaryEur_ = other.salaryEur_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TestResp Clone() {
    return new TestResp(this);
  }

  /// <summary>Field number for the "company_name" field.</summary>
  public const int CompanyNameFieldNumber = 1;
  private string companyName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string CompanyName {
    get { return companyName_; }
    set {
      companyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "designation" field.</summary>
  public const int DesignationFieldNumber = 2;
  private string designation_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Designation {
    get { return designation_; }
    set {
      designation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "salary_eur" field.</summary>
  public const int SalaryEurFieldNumber = 3;
  private int salaryEur_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int SalaryEur {
    get { return salaryEur_; }
    set {
      salaryEur_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TestResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TestResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CompanyName != other.CompanyName) return false;
    if (Designation != other.Designation) return false;
    if (SalaryEur != other.SalaryEur) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (CompanyName.Length != 0) hash ^= CompanyName.GetHashCode();
    if (Designation.Length != 0) hash ^= Designation.GetHashCode();
    if (SalaryEur != 0) hash ^= SalaryEur.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (CompanyName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(CompanyName);
    }
    if (Designation.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Designation);
    }
    if (SalaryEur != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(SalaryEur);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (CompanyName.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(CompanyName);
    }
    if (Designation.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Designation);
    }
    if (SalaryEur != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(SalaryEur);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (CompanyName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(CompanyName);
    }
    if (Designation.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Designation);
    }
    if (SalaryEur != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(SalaryEur);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TestResp other) {
    if (other == null) {
      return;
    }
    if (other.CompanyName.Length != 0) {
      CompanyName = other.CompanyName;
    }
    if (other.Designation.Length != 0) {
      Designation = other.Designation;
    }
    if (other.SalaryEur != 0) {
      SalaryEur = other.SalaryEur;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          CompanyName = input.ReadString();
          break;
        }
        case 18: {
          Designation = input.ReadString();
          break;
        }
        case 24: {
          SalaryEur = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          CompanyName = input.ReadString();
          break;
        }
        case 18: {
          Designation = input.ReadString();
          break;
        }
        case 24: {
          SalaryEur = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
