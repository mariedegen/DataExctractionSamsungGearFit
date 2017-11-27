"""
The controller of the samsung view (interface.py)
"""
 
from PyQt5 import QtGui, QtCore, QtWidgets
from PyQt5.QtGui import *
from PyQt5.QtCore import *
from PyQt5.QtWidgets import *
import sys

import threading
from multiprocessing import Queue

import interface
import catalogFunction
import client_network
import json
 
class ImageViewer(QtWidgets.QMainWindow, interface.Ui_MainWindow):
    """
        The controller class of the samsung view
        :param QtWidgets.QMainWindow: the type of the main window
        :param interface.Ui_MainWindow: to leak with the view 
    """

    def __init__(self, parent=None):
        """
            To initialize the window
            :param self: the object
            :param parent: the parent of the window
        """
        super(ImageViewer, self).__init__(parent)
        self.setupUi(self)

        #attribut the data array
        self.data = []

        #attribut of the catalog
        self.functionGraph = catalogFunction.CatalogFunction()
        
        #handle the click
        self.emotionGo.clicked.connect(self.handleButtonGo)
        self.actionExit.triggered.connect(self.closeIt)
        self.actionExport.triggered.connect(self.exportData)
        self.actionImport.triggered.connect(self.importData)
        self.emotionChoice.currentIndexChanged.connect(self.emotionChoiceIndex)

        my_queue = Queue()
        thread2 = threading.Thread(target = self.actualizeGraphic, args = (self.data,))
        thread2.start()

    def actualizeGraphic(self, data):
        """
            To show the graphic with data 
            :param self: the object
            :param data: the data
            
        """
        while(1):
           if(self.data != []):
                nameGraphic = self.functionGraph.GetGraphHeartSamsung(self.data)
                break

        self.setGraphicPhoto(nameGraphic)

    def emotionChoiceIndex(self):
        """
            To get the current index
            :param self: the current object
        """
        selectedIndex = self.emotionChoice.currentIndex()

        return selectedIndex

    def handleButtonGo(self):
        """
            To do actions when the go button is pressing
            :param self: the current object
        """
        selectedIndex = self.emotionChoiceIndex()
        if(selectedIndex == 0):
            QMessageBox.about(self, "No choice", "You have to choice between algorithms.")
        elif(selectedIndex == 1):
            #algo à insérer ici
            nameEmotion = "happy.jpg"
            self.displayMainEmotion(nameEmotion)
        elif(selectedIndex == 2):
            #algo à insérer ici
            text = "happy : 80% \n tired : 20% "
            self.displayDetailsEmotion(text)
        elif(selectedIndex == 3):
            #algo à insérer ici
            nameGraphic = "initialGraphic.png"
            self.displayGraphicEmotion(nameGraphic)
            
    def exportData(self, q):
        """
            To export data
            :param self: the current object
            :param q: the action triggered
        """
        self.functionGraph.WriteFileSamsung(self.data)
        
        #to display a message
        QMessageBox.about(self, "Data export", "Data exported !")

    def importData(self,q):
        """
            To import data
            :param self: the current object
            :param q: the action triggered
        """
        
        fname = QFileDialog.getOpenFileName(self, 'Open file', '/home')
        print(fname)
        if fname[0]:

            with open(fname[0], 'r') as fichier:
                data = json.load(fichier)

        nameGraphic = self.functionGraph.GetGraphHeartSamsung(data)
        self.setGraphicPhoto(nameGraphic)

    def closeIt(self, q):
        """
            To close the window
            :param self: the current object
            :param q: the action triggered
        """
        self.close()

    def main(self):
        """
            To diplay the main window
        """
        self.show()


        

def mainInterface():
    """
       To run the samusung application
    """
    app = QtWidgets.QApplication([])
    imageViewer = ImageViewer()

    my_queue = Queue()
    thread1 = threading.Thread(target = client_network.clientNetwork, args = (imageViewer,))
    thread1.start()
            
    imageViewer.main()
    sys.exit(app.exec_())
