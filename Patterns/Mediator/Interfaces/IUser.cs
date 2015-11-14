using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator.Interfaces
{
    /// <summary>
    /// Represents a user that is able to send messages to another users
    /// </summary>
    interface IUser
    {
        /// <summary>
        /// User's unique identifier
        /// </summary>
        string Id { get; }

        /// <summary>
        /// User name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Send message to specified client
        /// </summary>
        /// <param name="receiverId"></param>
        /// <param name="message"></param>
        void SendMessage(string receiverId, string message);

        /// <summary>
        /// Perform some actions when message is received
        /// </summary>
        /// <param name="senderId"></param>
        /// <param name="message"></param>
        void ReceiveMessage(string senderId, string message);
    }
}
