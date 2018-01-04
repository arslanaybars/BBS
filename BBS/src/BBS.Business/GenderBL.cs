using BBS.Domain;

namespace BBS.Business
{
    public class GenderBL : BaseBL<Gender>
    {
        public GenderBL() : base(new BbsContext())
        {
        }
    }
}
