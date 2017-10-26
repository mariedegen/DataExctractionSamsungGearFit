S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 3149
Date: 2017-10-26 11:25:16+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x36302e31

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x4175790c, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbeb1f3f8
r8   = 0xbeb1f4a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbeb1f3a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     83596 KB
Buffers:     28132 KB
Cached:     155356 KB
VmPeak:      95224 KB
VmSize:      94484 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17928 KB
VmRSS:       17928 KB
VmData:      40196 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23608 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3149 TID = 3149
3149 3456 3464 3465 3466 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40053000 4005f000 r-xp /usr/lib/libaul.so.0.1.0
40069000 4006b000 r-xp /lib/libdl-2.13.so
40074000 40077000 r-xp /usr/lib/libbundle.so.0.1.22
4007f000 40081000 r-xp /usr/lib/libdlog.so.0.0.0
40089000 4009d000 r-xp /lib/libpthread-2.13.so
400a8000 401e2000 r-xp /usr/lib/libelementary.so.1.7.99
401f9000 402c7000 r-xp /usr/lib/libevas.so.1.7.99
402ed000 40304000 r-xp /usr/lib/libecore.so.1.7.99
4031b000 40379000 r-xp /usr/lib/libedje.so.1.7.99
40382000 40452000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40453000 40459000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40461000 40465000 r-xp /usr/lib/libsmack.so.1.0.0
4046e000 40476000 r-xp /lib/libgcc_s-4.6.so.1
40477000 40592000 r-xp /lib/libc-2.13.so
405a0000 405dc000 r-xp /usr/lib/libsystemd.so.0.4.0
405e5000 405f0000 r-xp /lib/libunwind.so.8.0.1
4061d000 40634000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4063c000 40666000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066f000 40674000 r-xp /usr/lib/libxdgmime.so.1.1.0
4067c000 4069e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a6000 406aa000 r-xp /usr/lib/libproc-stat.so.0.2.86
406b3000 406b9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c2000 4072b000 r-xp /lib/libm-2.13.so
40734000 4074d000 r-xp /usr/lib/libeet.so.1.7.99
4075e000 4079f000 r-xp /usr/lib/libeina.so.1.7.99
407a8000 407ca000 r-xp /usr/lib/libecore_evas.so.1.7.99
407d3000 407d8000 r-xp /usr/lib/libecore_file.so.1.7.99
407e0000 407f1000 r-xp /usr/lib/libecore_input.so.1.7.99
407f9000 40802000 r-xp /usr/lib/libvconf.so.0.2.45
4080a000 4085a000 r-xp /usr/lib/libecore_x.so.1.7.99
4085c000 40865000 r-xp /usr/lib/libedbus.so.1.7.99
4086d000 40887000 r-xp /usr/lib/libecore_con.so.1.7.99
40890000 408a3000 r-xp /usr/lib/libfribidi.so.0.3.1
408ab000 408e8000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408f1000 40919000 r-xp /usr/lib/libfontconfig.so.1.8.0
4091a000 40970000 r-xp /usr/lib/libfreetype.so.6.11.3
4097c000 409d2000 r-xp /usr/lib/libpixman-1.so.0.28.2
409df000 409e5000 r-xp /lib/librt-2.13.so
409ee000 409f5000 r-xp /usr/lib/libembryo.so.1.7.99
409fd000 40a14000 r-xp /usr/lib/liblua-5.1.so
40a1d000 40a23000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a2b000 40a2c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a34000 40a62000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a6b000 40a6e000 r-xp /lib/libcap.so.2.21
40a76000 40a8e000 r-xp /usr/lib/liblzma.so.5.0.3
40a96000 40b12000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b1e000 40b2e000 r-xp /lib/libresolv-2.13.so
40b32000 40c05000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40c10000 40c44000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c4d000 40c63000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c6c000 40ce1000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ceb000 40d01000 r-xp /lib/libz.so.1.2.5
40d09000 40d2c000 r-xp /usr/lib/libjpeg.so.8.0.2
40d44000 40e25000 r-xp /usr/lib/libX11.so.6.3.0
40e30000 40e35000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e3e000 40e42000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e4b000 40e4e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e56000 40e5d000 r-xp /usr/lib/libXcursor.so.1.0.2
40e65000 40e67000 r-xp /usr/lib/libXdamage.so.1.1.0
40e6f000 40e71000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e79000 40e7b000 r-xp /usr/lib/libXgesture.so.7.0.0
40e83000 40e86000 r-xp /usr/lib/libXfixes.so.3.1.0
40e8e000 40e97000 r-xp /usr/lib/libXi.so.6.1.0
40e9f000 40ea0000 r-xp /usr/lib/libXinerama.so.1.0.0
40ea9000 40eaf000 r-xp /usr/lib/libXrandr.so.2.2.0
40eb7000 40ebd000 r-xp /usr/lib/libXrender.so.1.3.0
40ec5000 40ec9000 r-xp /usr/lib/libXtst.so.6.1.0
40ed1000 40edb000 r-xp /usr/lib/libXext.so.6.4.0
40ee4000 40f28000 r-xp /usr/lib/libcurl.so.4.3.0
40f31000 40f47000 r-xp /lib/libexpat.so.1.5.2
40f51000 40f69000 r-xp /usr/lib/libpng12.so.0.50.0
40f71000 40f8e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f97000 4102b000 r-xp /usr/lib/libstdc++.so.6.0.16
4103f000 41042000 r-xp /lib/libattr.so.1.1.0
4104a000 41055000 r-xp /usr/lib/libgpg-error.so.0.15.0
4105d000 4105e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41066000 4106b000 r-xp /usr/lib/libffi.so.5.0.10
41073000 41075000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
4107e000 4114a000 r-xp /usr/lib/libxml2.so.2.7.8
41157000 41159000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41162000 41164000 r-xp /usr/lib/journal/libjournal.so.0.1.0
4116c000 4117f000 r-xp /usr/lib/libxcb.so.1.1.0
41189000 41192000 r-xp /usr/lib/libcares.so.2.1.0
4119b000 411c9000 r-xp /usr/lib/libidn.so.11.5.44
411d1000 41218000 r-xp /usr/lib/libssl.so.1.0.0
41224000 413cd000 r-xp /usr/lib/libcrypto.so.1.0.0
413ee000 413f0000 r-xp /usr/lib/libiri.so
413f9000 41400000 r-xp /lib/libcrypt-2.13.so
41430000 41432000 r-xp /usr/lib/libXau.so.6.0.0
4153f000 41543000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41552000 41557000 r-xp /usr/lib/libappcore-common.so.1.1
4155f000 41561000 r-xp /usr/lib/libiniparser.so.0
4156a000 41575000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
4157d000 41581000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4158a000 4158c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41595000 4159b000 r-xp /usr/lib/libappsvc.so.0.1.0
415a3000 415c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415d0000 4169f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416b5000 416bf000 r-xp /lib/libnss_files-2.13.so
41743000 41748000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41758000 4178a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41793000 41797000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a0000 417a8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417a9000 417ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d3000 4180d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41816000 4182f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41837000 4183c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41844000 4186e000 r-xp /usr/lib/libsensor.so.1.9.6
41877000 41889000 r-xp /usr/lib/libefl-assist.so.0.1.0
41891000 41949000 r-xp /usr/lib/libcairo.so.2.11200.14
41954000 41957000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4195f000 41965000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4196e000 41976000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4197e000 41988000 r-xp /usr/lib/libsensord-shared.so
41991000 419a3000 r-xp /usr/lib/libtts.so
419ab000 419cd000 r-xp /usr/lib/libui-extension.so.0.1.0
419d6000 419dd000 r-xp /usr/lib/libtbm.so.1.0.0
419e5000 419f3000 r-xp /usr/lib/libGLESv2.so.2.0
419fc000 419fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a06000 41a0c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a14000 41a17000 r-xp /usr/lib/libEGL.so.1.4
41a1f000 41a2c000 r-xp /usr/lib/libail.so.0.1.0
41a35000 41b72000 r-xp /usr/lib/libicui18n.so.51.1
41b82000 41c66000 r-xp /usr/lib/libicuuc.so.51.1
43204000 43220000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43229000 4322c000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43234000 43235000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4323e000 43246000 r-xp /usr/lib/libdrm.so.2.4.0
4324e000 43250000 r-xp /usr/lib/libdri2.so.0.0.0
43258000 4325f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43268000 4326a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43272000 43279000 r-xp /usr/lib/libminizip.so.1.0.0
43281000 43287000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4328f000 43294000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4329c000 432bd000 r-xp /usr/lib/libexif.so.12.3.3
432d0000 432d2000 r-xp /usr/lib/libttrace.so.1.1
432da000 432df000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e7000 434b1000 r-xp /usr/lib/libCOREGL.so.4.0
436c4000 43ec3000 rw-p [stack:3456]
43ec3000 43ece000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ed7000 43edc000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43ef6000 43ef7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4408c000 4408e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44097000 44896000 rw-p [stack:3464]
44897000 45096000 rw-p [stack:3465]
45097000 45996000 rw-p [stack:3466]
45a4e000 45a51000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45b59000 45b5a000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
beaff000 beb20000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3149)
Call Stack Count: 1
 0: cfree + 0x30 (0x404e6150) [/lib/libc.so.6] + 0x6f150
