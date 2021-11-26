using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork02.Data.Models
{
    class Authorization
    {
        [PrimaryKey, AutoIncrement]
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
