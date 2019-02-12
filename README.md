## Space Force ##
2d Top down shooter made in Unity. This game demonstrates the basics of creating a of top down shooter and is here for people to learn off of.
Currently the game has the following basic features:
* Scrolling background (Parallax Effect)
* Player Score and Health
* Multiple enemy types
* Particle Effects
* Enemy movement/waves on path
* Music/Sound Effects
* And More

---
### Project Structure ###
The project is layed out with the following structure to make it easy for you find where everything is. Everything Starts from the Assets Folder.
* Backgrounds - The different backgrounds you can use in the game
* Enemy Waves - The different enemy waves you can configure
* Fonts
* Materials - materials to use on particle effects
* Music - Different music availaible to use in the game
* Prefabs - Where to place different prefabs
  * Backgrounds - The background prefab
  * Enemy - Where the place Enemy Prefabs
  * Explosions - Explosion particle effects
  * Game Utilites - Prefabs for general gameplayer or misc.
  * Paths - The different paths the enemy will take
  * Player - the player prefab
  * Projectiles - The different projectiles for a player
* Scenes - The different scenes in the game
* Scripts
  * Enemy - Scripts to do with the enemy
  * Gameplay - Scripts to do with the gameplay or misc.
  * Player - Scripts to do with the player
* SoundEffectConfigs - The different sound effects configurations to use for a player or enemies
* Sounds - The different sounds availiable to use
* Sprites - The different sprites availiable to use.
* TextMeshPro - TextMeshPro asset files
---
### How To Learn ###
The important part of this project is to help learn basics of 2D with Unity. The core building blocks are there for you to go and design your own 2D Top Down Shooter. You can configure how the enemies shoot, the paths, they take, how much health the player has, how much damange it does, and more. Use the following guide below to help configure.

#### Adding Enemies ####
Adding or modifying an ememy is easy. All enemies are done by a prefab. The game current has the following enemies:
* Enemy Green
* Enemy Red
* Big Enemy

The enemy has the following proerties that you can config/change so you can design your enemy:
* Sprite
* Enemy Path (See Enemy Pathing)
* Enemy Health
* Enemy Score Value (how much the enemy is worth when killed)
* Min Time Between Shots - how long the enemy must wait before shooting again (cool down period)
* Max Time Between Shots - the longest the enemy will wait before shooting again
* Projectile - The profile prefab the enemy will use when firing
* Projectile Speed - How fast the enemies projectile goes
* Sound Effects - The sound effects configurations to use for the enemy (Shooting and death). See SoundEffectConfigs
