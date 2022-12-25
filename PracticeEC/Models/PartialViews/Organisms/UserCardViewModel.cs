using Entities;

namespace PracticeEC.Models.PartialViews.Organisms
{
    public class UserCardViewModel
    {
        public User User { get; set; } = new User();

        public string classes { get; set; } = "";
    }
}
