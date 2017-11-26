# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'mainwindow.ui'
#
# Created by: PyQt5 UI code generator 5.6
#
# WARNING! All changes made in this file will be lost!

from PyQt5 import QtCore, QtGui, QtWidgets

class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(876, 353)
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.gridLayout = QtWidgets.QGridLayout(self.centralwidget)
        self.gridLayout.setObjectName("gridLayout")
        self.graphicLayout = QtWidgets.QGridLayout()
        self.graphicLayout.setObjectName("graphicLayout")
        self.graphicLegend = QtWidgets.QLabel(self.centralwidget)
        self.graphicLegend.setStyleSheet("font: 14pt \"OCR A Std\";\n"
"background-color: rgb(170, 170, 255);")
        self.graphicLegend.setObjectName("graphicLegend")
        self.graphicLayout.addWidget(self.graphicLegend, 5, 0, 1, 1)
        self.graphicPhoto = QtWidgets.QLabel(self.centralwidget)
        self.graphicPhoto.setObjectName("graphicPhoto")
        self.graphicPhoto.setStyleSheet("border-image: url(initialGraphic.png);\n"
"border-color: rgb(0, 0, 0);")
        self.graphicLayout.addWidget(self.graphicPhoto, 2, 0, 3, 1)
        self.graphicTitle = QtWidgets.QLabel(self.centralwidget)
        self.graphicTitle.setStyleSheet("font: 14pt \"OCR A Std\";\n"
"background-color: rgb(85, 255, 127);")
        self.graphicTitle.setObjectName("graphicTitle")
        self.graphicLayout.addWidget(self.graphicTitle, 1, 0, 1, 1)
        self.graphicLayout.setRowStretch(1, 2)
        self.graphicLayout.setRowStretch(2, 10)
        self.graphicLayout.setRowStretch(3, 1)
        self.graphicLayout.setRowStretch(5, 1)
        self.gridLayout.addLayout(self.graphicLayout, 0, 1, 1, 1)
        self.emotionLayout = QtWidgets.QGridLayout()
        self.emotionLayout.setObjectName("emotionLayout")
        self.emotionChoice = QtWidgets.QComboBox(self.centralwidget)
        self.emotionChoice.setObjectName("emotionChoice")
        self.emotionChoice.addItem("")
        self.emotionChoice.addItem("")
        self.emotionChoice.addItem("")
        self.emotionLayout.addWidget(self.emotionChoice, 1, 0, 1, 1)
        self.emotionTitle = QtWidgets.QLabel(self.centralwidget)
        self.emotionTitle.setStyleSheet("font: 14pt \"OCR A Std\";\n"
"background-color: rgb(255, 255, 127);")
        self.emotionTitle.setObjectName("emotionTitle")
        self.emotionLayout.addWidget(self.emotionTitle, 0, 0, 1, 2)
        self.emotionMain = QtWidgets.QLabel(self.centralwidget)
        self.emotionMain.setStyleSheet("font: 14pt \"OCR A Std\";\n"
"background-color: rgb(255, 170, 127);")
        self.emotionMain.setObjectName("emotionMain")
        self.emotionLayout.addWidget(self.emotionMain, 2, 0, 1, 2)
        self.emotionGo = QtWidgets.QPushButton(self.centralwidget)
        self.emotionGo.setObjectName("emotionGo")
        self.emotionLayout.addWidget(self.emotionGo, 1, 1, 1, 1)
        self.emotionPhoto = QtWidgets.QLabel(self.centralwidget)
        self.emotionPhoto.setObjectName("emotionPhoto")
        self.emotionLayout.addWidget(self.emotionPhoto, 3, 0, 1, 2)
        self.emotionLayout.setColumnStretch(0, 1)
        self.emotionLayout.setRowStretch(0, 2)
        self.emotionLayout.setRowStretch(2, 1)
        self.emotionLayout.setRowStretch(3, 10)
        self.gridLayout.addLayout(self.emotionLayout, 0, 3, 1, 1)
        self.bar = QtWidgets.QLabel(self.centralwidget)
        self.bar.setStyleSheet("background-color: rgb(200, 200, 200);")
        self.bar.setObjectName("bar")
        self.gridLayout.addWidget(self.bar, 0, 2, 1, 1)
        self.gridLayout.setColumnStretch(1, 1)
        self.gridLayout.setColumnStretch(3, 1)
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 876, 21))
        self.menubar.setObjectName("menubar")
        self.menuData = QtWidgets.QMenu(self.menubar)
        self.menuData.setObjectName("menuData")
        self.menuHome = QtWidgets.QMenu(self.menubar)
        self.menuHome.setObjectName("menuHome")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)
        self.actionExport = QtWidgets.QAction(MainWindow)
        self.actionExport.setObjectName("actionExport")
        self.actionImport = QtWidgets.QAction(MainWindow)
        self.actionImport.setObjectName("actionImport")
        self.actionExit = QtWidgets.QAction(MainWindow)
        self.actionExit.setObjectName("actionExit")
        self.menuData.addAction(self.actionImport)
        self.menuData.addAction(self.actionExport)
        self.menuHome.addAction(self.actionExit)
        self.menubar.addAction(self.menuHome.menuAction())
        self.menubar.addAction(self.menuData.menuAction())
        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "MainWindow"))
        self.graphicLegend.setText(_translate("MainWindow", "<html><head/><body><p align=\"center\"><span style=\" font-size:8pt;\">HEARTBEAT DURING THE RECORDED PERIOD</span></p></body></html>"))
        self.graphicTitle.setText(_translate("MainWindow", "<html><head/><body><p align=\"center\">GRAPHIC</p></body></html>"))
        self.emotionChoice.setItemText(0, _translate("MainWindow", "Choose your algorithm"))
        self.emotionChoice.setItemText(1, _translate("MainWindow", "Algo1"))
        self.emotionChoice.setItemText(2, _translate("MainWindow", "Algo2"))
        self.emotionTitle.setText(_translate("MainWindow", "<html><head/><body><p align=\"center\">EMOTIONS</p></body></html>"))
        self.emotionMain.setText(_translate("MainWindow", "<html><head/><body><p align=\"center\"><span style=\" font-size:8pt;\">MAIN EMOTION</span></p></body></html>"))
        self.emotionGo.setText(_translate("MainWindow", "GO"))
        self.emotionPhoto.setText(_translate("MainWindow", "<html><head/><body><p align=\"center\">photo emotion</p></body></html>"))
        self.bar.setText(_translate("MainWindow", "<html><head/><body><p><span style=\" color:#c8c8c8;\">T</span></p></body></html>"))
        self.menuData.setTitle(_translate("MainWindow", "Data"))
        self.menuHome.setTitle(_translate("MainWindow", "Home"))
        self.actionExport.setText(_translate("MainWindow", "Export"))
        self.actionImport.setText(_translate("MainWindow", "Import"))
        self.actionExit.setText(_translate("MainWindow", "Exit"))

    def setGraphicPhoto(self, nameGraphic):
        self.graphicPhoto.setStyleSheet("border-image: url("+nameGraphic+");\n"
"border-color: rgb(0, 0, 0);")


if __name__ == "__main__":
    import sys
    app = QtWidgets.QApplication(sys.argv)
    MainWindow = QtWidgets.QMainWindow()
    ui = Ui_MainWindow()
    ui.setupUi(MainWindow)
    MainWindow.show()
    sys.exit(app.exec_())

