using System;
using AltV.Freeroam.Structure;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.Resources.Chat.Api;

namespace AltV.Freeroam.Behaviour.Handler
{
    public class CommandHandler : IScript
    {
        [Command("tp")]
        public void TeleportPlayer(ServerPlayer player, float x, float y, float z)
        {
            if (player is null || !player.Exists)
                throw new ArgumentNullException(nameof(player));

            var socialClubId = player.SocialClubId;
            
            player.SetPosition(x, y, z);
            
            Alt.Log($"{socialClubId} teleported to {x} {y} {z}");
        }

        [Command("veh")]
        public void SpawnVehicle(ServerPlayer player, string vehName)
        {
            if (player is null || !player.Exists)
                throw new ArgumentNullException(nameof(player));
            if (vehName is null)
                throw new ArgumentNullException(nameof(vehName));

            var socialClubId = player.SocialClubId;
            var vehicle = player.Vehicle;

            vehicle?.Remove();
            
            var newVehicle = Alt.CreateVehicle(vehName, player.Position, player.Rotation);
            newVehicle.EngineOn = true;
            newVehicle.LockState = VehicleLockState.Unlocked;
            
            Alt.Log($"{socialClubId} spawned {vehName}");
        }

        [Command("pos")]
        public void GetPosition(ServerPlayer player)
        {
            if (player is null || !player.Exists)
                throw new ArgumentNullException(nameof(player));

            var socialClubId = player.SocialClubId;
            var pos = player.Position;
            
            player.Emit("Command:Pos:Print", pos);
            Alt.Log($"{socialClubId} is at pos {pos}");
        }

        [Command("rot")]
        public void GetRotation(ServerPlayer player)
        {
            if (player is null || !player.Exists)
                throw new ArgumentNullException(nameof(player));

            var socialClubId = player.SocialClubId;
            var rot = player.Rotation;

            player.Emit("Command:Rot:Print", rot);
            Alt.Log($"{socialClubId} has rot {rot}");
        }
    }
}