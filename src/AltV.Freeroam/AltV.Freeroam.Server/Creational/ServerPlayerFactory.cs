using AltV.Freeroam.Server.Structure;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Creational
{
    public class ServerPlayerFactory : IEntityFactory<IPlayer>
    {
        public IPlayer Create(ICore core, IntPtr entityPointer, ushort id)
        {
            return new ServerPlayer(core, entityPointer, id);
        }
    }
}
