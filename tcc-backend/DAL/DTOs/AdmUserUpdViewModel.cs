﻿using System.ComponentModel.DataAnnotations;

namespace DAL.DTOs
{
    public class AdmUserUpdViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(80, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "O {0} do usuário é obrigatório")]
        public string IdPerfil { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100)]
        public string Telefone { get; set; }

        public bool Ativo { get; set; }


    }
}
