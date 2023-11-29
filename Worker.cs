namespace ManagingANewspaper
{
    public class Worker
    {
        public string Name { get; set; }
        public string Pon { get; set; }
        public string Adress { get; set; }
        public float Salary { get; set; } = 0;
        public int Vetek { get; set; }
        public Worker()
        {
            
        }
        public Worker(string name, string pon, string ad, float salary,int vetek)
        {
           
            Name = name;
            Pon = pon;
            Adress = ad;
            Salary = salary;
            Vetek=vetek;
        }
    }
}
