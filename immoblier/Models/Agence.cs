using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immoblier.Models
{
    public class Agence
    {
        public int Id
        {
            get; set;
        }
        [Required,StringLength(80)]
        public string adresse { get; set; }
        [Required, StringLength(60), Display(Name ="Nom Responsable")]
        public string NomResponsable { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
     }
}