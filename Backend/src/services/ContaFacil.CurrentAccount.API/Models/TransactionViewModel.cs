using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContaFacil.CurrentAccount.API.Models
{
    public class TransactionViewModel
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Amount { get; set; }

    }
}
