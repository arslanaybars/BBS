using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BBS.Domain
{
    [DataContract]
    public class User : BaseEntity
    {
        #region Foreign Key(s)

        [DataMember]
        [Column("Role")]
        public int RoleId { get; set; }

        [DataMember]
        [Column("Gender")]
        public int GenderId { get; set; }

        #endregion

        #region Navigation(s)

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        
        #endregion
    }
}
