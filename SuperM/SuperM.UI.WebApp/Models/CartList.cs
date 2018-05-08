namespace SuperM.UI.WebApp.Models
{
    using SuperM.Data.Entities;

    public class CartList
    {
        public int CartListId { get; set; }

        public int CustomId { get; }

        public ShoppingCart ShoppingCart { get; set; }
    }
}
