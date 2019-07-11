using MyFriendOrganizer.Model;
using MyFriendOrganizer.UI.Data;
using System.Collections.ObjectModel;

namespace MyFriendOrganizer.UI.ViewModel
{
    class MainViewModel
    {
        IFriendDataService friendDataService;

        public MainViewModel(IFriendDataService friendDataService)
        {
            this.friendDataService = friendDataService;
        }

        public void Load()
        {
            Friends = new ObservableCollection<Friend>(friendDataService.GetAll()); ;
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
            }
        }
    }
}
