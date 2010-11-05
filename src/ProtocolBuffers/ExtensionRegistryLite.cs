#region Copyright notice and license
// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
// http://github.com/jskeet/dotnet-protobufs/
// Original C++/Java/Python code:
// http://code.google.com/p/protobuf/
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

using System.Collections.Generic;
using System;

namespace Google.ProtocolBuffers {


  /// <summary>
  /// A table of known extensions, searchable by name or field number.  When
  /// parsing a protocol message that might have extensions, you must provide
  /// an <see cref="ExtensionRegistryLite"/> in which you have registered any extensions
  /// that you want to be able to parse.  Otherwise, those extensions will just
  /// be treated like unknown fields.
  /// </summary>
  /// <example>
  /// For example, if you had the <c>.proto</c> file:
  /// <code>
  /// option java_class = "MyProto";
  ///
  /// message Foo {
  ///   extensions 1000 to max;
  /// }
  ///
  /// extend Foo {
  ///   optional int32 bar;
  /// }
  /// </code>
  ///
  /// Then you might write code like:
  ///
  /// <code>
  /// ExtensionRegistryLite registry = ExtensionRegistryLite.CreateInstance();
  /// registry.Add(MyProto.Bar);
  /// MyProto.Foo message = MyProto.Foo.ParseFrom(input, registry);
  /// </code>
  /// </example>
  ///
  /// <remarks>
  /// <para>You might wonder why this is necessary. Two alternatives might come to
  /// mind. First, you might imagine a system where generated extensions are
  /// automatically registered when their containing classes are loaded. This
  /// is a popular technique, but is bad design; among other things, it creates a
  /// situation where behavior can change depending on what classes happen to be
  /// loaded. It also introduces a security vulnerability, because an
  /// unprivileged class could cause its code to be called unexpectedly from a
  /// privileged class by registering itself as an extension of the right type.
  /// </para>
  /// <para>Another option you might consider is lazy parsing: do not parse an
  /// extension until it is first requested, at which point the caller must
  /// provide a type to use. This introduces a different set of problems. First,
  /// it would require a mutex lock any time an extension was accessed, which
  /// would be slow. Second, corrupt data would not be detected until first
  /// access, at which point it would be much harder to deal with it. Third, it
  /// could violate the expectation that message objects are immutable, since the
  /// type provided could be any arbitrary message class. An unprivileged user
  /// could take advantage of this to inject a mutable object into a message
  /// belonging to privileged code and create mischief.</para>
  /// </remarks>
  public class ExtensionRegistryLite {

    private static readonly ExtensionRegistryLite empty = new ExtensionRegistryLite(
        new Dictionary<ExtensionIntPair, IGeneratedExtensionLite>(),
        true);

    protected readonly IDictionary<ExtensionIntPair, IGeneratedExtensionLite> extensionsByNumber;
    protected readonly bool readOnly;

    protected ExtensionRegistryLite(IDictionary<ExtensionIntPair, IGeneratedExtensionLite> extensionsByNumber,
        bool readOnly) {
      this.extensionsByNumber = extensionsByNumber;
      this.readOnly = readOnly;
    }

    /// <summary>
    /// Construct a new, empty instance.
    /// </summary>
    public static ExtensionRegistryLite CreateInstance() {
      return new ExtensionRegistryLite(
        new Dictionary<ExtensionIntPair, IGeneratedExtensionLite>(), false);
    }

    /// <summary>
    /// Get the unmodifiable singleton empty instance.
    /// </summary>
    public static ExtensionRegistryLite Empty {
      get { return empty; }
    }

    public virtual ExtensionRegistryLite AsReadOnly() {
      return new ExtensionRegistryLite(extensionsByNumber, true);
    }

    /// <summary>
    /// Finds an extension by containing type and field number.
    /// A null reference is returned if the extension can't be found.
    /// </summary>
    public IGeneratedExtensionLite this[IMessageLite containingType, int fieldNumber] {
      get {
        IGeneratedExtensionLite ret;
        extensionsByNumber.TryGetValue(new ExtensionIntPair(containingType, fieldNumber), out ret);
        return ret;
      }
    }

    /// <summary>
    /// Add an extension from a generated file to the registry.
    /// </summary>
    public virtual void Add(IGeneratedExtensionLite extension) {
      if (readOnly) {
        throw new InvalidOperationException("Cannot add entries to a read-only extension registry");
      }
      extensionsByNumber.Add(
        new ExtensionIntPair(extension.ContainingType, extension.Number),
        extension);
    }

    /// <summary>
    /// Nested type just used to represent a pair of MessageDescriptor and int, as
    /// the key into the "by number" map.
    /// </summary>
    protected struct ExtensionIntPair : IEquatable<ExtensionIntPair> {
      readonly object msgType;
      readonly int number;

      internal ExtensionIntPair(object msgType, int number) {
        this.msgType = msgType;
        this.number = number;
      }

      public override int GetHashCode() {
        return msgType.GetHashCode() * ((1 << 16) - 1) + number;
      }

      public override bool Equals(object obj) {
        if (!(obj is ExtensionIntPair)) {
          return false;
        }
        return Equals((ExtensionIntPair)obj);
      }

      public bool Equals(ExtensionIntPair other) {
        return msgType.Equals(other.msgType) && number == other.number;
      }
    }
  }
}