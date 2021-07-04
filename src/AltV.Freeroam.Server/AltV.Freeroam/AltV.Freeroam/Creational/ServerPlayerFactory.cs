using System;
using AltV.Freeroam.Structure;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Creational
{
    public class ServerPlayerFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(IntPtr entityPointer, ushort id)
        {
            return new ServerPlayer(entityPointer, id);
        }
    }
}