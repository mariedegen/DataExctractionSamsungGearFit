"""@package fitbit
The catalog of graph and data functions
"""

import os, base64, requests, urllib, time, json, numpy as np, pylab as pl, datetime
from PyQt5 import QtGui, QtCore, QtWidgets
from PyQt5.QtGui import *
from PyQt5.QtCore import *
from PyQt5.QtWidgets import *

class CatalogFunction():
    """
        The catalog of functions
         - collects data
         - makes into a graph
         - exports data
    """

    def WriteFileSamsung(self, data):
        """
            Write in a file data 
            :param self: the object
            :param userName: the name of the user
        """
        dataHeart = self.ExtractData(data)

        #date = time.localtime()
        #date2 = str(date.tm_mday)+"-"+str(date.tm_mon)+"-"+str(date.tm_year)
        fileName = QFileDialog.getSaveFileName(None,'Save the file')
        #nomFichier = "Heart"+"_"+date2+".json"
        
        print(fileName)
        if fileName[0]:      
            with open(fileName[0], 'w') as f:
                json.dump(dataHeart, f, indent=4)
            
    def GetGraphHeartSamsung(self, data):
        """
            To get the graph of the heartbeat
            :param self: the object
            :param userName: the name of the user
            :return nameGraph: the name of the graph
        """

        dataHeart = self.ExtractData(data)
        nameGraph = self.SaveGraphSamsung(dataHeart)

        return nameGraph


    def ExtractData(self, data):
        """
            To convert data
            :param self: the current object
            :param data: the data
        """
        
        t = []
        for n in range (0, len(data),1):
            if (n != 0 and n <= len(data)-2):
                t.append(float(data[n]))
        return t
    
    
    def SaveGraphSamsung(self, dataHeart):
        """
            To create and save the graphic
            :param self: the current object
            :param dataHeart: the data
        """

        debut = 0
        fin = len(dataHeart)
        pas = int((fin-debut)/5)
        axeX = []
        palier = debut
        for i in range(0,len(dataHeart)):
            if(i>=palier):
                axeX.append(i)
                palier = i + pas
            else:
                axeX.append('')
        x=np.arange(len(axeX))
        pl.figure(figsize=(10,4))
        pl.xticks(pl.arange(len(axeX)), axeX)
        pl.plot(x, dataHeart)
        date = time.localtime()
        date2 = str(date.tm_mday)+"-"+str(date.tm_mon)+"-"+str(date.tm_year)
        nomFichier = date2+"_Heart"+".png"
        pl.savefig(nomFichier)
        pl.close()

        return nomFichier
