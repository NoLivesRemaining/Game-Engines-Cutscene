# Game-Engines-Cutscene

Link to Game Cutscene:

https://www.youtube.com/watch?v=VxqZEjdEx5Q


# Description of the Assignment:

For this assignment we were to recreate a cutscene/scene of a space battle from a favourite show/game/etc. in Unity using code, etc. instead of animations. I recreated the ending cutscene of the game Xcom: Enemy Unknown where one of the players soldiers sacrifices themselves to prevent an alien mothership from destroying the Earth as it self implodes.

# Instructions

The cutscene will play automatically as you open the build, it is made to be built in Unity for Windows 

# How it Works

The project moves from scene to scene using simple countdown timers with time.deltaTime that I made to sync it up with camera changes in the actual cutscene its based off of. The 3D models and their animations are from Mixamo and they are triggered by OnTriggerEnter colliders and time.deltaTime countdowns. There are several pulsating objects, such as the motherships control orb, that have a fun bit of code that rapidly changes its scale between 1 and -1 (that can be altered to things like 0 to 2 and 1 to 3, so fourth) over a period of time thats multiplier can be changed by adjusting the multiplier. In the outside scenes a large number of objects get pulled towards the underside of the space ship and away from the city buildings, this is a flocking algorithm that makes use of cohesion, avoidance, allignment and a fourth behaviour that guides them towards a certain point. The objects that are pulled towards the behaviour point are also instantiated by an adjustable flock script.

# What I'm most proud of

I'm most proud of my use of the flocking algorithm underneath the mothership to give it the visual effect of the ship pulling the ocean up towards it similar to the original cutscene.
