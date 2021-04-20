using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;


namespace FinalToDOListWebApplication.Model
{
    public class ToDoList
    {
        [Key]
        [HiddenInput]
        [Required]
        public int ID { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Entry")]
        [Required(ErrorMessage = "Please Enter Email Address")]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        [StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter upper and lower case alphabets only")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Discription")]
        [StringLength(100, MinimumLength = 1)]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter upper and lower case alphabets only")]

        public string Descrption { get; set; }


        public DateTime AddedDate{ get; set; }

        public DateTime DueDate { get; set; }

        public String Done { get; set; }
        public DateTime DoneDate { get; set; }

    }
}
