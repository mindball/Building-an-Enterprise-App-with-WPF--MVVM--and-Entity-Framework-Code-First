using FriendOrginizer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public interface IFriendDataService //<T> where T : class
    {
        //IEnumerable<T> GetAlll();
        Task<IList<Friend>> GetAllAsync();
    }
}