﻿namespace CompileThis.BawBag
{
    using System.Collections.ObjectModel;

    using Jabbr;

    internal class RoomCollection : KeyedCollection<string, JabbrRoom>
    {
        protected override string GetKeyForItem(JabbrRoom item)
        {
            return item.Name;
        }
    }
}
