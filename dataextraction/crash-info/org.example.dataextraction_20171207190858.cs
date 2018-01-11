S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 1957
Date: 2017-12-07 19:08:58+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1957, uid 5000)

Register Information
r0   = 0x4059d250, r1   = 0x00000002
r2   = 0x45d9d000, r3   = 0x416c7850
r4   = 0x416c78a8, r5   = 0x416c7850
r6   = 0x82d8f0f8, r7   = 0x4059d250
r8   = 0xbef8c4d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4177b3e4, sp   = 0xbef8c3e8
lr   = 0x404e61bc, pc   = 0x404e2174
cpsr = 0x00000010

Memory Information
MemTotal:   491948 KB
MemFree:     91800 KB
Buffers:     24788 KB
Cached:     150232 KB
VmPeak:      98564 KB
VmSize:      97456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19264 KB
VmRSS:       19264 KB
VmData:      41544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25024 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1957 TID = 1957
1957 2032 

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
4143f000 41443000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41452000 41457000 r-xp /usr/lib/libappcore-common.so.1.1
4145f000 41461000 r-xp /usr/lib/libiniparser.so.0
4146a000 41475000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d3000 414f4000 rw-p [heap]
414f4000 415c3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415d9000 415e3000 r-xp /lib/libnss_files-2.13.so
41767000 4176c000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4177c000 417ae000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
417b7000 417bb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417c4000 417e5000 r-xp /usr/lib/libefl-extension.so.0.1.0
417ee000 41828000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41831000 4184a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41852000 41857000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4185f000 41889000 r-xp /usr/lib/libsensor.so.1.9.6
41892000 4194a000 r-xp /usr/lib/libcairo.so.2.11200.14
41955000 41958000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41960000 41966000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4196f000 41977000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4197f000 41989000 r-xp /usr/lib/libsensord-shared.so
41992000 419a0000 r-xp /usr/lib/libGLESv2.so.2.0
419a9000 419aa000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419b3000 419b9000 r-xp /usr/lib/libxcb-render.so.0.0.0
419c1000 419c4000 r-xp /usr/lib/libEGL.so.1.4
419cc000 419d9000 r-xp /usr/lib/libail.so.0.1.0
419e2000 41b1f000 r-xp /usr/lib/libicui18n.so.51.1
41b2f000 41c13000 r-xp /usr/lib/libicuuc.so.51.1
431b1000 431cd000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431d6000 431dd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431e6000 431e8000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431f0000 431f7000 r-xp /usr/lib/libminizip.so.1.0.0
431ff000 432c9000 r-xp /usr/lib/libCOREGL.so.4.0
434dc000 43cdb000 rw-p [stack:2032]
43cdb000 43ce6000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43cef000 43cf7000 r-xp /usr/lib/libdrm.so.2.4.0
43e00000 43e05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43e13000 43e1a000 r-xp /usr/lib/libtbm.so.1.0.0
43e22000 43e24000 r-xp /usr/lib/libdri2.so.0.0.0
43fc7000 43fc8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4592c000 4592f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45a37000 45a38000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45a40000 45a41000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a5c000 45a63000 r-xp /usr/lib/libfeedback.so.0.1.4
45a6c000 45a6d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a75000 45a77000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a7f000 45a89000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a91000 45a98000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45aa0000 45ab6000 r-xp /usr/lib/libmmfsound.so.0.1.0
45ac8000 45acd000 r-xp /usr/lib/libmmfsession.so.0.0.0
45ad5000 45adf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45aeb000 45aef000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45af8000 45b0d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45b15000 45b76000 r-xp /usr/lib/libasound.so.2.0.0
45b80000 45b83000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b8b000 45bc3000 r-xp /usr/lib/libpulse.so.0.16.2
45bc4000 45bf5000 r-xp /usr/lib/libmdm.so.1.1.86
45bfd000 45c02000 r-xp /usr/lib/libjson.so.0.0.1
45c0a000 45c52000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c53000 45c9a000 r-xp /usr/lib/libsndfile.so.1.0.26
45ca6000 45cae000 r-xp /usr/lib/libmdm-common.so.1.0.89
45caf000 45cd1000 r-xp /usr/lib/libvorbis.so.0.4.3
45cd9000 45cdd000 r-xp /usr/lib/libogg.so.0.7.1
bef6c000 bef8d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1957)
Call Stack Count: 1
 0: (0x404e2174) [/lib/libc.so.6] + 0x6b174
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
roxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
12-07 19:04:28.096+0200 E/WG-CONSUMER( 2217): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
12-07 19:04:28.096+0200 E/WG-CONSUMER( 2217): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
12-07 19:04:28.096+0200 E/WG-CONSUMER( 2217): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
12-07 19:04:28.096+0200 E/WG-CONSUMER( 2217): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
12-07 19:04:28.096+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
12-07 19:04:28.096+0200 E/WG-CONSUMER( 2217): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
12-07 19:04:28.106+0200 W/WG-CONSUMER( 2217): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42eaf8d0[0m
12-07 19:04:28.106+0200 W/CAPI_APPFW_APP_CONTROL( 2217): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-07 19:04:28.106+0200 W/CAPI_APPFW_APP_CONTROL( 2217): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
12-07 19:04:28.146+0200 I/CAPI_APPFW_APPLICATION( 2217): service_app_main.c: service_app_exit(441) > service_app_exit
12-07 19:04:28.146+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 22
12-07 19:04:28.146+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(916) > app status : 4
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
12-07 19:04:28.146+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
12-07 19:04:28.146+0200 E/WIPC_SERVER( 2217): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
12-07 19:04:28.161+0200 W/WG-CONSUMER( 2217): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
12-07 19:04:28.161+0200 I/CAPI_CONTENT_MEDIA_CONTENT( 2217): media_content.c: media_content_disconnect(958) > [32m[2217]ref count changed to: 0
12-07 19:04:28.201+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:558 elm_quicklaunch_init() eet_init done.
12-07 19:04:28.201+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
12-07 19:04:28.226+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
12-07 19:04:28.226+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
12-07 19:04:28.266+0200 E/WG-CONSUMER( 2217): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
12-07 19:04:28.266+0200 W/WG-CONSUMER( 2217): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
12-07 19:04:28.266+0200 W/WG-CONSUMER( 2217): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
12-07 19:04:28.266+0200 W/WG-CONSUMER( 2217): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
12-07 19:04:28.266+0200 W/WG-CONSUMER( 2217): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
12-07 19:04:28.266+0200 W/WG-CONSUMER( 2217): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
12-07 19:04:28.271+0200 W/WG-CONSUMER( 2217): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
12-07 19:04:28.306+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
12-07 19:04:28.311+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
12-07 19:04:28.316+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
12-07 19:04:28.316+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
12-07 19:04:28.316+0200 E/EFL     ( 2226): elementary<2226> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
12-07 19:04:28.341+0200 E/EFL     ( 2226): elementary<2226> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
12-07 19:04:28.356+0200 E/EFL     ( 2226): elementary<2226> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
12-07 19:04:28.356+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
12-07 19:04:28.451+0200 E/EFL     ( 2226): elementary<2226> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
12-07 19:04:28.501+0200 E/EFL     ( 2226): elementary<2226> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
12-07 19:04:28.501+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
12-07 19:04:28.501+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
12-07 19:04:28.501+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
12-07 19:04:28.501+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
12-07 19:04:28.501+0200 E/EFL     ( 2226): elementary<2226> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
12-07 19:04:28.501+0200 I/AUL_PAD ( 2226): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
12-07 19:04:28.506+0200 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
12-07 19:04:28.536+0200 W/MUSIC_PLAYER( 2219): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:2219]   W_SERVICE_TYPE_BT[1][0m
12-07 19:04:28.536+0200 W/MUSIC_PLAYER( 2219): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:2219]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
12-07 19:04:28.536+0200 W/MUSIC_TRANSFER( 2219): mt-service.c: _service_app_create(88) > [31m[TID:2219]   SAP is disconnected.. Terminate process[0m
12-07 19:04:28.536+0200 I/CAPI_APPFW_APPLICATION( 2219): service_app_main.c: service_app_exit(441) > service_app_exit
12-07 19:04:28.566+0200 W/AUL     ( 2233): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
12-07 19:04:28.576+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 23
12-07 19:04:28.576+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 19:04:28.576+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2217
12-07 19:04:28.576+0200 W/AUL_AMD (  534): amd_request.c: __send_app_termination_signal(510) > send dead signal done
12-07 19:04:28.581+0200 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2217
12-07 19:04:28.606+0200 W/MUSIC_PLAYER( 2219): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:2219]   vendor : LO[0m
12-07 19:04:28.606+0200 W/MUSIC_PLAYER( 2219): mp-conf.c: mp_conf_init(262) > [33m[TID:2219]   iOS  connected..[0m
12-07 19:04:28.611+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 22
12-07 19:04:28.611+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(916) > app status : 4
12-07 19:04:28.616+0200 I/AUL     ( 1116): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
12-07 19:04:28.616+0200 E/CAPI_APPFW_APP_MANAGER( 1116): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-07 19:04:28.616+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
12-07 19:04:28.616+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-07 19:04:28.616+0200 W/SHealth_Service( 1116): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
12-07 19:04:28.646+0200 W/MUSIC_TRANSFER( 2219): mt-service.c: _service_app_terminate(104) > [33m[TID:2219]   [0m
12-07 19:04:28.666+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 14
12-07 19:04:28.676+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2219
12-07 19:04:28.676+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 12
12-07 19:04:28.681+0200 W/SHealth_Common( 1116): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1512604800000,000000[0;m
12-07 19:04:28.711+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
12-07 19:04:28.746+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 14
12-07 19:04:28.756+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2043
12-07 19:04:28.771+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 12
12-07 19:04:28.776+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (007427)]][0;m
12-07 19:04:28.821+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
12-07 19:04:28.821+0200 W/SHealthWidget(  828): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (007427), msgName: timeline_summary_updated[0;m
12-07 19:04:28.821+0200 W/SHealth_Common(  828): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
12-07 19:04:28.831+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-07 19:04:28.851+0200 I/healthData( 1116): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-07 19:04:28.856+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-07 19:04:28.856+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 19:04:28.856+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-07 19:04:28.856+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-07 19:04:28.911+0200 I/CAPI_WIDGET_APPLICATION(  828): widget_app.c: __provider_update_cb(281) > received updating signal
12-07 19:04:28.916+0200 E/EFL     (  828): edje<828> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:04:28.936+0200 W/AUL     ( 2235): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
12-07 19:04:28.941+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 23
12-07 19:04:28.941+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 19:04:28.941+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2219
12-07 19:04:28.941+0200 W/AUL_AMD (  534): amd_request.c: __send_app_termination_signal(510) > send dead signal done
12-07 19:04:28.946+0200 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2219
12-07 19:04:30.151+0200 W/AUL_AMD (  534): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 19:04:30.616+0200 W/AUL_AMD (  534): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 19:04:32.576+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: MEM_FLUSH State: PAUSED
12-07 19:04:34.801+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-07 19:04:55.916+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
12-07 19:04:55.916+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
12-07 19:04:55.916+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
12-07 19:04:55.916+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
12-07 19:04:55.956+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-07 19:04:55.971+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 19:04:55.971+0200 W/W_HOME  (  776): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-07 19:04:55.971+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-07 19:04:55.971+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 1
12-07 19:04:55.971+0200 W/W_HOME  (  776): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-07 19:04:55.971+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:04:56.001+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
12-07 19:04:56.006+0200 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-07 19:04:56.006+0200 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 19:04:56.006+0200 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-07 19:04:56.006+0200 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-07 19:04:56.036+0200 W/W_INDICATOR(  714): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
12-07 19:04:56.056+0200 W/SHealth_Common(  828): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-07 19:04:56.061+0200 W/SHealth_Common( 1116): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-07 19:04:56.061+0200 W/SHealth_Service( 1116): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-07 19:04:56.101+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
12-07 19:04:56.101+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 19:04:56.106+0200 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-07 19:04:56.126+0200 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 19:04:56.126+0200 W/AUL_AMD (  534): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-07 19:04:56.136+0200 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 19:04:56.136+0200 W/AUL_AMD (  534): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-07 19:04:56.146+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:04:56.256+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
12-07 19:04:56.346+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
12-07 19:04:56.346+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
12-07 19:04:56.346+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-07 19:04:56.346+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-07 19:04:56.346+0200 E/ALARM_MANAGER(  711): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(7-12-2017, 19:05:16), repeat(1), interval(20), type(-1073741822)
12-07 19:04:56.361+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
12-07 19:04:56.361+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
12-07 19:04:56.366+0200 E/ALARM_MANAGER( 2043): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(64), start(7-12-2017, 19:06:00), repeat(1), interval(120), type(-1073741822)
12-07 19:04:56.371+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [711].
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 708154043, next duetime: 1512666316
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(708154043)
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512666840), due_time(1512666316)
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:05:16 (UTC).
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:04:56.426+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:04:56.431+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:04:56.431+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [2043].
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 708154044, next duetime: 1512666360
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(708154044)
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512666316), due_time(1512666360)
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:05:16 (UTC).
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:04:56.476+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:04:56.866+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
12-07 19:04:56.866+0200 W/W_CLOCK_VIEWER( 2043): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 19:05  /5 / HH:mm
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 19:05
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 19
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 05
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  19
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  05
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 19 / 5 / 19:05
12-07 19:05:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
12-07 19:05:00.831+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:05:01.121+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-07 19:05:15.991+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
12-07 19:05:16.031+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
12-07 19:05:16.111+0200 E/RESOURCED(  537): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 711
12-07 19:05:16.136+0200 E/ALARM_MANAGER(  711): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [708154043]
12-07 19:05:16.136+0200 W/STARTER (  711): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [708154043]
12-07 19:05:16.141+0200 W/AUL     (  711): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
12-07 19:05:16.141+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 0
12-07 19:05:16.146+0200 W/AUL_AMD (  534): amd_launch.c: _start_app(1710) > caller pid : 711
12-07 19:05:16.151+0200 W/AUL_AMD (  534): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 776
12-07 19:05:16.156+0200 W/AUL_AMD (  534): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(776), cmd(0)
12-07 19:05:16.156+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: RESET State: PAUSED
12-07 19:05:16.156+0200 I/CAPI_APPFW_APPLICATION(  776): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-07 19:05:16.156+0200 W/W_HOME  (  776): main.c: _app_control(1704) > Service value : show_clock
12-07 19:05:16.156+0200 W/W_HOME  (  776): main.c: _app_control(1746) > Show clock operation
12-07 19:05:16.156+0200 W/W_HOME  (  776): gesture.c: _clock_show(245) > clock show
12-07 19:05:16.161+0200 W/AUL     (  711): launch.c: app_request_to_launchpad(282) > request cmd(0) result(776)
12-07 19:05:16.166+0200 W/W_HOME  (  776): gesture.c: _clock_show(260) > home raise
12-07 19:05:16.166+0200 E/W_HOME  (  776): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
12-07 19:05:16.166+0200 W/W_HOME  (  776): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-07 19:05:16.166+0200 W/W_HOME  (  776): gesture.c: _clock_show(263) > home raise done
12-07 19:05:16.166+0200 W/W_HOME  (  776): gesture.c: _clock_show(270) > show clock
12-07 19:05:16.166+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[708154043] is expired.
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 708154043, next duetime: 1512666336
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:05:36 (UTC).
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:05:16.176+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
12-07 19:05:16.206+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [711].
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(708154043)
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:06:00 (UTC).
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:05:16.241+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[708154043] is removed.
12-07 19:05:16.246+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:05:17.156+0200 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 19:05:17.156+0200 W/AUL_AMD (  534): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
12-07 19:05:36.731+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 76
12-07 19:05:36.731+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
12-07 19:05:36.731+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
12-07 19:05:36.736+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 76, index 15, bg level 75
12-07 19:05:36.736+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
12-07 19:05:36.741+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 76
12-07 19:05:36.751+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:05:59.996+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
12-07 19:06:00.056+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
12-07 19:06:00.141+0200 E/ALARM_MANAGER( 2043): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [708154044]
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[708154044] is expired.
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 708154044, next duetime: 1512666480
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:08:00 (UTC).
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:06:00.151+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
12-07 19:06:00.156+0200 E/WIDGET_EVAS( 2043): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
12-07 19:06:00.186+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 19:06  /5 / HH:mm
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 19:06
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 19
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 06
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  19
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  06
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 19 / 6 / 19:06
12-07 19:06:00.806+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
12-07 19:06:00.821+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:06:36.961+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 77
12-07 19:06:36.966+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
12-07 19:06:36.966+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
12-07 19:06:36.966+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 77, index 15, bg level 75
12-07 19:06:36.966+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
12-07 19:06:36.966+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 77
12-07 19:06:37.011+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:07:00.831+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 19:07  /5 / HH:mm
12-07 19:07:00.831+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 19:07
12-07 19:07:00.831+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
12-07 19:07:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 19
12-07 19:07:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 07
12-07 19:07:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  19
12-07 19:07:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  07
12-07 19:07:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 19 / 7 / 19:07
12-07 19:07:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
12-07 19:07:00.861+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:07:27.181+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 78
12-07 19:07:27.196+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
12-07 19:07:27.196+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
12-07 19:07:27.196+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 78, index 15, bg level 75
12-07 19:07:27.196+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
12-07 19:07:27.236+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 78
12-07 19:07:27.271+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:07:59.996+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
12-07 19:08:00.046+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
12-07 19:08:00.121+0200 E/ALARM_MANAGER( 2043): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [708154044]
12-07 19:08:00.141+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[708154044] is expired.
12-07 19:08:00.141+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:08:00.141+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 708154044, next duetime: 1512666600
12-07 19:08:00.146+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:08:00.146+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:10:00 (UTC).
12-07 19:08:00.146+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:08:00.146+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:08:00.146+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
12-07 19:08:00.166+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
12-07 19:08:00.831+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 19:08  /5 / HH:mm
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 19:08
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 19
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 08
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  19
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  08
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 19 / 8 / 19:08
12-07 19:08:00.836+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
12-07 19:08:00.851+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:08:07.481+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 79
12-07 19:08:07.506+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
12-07 19:08:07.506+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
12-07 19:08:07.506+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 79, index 15, bg level 75
12-07 19:08:07.506+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
12-07 19:08:07.531+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 79
12-07 19:08:07.571+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:08:57.811+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 80
12-07 19:08:57.811+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
12-07 19:08:57.811+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
12-07 19:08:57.811+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 80, index 16, bg level 80
12-07 19:08:57.811+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_80
12-07 19:08:57.811+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 80
12-07 19:08:57.821+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:08:58.421+0200 E/PKGMGR_SERVER( 2519): pkgmgr-server.c: main(2167) > package manager server start
12-07 19:08:58.551+0200 E/PKGMGR_SERVER( 2519): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_531405526], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[WMlrsydcFoqLTqApAwLHF3vF66E=], backend_flag=[0]
12-07 19:08:58.566+0200 E/PKGMGR_SERVER( 2520): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
12-07 19:08:58.566+0200 E/PKGMGR  ( 2517): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
12-07 19:08:58.686+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 14
12-07 19:08:58.696+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1957
12-07 19:08:58.696+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 12
12-07 19:08:58.696+0200 W/AUL     ( 2520): launch.c: app_request_to_launchpad(268) > request cmd(5) to(1957)
12-07 19:08:58.701+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 5
12-07 19:08:58.706+0200 W/AUL_AMD (  534): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(1957), cmd(4)
12-07 19:08:58.706+0200 W/AUL     ( 2520): launch.c: app_request_to_launchpad(282) > request cmd(5) result(0)
12-07 19:08:58.706+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 14
12-07 19:08:58.716+0200 I/APP_CORE( 1957): appcore-efl.c: __do_app(429) > [APP 1957] Event: TERMINATE State: PAUSED
12-07 19:08:58.716+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1957
12-07 19:08:58.721+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 22
12-07 19:08:58.721+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(916) > app status : 4
12-07 19:08:58.761+0200 E/APP_CORE( 1957): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-07 19:08:58.761+0200 I/APP_CORE( 1957): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-07 19:08:58.761+0200 I/CAPI_APPFW_APPLICATION( 1957): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-07 19:08:58.806+0200 I/Bluetooth( 1957): [bt_socket_destroy_rfcomm] success.
12-07 19:08:58.821+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 14
12-07 19:08:58.831+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1957
12-07 19:08:58.931+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 14
12-07 19:08:58.941+0200 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 19:08:58.946+0200 E/PKGMGR_SERVER( 2520): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
12-07 19:08:58.971+0200 E/PKGMGR_SERVER( 2519): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2520]
12-07 19:08:59.096+0200 W/CRASH_MANAGER( 2522): worker.c: worker_job(1205) > 1101957646174151266653
