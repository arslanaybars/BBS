using System;
using System.Collections.Generic;
using System.ServiceModel;
using BBS.Domain;

namespace BBS.Services
{
    [ServiceContract]
    public interface IBbsService
    {
        [OperationContract]
        List<User> GetUsers();

        [OperationContract]
        User FindUser(int id);

        [OperationContract]
        User CreateUser(User user);

        [OperationContract]
        User UpdateUser(User user);

        [OperationContract]
        bool DeleteUser(int d);

        [OperationContract]
        List<Role> GetRoles();

        [OperationContract]
        List<Gender> GetGenders();

    }
}
