using System;
using AltV.Net.Elements.Entities;

namespace AltV.Freeroam.Structure
{
    public class ServerPlayer : Player
    {
        public ServerPlayer(IntPtr nativePointer, ushort id) : base(nativePointer, id)
        {
            
        }
    }
}