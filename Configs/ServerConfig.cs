using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace KeepAccessorySlots.Configs {
    public class ServerConfig : ModConfig {

        public override ConfigScope Mode => ConfigScope.ServerSide;

        const string ItemHeader = "$Mods.KeepAccessorySlots.Configs.Common.ItemHeader";
        const string DemonSoulLabel = "$Mods.KeepAccessorySlots.Configs.Item.DemonSoulLabel";
        const string DemonSoulTooltip = "$Mods.KeepAccessorySlots.Configs.Item.DemonSoulTooltip";

        [Header(ItemHeader)]
        [LabelKey(DemonSoulLabel), TooltipKey(DemonSoulTooltip)]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool EnableDemonSoul;

    }
}
