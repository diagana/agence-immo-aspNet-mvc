using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immoblier.Models
{
    public enum Genre
    {
       Homme, Femme,
    }
    public class Bailleur
    {
        public int Id { get; set; }
        [Required, StringLength(20, ErrorMessage ="Le nom famille ne peut pas depasser 20 caractaire")]
        public string Nom { get; set; }
        [Required, StringLength(40, ErrorMessage ="Le prenom ne peut pas depasser 40 caractaire")]
        public string Prenom { get; set; }
        [Required, StringLength(15), DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
        [StringLength(20), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(80)]
        public string adresse { get; set; }
        public Genre genre { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }
        [Display(Name ="Nom complet")]
        public string NomComplet
        {
            get
            {
                return this.Nom + "  " + this.Prenom;
            }
        }
    }
}