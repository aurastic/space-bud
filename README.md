# Space Bud ~ ![image](https://user-images.githubusercontent.com/67746675/148153092-5e0789ba-4f2d-4765-a6f2-a2d5d28baf22.png) ![image](https://user-images.githubusercontent.com/67746675/148153527-7c31477b-2673-465a-b46d-a9c2ffbd4e72.png)



Space Bud is my current game development project built on the Unity Engine. It's a dispensary simulation game that lives on Mars, and the main objectives are to survive until the end of the shift while dealing with unpredictable patients (who are sometimes human, sometimes alien!). It'll offer users the experience of managing a dispensary, its employees, and more, all on the surface of Mars.

I've dedicated over 90 hours to this project so far, and I'm excited for its completion!

As of 1.4.2022, I've decided to make this project open source.

![image](https://user-images.githubusercontent.com/67746675/148143629-94f68832-2811-4732-95bc-c658c451498c.png)


## Game Architecture ~ ![image](https://user-images.githubusercontent.com/67746675/148153320-0a210a1e-3961-4eb7-a8c5-069f56ef03de.png)

As a short summary, patients appear at the dispensary and are assigned a sale state. The objective is to move the patient through the process of a sale by triggering events and managing patient lists. The process will involve an active sale state as the main component of the game. Here, the player can interact with the patient, give recommendations, and transfer objects to the patient's inventory. The player can manage employees, shop states, and can optionally route patients to employees during busy times. The game will also contain a mission system with specific patients and objectives. 

The focus of the project is to get the app out for the Android platform, but issues with Unity's new input system have put a hold on this task. For now, the input source is a mouse, and interaction and character movement is controlled by click events. 

There is a lot to be said about how the game works. A visual summary is available in the following map. After refactoring code, I realized that having abstract states for the sale and mood states was a little pointless, since events are running the decisions to switch animations or control patient movement. Therefore, some parts of the diagram are not up to date, but it still provides a good idea of how the game is structured. 

Click image to zoom in.

<img src="https://user-images.githubusercontent.com/67746675/148151140-5ed27054-4025-46bf-96f1-c9ff5345f76e.png" alt="img" width="480"/>

Note: Some parts of this diagram have changed as of recent updates to the code.
