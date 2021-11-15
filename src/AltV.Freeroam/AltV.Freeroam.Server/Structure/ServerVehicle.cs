using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Structure
{
    public class ServerVehicle : Vehicle
    {
        public ServerVehicle(IServer server, uint model, Position position, Rotation rotation) : base(server, model, position, rotation)
        {

        }

        public ServerVehicle(IServer server, IntPtr nativePointer, ushort id) : base(server, nativePointer, id)
        {

        }
    }
}
