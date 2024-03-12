namespace PizzaShop.Models
{
    public class Pie
    {
        private int PieId;
        private string Name;
        private string Description;
        private decimal Price;
        private bool IsPieOfTheWeek;
        private bool InStock;

        public Pie() { }
        public Pie(int PieId, string Name, string Description, decimal Price, bool IsPieOfTheWeek, bool InStock)
        {
            this.PieId = PieId;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.IsPieOfTheWeek = IsPieOfTheWeek;
            this.InStock = InStock;
        }

        public int GetPieId() { return this.PieId; }
        public string GetName() { return this.Name; }
        public string GetDescription() { return this.Description; }
        public decimal GetPrice() { return this.Price; }
        public bool GetIsPieOfTheWeek() { return this.IsPieOfTheWeek; }
        public bool GetInStock() { return this.InStock; }

        public void SetPieId(int PieId) { this.PieId = PieId; }
        public void SetName(string Name) { this.Name = Name; }
        public void SetDescription(string Description) { this.Description = Description; }
        public void SetPrice(decimal Price) { this.Price = Price; }
        public void SetIsPieOfTheWeek(bool IsPieOfTheWeek) { this.IsPieOfTheWeek = IsPieOfTheWeek; }
        public void SetInStock(bool InStock) { this.InStock = InStock; }

    }

}
