using FrontlineEBillingAssistant.Authentication.Requests;
using FrontlineEBillingAssistant.Authentication.Responses;
using System.Threading.Tasks;

namespace FrontlineEBillingAssistant.Authentication.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
    }
}
