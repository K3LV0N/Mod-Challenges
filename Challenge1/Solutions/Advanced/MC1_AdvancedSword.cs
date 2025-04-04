using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ModChallengeSolutions.Challenge1.Solutions.AllLevels;
using Terraria.DataStructures;

namespace ModChallengeSolutions.Challenge1.Solutions.Advanced
{ 

	public class MC1_AdvancedSword : ModItem
	{

		bool canShootShot;
        int baseDamage;
        int maxDamage;
        int ticks;
        int dpsIncrease;
		// Set the default stats and properites of our sword here
		public override void SetDefaults()
		{
            // THESE STATS ARE CHANGED IN ADVANCED!!!!!!
            // THESE STATS ARE CHANGED IN ADVANCED!!!!!!
            // THESE STATS ARE CHANGED IN ADVANCED!!!!!!
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
            // THESE STATS ARE CHANGED IN ADVANCED!!!!!!
            // THESE STATS ARE CHANGED IN ADVANCED!!!!!!
            // THESE STATS ARE CHANGED IN ADVANCED!!!!!!

            // Make our sword shoot the projectile
            Item.shoot = ModContent.ProjectileType<MC1_Projectile>();
            Item.shootSpeed = 10f;

            // this is to make our sword shoot once every 2 swings
            canShootShot = false;


            /* STEP 1 FOR ADVANCED */

            baseDamage = 10;
            maxDamage = baseDamage + 8;
            dpsIncrease = 1;
            ticks = 0;

            Item.damage = baseDamage;
            /* STEP 1 FOR ADVANCED */
        }

        /* STEP 1 FOR ADVANCED */

        // increase ticks once per frame
        public override void HoldItem(Player player)
        {
            ticks++;
        }

        // modify our weapon's damge
        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
            // damage per tick increase
            float dptIncrease = (float)(dpsIncrease) / 60;
            float increasedDamage = Item.damage + (ticks * dptIncrease);

            // cap our damage
            damage.Base = MathHelper.Min(maxDamage, increasedDamage);
        }
        /* STEP 1 FOR ADVANCED */




        // this is how we will make our weapon shoot once every 2 swings
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            canShootShot = !canShootShot;
            return canShootShot;
        }

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


        // Our sword can be made with 1 dirt block anywhere
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.Register();
        }
    }
}
