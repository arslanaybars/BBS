using System;
using System.Collections.Generic;
using BBS.Business;
using BBS.Domain;

namespace BBS.Services
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, AddressFilterMode = AddressFilterMode.Any)]
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BbsService : IBbsService
    {
        private readonly UserBL _userBL;
        private readonly RoleBL _roleBL;
        private readonly GenderBL _genderBL;

        public BbsService()
        {
            _userBL = new UserBL();
            _roleBL = new RoleBL();
            _genderBL = new GenderBL();
        }

        #region [ User ]

        public List<User> GetUsers()
        {
            return _userBL.GetAll();
        }

        public User FindUser(int id)
        {
            return _userBL.Find(id);
        }

        public User CreateUser(User user)
        {
            return _userBL.Create(user);
        }

        public User UpdateUser(User user)
        {
            return _userBL.Update(user);
        }

        public bool DeleteUser(int id)
        {
            return _userBL.Delete(id);
        }

        #endregion

        #region [ Role ]

        public List<Role> GetRoles()
        {
            return _roleBL.GetAll();
        }

        #endregion

        #region [ Gender ]

        public List<Gender> GetGenders()
        {
            return _genderBL.GetAll();
        }

        #endregion

    }
}
