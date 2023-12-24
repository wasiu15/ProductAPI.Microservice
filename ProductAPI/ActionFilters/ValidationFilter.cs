using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductDomain.Dtos.Request;

namespace ProductAPI.ActionFilters
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var model = context.ActionArguments["model"]; // Retrieve the model from action arguments

            if (model == null)
            {
                context.Result = new BadRequestObjectResult("Model is null"); // Return a 400 Bad Request response
                return;
            }

            // Custom validation logic
            if (!(model is CreateProductDto yourModel)) // Replace YourModelType with your model type
            {
                context.Result = new BadRequestObjectResult("Invalid model type"); // Return a 400 Bad Request response
                return;
            }

            if (string.IsNullOrWhiteSpace(yourModel.Name))
            {
                context.Result = new BadRequestObjectResult("Name is required"); // Return a 400 Bad Request response
                return;
            }

            //  FOR MODEL VALIDATION
            var modelState = context.ModelState;

            if (!modelState.IsValid)
            {
                var errors = modelState
                    .Where(ms => ms.Value.Errors.Any())
                    .SelectMany(ms => ms.Value.Errors.Select(e => new
                    {
                        Field = ms.Key,
                        ErrorMessage = e.ErrorMessage
                    }))
                    .ToList();

                context.Result = new BadRequestObjectResult(errors);
            }
        }
    }
}
