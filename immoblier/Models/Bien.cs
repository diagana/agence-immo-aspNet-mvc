using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immoblier.Models
{
    public enum Etat
    {
        Restaurer,Correct, Impeccable 
    }
   
    public class Bien
    {
        public int Id { get; set; }
        [Display(Name ="Adresse"), StringLength(80), Required]
        public string lieu { get; set; }
        [Display(Name ="Garniture")]
        public bool garniture { get; set; }
        [Display(Name = "Statut")]
        [DisplayFormat(NullDisplayText = "Pas de Etat")]
        public int? statut { get; set; }
        [Display(Name = "Etat")]
        [DisplayFormat(NullDisplayText ="Pas de Etat")]
        public Etat? etat { get; set; }
        [Display(Name ="Description "), StringLength(255), DataType(DataType.MultilineText)]
        public string Detail { get; set; }

        public virtual TypeBien TypeBien { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
    }
}