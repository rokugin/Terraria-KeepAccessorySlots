using KeepAccessorySlots.Configs;
using KeepAccessorySlots.Content.Items.Consumables;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace KeepAccessorySlots.Common.GlobalNPCs {
    public class CustomNPCLoot : GlobalNPC {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
            if (ModContent.GetInstance<ServerConfig>().EnableDemonSoul && npc.type == NPCID.WallofFlesh) {
                npcLoot.Add(new DropLocalPerClientAndResetsNPCMoneyTo0(ModContent.ItemType<DemonSoul>(), 1, 1, 1, new Conditions.IsMasterMode()));
            }
        }

    }
}
