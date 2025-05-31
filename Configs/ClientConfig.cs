using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace KeepAccessorySlots.Configs {
    public class ClientConfig : ModConfig {

        public override ConfigScope Mode => ConfigScope.ClientSide;

        const string ProgLabel = "$Mods.KeepAccessorySlots.Configs.Common.ProgLabel";
        const string ProgTooltip = "$Mods.KeepAccessorySlots.Configs.Common.ProgTooltip";
        const string SlotsHeader = "$Mods.KeepAccessorySlots.Configs.Common.SlotsHeader";
        const string ExpertLabel = "$Mods.KeepAccessorySlots.Configs.Slots.ExpertLabel";
        const string ExpertTooltip = "$Mods.KeepAccessorySlots.Configs.Slots.ExpertTooltip";
        const string MasterLabel = "$Mods.KeepAccessorySlots.Configs.Slots.MasterLabel";
        const string MasterTooltip = "$Mods.KeepAccessorySlots.Configs.Slots.MasterTooltip";
        
        [LabelKey(ProgLabel), TooltipKey(ProgTooltip)]
        [DefaultValue(true)]
        public bool ProgressionMode;

        [Header(SlotsHeader)]
        [LabelKey(ExpertLabel), TooltipKey(ExpertTooltip)]
        [DefaultValue(true)]
        public bool ExpertSlot;

        [LabelKey(MasterLabel), TooltipKey(MasterTooltip)]
        [DefaultValue(true)]
        public bool MasterSlot;

    }
}
