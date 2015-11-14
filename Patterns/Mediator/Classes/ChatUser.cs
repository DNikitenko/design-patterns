using Patterns.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator.Classes
{
    /// <summary>
    /// Represents a user that can participate in chat
    /// </summary>
    class ChatUser : IUser
    {
        /// <summary>
        /// Mediator object; used for sending messages
        /// </summary>
        private readonly IChatRoom _chatRoom;

        /// <summary>
        /// Unique ID of user
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Send message processing request to mediator
        /// </summary>
        /// <param name="receiverId"></param>
        /// <param name="message"></param>
        public void SendMessage(string receiverId, string message)
        {
            _chatRoom.ProcessMessage(this, receiverId, message);
        }

        /// <summary>
        /// Write message in console
        /// </summary>
        /// <param name="senderId"></param>
        /// <param name="message"></param>
        public void ReceiveMessage(string senderId, string message)
        {
            Console.WriteLine(String.Format("{0} received message from {1}: {2}", Id, senderId, message));
        }

        public ChatUser(string id, string name, IChatRoom chatRoom)
        {
            Id = id;
            Name = name;
            _chatRoom = chatRoom;
        }
    }
}