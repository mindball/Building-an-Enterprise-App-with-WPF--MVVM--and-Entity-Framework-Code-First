using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Wrapper
{
    public class WrapperBaseClass<T> : NotifyDataErrorInfoBase 
        where T : class 
    {
        public WrapperBaseClass(T model)
        {
            Model = model;  
        }

        public T Model { get; }

        public virtual TValue GetValue<TValue>([CallerMemberName] string propertyName = null)
        {
            return (TValue)typeof(T).GetProperty(propertyName).GetValue(Model);
        }

        public virtual void SetValue<Tvalue>(Tvalue objectValue, [CallerMemberName] string propertyName = null)
        {
            typeof(T).GetProperty(propertyName).SetValue(Model, objectValue);
            OnPropertyChanged(propertyName);
        }
    }
    
}
