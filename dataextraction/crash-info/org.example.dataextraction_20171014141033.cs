S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10882
Date: 2017-10-14 14:10:33+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x42ffac88, r3   = 0x40064114
r4   = 0xbe8f230c, r5   = 0x40057d30
r6   = 0x00000233, r7   = 0xbe8f21a0
r8   = 0xbe8f22dc, r9   = 0x40480c84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40059995, sp   = 0xbe8f2180
lr   = 0x40001ec5, pc   = 0x40001eca
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     60580 KB
Buffers:     40400 KB
Cached:     165524 KB
VmPeak:      55392 KB
VmSize:      55392 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       10984 KB
VmRSS:       10984 KB
VmData:       3312 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       22984 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40005000 40009000 r-xp /usr/lib/libsys-assert.so
40013000 40030000 r-xp /lib/ld-2.13.so
4004c000 40050000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
40058000 4005c000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
40065000 4006d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4006e000 40070000 r-xp /usr/lib/libdlog.so.0.0.0
40078000 40099000 r-xp /usr/lib/libefl-extension.so.0.1.0
400a2000 401dc000 r-xp /usr/lib/libelementary.so.1.7.99
401f3000 402c1000 r-xp /usr/lib/libevas.so.1.7.99
402e7000 40402000 r-xp /lib/libc-2.13.so
40410000 40418000 r-xp /lib/libgcc_s-4.6.so.1
40419000 40424000 r-xp /lib/libunwind.so.8.0.1
40451000 40453000 r-xp /lib/libdl-2.13.so
4045c000 40460000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40469000 4046b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40474000 40479000 r-xp /usr/lib/libappcore-efl.so.1.1
40481000 40486000 r-xp /usr/lib/libappcore-common.so.1.1
4048e000 4049a000 r-xp /usr/lib/libaul.so.0.1.0
404a4000 404c6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404ce000 4050f000 r-xp /usr/lib/libeina.so.1.7.99
40518000 4052c000 r-xp /lib/libpthread-2.13.so
40537000 40561000 r-xp /usr/lib/libsensor.so.1.9.6
4056a000 405fe000 r-xp /usr/lib/libstdc++.so.6.0.16
40611000 4067a000 r-xp /lib/libm-2.13.so
40683000 406d3000 r-xp /usr/lib/libecore_x.so.1.7.99
406d5000 406f7000 r-xp /usr/lib/libecore_evas.so.1.7.99
40700000 40709000 r-xp /usr/lib/libvconf.so.0.2.45
40711000 40739000 r-xp /usr/lib/libfontconfig.so.1.8.0
4073a000 40806000 r-xp /usr/lib/libxml2.so.2.7.8
40813000 408e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
408e4000 408f6000 r-xp /usr/lib/libefl-assist.so.0.1.0
408fe000 40915000 r-xp /usr/lib/libecore.so.1.7.99
4092c000 4098a000 r-xp /usr/lib/libedje.so.1.7.99
40993000 40a4b000 r-xp /usr/lib/libcairo.so.2.11200.14
40a56000 40b37000 r-xp /usr/lib/libX11.so.6.3.0
40b42000 40b4b000 r-xp /usr/lib/libXi.so.6.1.0
40b53000 40b6c000 r-xp /usr/lib/libeet.so.1.7.99
40b7d000 40b82000 r-xp /usr/lib/libecore_file.so.1.7.99
40b8a000 40b9b000 r-xp /usr/lib/libecore_input.so.1.7.99
40ba3000 40bac000 r-xp /usr/lib/libedbus.so.1.7.99
40bb4000 40bde000 r-xp /usr/lib/libdbus-1.so.3.8.12
40be7000 40c01000 r-xp /usr/lib/libecore_con.so.1.7.99
40c0a000 40c1d000 r-xp /usr/lib/libfribidi.so.0.3.1
40c25000 40c62000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40c6b000 40cc1000 r-xp /usr/lib/libfreetype.so.6.11.3
40ccd000 40d23000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d30000 40d36000 r-xp /usr/lib/libappsvc.so.0.1.0
40d3e000 40d41000 r-xp /usr/lib/libbundle.so.0.1.22
40d4a000 40d50000 r-xp /usr/lib/libecore_imf.so.1.7.99
40d58000 40d8c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40d95000 40d97000 r-xp /usr/lib/libiniparser.so.0
40da0000 40db7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40dbf000 40dc4000 r-xp /usr/lib/libxdgmime.so.1.1.0
40dcd000 40e09000 r-xp /usr/lib/libsystemd.so.0.4.0
40e12000 40e16000 r-xp /usr/lib/libproc-stat.so.0.2.86
40e1f000 40e35000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e3e000 40eb3000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ebd000 40ec3000 r-xp /lib/librt-2.13.so
40ecd000 40fa0000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40fab000 40fb1000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40fba000 40fc4000 r-xp /usr/lib/libsensord-shared.so
40fcd000 40fd4000 r-xp /usr/lib/libXcursor.so.1.0.2
40fdc000 40fde000 r-xp /usr/lib/libXdamage.so.1.1.0
40fe7000 40fe9000 r-xp /usr/lib/libXcomposite.so.1.0.0
40ff1000 40ff3000 r-xp /usr/lib/libXgesture.so.7.0.0
40ffb000 40ffe000 r-xp /usr/lib/libXfixes.so.3.1.0
41006000 41007000 r-xp /usr/lib/libXinerama.so.1.0.0
41010000 41016000 r-xp /usr/lib/libXrandr.so.2.2.0
4101e000 41024000 r-xp /usr/lib/libXrender.so.1.3.0
4102d000 41031000 r-xp /usr/lib/libXtst.so.6.1.0
41039000 41043000 r-xp /usr/lib/libXext.so.6.4.0
4104c000 41051000 r-xp /usr/lib/libecore_fb.so.1.7.99
4105a000 4105e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41067000 4106a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
41073000 41089000 r-xp /lib/libexpat.so.1.5.2
41093000 410a9000 r-xp /lib/libz.so.1.2.5
410b1000 410c3000 r-xp /usr/lib/libtts.so
410cb000 410ed000 r-xp /usr/lib/libui-extension.so.0.1.0
410f6000 410fd000 r-xp /usr/lib/libtbm.so.1.0.0
41106000 4110d000 r-xp /usr/lib/libembryo.so.1.7.99
41115000 4112c000 r-xp /usr/lib/liblua-5.1.so
41135000 41136000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4113e000 4114c000 r-xp /usr/lib/libGLESv2.so.2.0
41155000 4116d000 r-xp /usr/lib/libpng12.so.0.50.0
41176000 41177000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41180000 41186000 r-xp /usr/lib/libxcb-render.so.0.0.0
4118e000 411a1000 r-xp /usr/lib/libxcb.so.1.1.0
411aa000 411ad000 r-xp /usr/lib/libEGL.so.1.4
411b5000 411d8000 r-xp /usr/lib/libjpeg.so.8.0.2
411f1000 41235000 r-xp /usr/lib/libcurl.so.4.3.0
4123e000 4123f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41247000 4124c000 r-xp /usr/lib/libffi.so.5.0.10
41254000 4126c000 r-xp /usr/lib/liblzma.so.5.0.3
41275000 412f1000 r-xp /usr/lib/libgcrypt.so.20.0.3
412fd000 4130d000 r-xp /lib/libresolv-2.13.so
41311000 41313000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4131c000 4131e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41326000 41328000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41331000 41336000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4133e000 41341000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41349000 4134a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41353000 41490000 r-xp /usr/lib/libicui18n.so.51.1
414a0000 41584000 r-xp /usr/lib/libicuuc.so.51.1
4159a000 415a2000 r-xp /usr/lib/libdrm.so.2.4.0
415aa000 415ac000 r-xp /usr/lib/libdri2.so.0.0.0
415b4000 415b6000 r-xp /usr/lib/libXau.so.6.0.0
415be000 415c7000 r-xp /usr/lib/libcares.so.2.1.0
415d0000 415fe000 r-xp /usr/lib/libidn.so.11.5.44
41607000 4164e000 r-xp /usr/lib/libssl.so.1.0.0
4165a000 41803000 r-xp /usr/lib/libcrypto.so.1.0.0
41824000 4182f000 r-xp /usr/lib/libgpg-error.so.0.15.0
41837000 4183d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41845000 4184a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41853000 41857000 r-xp /usr/lib/libsmack.so.1.0.0
41860000 41879000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
42e0a000 42e2b000 r-xp /usr/lib/libexif.so.12.3.3
42e3e000 42e40000 r-xp /usr/lib/libttrace.so.1.1
42e49000 42e4e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e56000 42e5c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
42e65000 42e6d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
42e75000 42e91000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42e9b000 42ea2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42eab000 42ead000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42eb5000 42ee3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
42eec000 42ef3000 r-xp /usr/lib/libminizip.so.1.0.0
42efb000 42f08000 r-xp /usr/lib/libail.so.0.1.0
42f12000 42f2f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
42f38000 42f3a000 r-xp /usr/lib/libiri.so
42f42000 42f45000 r-xp /lib/libcap.so.2.21
42f4d000 42f54000 r-xp /lib/libcrypt-2.13.so
42f84000 42f87000 r-xp /lib/libattr.so.1.1.0
43095000 4315f000 r-xp /usr/lib/libCOREGL.so.4.0
43171000 43195000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4319e000 4326d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43283000 4328d000 r-xp /lib/libnss_files-2.13.so
be8d2000 be8f3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10882)
Call Stack Count: 9
 0: create_HRM_listener + 0x4d (0x40001eca) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1eca
 1: create_base_gui + 0x10 (0x40001771) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1771
 2: app_create + 0x32 (0x400016a3) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x16a3
 3: (0x4004d9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40477457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x4004e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x4000160b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x160b
 7: __libc_start_main + 0x114 (0x402fe82c) [/lib/libc.so.6] + 0x1782c
 8: (0x40001374) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1374
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
 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:30.010+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:30.010+0200 W/W_HOME  ( 1063): main.c: home_pause(766) > clock/widget paused
10-14 14:10:30.015+0200 W/W_HOME  ( 1063): clock_indicator.c: clock_indicator_pause(554) > 
10-14 14:10:30.015+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:30.015+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-14 14:10:30.015+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-14 14:10:30.015+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-14 14:10:30.015+0200 I/wnotib  ( 1063): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-14 14:10:30.015+0200 E/APPS    ( 1063): apps_main.c: apps_main_resume(636) >  resumed already
10-14 14:10:30.030+0200 W/WATCH_CORE( 1130): appcore-watch.c: __widget_pause(1028) > widget_pause
10-14 14:10:30.040+0200 W/SHealth_Common( 1156): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:30.040+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:30.040+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 14:10:30.045+0200 I/CAPI_WIDGET_APPLICATION( 1156): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 14:10:30.055+0200 W/SHealth_Common( 1156): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:30.055+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:30.060+0200 I/CAPI_WIDGET_APPLICATION( 1156): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 14:10:30.060+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 14:10:30.065+0200 W/SHealth_Common( 1156): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:30.070+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:30.070+0200 I/CAPI_WIDGET_APPLICATION( 1156): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 14:10:30.075+0200 W/SHealth_Common( 1156): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:30.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:30.075+0200 I/CAPI_WIDGET_APPLICATION( 1156): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 14:10:30.080+0200 W/SHealth_Common( 1156): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-14 14:10:30.080+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:30.085+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:30.085+0200 I/CAPI_WIDGET_APPLICATION( 1156): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-14 14:10:30.085+0200 I/CAPI_WIDGET_APPLICATION( 1156): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-14 14:10:30.095+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 14:10:30.095+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-14 14:10:30.250+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3312607 button=1
10-14 14:10:30.250+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:30.250+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:10:30.250+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-14 14:10:30.265+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:30.275+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:30.275+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 14:10:30.290+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:30.305+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:30.310+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:10:30.315+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3312672 button=1
10-14 14:10:30.315+0200 E/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 14:10:30.680+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:10:30.680+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 14:10:31.200+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3313558 button=1
10-14 14:10:31.200+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:31.200+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:10:31.205+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:10:31.265+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3313623 button=1
10-14 14:10:31.265+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:10:31.270+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:10:31.270+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:10:31.270+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:10:31.270+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:10:31.275+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:10:31.275+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:10:31.285+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:10:31.285+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:10:31.285+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:10:31.285+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 14:10:31.285+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:10:31.330+0200 I/efl-extension(10847): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:31.335+0200 I/UXT     (10847): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:31.335+0200 I/CAPI_APPFW_APPLICATION(10847): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:10:31.340+0200 I/CAPI_APPFW_APPLICATION(10847): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:10:31.390+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:10:31.390+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10847)
10-14 14:10:31.390+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:10:31.395+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:10:31.465+0200 W/CRASH_MANAGER(10835): worker.c: worker_job(1205) > 11108476461741507983031
10-14 14:10:32.280+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3314638 button=1
10-14 14:10:32.335+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3314690 button=1
10-14 14:10:32.440+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10847 pgid = 10847
10-14 14:10:32.450+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.722
10-14 14:10:32.500+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:10:32.505+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10847
10-14 14:10:32.510+0200 E/RESOURCED( 1005): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 14:10:32.510+0200 E/AUL     ( 1005): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 14:10:32.510+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:32.510+0200 E/RESOURCED( 1156): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 14:10:32.510+0200 E/AUL     ( 1156): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 14:10:32.510+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:32.515+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.723
10-14 14:10:33.200+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3315553 button=1
10-14 14:10:33.200+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:33.200+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:10:33.200+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:10:33.235+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:33.245+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:33.270+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:33.300+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:33.310+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:33.325+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3315680 button=1
10-14 14:10:33.325+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:10:33.325+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:10:33.325+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:10:33.325+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:10:33.325+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:10:33.325+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:10:33.325+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:10:33.340+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:10:33.340+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-14 14:10:33.340+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:10:33.340+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
10-14 14:10:33.340+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-14 14:10:33.345+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 10882
10-14 14:10:33.345+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:10:33.350+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:10:33.395+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 10882
10-14 14:10:33.395+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10882)
10-14 14:10:33.395+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:10:33.395+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:10:33.400+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:10:33.520+0200 I/efl-extension(10882): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:33.535+0200 I/CAPI_APPFW_APPLICATION(10882): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:10:33.545+0200 E/EFL     (10882): elementary<10882> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:33.545+0200 E/EFL     (10882): elementary<10882> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:33.585+0200 E/EFL     (10882): elementary<10882> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:33.590+0200 I/UXT     (10882): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:33.590+0200 E/EFL     (10882): elementary<10882> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:33.635+0200 E/EFL     (10882): elementary<10882> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:33.635+0200 E/EFL     (10882): elementary<10882> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:33.635+0200 E/EFL     (10882): elementary<10882> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:33.635+0200 E/EFL     (10882): elementary<10882> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:33.635+0200 E/EFL     (10882): elementary<10882> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:33.665+0200 E/EFL     (10882): elementary<10882> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:33.665+0200 E/EFL     (10882): elementary<10882> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:33.665+0200 E/EFL     (10882): elementary<10882> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:33.715+0200 E/EFL     (10882): elementary<10882> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:33.720+0200 E/EFL     (10882): elementary<10882> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:33.720+0200 E/EFL     (10882): elementary<10882> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:33.720+0200 E/EFL     (10882): elementary<10882> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:33.720+0200 E/EFL     (10882): elementary<10882> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:33.720+0200 E/EFL     (10882): elementary<10882> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:33.720+0200 E/EFL     (10882): elementary<10882> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:33.785+0200 I/CAPI_APPFW_APPLICATION(10882): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:10:33.885+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
10-14 14:10:34.095+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3316449 button=1
10-14 14:10:34.140+0200 W/AUL     (10888): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-14 14:10:34.140+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:10:34.145+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:10:34.145+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10882
10-14 14:10:34.145+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:10:34.155+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10882
10-14 14:10:34.220+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3316578 button=1
10-14 14:10:34.255+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:34.260+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:34.280+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:34.290+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:34.335+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:10:34.335+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:34.335+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:10:34.335+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:34.690+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3317048 button=1
10-14 14:10:34.690+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:34.695+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:10:34.695+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:10:34.810+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3317164 button=1
10-14 14:10:34.810+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:10:34.810+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:10:34.810+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:10:34.810+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:10:34.810+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:10:34.810+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:10:34.810+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:10:34.825+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:10:34.825+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:10:34.825+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:10:34.825+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-14 14:10:34.825+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:10:34.825+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
10-14 14:10:34.825+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-14 14:10:34.830+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 10893
10-14 14:10:34.905+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 10893
10-14 14:10:34.905+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:10:34.910+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10893)
10-14 14:10:34.910+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:10:34.930+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:10:34.950+0200 I/efl-extension(10893): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:34.965+0200 I/CAPI_APPFW_APPLICATION(10893): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:10:34.980+0200 E/EFL     (10893): elementary<10893> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:34.980+0200 E/EFL     (10893): elementary<10893> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:35.005+0200 E/EFL     (10893): elementary<10893> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:35.010+0200 I/UXT     (10893): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:35.010+0200 E/EFL     (10893): elementary<10893> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:35.040+0200 E/EFL     (10893): elementary<10893> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:35.040+0200 E/EFL     (10893): elementary<10893> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:35.045+0200 E/EFL     (10893): elementary<10893> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:35.045+0200 E/EFL     (10893): elementary<10893> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:35.045+0200 E/EFL     (10893): elementary<10893> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:35.065+0200 E/EFL     (10893): elementary<10893> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:35.065+0200 E/EFL     (10893): elementary<10893> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:35.065+0200 E/EFL     (10893): elementary<10893> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:35.095+0200 E/EFL     (10893): elementary<10893> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:35.105+0200 E/EFL     (10893): elementary<10893> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:35.105+0200 E/EFL     (10893): elementary<10893> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:35.105+0200 E/EFL     (10893): elementary<10893> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:35.105+0200 E/EFL     (10893): elementary<10893> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:35.105+0200 E/EFL     (10893): elementary<10893> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:35.105+0200 E/EFL     (10893): elementary<10893> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:35.150+0200 I/CAPI_APPFW_APPLICATION(10893): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:10:35.280+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3317634 button=1
10-14 14:10:35.350+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:35.355+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:35.355+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:35.360+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:35.375+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:10:35.375+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:35.375+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:10:35.375+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:35.380+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3317737 button=1
10-14 14:10:35.450+0200 E/EFL     (10878): elementary<10878> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:35.450+0200 E/EFL     (10878): elementary<10878> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:35.465+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 14:10:35.465+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 14:10:35.465+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:10:35.465+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-14 14:10:35.465+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-14 14:10:35.465+0200 E/wnoti-service(  838): wnoti-native-client.c: handle_cache_notification(603) > >>
10-14 14:10:35.490+0200 W/SHealth_Service( 1005): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-14 14:10:35.545+0200 W/AUL     (10897): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-14 14:10:35.545+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:10:35.545+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:10:35.545+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10893
10-14 14:10:35.545+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:10:35.545+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10893
10-14 14:10:35.685+0200 E/EFL     (10878): elementary<10878> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:35.685+0200 E/EFL     (10878): elementary<10878> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:35.695+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3318051 button=1
10-14 14:10:35.810+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3318167 button=1
10-14 14:10:35.870+0200 E/EFL     (10878): elementary<10878> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:35.870+0200 E/EFL     (10878): elementary<10878> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:35.895+0200 E/EFL     (10878): elementary<10878> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:35.895+0200 E/EFL     (10878): elementary<10878> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:35.895+0200 E/EFL     (10878): elementary<10878> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:36.025+0200 E/EFL     (10878): elementary<10878> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:36.025+0200 E/EFL     (10878): elementary<10878> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:36.025+0200 E/EFL     (10878): elementary<10878> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:36.150+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3318507 button=1
10-14 14:10:36.150+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:36.150+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:10:36.150+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:10:36.215+0200 E/EFL     (10878): elementary<10878> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:36.230+0200 E/EFL     (10878): elementary<10878> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:36.230+0200 E/EFL     (10878): elementary<10878> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:36.230+0200 E/EFL     (10878): elementary<10878> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:36.230+0200 E/EFL     (10878): elementary<10878> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:36.230+0200 E/EFL     (10878): elementary<10878> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:36.230+0200 E/EFL     (10878): elementary<10878> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:36.230+0200 I/AUL_PAD (10878): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:10:36.295+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3318649 button=1
10-14 14:10:36.295+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:10:36.295+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:10:36.295+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:10:36.295+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:10:36.295+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:10:36.295+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:10:36.295+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:10:36.310+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:10:36.310+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:10:36.310+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:10:36.310+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-14 14:10:36.310+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:10:36.310+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
10-14 14:10:36.310+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-14 14:10:36.310+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 10900
10-14 14:10:36.360+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 10900
10-14 14:10:36.365+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10900)
10-14 14:10:36.365+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:10:36.365+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:10:36.370+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:10:36.435+0200 I/efl-extension(10900): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:36.465+0200 I/CAPI_APPFW_APPLICATION(10900): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:10:36.475+0200 E/EFL     (10900): elementary<10900> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:36.475+0200 E/EFL     (10900): elementary<10900> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:36.495+0200 E/EFL     (10900): elementary<10900> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:36.495+0200 I/UXT     (10900): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:36.495+0200 E/EFL     (10900): elementary<10900> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:36.530+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3318884 button=1
10-14 14:10:36.535+0200 E/EFL     (10900): elementary<10900> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:36.535+0200 E/EFL     (10900): elementary<10900> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:36.535+0200 E/EFL     (10900): elementary<10900> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:36.535+0200 E/EFL     (10900): elementary<10900> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:36.535+0200 E/EFL     (10900): elementary<10900> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:36.555+0200 E/EFL     (10900): elementary<10900> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:36.555+0200 E/EFL     (10900): elementary<10900> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:36.555+0200 E/EFL     (10900): elementary<10900> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:36.590+0200 E/EFL     (10900): elementary<10900> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:36.595+0200 E/EFL     (10900): elementary<10900> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:36.595+0200 E/EFL     (10900): elementary<10900> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:36.595+0200 E/EFL     (10900): elementary<10900> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:36.595+0200 E/EFL     (10900): elementary<10900> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:36.595+0200 E/EFL     (10900): elementary<10900> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:36.595+0200 E/EFL     (10900): elementary<10900> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:36.650+0200 I/CAPI_APPFW_APPLICATION(10900): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:10:36.685+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3319040 button=1
10-14 14:10:36.830+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:36.840+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:36.840+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:36.845+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:36.850+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:10:36.850+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:36.850+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:10:36.850+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:36.930+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3319288 button=1
10-14 14:10:37.060+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3319418 button=1
10-14 14:10:37.075+0200 W/AUL     (10905): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-14 14:10:37.075+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:10:37.075+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:10:37.075+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10900
10-14 14:10:37.075+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:10:37.090+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10900
10-14 14:10:37.220+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3319575 button=1
10-14 14:10:37.335+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3319692 button=1
10-14 14:10:37.650+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3320005 button=1
10-14 14:10:37.650+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:37.650+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:10:37.650+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:10:37.685+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:37.755+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:10:37.765+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3320122 button=1
10-14 14:10:37.765+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:10:37.765+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:10:37.765+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:10:37.765+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:10:37.770+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:10:37.770+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:10:37.770+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:10:37.780+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:10:37.780+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 14:10:37.780+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:10:37.785+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:10:37.785+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:10:37.825+0200 I/efl-extension(10878): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:37.825+0200 I/UXT     (10878): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:37.830+0200 I/CAPI_APPFW_APPLICATION(10878): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:10:37.830+0200 I/CAPI_APPFW_APPLICATION(10878): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:10:37.885+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10878)
10-14 14:10:37.885+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:10:37.895+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:10:37.900+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:10:37.975+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3320331 button=1
10-14 14:10:38.030+0200 W/CRASH_MANAGER(10835): worker.c: worker_job(1205) > 1110882646174150798303
