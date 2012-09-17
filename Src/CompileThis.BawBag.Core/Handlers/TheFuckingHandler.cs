﻿namespace CompileThis.BawBag.Handlers
{
    using System;
    using System.Text.RegularExpressions;
    using CompileThis.BawBag.Jabbr;

    internal class TheFuckingHandler : IMessageHandler
    {
        private static readonly Regex Matcher = new Regex("(the) (fucking)", RegexOptions.IgnoreCase);
        private static readonly Random RandomProvider = new Random();

        public string Name
        {
            get { return "The Fucking"; }
        }

        public int Priority
        {
            get { return 104; }
        }

        public bool ContinueProcessing
        {
            get { return false; }
        }

        public MessageHandlerResult Execute(MessageContext message, MessageHandlerContext context)
        {
            if (message.IsBotAddressed || message.Type != MessageType.Default)
            {
                return MessageHandlerResult.NotHandled;
            }

            if (!Matcher.IsMatch(message.Content) || RandomProvider.Next(2) == 0)
            {
                return MessageHandlerResult.NotHandled;
            }

            var text = Matcher.Replace(message.Content, "$2 $1");

            var response = new MessageResponse
                {
                    ResponseType = MessageHandlerResultResponseType.Message,
                    ResponseText = text
                };

            return new MessageHandlerResult
                {
                    IsHandled = true,
                    Responses = new[] {response}
                };
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}