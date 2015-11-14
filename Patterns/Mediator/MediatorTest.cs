using Patterns.Mediator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    class MediatorTest : IPatternTest
    {
        public void Run()
        {
            var chatRoom = new SingleThreadedChatRoom();

            var user1 = new ChatUser("dnikitenko", "Dmitry Nikitenko", chatRoom);
            var user2 = new ChatUser("o.esenkov", "Oleg Esenkov", chatRoom);

            chatRoom.AddUser(user1);
            chatRoom.AddUser(user2);

            user1.SendMessage("o.esenkov", "Hi man!");
            user2.SendMessage("dnikitenko", "sup!");

            Console.ReadLine();
        }
    }
}
