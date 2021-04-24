using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immoblier.Models
{
    public class TypeContrat
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Libelle { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
    }
}