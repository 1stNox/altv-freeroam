using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Structure
{
    public class ServerPlayer : Player
    {
        public ServerPlayer(ICore core, IntPtr nativePointer, ushort id) : base(core, nativePointer, id)
        {
        }
    }
}
