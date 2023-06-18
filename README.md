# HandTrackingGame
The project is a consists of a hand tracking game with unity and mediapipe that allows the user to pick and move objects around with their hand.

## Files explanation
#### handTracking.py
In the "handTracking.py" file you can find the python script that does the hand tracking with mediapipe using a camera that you can change by changing the id in the VideoCapture() function.
The same script sends the mediapipe landmarks to a local server using the udp protocol.
#### Game
The "Game" folder contains all the assets of the unity game, the "UDPReceive.cs" is the C# code that allows me to get the landmarks coordinates from the local server.
We use the landmarks to recreate the hand in unity and make the desired functionality of the user being able to grab objects and move them around.
## Output

![ezgif-5-0f3e6b7dac](https://github.com/ahmedbenaissa/HandTrackingGame/assets/78700276/d97d015f-2d0b-4235-81b3-e16d3c314551)
