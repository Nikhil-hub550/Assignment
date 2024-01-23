using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Assignment.Configuration
{
    /// <summary>
    /// JwtTokenProvider
    /// </summary>
    public class JwtTokenProvider<TUser> : DataProtectorTokenProvider<TUser> where TUser : class
    {
        public JwtTokenProvider(IDataProtectionProvider dataProtectionProvider,
            IOptions<DataProtectionTokenProviderOptions> options, ILogger<DataProtectorTokenProvider<TUser>> logger) :
            base(dataProtectionProvider, options, logger)
        {

        }
    }
}
