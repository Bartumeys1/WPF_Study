using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace Event_Planning.Models
{
    public class MyPlann
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; }
        public string Information { get; set; }
        public string StartDate { get; set; }
        public string DedlineDate { get; set; }

        public MyPlann()
        {
            StartDate = DateTime.Today.ToShortDateString().ToString();
        }
        public override string ToString()
        {
            return $"{StartDate} - {DedlineDate}\t{Name,-20}\t{Priority}\t{Information}";
        }
    }
}
