using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarProject.Models
{
    [Table("Cars")]
    public class CarModel
    {
        [Key]
        public int CarId { get; set; }
        [Display(Name = "Marka")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Marka musi mieć więcej niż 4 znaki, ale mniej niż 10")]
        public string Brand { get; set; }
        public string Model { get; set; }
        [Display(Name = "Kraj")]
        public Country Country { get; set; }
        public virtual ICollection<CommentModel> Comments { get; set; }
    }
    public enum Country
    {
        Polska,
        Japonia,
        Chiny
    }
}