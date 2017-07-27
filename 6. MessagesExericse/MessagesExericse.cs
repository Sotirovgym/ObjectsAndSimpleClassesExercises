using System;
using System.Collections.Generic;
using System.Linq;

class MessagesExericse
{
    static void Main()
    {
        var users = new Dictionary<string, User>();

        var sender = string.Empty;
        var recipient = string.Empty;

        var input = Console.ReadLine();

        while (input != "exit")
        {
            var tokens = input.Split(' ');

            if (tokens[0] == "register")
            {
                var username = tokens[1];
                users.Add(username, new User(username));
                
            }
            else
            {
                sender = tokens[0];
                recipient = tokens[2];
                var content = tokens[3];

                if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                {
                    var senderUser = users[sender];
                    users[recipient].Messages.Add(new Message(content, senderUser));

                }
            }

            input = Console.ReadLine();
        }

        var chatUsers = Console.ReadLine().Split(' ');

        sender = chatUsers[0];
        recipient = chatUsers[1];

        var senderMessage = users[recipient].Messages
            .Where(m => m.Sender.Username == sender)
            .ToList();

        var recipientMessage = users[sender].Messages
            .Where(m => m.Sender.Username == recipient)
            .ToList();

        if (senderMessage.Count == 0 && recipientMessage.Count == 0)
        {
            Console.WriteLine("No messages");
        }

        var index = 0;

        while (index < senderMessage.Count && index < recipientMessage.Count)
        {
            Console.WriteLine($"{sender}: {senderMessage[index].Content}");
            Console.WriteLine($"{recipientMessage[index].Content} :{recipient}");
            index++;
        }

        while (index < senderMessage.Count)
        {
            Console.WriteLine($"{sender}: {senderMessage[index].Content}");
            index++;
        }

        while (index < recipientMessage.Count)
        {
            Console.WriteLine($"{recipientMessage[index].Content} :{recipient}");
            index++;
        }
    }
}

