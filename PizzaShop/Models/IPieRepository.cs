namespace PizzaShop.Models
{
    public interface IPieRepository
    {
        List<Pie> Pies { get; set; }
        public Pie GetPieById(int pieId);
    }
}
