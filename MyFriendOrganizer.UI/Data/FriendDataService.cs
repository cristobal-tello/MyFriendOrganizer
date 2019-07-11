using MyFriendOrganizer.Model;
using System.Collections.Generic;

namespace MyFriendOrganizer.UI.Data
{
    public class FriendDataService
    {
        IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Leo", LastName = "Messi" };
            yield return new Friend { FirstName = "Cristiano", LastName = "Ronaldo" };
            yield return new Friend { FirstName = "Carles", LastName = "Puyol" };
            yield return new Friend { FirstName = "Santiago", LastName = "Cañizares" };
            yield return new Friend { FirstName = "Rubén", LastName = "Pérez" };
        }
    }
}
