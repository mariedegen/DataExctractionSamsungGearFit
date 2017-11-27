S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2350
Date: 2017-11-26 21:31:32+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2350, uid 5000)

Register Information
r0   = 0x00000011, r1   = 0x00000209
r2   = 0x43ecd120, r3   = 0x4059d280
r4   = 0x4059d280, r5   = 0x43ecd120
r6   = 0x8446a3a0, r7   = 0x4059d250
r8   = 0x43ec7dc0, r9   = 0x000001ff
r10  = 0x00000050, fp   = 0x00000000
ip   = 0x4059d25c, sp   = 0xbea48178
lr   = 0x404e3434, pc   = 0x404e1c9c
cpsr = 0x60000010

Memory Information
MemTotal:   490928 KB
MemFree:     92692 KB
Buffers:     26240 KB
Cached:     153476 KB
VmPeak:      98996 KB
VmSize:      97520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19564 KB
VmRSS:       19564 KB
VmData:      41568 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25032 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2350 TID = 2350
2350 2461 

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
414d0000 414da000 r-xp /lib/libnss_files-2.13.so
414e3000 414e8000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
414f8000 4152a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41533000 41537000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41543000 41547000 rw-p [heap]
41547000 41568000 rw-p [heap]
41568000 41637000 r-xp /usr/lib/libscim-1.0.so.8.2.3
417c8000 417e9000 r-xp /usr/lib/libefl-extension.so.0.1.0
417f2000 4182c000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41835000 4184e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41856000 4185b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41863000 4188d000 r-xp /usr/lib/libsensor.so.1.9.6
41896000 4194e000 r-xp /usr/lib/libcairo.so.2.11200.14
41959000 4195c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41964000 4196a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41973000 4197b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41983000 4198d000 r-xp /usr/lib/libsensord-shared.so
41996000 419a4000 r-xp /usr/lib/libGLESv2.so.2.0
419ad000 419ae000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419b7000 419bd000 r-xp /usr/lib/libxcb-render.so.0.0.0
419c5000 419c8000 r-xp /usr/lib/libEGL.so.1.4
419d0000 419dd000 r-xp /usr/lib/libail.so.0.1.0
419e6000 41b23000 r-xp /usr/lib/libicui18n.so.51.1
41b33000 41c17000 r-xp /usr/lib/libicuuc.so.51.1
431b5000 431d1000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431da000 431e1000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431ea000 431ec000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431f4000 431fb000 r-xp /usr/lib/libminizip.so.1.0.0
43203000 432cd000 r-xp /usr/lib/libCOREGL.so.4.0
434e0000 43cdf000 rw-p [stack:2461]
43cdf000 43cea000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43cf3000 43cf5000 r-xp /usr/lib/libdri2.so.0.0.0
43e00000 43e05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43e13000 43e1b000 r-xp /usr/lib/libdrm.so.2.4.0
43e23000 43e2a000 r-xp /usr/lib/libtbm.so.1.0.0
43fcd000 43fce000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fd6000 43fd8000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
459f4000 459f5000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
459fd000 45a00000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45a10000 45a17000 r-xp /usr/lib/libfeedback.so.0.1.4
45a20000 45a21000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a29000 45a2b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a33000 45a3d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a45000 45a4c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a54000 45a6a000 r-xp /usr/lib/libmmfsound.so.0.1.0
45a7c000 45a81000 r-xp /usr/lib/libmmfsession.so.0.0.0
45a89000 45a93000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45a9f000 45aa3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45aac000 45ac1000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45ac9000 45b2a000 r-xp /usr/lib/libasound.so.2.0.0
45b34000 45b37000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b3f000 45b77000 r-xp /usr/lib/libpulse.so.0.16.2
45b78000 45ba9000 r-xp /usr/lib/libmdm.so.1.1.86
45bb1000 45bb6000 r-xp /usr/lib/libjson.so.0.0.1
45bbe000 45c06000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c07000 45c4e000 r-xp /usr/lib/libsndfile.so.1.0.26
45c5a000 45c62000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c63000 45c85000 r-xp /usr/lib/libvorbis.so.0.4.3
45c8d000 45c91000 r-xp /usr/lib/libogg.so.0.7.1
45ef5000 45ef6000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
bea28000 bea49000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2350)
Call Stack Count: 1
 0: (0x404e1c9c) [/lib/libc.so.6] + 0x6ac9c
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
gePort SendMessage
11-26 21:30:34.812+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-26 21:30:34.812+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-26 21:30:34.812+0200 W/SHealth_Common( 1087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-26 21:30:34.812+0200 I/CAPI_WIDGET_APPLICATION(  832): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-26 21:30:34.827+0200 W/SHealth_Common(  832): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-26 21:30:34.827+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-26 21:30:34.827+0200 W/SHealth_Common( 1087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-26 21:30:34.827+0200 I/CAPI_WIDGET_APPLICATION(  832): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-26 21:30:34.837+0200 W/SHealth_Common(  832): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-26 21:30:34.837+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-26 21:30:34.837+0200 I/CAPI_WIDGET_APPLICATION(  832): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-26 21:30:34.842+0200 W/SHealth_Common( 1087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-26 21:30:34.847+0200 W/SHealth_Common(  832): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-26 21:30:34.847+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-26 21:30:34.847+0200 I/CAPI_WIDGET_APPLICATION(  832): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-26 21:30:34.847+0200 W/SHealth_Common( 1087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-26 21:30:35.132+0200 E/EFL     (  776): ecore_x<776> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=491236 button=1
11-26 21:30:35.132+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.132+0200 E/W_HOME  (  776): move.c: _mouse_down_cb(384) > apps move is not allowed
11-26 21:30:35.132+0200 W/APPS    (  776): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
11-26 21:30:35.142+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.157+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.157+0200 W/APPS    (  776): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-26 21:30:35.172+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.177+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.192+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.202+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.217+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.227+0200 E/EFL     (  776): ecore_x<776> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=491332 button=1
11-26 21:30:35.227+0200 E/APPS    (  776): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
11-26 21:30:35.457+0200 W/AUL_AMD (  536): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-26 21:30:35.457+0200 W/AUL_AMD (  536): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-26 21:30:35.877+0200 E/EFL     (  776): ecore_x<776> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=491980 button=1
11-26 21:30:35.877+0200 E/W_HOME  (  776): move.c: _mouse_move_cb(546) > apps move is not allowed
11-26 21:30:35.877+0200 E/W_HOME  (  776): move.c: _mouse_down_cb(384) > apps move is not allowed
11-26 21:30:35.877+0200 W/APPS    (  776): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-26 21:30:35.922+0200 E/EFL     (  776): ecore_x<776> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=492028 button=1
11-26 21:30:35.927+0200 W/APPS    (  776): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-26 21:30:35.927+0200 E/APPS    (  776): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-26 21:30:35.927+0200 W/APPS    (  776): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-26 21:30:35.927+0200 W/AUL     (  776): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-26 21:30:35.927+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(645) > __request_handler: 0
11-26 21:30:35.927+0200 W/AUL_AMD (  536): amd_launch.c: _start_app(1710) > caller pid : 776
11-26 21:30:35.927+0200 I/AUL_AMD (  536): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
11-26 21:30:35.937+0200 W/AUL_AMD (  536): amd_launch.c: _start_app(2124) > pad pid(-5)
11-26 21:30:35.937+0200 E/RESOURCED(  537): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-26 21:30:35.942+0200 E/RESOURCED(  537): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-26 21:30:35.942+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-26 21:30:35.942+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-26 21:30:35.972+0200 I/efl-extension( 2350): efl_extension.c: eext_mod_init(40) > Init
11-26 21:30:35.972+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: ui_app_main(704) > app_efl_main
11-26 21:30:35.977+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-26 21:30:36.042+0200 W/AUL     (  776): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2350)
11-26 21:30:36.042+0200 E/W_HOME  (  776): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
11-26 21:30:36.062+0200 E/AUL     (  536): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-26 21:30:36.062+0200 E/RESOURCED(  537): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
11-26 21:30:36.067+0200 I/Bluetooth( 2350): [bt_initialize] success.
11-26 21:30:36.092+0200 I/Bluetooth( 2350): [bt_adapter_get_state] success.
11-26 21:30:36.152+0200 E/EFL     ( 2350): ecore_evas<2350> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-26 21:30:36.457+0200 W/W_HOME  (  776): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-26 21:30:36.457+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.457+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.457+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.462+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(429) > [APP 2350] Event: RESET State: CREATED
11-26 21:30:36.462+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-26 21:30:36.497+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-26 21:30:36.497+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(474) > [APP 2350] Initial Launching, call the resume_cb
11-26 21:30:36.497+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-26 21:30:36.502+0200 W/APP_CORE( 2350): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
11-26 21:30:36.552+0200 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(453) > Window [0x2800003] is now visible(1)
11-26 21:30:36.552+0200 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-26 21:30:36.552+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.552+0200 W/W_HOME  (  776): main.c: _window_visibility_cb(1211) > Window [0x2800003] is now visible(1)
11-26 21:30:36.557+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: PAUSE State: RUNNING
11-26 21:30:36.557+0200 I/CAPI_APPFW_APPLICATION(  776): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-26 21:30:36.557+0200 W/W_HOME  (  776): main.c: _appcore_pause_cb(696) > appcore pause
11-26 21:30:36.557+0200 W/W_HOME  (  776): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-26 21:30:36.557+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.557+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.557+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-26 21:30:36.572+0200 I/MESSAGE_PORT(  488): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-26 21:30:36.572+0200 E/CAPI_APPFW_APP_CONTROL( 1292): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-26 21:30:36.572+0200 W/MUSIC_CONTROL_SERVICE( 1292): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1292]   [com.samsung.w-home]register msg port [false][0m
11-26 21:30:36.622+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(429) > [APP 2350] Event: RESUME State: RUNNING
11-26 21:30:36.652+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:36.652+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:36.652+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:36.652+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:36.652+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:36.652+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:36.662+0200 W/wnotib  (  776): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-26 21:30:36.852+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:30:36.852+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:30:36.852+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:30:36.897+0200 E/AUL     (  536): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-26 21:30:37.072+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: MEM_FLUSH State: PAUSED
11-26 21:30:37.122+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(645) > __request_handler: 14
11-26 21:30:37.132+0200 W/AUL_AMD (  536): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2350
11-26 21:30:37.132+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(645) > __request_handler: 12
11-26 21:30:37.167+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(645) > __request_handler: 14
11-26 21:30:37.172+0200 W/AUL_AMD (  536): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2350
11-26 21:30:37.177+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(645) > __request_handler: 12
11-26 21:30:37.357+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-26 21:30:37.362+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-26 21:30:37.377+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:37.392+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-26 21:30:37.392+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-26 21:30:37.447+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-26 21:30:37.447+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-26 21:30:37.452+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-26 21:30:37.452+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-26 21:30:37.452+0200 E/EFL     ( 2471): elementary<2471> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-26 21:30:37.467+0200 E/EFL     ( 2471): elementary<2471> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-26 21:30:37.472+0200 E/EFL     ( 2471): elementary<2471> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-26 21:30:37.472+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-26 21:30:37.512+0200 E/EFL     ( 2471): elementary<2471> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-26 21:30:37.522+0200 E/EFL     ( 2471): elementary<2471> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-26 21:30:37.522+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-26 21:30:37.522+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-26 21:30:37.522+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-26 21:30:37.522+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-26 21:30:37.522+0200 E/EFL     ( 2471): elementary<2471> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-26 21:30:37.522+0200 I/AUL_PAD ( 2471): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-26 21:30:37.917+0200 W/W_INDICATOR(  730): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
11-26 21:30:37.917+0200 W/W_INDICATOR(  730): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-26 21:30:38.377+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:39.382+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:40.387+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:41.387+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:41.577+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: MEM_FLUSH State: PAUSED
11-26 21:30:42.387+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:43.397+0200 I/INFO_TAG( 2350): SENSOR_EVENT HEART RATE < 40 : 0
11-26 21:30:44.392+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-26 21:30:44.422+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-26 21:30:44.787+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:30:46.432+0200 E/EFL     ( 2350): ecore_x<2350> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=502534 button=1
11-26 21:30:46.452+0200 E/EFL     ( 2350): ecore_x<2350> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=502556 button=1
11-26 21:30:46.612+0200 E/RECORDING_TAG( 2350): sensor_listener_unset_event_cb error: -38010874
11-26 21:30:46.622+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-26 21:30:46.637+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-26 21:30:46.997+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:30:47.387+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 64
11-26 21:30:47.427+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 64
11-26 21:30:48.387+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 63
11-26 21:30:48.402+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 63
11-26 21:30:49.412+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 61
11-26 21:30:49.437+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 61
11-26 21:30:50.397+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 62
11-26 21:30:50.417+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 62
11-26 21:30:51.392+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 64
11-26 21:30:51.417+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 64
11-26 21:30:52.387+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 65
11-26 21:30:52.402+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 65
11-26 21:30:53.392+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 65
11-26 21:30:53.417+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 65
11-26 21:30:54.392+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 65
11-26 21:30:54.402+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 65
11-26 21:30:55.382+0200 E/EFL     ( 2350): ecore_x<2350> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=511481 button=1
11-26 21:30:55.392+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 HEART RATE : 65
11-26 21:30:55.392+0200 I/INFO_TAG( 2350): SENSOR_EVENT2 TAB VALUE : 65
11-26 21:30:55.422+0200 E/EFL     ( 2350): ecore_x<2350> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=511516 button=1
11-26 21:30:55.437+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-26 21:30:55.517+0200 I/Bluetooth( 2350): [bt_socket_create_rfcomm] success.
11-26 21:30:55.607+0200 I/BluetoothServer( 2350): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-26 21:30:55.607+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-26 21:30:55.772+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:30:59.942+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-26 21:30:59.942+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-26 21:30:59.942+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_double(1214) > preference_get_double(1087) : pedometer_inactive_period error
11-26 21:30:59.947+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-26 21:30:59.947+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-26 21:30:59.947+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_double(1214) > preference_get_double(1087) : inactive_10min_precaution_millisec error
11-26 21:30:59.947+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-26 21:30:59.947+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-26 21:30:59.947+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_double(1214) > preference_get_double(1087) : inactive_before_10min_precaution_millisec error
11-26 21:31:08.557+0200 W/WECONN  (  515): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-26 21:31:17.227+0200 I/BluetoothServer( 2350): Callback: Connected.
11-26 21:31:17.227+0200 I/BluetoothServer( 2350): Callback: Socket of connection - 27.
11-26 21:31:17.227+0200 I/BluetoothServer( 2350): Callback: Role of connection - 1.
11-26 21:31:17.227+0200 I/BluetoothServer( 2350): Callback: Address of connection - B8:81:98:D4:F2:78.
11-26 21:31:17.227+0200 E/dataextraction( 2350): Can't open the file
11-26 21:31:17.227+0200 I/BluetoothServer( 2350): Sent: '`'ÍC`•qA63,000000 61,000000 62,000000 64,000000 65,000000 65,000000 65,000000 65,000000 0,000000 '
11-26 21:31:17.337+0200 E/Bluetooth( 2350): [bt_socket_send_data] unknown error code : 98.
11-26 21:31:17.337+0200 E/Bluetooth( 2350): [bt_socket_send_data] unknown error code : 3.
11-26 21:31:17.337+0200 I/BluetoothServer( 2350): All data sent
11-26 21:31:17.337+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-26 21:31:17.352+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-26 21:31:17.602+0200 I/BluetoothServer( 2350): Callback: Disconnected.
11-26 21:31:17.602+0200 I/BluetoothServer( 2350): Callback: Socket of disconnection - 27.
11-26 21:31:17.602+0200 I/BluetoothServer( 2350): Callback: Address of connection - B8:81:98:D4:F2:78.
11-26 21:31:17.717+0200 E/EFL     ( 2350): elementary<2350> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-26 21:31:20.992+0200 W/WECONN  (  515): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-26 21:31:24.992+0200 W/WATCH_CORE(  820): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
11-26 21:31:25.002+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(204) > LCD off
11-26 21:31:25.002+0200 W/W_HOME  (  776): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-26 21:31:25.002+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-26 21:31:25.002+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 1
11-26 21:31:25.002+0200 W/W_HOME  (  776): event_manager.c: _lcd_off_cb(704) > lcd state: 0
11-26 21:31:25.002+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:25.017+0200 W/STARTER (  726): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
11-26 21:31:25.017+0200 W/STARTER (  726): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
11-26 21:31:25.032+0200 E/STARTER (  726): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
11-26 21:31:25.032+0200 W/STARTER (  726): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
11-26 21:31:25.032+0200 W/STARTER (  726): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
11-26 21:31:25.202+0200 W/SHealth_Common(  832): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-26 21:31:25.237+0200 W/SHealth_Common( 1087): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-26 21:31:25.237+0200 W/SHealth_Service( 1087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-26 21:31:25.247+0200 W/STARTER (  726): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
11-26 21:31:25.247+0200 W/STARTER (  726): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
11-26 21:31:25.247+0200 W/STARTER (  726): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
11-26 21:31:25.247+0200 W/STARTER (  726): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
11-26 21:31:25.247+0200 E/ALARM_MANAGER(  726): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-11-2017, 21:31:45), repeat(1), interval(20), type(-1073741822)
11-26 21:31:25.257+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(429) > [APP 2350] Event: PAUSE State: RUNNING
11-26 21:31:25.257+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
11-26 21:31:25.287+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [726].
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 113467021, next duetime: 1511724705
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(113467021)
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1511729252), due_time(1511724705)
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-11-2017, 19:31:45 (UTC).
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-26 21:31:25.372+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-26 21:31:30.417+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(429) > [APP 2350] Event: MEM_FLUSH State: PAUSED
11-26 21:31:31.377+0200 W/WATCH_CORE(  820): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
11-26 21:31:31.377+0200 I/WATCH_CORE(  820): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
11-26 21:31:31.382+0200 I/CAPI_WATCH_APPLICATION(  820): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-26 21:31:31.382+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(186) > LCD on
11-26 21:31:31.382+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_set(165) > timer set
11-26 21:31:31.382+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-26 21:31:31.382+0200 W/W_HOME  (  776): gesture.c: _apps_status_get(126) > apps status:0
11-26 21:31:31.382+0200 W/W_HOME  (  776): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:6323
11-26 21:31:31.382+0200 W/W_HOME  (  776): gesture.c: _manual_render_schedule(212) > schedule, manual render
11-26 21:31:31.382+0200 W/W_HOME  (  776): event_manager.c: _lcd_on_cb(696) > lcd state: 1
11-26 21:31:31.382+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:31.387+0200 W/STARTER (  726): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [6323]ms
11-26 21:31:31.387+0200 W/STARTER (  726): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-26 21:31:31.432+0200 W/W_HOME  (  776): gesture.c: _widget_updated_cb(194) > widget updated
11-26 21:31:31.432+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-26 21:31:31.432+0200 W/W_HOME  (  776): gesture.c: _manual_render(180) > 
11-26 21:31:31.437+0200 I/APP_CORE( 2350): appcore-efl.c: __do_app(429) > [APP 2350] Event: RESUME State: PAUSED
11-26 21:31:31.437+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [726].
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(113467021)
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-11-2017, 20:47:32 (UTC).
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[113467021] is removed.
11-26 21:31:31.477+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-26 21:31:31.497+0200 W/SHealth_Common(  832): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-26 21:31:31.537+0200 I/MALI    (  776): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-26 21:31:31.547+0200 W/W_HOME  (  776): gesture.c: _manual_render(180) > 
11-26 21:31:31.562+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 0
11-26 21:31:31.567+0200 W/STARTER (  726): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
11-26 21:31:31.567+0200 W/STARTER (  726): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-26 21:31:31.572+0200 W/SHealth_Common( 1087): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-26 21:31:31.572+0200 W/SHealth_Service( 1087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-26 21:31:31.577+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
11-26 21:31:31.577+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
11-26 21:31:31.577+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_boolean(1173) > preference_get_boolean(1087) : test_healthy_pace error
11-26 21:31:31.582+0200 W/SHealth_Common( 1087): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1511654400000,000000[0;m
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_double(1214) > preference_get_double(1087) : pedometer_inactive_period error
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_double(1214) > preference_get_double(1087) : inactive_10min_precaution_millisec error
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-26 21:31:31.612+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1087): preference.c: preference_get_double(1214) > preference_get_double(1087) : inactive_before_10min_precaution_millisec error
11-26 21:31:31.617+0200 W/SHealth_Common( 1087): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (191828)]][0;m
11-26 21:31:31.647+0200 W/SHealth_Common( 1087): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
11-26 21:31:31.647+0200 W/SHealthWidget(  832): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (191828), msgName: timeline_summary_updated[0;m
11-26 21:31:31.647+0200 W/SHealth_Common(  832): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
11-26 21:31:31.657+0200 I/HealthDataService(  781): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
11-26 21:31:31.677+0200 I/healthData( 1087): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-26 21:31:31.677+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-26 21:31:31.677+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-26 21:31:31.677+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-26 21:31:31.677+0200 E/TIZEN_N_SYSTEM_SETTINGS(  832): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-26 21:31:31.697+0200 I/CAPI_WIDGET_APPLICATION(  832): widget_app.c: __provider_update_cb(281) > received updating signal
11-26 21:31:31.697+0200 E/EFL     (  832): edje<832> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
11-26 21:31:31.867+0200 E/EFL     ( 2350): ecore_x<2350> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=547968 button=1
11-26 21:31:31.902+0200 E/EFL     ( 2350): ecore_x<2350> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=548005 button=1
11-26 21:31:31.902+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(645) > __request_handler: 22
11-26 21:31:31.902+0200 W/AUL_AMD (  536): amd_request.c: __request_handler(916) > app status : 4
11-26 21:31:31.957+0200 E/APP_CORE( 2350): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-26 21:31:31.957+0200 I/APP_CORE( 2350): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-26 21:31:31.957+0200 I/APP_CORE( 2350): appcore-efl.c: __after_loop(1089) > [APP 2350] PAUSE before termination
11-26 21:31:31.957+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
11-26 21:31:31.957+0200 I/CAPI_APPFW_APPLICATION( 2350): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-26 21:31:31.992+0200 E/Bluetooth( 2350): [bt_socket_disconnect_rfcomm] INVALIDE PARAM
11-26 21:31:32.027+0200 E/Bluetooth( 2350): [bt_socket_disconnect_rfcomm] INVALIDE PARAM
11-26 21:31:32.387+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2350 pgid = 2350
11-26 21:31:32.582+0200 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
11-26 21:31:32.672+0200 W/AUL_AMD (  536): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-26 21:31:32.672+0200 W/AUL_AMD (  536): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-26 21:31:32.672+0200 W/W_HOME  (  776): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
11-26 21:31:32.672+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.672+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.677+0200 W/WATCH_CORE(  820): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
11-26 21:31:32.677+0200 I/WATCH_CORE(  820): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
11-26 21:31:32.677+0200 I/CAPI_WATCH_APPLICATION(  820): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-26 21:31:32.712+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.727+0200 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(453) > Window [0x2800003] is now visible(0)
11-26 21:31:32.727+0200 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
11-26 21:31:32.727+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.727+0200 W/W_HOME  (  776): main.c: _window_visibility_cb(1211) > Window [0x2800003] is now visible(0)
11-26 21:31:32.727+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: RESUME State: PAUSED
11-26 21:31:32.727+0200 I/CAPI_APPFW_APPLICATION(  776): app_main.c: app_appcore_resume(223) > app_appcore_resume
11-26 21:31:32.727+0200 W/W_HOME  (  776): main.c: _appcore_resume_cb(687) > appcore resume
11-26 21:31:32.727+0200 W/W_HOME  (  776): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
11-26 21:31:32.727+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.737+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.737+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-26 21:31:32.772+0200 W/wnotib  (  776): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
11-26 21:31:32.912+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-26 21:31:32.917+0200 I/AUL_AMD (  536): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2350
11-26 21:31:32.922+0200 E/RESOURCED(  537): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.174
11-26 21:31:32.982+0200 W/CRASH_MANAGER( 2562): worker.c: worker_job(1205) > 1102350646174151172469
