import speech_recognition
import pyautogui
import pyttsx3
import time

# Initialize the recognizer and text-to-speech engine
rec = speech_recognition.Recognizer()
engine = pyttsx3.init()

# Safe exit setup
pyautogui.FAILSAFE = True

def click_at_coordinates(x1, y1, clicks=1):
    """Click at specified coordinates"""
    current_x, current_y = pyautogui.position()  # Save current position
    pyautogui.moveTo(x1, y1)
    pyautogui.click(clicks=clicks)
    pyautogui.moveTo(current_x, current_y)  # Return to original position

# Define the coordinates for actions
action_coordinates = {
    "play": (965, 364),
    "settings": (968, 550),
    "close": (1159, 158),
    "music on": (1108,347),
    "music off": (1108,347),
    "sound on": (1090,347),
    "sound off": (1090,439),
    "exit": (972, 750),
    "level one": (708, 484),
    "pause": (1867, 49),
    "resume": (961, 541),
    "restart": (1305, 541),
    "main menu": (625, 541),
    "next": (960, 875),
    "replay": (1305, 875),
    "home": (625, 875),
    "yes": (78, 778),
    "no": (1208, 780)
}

def speak(text):
    """Speak the given text using pyttsx3"""
    engine.say(text)
    engine.runAndWait()

def main():
    print("Listening for commands. Say 'goodbye' to stop.")
    speak("Listening for commands. Say 'goodbye' to stop.")
    
    while True:
        try:
            # Use microphone to capture speech
            with speech_recognition.Microphone() as mic:
                rec.adjust_for_ambient_noise(mic, duration=0.2)
                print("Listening...")
                audio = rec.listen(mic, timeout=5)

                # Recognize speech
                text = rec.recognize_google(audio)
                text = text.lower()

                print(f"Recognized: {text}")

                if text == "goodbye":
                    print("Exiting... Goodbye!")
                    speak("Exiting. Goodbye!")
                    break

                # Trigger corresponding action if the command matches
                if text in action_coordinates:
                    x, y = action_coordinates[text]
                    click_at_coordinates(x, y)
                    print(f"Executed action: {text}")
                    speak(f"Executed action: {text}")

        except speech_recognition.UnknownValueError:
            print("Sorry, I didn't catch that. Please try again.")
            speak("Sorry, I didn't catch that. Please try again.")

        except speech_recognition.WaitTimeoutError:
            print("No speech detected. Please try again.")
            speak("No speech detected. Please try again.")

        except Exception as e:
            print(f"An error occurred: {e}")
            speak("An error occurred. Please check the console for details.")

        time.sleep(0.01)  # Small delay to prevent high CPU usage

if __name__ == "__main__":
    main()
