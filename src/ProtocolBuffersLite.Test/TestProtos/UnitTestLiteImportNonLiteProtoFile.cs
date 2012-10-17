// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=17b3b1f090c3ea48.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class UnitTestLiteImportNonLiteProtoFile {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    #endregion
    #region Extensions
    internal static readonly object Descriptor;
    static UnitTestLiteImportNonLiteProtoFile() {
      Descriptor = null;
    }
    #endregion
    
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class TestLiteImportsNonlite : pb::GeneratedMessageLite<TestLiteImportsNonlite, TestLiteImportsNonlite.Builder> {
    private TestLiteImportsNonlite() { }
    private static readonly TestLiteImportsNonlite defaultInstance = new TestLiteImportsNonlite().MakeReadOnly();
    private static readonly string[] _testLiteImportsNonliteFieldNames = new string[] { "message" };
    private static readonly uint[] _testLiteImportsNonliteFieldTags = new uint[] { 10 };
    public static TestLiteImportsNonlite DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestLiteImportsNonlite DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override TestLiteImportsNonlite ThisMessage {
      get { return this; }
    }
    
    public const int MessageFieldNumber = 1;
    private bool hasMessage;
    private global::Google.ProtocolBuffers.TestProtos.TestAllTypes message_;
    public bool HasMessage {
      get { return hasMessage; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestAllTypes Message {
      get { return message_ ?? global::Google.ProtocolBuffers.TestProtos.TestAllTypes.DefaultInstance; }
    }
    
    public override bool IsInitialized {
      get {
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _testLiteImportsNonliteFieldNames;
      if (hasMessage) {
        output.WriteMessage(1, field_names[0], Message);
      }
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasMessage) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Message);
        }
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasMessage) hash ^= message_.GetHashCode();
      return hash;
    }
    
    public override bool Equals(object obj) {
      TestLiteImportsNonlite other = obj as TestLiteImportsNonlite;
      if (other == null) return false;
      if (hasMessage != other.hasMessage || (hasMessage && !message_.Equals(other.message_))) return false;
      return true;
    }
    
    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("message", hasMessage, message_, writer);
    }
    #endregion
    
    public static TestLiteImportsNonlite ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestLiteImportsNonlite ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private TestLiteImportsNonlite MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestLiteImportsNonlite prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class Builder : pb::GeneratedBuilderLite<TestLiteImportsNonlite, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(TestLiteImportsNonlite cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private TestLiteImportsNonlite result;
      
      private TestLiteImportsNonlite PrepareBuilder() {
        if (resultIsReadOnly) {
          TestLiteImportsNonlite original = result;
          result = new TestLiteImportsNonlite();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override TestLiteImportsNonlite MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override TestLiteImportsNonlite DefaultInstanceForType {
        get { return global::Google.ProtocolBuffers.TestProtos.TestLiteImportsNonlite.DefaultInstance; }
      }
      
      public override TestLiteImportsNonlite BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is TestLiteImportsNonlite) {
          return MergeFrom((TestLiteImportsNonlite) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(TestLiteImportsNonlite other) {
        if (other == global::Google.ProtocolBuffers.TestProtos.TestLiteImportsNonlite.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasMessage) {
          MergeMessage(other.Message);
        }
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_testLiteImportsNonliteFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _testLiteImportsNonliteFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              global::Google.ProtocolBuffers.TestProtos.TestAllTypes.Builder subBuilder = global::Google.ProtocolBuffers.TestProtos.TestAllTypes.CreateBuilder();
              if (result.hasMessage) {
                subBuilder.MergeFrom(Message);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Message = subBuilder.BuildPartial();
              break;
            }
          }
        }
        
        return this;
      }
      
      
      public bool HasMessage {
       get { return result.hasMessage; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestAllTypes Message {
        get { return result.Message; }
        set { SetMessage(value); }
      }
      public Builder SetMessage(global::Google.ProtocolBuffers.TestProtos.TestAllTypes value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMessage = true;
        result.message_ = value;
        return this;
      }
      public Builder SetMessage(global::Google.ProtocolBuffers.TestProtos.TestAllTypes.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasMessage = true;
        result.message_ = builderForValue.Build();
        return this;
      }
      public Builder MergeMessage(global::Google.ProtocolBuffers.TestProtos.TestAllTypes value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasMessage &&
            result.message_ != global::Google.ProtocolBuffers.TestProtos.TestAllTypes.DefaultInstance) {
            result.message_ = global::Google.ProtocolBuffers.TestProtos.TestAllTypes.CreateBuilder(result.message_).MergeFrom(value).BuildPartial();
        } else {
          result.message_ = value;
        }
        result.hasMessage = true;
        return this;
      }
      public Builder ClearMessage() {
        PrepareBuilder();
        result.hasMessage = false;
        result.message_ = null;
        return this;
      }
    }
    static TestLiteImportsNonlite() {
      object.ReferenceEquals(global::Google.ProtocolBuffers.TestProtos.UnitTestLiteImportNonLiteProtoFile.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
