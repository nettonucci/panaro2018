using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.Model
{
    public class Produtos
    {
        public int id { get; set; }
        public string produto { get; set; }
        public string descricao { get; set; }
        public string valor { get; set; }
        public string quantidade { get; set; }
    }
}
