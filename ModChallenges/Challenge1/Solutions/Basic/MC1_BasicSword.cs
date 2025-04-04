using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ModChallengeSolutions.ModChallenges.Challenge1.Solutions.AllLevels;

namespace ModChallengeSolutions.ModChallenges.Challenge1.Solutions.Basic
{ 

	public class MC1_BasicSword : ModItem
	{

		// Set the default stats and properites of our sword here
		public override void SetDefaults()
		{
			// these stats were all set by tModLoader's basic sword generation
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			// Make our sword shoot the projectile
			Item.shoot = ModContent.ProjectileType<MC1_Projectile>();
			Item.shootSpeed = 10f;

        }

        // Our sword can be made with 1 dirt block anywhere
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.Register();
        }
    }
}
