// Generated by the protocol buffer compiler.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.DescriptorProtos {
  
  public static partial class CSharpOptions {
  
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static readonly pbd::FileDescriptor descriptor = pbd::FileDescriptor.InternalBuildGeneratedFileFrom(
        global::System.Convert.FromBase64String(
        "CiRnb29nbGUvcHJvdG9idWYvY3NoYXJwX29wdGlvbnMucHJvdG8SD2dvb2ds" + 
        "ZS5wcm90b2J1ZhogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG8i" + 
        "4wEKEUNTaGFycEZpbGVPcHRpb25zEhEKCW5hbWVzcGFjZRgBIAEoCRIaChJ1" + 
        "bWJyZWxsYV9jbGFzc25hbWUYAiABKAkSFgoOcHVibGljX2NsYXNzZXMYAyAB" + 
        "KAgSFgoObXVsdGlwbGVfZmlsZXMYBCABKAgSFAoMbmVzdF9jbGFzc2VzGAUg" + 
        "ASgIMlkKDmNzaGFycF9vcHRpb25zEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVP" + 
        "cHRpb25zGOgHIAEoCzIiLmdvb2dsZS5wcm90b2J1Zi5DU2hhcnBGaWxlT3B0" + 
        "aW9ucyKIAQoSQ1NoYXJwRmllbGRPcHRpb25zEhUKDXByb3BlcnR5X25hbWUY" + 
        "ASABKAkyWwoOY3NoYXJwX29wdGlvbnMSHS5nb29nbGUucHJvdG9idWYuRmll" + 
        "bGRPcHRpb25zGOgHIAEoCzIjLmdvb2dsZS5wcm90b2J1Zi5DU2hhcnBGaWVs" + 
        "ZE9wdGlvbnM="),
        new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.DescriptorProtoFile.Descriptor, 
        });
    #endregion
    
    #region Static variables
    internal static readonly pbd::MessageDescriptor internal__static_google_protobuf_CSharpFileOptions__Descriptor
        = Descriptor.MessageTypes[0];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFileOptions, global::Google.ProtocolBuffers.DescriptorProtos.CSharpFileOptions.Builder> internal__static_google_protobuf_CSharpFileOptions__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFileOptions, global::Google.ProtocolBuffers.DescriptorProtos.CSharpFileOptions.Builder>(internal__static_google_protobuf_CSharpFileOptions__Descriptor,
            new string[] { "Namespace", "UmbrellaClassname", "PublicClasses", "MultipleFiles", "NestClasses", });
    internal static readonly pbd::MessageDescriptor internal__static_google_protobuf_CSharpFieldOptions__Descriptor
        = Descriptor.MessageTypes[1];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFieldOptions, global::Google.ProtocolBuffers.DescriptorProtos.CSharpFieldOptions.Builder> internal__static_google_protobuf_CSharpFieldOptions__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFieldOptions, global::Google.ProtocolBuffers.DescriptorProtos.CSharpFieldOptions.Builder>(internal__static_google_protobuf_CSharpFieldOptions__Descriptor,
            new string[] { "PropertyName", });
    #endregion
  }
  #region Messages
  public sealed partial class CSharpFileOptions : pb::GeneratedMessage<CSharpFileOptions, CSharpFileOptions.Builder> {
    private static readonly CSharpFileOptions defaultInstance = new Builder().BuildPartial();
    public static CSharpFileOptions DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override CSharpFileOptions DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override CSharpFileOptions ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.internal__static_google_protobuf_CSharpFileOptions__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<CSharpFileOptions, CSharpFileOptions.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.internal__static_google_protobuf_CSharpFileOptions__FieldAccessorTable; }
    }
    
    public static readonly pb::GeneratedExtensionBase<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFileOptions> CSharpOptions =
        pb::GeneratedSingleExtension<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFileOptions>.CreateInstance(Descriptor.Extensions[0]);
    private bool hasNamespace;
    private string namespace_ = "";
    public bool HasNamespace {
      get { return hasNamespace; }
    }
    public string Namespace {
      get { return namespace_; }
    }
    
    private bool hasUmbrellaClassname;
    private string umbrellaClassname_ = "";
    public bool HasUmbrellaClassname {
      get { return hasUmbrellaClassname; }
    }
    public string UmbrellaClassname {
      get { return umbrellaClassname_; }
    }
    
    private bool hasPublicClasses;
    private bool publicClasses_ = false;
    public bool HasPublicClasses {
      get { return hasPublicClasses; }
    }
    public bool PublicClasses {
      get { return publicClasses_; }
    }
    
    private bool hasMultipleFiles;
    private bool multipleFiles_ = false;
    public bool HasMultipleFiles {
      get { return hasMultipleFiles; }
    }
    public bool MultipleFiles {
      get { return multipleFiles_; }
    }
    
    private bool hasNestClasses;
    private bool nestClasses_ = false;
    public bool HasNestClasses {
      get { return hasNestClasses; }
    }
    public bool NestClasses {
      get { return nestClasses_; }
    }
    
    public static CSharpFileOptions ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CSharpFileOptions ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(CSharpFileOptions prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<CSharpFileOptions, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      CSharpFileOptions result = new CSharpFileOptions();
      
      protected override CSharpFileOptions MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new CSharpFileOptions();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return CSharpFileOptions.Descriptor; }
      }
      
      public override CSharpFileOptions DefaultInstanceForType {
        get { return CSharpFileOptions.DefaultInstance; }
      }
      
      public override CSharpFileOptions BuildPartial() {
        CSharpFileOptions returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      public bool HasNamespace {
        get { return result.HasNamespace; }
      }
      public string Namespace {
        get { return result.Namespace; }
        set { SetNamespace(value); }
      }
      public Builder SetNamespace(string value) {
        result.hasNamespace = true;
        result.namespace_ = value;
        return this;
      }
      public Builder ClearNamespace() {
        result.hasNamespace = false;
        result.namespace_ = "";
        return this;
      }
      
      public bool HasUmbrellaClassname {
        get { return result.HasUmbrellaClassname; }
      }
      public string UmbrellaClassname {
        get { return result.UmbrellaClassname; }
        set { SetUmbrellaClassname(value); }
      }
      public Builder SetUmbrellaClassname(string value) {
        result.hasUmbrellaClassname = true;
        result.umbrellaClassname_ = value;
        return this;
      }
      public Builder ClearUmbrellaClassname() {
        result.hasUmbrellaClassname = false;
        result.umbrellaClassname_ = "";
        return this;
      }
      
      public bool HasPublicClasses {
        get { return result.HasPublicClasses; }
      }
      public bool PublicClasses {
        get { return result.PublicClasses; }
        set { SetPublicClasses(value); }
      }
      public Builder SetPublicClasses(bool value) {
        result.hasPublicClasses = true;
        result.publicClasses_ = value;
        return this;
      }
      public Builder ClearPublicClasses() {
        result.hasPublicClasses = false;
        result.publicClasses_ = false;
        return this;
      }
      
      public bool HasMultipleFiles {
        get { return result.HasMultipleFiles; }
      }
      public bool MultipleFiles {
        get { return result.MultipleFiles; }
        set { SetMultipleFiles(value); }
      }
      public Builder SetMultipleFiles(bool value) {
        result.hasMultipleFiles = true;
        result.multipleFiles_ = value;
        return this;
      }
      public Builder ClearMultipleFiles() {
        result.hasMultipleFiles = false;
        result.multipleFiles_ = false;
        return this;
      }
      
      public bool HasNestClasses {
        get { return result.HasNestClasses; }
      }
      public bool NestClasses {
        get { return result.NestClasses; }
        set { SetNestClasses(value); }
      }
      public Builder SetNestClasses(bool value) {
        result.hasNestClasses = true;
        result.nestClasses_ = value;
        return this;
      }
      public Builder ClearNestClasses() {
        result.hasNestClasses = false;
        result.nestClasses_ = false;
        return this;
      }
    }
  }
  
  public sealed partial class CSharpFieldOptions : pb::GeneratedMessage<CSharpFieldOptions, CSharpFieldOptions.Builder> {
    private static readonly CSharpFieldOptions defaultInstance = new Builder().BuildPartial();
    public static CSharpFieldOptions DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override CSharpFieldOptions DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override CSharpFieldOptions ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.internal__static_google_protobuf_CSharpFieldOptions__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<CSharpFieldOptions, CSharpFieldOptions.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.internal__static_google_protobuf_CSharpFieldOptions__FieldAccessorTable; }
    }
    
    public static readonly pb::GeneratedExtensionBase<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFieldOptions> CSharpOptions =
        pb::GeneratedSingleExtension<global::Google.ProtocolBuffers.DescriptorProtos.CSharpFieldOptions>.CreateInstance(Descriptor.Extensions[0]);
    private bool hasPropertyName;
    private string propertyName_ = "";
    public bool HasPropertyName {
      get { return hasPropertyName; }
    }
    public string PropertyName {
      get { return propertyName_; }
    }
    
    public static CSharpFieldOptions ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static CSharpFieldOptions ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(CSharpFieldOptions prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<CSharpFieldOptions, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      CSharpFieldOptions result = new CSharpFieldOptions();
      
      protected override CSharpFieldOptions MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new CSharpFieldOptions();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return CSharpFieldOptions.Descriptor; }
      }
      
      public override CSharpFieldOptions DefaultInstanceForType {
        get { return CSharpFieldOptions.DefaultInstance; }
      }
      
      public override CSharpFieldOptions BuildPartial() {
        CSharpFieldOptions returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      public bool HasPropertyName {
        get { return result.HasPropertyName; }
      }
      public string PropertyName {
        get { return result.PropertyName; }
        set { SetPropertyName(value); }
      }
      public Builder SetPropertyName(string value) {
        result.hasPropertyName = true;
        result.propertyName_ = value;
        return this;
      }
      public Builder ClearPropertyName() {
        result.hasPropertyName = false;
        result.propertyName_ = "";
        return this;
      }
    }
  }
  
  #endregion
  
}
