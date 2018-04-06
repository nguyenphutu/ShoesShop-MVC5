using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoesShop.Models
{
    public enum Size
    {
        S,
        M,
        L,
        XL,
        XXL
    }

    public enum Types
    {
        [Display(Name="Casual Shoes")]
        CasualShoes,
        [Display(Name= "Sneakers")]
        Sneakers,
        [Display(Name = "Formal Shoes")]
        FormalShoes
    }
    public class Shoes
    {
        public int ID { get; set; }
        [Required(ErrorMessage = " The Name Shoe is required")]
        [StringLength(255)]
        [DisplayName("Shoe Name")]
        public string ShoeName { get; set; }
        [Required(ErrorMessage = " The Shoe Title is required")]
        [DisplayName("Shoe Title")]
        public string ShoeTitle { get; set; }
        [Required(ErrorMessage = " The Shoe Descriptions is required")]
        [DisplayName("Descriptions")]
        public string Descriptions { get; set; }
        [Required(ErrorMessage = " The Shoe Infomations is required")]
        [DisplayName("Infomations")]
        public string Infomations { get; set; }
        [Required(ErrorMessage = " The Shoe Size is required")]
        [DisplayName("Size")]
        public Size Size { get; set; }
        [Required(ErrorMessage = " The Shoe Price is required")]
        [DisplayName("Price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DisplayName("Sale")]
        [Range(0,99)]
        public int Sale { get; set; }
        [DisplayName("Types")]
        [Required(ErrorMessage = " The Shoe Type is required")]
        public Types Types { get; set; }
        [DisplayName("Image")]
        [Required(ErrorMessage = " The Shoe Image is required")]
        public string Image { get; set; }

        public virtual ICollection<ImagesShoe> ImagesShoe { get; set; }

    }    
}