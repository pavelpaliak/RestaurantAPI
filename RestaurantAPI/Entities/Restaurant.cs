namespace RestaurantAPI.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }
        public bool ContactEmail { get; set; }
        public bool ContactNumber { get; set; }


        public int AdressId { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual List<Dish> Dishes { get; set; }
    }
}
