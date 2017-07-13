using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwashApi.Model
{
    /// <summary>
    /// A 'person' registered to use the system
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Unique email address for the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Preferred name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether the user's email address has been verified
        /// </summary>
        public bool IsVerified { get; set; }
    }
}
