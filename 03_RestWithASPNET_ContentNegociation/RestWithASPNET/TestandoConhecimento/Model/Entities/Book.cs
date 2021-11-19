using System.ComponentModel.DataAnnotations.Schema;
using TestandoConhecimento.Repository.Base;

namespace TestandoConhecimento.Model.Entities
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
    }
}
