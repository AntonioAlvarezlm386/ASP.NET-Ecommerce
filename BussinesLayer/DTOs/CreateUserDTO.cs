using System;
using System.ComponentModel.DataAnnotations;


namespace BussinesLayout.DTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Este campo no puede ir vació")]
        [StringLength(100)]
        public string NAME { get; set; }
        [Required(ErrorMessage = "Rellene este campo")]
        [StringLength(100)]
        public string LAST_NAME { get; set; }
        [Required(ErrorMessage = "Este campo no puede ir vacio")]
        [StringLength(100)]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "Este campo no debe ir vacio")]
        public string PASSWORD { get; set; }
        [Required(ErrorMessage = "Este campo no puede ir vacio")]
        public bool ACTIVE { get; set; }
    }
}
