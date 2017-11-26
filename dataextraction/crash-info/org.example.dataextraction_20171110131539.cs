S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 7348
Date: 2017-11-10 13:15:39+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7348, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xcda7e700, r3   = 0xcda7e700
r4   = 0x41cd4490, r5   = 0x41c88ca0
r6   = 0x41ec88b8, r7   = 0xbea4f2a8
r8   = 0x00000000, r9   = 0x41cb43c0
r10  = 0x41cc5d98, fp   = 0x00000001
ip   = 0x40088a5c, sp   = 0xbea4f280
lr   = 0x41645b85, pc   = 0x41644b66
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     80716 KB
Buffers:     33808 KB
Cached:     158456 KB
VmPeak:      98844 KB
VmSize:      97368 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19404 KB
VmRSS:       19400 KB
VmData:      41496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25016 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7348 TID = 7348
7348 7415 7463 

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
41b43000 41b4a000 r-xp /usr/lib/libminizip.so.1.0.0
41b52000 41c1c000 r-xp /usr/lib/libCOREGL.so.4.0
41c2e000 41c39000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41c42000 41c47000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41c55000 41c5d000 r-xp /usr/lib/libdrm.so.2.4.0
41c65000 41c6c000 r-xp /usr/lib/libtbm.so.1.0.0
41c74000 41c76000 r-xp /usr/lib/libdri2.so.0.0.0
41d8d000 41d8e000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
41d96000 41d98000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41da0000 41da1000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
41dbc000 41dc3000 r-xp /usr/lib/libfeedback.so.0.1.4
41dcc000 41dcd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
41dd5000 41dda000 rw-p [heap]
41dda000 41ef1000 rw-p [heap]
4367b000 43e7a000 rw-p [stack:7415]
43ed6000 43ed8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
43ee0000 43eea000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
43ef2000 43ef7000 r-xp /usr/lib/libmmfsession.so.0.0.0
4508d000 4598c000 rw-p [stack:7463]
459e8000 459ef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
459f7000 459ff000 r-xp /usr/lib/libmdm-common.so.1.0.89
45bb8000 45bce000 r-xp /usr/lib/libmmfsound.so.0.1.0
45be0000 45bea000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45bf6000 45bfa000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45c03000 45c18000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45c20000 45c81000 r-xp /usr/lib/libasound.so.2.0.0
45c8b000 45c8e000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45c96000 45cce000 r-xp /usr/lib/libpulse.so.0.16.2
45ccf000 45d00000 r-xp /usr/lib/libmdm.so.1.1.86
45d08000 45d0d000 r-xp /usr/lib/libjson.so.0.0.1
45d15000 45d5d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d5e000 45da5000 r-xp /usr/lib/libsndfile.so.1.0.26
45db1000 45dd3000 r-xp /usr/lib/libvorbis.so.0.4.3
45ddb000 45ddf000 r-xp /usr/lib/libogg.so.0.7.1
bea2f000 bea50000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7348)
Call Stack Count: 18
 0: app_create + 0x5d (0x41644b66) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b66
 1: clicked_redo_app + 0x24 (0x41644d3b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d3b
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
13: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x66 (0x41644c3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
15: create_base_gui + 0x4a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
16: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
17: clicked_end_app + 0x3 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [true][0m
11-10 13:15:15.970+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:15:15.975+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 765
11-10 13:15:15.980+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:15:16.000+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1779]   bundle_add_str() .. [0xffffffea][0m
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:15:16.000+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:16.005+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:16.005+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:15:16.005+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:15:16.010+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:15:16.010+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:16.015+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:16.015+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:15:16.015+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:15:16.025+0200 I/TIZEN_N_SOUND_MANAGER( 1779): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-10 13:15:16.030+0200 E/TIZEN_N_SOUND_MANAGER( 1779): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-10 13:15:16.030+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1779]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:16.030+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:16.265+0200 W/AUL     ( 7414): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:15:16.265+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:15:16.300+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 13:15:16.325+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 13:15:16.325+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 13:15:16.325+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 7414
11-10 13:15:16.345+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:15:16.350+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:15:16.350+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:15:16.350+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-10 13:15:16.350+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:15:16.425+0200 I/efl-extension( 7348): efl_extension.c: eext_mod_init(40) > Init
11-10 13:15:16.425+0200 I/CAPI_APPFW_APPLICATION( 7348): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:15:16.440+0200 I/CAPI_APPFW_APPLICATION( 7348): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:15:16.450+0200 W/AUL     ( 7414): launch.c: app_request_to_launchpad(282) > request cmd(0) result(7348)
11-10 13:15:16.600+0200 I/Bluetooth( 7348): [bt_initialize] success.
11-10 13:15:16.640+0200 I/Bluetooth( 7348): [bt_adapter_get_state] success.
11-10 13:15:16.765+0200 E/EFL     ( 7348): ecore_evas<7348> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:15:17.010+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 2
11-10 13:15:17.010+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
11-10 13:15:17.010+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:15:17.060+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
11-10 13:15:17.060+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
11-10 13:15:17.060+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
11-10 13:15:17.060+0200 E/STARTER (  720): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
11-10 13:15:17.060+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
11-10 13:15:17.060+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
11-10 13:15:17.080+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(204) > LCD off
11-10 13:15:17.080+0200 W/W_HOME  (  765): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-10 13:15:17.085+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:15:17.085+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 1
11-10 13:15:17.085+0200 W/W_HOME  (  765): event_manager.c: _lcd_off_cb(704) > lcd state: 0
11-10 13:15:17.085+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.315+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:15:17.390+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:15:17.390+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:15:17.390+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:15:17.390+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:15:17.390+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.390+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.390+0200 W/W_HOME  (  765): main.c: home_pause(766) > clock/widget paused
11-10 13:15:17.395+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_pause(554) > 
11-10 13:15:17.410+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
11-10 13:15:17.410+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:15:17.410+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
11-10 13:15:17.410+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[1]
11-10 13:15:17.435+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:15:17.435+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:17.440+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.455+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:15:17.455+0200 W/AUL_AMD (  504): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-10 13:15:17.575+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_pause(1028) > widget_pause
11-10 13:15:17.585+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:15:17.595+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7348
11-10 13:15:17.595+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:15:17.635+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:17.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.635+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:15:17.645+0200 I/APP_CORE( 7348): appcore-efl.c: __do_app(429) > [APP 7348] Event: RESET State: CREATED
11-10 13:15:17.645+0200 I/CAPI_APPFW_APPLICATION( 7348): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:15:17.675+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:17.675+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.680+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:15:17.680+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.680+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.680+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.720+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:15:17.735+0200 I/APP_CORE( 7348): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:15:17.735+0200 I/APP_CORE( 7348): appcore-efl.c: __do_app(474) > [APP 7348] Initial Launching, call the resume_cb
11-10 13:15:17.735+0200 I/CAPI_APPFW_APPLICATION( 7348): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:15:17.735+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:17.735+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.740+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:15:17.745+0200 W/APP_CORE( 7348): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
11-10 13:15:17.755+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:17.755+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.760+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:15:17.770+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:15:17.770+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:15:17.770+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:15:17.775+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:15:17.780+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:15:17.785+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:15:17.785+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:15:17.785+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:15:17.790+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:15:17.790+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:15:17.800+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:15:17.815+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:15:17.845+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:15:17.845+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:15:17.845+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:17.845+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:15:17.850+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: PAUSED
11-10 13:15:17.850+0200 I/APP_CORE(  765): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
11-10 13:15:17.850+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:15:17.865+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:15:17.865+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:15:17.865+0200 I/APP_CORE( 7348): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
11-10 13:15:17.925+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:17.925+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:17.950+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:15:17.990+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:15:17.995+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7348
11-10 13:15:18.000+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:15:18.090+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:18.090+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:18.095+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:18.165+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:15:18.255+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:15:18.260+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:15:18.290+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:15:18.290+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:15:18.345+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:15:18.350+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:15:18.350+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:15:18.355+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:15:18.355+0200 E/EFL     ( 7416): elementary<7416> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:15:18.375+0200 E/EFL     ( 7416): elementary<7416> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:15:18.380+0200 E/EFL     ( 7416): elementary<7416> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:15:18.380+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:15:18.420+0200 E/EFL     ( 7416): elementary<7416> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:15:18.425+0200 E/EFL     ( 7416): elementary<7416> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:15:18.425+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:15:18.425+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:15:18.425+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:15:18.425+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:15:18.425+0200 E/EFL     ( 7416): elementary<7416> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:15:18.425+0200 I/AUL_PAD ( 7416): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:15:18.625+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:19.625+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:20.630+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
11-10 13:15:20.630+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
11-10 13:15:20.630+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:15:20.640+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
11-10 13:15:20.640+0200 W/W_HOME  (  765): gesture.c: _manual_render_schedule(212) > schedule, manual render
11-10 13:15:20.685+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:20.700+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
11-10 13:15:20.705+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
11-10 13:15:20.705+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:15:20.705+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(186) > LCD on
11-10 13:15:20.705+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_set(165) > timer set
11-10 13:15:20.705+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:15:20.705+0200 W/W_HOME  (  765): gesture.c: _apps_status_get(126) > apps status:0
11-10 13:15:20.705+0200 W/W_HOME  (  765): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:3627
11-10 13:15:20.705+0200 W/W_HOME  (  765): gesture.c: _manual_render_schedule(212) > schedule, manual render
11-10 13:15:20.705+0200 W/W_HOME  (  765): event_manager.c: _lcd_on_cb(696) > lcd state: 1
11-10 13:15:20.705+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:15:20.710+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [3627]ms
11-10 13:15:20.710+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:15:20.745+0200 I/APP_CORE( 7348): appcore-efl.c: __do_app(429) > [APP 7348] Event: RESUME State: RUNNING
11-10 13:15:20.770+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
11-10 13:15:20.770+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
11-10 13:15:20.770+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : test_healthy_pace error
11-10 13:15:20.770+0200 W/SHealth_Service( 1107): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
11-10 13:15:20.870+0200 W/SHealth_Common( 1107): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1510272000000,000000[0;m
11-10 13:15:20.890+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:15:20.895+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:15:20.900+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (622030)]][0;m
11-10 13:15:20.915+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:15:20.915+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
11-10 13:15:20.915+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 0
11-10 13:15:20.915+0200 W/W_HOME  (  765): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-10 13:15:20.935+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:15:20.945+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
11-10 13:15:20.945+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:15:21.000+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
11-10 13:15:21.000+0200 W/SHealthWidget(  837): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (622030), msgName: timeline_summary_updated[0;m
11-10 13:15:21.000+0200 W/SHealth_Common(  837): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
11-10 13:15:21.005+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:15:21.010+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:15:21.020+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
11-10 13:15:21.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:15:21.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:15:21.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:15:21.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:15:21.050+0200 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-10 13:15:21.060+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_update_cb(281) > received updating signal
11-10 13:15:21.065+0200 E/EFL     (  837): edje<837> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
11-10 13:15:21.625+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:22.450+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:15:22.630+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:23.620+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:24.625+0200 I/INFO_TAG( 7348): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:15:25.630+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:15:25.690+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:15:26.060+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:26.625+0200 E/EFL     ( 7348): ecore_x<7348> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1730985 button=1
11-10 13:15:26.675+0200 E/EFL     ( 7348): ecore_x<7348> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1731038 button=1
11-10 13:15:26.840+0200 E/RECORDING_TAG( 7348): sensor_listener_unset_event_cb error: -38010874
11-10 13:15:26.845+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:15:26.870+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:15:27.230+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:27.625+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 HEART RATE : 81
11-10 13:15:27.675+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 TAB VALUE : 81
11-10 13:15:28.630+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 HEART RATE : 80
11-10 13:15:28.670+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 TAB VALUE : 80
11-10 13:15:29.640+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
11-10 13:15:29.640+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 HEART RATE : 77
11-10 13:15:29.660+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 TAB VALUE : 77
11-10 13:15:30.630+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 HEART RATE : 76
11-10 13:15:30.660+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 TAB VALUE : 76
11-10 13:15:31.640+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 HEART RATE : 74
11-10 13:15:31.655+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 TAB VALUE : 74
11-10 13:15:32.660+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 HEART RATE : 73
11-10 13:15:32.685+0200 I/INFO_TAG( 7348): SENSOR_EVENT2 TAB VALUE : 73
11-10 13:15:33.145+0200 E/EFL     ( 7348): ecore_x<7348> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1737512 button=1
11-10 13:15:33.180+0200 E/EFL     ( 7348): ecore_x<7348> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1737545 button=1
11-10 13:15:33.200+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:15:33.275+0200 I/Bluetooth( 7348): [bt_socket_create_rfcomm] success.
11-10 13:15:33.370+0200 I/BluetoothServer( 7348): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:15:33.405+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:15:33.765+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:37.915+0200 I/BluetoothServer( 7348): Callback: Connected.
11-10 13:15:37.925+0200 I/BluetoothServer( 7348): Callback: Socket of connection - 28.
11-10 13:15:37.925+0200 I/BluetoothServer( 7348): Callback: Role of connection - 1.
11-10 13:15:37.935+0200 I/BluetoothServer( 7348): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:15:37.940+0200 I/BluetoothServer( 7348): Sent: '`Ò…A680,000000 77,000000 76,000000 74,000000 73,000000 0,000000 '
11-10 13:15:38.010+0200 E/Bluetooth( 7348): [bt_socket_send_data] unknown error code : 64.
11-10 13:15:38.010+0200 E/Bluetooth( 7348): [bt_socket_send_data] unknown error code : 3.
11-10 13:15:38.010+0200 I/BluetoothServer( 7348): All data sent
11-10 13:15:38.010+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:15:38.040+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:15:38.180+0200 I/BluetoothServer( 7348): Callback: Disconnected.
11-10 13:15:38.180+0200 I/BluetoothServer( 7348): Callback: Socket of disconnection - 28.
11-10 13:15:38.180+0200 I/BluetoothServer( 7348): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:15:38.405+0200 E/EFL     ( 7348): elementary<7348> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:15:39.490+0200 E/EFL     ( 7348): ecore_x<7348> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1743854 button=1
11-10 13:15:39.535+0200 E/EFL     ( 7348): ecore_x<7348> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1743898 button=1
11-10 13:15:39.535+0200 I/Bluetooth( 7348): [bt_initialize] success.
11-10 13:15:39.570+0200 I/Bluetooth( 7348): [bt_adapter_get_state] success.
11-10 13:15:39.875+0200 W/CRASH_MANAGER( 7479): worker.c: worker_job(1205) > 1107348646174151031253
