namespace CompileThis.BawBag.Jabbr
{
    using System;

    public class LeftRoomEventArgs : EventArgs
    {
        private readonly IRoom _room;
        private readonly IUser _user;

        public LeftRoomEventArgs(IRoom room, IUser user)
        {
            _room = room;
            _user = user;
        }

        public IRoom Room
        {
            get { return _room; }
        }

        public IUser User
        {
            get { return _user; }
        }
    }
}