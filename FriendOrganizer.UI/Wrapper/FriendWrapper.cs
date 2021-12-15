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
                ValidateProperty(nameof(FirstName));
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

        private void ValidateProperty(string propertyName)
        {
            ClearErrors(propertyName);
            switch (propertyName)
            {
                case nameof(FirstName):
                    if (string.Equals(FirstName, "Robot", StringComparison.OrdinalIgnoreCase))
                    {
                        AddError(propertyName, "Robot are not valid for First name");
                    }
                    break;
                case nameof(LastName):

                    break;
                case nameof(Email):

                    break;
            }
        }
    }
}
