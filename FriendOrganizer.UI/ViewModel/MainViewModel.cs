using FriendOrganizer.UI.Data;
using FriendOrginizer.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //private IFriendDataService<Friend> friendDataService;
        private IFriendDataService friendDataService;
        private Friend friend;
        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            this.friendDataService = friendDataService; 
        }     

        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return this.friend; }
            set 
            { 
                this.friend = value; 
                this.OnPropertyChanged();
            }
        }

        public async Task LoadAsync()
        {
            var friends = await this.friendDataService.GetAllAsync();
            this.Friends.Clear();
            foreach (var friend in friends)
            {
                this.Friends.Add(friend);
            }
        }
    }
}
