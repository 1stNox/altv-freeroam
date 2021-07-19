﻿using System;
using AltV.Freeroam.Structure;
using AltV.Net;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Creational
{
    public class ServerVehicleFactory : IEntityFactory<IVehicle>
    {
        public IVehicle Create(IServer server, IntPtr entityPointer, ushort id)
        {
            return new ServerVehicle(server, entityPointer, id);
        }
    }
}