// See https://aka.ms/new-console-template for more information

class program
{
    static void Main(string[] args)
    {
        Proje proje1 = new Proje();
        proje1.Year = "2020/2021";
        proje1.Name = "Ataturk Kultur Merkezi";
        proje1.Position = "Design Architect";
        proje1.Company = "Sembol Construction";

        Proje proje2 = new Proje();
        proje2.Year = "2020/2019";
        proje2.Name = "Portonovi Middle Village ";
        proje2.Position = "Design Architect";
        proje2.Company = "Alp Yapi";


        Proje proje3 = new Proje();
        proje3.Year = "2019/2018";
        proje3.Name = "Istanbul Airport State Guest House ";
        proje3.Position = "Architect";
        proje3.Company = "Alp Yapi";


        Proje proje4 = new Proje();
        proje4.Year = "2018/2017";
        proje4.Name = "Istanbul Airport Terminal Baggage Reclaim and Meeters&Greeters Halls ";
        proje4.Position = "Architect";
        proje4.Company = "Alp Yapi";

        Proje proje5 = new Proje();
        proje5.Year = "2016/2017";
        proje5.Name = "Maltepe Piazza Mall, Office and Residence ";
        proje5.Position = "Junior Design Architect";
        proje5.Company = "Renaissance Construction";

        Proje proje6 = new Proje();
        proje6.Year = "2016/Present";
        proje6.Name = " Mixed Deigns and Examples ";
        proje6.Position = "Designer";
        proje6.Company = "Freelance";



        Proje[] projeler = new Proje[] { proje1, proje2, proje3, proje4, proje5, proje6 };

        foreach (var proje in projeler)
        {
            Console.WriteLine(proje.Year + " - " + proje.Name + " Title " + proje.Position + " " + proje.Company);

        }

    }


}

class Proje
{
    public string Year { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public string Company { get; set; }
}
//Console.WriteLine("Hello, World!");