using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data.Entities;

namespace MyVet.Web.Models
{
    public class PetViewModel : Pet
    {
        public int OwnerId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Tipo de Mascota")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a pet type.")]
        public int PetTypeId { get; set; }

        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }

        public IEnumerable<SelectListItem> PetTypes { get; set; }
    }
}
