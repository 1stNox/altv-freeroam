using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Structure
{
    public class ServerVehicle : Vehicle
    {
        public ServerVehicle(ICore core, IntPtr nativePointer, ushort id) : base(core, nativePointer, id)
        {
        }
    }
}
