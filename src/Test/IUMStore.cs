using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Test
{
    public interface IUMStore
    {
        Task<bool> ValidateCredentials(string username, string password, string loginType, int userType);
        TestUser FindBySubjectId(string subjectId);
        Task<TestUser> FindByUsername(string username, string loginType, int userType);
        TestUser FindByExternalProvider(string provider, string userId);
        TestUser AutoProvisionUser(string provider, string userId, List<Claim> claims);
    }
}
