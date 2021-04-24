using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace immoblier.Models
{
    public class Contrat
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10, MinimumLength =5)]
        [Display(Name ="Reference")]
        public string Code { get; set; }
        [Display(Name ="Montant")]
        //[StringLength(9, ErrorMessage ="Montant ne peut pas depasser 9 chiffre.")]
        [DataType(DataType.Currency)]
        public int? Montant { get; set; }
        [Display(Name ="Montant Mensuel")]
        //[StringLength(9,ErrorMessage ="Montant Mensuel ne peut pas depasser 9 chiffre.")]
        [DataType(DataType.Currency)]
        //[DisplayFormat("Montant Mensuel")]
        public int? MontantMensuel { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        [Display(Name ="Date Signature")]
        public DateTime DateSignature { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        [Display(Name ="Date Debut")]
        public DateTime? DateDebut { get; set; }
        [Display(Name ="Date Fin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime? DateFin { get; set; }
        public int? ClientID { get; set; }
        public int? BailleurID { get; set; }
        public int AgenceID { get; set; }
        public virtual Agence Agence { get; set; }
        public virtual Client Client { get; set; }
        public virtual Bailleur Bailleur { get; set; }
    }
}