using System;
using System.ComponentModel.DataAnnotations.Schema;
using TestandoConhecimento.Repository.Base;

namespace TestandoConhecimento.Model.Entities
{
    [Table("Person")]
    public class Person : BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [Column("birthdate")]
        public DateTime? BirthDate { get; set; }
    }
}
