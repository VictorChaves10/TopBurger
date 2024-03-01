using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopBurgers.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required(ErrorMessage ="Informe seu nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu sobrenome")]
        [StringLength(100)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name ="Endereço")]
        [StringLength (100)]
        public string Endereco { get; set; }

       
        [Display(Name = "Complemento")]
        [StringLength(100)]

        public string Complemento { get; set; }

        [Required(ErrorMessage ="Informe o seu CEP")]
        [Display(Name = "CEP")]
        [StringLength(15, MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o Estado")]
        [Display(Name = "Estado")]
        [StringLength(15)]
        public string Estado { get; set;}

        [Required(ErrorMessage = "Informe a Cidade")]
        [Display(Name = "Cidade")]
        [StringLength(25)]
        public string Cidade { get; set; }

        [Required(ErrorMessage ="Informe seu telefone")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        
        
        [Required(ErrorMessage = "Informe o seu e-mail")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName ="decimal(18,2)")]
        [Display(Name ="Total do Pedido")]        
        public decimal PedidoTotal { get; set; }
        [ScaffoldColumn(false)]
        [Display(Name ="Itens no pedido")]
        public int TotalItensPedido { get; set; }

        [Display(Name = "Data Envio Pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime PedidoEnviado { get; set; }


        [Display(Name = "Data Entrega Pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? PedidoEntregueEm { get; set; }

        public List<PedidoDetalhe> PedidosItens { get; set; }
    }
}
