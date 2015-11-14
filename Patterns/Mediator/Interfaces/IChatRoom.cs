using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator.Interfaces
{
    /// <summary>
    /// Provides message exchange functionality
    /// </summary>
    interface IChatRoom
    {
        /// <summary>
        /// Get list of connected users
        /// </summary>
        /// <returns></returns>
        IEnumerable<IUser> OnlineUsers { get; }

        /// <summary>
        /// Add user to chat
        /// </summary>
        /// <param name="user"></param>
        void AddUser(IUser user);

        /// <summary>
        /// Disconnect user from chat
        /// </summary>
        /// <param name="user"></param>
        void RemoveUser(IUser user);

        /// <summary>
        /// Send message to appropriate receiver
        /// </summary>
        /// <param name="from"></param>
        /// <param name="recipientId"></param>
        /// <param name="message"></param>
        void ProcessMessage(IUser from, string recipientId, string message);
    }
}
