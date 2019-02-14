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
The important part of this project is to help learn basics of 2D with Unity. The core building blocks are there for you to go and design your own 2D Top Down Shooter. You can configure how the enemies shoot, the paths they take, how much health the player has, how much damange it does, and more. Use the following guide below to help configure.

#### Adding Enemies ####
Adding or modifying an ememy is easy. All enemies are done with a prefab. The game current has the following enemies:
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
* Projectile - The projectile prefab the enemy will use when firing
* Projectile Speed - How fast the enemies projectile goes
* Sound Effects - The sound effects configurations to use for the enemy (Shooting and death). See SoundEffectConfigs to create the sound effects for the enemies.

If you wanted to create a new Enemy it would be as simple as duplicating an existing prefab and modifying the configurations the way you want the enemy to act.

### Adding Enemy Paths ###
Enemy paths are just a group of empty game objects that define the positions you want the enemies to move towards.

To create a new path, just duplicate one of the existing Path prefabs. Drag this into a scene and move the indvidual waypoints to different locations you would like an enemy to move towards. Once done and satisfied just click "Apply" for apply those changes back to the prefab. Each individual waypoint has a Yellow Icon so you can easily see the different positions.

### Creating New EnemyWaves ###
Enemy Wave Configs is a scriptable object that can be created from the asset menu. These define a wave of enemies that will come on the screen and shoot at the player. You can decide which enemy this wave is for, what path it should take, the time between the spawns, how often a new one will spawm, the number of enemies this wave will have in it, and the movement speed.

In the EnemyWaves folder right click and create a new Enemy Wave Config. Define your configurations you would like for this wave.

### Creating Projectiles ###
To create a new projectile, duplicate one of the existing project prefabs.
Set the sprite you would like for this projectile.
in the DamageDealer component define how much damage this projectile will do.

Once your projectile is created it is good to make sure you have enemy using this new projectile.

### SoundEffectConfigs ###
You can define and create new sound effect configs for both the player and enemy.
In the SoundEffectConfigs folder right click and click create Player Sound Effects or Enemy Sound Effects.
Drag in your death effect and shooting sound effect and set the volume for each one.
