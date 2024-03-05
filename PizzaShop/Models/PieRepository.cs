using PizzaShop.Models;

namespace PizzaShop.Models
{
    public class PieRepository : IPieRepository
    {

        public List<Pie> piesCollection { get; set; }

        private List<Pie> pies = new List<Pie>();

        public Pie GetPieById(int PieId)
        {
            foreach ( var pie in pies )
            {
                if (pie.GetPieId() == PieId)
                return pie;
            }
            return null;
        }
        public PieRepository()
        {

            pies = new List<Pie>();

            Pie pie1 = new Pie(1, "Pita sa jabukama", "Mala pita sa jabukama", (decimal)1.25,true, true);
            pies.Add(pie1);
            Pie pie2 = new Pie(2, "Makovnjača", "Velika štrudla sa makom", (decimal)8.35, true, false);
            pies.Add(pie2);
            Pie pie3 = new Pie(3, "Burek", "Mastan burek sa sirom", 6.5m, false, false);
            pies.Add(pie3);
        
        }




    }
}
