using Entities;

namespace PracticeEC.Models.PartialViews.Organisms
{
    public class UserCardViewModel
    {
        public Product User { get; set; } = new Product();

        public string classes { get; set; } = "";
    }
}
