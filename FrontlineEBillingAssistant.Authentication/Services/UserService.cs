using FrontlineEBillingAssistant.Authentication.Helpers;
using FrontlineEBillingAssistant.Authentication.Interfaces;
using FrontlineEBillingAssistant.Authentication.Requests;
using FrontlineEBillingAssistant.Authentication.Responses;
using FrontlineEBillingAssistant.Core.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Authentication.Services
{
    public class UserService : IUserService
    {
        private readonly EBillingContext _eBillingContext;

        public UserService(EBillingContext eBillingContext)
        {
            _eBillingContext = eBillingContext;
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            var user = _eBillingContext.Users.SingleOrDefault(user => user.Status == 1 && user.Login == loginRequest.UserName);

            if (user == null)
            {
                return null;
            }

            bool passwordVerified = HashingHelper.VerifyHash(loginRequest.Password, "MD5", user.Password);

            if (!passwordVerified)
            {
                return null;
            }

            var token = await Task.Run(() => TokenHelper.GenerateToken(user));

            return new LoginResponse { UserName = user.Login, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, Token = token };
        }
    }
}
