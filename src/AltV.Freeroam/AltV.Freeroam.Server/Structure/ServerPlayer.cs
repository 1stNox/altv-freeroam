using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Structure
{
    public class ServerPlayer : Player
    {
        public ServerPlayer(IServer server, IntPtr nativePointer, ushort id) : base(server, nativePointer, id)
        {

        }
    }
}
