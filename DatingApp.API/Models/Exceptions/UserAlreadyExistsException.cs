using System;

namespace DatingApp.API.Models.Exceptions
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string username) : base(CreateErrorMessage(username))
        {
        }

        public static string CreateErrorMessage(string username)
        {
            return $"The username '{username}' is already taken";
        }
    }
}
