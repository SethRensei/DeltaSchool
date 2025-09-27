using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DeltaSchool.Utilities;

namespace DeltaSchool.Core
{
    public static class FormValidator
    {
        public static bool Validate<T>(T viewModel)
        {
            var context = new ValidationContext(viewModel);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(viewModel, context, results, true);

            if (!isValid)
            {
                foreach (var error in results)
                {
                    ShowAlert.ErrorMsg(error.ErrorMessage);
                }
            }

            return isValid;
        }
    }
}
