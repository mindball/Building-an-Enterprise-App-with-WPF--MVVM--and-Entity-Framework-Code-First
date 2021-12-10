using FriendOrganizer.DataAccess;
using FriendOrginizer.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    //TODO: make it a generic
    public class FriendDataService : IFriendDataService //IFriendDataService<Friend>
    {
        private readonly FriendOrganizerDbContext dbContext;

        public FriendDataService(FriendOrganizerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //TODO: Load data from real DB
        public async Task<IList<Friend>> GetAllAsync()
        {
           using(var context = new FriendOrganizerDbContext())
            {
                var friends = await context.Friends.ToListAsync();

                await Task.Delay(5000);

                return friends;
            }
        }
    }
}
