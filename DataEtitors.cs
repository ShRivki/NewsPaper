using CsvHelper;
using System.Globalization;

namespace ManagingANewspaper
{
    public class DataEtitors
    {
        public readonly List<Editor> _Editors;

        public DataEtitors()
        {

            using (var reader = new StreamReader("Editors.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Editors = csv.GetRecords<Editor>().ToList();
            }
        }
    }
}

