﻿namespace CompileThis.BawBag.Extensibility
{
    using CompileThis.BawBag.Jabbr;

    using Raven.Client;

    public interface IPluginContext
    {
        bool IsBotAddressed { get; }
        string BotName { get; }
        Room Room { get; }
        User User { get; }
        IDocumentSession RavenSession { get; }
        IRandomNumberProvider RandomProvider { get; }
        IInventoryManager InventoryManager { get; }
    }
}