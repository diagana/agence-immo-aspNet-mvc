using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immoblier.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Identifient")]
        [StringLength(20,ErrorMessage ="La CNI ne peut pas depasser les 20 caractaire")]
        public string CNI { get; set; }
        [Required]
        [StringLength(25, ErrorMessage ="Le nom de famille ne peut pas depasser 25 caractaire")]
        public string Nom { get; set; }
        [Required]
        [StringLength(40,ErrorMessage ="Le prenom ne peut pas depasser 40 caractaire")]
        public string Prenom { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        public string Telephone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        public string Email { get; set; }
        public Genre genre { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }

        [Display(Name="Nom Complet")]
        public string NomComplet
        {
            get
            {
                return this.Nom + "  " + this.Prenom;
            }
        }
    }
}