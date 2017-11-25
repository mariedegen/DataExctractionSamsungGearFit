"""@package fitbit
The catalog of graph and data functions
"""

import os, base64, requests, urllib, time, json, numpy as np, pylab as pl, datetime

class CatalogFunction():
    """
        The catalog of functions
         - collects data
         - makes into a graph
         - exports data
    """

    def WriteFileSamsung(self, data):
        """
            Write in a file data of the day
            :param self: the object
            :param userName: the name of the user
        """

        dataHeart = self.ExtractData(data)
        
        date = time.localtime()
        date2 = str(date.tm_mday)+"-"+str(date.tm_mon)+"-"+str(date.tm_year)
        nomFichier = "Heart"+"_"+date2+".json"

        with open(nomFichier, 'w') as f:
            json.dump(dataHeart, f, indent=4) 
            
    def GetGraphHeartSamsung(self, data):
        """
            To get the graph of the minutes
            :param self: the object
            :param userName: the name of the user
            :return nameGraph: the name of the graph
        """

        dataHeart = self.ExtractData(data)
        nameGraph = self.SaveGraphSamsung(dataHeart)

        return nameGraph


    def ExtractData(self, data):
        
        t = []
        for n in range (0, len(data),1):
            if (n != 0 and n <= len(data)-2):
                t.append(float(data[n]))
        return t
    
    
    def SaveGraphSamsung(self, dataHeart):

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

        return nomFichier
