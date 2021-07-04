using System;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Structure
{
    public class ServerVehicle : Vehicle
    {
        public ServerVehicle(uint model, Position position, Rotation rotation) : base(model, position, rotation)
        {
            
        }

        public ServerVehicle(IntPtr nativePointer, ushort id) : base(nativePointer, id)
        {
            
        }
    }
}