using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace actividad_1{
	public static class EnumHelper<T>
    	where T :  Enum
	{	
		private static string? lookupResource(Type? resourceManagerProvider, string? resourceKey)
		{
			if(resourceKey != null){
				var resourceKeyProperty = resourceManagerProvider?.GetProperty(resourceKey,
				BindingFlags.Static | BindingFlags.Public, null, typeof(string),
				new Type[0], null);
				if (resourceKeyProperty != null)
				{
					return resourceKeyProperty.GetMethod?.Invoke(null, null)!.ToString();
				}
			}
			return resourceKey;
		}	 
		public static string? GetDisplayValue(T value)
		{
			var fieldInfo = value.GetType().GetField(value.ToString());

			var descriptionAttributes = fieldInfo?.GetCustomAttributes(
				typeof(DisplayAttribute), false) as DisplayAttribute[];

			if (descriptionAttributes?[0].ResourceType != null)
				return lookupResource(descriptionAttributes[0].ResourceType, descriptionAttributes[0].Name);

			if (descriptionAttributes == null) return string.Empty;
			return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
		}
	}
}