using System.ComponentModel.DataAnnotations.Schema;
using TestandoConhecimento2.Repository.Base;

namespace TestandoConhecimento2.Model.Entities
{
    [Table("CAR")]
    public class Car : BaseEntity
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("MARK")]
        public string Mark { get; set; }

        [Column("VALUE")]
        public string Value { get; set; }

        [Column("COLOR")]
        public string Color { get; set; }
    }
}
