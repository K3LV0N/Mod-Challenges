## 🧠 Helpful Hints & Reminders

1. **Custom projectiles don't need complex AI!**  
  You can reuse existing AI styles — for example, using the default arrow AI by setting:
   ```csharp
   Projectile.aiStyle = ProjAIStyleID.Arrow;; // Arrow-style behavior
   ```
   This is a great way to get functionality fast without writing everything from scratch.

2. **Buffs work differently than items or projectiles.**
Unlike items and projectiles, buffs don’t have a `SetDefaults()` method.
To apply effects from buffs, you need to update values every frame.
👉 **Ask yourself:** Where in `ModBuff` can we **update** values every frame?

3. **Weapons should be craftable.**
To add a recipe for your weapon, override the `AddRecipes()` method in your ModItem: