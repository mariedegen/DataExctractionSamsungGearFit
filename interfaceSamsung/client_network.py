#!/usr/bin/python

import bluetooth
import threading
import time
import random
import sys
import time 


def clientNetwork(imageViewer):

    tabData = []
    address="BC:76:5E:96:EE:6C"
    uuid="00001101-0000-1000-8000-00805F9B34FB" 
    finish = True;
    end = 'END'

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
          sock.connect((host, port))

          data = sock.recv(8);
          while True: 
              data = sock.recv(8)
              if data:
                tabData.append(data.decode('latin1'))
              if tabData.endswith(end):
                break
              elif not data :
                break
        print("".join(tabData))
    sock.close()

    imageViewer.data = tabData

