S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 11240
Date: 2017-11-10 13:29:29+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0xe6a2e100
r4   = 0xbea7f504, r5   = 0x41441980
r6   = 0x00000249, r7   = 0xbea7f440
r8   = 0xbea7f4d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbea7f428
lr   = 0x4176dcb7, pc   = 0x4176f230
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     63324 KB
Buffers:     39624 KB
Cached:     160496 KB
VmPeak:      91996 KB
VmSize:      91624 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16640 KB
VmRSS:       16636 KB
VmData:      38248 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23076 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 11240 TID = 11240
11240 11307 11314 11315 11316 

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
414a3000 414ad000 r-xp /lib/libnss_files-2.13.so
414b9000 414be000 rw-p [heap]
414be000 414df000 rw-p [heap]
414df000 41503000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4150c000 415db000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4176c000 41771000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41781000 417b3000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
417bc000 417c0000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417c9000 417ea000 r-xp /usr/lib/libefl-extension.so.0.1.0
417f3000 4182d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41836000 4184f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41857000 4185c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41864000 4188e000 r-xp /usr/lib/libsensor.so.1.9.6
41897000 4194f000 r-xp /usr/lib/libcairo.so.2.11200.14
4195a000 4195d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41965000 4196b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41974000 4197c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41984000 4198e000 r-xp /usr/lib/libsensord-shared.so
41997000 419a5000 r-xp /usr/lib/libGLESv2.so.2.0
419ae000 419af000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419b8000 419be000 r-xp /usr/lib/libxcb-render.so.0.0.0
419c6000 419c9000 r-xp /usr/lib/libEGL.so.1.4
419d1000 419de000 r-xp /usr/lib/libail.so.0.1.0
419e7000 41b24000 r-xp /usr/lib/libicui18n.so.51.1
41b34000 41c18000 r-xp /usr/lib/libicuuc.so.51.1
431b6000 431d2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431db000 431e2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431eb000 431ed000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431f5000 431fc000 r-xp /usr/lib/libminizip.so.1.0.0
43204000 432ce000 r-xp /usr/lib/libCOREGL.so.4.0
434e1000 43ce0000 rw-p [stack:11307]
43ce0000 43ceb000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43cf4000 43cf6000 r-xp /usr/lib/libdri2.so.0.0.0
43e00000 43e05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43e13000 43e1b000 r-xp /usr/lib/libdrm.so.2.4.0
43e23000 43e2a000 r-xp /usr/lib/libtbm.so.1.0.0
43ecd000 43ece000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43ed6000 43ed8000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43ee0000 43ee3000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43eeb000 43eec000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
44001000 44800000 rw-p [stack:11314]
44801000 45000000 rw-p [stack:11315]
45001000 45800000 rw-p [stack:11316]
bea5f000 bea80000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11240)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x4176f230) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3230
 1: app_terminate + 0x26 (0x4176dcb7) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1cb7
 2: (0x41440af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x4176dc3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
 6: create_base_gui + 0x4a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: clicked_end_app + 0x3 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
ppcore-intf.c: main(120) > ------------------------------------------------
11-10 13:29:19.240+0200 E/rpm-installer(11230): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
11-10 13:29:19.240+0200 E/rpm-installer(11230): rpm-appcore-intf.c: main(122) > ------------------------------------------------
11-10 13:29:19.240+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:29:19.240+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:19.240+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:19.240+0200 W/W_HOME  (  765): main.c: home_pause(766) > clock/widget paused
11-10 13:29:19.245+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_pause(554) > 
11-10 13:29:19.245+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
11-10 13:29:19.245+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
11-10 13:29:19.245+0200 E/STARTER (  720): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
11-10 13:29:19.245+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
11-10 13:29:19.245+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
11-10 13:29:19.280+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:29:19.285+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.290+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:29:19.290+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:29:19.300+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_pause(1028) > widget_pause
11-10 13:29:19.330+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:29:19.330+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.335+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:29:19.345+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: main(601) > OBSERVER start
11-10 13:29:19.360+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:29:19.360+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.360+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:29:19.375+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:29:19.375+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.380+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:29:19.385+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:29:19.390+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.390+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:29:19.405+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:29:19.405+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:29:19.410+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_pause_cb(298) > widget obj was paused
11-10 13:29:19.410+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:29:19.410+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:29:19.415+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:29:19.415+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:29:19.420+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
11-10 13:29:19.470+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:29:19.495+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:29:19.500+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
11-10 13:29:19.500+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:29:19.500+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
11-10 13:29:19.500+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
11-10 13:29:19.500+0200 E/ALARM_MANAGER(  720): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(10-11-2017, 13:29:40), repeat(1), interval(20), type(-1073741822)
11-10 13:29:19.500+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:29:19.505+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:29:19.505+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:29:19.505+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:29:19.505+0200 E/W_HOME  (  765): main.c: _pause_cb(674) > paused already
11-10 13:29:19.525+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [720].
11-10 13:29:19.540+0200 E/rpm-installer(11230): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
11-10 13:29:19.565+0200 E/rpm-installer(11230): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
11-10 13:29:19.565+0200 E/rpm-installer(11230): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
11-10 13:29:19.565+0200 E/rpm-installer(11230): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
11-10 13:29:19.570+0200 E/ALARM_MANAGER(  481): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 964424232, next duetime: 1510313380
11-10 13:29:19.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(964424232)
11-10 13:29:19.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1510317900), due_time(1510313380)
11-10 13:29:19.570+0200 E/rpm-installer(11230): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
11-10 13:29:19.570+0200 E/rpm-installer(11230): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
11-10 13:29:19.575+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-10 13:29:19.575+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 10-11-2017, 11:29:40 (UTC).
11-10 13:29:19.575+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-10 13:29:19.575+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-10 13:29:19.575+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-10 13:29:19.635+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
11-10 13:29:19.655+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[112290002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
11-10 13:29:19.665+0200 E/APPS    (  765): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
11-10 13:29:19.665+0200 E/APPS    (  765): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
11-10 13:29:19.680+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
11-10 13:29:19.690+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[112290002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
11-10 13:29:19.715+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
11-10 13:29:19.740+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:29:19.790+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:29:19.865+0200 W/CERT_SVC(11230): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
11-10 13:29:19.895+0200 E/rpm-installer(11230): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
11-10 13:29:19.895+0200 E/rpm-installer(11230): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
11-10 13:29:19.895+0200 E/rpm-installer(11230): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
11-10 13:29:19.895+0200 E/rpm-installer(11230): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
11-10 13:29:19.965+0200 E/PKGMGR_PARSER(11230): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
11-10 13:29:19.975+0200 E/PKGMGR_PARSER(11230): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
11-10 13:29:20.015+0200 E/PKGMGR_PARSER(11230): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
11-10 13:29:20.115+0200 I/PRIVACY-MANAGER-CLIENT(11230): SocketClient.cpp: SocketClient(37) > Client created
11-10 13:29:20.250+0200 I/efl-extension(11230): efl_extension.c: eext_mod_init(40) > Init
11-10 13:29:20.250+0200 I/efl-extension(11230): efl_extension.c: eext_mod_shutdown(46) > Shutdown
11-10 13:29:20.340+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
11-10 13:29:20.340+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
11-10 13:29:20.345+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
11-10 13:29:20.345+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
11-10 13:29:20.345+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
11-10 13:29:20.345+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
11-10 13:29:20.345+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
11-10 13:29:20.360+0200 E/PKGMGR_CERT(11230): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
11-10 13:29:20.370+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[112290002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
11-10 13:29:20.415+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:29:20.455+0200 E/rpm-installer(11230): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
11-10 13:29:20.465+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10839 pgid = 10839
11-10 13:29:20.480+0200 E/rpm-installer(11230): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
11-10 13:29:20.545+0200 E/rpm-installer(11230): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
11-10 13:29:20.565+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[112290002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
11-10 13:29:20.605+0200 E/rpm-installer(11230): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
11-10 13:29:20.625+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10839
11-10 13:29:20.630+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.624
11-10 13:29:20.645+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:29:20.690+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:29:20.690+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10553 pgid = -1
11-10 13:29:20.690+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:29:20.705+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10553
11-10 13:29:20.715+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.625
11-10 13:29:20.995+0200 E/EFL     (11240): elementary<11240> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:29:20.995+0200 E/EFL     (11240): elementary<11240> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:29:21.055+0200 E/EFL     (11240): elementary<11240> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:29:21.060+0200 E/EFL     (11240): elementary<11240> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:29:21.120+0200 E/EFL     (11240): elementary<11240> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:29:21.120+0200 E/EFL     (11240): elementary<11240> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:29:21.125+0200 E/EFL     (11240): elementary<11240> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:29:21.125+0200 E/EFL     (11240): elementary<11240> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:29:21.130+0200 E/EFL     (11240): elementary<11240> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:29:21.165+0200 E/EFL     (11240): elementary<11240> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:29:21.170+0200 E/EFL     (11240): elementary<11240> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:29:21.175+0200 E/EFL     (11240): elementary<11240> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:29:21.245+0200 E/EFL     (11240): elementary<11240> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:29:21.285+0200 E/EFL     (11240): elementary<11240> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:29:21.285+0200 E/EFL     (11240): elementary<11240> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:29:21.285+0200 E/EFL     (11240): elementary<11240> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:29:21.285+0200 E/EFL     (11240): elementary<11240> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:29:21.285+0200 E/EFL     (11240): elementary<11240> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:29:21.285+0200 E/EFL     (11240): elementary<11240> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:29:21.285+0200 I/AUL_PAD (11240): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:29:21.515+0200 I/efl-extension(11241): efl_extension.c: eext_mod_init(40) > Init
11-10 13:29:21.630+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[112290002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
11-10 13:29:21.635+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
11-10 13:29:21.645+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
11-10 13:29:21.645+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
11-10 13:29:21.695+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
11-10 13:29:21.700+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
11-10 13:29:21.700+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
11-10 13:29:21.700+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
11-10 13:29:21.700+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
11-10 13:29:21.700+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
11-10 13:29:21.700+0200 E/WMS     (  493): wms_db.c: wms_db_package_event_insert_record(177) > 
11-10 13:29:21.725+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
11-10 13:29:21.760+0200 E/PKGMGR_INFO(11229): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
11-10 13:29:21.775+0200 E/PKGMGR_OBSERVER(11229): pkg_observer.c: main(620) > OBSERVER end
11-10 13:29:21.790+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
11-10 13:29:21.790+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: sighandler(409) > child NORMAL exit [11229]
11-10 13:29:21.815+0200 E/STARTER (  720): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
11-10 13:29:21.830+0200 E/PKGMGR_INFO(  492): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
11-10 13:29:21.855+0200 W/APPS    (  765): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-10 13:29:21.855+0200 W/APPS    (  765): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
11-10 13:29:21.915+0200 E/EFL     (11241): elementary<11241> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:29:21.920+0200 E/EFL     (11241): elementary<11241> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:29:21.945+0200 E/EFL     (11241): elementary<11241> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:29:21.950+0200 I/UXT     (11241): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
11-10 13:29:21.950+0200 E/EFL     (11241): elementary<11241> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:29:22.010+0200 E/EFL     (11241): elementary<11241> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:29:22.010+0200 E/EFL     (11241): elementary<11241> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:29:22.015+0200 E/EFL     (11241): elementary<11241> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:29:22.015+0200 E/EFL     (11241): elementary<11241> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:29:22.020+0200 E/EFL     (11241): elementary<11241> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:29:22.035+0200 E/EFL     (11241): elementary<11241> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:29:22.040+0200 E/EFL     (11241): elementary<11241> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:29:22.040+0200 E/EFL     (11241): elementary<11241> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:29:22.080+0200 E/EFL     (11241): elementary<11241> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:29:22.095+0200 E/EFL     (11241): elementary<11241> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:29:22.095+0200 E/EFL     (11241): elementary<11241> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:29:22.095+0200 E/EFL     (11241): elementary<11241> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:29:22.095+0200 E/EFL     (11241): elementary<11241> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:29:22.095+0200 E/EFL     (11241): elementary<11241> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:29:22.095+0200 E/EFL     (11241): elementary<11241> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:29:22.095+0200 I/AUL_PAD (11241): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:29:22.785+0200 E/rpm-installer(11230): rpm-appcore-intf.c: main(273) > ------------------------------------------------
11-10 13:29:22.785+0200 E/rpm-installer(11230): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
11-10 13:29:22.785+0200 E/rpm-installer(11230): rpm-appcore-intf.c: main(275) > ------------------------------------------------
11-10 13:29:22.820+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: sighandler(409) > child NORMAL exit [11230]
11-10 13:29:22.925+0200 E/RESOURCED(  514): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/11230/oom_score_adj failed
11-10 13:29:22.925+0200 E/RESOURCED(  514): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 11230
11-10 13:29:23.635+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-10 13:29:23.645+0200 E/PKGMGR_SERVER(11086): pkgmgr-server.c: main(2221) > package manager server terminated.
11-10 13:29:24.510+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:29:25.235+0200 W/AUL     (11306): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:29:25.235+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:29:25.255+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 13:29:25.270+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 13:29:25.270+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 13:29:25.270+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 11306
11-10 13:29:25.285+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
11-10 13:29:25.285+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:29:25.285+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:29:25.285+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:29:25.285+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:29:25.335+0200 I/efl-extension(11240): efl_extension.c: eext_mod_init(40) > Init
11-10 13:29:25.340+0200 I/CAPI_APPFW_APPLICATION(11240): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:29:25.345+0200 I/CAPI_APPFW_APPLICATION(11240): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:29:25.390+0200 W/AUL     (11306): launch.c: app_request_to_launchpad(282) > request cmd(0) result(11240)
11-10 13:29:25.465+0200 I/Bluetooth(11240): [bt_initialize] success.
11-10 13:29:25.495+0200 I/Bluetooth(11240): [bt_adapter_get_state] success.
11-10 13:29:25.595+0200 E/EFL     (11240): ecore_evas<11240> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:29:25.905+0200 I/APP_CORE(11240): appcore-efl.c: __do_app(429) > [APP 11240] Event: RESET State: CREATED
11-10 13:29:25.905+0200 I/CAPI_APPFW_APPLICATION(11240): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:29:25.935+0200 I/APP_CORE(11240): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:29:25.935+0200 I/APP_CORE(11240): appcore-efl.c: __do_app(474) > [APP 11240] Initial Launching, call the resume_cb
11-10 13:29:25.935+0200 I/CAPI_APPFW_APPLICATION(11240): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:29:25.940+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:29:25.940+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:25.940+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:25.940+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:25.950+0200 W/APP_CORE(11240): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
11-10 13:29:26.045+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:29:26.045+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:29:26.045+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:29:26.045+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:29:26.060+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:29:26.060+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:29:26.060+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: PAUSED
11-10 13:29:26.060+0200 I/APP_CORE(  765): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
11-10 13:29:26.060+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:29:26.080+0200 I/APP_CORE(11240): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
11-10 13:29:26.280+0200 E/EFL     (11240): elementary<11240> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:29:26.280+0200 E/EFL     (11240): elementary<11240> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:29:26.280+0200 E/EFL     (11240): elementary<11240> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:29:26.375+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:29:26.540+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.631
11-10 13:29:26.565+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:29:26.575+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11240
11-10 13:29:26.575+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:29:26.590+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:29:26.605+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11240
11-10 13:29:26.610+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:29:26.775+0200 E/EFL     (11317): elementary<11317> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:29:26.775+0200 E/EFL     (11317): elementary<11317> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:29:26.805+0200 E/EFL     (11317): elementary<11317> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:29:26.810+0200 E/EFL     (11317): elementary<11317> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:29:26.860+0200 E/EFL     (11317): elementary<11317> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:29:26.860+0200 E/EFL     (11317): elementary<11317> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:29:26.865+0200 I/INFO_TAG(11240): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:29:26.870+0200 E/EFL     (11317): elementary<11317> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:29:26.870+0200 E/EFL     (11317): elementary<11317> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:29:26.870+0200 E/EFL     (11317): elementary<11317> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:29:26.910+0200 E/EFL     (11317): elementary<11317> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:29:26.915+0200 E/EFL     (11317): elementary<11317> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:29:26.915+0200 E/EFL     (11317): elementary<11317> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:29:26.970+0200 E/EFL     (11317): elementary<11317> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:29:26.980+0200 E/EFL     (11317): elementary<11317> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:29:26.980+0200 E/EFL     (11317): elementary<11317> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:29:26.985+0200 E/EFL     (11317): elementary<11317> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:29:26.985+0200 E/EFL     (11317): elementary<11317> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:29:26.985+0200 E/EFL     (11317): elementary<11317> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:29:26.985+0200 E/EFL     (11317): elementary<11317> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:29:26.985+0200 I/AUL_PAD (11317): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:29:27.865+0200 I/INFO_TAG(11240): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:29:28.865+0200 I/INFO_TAG(11240): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:29:29.025+0200 E/PKGMGR_SERVER(11361): pkgmgr-server.c: main(2167) > package manager server start
11-10 13:29:29.145+0200 E/PKGMGR_SERVER(11361): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1004119785], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[nnWPYehb08CwnJY5F3eag6XpMG8=], backend_flag=[0]
11-10 13:29:29.160+0200 E/PKGMGR_SERVER(11362): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
11-10 13:29:29.175+0200 E/PKGMGR  (11359): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
11-10 13:29:29.255+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:29:29.265+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11240
11-10 13:29:29.265+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:29:29.270+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(268) > request cmd(5) to(2278)
11-10 13:29:29.270+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:29:29.275+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(2278) is dead. cmd(5) is canceled
11-10 13:29:29.275+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:29:29.275+0200 E/PKGMGR_SERVER(11362): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:29:29.275+0200 E/PKGMGR_SERVER(11362): [0;m
11-10 13:29:29.275+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(268) > request cmd(5) to(2514)
11-10 13:29:29.275+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:29:29.275+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(2514) is dead. cmd(5) is canceled
11-10 13:29:29.275+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:29:29.275+0200 E/PKGMGR_SERVER(11362): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:29:29.275+0200 E/PKGMGR_SERVER(11362): [0;m
11-10 13:29:29.275+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(268) > request cmd(5) to(2876)
11-10 13:29:29.275+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:29:29.280+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(2876) is dead. cmd(5) is canceled
11-10 13:29:29.280+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:29:29.280+0200 E/PKGMGR_SERVER(11362): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:29:29.280+0200 E/PKGMGR_SERVER(11362): [0;m
11-10 13:29:29.280+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(268) > request cmd(5) to(3782)
11-10 13:29:29.280+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:29:29.280+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(3782) is dead. cmd(5) is canceled
11-10 13:29:29.280+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:29:29.280+0200 E/PKGMGR_SERVER(11362): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:29:29.280+0200 E/PKGMGR_SERVER(11362): [0;m
11-10 13:29:29.280+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(268) > request cmd(5) to(11240)
11-10 13:29:29.280+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:29:29.285+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(11240), cmd(4)
11-10 13:29:29.285+0200 W/AUL     (11362): launch.c: app_request_to_launchpad(282) > request cmd(5) result(0)
11-10 13:29:29.285+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:29:29.285+0200 I/APP_CORE(11240): appcore-efl.c: __do_app(429) > [APP 11240] Event: TERMINATE State: RUNNING
11-10 13:29:29.300+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11240
11-10 13:29:29.300+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 22
11-10 13:29:29.300+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(916) > app status : 4
11-10 13:29:29.355+0200 E/APP_CORE(11240): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-10 13:29:29.355+0200 I/APP_CORE(11240): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-10 13:29:29.355+0200 I/CAPI_APPFW_APPLICATION(11240): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-10 13:29:29.360+0200 I/Bluetooth(11240): [bt_deinitialize] success.
11-10 13:29:29.400+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:29:29.410+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11240
11-10 13:29:29.510+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:29:29.525+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
11-10 13:29:29.535+0200 E/PKGMGR_SERVER(11362): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
11-10 13:29:29.580+0200 E/PKGMGR_SERVER(11361): pkgmgr-server.c: sighandler(409) > child NORMAL exit [11362]
11-10 13:29:29.650+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:29:29.655+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:29:29.660+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:29:29.660+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:29:29.670+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:29:29.755+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 11240 pgid = 11240
11-10 13:29:29.780+0200 W/CRASH_MANAGER(11376): worker.c: worker_job(1205) > 1111240646174151031336
