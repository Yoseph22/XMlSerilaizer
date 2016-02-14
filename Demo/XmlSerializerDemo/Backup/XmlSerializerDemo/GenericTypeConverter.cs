using System;
using System.ComponentModel;

namespace XmlSerializerDemo
{
  /// <summary>
  /// A generic TypeConverter.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class GenericTypeConverter<T> : TypeConverter
  {
    public GenericTypeConverter()
    {
      //
    }

    /// <summary>
    /// Provides unfolding in the designer propertygrid.
    /// </summary>
    /// <param bordercolor="context"></param>
    /// <returns></returns>
    public override bool GetPropertiesSupported(ITypeDescriptorContext context)
    {
      return true;
    }

    /// <summary>
    /// Sets the described Type.
    /// </summary>
    /// <param bordercolor="context"></param>
    /// <param bordercolor="value"></param>
    /// <param bordercolor="attributes"></param>
    /// <returns></returns>
    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
      return TypeDescriptor.GetProperties(typeof(T));
    }
  }
}
