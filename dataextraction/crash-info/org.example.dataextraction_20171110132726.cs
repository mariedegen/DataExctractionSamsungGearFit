S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10766
Date: 2017-11-10 13:27:26+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 10766, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002a0e
r2   = 0x00000006, r3   = 0x00002a0e
r4   = 0x00000006, r5   = 0x000f5528
r6   = 0x4059cbec, r7   = 0x0000010c
r8   = 0x4143c9f0, r9   = 0x00000002
r10  = 0x00000088, fp   = 0xbeeaa3d8
ip   = 0x4143ceb0, sp   = 0xbeea9ca0
lr   = 0x404a76bc, pc   = 0x404a39e8
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     63672 KB
Buffers:     39052 KB
Cached:     160244 KB
VmPeak:      97432 KB
VmSize:      96324 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19540 KB
VmRSS:       19536 KB
VmData:      40372 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25032 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10766 TID = 10766
10766 10827 

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
435b8000 43db7000 rw-p [stack:10827]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
459cc000 459cf000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
459d7000 459d8000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
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
bee8a000 beeab000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10766)
Call Stack Count: 1
 0: gsignal + 0x3c (0x404a39e8) [/lib/libc.so.6] + 0x2c9e8
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
/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
11-10 13:26:25.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:25.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : test_healthy_pace error
11-10 13:26:25.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:25.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:26:25.265+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
11-10 13:26:25.265+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 0
11-10 13:26:25.265+0200 W/W_HOME  (  765): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-10 13:26:25.285+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:26:25.315+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
11-10 13:26:25.315+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:26:25.335+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:26:25.340+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:26:25.605+0200 W/AUL_AMD (  504): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:26.085+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.085+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:26:26.085+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [true][0m
11-10 13:26:26.095+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:26.100+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 765
11-10 13:26:26.150+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:26:26.150+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1779]   bundle_add_str() .. [0xffffffea][0m
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:26.150+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:26.205+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.205+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:26:26.205+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:26:26.225+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:26.225+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:26.270+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.270+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:26:26.270+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:26:26.275+0200 I/TIZEN_N_SOUND_MANAGER( 1779): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-10 13:26:26.295+0200 E/TIZEN_N_SOUND_MANAGER( 1779): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-10 13:26:26.300+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1779]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:26.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:26.325+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:26.610+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2390977 button=1
11-10 13:26:26.610+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:26:26.615+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:26:26.615+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-10 13:26:26.635+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:26:26.685+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:26:26.695+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2391062 button=1
11-10 13:26:26.695+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-10 13:26:26.695+0200 E/APPS    (  765): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-10 13:26:26.695+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-10 13:26:26.695+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:26:26.700+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:26:26.700+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 765
11-10 13:26:26.700+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
11-10 13:26:26.715+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
11-10 13:26:26.715+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:26:26.715+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:26:26.715+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:26:26.715+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:26:26.755+0200 I/efl-extension(10766): efl_extension.c: eext_mod_init(40) > Init
11-10 13:26:26.755+0200 I/CAPI_APPFW_APPLICATION(10766): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:26:26.760+0200 I/CAPI_APPFW_APPLICATION(10766): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:26:26.820+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:26:26.820+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10766)
11-10 13:26:26.820+0200 E/W_HOME  (  765): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
11-10 13:26:26.865+0200 I/Bluetooth(10766): [bt_initialize] success.
11-10 13:26:26.885+0200 I/Bluetooth(10766): [bt_adapter_get_state] success.
11-10 13:26:26.950+0200 E/EFL     (10766): ecore_evas<10766> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:26:27.255+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:26:27.255+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.255+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.255+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.265+0200 I/APP_CORE(10766): appcore-efl.c: __do_app(429) > [APP 10766] Event: RESET State: CREATED
11-10 13:26:27.265+0200 I/CAPI_APPFW_APPLICATION(10766): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:26:27.300+0200 I/APP_CORE(10766): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:26:27.305+0200 I/APP_CORE(10766): appcore-efl.c: __do_app(474) > [APP 10766] Initial Launching, call the resume_cb
11-10 13:26:27.305+0200 I/CAPI_APPFW_APPLICATION(10766): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:26:27.310+0200 W/APP_CORE(10766): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
11-10 13:26:27.400+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:26:27.400+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:26:27.400+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.400+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:26:27.400+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:26:27.400+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:26:27.400+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:26:27.400+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:26:27.400+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.405+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.405+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:27.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:27.405+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:26:27.405+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:26:27.410+0200 E/EFL     (  504): ecore_x<504> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2391777 button=1
11-10 13:26:27.410+0200 I/APP_CORE(10766): appcore-efl.c: __do_app(429) > [APP 10766] Event: RESUME State: RUNNING
11-10 13:26:27.480+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2391837 button=1
11-10 13:26:27.485+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:27.485+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:27.485+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:27.490+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:26:27.665+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:27.665+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:27.665+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:27.735+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:26:27.895+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:27.905+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10766
11-10 13:26:27.910+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:27.910+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:26:27.920+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.610
11-10 13:26:27.945+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:27.955+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10766
11-10 13:26:27.955+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:28.165+0200 E/EFL     (10839): elementary<10839> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:26:28.165+0200 E/EFL     (10839): elementary<10839> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:26:28.195+0200 E/EFL     (10839): elementary<10839> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:26:28.200+0200 E/EFL     (10839): elementary<10839> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:26:28.215+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:28.260+0200 E/EFL     (10839): elementary<10839> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:26:28.260+0200 E/EFL     (10839): elementary<10839> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:26:28.265+0200 E/EFL     (10839): elementary<10839> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:26:28.265+0200 E/EFL     (10839): elementary<10839> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:26:28.265+0200 E/EFL     (10839): elementary<10839> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:26:28.285+0200 E/EFL     (10839): elementary<10839> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:26:28.285+0200 E/EFL     (10839): elementary<10839> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:26:28.290+0200 E/EFL     (10839): elementary<10839> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:26:28.355+0200 E/EFL     (10839): elementary<10839> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:26:28.370+0200 E/EFL     (10839): elementary<10839> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:26:28.370+0200 E/EFL     (10839): elementary<10839> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:26:28.370+0200 E/EFL     (10839): elementary<10839> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:26:28.370+0200 E/EFL     (10839): elementary<10839> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:26:28.370+0200 E/EFL     (10839): elementary<10839> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:26:28.370+0200 E/EFL     (10839): elementary<10839> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:26:28.370+0200 I/AUL_PAD (10839): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:26:29.215+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:30.215+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:31.215+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:31.460+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:26:32.220+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:32.440+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:26:33.215+0200 I/INFO_TAG(10766): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:34.220+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:26:34.250+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:26:34.610+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:35.565+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2399928 button=1
11-10 13:26:35.705+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2400074 button=1
11-10 13:26:35.835+0200 E/RECORDING_TAG(10766): sensor_listener_unset_event_cb error: -38010874
11-10 13:26:35.840+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:26:35.865+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:26:36.225+0200 I/INFO_TAG(10766): SENSOR_EVENT2 HEART RATE : 64
11-10 13:26:36.240+0200 I/INFO_TAG(10766): SENSOR_EVENT2 TAB VALUE : 64
11-10 13:26:36.240+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:37.225+0200 I/INFO_TAG(10766): SENSOR_EVENT2 HEART RATE : 65
11-10 13:26:37.230+0200 I/INFO_TAG(10766): SENSOR_EVENT2 TAB VALUE : 65
11-10 13:26:38.220+0200 I/INFO_TAG(10766): SENSOR_EVENT2 HEART RATE : 66
11-10 13:26:38.225+0200 I/INFO_TAG(10766): SENSOR_EVENT2 TAB VALUE : 66
11-10 13:26:39.225+0200 I/INFO_TAG(10766): SENSOR_EVENT2 HEART RATE : 65
11-10 13:26:39.225+0200 I/INFO_TAG(10766): SENSOR_EVENT2 TAB VALUE : 65
11-10 13:26:40.220+0200 I/INFO_TAG(10766): SENSOR_EVENT2 HEART RATE : 67
11-10 13:26:40.225+0200 I/INFO_TAG(10766): SENSOR_EVENT2 TAB VALUE : 67
11-10 13:26:40.645+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2405012 button=1
11-10 13:26:40.710+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2405072 button=1
11-10 13:26:40.725+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:26:40.780+0200 I/Bluetooth(10766): [bt_socket_create_rfcomm] success.
11-10 13:26:40.845+0200 I/BluetoothServer(10766): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:26:40.880+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:26:41.230+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:42.975+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:26:51.410+0200 W/SHealth_Common( 1107): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1510272000000,000000[0;m
11-10 13:26:51.430+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (622030)]][0;m
11-10 13:26:51.470+0200 W/SHealthWidget(  837): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (622030), msgName: timeline_summary_updated[0;m
11-10 13:26:51.470+0200 W/SHealth_Common(  837): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
11-10 13:26:51.475+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
11-10 13:26:51.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:26:51.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:26:51.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:26:51.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:26:51.525+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_update_cb(281) > received updating signal
11-10 13:26:51.525+0200 E/EFL     (  837): edje<837> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
11-10 13:26:51.555+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
11-10 13:26:51.575+0200 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-10 13:26:53.620+0200 I/BluetoothServer(10766): Callback: Connected.
11-10 13:26:53.620+0200 I/BluetoothServer(10766): Callback: Socket of connection - 28.
11-10 13:26:53.620+0200 I/BluetoothServer(10766): Callback: Role of connection - 1.
11-10 13:26:53.620+0200 I/BluetoothServer(10766): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:26:53.620+0200 I/BluetoothServer(10766): Sent: '€œ4C€ãMA65,000000 66,000000 65,000000 67,000000 0,000000 '
11-10 13:26:53.655+0200 E/Bluetooth(10766): [bt_socket_send_data] unknown error code : 58.
11-10 13:26:53.655+0200 E/Bluetooth(10766): [bt_socket_send_data] unknown error code : 3.
11-10 13:26:53.655+0200 I/BluetoothServer(10766): All data sent
11-10 13:26:53.655+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:26:53.675+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:26:53.750+0200 I/BluetoothServer(10766): Callback: Disconnected.
11-10 13:26:53.755+0200 I/BluetoothServer(10766): Callback: Socket of disconnection - 28.
11-10 13:26:53.755+0200 I/BluetoothServer(10766): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:26:54.035+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:56.500+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2420865 button=1
11-10 13:26:56.560+0200 E/EFL     (10766): ecore_x<10766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2420925 button=1
11-10 13:26:56.570+0200 I/Bluetooth(10766): [bt_deinitialize] success.
11-10 13:26:56.585+0200 E/EFL     (10766): ecore_evas<10766> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:26:56.820+0200 W/APP_CORE(10766): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e000fe
11-10 13:26:57.125+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:57.125+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:57.130+0200 E/EFL     (10766): elementary<10766> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:57.240+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:26:57.295+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:27:00.500+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:27:00.505+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:27:23.685+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
11-10 13:27:23.700+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-10 13:27:26.115+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
11-10 13:27:26.120+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(204) > LCD off
11-10 13:27:26.120+0200 W/W_HOME  (  765): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-10 13:27:26.120+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:27:26.120+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 1
11-10 13:27:26.120+0200 W/W_HOME  (  765): event_manager.c: _lcd_off_cb(704) > lcd state: 0
11-10 13:27:26.120+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:27:26.130+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
11-10 13:27:26.130+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
11-10 13:27:26.135+0200 E/STARTER (  720): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
11-10 13:27:26.135+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
11-10 13:27:26.140+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
11-10 13:27:26.375+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:27:26.430+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:27:26.440+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:27:26.480+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
11-10 13:27:26.480+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:27:26.480+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
11-10 13:27:26.480+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
11-10 13:27:26.480+0200 E/ALARM_MANAGER(  720): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(10-11-2017, 13:27:46), repeat(1), interval(20), type(-1073741822)
11-10 13:27:26.495+0200 I/APP_CORE(10766): appcore-efl.c: __do_app(429) > [APP 10766] Event: PAUSE State: RUNNING
11-10 13:27:26.495+0200 I/CAPI_APPFW_APPLICATION(10766): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
11-10 13:27:26.525+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [720].
11-10 13:27:26.580+0200 E/ALARM_MANAGER(  481): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 964437467, next duetime: 1510313266
11-10 13:27:26.580+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(964437467)
11-10 13:27:26.585+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1510317900), due_time(1510313266)
11-10 13:27:26.585+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-10 13:27:26.585+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 10-11-2017, 11:27:46 (UTC).
11-10 13:27:26.585+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-10 13:27:26.585+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-10 13:27:26.590+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-10 13:27:26.605+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 22
11-10 13:27:26.605+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(916) > app status : 4
11-10 13:27:26.650+0200 E/APP_CORE(10766): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-10 13:27:26.650+0200 I/APP_CORE(10766): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-10 13:27:26.650+0200 I/CAPI_APPFW_APPLICATION(10766): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-10 13:27:26.650+0200 E/CAPI_NETWORK_BLUETOOTH(10766): bluetooth-common.c: bt_deinitialize(82) > [bt_deinitialize] NOT_INITIALIZED(0xfe400101)
11-10 13:27:26.650+0200 E/Bluetooth(10766): [bt_deinitialize] BT_ERROR_NOT_INITIALIZED 
11-10 13:27:26.655+0200 E/CAPI_NETWORK_BLUETOOTH(10766): bluetooth-socket.c: bt_socket_disconnect_rfcomm(218) > [bt_socket_disconnect_rfcomm] NOT_INITIALIZED(0xfe400101)
11-10 13:27:26.655+0200 E/Bluetooth(10766): [bt_socket_disconnect_rfcomm] BT_ERROR_NOT_INITIALIZED 
11-10 13:27:26.655+0200 E/CAPI_NETWORK_BLUETOOTH(10766): bluetooth-socket.c: bt_socket_disconnect_rfcomm(218) > [bt_socket_disconnect_rfcomm] NOT_INITIALIZED(0xfe400101)
11-10 13:27:26.655+0200 E/Bluetooth(10766): [bt_socket_disconnect_rfcomm] BT_ERROR_NOT_INITIALIZED 
11-10 13:27:27.050+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:27:27.050+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:27:27.065+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10766 pgid = 10766
11-10 13:27:27.140+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:27:27.215+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
11-10 13:27:27.215+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:27:27.215+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:27:27.215+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:27:27.240+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
11-10 13:27:27.240+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
11-10 13:27:27.240+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:27:27.240+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
11-10 13:27:27.240+0200 I/APP_CORE(  765): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
11-10 13:27:27.240+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
11-10 13:27:27.280+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:27:27.285+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10766
11-10 13:27:27.295+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.612
11-10 13:27:27.360+0200 W/CRASH_MANAGER(10902): worker.c: worker_job(1205) > 0610766646174151031324
