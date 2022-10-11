using Proj_EF.Context;
using Proj_EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF.Controllers
{
    internal class ContactController
    {
        public void InsertContact()
        {
            Person p = new Person();
            Telephone t = new Telephone();
            Console.WriteLine(">>CADASTRO DE CONTATO<<");
            using (var context = new ContactContext())
            {
                //usar um try catch
                Console.WriteLine("Informe o nome: ");
                p.Name = Console.ReadLine();
                Console.WriteLine("Informe o telefone celular: ");
                t.Mobile = Console.ReadLine();
                Console.WriteLine("Informe o telefone fixo: ");
                t.Landline = Console.ReadLine();
                t.Name = p;
                context.Person.Add(p);
                context.Telephones.Add(t);
                context.SaveChanges();
                Console.WriteLine("Cadastro realizado com sucesso!");
                Console.ReadKey();
            }
        }
        public void SelectAll()
        {
            var telephone = new ContactContext().Telephones.ToList();
            foreach (var item in telephone)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nPressione ENTER para sair...");
            Console.ReadKey();
        }
        //ok
        public void SelectOne()
        {
           Person person = new Person();
            using (var context = new ContactContext())
            {
                Console.WriteLine("Informe o nome para consultar os telefones: ");
                person.Name = Console.ReadLine();
                var find = context.Telephones.FirstOrDefault(t => t.Name.Name == person.Name);
                if (find != null)
                {
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nPressione ENTER para sair...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nDesculpe, cadastro não encontrado!");
                    Console.ReadKey();
                }
            }
        }
        //ok
        public void DeleteOne()
        {
            using (var context = new ContactContext())
            {
                Console.WriteLine("Informe o ID do contato que deseja deletar o cadastro:");
                int id = int.Parse(Console.ReadLine());
                Telephone find = new ContactContext().Telephones.FirstOrDefault(f => f.Id == id);
                if (find != null)
                {
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("Deseja realmente deletar esse cadastro? [1 - SIM, 2 - NÃO]");
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        context.Entry(find).State = EntityState.Deleted;
                        context.Telephones.Remove(find);
                        context.SaveChanges();
                        Console.WriteLine("\nContato deletado com sucesso!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nOperação cancelada!");
                    }
                }
                else
                {
                    Console.WriteLine("\nContato não encontrado!");
                    Console.ReadKey();
                }
            }
        }
        public void UpdateContact()
        {
            Person person = new Person();
            using (var context = new ContactContext())
            {
                Console.WriteLine("Informe o nome para consultar os dados do contato: ");
                person.Name = Console.ReadLine();
                var find = context.Telephones.FirstOrDefault(t => t.Name.Name == person.Name);
                if (find != null)
                {
                    Console.WriteLine(find.ToString());
                    Console.WriteLine("\nPressione ENTER para sair...");
                    Console.ReadKey();
                    Console.WriteLine("\nO que deseja atualizar? \n1-Telefone celular\n2-Telefone Fixo\nEscolha: ");
                    int op = int.Parse(Console.ReadLine());
                    switch (op) 
                    { 
                        case 1:
                            Console.WriteLine("\nAlterar celular: ");
                            string c = Console.ReadLine();
                            find.Mobile = c;
                            context.Entry(find).State = EntityState.Modified;
                            context.SaveChanges();
                            Console.WriteLine("Telefone celular atualizado!");
                            Console.WriteLine(find.ToString());
                            break;

                        case 2:
                            Console.WriteLine("\nAlterar fixo: ");
                            string f = Console.ReadLine();
                            find.Landline = f;
                            context.Entry(find).State = EntityState.Modified;
                            context.SaveChanges();
                            Console.WriteLine("Telefone fixo atualizado!");
                            Console.WriteLine(find.ToString());
                            break;

                            default:
                            Console.WriteLine("Informe uma das opções ofertadas!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nDesculpe, esse contato não foi encontrado!");
                    Console.ReadKey();
                }
            }
        }
    }
}

