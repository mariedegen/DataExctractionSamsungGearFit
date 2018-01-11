S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 1542
Date: 2017-12-09 11:12:39+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1542, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0x41744d59
r4   = 0xbe9d0504, r5   = 0x41541980
r6   = 0x00000249, r7   = 0xbe9d0440
r8   = 0xbe9d04d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x41757588, sp   = 0xbe9d0428
lr   = 0x41744d75, pc   = 0x417462a8
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     97256 KB
Buffers:     25484 KB
Cached:     153164 KB
VmPeak:      98476 KB
VmSize:      97368 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20072 KB
VmRSS:       20068 KB
VmData:      41404 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25044 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1542 TID = 1542
1542 1614 1621 1622 

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
41793000 41798000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a0000 417a4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417ad000 417ce000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d7000 41811000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4181a000 41833000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4183b000 41840000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41848000 41872000 r-xp /usr/lib/libsensor.so.1.9.6
4187b000 41933000 r-xp /usr/lib/libcairo.so.2.11200.14
4193e000 41941000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41949000 4194f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41958000 41960000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41968000 41972000 r-xp /usr/lib/libsensord-shared.so
4197b000 41989000 r-xp /usr/lib/libGLESv2.so.2.0
41992000 41993000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4199c000 419a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
419aa000 419ad000 r-xp /usr/lib/libEGL.so.1.4
419b5000 419c2000 r-xp /usr/lib/libail.so.0.1.0
419cb000 41b08000 r-xp /usr/lib/libicui18n.so.51.1
41b18000 41bfc000 r-xp /usr/lib/libicuuc.so.51.1
4319a000 431b6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431bf000 431c6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431cf000 431d1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431d9000 431e0000 r-xp /usr/lib/libminizip.so.1.0.0
431e8000 432b2000 r-xp /usr/lib/libCOREGL.so.4.0
435c5000 43dc4000 rw-p [stack:1614]
43dc4000 43dcf000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dd8000 43ddd000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43deb000 43df3000 r-xp /usr/lib/libdrm.so.2.4.0
43f00000 43f07000 r-xp /usr/lib/libtbm.so.1.0.0
43f0f000 43f11000 r-xp /usr/lib/libdri2.so.0.0.0
43fb4000 43fb5000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
440be000 448bd000 rw-p [stack:1621]
448be000 450bd000 rw-p [stack:1622]
459d1000 459d2000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
459da000 459dd000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
459ed000 459f4000 r-xp /usr/lib/libfeedback.so.0.1.4
459fd000 459fe000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a06000 45a08000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a10000 45a1a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a22000 45a29000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a31000 45a47000 r-xp /usr/lib/libmmfsound.so.0.1.0
45a59000 45a5e000 r-xp /usr/lib/libmmfsession.so.0.0.0
45a66000 45a70000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45a7c000 45a80000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45a89000 45a9e000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45aa6000 45b07000 r-xp /usr/lib/libasound.so.2.0.0
45b11000 45b14000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b1c000 45b54000 r-xp /usr/lib/libpulse.so.0.16.2
45b55000 45b86000 r-xp /usr/lib/libmdm.so.1.1.86
45b8e000 45b93000 r-xp /usr/lib/libjson.so.0.0.1
45b9b000 45be3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45be4000 45c2b000 r-xp /usr/lib/libsndfile.so.1.0.26
45c37000 45c3f000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c40000 45c62000 r-xp /usr/lib/libvorbis.so.0.4.3
45c6a000 45c6e000 r-xp /usr/lib/libogg.so.0.7.1
45ed2000 45ed3000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
be9b0000 be9d1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1542)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x417462a8) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x32a8
 1: app_terminate + 0x1c (0x41744d75) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d75
 2: (0x41540af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41744d07) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d07
 6: bluetooth_screen + 0xda (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: main + 0x6f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
sagePortIpcServer::Stop
12-09 11:12:33.735+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1078]   [MUSIC_PLAYER_EVENT][0m
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:33.740+0200 W/W_HOME  (  779): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
12-09 11:12:33.740+0200 E/W_HOME  (  779): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:33.740+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:33.740+0200 W/W_HOME  (  779): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
12-09 11:12:33.740+0200 E/W_HOME  (  779): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 11:12:33.755+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 HEART RATE : 68
12-09 11:12:33.755+0200 I/TIZEN_N_SOUND_MANAGER( 1078): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
12-09 11:12:33.755+0200 E/TIZEN_N_SOUND_MANAGER( 1078): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
12-09 11:12:33.755+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1078]   sound_manager_get_volume() .. [0xfe6a0001][0m
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 11:12:33.755+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:33.760+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:33.770+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 TAB VALUE : 68
12-09 11:12:34.025+0200 W/W_HOME  (  779): move.c: _transit_del_cb(115) > transit end
12-09 11:12:34.025+0200 W/W_HOME  (  779): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
12-09 11:12:34.025+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:12:34.035+0200 W/W_HOME  (  779): move.c: _scroller_up_done(515) > up signal done
12-09 11:12:34.040+0200 W/W_HOME  (  779): event_manager.c: _apptray_visibility_cb(583) > apps,show
12-09 11:12:34.045+0200 W/W_HOME  (  779): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
12-09 11:12:34.045+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:34.050+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:34.050+0200 W/W_HOME  (  779): main.c: home_pause(766) > clock/widget paused
12-09 11:12:34.050+0200 W/W_HOME  (  779): clock_indicator.c: clock_indicator_pause(554) > 
12-09 11:12:34.050+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:34.050+0200 W/W_HOME  (  779): noti_broker.c: _apptray_visibility_cb(789) > apps,show
12-09 11:12:34.055+0200 W/W_HOME  (  779): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
12-09 11:12:34.055+0200 I/wnotib  (  779): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
12-09 11:12:34.055+0200 I/wnotib  (  779): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
12-09 11:12:34.055+0200 E/APPS    (  779): apps_main.c: apps_main_resume(636) >  resumed already
12-09 11:12:34.070+0200 W/WATCH_CORE(  812): appcore-watch.c: __widget_pause(1028) > widget_pause
12-09 11:12:34.075+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:34.075+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:34.080+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:12:34.080+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:12:34.085+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:34.085+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:34.090+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:12:34.090+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:12:34.100+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:34.100+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:34.100+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:12:34.105+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:12:34.105+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:34.110+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:34.110+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:12:34.110+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:12:34.115+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:34.115+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:34.120+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:34.120+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:12:34.125+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:12:34.125+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:34.125+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:34.125+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:12:34.125+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:12:34.125+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-09 11:12:34.335+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=201702 button=1
12-09 11:12:34.335+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.335+0200 E/W_HOME  (  779): move.c: _mouse_down_cb(384) > apps move is not allowed
12-09 11:12:34.335+0200 W/APPS    (  779): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
12-09 11:12:34.360+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.370+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.370+0200 W/APPS    (  779): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
12-09 11:12:34.385+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.395+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.405+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.420+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.430+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:34.445+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=201810 button=1
12-09 11:12:34.445+0200 E/APPS    (  779): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
12-09 11:12:34.715+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:12:34.715+0200 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
12-09 11:12:34.750+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 HEART RATE : 69
12-09 11:12:34.755+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:12:35.045+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=202412 button=1
12-09 11:12:35.050+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:35.050+0200 E/W_HOME  (  779): move.c: _mouse_down_cb(384) > apps move is not allowed
12-09 11:12:35.050+0200 W/APPS    (  779): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
12-09 11:12:35.070+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:12:35.080+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=202446 button=1
12-09 11:12:35.080+0200 W/APPS    (  779): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
12-09 11:12:35.085+0200 E/APPS    (  779): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
12-09 11:12:35.085+0200 W/APPS    (  779): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
12-09 11:12:35.085+0200 W/AUL     (  779): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
12-09 11:12:35.085+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 0
12-09 11:12:35.085+0200 W/AUL_AMD (  530): amd_launch.c: _start_app(1710) > caller pid : 779
12-09 11:12:35.085+0200 I/AUL_AMD (  530): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
12-09 11:12:35.095+0200 W/AUL_AMD (  530): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 1542
12-09 11:12:35.095+0200 W/AUL_AMD (  530): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(1542), cmd(0)
12-09 11:12:35.095+0200 W/AUL     (  779): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1542)
12-09 11:12:35.095+0200 E/W_HOME  (  779): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
12-09 11:12:35.100+0200 E/AUL     (  530): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:12:35.105+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(429) > [APP 1542] Event: RESET State: PAUSED
12-09 11:12:35.105+0200 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
12-09 11:12:35.105+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
12-09 11:12:35.105+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(481) > [APP 1542] App already running, raise the window
12-09 11:12:35.110+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(485) > [APP 1542] Call the resume_cb
12-09 11:12:35.110+0200 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:12:35.135+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
12-09 11:12:35.135+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.135+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.140+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _state_control(344) > appcore paused manually
12-09 11:12:35.170+0200 W/W_HOME  (  779): main.c: home_appcore_pause(723) > Home Appcore Paused
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.170+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:35.175+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(429) > [APP 1542] Event: RESUME State: RUNNING
12-09 11:12:35.175+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:35.175+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:35.175+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:12:35.180+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:12:35.185+0200 E/CAPI_APPFW_APP_CONTROL( 1078): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 11:12:35.185+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
12-09 11:12:35.190+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: PAUSE State: RUNNING
12-09 11:12:35.190+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 11:12:35.190+0200 W/W_HOME  (  779): main.c: _appcore_pause_cb(696) > appcore pause
12-09 11:12:35.190+0200 E/W_HOME  (  779): main.c: _pause_cb(674) > paused already
12-09 11:12:35.190+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1078]   [com.samsung.w-home]register msg port [false][0m
12-09 11:12:35.240+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
12-09 11:12:35.515+0200 E/AUL     (  530): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:12:35.690+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: MEM_FLUSH State: PAUSED
12-09 11:12:35.765+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 HEART RATE : 67
12-09 11:12:35.775+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:12:36.760+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 HEART RATE : 66
12-09 11:12:36.790+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 TAB VALUE : 66
12-09 11:12:37.260+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-09 11:12:37.360+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:12:37.360+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:12:37.360+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:12:37.455+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:12:37.460+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:12:37.460+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:12:37.460+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:12:37.460+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:12:37.460+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:12:37.460+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:37.460+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
12-09 11:12:37.460+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:12:37.470+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:12:37.470+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:12:37.470+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:12:37.695+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:12:37.765+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 HEART RATE : 64
12-09 11:12:37.795+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:12:37.810+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
12-09 11:12:37.810+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:12:37.815+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:12:37.815+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:12:37.815+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:12:58), repeat(1), interval(20), type(-1073741822)
12-09 11:12:37.830+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(429) > [APP 1542] Event: PAUSE State: RUNNING
12-09 11:12:37.830+0200 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:12:37.845+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:12:37.900+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:12:37.910+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1544087058, next duetime: 1512810778
12-09 11:12:37.910+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1544087058)
12-09 11:12:37.910+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512810778)
12-09 11:12:37.910+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:12:37.910+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:12:58 (UTC).
12-09 11:12:37.910+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:12:37.935+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:12:38.250+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:12:38.250+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:12:38.255+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:12:38.260+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-09 11:12:38.260+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:12:38.325+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:12:38.325+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:12:38.325+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:12:38.325+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:12:38.325+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:12:38.325+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:12:38.325+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:12:38.325+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:883
12-09 11:12:38.325+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:12:38.325+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:12:38.325+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:38.330+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [883]ms
12-09 11:12:38.330+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:12:38.350+0200 I/APP_CORE( 1542): appcore-efl.c: __do_app(429) > [APP 1542] Event: RESUME State: PAUSED
12-09 11:12:38.360+0200 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:12:38.375+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:12:38.375+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1544087058)
12-09 11:12:38.375+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:12:38.375+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:12:38.375+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:12:38.375+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1544087058] is removed.
12-09 11:12:38.405+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:12:38.405+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:12:38.405+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:12:38.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:12:38.460+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:12:38.525+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:12:38.530+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-09 11:12:38.530+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:12:38.530+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:12:38.545+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:12:38.545+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:12:38.560+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
12-09 11:12:38.560+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:12:38.765+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 HEART RATE : 65
12-09 11:12:38.780+0200 I/INFO_TAG( 1542): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:12:39.095+0200 E/EFL     ( 1542): ecore_x<1542> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=206459 button=1
12-09 11:12:39.110+0200 E/EFL     ( 1542): ecore_x<1542> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=206467 button=1
12-09 11:12:39.110+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 22
12-09 11:12:39.110+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(916) > app status : 4
12-09 11:12:39.165+0200 E/APP_CORE( 1542): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-09 11:12:39.165+0200 I/APP_CORE( 1542): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-09 11:12:39.165+0200 I/APP_CORE( 1542): appcore-efl.c: __after_loop(1089) > [APP 1542] PAUSE before termination
12-09 11:12:39.165+0200 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:12:39.165+0200 I/CAPI_APPFW_APPLICATION( 1542): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-09 11:12:39.570+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1542 pgid = 1542
12-09 11:12:39.700+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:12:39.700+0200 W/AUL_AMD (  530): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-09 11:12:39.795+0200 I/MALI    (  779): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
12-09 11:12:39.885+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-09 11:12:39.925+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
12-09 11:12:39.925+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.925+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.925+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.955+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
12-09 11:12:39.955+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
12-09 11:12:39.955+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.955+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
12-09 11:12:39.955+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: RESUME State: PAUSED
12-09 11:12:39.955+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 11:12:39.955+0200 W/W_HOME  (  779): main.c: _appcore_resume_cb(687) > appcore resume
12-09 11:12:39.955+0200 W/W_HOME  (  779): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
12-09 11:12:39.960+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.960+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.960+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:12:39.960+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
12-09 11:12:39.965+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
12-09 11:12:39.965+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
12-09 11:12:39.965+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:12:40.050+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
12-09 11:12:40.060+0200 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1542
12-09 11:12:40.075+0200 E/RESOURCED(  532): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.160
12-09 11:12:40.140+0200 W/CRASH_MANAGER( 1762): worker.c: worker_job(1205) > 1101542646174151281075
