import cv2
from cvzone.HandTrackingModule import HandDetector
import socket

width, height = 640, 360
# Webcam
cap = cv2.VideoCapture(1)
cap.set(3, width)
cap.set(4, height)

# Hand detector
detector = HandDetector(maxHands=2, detectionCon=0.8)

sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
serverAddressPort = ("127.0.0.1", 5052)
while True:
    # get the frame from cam
    success,img = cap.read()

    # Hands
    hands,img = detector.findHands(img)
    data = []
    if hands:
        hand = hands[0]
        lmList= hand['lmList']
        for lm in lmList:
            data.extend([lm[0],height-lm[1],lm[2]])
        print(data)
        sock.sendto(str.encode(str(data)), serverAddressPort)
    cv2.imshow("Image",img)
    cv2.waitKey(20)
