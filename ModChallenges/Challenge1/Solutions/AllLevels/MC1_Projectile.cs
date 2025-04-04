using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModChallengeSolutions.ModChallenges.Challenge1.Solutions.AllLevels
{
    public class MC1_Projectile : ModProjectile
    {
        public override void SetDefaults()
        {
            // dimensions of our projectile
            Projectile.width = 8;
            Projectile.height = 12;

            // this solution will have the projectile be an arrow
            Projectile.aiStyle = ProjAIStyleID.Arrow;
            Projectile.arrow = true;

            // if our projectile does damage to enemies, and what damage type it is
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Melee;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            // terraria is in 60 ticks per second
            int seconds = 10;
            int ticks = seconds * 60;

            // add our buff to our target
            target.AddBuff(ModContent.BuffType<MC1_Buff>(), ticks);
        }
    }
}
