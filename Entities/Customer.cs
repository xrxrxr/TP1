using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    public class Customer
    {
        private long id;
        private long firstname;
        private long lastname;

        public long Id { get => id; set => id = value; }
        public long Firstname { get => firstname; set => firstname = value; }
        public long Lastname { get => lastname; set => lastname = value; }
    }
}