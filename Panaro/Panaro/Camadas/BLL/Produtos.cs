using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.BLL
{
    public class Produtos
    {
        public List<Model.Produtos> Select()
        {
            DAL.Produtos dalPro = new DAL.Produtos();
            return dalPro.Select();
        }

        public List<Model.Produtos> SelectById(int id)
        {
            DAL.Produtos dalPro = new DAL.Produtos();
            return dalPro.SelectById(id);
        }

        public List<Model.Produtos> SelectByNome(string nome)
        {
            DAL.Produtos dalPro = new DAL.Produtos();
            return dalPro.SelectByNome(nome);
        }
    }
}
