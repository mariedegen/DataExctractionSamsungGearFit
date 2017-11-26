S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 3451
Date: 2017-11-10 12:59:03+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3451, uid 5000)

Register Information
r0   = 0xbed34560, r1   = 0x43e35dd0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x43e81fd8, r5   = 0x43e35dd0
r6   = 0x41c3b310, r7   = 0xbed342d0
r8   = 0x00000000, r9   = 0x43e66a08
r10  = 0x43e74ae8, fp   = 0x00000001
ip   = 0x43e35dd0, sp   = 0xbed342a8
lr   = 0xbed34560, pc   = 0x41644d04
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     91196 KB
Buffers:     28208 KB
Cached:     155628 KB
VmPeak:      96796 KB
VmSize:      95320 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19520 KB
VmRSS:       19516 KB
VmData:      39448 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25016 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3451 TID = 3451
3451 3510 3550 

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
418be000 419fb000 r-xp /usr/lib/libicui18n.so.51.1
41a0b000 41aef000 r-xp /usr/lib/libicuuc.so.51.1
41b04000 41b20000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b29000 41b30000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41b39000 41b3b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41b46000 41b4a000 rw-p [heap]
41b4a000 41c61000 rw-p [heap]
431ea000 431f1000 r-xp /usr/lib/libminizip.so.1.0.0
431f9000 432c3000 r-xp /usr/lib/libCOREGL.so.4.0
434d6000 43cd5000 rw-p [stack:3510]
43cd5000 43ce0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ce9000 43cee000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43cf6000 43cf7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43e00000 43e08000 r-xp /usr/lib/libdrm.so.2.4.0
43e10000 43e17000 r-xp /usr/lib/libtbm.so.1.0.0
43e1f000 43e21000 r-xp /usr/lib/libdri2.so.0.0.0
43fc4000 43fc6000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43fcf000 447ce000 rw-p [stack:3550]
4593e000 4593f000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
4595a000 45961000 r-xp /usr/lib/libfeedback.so.0.1.4
4596a000 4596b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45973000 45975000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
4597d000 45987000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
4598f000 45996000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4599e000 459b4000 r-xp /usr/lib/libmmfsound.so.0.1.0
459c6000 459cb000 r-xp /usr/lib/libmmfsession.so.0.0.0
459d3000 459dd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
459e9000 459ed000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
459f6000 45a0b000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45a13000 45a74000 r-xp /usr/lib/libasound.so.2.0.0
45a7e000 45a81000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a89000 45ac1000 r-xp /usr/lib/libpulse.so.0.16.2
45ac2000 45af3000 r-xp /usr/lib/libmdm.so.1.1.86
45afb000 45b00000 r-xp /usr/lib/libjson.so.0.0.1
45b08000 45b50000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b51000 45b98000 r-xp /usr/lib/libsndfile.so.1.0.26
45ba4000 45bac000 r-xp /usr/lib/libmdm-common.so.1.0.89
45bad000 45bcf000 r-xp /usr/lib/libvorbis.so.0.4.3
45bd7000 45bdb000 r-xp /usr/lib/libogg.so.0.7.1
bed14000 bed35000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3451)
Call Stack Count: 17
 0: clicked_redo_app + 0x13 (0x41644d04) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d04
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
16: clicked_redo_app + 0x1f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:24.725+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:24.725+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 12:58:24.725+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [true][0m
11-10 12:58:24.730+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 12:58:24.740+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 765
11-10 12:58:24.740+0200 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-10 12:58:24.750+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 12:58:24.750+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1779]   bundle_add_str() .. [0xffffffea][0m
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 12:58:24.750+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:24.755+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 12:58:24.755+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 12:58:24.755+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:24.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:24.760+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 12:58:24.760+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 12:58:24.765+0200 I/TIZEN_N_SOUND_MANAGER( 1779): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-10 12:58:24.765+0200 E/TIZEN_N_SOUND_MANAGER( 1779): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-10 12:58:24.765+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1779]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:24.765+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:26.620+0200 W/AUL     ( 3509): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 12:58:26.625+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 12:58:26.640+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 12:58:26.655+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 12:58:26.655+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 12:58:26.655+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 3509
11-10 12:58:26.665+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 12:58:26.670+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-10 12:58:26.670+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 12:58:26.670+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 12:58:26.670+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 12:58:26.720+0200 I/efl-extension( 3451): efl_extension.c: eext_mod_init(40) > Init
11-10 12:58:26.720+0200 I/CAPI_APPFW_APPLICATION( 3451): app_main.c: ui_app_main(704) > app_efl_main
11-10 12:58:26.730+0200 I/CAPI_APPFW_APPLICATION( 3451): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 12:58:26.775+0200 W/AUL     ( 3509): launch.c: app_request_to_launchpad(282) > request cmd(0) result(3451)
11-10 12:58:26.860+0200 I/Bluetooth( 3451): [bt_initialize] success.
11-10 12:58:26.905+0200 I/Bluetooth( 3451): [bt_adapter_get_state] success.
11-10 12:58:27.020+0200 E/EFL     ( 3451): ecore_evas<3451> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 12:58:27.480+0200 I/APP_CORE( 3451): appcore-efl.c: __do_app(429) > [APP 3451] Event: RESET State: CREATED
11-10 12:58:27.480+0200 I/CAPI_APPFW_APPLICATION( 3451): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 12:58:27.505+0200 I/APP_CORE( 3451): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 12:58:27.505+0200 I/APP_CORE( 3451): appcore-efl.c: __do_app(474) > [APP 3451] Initial Launching, call the resume_cb
11-10 12:58:27.505+0200 I/CAPI_APPFW_APPLICATION( 3451): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 12:58:27.530+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 12:58:27.530+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.530+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.530+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.540+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 12:58:27.555+0200 W/APP_CORE( 3451): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _state_control(344) > appcore paused manually
11-10 12:58:27.650+0200 W/W_HOME  (  765): main.c: home_appcore_pause(723) > Home Appcore Paused
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.650+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.650+0200 W/W_HOME  (  765): main.c: home_pause(766) > clock/widget paused
11-10 12:58:27.650+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_pause(554) > 
11-10 12:58:27.660+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 12:58:27.660+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 12:58:27.670+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 12:58:27.670+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:27.685+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.690+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 12:58:27.690+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 12:58:27.695+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 12:58:27.705+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 12:58:27.735+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 12:58:27.735+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 12:58:27.735+0200 E/W_HOME  (  765): main.c: _pause_cb(674) > paused already
11-10 12:58:27.735+0200 I/APP_CORE( 3451): appcore-efl.c: __do_app(429) > [APP 3451] Event: RESUME State: RUNNING
11-10 12:58:27.765+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:27.765+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:27.765+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:27.850+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 12:58:27.855+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.217
11-10 12:58:27.855+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3451
11-10 12:58:27.875+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 12:58:27.885+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 12:58:27.885+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:58:27.885+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:58:27.890+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:58:27.895+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_pause(1028) > widget_pause
11-10 12:58:27.915+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:27.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.920+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 12:58:27.935+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:27.935+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.935+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 12:58:27.950+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 12:58:27.955+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:27.955+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 12:58:27.960+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:27.960+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.960+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 12:58:27.965+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3451
11-10 12:58:27.965+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 12:58:27.965+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 12:58:27.965+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 12:58:27.970+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 12:58:27.975+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:27.975+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.985+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 12:58:27.985+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 12:58:27.995+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 12:58:27.995+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 12:58:27.995+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 12:58:27.995+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 12:58:28.000+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 12:58:28.095+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 12:58:28.095+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 12:58:28.120+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 12:58:28.120+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 12:58:28.165+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 12:58:28.165+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 12:58:28.170+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 12:58:28.170+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 12:58:28.170+0200 E/EFL     ( 3520): elementary<3520> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 12:58:28.190+0200 E/EFL     ( 3520): elementary<3520> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 12:58:28.195+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 12:58:28.195+0200 E/EFL     ( 3520): elementary<3520> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 12:58:28.195+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 12:58:28.235+0200 E/EFL     ( 3520): elementary<3520> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 12:58:28.235+0200 E/EFL     ( 3520): elementary<3520> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 12:58:28.240+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 12:58:28.240+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 12:58:28.245+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 12:58:28.245+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 12:58:28.245+0200 E/EFL     ( 3520): elementary<3520> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 12:58:28.245+0200 I/AUL_PAD ( 3520): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 12:58:28.390+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:29.390+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:30.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:31.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:32.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:32.755+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 12:58:33.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:33.690+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
11-10 12:58:33.690+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-10 12:58:34.240+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=718607 button=1
11-10 12:58:34.335+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=718701 button=1
11-10 12:58:34.390+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:34.550+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=718912 button=1
11-10 12:58:34.595+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=718958 button=1
11-10 12:58:34.855+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=719220 button=1
11-10 12:58:34.915+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=719278 button=1
11-10 12:58:35.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:35.460+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=719824 button=1
11-10 12:58:35.515+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=719881 button=1
11-10 12:58:35.820+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=720184 button=1
11-10 12:58:35.890+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=720255 button=1
11-10 12:58:36.125+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=720492 button=1
11-10 12:58:36.235+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=720598 button=1
11-10 12:58:36.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:36.800+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=721163 button=1
11-10 12:58:36.855+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=721221 button=1
11-10 12:58:37.150+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=721512 button=1
11-10 12:58:37.265+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=721631 button=1
11-10 12:58:37.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT HEART RATE < 40 : 0
11-10 12:58:37.475+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=721841 button=1
11-10 12:58:37.570+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=721936 button=1
11-10 12:58:37.835+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=722198 button=1
11-10 12:58:37.965+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=722329 button=1
11-10 12:58:38.180+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=722543 button=1
11-10 12:58:38.310+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=722674 button=1
11-10 12:58:38.390+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 12:58:38.400+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 12:58:38.770+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:58:38.805+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=723148 button=1
11-10 12:58:38.890+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=723257 button=1
11-10 12:58:39.680+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=724042 button=1
11-10 12:58:39.735+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=724100 button=1
11-10 12:58:39.900+0200 E/RECORDING_TAG( 3451): sensor_listener_unset_event_cb error: -38010874
11-10 12:58:39.910+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 12:58:39.915+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 12:58:40.090+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:58:40.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 106
11-10 12:58:40.440+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 106
11-10 12:58:41.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 106
11-10 12:58:41.415+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 106
11-10 12:58:42.045+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=726404 button=1
11-10 12:58:42.075+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=726437 button=1
11-10 12:58:42.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 103
11-10 12:58:42.420+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 103
11-10 12:58:42.795+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=727161 button=1
11-10 12:58:42.855+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=727219 button=1
11-10 12:58:43.395+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 101
11-10 12:58:43.420+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 101
11-10 12:58:43.730+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=728090 button=1
11-10 12:58:43.800+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=728160 button=1
11-10 12:58:44.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 105
11-10 12:58:44.420+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 105
11-10 12:58:44.470+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=728834 button=1
11-10 12:58:44.580+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=728940 button=1
11-10 12:58:45.100+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=729466 button=1
11-10 12:58:45.195+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=729560 button=1
11-10 12:58:45.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 109
11-10 12:58:45.430+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 109
11-10 12:58:46.405+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 107
11-10 12:58:46.425+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 107
11-10 12:58:47.405+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 109
11-10 12:58:47.420+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 109
11-10 12:58:48.400+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 HEART RATE : 106
11-10 12:58:48.425+0200 I/INFO_TAG( 3451): SENSOR_EVENT2 TAB VALUE : 106
11-10 12:58:48.965+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=733332 button=1
11-10 12:58:49.050+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=733414 button=1
11-10 12:58:49.065+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 12:58:49.140+0200 I/Bluetooth( 3451): [bt_socket_create_rfcomm] success.
11-10 12:58:49.230+0200 I/BluetoothServer( 3451): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 12:58:49.260+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 12:58:49.610+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:58:53.680+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
11-10 12:58:53.685+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-10 12:58:55.490+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=739854 button=1
11-10 12:58:55.510+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=739875 button=1
11-10 12:58:56.195+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=740562 button=1
11-10 12:58:56.205+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=740571 button=1
11-10 12:58:57.035+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=741401 button=1
11-10 12:58:57.080+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=741447 button=1
11-10 12:58:58.764+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=743129 button=1
11-10 12:58:58.795+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=743162 button=1
11-10 12:58:59.555+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=743922 button=1
11-10 12:58:59.580+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=743943 button=1
11-10 12:58:59.910+0200 I/BluetoothServer( 3451): Callback: Connected.
11-10 12:58:59.930+0200 I/BluetoothServer( 3451): Callback: Socket of connection - 28.
11-10 12:58:59.930+0200 I/BluetoothServer( 3451): Callback: Role of connection - 1.
11-10 12:58:59.935+0200 I/BluetoothServer( 3451): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 12:58:59.940+0200 I/BluetoothServer( 3451): Sent: 'h3ÕC6106,000000 103,000000 101,000000 105,000000 109,000000 107,000000 109,000000 106,000000 0,000000 '
11-10 12:58:59.995+0200 E/Bluetooth( 3451): [bt_socket_send_data] unknown error code : 102.
11-10 12:58:59.995+0200 E/Bluetooth( 3451): [bt_socket_send_data] unknown error code : 3.
11-10 12:58:59.995+0200 I/BluetoothServer( 3451): All data sent
11-10 12:58:59.995+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 12:59:00.020+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 12:59:00.090+0200 I/BluetoothServer( 3451): Callback: Disconnected.
11-10 12:59:00.090+0200 I/BluetoothServer( 3451): Callback: Socket of disconnection - 28.
11-10 12:59:00.090+0200 I/BluetoothServer( 3451): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 12:59:00.120+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=744485 button=1
11-10 12:59:00.155+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=744519 button=1
11-10 12:59:00.375+0200 E/EFL     ( 3451): elementary<3451> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 12:59:00.510+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 12:59:00.510+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 12:59:00.510+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 12:59:00.510+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 12:59:00.510+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 12:59:00.510+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 12:59:00.515+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 12:59:00.515+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 12:59:00.515+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 12:59:01.325+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=745689 button=1
11-10 12:59:01.335+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=745697 button=1
11-10 12:59:03.695+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 12:59:03.710+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
11-10 12:59:03.710+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-10 12:59:03.890+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=748255 button=1
11-10 12:59:03.925+0200 E/EFL     ( 3451): ecore_x<3451> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=748289 button=1
11-10 12:59:04.285+0200 W/CRASH_MANAGER( 3572): worker.c: worker_job(1205) > 1103451646174151031154
