namespace PizzaShop.Models
{
    public class PieRepository : IPieRepository
    {
        public List<Pie> Pies { get; set; } = new List<Pie>();

        public Pie GetPieById(int pieId)
        {
            foreach (var pie in Pies)
            {
                if (pie.GetPieId() == pieId)

                    return pie;
            }

            return null;
        }

        public PieRepository()
        {
            Pie pie1 = new Pie(1, "Pita sa jabukama", "Mala pita sa jabukama", (decimal)1.25, true, true);
            Pies.Add(pie1);
            Pie pie2 = new Pie(2, "Makovnjača", "Velika štrudla sa makom", (decimal)8.35, true, false);
            Pies.Add(pie2);
            Pie pie3 = new Pie(3, "Burek", "Mastan burek sa sirom", 6.5m, false, false);
            Pies.Add(pie3);
        }
    }
}
