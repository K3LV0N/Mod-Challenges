## 🧠 Helpful Hints & Reminders

1. **Booleans are great for 1 in every 2**  
  Try flip-flopping a boolean to deal with **1 projectile every 2 swings**.

2. **Where to change vanilla shooting behaviour**
  Item has `CanShoot()` but I believe it can be called multiple times per usage, which would be hard to work around. Maybe we can just change the logic in `Shoot()` instead.
