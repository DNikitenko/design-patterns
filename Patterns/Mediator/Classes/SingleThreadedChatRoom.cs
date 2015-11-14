using Patterns.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator.Classes
{
    /// <summary>
    /// This version of chat room is for mediator pattern demonstration only, so we don't implement all stuff related
    /// with multi-threading
    /// </summary>
    class SingleThreadedChatRoom : IChatRoom
    {
        /// <summary>
        /// List of users that are currently online
        /// </summary>
        private readonly List<IUser> _users = new List<IUser>();

        public IEnumerable<IUser> OnlineUsers
        {
            get { return _users; }
        }

        /// <summary>
        /// Add user to online list
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(IUser user)
        {
            _users.Add(user);
        }

        /// <summary>
        /// Remove user from online list
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(IUser user)
        {
            _users.Remove(user);
        }

        /// <summary>
        /// Send message to destination
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        public void ProcessMessage(IUser from, string recipientId, string message)
        {
            var recipient = _users.Find(user => user.Id == recipientId);

            if (recipient != null)
            {
                recipient.ReceiveMessage(from.Id, message);
            }
        }
    }
}
