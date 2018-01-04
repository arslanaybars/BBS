using System;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace BBS.Services
{
    public class PasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == "labas" && password == "labas"))
            {
                throw new FaultException("Incorrect Username or Password");
            }
        }
    }
}
