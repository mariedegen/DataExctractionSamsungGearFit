S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 5501
Date: 2017-11-10 13:07:43+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5501, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x14049c00, r3   = 0x14049c00
r4   = 0x43328a98, r5   = 0x432de0e0
r6   = 0x4153bac0, r7   = 0xbe96f2a0
r8   = 0x00000000, r9   = 0x43311060
r10  = 0x4331a108, fp   = 0x00000001
ip   = 0x40088a5c, sp   = 0xbe96f278
lr   = 0x41745b69, pc   = 0x41744b6a
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     85652 KB
Buffers:     31004 KB
Cached:     157492 KB
VmPeak:      97696 KB
VmSize:      96220 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19304 KB
VmRSS:       19300 KB
VmData:      40348 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25016 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5501 TID = 5501
5501 5535 5599 

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
417a0000 417c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417ca000 41804000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4180d000 41826000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4182e000 41833000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4183b000 41865000 r-xp /usr/lib/libsensor.so.1.9.6
4186e000 41926000 r-xp /usr/lib/libcairo.so.2.11200.14
41931000 41934000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4193c000 41942000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4194b000 41953000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4195b000 41965000 r-xp /usr/lib/libsensord-shared.so
4196e000 4197c000 r-xp /usr/lib/libGLESv2.so.2.0
41985000 41986000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4198f000 41995000 r-xp /usr/lib/libxcb-render.so.0.0.0
4199d000 419a0000 r-xp /usr/lib/libEGL.so.1.4
419a8000 419b5000 r-xp /usr/lib/libail.so.0.1.0
419be000 41afb000 r-xp /usr/lib/libicui18n.so.51.1
41b0b000 41bef000 r-xp /usr/lib/libicuuc.so.51.1
4318d000 431a9000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431b2000 431b9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431c2000 431c4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431cc000 431d3000 r-xp /usr/lib/libminizip.so.1.0.0
431db000 432a5000 r-xp /usr/lib/libCOREGL.so.4.0
435b8000 43db7000 rw-p [stack:5535]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43fb9000 447b8000 rw-p [stack:5599]
45a28000 45a29000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a44000 45a4b000 r-xp /usr/lib/libfeedback.so.0.1.4
45a54000 45a55000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a5d000 45a5f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a67000 45a71000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a79000 45a80000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a88000 45a9e000 r-xp /usr/lib/libmmfsound.so.0.1.0
45ab0000 45ab5000 r-xp /usr/lib/libmmfsession.so.0.0.0
45abd000 45ac7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45ad3000 45ad7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45ae0000 45af5000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45afd000 45b5e000 r-xp /usr/lib/libasound.so.2.0.0
45b68000 45b6b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b73000 45bab000 r-xp /usr/lib/libpulse.so.0.16.2
45bac000 45bdd000 r-xp /usr/lib/libmdm.so.1.1.86
45be5000 45bea000 r-xp /usr/lib/libjson.so.0.0.1
45bf2000 45c3a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c3b000 45c82000 r-xp /usr/lib/libsndfile.so.1.0.26
45c8e000 45c96000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c97000 45cb9000 r-xp /usr/lib/libvorbis.so.0.4.3
45cc1000 45cc5000 r-xp /usr/lib/libogg.so.0.7.1
be94f000 be970000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5501)
Call Stack Count: 18
 0: app_create + 0x5d (0x41744b6a) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b6a
 1: clicked_redo_app + 0x2c (0x41744d1f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d1f
 2: evas_object_smart_callback_call + 0x88 (0x4022e725) [/usr/lib/libevas.so.1] + 0x35725
 3: (0x40360ad9) [/usr/lib/libedje.so.1] + 0x45ad9
 4: (0x40364ac1) [/usr/lib/libedje.so.1] + 0x49ac1
 5: (0x40361431) [/usr/lib/libedje.so.1] + 0x46431
 6: (0x403617e3) [/usr/lib/libedje.so.1] + 0x467e3
 7: (0x4036191d) [/usr/lib/libedje.so.1] + 0x4691d
 8: (0x402f83f5) [/usr/lib/libecore.so.1] + 0xb3f5
 9: (0x402f5e53) [/usr/lib/libecore.so.1] + 0x8e53
10: (0x402f946b) [/usr/lib/libecore.so.1] + 0xc46b
11: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
13: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x66 (0x41744c43) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c43
15: create_base_gui + 0x46 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
16: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
17: clicked_redo_app + 0x1d (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
ged_ind(231) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:07:17.765+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1779]   bundle_add_str() .. [0xffffffea][0m
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:07:17.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:17.785+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:17.790+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:17.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:17.805+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:07:17.805+0200 I/TIZEN_N_SOUND_MANAGER( 1779): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-10 13:07:17.805+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:07:17.810+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:07:17.810+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:07:17.825+0200 E/TIZEN_N_SOUND_MANAGER( 1779): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-10 13:07:17.825+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1779]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:07:17.825+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:17.830+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:17.975+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
11-10 13:07:17.975+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
11-10 13:07:17.980+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1242339
11-10 13:07:17.980+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
11-10 13:07:17.980+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
11-10 13:07:17.980+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
11-10 13:07:17.980+0200 E/STARTER (  720): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
11-10 13:07:17.980+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
11-10 13:07:17.980+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
11-10 13:07:18.000+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:07:18.175+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:07:18.175+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:07:18.180+0200 W/STARTER (  720): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
11-10 13:07:18.180+0200 W/STARTER (  720): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
11-10 13:07:18.190+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
11-10 13:07:18.195+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
11-10 13:07:18.195+0200 E/STARTER (  720): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
11-10 13:07:18.195+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
11-10 13:07:18.200+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:07:18.200+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 720
11-10 13:07:18.210+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 765
11-10 13:07:18.215+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1242540
11-10 13:07:18.215+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:07:18.215+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(765), cmd(0)
11-10 13:07:18.215+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(282) > request cmd(0) result(765)
11-10 13:07:18.215+0200 E/AUL     (  720): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:07:18.215+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESET State: RUNNING
11-10 13:07:18.215+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_reset(245) > app_appcore_reset
11-10 13:07:18.215+0200 W/W_HOME  (  765): main.c: _app_control(1704) > Service value : powerkey
11-10 13:07:18.220+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
11-10 13:07:18.220+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
11-10 13:07:18.220+0200 W/W_HOME  (  765): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
11-10 13:07:18.220+0200 E/W_HOME  (  765): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
11-10 13:07:18.220+0200 W/W_HOME  (  765): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-10 13:07:18.220+0200 W/W_HOME  (  765): move.c: move_move_to_apps(220) > move to apps
11-10 13:07:18.220+0200 W/W_HOME  (  765): move.c: _create_fake_apps(823) > fake image position : 432
11-10 13:07:18.220+0200 W/W_HOME  (  765): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
11-10 13:07:18.220+0200 W/W_HOME  (  765): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
11-10 13:07:18.220+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:18.220+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:18.225+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
11-10 13:07:18.225+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
11-10 13:07:18.225+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
11-10 13:07:18.225+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:18.225+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:18.225+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:18.225+0200 W/W_HOME  (  765): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
11-10 13:07:18.225+0200 W/W_HOME  (  765): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
11-10 13:07:18.225+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
11-10 13:07:18.225+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
11-10 13:07:18.545+0200 W/W_HOME  (  765): move.c: _transit_del_cb(115) > transit end
11-10 13:07:18.545+0200 W/W_HOME  (  765): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
11-10 13:07:18.545+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:18.555+0200 W/W_HOME  (  765): move.c: _scroller_up_done(515) > up signal done
11-10 13:07:18.560+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(583) > apps,show
11-10 13:07:18.560+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
11-10 13:07:18.560+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:18.565+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:18.565+0200 W/W_HOME  (  765): main.c: home_pause(766) > clock/widget paused
11-10 13:07:18.565+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_pause(554) > 
11-10 13:07:18.565+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:18.565+0200 W/W_HOME  (  765): noti_broker.c: _apptray_visibility_cb(789) > apps,show
11-10 13:07:18.565+0200 W/W_HOME  (  765): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
11-10 13:07:18.565+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
11-10 13:07:18.565+0200 I/wnotib  (  765): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
11-10 13:07:18.570+0200 E/APPS    (  765): apps_main.c: apps_main_resume(636) >  resumed already
11-10 13:07:18.580+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_pause(1028) > widget_pause
11-10 13:07:18.590+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:18.595+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:18.595+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:07:18.595+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:07:18.605+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:18.615+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:18.615+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:07:18.615+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:07:18.625+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:18.625+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:18.625+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:07:18.625+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:07:18.635+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:18.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:18.640+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:07:18.645+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:18.645+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:18.650+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:07:18.650+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:07:18.650+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:07:19.185+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1243550 button=1
11-10 13:07:19.185+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.185+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:07:19.185+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
11-10 13:07:19.195+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.205+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.210+0200 W/APPS    (  765): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-10 13:07:19.210+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:07:19.210+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-10 13:07:19.220+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.230+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.245+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.255+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.270+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.280+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.295+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1243659 button=1
11-10 13:07:19.295+0200 E/APPS    (  765): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
11-10 13:07:19.945+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1244308 button=1
11-10 13:07:19.945+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:07:19.945+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:07:19.945+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-10 13:07:20.015+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1244381 button=1
11-10 13:07:20.015+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-10 13:07:20.015+0200 E/APPS    (  765): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-10 13:07:20.015+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-10 13:07:20.020+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:07:20.020+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:07:20.020+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 765
11-10 13:07:20.020+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
11-10 13:07:20.035+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:07:20.035+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-10 13:07:20.035+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:07:20.035+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:07:20.035+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:07:20.070+0200 I/efl-extension( 5501): efl_extension.c: eext_mod_init(40) > Init
11-10 13:07:20.070+0200 I/CAPI_APPFW_APPLICATION( 5501): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:07:20.075+0200 I/CAPI_APPFW_APPLICATION( 5501): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:07:20.135+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(282) > request cmd(0) result(5501)
11-10 13:07:20.135+0200 E/W_HOME  (  765): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
11-10 13:07:20.135+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:07:20.170+0200 I/Bluetooth( 5501): [bt_initialize] success.
11-10 13:07:20.200+0200 I/Bluetooth( 5501): [bt_adapter_get_state] success.
11-10 13:07:20.265+0200 E/EFL     ( 5501): ecore_evas<5501> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:07:20.540+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:07:20.540+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.540+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.540+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.545+0200 I/APP_CORE( 5501): appcore-efl.c: __do_app(429) > [APP 5501] Event: RESET State: CREATED
11-10 13:07:20.545+0200 I/CAPI_APPFW_APPLICATION( 5501): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:07:20.595+0200 I/APP_CORE( 5501): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:07:20.600+0200 I/APP_CORE( 5501): appcore-efl.c: __do_app(474) > [APP 5501] Initial Launching, call the resume_cb
11-10 13:07:20.600+0200 I/CAPI_APPFW_APPLICATION( 5501): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:07:20.605+0200 W/APP_CORE( 5501): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.665+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:07:20.665+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:07:20.665+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:07:20.665+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:07:20.670+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:20.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:20.675+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:07:20.675+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:07:20.685+0200 I/APP_CORE( 5501): appcore-efl.c: __do_app(429) > [APP 5501] Event: RESUME State: RUNNING
11-10 13:07:20.770+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:20.770+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:20.770+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:20.790+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:07:20.830+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1245184 button=1
11-10 13:07:20.880+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1245244 button=1
11-10 13:07:20.950+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:20.950+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:20.955+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:21.000+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:07:21.175+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:07:21.230+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.307
11-10 13:07:21.260+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:07:21.270+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5501
11-10 13:07:21.270+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:07:21.305+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:07:21.315+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5501
11-10 13:07:21.315+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:07:21.495+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:21.505+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:07:21.505+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:07:21.540+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:07:21.540+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:07:21.605+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:07:21.605+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:07:21.610+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:07:21.610+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:07:21.610+0200 E/EFL     ( 5545): elementary<5545> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:07:21.630+0200 E/EFL     ( 5545): elementary<5545> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:07:21.635+0200 E/EFL     ( 5545): elementary<5545> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:07:21.635+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:07:21.690+0200 E/EFL     ( 5545): elementary<5545> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:07:21.700+0200 E/EFL     ( 5545): elementary<5545> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:07:21.700+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:07:21.705+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:07:21.705+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:07:21.705+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:07:21.705+0200 E/EFL     ( 5545): elementary<5545> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:07:21.705+0200 I/AUL_PAD ( 5545): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:07:22.495+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:23.495+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:24.500+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:25.500+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:25.680+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:07:26.500+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:27.500+0200 I/INFO_TAG( 5501): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:07:28.510+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:07:28.575+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:07:28.930+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:29.415+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:07:31.330+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1255695 button=1
11-10 13:07:31.355+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1255718 button=1
11-10 13:07:31.525+0200 E/RECORDING_TAG( 5501): sensor_listener_unset_event_cb error: -38010874
11-10 13:07:31.530+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:07:31.535+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:07:31.710+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:32.520+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 HEART RATE : 65
11-10 13:07:32.560+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 TAB VALUE : 65
11-10 13:07:33.520+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 HEART RATE : 64
11-10 13:07:33.545+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 TAB VALUE : 64
11-10 13:07:34.520+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 HEART RATE : 66
11-10 13:07:34.550+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 TAB VALUE : 66
11-10 13:07:35.515+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 HEART RATE : 67
11-10 13:07:35.535+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 TAB VALUE : 67
11-10 13:07:36.485+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1260853 button=1
11-10 13:07:36.510+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 HEART RATE : 68
11-10 13:07:36.515+0200 I/INFO_TAG( 5501): SENSOR_EVENT2 TAB VALUE : 68
11-10 13:07:36.515+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1260874 button=1
11-10 13:07:36.530+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:07:36.605+0200 I/Bluetooth( 5501): [bt_socket_create_rfcomm] success.
11-10 13:07:36.705+0200 I/BluetoothServer( 5501): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:07:36.705+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:07:36.870+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:38.620+0200 I/BluetoothServer( 5501): Callback: Connected.
11-10 13:07:38.620+0200 I/BluetoothServer( 5501): Callback: Socket of connection - 27.
11-10 13:07:38.620+0200 I/BluetoothServer( 5501): Callback: Role of connection - 1.
11-10 13:07:38.620+0200 I/BluetoothServer( 5501): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:07:38.620+0200 I/BluetoothServer( 5501): Sent: 'ػ5C664,000000 66,000000 67,000000 68,000000 0,000000 '
11-10 13:07:38.695+0200 E/Bluetooth( 5501): [bt_socket_send_data] unknown error code : 54.
11-10 13:07:38.695+0200 E/Bluetooth( 5501): [bt_socket_send_data] unknown error code : 3.
11-10 13:07:38.695+0200 I/BluetoothServer( 5501): All data sent
11-10 13:07:38.695+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:07:38.725+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:07:38.815+0200 I/BluetoothServer( 5501): Callback: Disconnected.
11-10 13:07:38.815+0200 I/BluetoothServer( 5501): Callback: Socket of disconnection - 27.
11-10 13:07:38.815+0200 I/BluetoothServer( 5501): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:07:39.085+0200 E/EFL     ( 5501): elementary<5501> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:42.405+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:07:43.695+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1268061 button=1
11-10 13:07:43.875+0200 E/EFL     ( 5501): ecore_x<5501> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1268241 button=1
11-10 13:07:43.890+0200 I/Bluetooth( 5501): [bt_deinitialize] success.
11-10 13:07:43.905+0200 I/Bluetooth( 5501): [bt_initialize] success.
11-10 13:07:43.935+0200 I/Bluetooth( 5501): [bt_adapter_get_state] success.
11-10 13:07:44.085+0200 W/CRASH_MANAGER( 5514): worker.c: worker_job(1205) > 1105501646174151031206
