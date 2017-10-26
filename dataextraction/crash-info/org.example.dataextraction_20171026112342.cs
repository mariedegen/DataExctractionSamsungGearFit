S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2812
Date: 2017-10-26 11:23:42+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2812, uid 5000)

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x4165790c, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbe8f93f8
r8   = 0xbe8f94a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbe8f93a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     86024 KB
Buffers:     27504 KB
Cached:     155664 KB
VmPeak:      98888 KB
VmSize:      96404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19976 KB
VmRSS:       19976 KB
VmData:      39540 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25564 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2812 TID = 2812
2812 2857 

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
416a0000 416a8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
416a9000 416ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
416d3000 4170d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41716000 4172f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41737000 4173c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41744000 4176e000 r-xp /usr/lib/libsensor.so.1.9.6
41777000 41789000 r-xp /usr/lib/libefl-assist.so.0.1.0
41791000 41794000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4179c000 417a2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
417ae000 417b2000 rw-p [heap]
417b2000 418c8000 rw-p [heap]
418c8000 41980000 r-xp /usr/lib/libcairo.so.2.11200.14
4198b000 41993000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4199b000 419a5000 r-xp /usr/lib/libsensord-shared.so
419ae000 419c0000 r-xp /usr/lib/libtts.so
419c8000 419ea000 r-xp /usr/lib/libui-extension.so.0.1.0
419f3000 419fa000 r-xp /usr/lib/libtbm.so.1.0.0
41a02000 41a10000 r-xp /usr/lib/libGLESv2.so.2.0
41a19000 41a1a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a23000 41a29000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a31000 41a34000 r-xp /usr/lib/libEGL.so.1.4
41a3c000 41a49000 r-xp /usr/lib/libail.so.0.1.0
41a52000 41b8f000 r-xp /usr/lib/libicui18n.so.51.1
41b9f000 41c83000 r-xp /usr/lib/libicuuc.so.51.1
43221000 4323d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43246000 43249000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43251000 43252000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4325b000 43263000 r-xp /usr/lib/libdrm.so.2.4.0
4326b000 4326d000 r-xp /usr/lib/libdri2.so.0.0.0
43275000 4327c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43285000 43287000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4328f000 43296000 r-xp /usr/lib/libminizip.so.1.0.0
4329e000 432a4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
432ac000 432b1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
432b9000 432da000 r-xp /usr/lib/libexif.so.12.3.3
432ed000 432ef000 r-xp /usr/lib/libttrace.so.1.1
432f7000 432fc000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43304000 433ce000 r-xp /usr/lib/libCOREGL.so.4.0
435e1000 43de0000 rw-p [stack:2857]
43de0000 43deb000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43df4000 43df5000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43f00000 43f05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
440a8000 440aa000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45a22000 45a23000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a2b000 45a2e000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45a3e000 45a45000 r-xp /usr/lib/libfeedback.so.0.1.4
45a4e000 45a4f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a57000 45a59000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a61000 45a6b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a73000 45a7a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a82000 45a98000 r-xp /usr/lib/libmmfsound.so.0.1.0
45aaa000 45aaf000 r-xp /usr/lib/libmmfsession.so.0.0.0
45ab7000 45ac1000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45acd000 45ad1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45ada000 45aef000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45af7000 45b58000 r-xp /usr/lib/libasound.so.2.0.0
45b62000 45b65000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b6d000 45ba5000 r-xp /usr/lib/libpulse.so.0.16.2
45ba6000 45bd7000 r-xp /usr/lib/libmdm.so.1.1.86
45bdf000 45be4000 r-xp /usr/lib/libjson.so.0.0.1
45bec000 45c34000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c35000 45c7c000 r-xp /usr/lib/libsndfile.so.1.0.26
45c88000 45c90000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c91000 45cb3000 r-xp /usr/lib/libvorbis.so.0.4.3
45cbb000 45cbf000 r-xp /usr/lib/libogg.so.0.7.1
45cc7000 45cc8000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
be8d9000 be8fa000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2812)
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
l(661) >  touch cancel
10-26 11:22:55.485+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:55.495+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:55.510+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:55.520+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1169872 button=1
10-26 11:22:55.520+0200 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:55.615+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:55.620+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.625+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 11:22:55.625+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [true][0m
10-26 11:22:55.630+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:55.640+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
10-26 11:22:55.660+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:22:55.665+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:55.665+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.670+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.670+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.670+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:55.675+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.680+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 11:22:55.680+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 11:22:55.680+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:55.685+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:55.700+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.705+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 11:22:55.705+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 11:22:55.735+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 11:22:55.735+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 11:22:55.735+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:55.735+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:55.740+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:55.900+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1170250 button=1
10-26 11:22:55.905+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:22:55.905+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 11:22:55.905+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 11:22:55.950+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1170302 button=1
10-26 11:22:55.950+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 11:22:55.950+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 11:22:55.950+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 11:22:55.950+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 11:22:55.955+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:22:55.955+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 11:22:55.955+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 11:22:55.970+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 11:22:55.970+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 11:22:55.970+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 11:22:55.970+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 11:22:55.970+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 11:22:56.015+0200 I/efl-extension( 2812): efl_extension.c: eext_mod_init(40) > Init
10-26 11:22:56.020+0200 I/UXT     ( 2812): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 11:22:56.020+0200 I/CAPI_APPFW_APPLICATION( 2812): app_main.c: ui_app_main(704) > app_efl_main
10-26 11:22:56.025+0200 I/CAPI_APPFW_APPLICATION( 2812): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 11:22:56.070+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:22:56.075+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2812)
10-26 11:22:56.075+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 11:22:56.105+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 11:22:56.155+0200 I/Bluetooth( 2812): [bt_initialize] success.
10-26 11:22:56.155+0200 I/Bluetooth( 2812): [bt_adapter_le_create_advertiser] success.
10-26 11:22:56.185+0200 I/Bluetooth( 2812): [bt_adapter_le_set_advertising_mode] success.
10-26 11:22:56.190+0200 I/Bluetooth( 2812): [bt_adapter_le_set_advertising_connectable] success.
10-26 11:22:56.190+0200 I/Bluetooth( 2812): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:56.190+0200 I/Bluetooth( 2812): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:56.305+0200 I/Bluetooth( 2812): [bt_adapter_le_start_advertising_new] success.
10-26 11:22:56.305+0200 I/Bluetooth( 2812): Heart Rate Measurement advertiser started.
10-26 11:22:56.345+0200 I/Bluetooth( 2812): [bt_adapter_le_stop_advertising] success.
10-26 11:22:56.345+0200 I/Bluetooth( 2812): [bt_adapter_le_clear_advertising_data] success.
10-26 11:22:56.345+0200 I/Bluetooth( 2812): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:56.350+0200 I/Bluetooth( 2812): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 11:22:56.440+0200 I/Bluetooth( 2812): [bt_adapter_le_start_advertising_new] success.
10-26 11:22:56.500+0200 E/EFL     ( 2812): ecore_evas<2812> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 11:22:56.750+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 11:22:56.750+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.750+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.750+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.750+0200 I/APP_CORE( 2812): appcore-efl.c: __do_app(429) > [APP 2812] Event: RESET State: CREATED
10-26 11:22:56.750+0200 I/CAPI_APPFW_APPLICATION( 2812): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 11:22:56.775+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 11:22:56.785+0200 I/APP_CORE( 2812): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 11:22:56.785+0200 I/APP_CORE( 2812): appcore-efl.c: __do_app(474) > [APP 2812] Initial Launching, call the resume_cb
10-26 11:22:56.785+0200 I/CAPI_APPFW_APPLICATION( 2812): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 11:22:56.795+0200 W/APP_CORE( 2812): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.845+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 11:22:56.845+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 11:22:56.845+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 11:22:56.845+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.845+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:56.860+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:22:56.865+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:22:56.865+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 11:22:56.865+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 11:22:56.915+0200 I/APP_CORE( 2812): appcore-efl.c: __do_app(429) > [APP 2812] Event: RESUME State: RUNNING
10-26 11:22:56.940+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 11:22:56.945+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:56.945+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:56.945+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:57.055+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1171394 button=1
10-26 11:22:57.100+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1171432 button=1
10-26 11:22:57.145+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:22:57.145+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:22:57.190+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:22:57.370+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:22:57.375+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:22:57.375+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:22:57.405+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:22:57.405+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:22:57.460+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:22:57.460+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:22:57.465+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:22:57.465+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:22:57.465+0200 E/EFL     ( 2872): elementary<2872> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:22:57.485+0200 E/EFL     ( 2872): elementary<2872> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:22:57.490+0200 E/EFL     ( 2872): elementary<2872> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:22:57.490+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:22:57.530+0200 E/EFL     ( 2872): elementary<2872> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:22:57.540+0200 E/EFL     ( 2872): elementary<2872> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:22:57.540+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:22:57.545+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:22:57.545+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:22:57.545+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:22:57.545+0200 E/EFL     ( 2872): elementary<2872> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:22:57.545+0200 I/AUL_PAD ( 2872): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:22:57.615+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:57.625+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2812
10-26 11:22:57.630+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:22:57.645+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:57.650+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2812
10-26 11:22:57.655+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:22:57.700+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:58.700+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:22:59.700+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:23:00.620+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 11:23:00.620+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 11:23:00.625+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 11:23:00.700+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:23:01.700+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:23:01.880+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:23:02.700+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:23:03.720+0200 I/INFO_TAG( 2812): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:23:04.715+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 11:23:04.765+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 11:23:05.140+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:23:06.865+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1181213 button=1
10-26 11:23:06.930+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1181283 button=1
10-26 11:23:07.115+0200 E/RECORDING_TAG( 2812): sensor_listener_unset_event_cb error: -38010874
10-26 11:23:07.120+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 11:23:07.125+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 11:23:07.285+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:23:07.720+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 77
10-26 11:23:07.765+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 77
10-26 11:23:08.710+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 76
10-26 11:23:08.730+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 76
10-26 11:23:09.710+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 76
10-26 11:23:09.725+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 76
10-26 11:23:10.715+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 78
10-26 11:23:10.750+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 78
10-26 11:23:11.710+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 80
10-26 11:23:11.730+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 80
10-26 11:23:12.710+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 82
10-26 11:23:12.730+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 82
10-26 11:23:13.735+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 HEART RATE : 81
10-26 11:23:13.765+0200 I/INFO_TAG( 2812): SENSOR_EVENT2 TAB VALUE : 81
10-26 11:23:13.930+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1188280 button=1
10-26 11:23:13.950+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1188301 button=1
10-26 11:23:13.970+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 11:23:13.975+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 11:23:14.305+0200 E/EFL     ( 2812): elementary<2812> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:23:17.555+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:23:28.565+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:23:31.695+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 11:23:31.700+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:23:35.815+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 11:23:35.950+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 11:23:36.060+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 11:23:36.060+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 11:23:36.075+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 11:23:36.095+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 11:23:36.130+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 11:23:36.160+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 11:23:36.160+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 11:23:36.160+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 11:23:36.160+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 11:23:36.190+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 11:23:36.195+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 11:23:39.970+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:23:41.689+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 11:23:41.694+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:23:42.160+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-26 11:23:42.160+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-26 11:23:42.160+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-26 11:23:42.165+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-26 11:23:42.165+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-26 11:23:42.170+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1216496
10-26 11:23:42.175+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1216496
10-26 11:23:42.190+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-26 11:23:42.255+0200 E/STARTER (  732): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-26 11:23:42.265+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-26 11:23:42.265+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-26 11:23:42.330+0200 E/W_HOME  (  769): key.c: _key_press_cb(218) > (APP_STATE_PAUSE == main_get_info()->state) -> _key_press_cb() return
10-26 11:23:42.390+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 11:23:42.390+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 11:23:42.390+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 11:23:42.390+0200 W/STARTER (  732): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-26 11:23:42.395+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1216734
10-26 11:23:42.395+0200 E/EFL     ( 2812): ecore_x<2812> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1216734
10-26 11:23:42.400+0200 W/STARTER (  732): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-26 11:23:42.425+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-26 11:23:42.425+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-26 11:23:42.440+0200 E/STARTER (  732): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-26 11:23:42.440+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 11:23:42.440+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:23:42.445+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 11:23:42.450+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 11:23:42.450+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: PAUSED
10-26 11:23:42.450+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 11:23:42.450+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : powerkey
10-26 11:23:42.450+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-26 11:23:42.450+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-26 11:23:42.450+0200 W/W_HOME  (  769): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-26 11:23:42.450+0200 E/W_HOME  (  769): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-26 11:23:42.450+0200 W/W_HOME  (  769): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:0 clock:1 apps:1
10-26 11:23:42.450+0200 W/W_HOME  (  769): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-26 11:23:42.450+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 11:23:42.450+0200 W/W_HOME  (  769): move.c: _scroller_down_done(494) > down signal done
10-26 11:23:42.450+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-26 11:23:42.450+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 11:23:42.450+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.450+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.450+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.450+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-26 11:23:42.450+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-26 11:23:42.450+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-26 11:23:42.450+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-26 11:23:42.455+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(769), cmd(0)
10-26 11:23:42.460+0200 E/APPS    (  769): apps_main.c: apps_main_pause(602) >  paused already
10-26 11:23:42.460+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 11:23:42.465+0200 E/AUL     (  732): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:23:42.470+0200 W/W_HOME  (  769): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-26 11:23:42.470+0200 W/W_HOME  (  769): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-26 11:23:42.470+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.470+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:23:42.470+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.470+0200 W/W_HOME  (  769): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
10-26 11:23:42.475+0200 W/W_HOME  (  769): main.c: home_resume(739) > clock/widget resumed
10-26 11:23:42.475+0200 W/W_HOME  (  769): clock_indicator.c: clock_indicator_resume(537) > 
10-26 11:23:42.475+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.480+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:23:42.480+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 11:23:42.480+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
10-26 11:23:42.490+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_resume(1039) > widget_resume
10-26 11:23:42.490+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 11:23:42.500+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 11:23:42.535+0200 W/PROCESSMGR(  406): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-26 11:23:42.535+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-26 11:23:42.535+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-26 11:23:42.535+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 11:23:42.560+0200 I/APP_CORE( 2812): appcore-efl.c: __do_app(429) > [APP 2812] Event: PAUSE State: RUNNING
10-26 11:23:42.560+0200 I/CAPI_APPFW_APPLICATION( 2812): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 11:23:42.585+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-26 11:23:42.585+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.585+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.585+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.595+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-26 11:23:42.595+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-26 11:23:42.595+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:23:42.595+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-26 11:23:42.595+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESUME State: RUNNING
10-26 11:23:42.595+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-26 11:23:42.600+0200 E/TBM     (  406): tbm_bufmgr.c: _tgl_destroy(151) > [libtbm:406] error(Device or resource busy) _tgl_destroy:151 key:25
10-26 11:23:42.680+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:23:42.680+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:23:42.765+0200 I/APP_CORE( 2812): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 11:23:42.765+0200 I/CAPI_APPFW_APPLICATION( 2812): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 11:23:42.980+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
10-26 11:23:43.120+0200 W/CRASH_MANAGER( 2998): worker.c: worker_job(1205) > 1102812646174150900982
