using System;
using System.Collections.Generic;
using System.Text;

namespace AulasBanco
{
    class Telefone
    {
        public int id_Telefone { get; set; }
        public int id_Pessoa { get; set; }
        public string numero { get; set; }

        public Telefone() { }
        public Telefone(
        int id_Telefone,
        int id_Pessoa,
        string numero)
        { }

    }
}
