using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;


namespace SandsBox
{
    public class SandModel : ViewModelBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected override void ValidateFields(List<IFieldValidationResult> validationResults)
        {
            if (!string.IsNullOrEmpty(FirstName))
            {
                validationResults.Add(FieldValidationResult.CreateError(FirstName, "First name cannot be empty"));
            }
        }
    }
}
