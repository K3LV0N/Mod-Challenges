using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ModChallengeSolutions.Challenge1.Solutions.AllLevels;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace ModChallengeSolutions.Challenge1.Solutions.Intermediate
{ 

	public class MC1_IntermediateSword : ModItem
	{

		bool canShootShot;
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


            /* STEP 1 FOR INTERMEDIATE */

            // this is to make our sword shoot once every 2 swings
            canShootShot = false;
            /* STEP 1 FOR INTERMEDIATE */

        }

        /* STEP 1 FOR INTERMEDIATE */

        // this is how we will make our weapon shoot once every 2 swings
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            canShootShot = !canShootShot;
            return canShootShot;
        }
        /* STEP 1 FOR INTERMEDIATE */


        /* STEP 2 FOR INTERMEDIATE */

        // this function allows us to use right click functionality when holding our weapon
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }


        // this will be where we check to see if the item is being used with a right click
        public override bool? UseItem(Player player)
        {

            if (player.altFunctionUse == 2)
            {
                // terraria is in 60 ticks per second
                int seconds = 10;
                int ticks = seconds * 60;

                player.AddBuff(ModContent.BuffType<MC1_Buff>(), ticks);
    
				// true means our item did something
                return true;
            }

            // null means vanilla behavior
            return null;
        }
        /* STEP 2 FOR INTERMEDIATE */




        // Our sword can be made with 1 dirt block anywhere
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.Register();
        }
    }
}
