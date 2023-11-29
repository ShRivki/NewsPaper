using CsvHelper;
using System.Globalization;

namespace ManagingANewspaper
{
    public class DataDesigners
    {
        public readonly List<Designer> _Designers;

        public DataDesigners()
        {
            
            using (var reader = new StreamReader("Designers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Designers = csv.GetRecords<Designer>().ToList();
            }
        }
    }
}
