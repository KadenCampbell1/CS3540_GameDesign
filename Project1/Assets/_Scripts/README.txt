Build: Windows
Feature 1 (A way to win): I created a "passenger" character that the player has to protect and guide to the
	blue area of the map. Once the passenger enters the blue area you win. If the passenger gets shot either
	by an enemy or by yourself you lose. To implement this passenger I adapted the wanderingAI script that
	the book uses to have a bool that checks if it is an enemy type or not and that determines if it will
	shoot the player. Then I have a lose condition script on an empty game object and I adapted the
	PlayerController and the ReactiveTarget scripts to send a bool to the lose condition object that checks 
	and loads a lose scene when it is true. The win condition is a trigger on an empty game object and it checks 
	what object triggered it and if it was the passenger then it loads a win scene. I also adapted the 
	ReactiveTarget script to check if it can lose when the object dies so that the player can lose by shooting
	the passenger.
Feature 2 (graphics): I created rocks and a bullet model (loosely inspired by the bullet bill from mario). 
	The enemys shoot the bullets and the rocks are scattered through the map. I also found tileable textures
	for the environment models. I also added a skybox with an alien world design. I found it on the Unity asset
	store and imported it using the package manager.

To close you'll have to hit Alt+F4