using System;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Structure
{
    public class ServerColShape : ColShape
    {
        public ServerColShape(IServer server, IntPtr nativePointer) : base(server, nativePointer)
        {
            
        }
    }
}