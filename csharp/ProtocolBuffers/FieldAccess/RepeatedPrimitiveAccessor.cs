// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.
// http://code.google.com/p/protobuf/
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections;
using System.Reflection;

namespace Google.ProtocolBuffers.FieldAccess {
  /// <summary>
  /// Accesor for a repeated field of type int, ByteString etc.
  /// </summary>
  internal class RepeatedPrimitiveAccessor : IFieldAccessor {

    private readonly PropertyInfo messageProperty;
    private readonly PropertyInfo builderProperty;
    private readonly PropertyInfo countProperty;
    private readonly MethodInfo clearMethod;
    private readonly MethodInfo addMethod;
    private readonly MethodInfo getElementMethod;
    private readonly MethodInfo setElementMethod;

    /// <summary>
    /// The CLR type of the field (int, the enum type, ByteString, the message etc).
    /// This is taken from the return type of the method used to retrieve a single
    /// value.
    /// </summary>
    protected Type ClrType {
      get { return getElementMethod.ReturnType; }
    }

    internal RepeatedPrimitiveAccessor(string name, Type messageType, Type builderType) {      
      messageProperty = messageType.GetProperty(name + "List");
      builderProperty = builderType.GetProperty(name + "List");
      countProperty = messageType.GetProperty(name + "Count");
      clearMethod = builderType.GetMethod("Clear" + name);
      getElementMethod = messageType.GetMethod("Get" + name, new Type[] { typeof(int) });
      addMethod = builderType.GetMethod("Add" + name, new Type[] { ClrType });
      setElementMethod = builderType.GetMethod("Set" + name, new Type[] { typeof(int), ClrType });
      if (messageProperty == null 
          || builderProperty == null 
          || countProperty == null
          || clearMethod == null
          || addMethod == null
          || getElementMethod == null
          || setElementMethod == null) {
        throw new ArgumentException("Not all required properties/methods available");
      }
    }

    public bool Has(IMessage message) {
      throw new InvalidOperationException();
    }
    
    public virtual IBuilder CreateBuilder() {
      throw new InvalidOperationException();
    }

    public virtual object GetValue(IMessage message) {
      return messageProperty.GetValue(message, null);
    }

    public void SetValue(IBuilder builder, object value) {
      // Add all the elements individually.  This serves two purposes:
      // 1) Verifies that each element has the correct type.
      // 2) Insures that the caller cannot modify the list later on and
      //    have the modifications be reflected in the message.
      Clear(builder);
      foreach (object element in (IEnumerable) value) {
        AddRepeated(builder, element);
      }
    }

    public void Clear(IBuilder builder) {
      clearMethod.Invoke(builder, null);
    }

    public int GetRepeatedCount(IMessage message) {
      return (int) countProperty.GetValue(message, null);
    }

    public virtual object GetRepeatedValue(IMessage message, int index) {
      return getElementMethod.Invoke(message, new object[] {index } );
    }

    public virtual void SetRepeated(IBuilder builder, int index, object value) {
      setElementMethod.Invoke(builder, new object[] {index, value} );
    }

    public virtual void AddRepeated(IBuilder builder, object value) {
      addMethod.Invoke(builder, new object[] { value });
    }

    /// <summary>
    /// The builder class's accessor already builds a read-only wrapper for
    /// us, which is exactly what we want.
    /// </summary>
    public object GetRepeatedWrapper(IBuilder builder) {
      return builderProperty.GetValue(builder, null);
    }
  }
}