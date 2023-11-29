namespace ManagingANewspaper
{
    
    public class Designer:Worker
    {
        static int num = 0;
        public int Id { get; set; }

        public bool IsDesigningAi { get; set; } = true;
        public Designer()
        {
            Id = num++;
        }
        public Designer(bool isDesigningAi,string name,string pon ,string ad,float salary=0, int vetek = 0) : base(name, pon, ad, salary, vetek)
        {
            Id = num++;
            IsDesigningAi= isDesigningAi;
        }
    }
}
