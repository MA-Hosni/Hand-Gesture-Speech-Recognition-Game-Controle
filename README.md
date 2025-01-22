# Hand Gesture & Speech Recognition Game Controller

## Introduction
This project features a 2D endless runner Unity game controlled by innovative hand gesture and speech recognition technologies. The system combines a Unity-based game (gamePart) with a Deep Learning-based model (DLpart) for gesture and speech recognition, providing a unique interactive gaming experience.

## How to Clone the Repository
To get started, you need to clone this repository from GitHub. Follow these steps:

1. Open a terminal or command prompt on your machine.
2. Navigate to the directory where you want to clone the repository.
3. Run the following command:
   ```bash
   git clone https://github.com/MA-Hosni/Hand-Gesture-Speech-Recognition-Game-Controle.git
   ```
4. Navigate to the project directory:
   ```bash
   cd Hand-Gesture-Speech-Recognition-Game-Controle
   ```

## Setting Up the Unity Game (gamePart)

### Prerequisites
- Install [Unity Hub](https://unity.com/download).

### Steps to Run the Game
1. Open Unity Hub.
2. From the Unity Hub interface, click on the **Installs** tab.
3. Click **Add** and select **2022.3.3f1** from the Unity archive. If this version is not visible, download it from the [Unity Archive](https://unity.com/releases/editor/archive).
4. After installing the correct Unity version, click on the **Projects** tab in Unity Hub.
5. Click **Add Project from Disk**.
6. Navigate to the following folder:
   ```
   Hand-Gesture-Speech-Recognition-Game-Controle/gamePart
   ```
7. Select the folder and click **Open**.
8. Once the project loads in Unity, you can run the game by clicking the **Play** button in the Unity Editor.

## Running the Deep Learning Model (DLpart)

### Prerequisites
- Install Python 3.8 or above.
- Ensure you have pip installed.
- Install the required dependencies.

### Gesture Recognition Script
The gesture recognition script uses OpenCV, MediaPipe, and PyAutoGUI to detect hand gestures and trigger specific actions.

#### Steps to Run:
1. Navigate to the `DLpart` directory:
   ```bash
   cd Hand-Gesture-Speech-Recognition-Game-Controle/DLpart
   ```
2. Create a virtual environment (optional but recommended):
   ```bash
   python -m venv venv
   source venv/bin/activate  # On Windows: venv\Scripts\activate
   ```
3. Install the required Python libraries:
   ```bash
   pip install opencv-python mediapipe pyautogui
   ```
4. Run the gesture recognition script:
   ```bash
   python gesture_recognition.py
   ```
   Replace `gesture_recognition.py` with the actual file name if different.

#### Gesture Actions:
- **1 Finger**: Presses "Z".
- **2 Fingers**: Presses "S".
- **5 Fingers**: Presses "Space".

### Speech Recognition Script
The speech recognition script uses the SpeechRecognition and PyAutoGUI libraries to recognize commands and interact with the game.

#### Steps to Run:
1. Ensure you are in the `DLpart` directory:
   ```bash
   cd Hand-Gesture-Speech-Recognition-Game-Controle/DLpart
   ```
2. Create and activate a virtual environment (if not already done).
3. Install the required Python libraries:
   ```bash
   pip install SpeechRecognition pyautogui pyttsx3
   ```
4. Run the speech recognition script:
   ```bash
   python speech_recognition.py
   ```
   Replace `speech_recognition.py` with the actual file name if different.

#### Voice Commands:
- Commands like "play," "settings," "music on," "exit," and others trigger corresponding actions in the game.
- Say "goodbye" to safely exit the script.

## Features
- **Hand Gesture Recognition**: Control the game with specific hand gestures.
- **Speech Recognition**: Execute in-game actions via voice commands.
- **Endless Runner Gameplay**: Navigate through the game world and set high scores.

## Contribution
Feel free to contribute to this project by forking the repository and submitting pull requests. Suggestions and feedback are welcome.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

For any issues or queries, please open an issue in this repository or contact the project maintainer.

