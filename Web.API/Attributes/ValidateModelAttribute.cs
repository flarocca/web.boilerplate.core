using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Web.TORCHx.Core.Web.API
{
	public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
			//Check for null models. To be fixed in https://github.com/aspnet/Mvc/pull/6055
			var nullErrors = GetNullErrors(context.ActionArguments);
			if (nullErrors.Any()) {
				context.Result = new FailureResult(nullErrors);
				return;
			}

			//Check for invalid models
			var validationErrors = GetValidationErrors(context.ModelState);
			if (validationErrors.Any()) {
				context.Result = new FailureResult(validationErrors);
				return;
			}
		}

		private IEnumerable<Failure> GetNullErrors(IDictionary<string, object> actionArguments)
		{
			return actionArguments
				.Where(i => i.Value == null)
				.Select(i => new Failure(i.Key, string.Format("The {0} object is required.", i.Key)));
		}

		private IEnumerable<Failure> GetValidationErrors(ModelStateDictionary modelState)
		{
			return modelState.Keys.SelectMany(i => modelState[i].Errors.Select(e => new Failure(i, e.ErrorMessage)));
		}
    }
}
