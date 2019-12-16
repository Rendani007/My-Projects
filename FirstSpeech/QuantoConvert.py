from PyQt5.QtWidgets import QApplication, QPushButton, QDialog, QTextEdit, QVBoxLayout, QFileDialog, QMessageBox
import sys
from PyQt5.QtGui import QFont
import speech_recognition as sr

class Window(QDialog):
    def __init__(self):
        super().__init__()

        self.title = "QConvert"
        self.top = 250
        self.left = 250
        self.width = 400
        self.height = 300

        self.setWindowTitle(self.title)
        self.setGeometry(self.top, self.left, self.width, self.height)
        #calling the method
        self.InitUI()


    #Method with VBox layout, Text edit and a button
    def InitUI(self):
        vbox = QVBoxLayout() #this is the white screen

        self.texEdit = QTextEdit(self)
        self.texEdit.setFont(QFont("Times", 12))
        vbox.addWidget(self.texEdit)
        self.setLayout(vbox)

        # Creating the button Browse File
        self.btn = QPushButton("Open File")
        self.btn.clicked.connect(self.openfile)
        vbox.addWidget(self.btn)

        # Creating the button Record Audio
        self.btn = QPushButton("Record Audio")
        self.btn.clicked.connect(self.Recordaudio)
        vbox.addWidget(self.btn)

        # Creating the display in text
        self.btn =QPushButton("Display Text")
        self.btn.clicked.connect(self.DisplayText)
        vbox.addWidget(self.btn)

    # Method for converting audio and saves local
    def Recordaudio(self):
        r = sr.Recognizer()
        with sr.Microphone() as source:
            r.adjust_for_ambient_noise(source)

            print('Say something :')

            audio = r.listen(source)

            print("Recognizing Now ....")

            try:

                print("you said \n " + r.recognize_google(audio))
                print("Audio Recorder success \n ")

            except Exception as e:
                print("Error : " + str(e))

            with open("NewAudio.wav", "wb") as f:
                f.write(audio.get_wav_data())

    # Button that plays back Audio
    def openfile(self):
        filename = QFileDialog.getOpenFileName(self, "Open File", "/home")

        if filename[0]:
         f = open(filename[0], 'r')

        with f:
                data = f.read()
                self.texEdit.setText(data)

    # Button to add audio to text field
    def DisplayText(self):
        rec = sr.Recognizer()
        audioF = 'NewAudio.wav'

        with sr.AudioFile(audioF) as sourceF:
            audio = rec.record(sourceF)
            print('File Reading')

            print('File text is')
        try:
            text = rec.recognize_google(audio)
            self.texEdit.setText(text)
        except Exception as e:
            print(e)




#Creating your application
app = QApplication(sys.argv)
window = Window() #window object
window.show()
app.exec()