#!/usr/bin/python

import bluetooth
import threading
import time
import random
import sys
import time 



def clientNetwork(imageViewerSamsung):

    dataStr = ""
    tabData = []
    address="BC:76:5E:96:EE:6C"
    uuid="00001101-0000-1000-8000-00805F9B34FB" 
    finish = True
    end = 'END'
<<<<<<< HEAD

    """tabData = ["0","1","9","3","0"]
    time.sleep(2)"""
=======
>>>>>>> 9c7dce875030bab6c66a8f7c3e68266a1ed0405c
    
    while finish:
        print ("Searching ...")
        try:

          service_matches
        except NameError:
          service_matches = bluetooth.find_service(uuid = uuid)
        else:
          if not service_matches:
                print ("without address")
                service_matches = bluetooth.find_service(uuid = uuid)
          else:
                print ("with address")
                service_matches_with_addr = bluetooth.find_service(uuid = uuid, address = host)
                if service_matches_with_addr:
                  service_matches = service_matches_with_addr
                else:
                  continue

        if service_matches:
          first_match = service_matches[0]
          port = first_match["port"]
          name = first_match["name"]
          host = first_match["host"]
          print ("Connecting to ", name, " on ", host)
          sock=bluetooth.BluetoothSocket(bluetooth.RFCOMM)
          try:
            sock.connect((host, port))
          
            data = sock.recv(9);
            while True: 
                data = sock.recv(8)
                if data:
                  dataStr += data.decode('latin1')
                if dataStr.endswith(end):
                  break
                elif not data :
                  break
            finish = False
          except:
              e = sys.exc_info()[0]
              print("error:", e)
    print("data:", dataStr)
    tabData = conversionChartoFloat(dataStr)
    sock.close()
    del service_matches
    dataStr = ""

    imageViewerSamsung.data = tabData
    imageViewerSamsung.actualizeGraphic()

    while(1):
        time.sleep(2)

def conversionChartoFloat(data): 
    tabData = []
    for str in data.replace(",", ".").split(" "):
        try:
            tabData.append(float(str))
        except Exception:
            pass
    print("TabData : ", tabData)
    return tabData
