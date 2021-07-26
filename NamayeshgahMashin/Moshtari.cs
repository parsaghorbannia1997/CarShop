using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamayeshgahMashin
{
   public class Moshtari
    {
        private int _idmoshtari;
        public int idmoshtari { get => _idmoshtari; set => _idmoshtari = value; }

        private string _firstname;
        public string firstname { get => _firstname; set => _firstname = value; }

        private string _lastname;
        public string lastname { get => _lastname; set => _lastname = value; }

        private string _mobile;
        public string mobile { get => _mobile; set => _mobile = value; }

        private string _address;
        public string address { get => _address; set => _address = value; }
    }
}
