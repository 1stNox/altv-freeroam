using AltV.Freeroam.Server.Structure;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Creational
{
    public class ServerVehicleFactory : IEntityFactory<IVehicle>
    {
        public IVehicle Create(ICore core, IntPtr entityPointer, ushort id)
        {
            return new ServerVehicle(core, entityPointer, id);
        }
    }
}
