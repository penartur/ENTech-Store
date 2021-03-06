﻿using System.ComponentModel.DataAnnotations;
using ENTech.Store.Infrastructure.Services.Validators;
using ENTech.Store.Services.Internal.StoreModule.Commands.Criterias;

namespace ENTech.Store.Services.External.ForCustomer.StoreModule.Dtos
{
	public class SortFieldDto
	{
		/// <summary>
		/// Possible values: see enum <see cref="ProductCriteria.SortField"/>
		/// </summary>
		[Required(ErrorMessage = RequestValidatorErrorMessage.Required)]
		public string SortField { get; set; }

		[Required(ErrorMessage = RequestValidatorErrorMessage.Required)]
		public bool? IsDescending { get; set; }
	}
}
