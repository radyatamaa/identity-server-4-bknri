using IdentityServer4.Models;
using IdentityServer4.Models.ViewModels;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer4.Serivces
{
    public interface IUsersService
    {
        Task<bool> VerifiedEmail(VerifiedOTP verifiedOTP);
        Task<IQueryable<Users>> GetUsers();
        Task<UsersDto> GetByIdUserTest(string id);
        Task<UsersDto> GetByDetail(string id,bool isDetail);
        Task<Users> GetById(Guid id);
        Task<Users> GetByUsername(string username,string loginType, int userType);
        Task<Users> GetByPhoneNumberOTP(string phoneNumber , string oTP);
        Task<UsersForm> Insert(UsersForm entity,string otpCode);
        Task<Users> GenerateOTP(string phoneNumber,string otp,DateTime expiredDate);
        Task<OTPTemp> GenerateOTPTemp(string phoneNumber, string email, string otp, DateTime expiredDate);
        Task Insert(IEnumerable<Users> entity);
        Task<UsersForm> Update(UsersForm entity,string id);
        Task Update(IEnumerable<Users> entities);
        Task Delete(string id);
        Task<bool> ValidateCredentials(string username, string password, string loginType, int userType);
        Task<TestUser> FindBySubjectId(string subjectId);
        Task<TestUser> FindByUsername(string username, string loginType, int userType);
        TestUser FindByExternalProvider(string provider, string userId);
        TestUser AutoProvisionUser(string provider, string userId, List<Claim> claims);
    }
}
