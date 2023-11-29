using System;

namespace ManagingANewspaper
{
    public enum TypeWriter { child,teen,adult};
    public class Writer:Worker
    {

        static int num = 0;
        public int Id { get; set; }
        public TypeWriter TWriter { get; set; } 
        public Writer()
        {
            Id = num++;
        }
    
        public Writer(TypeWriter typeWriter,string name, string pon, string ad, float salary=0, int vetek = 0 ) :base(name, pon, ad,salary, vetek)
        {
            Id = num++;
            TWriter = typeWriter;
        }
    }
}
