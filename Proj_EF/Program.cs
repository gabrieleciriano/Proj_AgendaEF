using Proj_EF.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF
{
    internal class Program
    {
        public static void MenuPrincipal()
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(">>>AGENDA DE CONTATOS<<<");
                Console.WriteLine("\n");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Cadastrar contato");
                Console.WriteLine("2 - Ver contato especifico ");
                Console.WriteLine("3 - Ver todos os contatos ");
                Console.WriteLine("4 - Atualizar contato");
                Console.WriteLine("5 - Deletar contato");
                Console.WriteLine("\n>>Informe o que deseja acessar...");
                opc = int.Parse(Console.ReadLine());
                if (opc < 0 || opc > 9)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA! Informe um número válido para acessar o menu:");

                }
                else
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("SAINDO...");
                            Environment.Exit(0);
                            break;

                        case 1:
                            ContactController c = new ContactController();
                            c.InsertContact();
                            break;

                        case 2:
                            c = new ContactController();
                            c.SelectOne();
                            break;

                        case 3:
                            c = new ContactController();
                            c.SelectAll();
                            break;

                        case 4:
                            c = new ContactController();
                            c.UpdateContact();
                            break;

                        case 5:
                            c = new ContactController();
                            c.DeleteOne();
                            break;

                        default:
                            Console.WriteLine("OPÇÃO INVÁLIDA! Informe uma das opções segundo o menu!");
                            break;
                    }
                }
            } while (opc < 0 || opc > 9);
        }
        static void Main(string[] args)
        {
            MenuPrincipal(); 
        }
    }
}
