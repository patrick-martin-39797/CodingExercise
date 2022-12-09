namespace SampleApp
{
    public abstract class CartItem
    {
        public string Description { get; set; }
        public decimal? UnitPrice { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal? Weight { get; set; }

        public CartItem WithDescription(string description)
        {
            this.Description = description;
            return this;
        }

        public CartItem WithUnitPrice(decimal unitPrice)
        {
            this.UnitPrice = unitPrice;
            return this;
        }

        public CartItem WithQuantity(int quantity)
        {
            this.Quantity = quantity;
            return this;
        }
        
        public CartItem WithWeight(decimal weight)
        {
            this.Weight = weight;
            return this;
        }

    }
}