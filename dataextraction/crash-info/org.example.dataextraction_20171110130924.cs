S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 5977
Date: 2017-11-10 13:09:24+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5977, uid 5000)

Register Information
r0   = 0xbe974560, r1   = 0x43d2cbc0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x43d78b90, r5   = 0x43d2cbc0
r6   = 0x41adead0, r7   = 0xbe9742d0
r8   = 0x00000000, r9   = 0x43d5fca8
r10  = 0x43d6b470, fp   = 0x00000001
ip   = 0x43d2cbc0, sp   = 0xbe9742a8
lr   = 0xbe974560, pc   = 0x41644d02
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     83796 KB
Buffers:     31784 KB
Cached:     157796 KB
VmPeak:      97800 KB
VmSize:      96324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19332 KB
VmRSS:       19328 KB
VmData:      40452 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25016 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5977 TID = 5977
5977 6064 6073 

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
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 41648000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41658000 4168a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41693000 41697000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
416a0000 416c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
416ca000 41704000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4170d000 41726000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4172e000 41733000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4173b000 41765000 r-xp /usr/lib/libsensor.so.1.9.6
4176e000 41826000 r-xp /usr/lib/libcairo.so.2.11200.14
41831000 41834000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4183c000 41842000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4184b000 41853000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4185b000 41865000 r-xp /usr/lib/libsensord-shared.so
4186e000 4187c000 r-xp /usr/lib/libGLESv2.so.2.0
41885000 41886000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4188f000 41895000 r-xp /usr/lib/libxcb-render.so.0.0.0
4189d000 418a0000 r-xp /usr/lib/libEGL.so.1.4
418a8000 418b5000 r-xp /usr/lib/libail.so.0.1.0
418be000 419a2000 r-xp /usr/lib/libicuuc.so.51.1
419b7000 419d3000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
419dc000 419e3000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
419ec000 41b02000 rw-p [heap]
41b02000 41c3f000 r-xp /usr/lib/libicui18n.so.51.1
431d8000 431da000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431e2000 431e9000 r-xp /usr/lib/libminizip.so.1.0.0
431f1000 432bb000 r-xp /usr/lib/libCOREGL.so.4.0
434ce000 43ccd000 rw-p [stack:6064]
43ccd000 43cd8000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ce1000 43ce6000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43cf4000 43cfc000 r-xp /usr/lib/libdrm.so.2.4.0
43d04000 43d0b000 r-xp /usr/lib/libtbm.so.1.0.0
43d13000 43d15000 r-xp /usr/lib/libdri2.so.0.0.0
43eb8000 43eb9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43ec1000 43ec3000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44ecc000 457cb000 rw-p [stack:6073]
4593b000 4593c000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45957000 4595e000 r-xp /usr/lib/libfeedback.so.0.1.4
45967000 45968000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45970000 45972000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
4597a000 45984000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
4598c000 45993000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4599b000 459b1000 r-xp /usr/lib/libmmfsound.so.0.1.0
459c3000 459c8000 r-xp /usr/lib/libmmfsession.so.0.0.0
459d0000 459da000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
459e6000 459ea000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
459f3000 45a08000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45a10000 45a71000 r-xp /usr/lib/libasound.so.2.0.0
45a7b000 45a7e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a86000 45abe000 r-xp /usr/lib/libpulse.so.0.16.2
45abf000 45af0000 r-xp /usr/lib/libmdm.so.1.1.86
45af8000 45afd000 r-xp /usr/lib/libjson.so.0.0.1
45b05000 45b4d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b4e000 45b95000 r-xp /usr/lib/libsndfile.so.1.0.26
45ba1000 45ba9000 r-xp /usr/lib/libmdm-common.so.1.0.89
45baa000 45bcc000 r-xp /usr/lib/libvorbis.so.0.4.3
45bd4000 45bd8000 r-xp /usr/lib/libogg.so.0.7.1
be954000 be975000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5977)
Call Stack Count: 17
 0: clicked_redo_app + 0x13 (0x41644d02) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d02
 1: evas_object_smart_callback_call + 0x88 (0x4022e725) [/usr/lib/libevas.so.1] + 0x35725
 2: (0x40360ad9) [/usr/lib/libedje.so.1] + 0x45ad9
 3: (0x40364ac1) [/usr/lib/libedje.so.1] + 0x49ac1
 4: (0x40361431) [/usr/lib/libedje.so.1] + 0x46431
 5: (0x403617e3) [/usr/lib/libedje.so.1] + 0x467e3
 6: (0x4036191d) [/usr/lib/libedje.so.1] + 0x4691d
 7: (0x402f83f5) [/usr/lib/libecore.so.1] + 0xb3f5
 8: (0x402f5e53) [/usr/lib/libecore.so.1] + 0x8e53
 9: (0x402f946b) [/usr/lib/libecore.so.1] + 0xc46b
