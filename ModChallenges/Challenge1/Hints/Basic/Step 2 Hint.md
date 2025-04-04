## 🧠 Helpful Hints & Reminders

1. **Shooting a projectile is a default weapon property**  
  There must be a way we can tell tModLoader that our item shoots a projectile in the `SetDefaults()` method.

2. **Accessing modded content is different than vanilla content.**
  You can access a modded projectile as such:
```csharp
ModContent.ProjectileType<ProjectileClassName>() 
// where 'ProjectileClassName' is the class of your projectile
```