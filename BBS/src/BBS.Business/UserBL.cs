using BBS.Domain;

namespace BBS.Business
{
    public class UserBL : BaseBL<User>
    {
        public UserBL() : base(new BbsContext())
        {
        }
    }
}
