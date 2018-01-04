using BBS.Domain;

namespace BBS.Business
{
    public class RoleBL : BaseBL<Role>
    {
        public RoleBL() : base(new BbsContext())
        {
        }
    }
}
