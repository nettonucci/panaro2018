using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.Model
{
    public class Fornecedor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string produto { get; set; }
        public string celular { get; set; }
    }
}
