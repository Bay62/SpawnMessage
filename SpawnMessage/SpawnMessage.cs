namespace SpawnMessage
{
    using MEC;
    using PlayerRoles;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;

    public class SpawnMessage
    {
        public enum MessageType
        {
            Broadcast,
            Hint
        };

        [PluginEntryPoint("SpawnMessage", "1.0.1", "Send a Broadcast or Hint when a player spawn.", "Bay")]
        void Enabled()
        {
            if (Config.IsEnabled) EventManager.RegisterEvents(this);
        }

        [PluginEvent(ServerEventType.PlayerSpawn)]
        void OnPlayerSpawn(Player player, RoleTypeId roleTypeId)
        {
            Timing.CallDelayed(1, () =>
            {
                if (Config.Message.TryGetValue(roleTypeId, out string message))
                {
                    switch (Config.SpawnMessageType)
                    {
                        default: player.ReceiveHint(message, Config.MessageTime); break;
                        case MessageType.Broadcast: player.SendBroadcast(message, (ushort)Config.MessageTime); break;
                    }
                }
            });
        }

        [PluginConfig] 
        public Config Config;
    }
}
