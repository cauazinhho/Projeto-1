using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.Model
{
    internal class Conexao
    {
        public static string Conectar() 
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\emerson.csrodrigues1\source\repos\Projeto 1\Projeto 1\Dados\Database1.mdf"";Integrated Security=True";
        }
    }
}
