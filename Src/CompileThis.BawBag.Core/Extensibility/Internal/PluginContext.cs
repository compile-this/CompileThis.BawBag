﻿namespace CompileThis.BawBag.Extensibility.Internal
{
    using Raven.Client;

    using CompileThis.BawBag.Jabbr;

    internal class PluginContext : IPluginContext
    {
        public bool IsBotAddressed { get; set; }
        public string BotName { get; set; }
        public Room Room { get; set; }
        public User User { get; set; }
        public IDocumentSession RavenSession { get; set; }
        public IRandomNumberProvider RandomProvider { get; set; }
        public IInventoryManager InventoryManager { get; set; }
    }
}
