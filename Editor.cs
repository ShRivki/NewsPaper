using System.Diagnostics.Metrics;

namespace ManagingANewspaper
{
    public enum TypeEditor { Content,Literary,Torani,Main}
    public class Editor:Worker
    {

        static int num = 0;
        public int Id { get; set; }

        public TypeEditor TEditor {  get; set; }   
        public Editor()
        {
            Id = num++;
        }
        public Editor(TypeEditor tEditor,string name, string pon, string ad, float salary=0, int vetek = 0) : base(name, pon, ad, salary, vetek)
        {
            Id = num++;
            TEditor= tEditor;
        }
    }
}
