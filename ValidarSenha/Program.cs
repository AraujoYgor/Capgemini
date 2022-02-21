using System;
using System.Linq;

namespace ValidarSenha
{
    class Program
    {


        static void Main(string[] args)
        {

                bool verificaSenhaForte(string senha)
                {
                    //quantidade de caracteres
                    if(senha.Length <= 5)
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
                    if(!senha.Any(c => char.IsLetter(c)))
                        return false;

                    return true;
                }
                Console.WriteLine("Vamos criar uma senha segura, então a sua senha deve: ");
                Console.WriteLine("Possuir no mínimo 6 caracteres.");
                Console.WriteLine("Conter no mínimo 1 digito(numero).");
                Console.WriteLine("Conter no mínimo 1 letra em minúsculo.");
                Console.WriteLine("Conter no mínimo 1 letra em maiúsculo.");
                Console.WriteLine("Conter no mínimo 1 caractere especial. Os caracteres especiais são: !@#$%^&*()-+");
                string senha = "";
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();

                if(verificaSenhaForte(senha) == true)
                {
                    Console.WriteLine("Parabens sua Senha atende os requisitos minimos");
                }
                else
                {
                    Console.WriteLine("Sua senha não atende os requisitos");
                }
            Console.ReadLine();
        }
    }
}
