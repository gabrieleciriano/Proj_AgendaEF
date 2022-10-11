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
        public int Id { get; set; } 
        public string Mobile { get; set; } 
        public string Landline { get; set; } 
        public Person Name { get; set; } 
        public override string ToString()
        {
            return $"\nID: {this.Id} \nTelefone celular: {this.Mobile} \nTelefone Fixo: {this.Landline}";
        }
    }
}
