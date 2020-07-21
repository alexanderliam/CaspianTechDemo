namespace CaspianTechDemo.Models
{
    public static class MenuItem
    {
        public static OrderItem Cola = new OrderItem
        {
            Name = "Cola",
            Price = 0.5,
            IsHot = false
        };

        public static OrderItem Coffee = new OrderItem
        {
            Name = "Coffee",
            Price = 1,
            IsHot = true
        };

        public static OrderItem CheeseSandwich = new OrderItem
        {
            Name = "Cheese Sandwich",
            Price = 2,
            IsHot = false
        };

        public static OrderItem SteakSandwich = new OrderItem
        {
            Name = "Steak Sandwich",
            Price = 4.5,
            IsHot = true
        };
    }
}
