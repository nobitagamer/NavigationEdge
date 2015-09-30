﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Http.ValueProviders;

namespace NavigationEdgeApi.Navigation
{
	public class DataValueProvider : IValueProvider
	{
		private Dictionary<string, ValueProviderResult> _values = new Dictionary<string, ValueProviderResult>();

		public DataValueProvider(dynamic data)
		{
			foreach (var item in data)
			{
				_values[item.Key] = new ValueProviderResult(item.Value, Convert.ToString(item.Value, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
			}
		}

		public bool ContainsPrefix(string prefix)
		{
			return false;
		}

		public ValueProviderResult GetValue(string key)
		{
			ValueProviderResult result;
			_values.TryGetValue(key, out result);
			return result;
		}
	}
}