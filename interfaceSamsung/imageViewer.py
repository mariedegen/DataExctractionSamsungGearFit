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
        The controller class of the fitbit view
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

        """my_queue = Queue()
        thread2 = threading.Thread(target = self.actualizeGraphic, args = (self.data,))
        thread2.start()"""

    def actualizeGraphic(self, data):
        """
            To show the graphic with data 
            :param self: the object
            
        """
        while(1):
           if(self.data != []):
                nameGraphic = self.functionGraph.GetGraphHeartSamsung(self.data)
                break

        self.setGraphicPhoto(nameGraphic)

    def handleButtonGo():

        print("working on..")

    def exportData(self, q):
        self.functionGraph.WriteFileSamsung(self.data)
        
        #to display a message
        QMessageBox.about(self, "Data export", "Data exported !")

    def importData(self,q):
        print("working on...")

        fname = QFileDialog.getOpenFileName(self, 'Open file', '/home')
        print(fname)
        if fname[0]:

            with open(fname[0], 'r') as fichier:
                data = json.load(fichier)

        nameGraphic = self.functionGraph.GetGraphHeartSamsung(self.data)
        self.setGraphicPhoto(nameGraphic)

    def closeIt(self, q):
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
