S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10893
Date: 2017-10-14 14:10:35+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x42ffac88, r3   = 0x40064114
r4   = 0xbe8df30c, r5   = 0x40057d30
r6   = 0x00000233, r7   = 0xbe8df1a0
r8   = 0xbe8df2dc, r9   = 0x40480c84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40059995, sp   = 0xbe8df180
lr   = 0x40001ec5, pc   = 0x40001eca
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     59116 KB
Buffers:     40412 KB
Cached:     166508 KB
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
be8bf000 be8e0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10893)
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
0940): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 14:10:41.430+0200 I/APP_CORE(10940): appcore-efl.c: __do_app(474) > [APP 10940] Initial Launching, call the resume_cb
10-14 14:10:41.430+0200 I/CAPI_APPFW_APPLICATION(10940): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:10:41.445+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(177) > [_battery_charger_status_changed_cb:177] TA connected or abnormal
10-14 14:10:41.445+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(195) > [_battery_charger_status_changed_cb:195] Show Moment View to display charging animation
10-14 14:10:41.450+0200 W/APP_CORE(10940): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000002
10-14 14:10:41.465+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 14:10:41.465+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 14:10:41.475+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:41.485+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 14:10:41.500+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:10:41.500+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 14:10:41.500+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 14:10:41.500+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 14:10:41.500+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 14:10:41.510+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:10:41.510+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 14:10:41.580+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.740
10-14 14:10:41.590+0200 W/W_CLOCK_VIEWER(10940): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(194) >  get_info_cb called err[0], context[45], data[{ "Time" : 1507983041414, "Reason" : 0, "Status" : 2 }], req_id[2]
10-14 14:10:41.590+0200 W/W_CLOCK_VIEWER(10940): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(214) >  status[2] Wear OFF
10-14 14:10:41.590+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: __clock_viewer_lcdon_completed_cb(471) >  event lcdon completed[1]
10-14 14:10:41.590+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[1]
10-14 14:10:41.590+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: clock_viewer_hide(1298) >  reservied[0], gesture[0], clock visible[0]
10-14 14:10:41.590+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: _clock_viewer_send_clock_changed(919) >  clock changed <<
10-14 14:10:41.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 14:10:41.610+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:41.625+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.625+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 14:10:41.625+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 14:10:41.630+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:10:41.630+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 14:10:41.630+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 14:10:41.630+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 14:10:41.630+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 14:10:41.630+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.650+0200 E/DATA_PROVIDER_MASTER(  706): package.c: package_alter_instances_to_client(1695) > Failed to load a buffer
10-14 14:10:41.655+0200 E/DATA_PROVIDER_MASTER(  706): shared_fd_service.c: direct_hello_handler(66) > Client is not exists: 
10-14 14:10:41.655+0200 E/WIDGET_VIEWER(10940): client.c: master_created(1712) > [31,331347] pkgname: com.samsung.idle-clock-volt_sparkle, id: file:///opt/usr/share/live_magazine/com.samsung.idle-clock-volt_sparkle_1063_31,331347.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 216, widget_h: 432, cluster: user,created, category: default, widget_fname: "pixmap://29360130:4", gbar_fname: "", auto_launch: , priority: 0,000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0,000000, title: [], is_pinned_up: 0
10-14 14:10:41.670+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_show(1505) > [windicator_moment_view_show:1505] Show Moment View : type(1)
10-14 14:10:41.670+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1648) > [windicator_init_battery_rect:1648] battery level 100, index 20, bg level 100
10-14 14:10:41.670+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1652) > [windicator_init_battery_rect:1652] Battery signal emit : bg_level_90
10-14 14:10:41.680+0200 E/WIDGET_EVAS(10940): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-14 14:10:41.680+0200 W/W_CLOCK_VIEWER(10940): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(257) >  DBOX Created[com.samsung.idle-clock-volt_sparkle] it should be [com.samsung.idle-clock-volt_sparkle]
10-14 14:10:41.680+0200 W/W_CLOCK_VIEWER(10940): clock-viewer-dbox.c: _clock_viewer_widget_list_append(128) >  >>>Append to list[com.samsung.idle-clock-volt_sparkle][0x41778f40]
10-14 14:10:41.690+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] PRE LCD ON - charge
10-14 14:10:41.700+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:41.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.735+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 14:10:41.735+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 14:10:41.760+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 14:10:41.760+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.760+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.760+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.795+0200 W/APP_CORE(  714): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000a
10-14 14:10:41.795+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:10:41.805+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 14:10:41.805+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 14:10:41.805+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 14:10:41.805+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 14:10:41.840+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 14:10:41.840+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.840+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 14:10:41.845+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:41.850+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.865+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:10:41.865+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:10:41.865+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:10:41.865+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 14:10:41.865+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:10:41.880+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 14:10:41.880+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 14:10:41.880+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 14:10:41.885+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 14:10:41.895+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:10:41.910+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_get_angle(613) > [_windicator_get_angle:613] Unknown state(0)
10-14 14:10:41.910+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(650) > [_windicator_rotation_changed_cb:650] invliad state, Add timer :0 angle:-1
10-14 14:10:41.920+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(657) > [_windicator_rotation_changed_cb:657] Got specific angle, so delete timer!
10-14 14:10:41.920+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:2 angle:3 / is_connected : 1
10-14 14:10:41.920+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(688) > [_windicator_rotation_changed_cb:688] [ROTATION] Refresh angle value only for 90`, 270`
10-14 14:10:41.920+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_angle_changed(1600) > [windicator_moment_view_angle_changed:1600] [Rotation] Angle : 3 (check 1,3)
10-14 14:10:41.920+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 14:10:41.920+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 14:10:41.925+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 14:10:41.925+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 14:10:41.925+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 14:10  /5 / HH:mm
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 14:10
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 14
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 10
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  14
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  10
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 14 / 10 / 14:10
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 14:10:41.930+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_charging_watch_ui_show(1442) > [windicator_moment_view_charging_watch_ui_show:1442] [Rotation] Degree : 90
10-14 14:10:41.930+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:10:41.950+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 14:10:41.965+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:41.970+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10955
10-14 14:10:41.975+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:10:41.975+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:10:41.980+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:10:41.980+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 14:10:41.980+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 14:10:42.250+0200 E/EFL     (10964): elementary<10964> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:42.250+0200 E/EFL     (10964): elementary<10964> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:42.275+0200 E/EFL     (10964): elementary<10964> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:42.280+0200 E/EFL     (10964): elementary<10964> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:42.290+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:42.300+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10957
10-14 14:10:42.350+0200 E/EFL     (10964): elementary<10964> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:42.350+0200 E/EFL     (10964): elementary<10964> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:42.350+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 14:10:42.350+0200 E/EFL     (10964): elementary<10964> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:42.350+0200 E/EFL     (10964): elementary<10964> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:42.385+0200 E/EFL     (10964): elementary<10964> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:42.420+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:10:42.525+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:42.535+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10955
10-14 14:10:42.575+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:10:42.605+0200 W/WG-CONSUMER(10955): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
10-14 14:10:42.605+0200 W/WG-CONSUMER(10955): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
10-14 14:10:42.605+0200 W/WG-CONSUMER(10955): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
10-14 14:10:42.605+0200 W/WG-CONSUMER(10955): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 14:10:42.655+0200 W/WG-CONSUMER(10955): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-14 14:10:42.655+0200 I/CAPI_CONTENT_MEDIA_CONTENT(10955): media_content.c: media_content_connect(870) > [32m[10955]ref count : 0
10-14 14:10:42.680+0200 I/CAPI_CONTENT_MEDIA_CONTENT(10955): media_content.c: media_content_connect(902) > [32m[10955]ref count changed to: 1
10-14 14:10:42.680+0200 W/WG-CONSUMER(10955): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-14 14:10:42.710+0200 E/EFL     (10964): elementary<10964> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:42.710+0200 E/EFL     (10964): elementary<10964> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:42.710+0200 E/EFL     (10964): elementary<10964> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 14:10:42.725+0200 E/WG-CONSUMER(10955): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-14 14:10:42.725+0200 W/WG-CONSUMER(10955): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42eaf8d0[0m
10-14 14:10:42.725+0200 W/CAPI_APPFW_APP_CONTROL(10955): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 14:10:42.725+0200 W/CAPI_APPFW_APP_CONTROL(10955): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 14:10:42.840+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 14:10:42.840+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 14:10:42.840+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 14:10:42.840+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-14 14:10:42.895+0200 W/WG-CONSUMER(10955): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-14 14:10:42.895+0200 I/CAPI_APPFW_APPLICATION(10955): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 14:10:42.910+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 14:10:42.910+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 14:10:42.930+0200 E/WIPC_SERVER(10955): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 14:10:42.930+0200 W/WG-CONSUMER(10955): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 14:10:42.945+0200 I/CAPI_CONTENT_MEDIA_CONTENT(10955): media_content.c: media_content_disconnect(958) > [32m[10955]ref count changed to: 0
10-14 14:10:42.990+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:43.000+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10940
10-14 14:10:43.005+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:10:43.060+0200 E/WG-CONSUMER(10955): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-14 14:10:43.060+0200 W/WG-CONSUMER(10955): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-14 14:10:43.060+0200 W/WG-CONSUMER(10955): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-14 14:10:43.060+0200 W/WG-CONSUMER(10955): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-14 14:10:43.060+0200 W/WG-CONSUMER(10955): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-14 14:10:43.060+0200 W/WG-CONSUMER(10955): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-14 14:10:43.070+0200 W/WG-CONSUMER(10955): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-14 14:10:43.220+0200 E/EFL     (10964): elementary<10964> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:43.275+0200 E/EFL     (10964): elementary<10964> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:43.275+0200 E/EFL     (10964): elementary<10964> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:43.275+0200 E/EFL     (10964): elementary<10964> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:43.275+0200 E/EFL     (10964): elementary<10964> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:43.275+0200 E/EFL     (10964): elementary<10964> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:43.275+0200 E/EFL     (10964): elementary<10964> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:43.275+0200 I/AUL_PAD (10964): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:10:43.340+0200 W/MUSIC_TRANSFER(10957): mt-service.c: main(142) > [33m[TID:10957]   service start[0m
10-14 14:10:43.350+0200 W/MUSIC_TRANSFER(10957): mt-service.c: _service_app_create(65) > [33m[TID:10957]   [0m
10-14 14:10:43.550+0200 W/AUL     (10974): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-14 14:10:43.550+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:10:43.550+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:10:43.555+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10955
10-14 14:10:43.555+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:10:43.560+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10955
10-14 14:10:43.715+0200 W/MUSIC_PLAYER(10957): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:10957]   W_SERVICE_TYPE_BT[1][0m
10-14 14:10:43.715+0200 W/MUSIC_PLAYER(10957): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:10957]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-14 14:10:43.715+0200 W/MUSIC_TRANSFER(10957): mt-service.c: _service_app_create(88) > [31m[TID:10957]   SAP is disconnected.. Terminate process[0m
10-14 14:10:43.715+0200 I/CAPI_APPFW_APPLICATION(10957): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 14:10:43.805+0200 W/MUSIC_PLAYER(10957): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:10957]   vendor : LO[0m
10-14 14:10:43.805+0200 W/MUSIC_PLAYER(10957): mp-conf.c: mp_conf_init(262) > [33m[TID:10957]   iOS  connected..[0m
10-14 14:10:43.825+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(10957): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-14 14:10:43.825+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(10957): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-14 14:10:43.825+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(10957): preference.c: preference_get_int(1132) > preference_get_int(10957) : key(tutorial_complete) error
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-14 14:10:43.835+0200 E/CAPI_NETWORK_BLUETOOTH( 1814): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1814]   bt_gatt_client_get_service Error[-22][0m
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1814]   remote mode[0][0m
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:10:43.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 14:10:43.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 14:10:43.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 14:10:43.835+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 14:10:43.840+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 14:10:43.840+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 14:10:43.840+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 14:10:43.845+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-14 14:10:43.855+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 14:10:43.855+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 14:10:43.855+0200 W/MUSIC_TRANSFER(10957): mt-service.c: _service_app_terminate(104) > [33m[TID:10957]   [0m
10-14 14:10:44.130+0200 W/AUL     (10978): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-14 14:10:44.130+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:10:44.130+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:10:44.130+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10957
10-14 14:10:44.130+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:10:44.135+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10957
10-14 14:10:44.165+0200 E/RESOURCED( 1005): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 14:10:44.165+0200 E/AUL     ( 1005): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 14:10:44.165+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:10:44.225+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:44.235+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10940
10-14 14:10:44.245+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:10:44.250+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 14:10:44.290+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-14 14:10:44.295+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 14:10:44.320+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 14:10:44.345+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 14:10:44.910+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:10:45.855+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:10:46.130+0200 W/CRASH_MANAGER(10835): worker.c: worker_job(1205) > 1110893646174150798303