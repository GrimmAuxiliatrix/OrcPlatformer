# OrcPlatformer

HOW TO MAKE THE ORC NOT GO THROUGH EVERYTHING:<br>
-Set the orc's collider to isTrigger.<br>
-Make a new empty gameObject.<br>
-Make this gameObject a child of the orc, and then drag it over to the orc in the scene.<br>
-Give the empty gameObject a 2D box collider, and then edit the collider so that it is slightly smaller than the orc's collider. DON'T make this one a trigger.
<br><br>

HOW TO SET UP FOR PLATFORM AND ORC GENERATION this is simpler:<br>
-Delete two of the platforms from the heirarchy
-Select the remaining one and change its x-scale from 20 to 15
-Drag it to the prefabs folder and then delete it from the heirarchy
-Drag the orc to the prefabs folder and then delete it from the heirarchy (make sure the score count and everything else works first!)
-Use those two prefabs for the new variables in the GemSpawn script

orcplatformer3 is the working build of the game
