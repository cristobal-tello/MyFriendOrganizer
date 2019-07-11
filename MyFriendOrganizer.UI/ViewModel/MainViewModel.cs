using MyFriendOrganizer.Model;
using MyFriendOrganizer.UI.Data;
using System.Collections.ObjectModel;

namespace MyFriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendDataService friendDataService;

        public MainViewModel(IFriendDataService friendDataService)
        {
            this.friendDataService = friendDataService;
        }

        public void Load()
        {
            this.Friends = new ObservableCollection<Friend>(friendDataService.GetAll());
            OnPropertyChanged("Friends");
        }

        public ObservableCollection<Friend> Friends { get; set; }

        private Friend selectedFriend;
        public Friend SelectedFriend
        {
            get
            {
                return this.selectedFriend;
            }
            set
            {
                this.selectedFriend = value;
                OnPropertyChanged();
            }
        }
    }
}
