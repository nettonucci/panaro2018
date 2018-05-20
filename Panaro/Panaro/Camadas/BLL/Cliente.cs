using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.BLL
{
    public class Cliente
    {
        public List<Model.Cliente> Select()
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.Select();
        }

        public List<Model.Cliente> SelectById(int id)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectById(id);
        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            DAL.Cliente dalCli = new DAL.Cliente();
            return dalCli.SelectByNome(nome);
        }
    }
}
