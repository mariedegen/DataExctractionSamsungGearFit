S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18013
Date: 2017-10-16 21:43:44+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18013, uid 5000)

Register Information
r0   = 0x0000006b, r1   = 0x696c612f
r2   = 0xffffffff, r3   = 0xbee36f07
r4   = 0x4146bf6d, r5   = 0x416c77fc
r6   = 0x00000001, r7   = 0xbee36f10
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x41c2d900, fp   = 0x00000000
ip   = 0x0000612f, sp   = 0xbee36e60
lr   = 0x4146bff7, pc   = 0x4146bff8
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     45468 KB
Buffers:     52312 KB
Cached:     166388 KB
VmPeak:      97240 KB
VmSize:      95764 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18832 KB
VmRSS:       18828 KB
VmData:      39492 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25108 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 18013 TID = 18013
18013 18067 18068 18069 18070 

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
4146a000 4146d000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 4164e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41656000 4165a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41663000 4166b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4166c000 4168d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41696000 416c0000 r-xp /usr/lib/libsensor.so.1.9.6
416c9000 416db000 r-xp /usr/lib/libefl-assist.so.0.1.0
416e3000 4179b000 r-xp /usr/lib/libcairo.so.2.11200.14
417a6000 417b0000 r-xp /usr/lib/libsensord-shared.so
417b9000 417cb000 r-xp /usr/lib/libtts.so
417d3000 417f5000 r-xp /usr/lib/libui-extension.so.0.1.0
417fe000 41805000 r-xp /usr/lib/libtbm.so.1.0.0
4180d000 4181b000 r-xp /usr/lib/libGLESv2.so.2.0
41824000 41825000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4182e000 41834000 r-xp /usr/lib/libxcb-render.so.0.0.0
4183c000 4183f000 r-xp /usr/lib/libEGL.so.1.4
41847000 4184c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41854000 41857000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4185f000 41860000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41869000 419a6000 r-xp /usr/lib/libicui18n.so.51.1
419b6000 41a9a000 r-xp /usr/lib/libicuuc.so.51.1
41aaf000 41ab7000 r-xp /usr/lib/libdrm.so.2.4.0
41abf000 41ac1000 r-xp /usr/lib/libdri2.so.0.0.0
41ac9000 41acf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41ad7000 41adc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41ae4000 41afd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41b05000 41b26000 r-xp /usr/lib/libexif.so.12.3.3
41b39000 41b3b000 r-xp /usr/lib/libttrace.so.1.1
41b43000 41b48000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b50000 41b56000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41b5f000 41b67000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41b6f000 41b8b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b94000 41b96000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41b9e000 41cb5000 rw-p [heap]
4323e000 43245000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4324e000 43255000 r-xp /usr/lib/libminizip.so.1.0.0
4325d000 4326a000 r-xp /usr/lib/libail.so.0.1.0
43273000 4333d000 r-xp /usr/lib/libCOREGL.so.4.0
4354f000 4355a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43563000 43568000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4370e000 4370f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43717000 43719000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43722000 43f21000 rw-p [stack:18067]
43f22000 44721000 rw-p [stack:18068]
44722000 44f21000 rw-p [stack:18069]
44f22000 45721000 rw-p [stack:18070]
457d9000 457da000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
457f5000 457f6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45ab8000 45abf000 r-xp /usr/lib/libfeedback.so.0.1.4
45ac8000 45aca000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45ad2000 45adc000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45ae4000 45aeb000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45af3000 45b09000 r-xp /usr/lib/libmmfsound.so.0.1.0
45b1b000 45b20000 r-xp /usr/lib/libmmfsession.so.0.0.0
45b28000 45b32000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45b3e000 45b42000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45b4b000 45b60000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45b68000 45bc9000 r-xp /usr/lib/libasound.so.2.0.0
45bd3000 45bd6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45bde000 45c16000 r-xp /usr/lib/libpulse.so.0.16.2
45c17000 45c1a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45c22000 45c53000 r-xp /usr/lib/libmdm.so.1.1.86
45c5b000 45c60000 r-xp /usr/lib/libjson.so.0.0.1
45c68000 45cb0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45cb1000 45cf8000 r-xp /usr/lib/libsndfile.so.1.0.26
45d04000 45d0c000 r-xp /usr/lib/libmdm-common.so.1.0.89
45d0d000 45d2f000 r-xp /usr/lib/libvorbis.so.0.4.3
45d37000 45d3b000 r-xp /usr/lib/libogg.so.0.7.1
bee17000 bee38000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18013)
Call Stack Count: 15
 0: on_sensor_event_2 + 0x8b (0x4146bff8) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1ff8
 1: (0x4165782f) [/usr/lib/libcapi-system-sensor.so.0] + 0x182f
 2: (0x416aaaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 3: (0x403b5fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 4: g_main_context_dispatch + 0xbc (0x403b77a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 5: (0x402fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
 6: (0x402f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
 7: (0x402f95a7) [/usr/lib/libecore.so.1] + 0xc5a7
 8: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
 9: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
10: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
11: main + 0x10e (0x4146b627) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1627
12: create_base_gui + 0x212 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
13: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
14: create_base_gui + 0x587 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
e(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-16 21:43:30.872+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:30.872+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:30.872+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:30.877+0200 W/MUSIC_CONTROL_SERVICE(15150): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:15150]   [MUSIC_PLAYER_EVENT][0m
10-16 21:43:30.882+0200 W/W_HOME  (15003): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-16 21:43:30.882+0200 E/W_HOME  (15003): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-16 21:43:30.882+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(15150): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-16 21:43:30.882+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(15150): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-16 21:43:30.882+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(15150): preference.c: preference_get_int(1132) > preference_get_int(15150) : key(music-control-service_native/playing_diration) error
10-16 21:43:30.882+0200 W/MUSIC_CONTROL_SERVICE(15150): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:15150]   preference_get_int() .. [0xfef00030][0m
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-16 21:43:30.882+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:30.897+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:30.907+0200 I/TIZEN_N_SOUND_MANAGER(15150): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-16 21:43:30.907+0200 W/W_HOME  (15003): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-16 21:43:30.907+0200 E/W_HOME  (15003): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-16 21:43:30.907+0200 E/TIZEN_N_SOUND_MANAGER(15150): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-16 21:43:30.912+0200 W/MUSIC_CONTROL_SERVICE(15150): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:15150]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-16 21:43:30.912+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:30.927+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:31.027+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-16 21:43:31.027+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-16 21:43:31.027+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-16 21:43:31.027+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-16 21:43:31.027+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-16 21:43:31.032+0200 E/STARTER (  695): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-16 21:43:31.032+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-16 21:43:31.032+0200 W/STARTER (  695): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-16 21:43:31.037+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=3966027
10-16 21:43:31.132+0200 W/W_HOME  (15003): index.c: index_hide(331) > hide VI:1 visibility:0 vi:(nil)
10-16 21:43:31.177+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-16 21:43:31.177+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-16 21:43:31.177+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=3966180
10-16 21:43:31.177+0200 W/STARTER (  695): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-16 21:43:31.182+0200 W/STARTER (  695): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-16 21:43:31.192+0200 W/STARTER (  695): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-16 21:43:31.197+0200 W/STARTER (  695): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-16 21:43:31.202+0200 E/STARTER (  695): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-16 21:43:31.202+0200 W/AUL     (  695): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-16 21:43:31.207+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-16 21:43:31.212+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 695
10-16 21:43:31.222+0200 W/AUL_AMD (  535): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 15003
10-16 21:43:31.222+0200 I/APP_CORE(15003): appcore-efl.c: __do_app(429) > [APP 15003] Event: RESET State: RUNNING
10-16 21:43:31.222+0200 W/AUL_AMD (  535): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(13), pid(15003), cmd(0)
10-16 21:43:31.222+0200 I/CAPI_APPFW_APPLICATION(15003): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-16 21:43:31.222+0200 W/W_HOME  (15003): main.c: _app_control(1704) > Service value : powerkey
10-16 21:43:31.222+0200 I/wnotib  (15003): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-16 21:43:31.222+0200 I/wnotib  (15003): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-16 21:43:31.222+0200 W/W_HOME  (15003): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-16 21:43:31.222+0200 E/W_HOME  (15003): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-16 21:43:31.222+0200 W/W_HOME  (15003): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-16 21:43:31.222+0200 W/AUL     (  695): launch.c: app_request_to_launchpad(282) > request cmd(0) result(15003)
10-16 21:43:31.222+0200 W/W_HOME  (15003): move.c: move_move_to_apps(220) > move to apps
10-16 21:43:31.222+0200 E/AUL     (  695): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-16 21:43:31.222+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-16 21:43:31.227+0200 W/W_HOME  (15003): move.c: _create_fake_apps(823) > fake image position : 432
10-16 21:43:31.227+0200 W/W_HOME  (15003): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-16 21:43:31.227+0200 W/W_HOME  (15003): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-16 21:43:31.227+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.227+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.227+0200 I/APP_CORE(15003): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-16 21:43:31.227+0200 W/W_HOME  (15003): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-16 21:43:31.227+0200 W/W_HOME  (15003): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-16 21:43:31.227+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.232+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.232+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.232+0200 W/W_HOME  (15003): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-16 21:43:31.232+0200 W/W_HOME  (15003): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-16 21:43:31.232+0200 I/wnotib  (15003): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-16 21:43:31.232+0200 I/wnotib  (15003): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-16 21:43:31.267+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3966269 button=1
10-16 21:43:31.392+0200 W/W_HOME  (15003): event_manager.c: _home_scroll_cb(569) > scroll,start
10-16 21:43:31.427+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3966424 button=1
10-16 21:43:31.432+0200 W/W_HOME  (15003): event_manager.c: _clock_view_obscured_cb(626) > state: 1 -> 0
10-16 21:43:31.432+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.437+0200 W/SHealth_Common(15076): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:31.437+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:31.437+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-16 21:43:31.437+0200 I/CAPI_WIDGET_APPLICATION(15076): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-16 21:43:31.447+0200 W/W_HOME  (15003): index.c: index_show(293) > is_paused:0 show VI:1 visibility:0 vi:(nil)
10-16 21:43:31.457+0200 W/SHealth_Common(15076): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:31.457+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:31.462+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-16 21:43:31.462+0200 I/CAPI_WIDGET_APPLICATION(15076): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-16 21:43:31.477+0200 W/SHealth_Common(15076): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:31.477+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:31.477+0200 I/CAPI_WIDGET_APPLICATION(15076): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-16 21:43:31.477+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-16 21:43:31.492+0200 W/SHealth_Common(15076): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:31.497+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:31.497+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-16 21:43:31.497+0200 I/CAPI_WIDGET_APPLICATION(15076): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-16 21:43:31.512+0200 W/SHealth_Common(15076): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:31.512+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:31.512+0200 I/CAPI_WIDGET_APPLICATION(15076): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-16 21:43:31.517+0200 I/CAPI_WIDGET_APPLICATION(15076): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-16 21:43:31.527+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-16 21:43:31.542+0200 W/W_HOME  (15003): move.c: _transit_del_cb(115) > transit end
10-16 21:43:31.542+0200 W/W_HOME  (15003): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-16 21:43:31.542+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-16 21:43:31.542+0200 W/W_HOME  (15003): clock_indicator.c: clock_indicator_pause(554) > 
10-16 21:43:31.542+0200 I/wnotib  (15003): w-notification-board-panel-manager.c: _wnb_panel_manager_scroll_cb(83) > x is 0.
10-16 21:43:31.542+0200 W/wnotib  (15003): w-notification-board-noti-manager.c: wnb_nm_control_home_indicator(43) > unread_count: 0, is_home_indicator_displayed: 1, is_in_notiboard: 0
10-16 21:43:31.542+0200 W/W_HOME  (15003): noti_broker.c: _handler_noti_indicator_hide(499) > 
10-16 21:43:31.542+0200 W/W_HOME  (15003): clock_view_indicator.c: _view_remove_by_type(290) > removed:7
10-16 21:43:31.542+0200 W/W_HOME  (15003): clock_indicator.c: _indicator_pack_right(254) > item id : 6
10-16 21:43:31.542+0200 W/W_HOME  (15003): clock_indicator.c: _indicator_pack_right(258) > packed:r_2
10-16 21:43:31.542+0200 W/W_HOME  (15003): clock_indicator.c: clock_indicator_pop(493) > icon:1(1) is popped from clock indicator
10-16 21:43:31.557+0200 E/wnoti-service(  869): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(3101) > change_type : 0, value : 0
10-16 21:43:31.567+0200 W/W_HOME  (15003): move.c: _scroller_up_done(515) > up signal done
10-16 21:43:31.577+0200 W/W_HOME  (15003): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-16 21:43:31.577+0200 W/W_HOME  (15003): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-16 21:43:31.577+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:31.582+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:31.582+0200 W/W_HOME  (15003): main.c: home_pause(766) > clock/widget paused
10-16 21:43:31.582+0200 W/W_HOME  (15003): clock_indicator.c: clock_indicator_pause(554) > 
10-16 21:43:31.582+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:31.582+0200 W/W_HOME  (15003): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-16 21:43:31.582+0200 W/W_HOME  (15003): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-16 21:43:31.582+0200 I/wnotib  (15003): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-16 21:43:31.582+0200 I/wnotib  (15003): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-16 21:43:31.587+0200 E/APPS    (15003): apps_main.c: apps_main_resume(636) >  resumed already
10-16 21:43:31.597+0200 W/WATCH_CORE(14999): appcore-watch.c: __widget_pause(1028) > widget_pause
10-16 21:43:31.707+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.707+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.712+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.717+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.717+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.722+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.722+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.722+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group plus_item has a non-fixed part 'text'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.727+0200 E/EFL     (15003): edje<15003> edje_util.c:3770 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'remove_focus'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-16 21:43:31.732+0200 W/W_HOME  (15003): event_manager.c: _home_scroll_cb(569) > scroll,done
10-16 21:43:32.087+0200 W/W_HOME  (15003): index.c: index_hide(331) > hide VI:1 visibility:1 vi:(nil)
10-16 21:43:32.222+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-16 21:43:32.222+0200 W/AUL_AMD (  535): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-16 21:43:32.632+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3967637 button=1
10-16 21:43:32.632+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.632+0200 E/W_HOME  (15003): move.c: _mouse_down_cb(384) > apps move is not allowed
10-16 21:43:32.632+0200 W/APPS    (15003): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-16 21:43:32.647+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.657+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.657+0200 W/APPS    (15003): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-16 21:43:32.672+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.682+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.697+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.712+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.727+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:32.737+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3967740 button=1
10-16 21:43:32.737+0200 E/APPS    (15003): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-16 21:43:33.732+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3968735 button=1
10-16 21:43:33.732+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.737+0200 E/W_HOME  (15003): move.c: _mouse_down_cb(384) > apps move is not allowed
10-16 21:43:33.737+0200 W/APPS    (15003): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-16 21:43:33.757+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.767+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.782+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.792+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.807+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.822+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.852+0200 E/W_HOME  (15003): move.c: _mouse_move_cb(546) > apps move is not allowed
10-16 21:43:33.857+0200 E/EFL     (15003): ecore_x<15003> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3968863 button=1
10-16 21:43:33.862+0200 W/APPS    (15003): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-16 21:43:33.862+0200 E/APPS    (15003): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-16 21:43:33.862+0200 W/APPS    (15003): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-16 21:43:33.867+0200 W/AUL     (15003): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-16 21:43:33.867+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-16 21:43:33.872+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 15003
10-16 21:43:33.872+0200 I/AUL_AMD (  535): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-16 21:43:33.882+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(2124) > pad pid(-5)
10-16 21:43:33.882+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-16 21:43:33.882+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-16 21:43:33.882+0200 W/AUL_PAD ( 1190): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-16 21:43:33.882+0200 W/AUL_PAD ( 1190): launchpad.c: __send_result_to_caller(272) > Check app launching
10-16 21:43:33.927+0200 I/efl-extension(18013): efl_extension.c: eext_mod_init(40) > Init
10-16 21:43:33.927+0200 I/UXT     (18013): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-16 21:43:33.932+0200 I/CAPI_APPFW_APPLICATION(18013): app_main.c: ui_app_main(704) > app_efl_main
10-16 21:43:33.932+0200 I/CAPI_APPFW_APPLICATION(18013): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-16 21:43:33.987+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-16 21:43:33.987+0200 W/AUL     (15003): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18013)
10-16 21:43:33.987+0200 E/W_HOME  (15003): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-16 21:43:33.992+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-16 21:43:34.032+0200 E/EFL     (18013): ecore_evas<18013> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-16 21:43:34.297+0200 I/APP_CORE(18013): appcore-efl.c: __do_app(429) > [APP 18013] Event: RESET State: CREATED
10-16 21:43:34.297+0200 I/CAPI_APPFW_APPLICATION(18013): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-16 21:43:34.322+0200 I/APP_CORE(18013): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-16 21:43:34.322+0200 I/APP_CORE(18013): appcore-efl.c: __do_app(474) > [APP 18013] Initial Launching, call the resume_cb
10-16 21:43:34.322+0200 I/CAPI_APPFW_APPLICATION(18013): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-16 21:43:34.327+0200 W/W_HOME  (15003): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-16 21:43:34.327+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.327+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.327+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.357+0200 W/APP_CORE(18013): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00002
10-16 21:43:34.412+0200 W/W_HOME  (15003): event_manager.c: _window_visibility_cb(453) > Window [0x3200003] is now visible(1)
10-16 21:43:34.412+0200 W/W_HOME  (15003): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-16 21:43:34.412+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.412+0200 W/W_HOME  (15003): main.c: _window_visibility_cb(1211) > Window [0x3200003] is now visible(1)
10-16 21:43:34.417+0200 I/APP_CORE(15003): appcore-efl.c: __do_app(429) > [APP 15003] Event: PAUSE State: RUNNING
10-16 21:43:34.417+0200 I/CAPI_APPFW_APPLICATION(15003): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-16 21:43:34.417+0200 W/W_HOME  (15003): main.c: _appcore_pause_cb(696) > appcore pause
10-16 21:43:34.417+0200 W/W_HOME  (15003): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-16 21:43:34.417+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.417+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.417+0200 W/W_HOME  (15003): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-16 21:43:34.442+0200 E/W_HOME  (15003): page.c: page_access_highlight(667) > (!page_info->focus) -> page_access_highlight() return
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-16 21:43:34.442+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-16 21:43:34.447+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-16 21:43:34.447+0200 E/CAPI_APPFW_APP_CONTROL(15150): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-16 21:43:34.447+0200 W/MUSIC_CONTROL_SERVICE(15150): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:15150]   [com.samsung.w-home]register msg port [false][0m
10-16 21:43:34.452+0200 I/APP_CORE(18013): appcore-efl.c: __do_app(429) > [APP 18013] Event: RESUME State: RUNNING
10-16 21:43:34.507+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:34.507+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:34.507+0200 W/wnotib  (15003): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-16 21:43:34.687+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-16 21:43:34.687+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-16 21:43:34.687+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-16 21:43:34.757+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-16 21:43:34.947+0200 I/APP_CORE(15003): appcore-efl.c: __do_app(429) > [APP 15003] Event: MEM_FLUSH State: PAUSED
10-16 21:43:35.192+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.938
10-16 21:43:35.247+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-16 21:43:35.252+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18013
10-16 21:43:35.257+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-16 21:43:35.272+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18013
10-16 21:43:35.277+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-16 21:43:35.277+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:35.282+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-16 21:43:35.402+0200 E/EFL     (18071): elementary<18071> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-16 21:43:35.402+0200 E/EFL     (18071): elementary<18071> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-16 21:43:35.437+0200 E/EFL     (18071): elementary<18071> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-16 21:43:35.437+0200 E/EFL     (18071): elementary<18071> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-16 21:43:35.507+0200 E/EFL     (18071): elementary<18071> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-16 21:43:35.507+0200 E/EFL     (18071): elementary<18071> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-16 21:43:35.517+0200 E/EFL     (18071): elementary<18071> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-16 21:43:35.517+0200 E/EFL     (18071): elementary<18071> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-16 21:43:35.517+0200 E/EFL     (18071): elementary<18071> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-16 21:43:35.542+0200 E/EFL     (18071): elementary<18071> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-16 21:43:35.547+0200 E/EFL     (18071): elementary<18071> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-16 21:43:35.552+0200 E/EFL     (18071): elementary<18071> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-16 21:43:35.607+0200 E/EFL     (18071): elementary<18071> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-16 21:43:35.617+0200 E/EFL     (18071): elementary<18071> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-16 21:43:35.622+0200 E/EFL     (18071): elementary<18071> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-16 21:43:35.622+0200 E/EFL     (18071): elementary<18071> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-16 21:43:35.622+0200 E/EFL     (18071): elementary<18071> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-16 21:43:35.622+0200 E/EFL     (18071): elementary<18071> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-16 21:43:35.627+0200 E/EFL     (18071): elementary<18071> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-16 21:43:35.627+0200 I/AUL_PAD (18071): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-16 21:43:36.287+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:37.287+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:38.287+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:39.287+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:39.452+0200 I/APP_CORE(15003): appcore-efl.c: __do_app(429) > [APP 15003] Event: MEM_FLUSH State: PAUSED
10-16 21:43:40.287+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:41.207+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-16 21:43:41.287+0200 I/INFO_TAG(18013): HEART RATE < 40 : 0
10-16 21:43:42.292+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-16 21:43:42.342+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-16 21:43:42.707+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-16 21:43:43.387+0200 E/EFL     (18013): ecore_x<18013> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3978387 button=1
10-16 21:43:43.467+0200 E/EFL     (18013): ecore_x<18013> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3978469 button=1
10-16 21:43:43.702+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-16 21:43:43.722+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-16 21:43:44.077+0200 E/EFL     (18013): elementary<18013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-16 21:43:44.282+0200 I/INFO_TAG_SENSOR_EVENT2(18013): HEART RATE : 70
10-16 21:43:44.747+0200 W/CRASH_MANAGER(18095): worker.c: worker_job(1205) > 1118013646174150818302
