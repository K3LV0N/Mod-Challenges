using Terraria;
using Terraria.ModLoader;

namespace ModChallengeSolutions.ModChallenges.Challenge1.Solutions.AllLevels
{

    public class MC1_Buff : ModBuff
    {
        // Use the Update() methods to make our buff do things
        public override void Update(Player player, ref int buffIndex)
        {
            // increase our defense
            player.statDefense += (int)(player.statDefense * .125);
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            // lower the NPCs defense
            npc.defense = (int)(npc.defDefense * .75);
        }
    }
}