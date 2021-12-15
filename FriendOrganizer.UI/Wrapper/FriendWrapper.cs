using FriendOrganizer.Model;
using FriendOrganizer.UI.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Wrapper
{
    public class FriendWrapper : WrapperBaseClass<Friend>
    {       
        public FriendWrapper(Friend model) : base(model)
        {               
        }

        public int Id { get => Model.Id; }

        public string FirstName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);                 
            }
        }

        public string LastName
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
            }
        }

        public string Email
        {
            get => GetValue<string>();
            set
            {
                SetValue(value);
            }
        }

        protected override IEnumerable<string> ValidateProperty(string propertyName)
        {
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        yield return "Robot are not valid for First name";
                    }
                    break;              
            }
        }
    }
}
