namespace SpawnMessage
{
    using PlayerRoles;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config
    {
        [Description("Set if plugin is enabled or not.")]
        public bool IsEnabled { get; set; } = true;

        [Description("The message type, broadcast / hint.")]
        public SpawnMessage.MessageType SpawnMessageType = SpawnMessage.MessageType.Hint;

        [Description("The message to send when a player spawn.")]
        public Dictionary<RoleTypeId, string> Message { get; set; } = new Dictionary<RoleTypeId, string>
        {
            [RoleTypeId.ClassD] = "You're <#FF8E00>Class-D Personnel</color>.",
            [RoleTypeId.Scientist] = "You're <#FFFF7C>Scientist</color>.",
            [RoleTypeId.FacilityGuard] = "You're <#5B6370>Facility Guard</color>.",
            [RoleTypeId.Scp049] = "You're <#EC2121>SCP-049</color>.",
            [RoleTypeId.Scp0492] = "You're <#EC2121>SCP-049-2</color>.",
            [RoleTypeId.Scp079] = "You're <#EC2121>SCP-079</color>.",
            [RoleTypeId.Scp096] = "You're <#EC2121>SCP-096</color>.",
            [RoleTypeId.Scp106] = "You're <#EC2121>SCP-106</color>.",
            [RoleTypeId.Scp173] = "You're <#EC2121>SCP-173</color>.",
            [RoleTypeId.Scp939] = "You're <#EC2121>SCP-939</color>.",
            [RoleTypeId.NtfPrivate] = "You're <#6FC3FF>Nine-Tailed Fox Private</color>.",
            [RoleTypeId.NtfSergeant] = "You're <#0096FF>Nine-Tailed Fox Sergeant</color>.",
            [RoleTypeId.NtfCaptain] = "You're <#003ECA>Nine-Tailed Fox Captain</color>.",
            [RoleTypeId.ChaosConscript] = "You're <#008F1E>Chaos Insurgency Conscript</color>.",
            [RoleTypeId.ChaosRifleman] = "You're <#008F1E>Chaos Insurgency Rifleman</color>.",
            [RoleTypeId.ChaosMarauder] = "You're <#0A7D34>Chaos Insurgency Marauder</color>.",
            [RoleTypeId.ChaosRepressor] = "You're <#006728>Chaos Insurgency Repressor</color>.",
            [RoleTypeId.Spectator] = "You're <#D2D4C1>Spectator</color>.",
            [RoleTypeId.Tutorial] = "You're <#FC00AB>TUTORIAL</color>."
        };

        [Description("The seconds of the message.")]
        public float MessageTime = 15;
    }
}