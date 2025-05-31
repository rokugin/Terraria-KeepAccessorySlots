using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace KeepAccessorySlots.Common.Players {
    public class AccessoryPlayer : ModPlayer {

        public bool UsedDemonSoul = false;

        public override void SaveData(TagCompound tag) {
            tag["UsedDemonSoul"] = UsedDemonSoul;
        }

        public override void LoadData(TagCompound tag) {
            UsedDemonSoul = tag.GetBool("UsedDemonSoul");
        }

    }
}
