﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileThis.BawBag.Extensibility
{
    public class Message
    {
        public string Text { get; set; }
        public MessageType Type { get; set; }
    }

    public enum MessageType
    {
        Default,
        Action
    }
}
