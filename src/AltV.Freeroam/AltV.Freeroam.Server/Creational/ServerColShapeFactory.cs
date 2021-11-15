using AltV.Freeroam.Server.Structure;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Server.Creational
{
    public class ServerColShapeFactory : IBaseObjectFactory<IColShape>
    {
        public IColShape Create(IServer server, IntPtr baseObjectPointer)
        {
            return new ServerColShape(server, baseObjectPointer);
        }
    }
}
