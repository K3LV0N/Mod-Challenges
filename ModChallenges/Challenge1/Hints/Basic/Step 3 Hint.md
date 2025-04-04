## 🧠 Helpful Hints & Reminders

1. **Projectiles can apply effects when hitting.**  
  Projectiles have a function that allows them to do effects **on hitting an NPC**.

2. **`AddBuff()` is a useful function for Player and NPC objects.**
  You will need to access the buff. I wonder if `ModContent` has a `BuffType<>()` function?

3. **Terraria plays in ticks.**
  Remember that terraria calls `Update()` **60 times per second**. So make sure you are using the correct values for how long the buff should be applied for.