﻿using System;
using System.Linq.Expressions;
using ENTech.Store.Infrastructure.Helpers;

namespace ENTech.Store.Infrastructure.Services.Responses
{
	public class ArgumentError : Error
	{
		public string ArgumentName { get; set; }

		internal ArgumentError(string argumentName, int errorCode, string errorMessage)
			: base(errorCode, errorMessage)
		{
			ArgumentName = argumentName;
		}

		public static ArgumentError For<TObj>(Expression<Func<TObj, object>> expression, string errorMessage, int errorCode)
		{
			return new ArgumentError(PropertyHelper.GetName(expression), errorCode, errorMessage);
		}
	}
}
