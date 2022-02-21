using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarSenha
{
    class Verificador
    {
        public  bool verificaSenhaForte(string senha)
        {
            //quantidade de caracteres
            if(senha.Length < 6 || senha.Length > 20)
                return false;

            //verfica se não tem nunhum numero
            if(!senha.Any(c => char.IsDigit(c)))
                return false;

            //verifica se tem leta maiuscula
            if(!senha.Any(c => char.IsUpper(c)))
                return false;

            // verifica se não tem letra minuscula
            if(!senha.Any(c => char.IsLower(c)))
                return false;

            //verifica se não tem um caractere especial
            if(!senha.Any(c => char.IsSymbol(c)))
                return false;

            return true;
        }
    }
}
