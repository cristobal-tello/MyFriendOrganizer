using MyFriendOrganizer.Model;
using System.Collections.Generic;

namespace MyFriendOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}
