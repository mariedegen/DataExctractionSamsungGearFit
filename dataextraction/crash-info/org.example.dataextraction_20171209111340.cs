S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2054
Date: 2017-12-09 11:13:40+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2054, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x43e00010, r3   = 0x415c9d59
r4   = 0xbeb89504, r5   = 0x41441980
r6   = 0x00000249, r7   = 0xbeb89440
r8   = 0xbeb894d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbeb89428
lr   = 0x415c9d75, pc   = 0x415cb2a8
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     99692 KB
Buffers:     26068 KB
Cached:     153104 KB
VmPeak:      95220 KB
VmSize:      94848 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17180 KB
VmRSS:       17176 KB
VmData:      38884 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25044 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2054 TID = 2054
2054 2120 2128 2129 

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
415c8000 415cd000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
415dd000 4160f000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41618000 4161d000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41625000 41628000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41630000 416b5000 rw-p [heap]
41830000 41834000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
4183d000 4185e000 r-xp /usr/lib/libefl-extension.so.0.1.0
41867000 418a1000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
418aa000 418c3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
418cb000 418d0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
418d8000 41902000 r-xp /usr/lib/libsensor.so.1.9.6
4190b000 419c3000 r-xp /usr/lib/libcairo.so.2.11200.14
419ce000 419d4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
419dd000 419e5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
419ed000 419f7000 r-xp /usr/lib/libsensord-shared.so
41a00000 41a0e000 r-xp /usr/lib/libGLESv2.so.2.0
41a17000 41a18000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a21000 41a27000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a2f000 41a32000 r-xp /usr/lib/libEGL.so.1.4
41a3a000 41a47000 r-xp /usr/lib/libail.so.0.1.0
41a50000 41b8d000 r-xp /usr/lib/libicui18n.so.51.1
41b9d000 41c81000 r-xp /usr/lib/libicuuc.so.51.1
4321f000 4323b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43244000 4324b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43254000 43256000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4325e000 43265000 r-xp /usr/lib/libminizip.so.1.0.0
4326d000 43337000 r-xp /usr/lib/libCOREGL.so.4.0
4354a000 43d49000 rw-p [stack:2120]
43d49000 43d54000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43d5d000 43d62000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43d70000 43d78000 r-xp /usr/lib/libdrm.so.2.4.0
43d80000 43d87000 r-xp /usr/lib/libtbm.so.1.0.0
43d8f000 43d91000 r-xp /usr/lib/libdri2.so.0.0.0
43da8000 43da9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43db1000 43db2000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
43dba000 43dbd000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43dcd000 43dd4000 r-xp /usr/lib/libfeedback.so.0.1.4
43ddd000 43dde000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
43de6000 43de8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
43df0000 43df7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4408d000 4488c000 rw-p [stack:2128]
4488d000 4508c000 rw-p [stack:2129]
458e8000 458f2000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
458fa000 45910000 r-xp /usr/lib/libmmfsound.so.0.1.0
45922000 45927000 r-xp /usr/lib/libmmfsession.so.0.0.0
4592f000 45939000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45945000 45949000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45952000 45967000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4596f000 459d0000 r-xp /usr/lib/libasound.so.2.0.0
459da000 459dd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
459e5000 45a1d000 r-xp /usr/lib/libpulse.so.0.16.2
45a1e000 45a4f000 r-xp /usr/lib/libmdm.so.1.1.86
45a57000 45a5c000 r-xp /usr/lib/libjson.so.0.0.1
45a64000 45aac000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45aad000 45af4000 r-xp /usr/lib/libsndfile.so.1.0.26
45b00000 45b08000 r-xp /usr/lib/libmdm-common.so.1.0.89
45b09000 45b2b000 r-xp /usr/lib/libvorbis.so.0.4.3
45b33000 45b37000 r-xp /usr/lib/libogg.so.0.7.1
45bf7000 45bf8000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
beb69000 beb8a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2054)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x415cb2a8) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x32a8
 1: app_terminate + 0x1c (0x415c9d75) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d75
 2: (0x41440af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x415c9d07) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d07
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
.205+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.205+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 11:13:33.210+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.215+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 11:13:33.220+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:33.220+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:33.220+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.220+0200 E/CAPI_APPFW_APP_CONTROL( 1078): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 11:13:33.220+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1078]   [com.samsung.w-home]register msg port [true][0m
12-09 11:13:33.230+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 14
12-09 11:13:33.255+0200 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 779
12-09 11:13:33.270+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1078]   [MUSIC_PLAYER_EVENT][0m
12-09 11:13:33.280+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1078]   bundle_add_str() .. [0xffffffea][0m
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 11:13:33.285+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:33.290+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.290+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1078]   [MUSIC_PLAYER_EVENT][0m
12-09 11:13:33.305+0200 W/W_HOME  (  779): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
12-09 11:13:33.305+0200 E/W_HOME  (  779): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.320+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:33.325+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.325+0200 W/W_HOME  (  779): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
12-09 11:13:33.325+0200 E/W_HOME  (  779): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 11:13:33.340+0200 I/TIZEN_N_SOUND_MANAGER( 1078): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
12-09 11:13:33.340+0200 E/TIZEN_N_SOUND_MANAGER( 1078): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
12-09 11:13:33.340+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1078]   sound_manager_get_volume() .. [0xfe6a0001][0m
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 11:13:33.340+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:33.345+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:34.435+0200 I/APP_CORE( 2054): appcore-efl.c: __do_app(429) > [APP 2054] Event: MEM_FLUSH State: PAUSED
12-09 11:13:36.085+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
12-09 11:13:36.085+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
12-09 11:13:36.085+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=263448
12-09 11:13:36.090+0200 W/STARTER (  696): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
12-09 11:13:36.090+0200 W/STARTER (  696): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
12-09 11:13:36.090+0200 W/STARTER (  696): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
12-09 11:13:36.105+0200 E/STARTER (  696): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
12-09 11:13:36.115+0200 W/STARTER (  696): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
12-09 11:13:36.115+0200 W/STARTER (  696): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
12-09 11:13:36.245+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
12-09 11:13:36.245+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
12-09 11:13:36.245+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=263609
12-09 11:13:36.245+0200 W/STARTER (  696): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
12-09 11:13:36.250+0200 W/STARTER (  696): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
12-09 11:13:36.260+0200 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
12-09 11:13:36.265+0200 W/STARTER (  696): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
12-09 11:13:36.280+0200 E/STARTER (  696): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
12-09 11:13:36.280+0200 W/AUL     (  696): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
12-09 11:13:36.285+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 0
12-09 11:13:36.290+0200 W/AUL_AMD (  530): amd_launch.c: _start_app(1710) > caller pid : 696
12-09 11:13:36.310+0200 W/AUL_AMD (  530): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 779
12-09 11:13:36.320+0200 E/AUL     (  530): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:13:36.325+0200 W/AUL_AMD (  530): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(779), cmd(0)
12-09 11:13:36.325+0200 W/AUL     (  696): launch.c: app_request_to_launchpad(282) > request cmd(0) result(779)
12-09 11:13:36.325+0200 E/AUL     (  696): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:13:36.325+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: RESET State: RUNNING
12-09 11:13:36.325+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-09 11:13:36.330+0200 W/W_HOME  (  779): main.c: _app_control(1704) > Service value : powerkey
12-09 11:13:36.330+0200 I/wnotib  (  779): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
12-09 11:13:36.330+0200 I/wnotib  (  779): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
12-09 11:13:36.330+0200 W/W_HOME  (  779): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
12-09 11:13:36.330+0200 E/W_HOME  (  779): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
12-09 11:13:36.330+0200 W/W_HOME  (  779): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
12-09 11:13:36.330+0200 W/W_HOME  (  779): move.c: move_move_to_apps(220) > move to apps
12-09 11:13:36.335+0200 W/W_HOME  (  779): move.c: _create_fake_apps(823) > fake image position : 432
12-09 11:13:36.335+0200 W/W_HOME  (  779): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
12-09 11:13:36.335+0200 W/W_HOME  (  779): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
12-09 11:13:36.335+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:13:36.335+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:13:36.335+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-09 11:13:36.340+0200 W/W_HOME  (  779): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
12-09 11:13:36.340+0200 W/W_HOME  (  779): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
12-09 11:13:36.340+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:13:36.340+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:13:36.340+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:13:36.340+0200 W/W_HOME  (  779): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
12-09 11:13:36.340+0200 W/W_HOME  (  779): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
12-09 11:13:36.340+0200 I/wnotib  (  779): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
12-09 11:13:36.340+0200 I/wnotib  (  779): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
12-09 11:13:36.655+0200 W/W_HOME  (  779): move.c: _transit_del_cb(115) > transit end
12-09 11:13:36.655+0200 W/W_HOME  (  779): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
12-09 11:13:36.655+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:13:36.665+0200 W/W_HOME  (  779): move.c: _scroller_up_done(515) > up signal done
12-09 11:13:36.670+0200 W/W_HOME  (  779): event_manager.c: _apptray_visibility_cb(583) > apps,show
12-09 11:13:36.670+0200 W/W_HOME  (  779): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
12-09 11:13:36.670+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:36.670+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:36.670+0200 W/W_HOME  (  779): main.c: home_pause(766) > clock/widget paused
12-09 11:13:36.670+0200 W/W_HOME  (  779): clock_indicator.c: clock_indicator_pause(554) > 
12-09 11:13:36.675+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:36.675+0200 W/W_HOME  (  779): noti_broker.c: _apptray_visibility_cb(789) > apps,show
12-09 11:13:36.675+0200 W/W_HOME  (  779): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
12-09 11:13:36.675+0200 I/wnotib  (  779): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
12-09 11:13:36.675+0200 I/wnotib  (  779): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
12-09 11:13:36.675+0200 E/APPS    (  779): apps_main.c: apps_main_resume(636) >  resumed already
12-09 11:13:36.685+0200 W/WATCH_CORE(  812): appcore-watch.c: __widget_pause(1028) > widget_pause
12-09 11:13:36.695+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:36.695+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:36.695+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:13:36.695+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:13:36.705+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:36.705+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:36.705+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:13:36.710+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:13:36.715+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:36.715+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:36.715+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:13:36.725+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:36.725+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:36.725+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:13:36.735+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:36.735+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:36.735+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:13:36.745+0200 W/SHealth_Common(  839): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:36.745+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:36.745+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_pause_cb(298) > widget obj was paused
12-09 11:13:36.750+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-09 11:13:36.750+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:13:36.755+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:13:36.755+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:13:36.755+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
12-09 11:13:37.045+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=264409 button=1
12-09 11:13:37.045+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.045+0200 E/W_HOME  (  779): move.c: _mouse_down_cb(384) > apps move is not allowed
12-09 11:13:37.045+0200 W/APPS    (  779): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
12-09 11:13:37.055+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.065+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.065+0200 W/APPS    (  779): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
12-09 11:13:37.080+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.090+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.105+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.115+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.130+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.140+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=264506 button=1
12-09 11:13:37.140+0200 E/APPS    (  779): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
12-09 11:13:37.315+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:13:37.315+0200 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
12-09 11:13:37.650+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
12-09 11:13:37.650+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
12-09 11:13:37.955+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=265320 button=1
12-09 11:13:37.955+0200 E/W_HOME  (  779): move.c: _mouse_move_cb(546) > apps move is not allowed
12-09 11:13:37.955+0200 E/W_HOME  (  779): move.c: _mouse_down_cb(384) > apps move is not allowed
12-09 11:13:37.960+0200 W/APPS    (  779): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
12-09 11:13:38.035+0200 E/EFL     (  779): ecore_x<779> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=265403 button=1
12-09 11:13:38.040+0200 W/APPS    (  779): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
12-09 11:13:38.040+0200 E/APPS    (  779): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
12-09 11:13:38.040+0200 W/APPS    (  779): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
12-09 11:13:38.040+0200 W/AUL     (  779): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
12-09 11:13:38.040+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 0
12-09 11:13:38.045+0200 W/AUL_AMD (  530): amd_launch.c: _start_app(1710) > caller pid : 779
12-09 11:13:38.045+0200 I/AUL_AMD (  530): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
12-09 11:13:38.055+0200 W/AUL_AMD (  530): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 2054
12-09 11:13:38.055+0200 W/AUL_AMD (  530): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(2054), cmd(0)
12-09 11:13:38.055+0200 W/AUL     (  779): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2054)
12-09 11:13:38.055+0200 E/W_HOME  (  779): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
12-09 11:13:38.060+0200 I/APP_CORE( 2054): appcore-efl.c: __do_app(429) > [APP 2054] Event: RESET State: PAUSED
12-09 11:13:38.060+0200 I/CAPI_APPFW_APPLICATION( 2054): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
12-09 11:13:38.060+0200 I/APP_CORE( 2054): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
12-09 11:13:38.060+0200 I/APP_CORE( 2054): appcore-efl.c: __do_app(481) > [APP 2054] App already running, raise the window
12-09 11:13:38.060+0200 E/AUL     (  530): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:13:38.070+0200 I/APP_CORE( 2054): appcore-efl.c: __do_app(485) > [APP 2054] Call the resume_cb
12-09 11:13:38.070+0200 I/CAPI_APPFW_APPLICATION( 2054): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:13:38.095+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
12-09 11:13:38.095+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.095+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.095+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _state_control(344) > appcore paused manually
12-09 11:13:38.130+0200 W/W_HOME  (  779): main.c: home_appcore_pause(723) > Home Appcore Paused
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.130+0200 I/APP_CORE( 2054): appcore-efl.c: __do_app(429) > [APP 2054] Event: RESUME State: RUNNING
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.130+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 11:13:38.135+0200 I/MESSAGE_PORT(  493): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 11:13:38.135+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
12-09 11:13:38.140+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: PAUSE State: RUNNING
12-09 11:13:38.140+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 11:13:38.140+0200 W/W_HOME  (  779): main.c: _appcore_pause_cb(696) > appcore pause
12-09 11:13:38.140+0200 E/W_HOME  (  779): main.c: _pause_cb(674) > paused already
12-09 11:13:38.170+0200 E/CAPI_APPFW_APP_CONTROL( 1078): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 11:13:38.170+0200 W/MUSIC_CONTROL_SERVICE( 1078): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1078]   [com.samsung.w-home]register msg port [false][0m
12-09 11:13:38.180+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
12-09 11:13:38.445+0200 E/AUL     (  530): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:13:38.635+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: MEM_FLUSH State: PAUSED
12-09 11:13:39.840+0200 E/EFL     ( 2054): ecore_x<2054> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=267201 button=1
12-09 11:13:39.870+0200 E/EFL     ( 2054): ecore_x<2054> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=267234 button=1
12-09 11:13:40.030+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 22
12-09 11:13:40.030+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(916) > app status : 4
12-09 11:13:40.090+0200 E/APP_CORE( 2054): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-09 11:13:40.090+0200 I/APP_CORE( 2054): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-09 11:13:40.095+0200 I/APP_CORE( 2054): appcore-efl.c: __after_loop(1089) > [APP 2054] PAUSE before termination
12-09 11:13:40.095+0200 I/CAPI_APPFW_APPLICATION( 2054): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:13:40.095+0200 I/CAPI_APPFW_APPLICATION( 2054): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-09 11:13:40.510+0200 I/MALI    (  779): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
12-09 11:13:40.515+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:13:40.515+0200 W/AUL_AMD (  530): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-09 11:13:40.545+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2054 pgid = 2054
12-09 11:13:40.590+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-09 11:13:40.590+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
12-09 11:13:40.590+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.590+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.590+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.625+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
12-09 11:13:40.625+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: RESUME State: PAUSED
12-09 11:13:40.625+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 11:13:40.625+0200 W/W_HOME  (  779): main.c: _appcore_resume_cb(687) > appcore resume
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.625+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:13:40.640+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
12-09 11:13:40.705+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
12-09 11:13:40.705+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
12-09 11:13:40.705+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:13:40.750+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
12-09 11:13:40.755+0200 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2054
12-09 11:13:40.770+0200 E/RESOURCED(  532): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.183
12-09 11:13:40.830+0200 W/CRASH_MANAGER( 2184): worker.c: worker_job(1205) > 1102054646174151281082
