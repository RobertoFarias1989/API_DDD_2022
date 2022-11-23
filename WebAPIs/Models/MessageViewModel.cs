using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIs.Models
{
    public class MessageViewModel
    {        
        public int Id { get; set; }        
        public string Titulo { get; set; }        
        public bool Ativo { get; set; }       
        public DateTime MyProperty { get; set; }
        public DateTime DataAlteracao { get; set; }      
        public string UserId { get; set; }

    }
}
