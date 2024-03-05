namespace PizzaShop.Models
{
    public interface IPieRepository

    {

        List<Pie> piesCollection { get; set; }
        public Pie GetPieById(int PieId);
    }
}
