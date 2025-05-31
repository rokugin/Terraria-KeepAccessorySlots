using KeepAccessorySlots.Common.Players;
using KeepAccessorySlots.Configs;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KeepAccessorySlots {

    public class KeepAccessorySlots : Mod {

        public override void Load() {
            On_Player.IsItemSlotUnlockedAndUsable += On_IsItemSlotUnlockedAndUsable;
        }

        public override void Unload() {
            On_Player.IsItemSlotUnlockedAndUsable -= On_IsItemSlotUnlockedAndUsable;
        }

        private bool On_IsItemSlotUnlockedAndUsable(On_Player.orig_IsItemSlotUnlockedAndUsable orig, Player self, int slot) {
            ClientConfig config = ModContent.GetInstance<ClientConfig>();


            if (!config.ProgressionMode) {
                return slot is 8 or 9 || orig.Invoke(self, slot);
            }
            
            if (slot is 8 && self.extraAccessory == true && config.ExpertSlot) {
                return true;
            }

            if (slot is 9 && self.GetModPlayer<AccessoryPlayer>().UsedDemonSoul && config.MasterSlot) {
                return true;
            }

            return orig.Invoke(self, slot);
        }

    }
}