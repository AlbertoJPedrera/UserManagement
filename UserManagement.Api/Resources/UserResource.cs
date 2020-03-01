// -----------------------------------------------------
//     Class name
//     Author: Alberto José Pedrera Ros
//------------------------------------------------------

using System;

namespace UserManagement.Api.Resources
{
    public class UserResource
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Country { get; set; }

        public int PhoneNumber { get; set; }

        public int PostalCode { get; set; }
    }
}