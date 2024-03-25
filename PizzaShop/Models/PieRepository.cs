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
            Pie pie3 = new Pie(3, "Burek", "Mastan burek za svaki dan", 6.5m, false, false);
            Pies.Add(pie3);

            Pie pie4= new Pie(4, "Pita sa sirom", "Po starinskom receptu", 1.25m, true, true);
            Pies.Add(pie4);
            Pie pie5 = new Pie(1, "Pita sa krompirom", "posno i vegansko", (decimal)1.25, true, true);
            Pies.Add(pie5);
            Pie pie6 = new Pie(2, "štrudla sa orasima", "Velika štrudla sa orasima", (decimal)8.35, true, false);
            Pies.Add(pie6);
            Pie pie7 = new Pie(3, "Burek sa sirom", "Mastan burek sa sirom", 6.5m, false, false);
            Pies.Add(pie7);

            Pie pie8 = new Pie(4, "Pita sa zeljem", "Po starinskom receptu", 1.25m, true, true);
            Pies.Add(pie8);

            Pie pie9 = new Pie(1, "Pita sa kačkavaljem", "Italijanski ukusi", (decimal)1.25, true, true);
            Pies.Add(pie9);
            Pie pie10 = new Pie(2, "Američka pita", "Sa svežim voćem", (decimal)8.35, true, false);
            Pies.Add(pie10);
            Pie pie11 = new Pie(3, "Burek sa prečurkama", "Zdravo i ukusno", 6.5m, false, false);
            Pies.Add(pie11);

            Pie pie12 = new Pie(4, "Pita sa višnjama", "Po starinskom receptu", 1.25m, true, true);
            Pies.Add(pie12);


            foreach (var pie in Pies)
            {
                pie.Category = new Category(4, "Veganske pite", "prfipremljeno sveže za vas");
            }


        }
    }
}
