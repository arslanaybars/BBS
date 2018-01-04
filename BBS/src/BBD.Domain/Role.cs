using System.Collections.Generic;
using System.Runtime.Serialization;


namespace BBS.Domain
{
    [DataContract]
    public class Role : BaseEntity
    {
        #region Navigation(s)

        public ICollection<User> Users { get; set; }

        #endregion
    }
}
