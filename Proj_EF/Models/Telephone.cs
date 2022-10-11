using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF.Models
{
    internal class Telephone
    {
        [Key]
        public int Id { get; set; } //necessito de uma chave primaria
        public string Mobile { get; set; } //telefone celular
        public string Landline { get; set; } //telefone fixo
        public Person Name { get; set; } //associação
        public override string ToString()
        {
            return $"\nID: {this.Id} \nTelefone celular: {this.Mobile}\nTelefone Fixo: {this.Landline}";
        }
    }
}
