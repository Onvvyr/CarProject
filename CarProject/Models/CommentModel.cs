using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarProject.Models
{
    [Table("Comments")]
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Cars")]
        public int CarId { get; set; }
        public string Comment { get; set; }
        public virtual CarModel Cars { get; set; }
    }
}