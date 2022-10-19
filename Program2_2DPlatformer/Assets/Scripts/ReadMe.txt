Feature 1:
I created a way to win and a way to lose in my game. To win you must get to the fire at the end of the level and if you fall you will lose. These are done with simple collision boxes that check a bool when collided with
and then loads the proper level either win or lose.

Feature 2:
I found a very cute 2D asset collection for free on the unity asset store called Sunny Land. I took the tile map and used the unity tile map feature to draw a scene and I created a state machine for the player using the character sprites
that the collection came with. The sprites were seperated already so all I needed to do was drag and drop them into the timeline for each animation state. 

Feature 3:
I chose to create a power-up. The power-up gives the player a multi-jump ability. The item has a trigger collider on it and a trigger event script that I created. The script activates any event when the object is triggered. So
I created a bool called can_fly and when the player enters the trigger the event sets the bool to true and activates an enumerator that will deactivate the ability after a set time (which happens to be 5 seconds in my game). Then
the player goes back to normal jumping.

Feature 4:
I added an alternate path that would give the player the opportunity to obtain an item and make the level easier. Granted to get to the item it is quite challenging so there is a trade off. Either do something difficult early and
then have an easier time for the other part of the level or go the easier route and have a harder time at the end of the level. This creates a couple of ways to beat the level because the player could get this item and fly to the
end or fly and take their time and get past the first set of platforms or they could skip the item and attempt to get to the end traditionally.