End of Call Stack

Package Information
Package Name: org.example.dataextraction
Package ID : org.example.dataextraction
Version: 1.0.0
Package Type: rpm
App Name: Health Reacording
App ID: org.example.dataextraction
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
st_handler(645) > __request_handler: 12
10-26 11:24:14.835+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:24:14.850+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3033
10-26 11:24:14.885+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:24:14.975+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:24:14.980+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3140
10-26 11:24:14.980+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:24:15.015+0200 W/WG-CONSUMER( 3139): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
10-26 11:24:15.045+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:24:15.045+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:24:15.050+0200 W/WG-CONSUMER( 3139): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
10-26 11:24:15.050+0200 W/WG-CONSUMER( 3139): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
10-26 11:24:15.050+0200 W/WG-CONSUMER( 3139): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-26 11:24:15.055+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-26 11:24:15.065+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-26 11:24:15.065+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-26 11:24:15.065+0200 W/WG-CONSUMER( 3139): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-26 11:24:15.065+0200 W/WG-CONSUMER( 3139): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-26 11:24:15.065+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:24:15.075+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3033
10-26 11:24:15.075+0200 W/WG-CONSUMER( 3139): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-26 11:24:15.080+0200 W/WG-CONSUMER( 3139): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-26 11:24:15.080+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-26 11:24:15.080+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-26 11:24:15.085+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:24:15.090+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 11:24:15.105+0200 W/WG-CONSUMER( 3139): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-26 11:24:15.110+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 3139): media_content.c: media_content_connect(870) > [32m[3139]ref count : 0
10-26 11:24:15.130+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 3139): media_content.c: media_content_connect(902) > [32m[3139]ref count changed to: 1
10-26 11:24:15.135+0200 W/WG-CONSUMER( 3139): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-26 11:24:15.145+0200 W/WG-CONSUMER( 3139): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-26 11:24:15.160+0200 W/WG-CONSUMER( 3139): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-26 11:24:15.165+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-26 11:24:15.165+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-26 11:24:15.165+0200 E/WG-CONSUMER( 3139): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-26 11:24:15.170+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-26 11:24:15.170+0200 E/WG-CONSUMER( 3139): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-26 11:24:15.175+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-26 11:24:15.180+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-26 11:24:15.180+0200 E/WG-CONSUMER( 3139): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-26 11:24:15.180+0200 W/WG-CONSUMER( 3139): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-26 11:24:15.180+0200 W/WG-CONSUMER( 3139): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-26 11:24:15.180+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-26 11:24:15.180+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-26 11:24:15.180+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-26 11:24:15.180+0200 E/WG-CONSUMER( 3139): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-26 11:24:15.180+0200 E/WG-CONSUMER( 3139): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-26 11:24:15.185+0200 E/WG-CONSUMER( 3139): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-26 11:24:15.190+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-26 11:24:15.190+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-26 11:24:15.190+0200 E/WG-CONSUMER( 3139): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-26 11:24:15.190+0200 W/WG-CONSUMER( 3139): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x438004a8[0m
10-26 11:24:15.200+0200 W/CAPI_APPFW_APP_CONTROL( 3139): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-26 11:24:15.200+0200 W/CAPI_APPFW_APP_CONTROL( 3139): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-26 11:24:15.220+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 11:24:15.270+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:24:15.270+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 11:24:15.275+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 11:24:15.280+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 11:24:15.290+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:24:15.365+0200 W/WG-CONSUMER( 3139): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-26 11:24:15.440+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 11:24:15.480+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:24:15.530+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:24:15.530+0200 I/CAPI_APPFW_APPLICATION( 3139): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 11:24:15.530+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 11:24:15.550+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:24:15.565+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:24:15.585+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:24:15.585+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:24:15.595+0200 W/WG-CONSUMER( 3139): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-26 11:24:15.595+0200 E/EFL     ( 3149): elementary<3149> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:24:15.600+0200 W/WG-CONSUMER( 3139): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-26 11:24:15.600+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-26 11:24:15.600+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-26 11:24:15.600+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 11:24:15.610+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 11:24:15.620+0200 W/WG-CONSUMER( 3139): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 11:24:15.620+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 11:24:15.620+0200 E/WIPC_SERVER( 3139): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-26 11:24:15.620+0200 W/WG-CONSUMER( 3139): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-26 11:24:15.620+0200 W/WG-CONSUMER( 3139): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-26 11:24:15.620+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-26 11:24:15.625+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-26 11:24:15.625+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 11:24:15.625+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 11:24:15.625+0200 W/WG-CONSUMER( 3139): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 11:24:15.625+0200 W/WG-CONSUMER( 3139): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 11:24:15.655+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 3139): media_content.c: media_content_disconnect(958) > [32m[3139]ref count changed to: 0
10-26 11:24:15.710+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 11:24:15.710+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 11:24:15.715+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 11:24:15.715+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 11:24:15.775+0200 E/WG-CONSUMER( 3139): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-26 11:24:15.775+0200 W/WG-CONSUMER( 3139): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-26 11:24:15.780+0200 W/WG-CONSUMER( 3139): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-26 11:24:15.780+0200 W/WG-CONSUMER( 3139): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-26 11:24:15.780+0200 W/WG-CONSUMER( 3139): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-26 11:24:15.780+0200 W/WG-CONSUMER( 3139): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-26 11:24:15.785+0200 W/WG-CONSUMER( 3139): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-26 11:24:15.815+0200 W/MUSIC_TRANSFER( 3140): mt-service.c: main(142) > [33m[TID:3140]   service start[0m
10-26 11:24:15.895+0200 E/EFL     ( 3149): elementary<3149> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:24:15.895+0200 W/MUSIC_TRANSFER( 3140): mt-service.c: _service_app_create(65) > [33m[TID:3140]   [0m
10-26 11:24:15.985+0200 E/EFL     ( 3149): elementary<3149> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:24:15.985+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:24:16.050+0200 W/AUL     ( 3158): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-26 11:24:16.065+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 11:24:16.065+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 11:24:16.065+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 3139
10-26 11:24:16.065+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 11:24:16.085+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3139
10-26 11:24:16.105+0200 W/MUSIC_PLAYER( 3140): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:3140]   W_SERVICE_TYPE_BT[1][0m
10-26 11:24:16.110+0200 W/MUSIC_PLAYER( 3140): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:3140]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-26 11:24:16.110+0200 W/MUSIC_TRANSFER( 3140): mt-service.c: _service_app_create(88) > [31m[TID:3140]   SAP is disconnected.. Terminate process[0m
10-26 11:24:16.110+0200 I/CAPI_APPFW_APPLICATION( 3140): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 11:24:16.150+0200 W/MUSIC_PLAYER( 3140): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:3140]   vendor : LO[0m
10-26 11:24:16.150+0200 W/MUSIC_PLAYER( 3140): mp-conf.c: mp_conf_init(262) > [33m[TID:3140]   iOS  connected..[0m
10-26 11:24:16.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3140): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-26 11:24:16.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3140): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-26 11:24:16.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3140): preference.c: preference_get_int(1132) > preference_get_int(3140) : key(tutorial_complete) error
10-26 11:24:16.165+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-26 11:24:16.165+0200 E/CAPI_NETWORK_BLUETOOTH( 1061): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-26 11:24:16.165+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1061]   bt_gatt_client_get_service Error[-22][0m
10-26 11:24:16.165+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1061]   remote mode[0][0m
10-26 11:24:16.165+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:24:16.165+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:24:16.170+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 11:24:16.175+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 11:24:16.175+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 11:24:16.180+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 11:24:16.180+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 11:24:16.180+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 11:24:16.220+0200 W/MUSIC_TRANSFER( 3140): mt-service.c: _service_app_terminate(104) > [33m[TID:3140]   [0m
10-26 11:24:16.230+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:24:16.230+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:24:16.270+0200 E/EFL     ( 3149): elementary<3149> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:24:16.295+0200 E/EFL     ( 3149): elementary<3149> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:24:16.295+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:24:16.295+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:24:16.295+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:24:16.295+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:24:16.295+0200 E/EFL     ( 3149): elementary<3149> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:24:16.295+0200 I/AUL_PAD ( 3149): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:24:16.565+0200 W/AUL     ( 3163): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-26 11:24:16.565+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 11:24:16.565+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 11:24:16.565+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 3140
10-26 11:24:16.570+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 11:24:16.585+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3140
10-26 11:24:17.585+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 11:24:18.230+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 11:24:18.980+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:24:21.395+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 11:24:21.685+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 11:24:21.685+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:24:25.975+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:24:37.985+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:24:42.335+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:24:42.340+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:24:42.340+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 11:24:42.365+0200 W/W_INDICATOR(  735): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
10-26 11:24:42.370+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
10-26 11:24:42.370+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
10-26 11:24:42.370+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-26 11:24:42.375+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
10-26 11:24:42.390+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 11:24:42.410+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 11:24:42.410+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 11:24:42.410+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 11:24:42.410+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 11:24:42.410+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 11:24:42.410+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:24:42.415+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 11:24:42.415+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 11:24:42.415+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 11:24:42.415+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 11:24:42.415+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 11:24:42.465+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: PAUSE State: RUNNING
10-26 11:24:42.465+0200 I/CAPI_APPFW_APPLICATION(  735): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 11:24:42.465+0200 I/APP_CORE(  735): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 11:24:42.485+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:24:42.485+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 11:24:42.490+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:24:42.490+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 11:24:42.510+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 11:24:42.610+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
10-26 11:24:42.690+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 11:24:42.690+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
10-26 11:24:42.690+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 11:24:42.690+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 11:24:42.690+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 11:25:03), repeat(1), interval(20), type(-1073741822)
10-26 11:24:42.720+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
10-26 11:24:42.720+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
10-26 11:24:42.725+0200 E/ALARM_MANAGER( 3033): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(78), start(26-10-2017, 11:26:01), repeat(1), interval(120), type(-1073741822)
10-26 11:24:42.730+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 11:24:42.790+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 510993395, next duetime: 1509009903
10-26 11:24:42.790+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(510993395)
10-26 11:24:42.790+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509009903)
10-26 11:24:42.790+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:24:42.790+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:25:03 (UTC).
10-26 11:24:42.790+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:24:42.795+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [3033].
10-26 11:24:42.840+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 510993396, next duetime: 1509009961
10-26 11:24:42.840+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(510993396)
10-26 11:24:42.840+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509009903), due_time(1509009961)
10-26 11:24:42.840+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:24:42.840+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:25:03 (UTC).
10-26 11:24:42.840+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:24:43.225+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-26 11:24:43.225+0200 W/W_CLOCK_VIEWER( 3033): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-26 11:24:47.475+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: MEM_FLUSH State: PAUSED
10-26 11:24:50.080+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:25:00.980+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 11:25  /5 / HH:mm
10-26 11:25:00.980+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] AM / 11:25
10-26 11:25:00.990+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 11:25:00.990+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 11
10-26 11:25:00.995+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 25
10-26 11:25:00.995+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  11
10-26 11:25:01.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  25
10-26 11:25:01.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 11 / 25 / 11:25
10-26 11:25:01.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 11:25:01.035+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 11:25:01.810+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:25:02.665+0200 W/W_INDICATOR(  735): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 96
10-26 11:25:02.685+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-26 11:25:02.705+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-26 11:25:02.705+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 96, index 19, bg level 95
10-26 11:25:02.725+0200 E/RESOURCED(  566): heart-battery.c: heart_battery_calculate_prediction(1057) > No battery capacity history data
10-26 11:25:02.730+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_95
10-26 11:25:02.755+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 96
10-26 11:25:02.770+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 11:25:02.995+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:25:03.090+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:25:03.180+0200 E/RESOURCED(  566): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 732
10-26 11:25:03.185+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[510993395] is expired.
10-26 11:25:03.190+0200 E/ALARM_MANAGER(  732): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [510993395]
10-26 11:25:03.190+0200 W/STARTER (  732): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [510993395]
10-26 11:25:03.190+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 510993395, next duetime: 1509009923
10-26 11:25:03.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:25:03.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:25:23 (UTC).
10-26 11:25:03.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:25:03.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:25:03.205+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 11:25:03.205+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:25:03.210+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 11:25:03.215+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 11:25:03.220+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:25:03.220+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: PAUSED
10-26 11:25:03.220+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 11:25:03.220+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : show_clock
10-26 11:25:03.220+0200 W/W_HOME  (  769): main.c: _app_control(1746) > Show clock operation
10-26 11:25:03.220+0200 W/W_HOME  (  769): gesture.c: _clock_show(245) > clock show
10-26 11:25:03.220+0200 W/W_HOME  (  769): gesture.c: _clock_show(260) > home raise
10-26 11:25:03.220+0200 E/W_HOME  (  769): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-26 11:25:03.220+0200 W/W_HOME  (  769): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-26 11:25:03.220+0200 W/W_HOME  (  769): gesture.c: _clock_show(263) > home raise done
10-26 11:25:03.220+0200 W/W_HOME  (  769): gesture.c: _clock_show(270) > show clock
10-26 11:25:03.220+0200 W/W_HOME  (  769): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-26 11:25:03.225+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(769), cmd(0)
10-26 11:25:03.230+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 11:25:03.230+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 11:25:03.230+0200 W/W_HOME  (  769): move.c: _scroller_down_done(494) > down signal done
10-26 11:25:03.230+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-26 11:25:03.230+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 11:25:03.230+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:03.240+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:03.240+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:03.240+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-26 11:25:03.240+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-26 11:25:03.240+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-26 11:25:03.240+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-26 11:25:03.250+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
10-26 11:25:03.255+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 11:25:03.255+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(510993395)
10-26 11:25:03.255+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:25:03.255+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:26:01 (UTC).
10-26 11:25:03.255+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:25:03.255+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[510993395] is removed.
10-26 11:25:03.260+0200 E/APPS    (  769): apps_main.c: apps_main_pause(602) >  paused already
10-26 11:25:03.275+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 11:25:04.220+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:25:04.220+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 11:25:12.850+0200 E/PKGMGR_SERVER( 3405): pkgmgr-server.c: main(2167) > package manager server start
10-26 11:25:12.950+0200 E/PKGMGR_SERVER( 3405): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-1076958752], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[JzEYs+6Ns3kEGPTdda6vLgQjEBQ=], backend_flag=[0]
10-26 11:25:12.955+0200 E/PKGMGR_SERVER( 3406): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-26 11:25:12.965+0200 E/PKGMGR  ( 3403): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-26 11:25:13.045+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:25:13.055+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 11:25:13.065+0200 E/PKGMGR_SERVER( 3406): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-26 11:25:13.120+0200 E/PKGMGR_SERVER( 3405): pkgmgr-server.c: sighandler(409) > child NORMAL exit [3406]
10-26 11:25:13.285+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:25:14.300+0200 W/AUL     ( 3455): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 11:25:14.300+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:25:14.325+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 11:25:14.340+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 11:25:14.340+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 11:25:14.340+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 3455
10-26 11:25:14.360+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 11:25:14.360+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 11:25:14.360+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 11:25:14.360+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 11:25:14.360+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 11:25:14.440+0200 I/efl-extension( 3149): efl_extension.c: eext_mod_init(40) > Init
10-26 11:25:14.445+0200 I/UXT     ( 3149): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 11:25:14.445+0200 I/CAPI_APPFW_APPLICATION( 3149): app_main.c: ui_app_main(704) > app_efl_main
10-26 11:25:14.460+0200 I/CAPI_APPFW_APPLICATION( 3149): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 11:25:14.460+0200 W/AUL     ( 3455): launch.c: app_request_to_launchpad(282) > request cmd(0) result(3149)
10-26 11:25:14.475+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 11:25:14.650+0200 I/Bluetooth( 3149): [bt_initialize] success.
10-26 11:25:14.650+0200 I/Bluetooth( 3149): [bt_adapter_le_create_advertiser] success.
10-26 11:25:14.680+0200 I/Bluetooth( 3149): [bt_adapter_le_set_advertising_mode] success.
10-26 11:25:14.685+0200 I/Bluetooth( 3149): [bt_adapter_le_set_advertising_connectable] success.
10-26 11:25:14.685+0200 I/Bluetooth( 3149): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:25:14.685+0200 I/Bluetooth( 3149): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:25:14.850+0200 I/Bluetooth( 3149): [bt_adapter_le_start_advertising_new] success.
10-26 11:25:14.850+0200 I/Bluetooth( 3149): Heart Rate Measurement advertiser started.
10-26 11:25:14.935+0200 I/Bluetooth( 3149): [bt_adapter_le_stop_advertising] success.
10-26 11:25:14.935+0200 I/Bluetooth( 3149): [bt_adapter_le_clear_advertising_data] success.
10-26 11:25:14.935+0200 I/Bluetooth( 3149): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:25:14.935+0200 I/Bluetooth( 3149): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 11:25:15.135+0200 I/Bluetooth( 3149): [bt_adapter_le_start_advertising_new] success.
10-26 11:25:15.235+0200 E/EFL     ( 3149): ecore_evas<3149> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 11:25:15.465+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:25:15.465+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 11:25:15.570+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.246
10-26 11:25:15.635+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:25:15.645+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3149
10-26 11:25:15.645+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:25:15.650+0200 E/PKGMGR_SERVER( 3405): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 11:25:15.650+0200 E/PKGMGR_SERVER( 3405): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 11:25:15.660+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3149
10-26 11:25:15.660+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:25:15.665+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:25:15.850+0200 I/APP_CORE( 3149): appcore-efl.c: __do_app(429) > [APP 3149] Event: RESET State: CREATED
10-26 11:25:15.850+0200 I/CAPI_APPFW_APPLICATION( 3149): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 11:25:15.885+0200 I/APP_CORE( 3149): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 11:25:15.885+0200 I/APP_CORE( 3149): appcore-efl.c: __do_app(474) > [APP 3149] Initial Launching, call the resume_cb
10-26 11:25:15.885+0200 I/CAPI_APPFW_APPLICATION( 3149): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 11:25:15.895+0200 W/APP_CORE( 3149): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000002
10-26 11:25:15.905+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:25:15.910+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:25:15.940+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:25:15.940+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:25:16.015+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:25:16.015+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:25:16.025+0200 I/APP_CORE( 3149): appcore-efl.c: __do_app(429) > [APP 3149] Event: PAUSE State: RUNNING
10-26 11:25:16.025+0200 I/CAPI_APPFW_APPLICATION( 3149): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 11:25:16.030+0200 I/APP_CORE( 3149): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 11:25:16.035+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:25:16.035+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:25:16.035+0200 E/EFL     ( 3457): elementary<3457> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:25:16.035+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:25:16.035+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:25:16.060+0200 E/EFL     ( 3457): elementary<3457> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:25:16.065+0200 E/EFL     ( 3457): elementary<3457> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:25:16.065+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:25:16.100+0200 I/APP_CORE( 3149): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 11:25:16.100+0200 I/CAPI_APPFW_APPLICATION( 3149): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 11:25:16.120+0200 E/EFL     ( 3457): elementary<3457> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:25:16.130+0200 E/EFL     ( 3457): elementary<3457> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:25:16.130+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:25:16.130+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:25:16.130+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:25:16.130+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:25:16.130+0200 E/EFL     ( 3457): elementary<3457> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:25:16.130+0200 I/AUL_PAD ( 3457): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:25:16.460+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3149 pgid = 3149
10-26 11:25:16.620+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 11:25:16.625+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3149
10-26 11:25:16.635+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.249
10-26 11:25:16.695+0200 W/CRASH_MANAGER( 3467): worker.c: worker_job(1205) > 1103149646174150900991
