using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BBS.Domain
{
    [DataContract]
    public abstract class BaseEntity
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
    }
}
