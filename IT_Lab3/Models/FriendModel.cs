using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT_Lab3.Models
{
    public class FriendModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "ID must be between 0 and 200")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FriendID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string MestoNaZiveenje { get; set; }

    }
}