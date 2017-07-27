using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public string Username { get; set; }

    public List<Message> Messages { get; set; }

    public User(string username)
    {
        this.Username = username;
        this.Messages = new List<Message>();
    }
}

