using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductDomain.Dtos.Request;

namespace ProductAPI.ActionFilters
{
    public class CreateProductValidation : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var model = context.ActionArguments["request"]; // Retrieve the model from action arguments

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
            else if (yourModel.Price < 1)
            {
                context.Result = new BadRequestObjectResult("Price can not be less than 0 (zero)"); // Return a 400 Bad Request response
                return;
            }
            else if (string.IsNullOrWhiteSpace(yourModel.ImageUrl))
            {
                context.Result = new BadRequestObjectResult("Product Image is required"); // Return a 400 Bad Request response
                return;
            }
            else { }    //do nothing

        }
    }
}
