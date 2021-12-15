using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Event;
using Prism.Events;
using System.Threading.Tasks;
using System;
using System.Windows.Input;
using Prism.Commands;
using FriendOrganizer.UI.Wrapper;

namespace FriendOrganizer.UI.ViewModel
{
    public class FriendDetailViewModel : ViewModelBase, IFriendDetailViewModel
    {
        private IFriendDataService _dataService;
        private IEventAggregator _eventAggregator;
        private FriendWrapper _friend;

        public FriendDetailViewModel(
            IFriendDataService dataService,
          IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<OpenFriendDetailViewEvent>()
              .Subscribe(OnOpenFriendDetailView);

            SaveCommand = new DelegateCommand(OnSaveExecuteAsync, OnSaveCanExecute);
        }        

        public async Task LoadAsync(int friendId)
        {
            var friend = await _dataService.GetByIdAsync(friendId);
            Friend = new FriendWrapper(friend);            
        }

        public FriendWrapper Friend
        {
            get { return _friend; }
            private set
            {
                _friend = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        private bool OnSaveCanExecute()
        {
            //TODO: check if friend is valid
            return true;
        }

        private async void OnSaveExecuteAsync()
        {
            await _dataService.SaveAsync(Friend.Model);
            _eventAggregator.GetEvent<AfterFriendSavedEvent>()
            .Publish(new AfterFriendSavedEventArgs
            {
                FriendId = Friend.Id,
                DisplayMemeber = Friend.FirstName + " " + Friend.LastName
            });
        }

        private async void OnOpenFriendDetailView(int friendId)
        {
            await LoadAsync(friendId);
        }
    }
}
