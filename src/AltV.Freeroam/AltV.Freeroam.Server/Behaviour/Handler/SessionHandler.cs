using AltV.Freeroam.Server.Structure;
using AltV.Net;
using AltV.Net.Async;
using AltV.Net.Data;

namespace AltV.Freeroam.Server.Behaviour.Handler
{
    public class SessionHandler : IScript
    {
        [AsyncScriptEvent(ScriptEventType.PlayerConnect)]
        public async Task OnPlayerConnect(ServerPlayer player, string reason)
        {
            if (player is null || !player.Exists)
                throw new ArgumentNullException(nameof(player));

            var socialClubId = player.SocialClubId;
            Alt.Log($"{socialClubId} is trying to connect.");

            var model = Alt.Hash("mp_m_freemode_01");
            var dim = 0;
            var spawnPos = new Position(0f, 0f, 72f);
            var rotation = new Rotation(0f, 0f, 0f);

            await player.SetModelAsync(model);
            await player.SetDimensionAsync(dim);
            await player.SpawnAsync(spawnPos);
            await player.SetRotationAsync(rotation);

            await Task.Delay(100);

            Alt.Log($"{socialClubId} connected.");
        }
    }
}
