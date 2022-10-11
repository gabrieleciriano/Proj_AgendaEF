using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_EF.Models
{
    internal class Person
    {
        [Key]
        public string Name { get; set; }
        List<Telephone> Telephones { get; set; }
    }
}
