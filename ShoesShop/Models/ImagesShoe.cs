using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public class ImagesShoe
    {
        public int ID { get; set; }
        [Required(ErrorMessage = " The Image URL is required")]
        [DisplayName("URL")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = " The Shoe Id is required")]
        [DisplayName("Shoe Id")]
        public int ShoeId { get; set; }
        public virtual Shoes Shoe { get; set; }
    }
}