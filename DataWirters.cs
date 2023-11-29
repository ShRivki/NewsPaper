using CsvHelper;
using System.Globalization;

namespace ManagingANewspaper
{
    public class DataWirters
    {
        public readonly List<Writer> _Writers;

        public DataWirters()
        {

            using (var reader = new StreamReader("Writers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _Writers = csv.GetRecords<Writer>().ToList();
            }
        }
    }
}