10: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
12: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x66 (0x41644c3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
14: create_base_gui + 0x4a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
15: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
16: clicked_redo_app + 0x21 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
-10 13:09:04.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:04.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:04.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:04.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:04.640+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:04.640+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:09:04.645+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:09:04.655+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:04.660+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:04.660+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:09:04.675+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:04.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:04.675+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:09:04.685+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:04.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:04.685+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:09:04.690+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:09:04.720+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:09:04.720+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:09:04.810+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:09:04.810+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-10 13:09:04.855+0200 W/W_HOME  (  765): move.c: _transit_del_cb(115) > transit end
11-10 13:09:04.860+0200 W/W_HOME  (  765): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
11-10 13:09:04.860+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:04.875+0200 W/W_HOME  (  765): move.c: _scroller_down_done(494) > down signal done
11-10 13:09:04.875+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(583) > apps,hide
11-10 13:09:04.875+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(601) > state: 0 -> 0
11-10 13:09:04.875+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:04.880+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:04.880+0200 W/W_HOME  (  765): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
11-10 13:09:04.880+0200 W/W_HOME  (  765): main.c: home_resume(739) > clock/widget resumed
11-10 13:09:04.880+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_resume(537) > 
11-10 13:09:04.880+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:04.885+0200 W/W_HOME  (  765): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
11-10 13:09:04.885+0200 W/W_HOME  (  765): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
11-10 13:09:04.885+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
11-10 13:09:04.885+0200 I/wnotib  (  765): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
11-10 13:09:04.890+0200 E/APPS    (  765): apps_main.c: apps_main_pause(602) >  paused already
11-10 13:09:05.135+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
11-10 13:09:05.135+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
11-10 13:09:05.135+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
11-10 13:09:05.135+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
11-10 13:09:05.135+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
11-10 13:09:05.135+0200 E/STARTER (  720): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
11-10 13:09:05.135+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
11-10 13:09:05.135+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
11-10 13:09:05.140+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1349500
11-10 13:09:05.345+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:09:05.345+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:09:05.345+0200 W/STARTER (  720): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
11-10 13:09:05.345+0200 W/STARTER (  720): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
11-10 13:09:05.345+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1349710
11-10 13:09:05.355+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
11-10 13:09:05.355+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
11-10 13:09:05.360+0200 E/STARTER (  720): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
11-10 13:09:05.360+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
11-10 13:09:05.365+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:09:05.365+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 720
11-10 13:09:05.370+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 765
11-10 13:09:05.370+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(15), pid(765), cmd(0)
11-10 13:09:05.375+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(282) > request cmd(0) result(765)
11-10 13:09:05.375+0200 E/AUL     (  720): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:09:05.375+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESET State: RUNNING
11-10 13:09:05.375+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_reset(245) > app_appcore_reset
11-10 13:09:05.375+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:09:05.375+0200 W/W_HOME  (  765): main.c: _app_control(1704) > Service value : powerkey
11-10 13:09:05.375+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
11-10 13:09:05.375+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
11-10 13:09:05.375+0200 W/W_HOME  (  765): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
11-10 13:09:05.375+0200 E/W_HOME  (  765): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
11-10 13:09:05.375+0200 W/W_HOME  (  765): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-10 13:09:05.375+0200 W/W_HOME  (  765): move.c: move_move_to_apps(220) > move to apps
11-10 13:09:05.380+0200 W/W_HOME  (  765): move.c: _create_fake_apps(823) > fake image position : 432
11-10 13:09:05.380+0200 W/W_HOME  (  765): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
11-10 13:09:05.380+0200 W/W_HOME  (  765): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
11-10 13:09:05.380+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:05.380+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:05.380+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
11-10 13:09:05.380+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
11-10 13:09:05.380+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
11-10 13:09:05.385+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:05.385+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:05.385+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:05.385+0200 W/W_HOME  (  765): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
11-10 13:09:05.385+0200 W/W_HOME  (  765): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
11-10 13:09:05.385+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
11-10 13:09:05.385+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
11-10 13:09:05.540+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:09:05.540+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-10 13:09:05.690+0200 W/W_HOME  (  765): move.c: _transit_del_cb(115) > transit end
11-10 13:09:05.690+0200 W/W_HOME  (  765): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
11-10 13:09:05.690+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:09:05.705+0200 W/W_HOME  (  765): move.c: _scroller_up_done(515) > up signal done
11-10 13:09:05.710+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(583) > apps,show
11-10 13:09:05.710+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
11-10 13:09:05.710+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:05.715+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:05.715+0200 W/W_HOME  (  765): main.c: home_pause(766) > clock/widget paused
11-10 13:09:05.715+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_pause(554) > 
11-10 13:09:05.715+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:05.715+0200 W/W_HOME  (  765): noti_broker.c: _apptray_visibility_cb(789) > apps,show
11-10 13:09:05.720+0200 W/W_HOME  (  765): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
11-10 13:09:05.720+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
11-10 13:09:05.720+0200 I/wnotib  (  765): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
11-10 13:09:05.720+0200 E/APPS    (  765): apps_main.c: apps_main_resume(636) >  resumed already
11-10 13:09:05.730+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_pause(1028) > widget_pause
11-10 13:09:05.740+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:09:05.740+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:05.745+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:05.745+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:09:05.750+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:09:05.770+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1350126 button=1
11-10 13:09:05.770+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:09:05.770+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:09:05.770+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,118,216,124]
11-10 13:09:05.785+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:09:05.785+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:09:05.790+0200 W/APPS    (  765): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-10 13:09:05.790+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:05.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:05.795+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:09:05.800+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:09:05.810+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1350174 button=1
11-10 13:09:05.810+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:09:05.815+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:05.815+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:05.815+0200 E/APPS    (  765): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
11-10 13:09:05.815+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:09:05.825+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:09:05.830+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:05.835+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:05.840+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:09:05.850+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:09:05.850+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:05.850+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:05.855+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:05.855+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:09:05.855+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:09:05.855+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:09:06.370+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:09:06.370+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-10 13:09:06.610+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1350977 button=1
11-10 13:09:06.610+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:09:06.615+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:09:06.615+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-10 13:09:06.625+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:09:06.670+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1351038 button=1
11-10 13:09:06.675+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-10 13:09:06.675+0200 E/APPS    (  765): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-10 13:09:06.675+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-10 13:09:06.675+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:09:06.680+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:09:06.680+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 765
11-10 13:09:06.680+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
11-10 13:09:06.690+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:09:06.690+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:09:06.690+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:09:06.695+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-10 13:09:06.695+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:09:06.730+0200 I/efl-extension( 5977): efl_extension.c: eext_mod_init(40) > Init
11-10 13:09:06.730+0200 I/CAPI_APPFW_APPLICATION( 5977): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:09:06.735+0200 I/CAPI_APPFW_APPLICATION( 5977): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:09:06.795+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:09:06.795+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(282) > request cmd(0) result(5977)
11-10 13:09:06.795+0200 E/W_HOME  (  765): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
11-10 13:09:06.835+0200 I/Bluetooth( 5977): [bt_initialize] success.
11-10 13:09:06.865+0200 I/Bluetooth( 5977): [bt_adapter_get_state] success.
11-10 13:09:06.940+0200 E/EFL     ( 5977): ecore_evas<5977> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:09:07.250+0200 I/APP_CORE( 5977): appcore-efl.c: __do_app(429) > [APP 5977] Event: RESET State: CREATED
11-10 13:09:07.250+0200 I/CAPI_APPFW_APPLICATION( 5977): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:09:07.295+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:09:07.295+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.295+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.295+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.320+0200 I/APP_CORE( 5977): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:09:07.335+0200 I/APP_CORE( 5977): appcore-efl.c: __do_app(474) > [APP 5977] Initial Launching, call the resume_cb
11-10 13:09:07.335+0200 I/CAPI_APPFW_APPLICATION( 5977): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:09:07.365+0200 W/APP_CORE( 5977): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
11-10 13:09:07.460+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:09:07.460+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:09:07.460+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.460+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:09:07.475+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:09:07.475+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:09:07.475+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:09:07.475+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:09:07.475+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.475+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.475+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:09:07.500+0200 I/APP_CORE( 5977): appcore-efl.c: __do_app(429) > [APP 5977] Event: RESUME State: RUNNING
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:09:07.510+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:07.520+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:09:07.520+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:09:07.525+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:09:07.525+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:09:07.525+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:09:07.605+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:07.605+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:07.605+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:07.640+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:09:07.685+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:07.685+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:07.690+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:07.805+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:09:07.910+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.336
11-10 13:09:07.925+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:09:07.935+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5977
11-10 13:09:07.935+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:09:07.970+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:09:07.980+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5977
11-10 13:09:07.980+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:09:08.025+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:09:08.190+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:09:08.190+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:09:08.225+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:08.230+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:09:08.230+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:09:08.295+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:09:08.310+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:09:08.310+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:09:08.310+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:09:08.310+0200 E/EFL     ( 6075): elementary<6075> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:09:08.335+0200 E/EFL     ( 6075): elementary<6075> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:09:08.340+0200 E/EFL     ( 6075): elementary<6075> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:09:08.340+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:09:08.380+0200 E/EFL     ( 6075): elementary<6075> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:09:08.395+0200 E/EFL     ( 6075): elementary<6075> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:09:08.400+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:09:08.400+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:09:08.400+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:09:08.400+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:09:08.400+0200 E/EFL     ( 6075): elementary<6075> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:09:08.400+0200 I/AUL_PAD ( 6075): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:09:09.230+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:10.230+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:11.230+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:12.230+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:12.545+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:09:13.230+0200 I/INFO_TAG( 5977): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:09:14.235+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:09:14.295+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:09:14.300+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:09:14.670+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:15.850+0200 E/EFL     ( 5977): ecore_x<5977> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1360212 button=1
11-10 13:09:15.915+0200 E/EFL     ( 5977): ecore_x<5977> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1360282 button=1
11-10 13:09:16.090+0200 E/RECORDING_TAG( 5977): sensor_listener_unset_event_cb error: -38010874
11-10 13:09:16.100+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:09:16.100+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:09:16.240+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 HEART RATE : 64
11-10 13:09:16.255+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 TAB VALUE : 64
11-10 13:09:16.285+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:16.680+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
11-10 13:09:17.255+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 HEART RATE : 62
11-10 13:09:17.270+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 TAB VALUE : 62
11-10 13:09:18.250+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 HEART RATE : 62
11-10 13:09:18.280+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 TAB VALUE : 62
11-10 13:09:19.235+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 HEART RATE : 63
11-10 13:09:19.250+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 TAB VALUE : 63
11-10 13:09:20.255+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 HEART RATE : 64
11-10 13:09:20.275+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 TAB VALUE : 64
11-10 13:09:21.240+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 HEART RATE : 65
11-10 13:09:21.260+0200 I/INFO_TAG( 5977): SENSOR_EVENT2 TAB VALUE : 65
11-10 13:09:21.410+0200 E/EFL     ( 5977): ecore_x<5977> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1365775 button=1
11-10 13:09:21.505+0200 E/EFL     ( 5977): ecore_x<5977> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1365869 button=1
11-10 13:09:21.525+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:09:21.595+0200 I/Bluetooth( 5977): [bt_socket_create_rfcomm] success.
11-10 13:09:21.705+0200 I/BluetoothServer( 5977): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:09:21.735+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:09:22.095+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:22.450+0200 I/BluetoothServer( 5977): Callback: Connected.
11-10 13:09:22.450+0200 I/BluetoothServer( 5977): Callback: Socket of connection - 27.
11-10 13:09:22.450+0200 I/BluetoothServer( 5977): Callback: Role of connection - 1.
11-10 13:09:22.455+0200 I/BluetoothServer( 5977): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:09:22.455+0200 I/BluetoothServer( 5977): Sent: '0CÞC662,000000 62,000000 63,000000 64,000000 65,000000 0,000000 '
11-10 13:09:22.525+0200 E/Bluetooth( 5977): [bt_socket_send_data] unknown error code : 64.
11-10 13:09:22.525+0200 E/Bluetooth( 5977): [bt_socket_send_data] unknown error code : 3.
11-10 13:09:22.525+0200 I/BluetoothServer( 5977): All data sent
11-10 13:09:22.530+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:09:22.550+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:09:22.675+0200 I/BluetoothServer( 5977): Callback: Disconnected.
11-10 13:09:22.675+0200 I/BluetoothServer( 5977): Callback: Socket of disconnection - 27.
11-10 13:09:22.680+0200 I/BluetoothServer( 5977): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:09:22.910+0200 E/EFL     ( 5977): elementary<5977> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:09:24.415+0200 E/EFL     ( 5977): ecore_x<5977> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1368782 button=1
11-10 13:09:24.485+0200 E/EFL     ( 5977): ecore_x<5977> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1368852 button=1
11-10 13:09:24.660+0200 W/CRASH_MANAGER( 6041): worker.c: worker_job(1205) > 1105977646174151031216
