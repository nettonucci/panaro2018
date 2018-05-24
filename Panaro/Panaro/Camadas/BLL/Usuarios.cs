using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaro.Camadas.BLL
{
    public class Usuarios
    {
        public Boolean Login(string usuario, string senha)
        {
            DAL.Usuarios dalUser = new DAL.Usuarios();
            List<Model.Usuarios> user = new List<Model.Usuarios>();

            user = dalUser.Login(usuario, senha);

            if(user.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}