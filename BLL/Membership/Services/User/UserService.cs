using System;
using System.Text;
using System.Security.Cryptography;

namespace Web.TORCHx.Core.BLL.Membership
{
    public class UserService : IUserService
    {
		private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
			this.userRepository = userRepository;
        }

		public User GetUser(Guid id)
		{
			return userRepository.GetUser(id);
		}

		public User GetUser(string username)
		{
			return userRepository.GetUser(username);
		}

		public bool ValidateUser(string username, string password)
		{
			var membership = userRepository.GetMembership(username);

			if (membership == null) {
				return false;
			}

			if (!membership.IsApproved) {
				return false;
			}

			if (membership.IsLockedOut) {
				return false;
			}

			if (!ValidatePassword(membership, password)) {
				return false;
			}

			//TODO: Check if FailedPasswordAttemptCount exceeds max

			//TODO: Update LastLoginDate

			return true;
		}

		private bool ValidatePassword(Membership membership, string password)
		{
			var encoded = EncodePassword(password, membership.PasswordFormat, membership.PasswordSalt);
			return membership.Password == encoded;
		}

		private string EncodePassword(string password, int format, string salt)
		{
			// MembershipPasswordFormat.Clear
			if (format == 0) {
				return password;
			}

			// MembershipPasswordFormat.Hashed
			if (format == 1) {
				byte[] bIn = Encoding.Unicode.GetBytes(password);
				byte[] bSalt = Convert.FromBase64String(salt);
				byte[] bRet = null;
				HashAlgorithm hm = SHA1.Create();
                byte[] bAll = new byte[bSalt.Length + bIn.Length];
                Buffer.BlockCopy(bSalt, 0, bAll, 0, bSalt.Length);
                Buffer.BlockCopy(bIn, 0, bAll, bSalt.Length, bIn.Length);
                bRet = hm.ComputeHash(bAll);
				return Convert.ToBase64String(bRet);
            }

			throw new NotSupportedException("Unsupported MembershipPasswordFormat");
        }
    }
}
