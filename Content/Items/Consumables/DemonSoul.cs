using KeepAccessorySlots.Common.Players;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace KeepAccessorySlots.Content.Items.Consumables {
    public class DemonSoul : ModItem {

        public static LocalizedText ConsumedTooltip { get; private set; }

        public override void SetStaticDefaults() {
            ConsumedTooltip = this.GetLocalization("ConsumedTooltip");

            ItemID.Sets.SortingPriorityMaterials[Item.type] = 3335;

            ItemID.Sets.ItemNoGravity[Item.type] = true;
        }

        public override void SetDefaults() {
            Item.width = 80;
            Item.height = 80;
            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.sellPrice(0, 4);
            Item.rare = ItemRarityID.LightRed;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.master = true;
            Item.useTime = 30;
            Item.consumable = true;
            Item.useAnimation = 30;
            Item.UseSound = SoundID.Item4;
        }

        public override bool CanUseItem(Player player) {
            bool canUse = false;
            if (!player.GetModPlayer<AccessoryPlayer>().UsedDemonSoul && Main.masterMode) canUse = true;
            return canUse;
        }

        public override bool? UseItem(Player player) {
            if (player.GetModPlayer<AccessoryPlayer>().UsedDemonSoul) return null;

            player.GetModPlayer<AccessoryPlayer>().UsedDemonSoul = true;

            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            if (Main.LocalPlayer.GetModPlayer<AccessoryPlayer>().UsedDemonSoul) {
                var line = new TooltipLine(Mod, "ConsumedTooltip", ConsumedTooltip.Value) {
                    OverrideColor = new Microsoft.Xna.Framework.Color(80, 200, 120)
                };
                tooltips.Add(line);
            }
        }

    }
}
