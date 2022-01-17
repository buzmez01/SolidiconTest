# SolidiconTest

I would like to say, thank you all for giving me this job opportunity. 

First of all, I want to express my deep apologies for not finishing the project. While I was implementing the task, I realized that I still need to learn many things from game development, both the technical design side and Unity side. However, I did my best for implementing this project. 

What is done? I implemented the rotation way of the ball and player. I used raycast, that’s why it cannot be seen from game mode.

# Ball Side
Before beginning the actual solution, I tried to raycast from the ball’s game object position to the ball’s game object local x rotation. They are not consistent for the ball’s path, that’s why I gave up that idea. After that, by using current and next position information, I implemented the raycast operation. In BallTransformSystem.cs, I created 2 Vector3 (linePoint, lineVector). One is for the position, another one is for the direction of the ball. I wrote a code in 2 comment area, which is called My Coding Part. In there, I implemented position and direction, and used raycast operation for showing the ball’s direction. While I was writing this, I realized that I could calculate the speed of the ball by taking the determinant of the direction vector. 

# Player Side
I implemented the same raycast operation in BallTransformSystem.cs. For the player side, I implemented it in PlayerTransformSystem.cs. This time, I made linePoint and lineVector array, since there are 22 players. You can see it in My Coding Part comment area. 

# Ball-Player Intersection Side 
I tried to implement this in the GameManager side. I know and am aware of the fact that implementing it here is complete nonsense. However, for the sake of prototyping, I tried to implement it in here. I had both ball and player information, therefore I focused on the algorithm. Unfortunately, I couldn’t make it work. I realized that my 3D geometry skills are weakened. Maybe I should study Freya Holmer’s Math for Game Devs Tutorials and Jason Weimann tutorials more… Anyway, I tried to intersect different raycasts (I mean I tried to intersect ball’s raycast and players’ raycast) but I couldn’t succeed. They do not hit each other. However, I found a code about lineline interaction (https://stackoverflow.com/questions/59449628/check-when-two-vector3-lines-intersect-unity3d). I used it in Update method of GameManager.cs. I used a simple cube and its transform.position to show the intersection ball-player. It might work, it needs fine tuning. However, I need to study Freya’s tutorial because it’s been a long time since I’ve studied 3D Maths.

In conclusion, I wanted to implement a better solution, however, this is the best thing I’ve got. I wish I had more time to implement it, but I can’t. Because I’m well aware of the deadline I gave you.

Thank you for seeing me as a candidate.

Best wishes,

Bağışcan.
