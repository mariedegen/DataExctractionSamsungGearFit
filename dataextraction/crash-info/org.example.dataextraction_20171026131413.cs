S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 20449
Date: 2017-10-26 13:14:13+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b65b8, r1   = 0x00000001
r2   = 0x4044b250, r3   = 0x0e6e0700
r4   = 0xbeb822fc, r5   = 0x4005ad30
r6   = 0x00000233, r7   = 0xbeb82228
r8   = 0xbeb822cc, r9   = 0x404bec84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40393a00, sp   = 0xbeb821f8
lr   = 0x40393ab4, pc   = 0x40003754
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     15308 KB
Buffers:     46924 KB
Cached:     174468 KB
VmPeak:      64156 KB
VmSize:      64152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11712 KB
VmRSS:       11712 KB
VmData:      11544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23428 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20449 TID = 20449
20449 20450 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40016000 40033000 r-xp /lib/ld-2.13.so
4004f000 40053000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005b000 4008d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
40096000 4009a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400a3000 400ab000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400ac000 400ae000 r-xp /usr/lib/libdlog.so.0.0.0
400b6000 400d7000 r-xp /usr/lib/libefl-extension.so.0.1.0
400e0000 4021a000 r-xp /usr/lib/libelementary.so.1.7.99
40231000 402ff000 r-xp /usr/lib/libevas.so.1.7.99
40325000 40440000 r-xp /lib/libc-2.13.so
4044e000 40456000 r-xp /lib/libgcc_s-4.6.so.1
40457000 40462000 r-xp /lib/libunwind.so.8.0.1
4048f000 40491000 r-xp /lib/libdl-2.13.so
4049a000 4049e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404a7000 404a9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404b2000 404b7000 r-xp /usr/lib/libappcore-efl.so.1.1
404bf000 404c4000 r-xp /usr/lib/libappcore-common.so.1.1
404cc000 404d8000 r-xp /usr/lib/libaul.so.0.1.0
404e2000 40504000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4050c000 4054d000 r-xp /usr/lib/libeina.so.1.7.99
40556000 4056a000 r-xp /lib/libpthread-2.13.so
40575000 405af000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
405b8000 405d1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
405d9000 405de000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e6000 406b6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
406b7000 406bd000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c6000 406f0000 r-xp /usr/lib/libsensor.so.1.9.6
406f9000 4078d000 r-xp /usr/lib/libstdc++.so.6.0.16
407a0000 40809000 r-xp /lib/libm-2.13.so
40812000 40862000 r-xp /usr/lib/libecore_x.so.1.7.99
40864000 40886000 r-xp /usr/lib/libecore_evas.so.1.7.99
4088f000 40898000 r-xp /usr/lib/libvconf.so.0.2.45
408a0000 408c8000 r-xp /usr/lib/libfontconfig.so.1.8.0
408c9000 40995000 r-xp /usr/lib/libxml2.so.2.7.8
409a2000 409b4000 r-xp /usr/lib/libefl-assist.so.0.1.0
409bc000 409d3000 r-xp /usr/lib/libecore.so.1.7.99
409ea000 40a48000 r-xp /usr/lib/libedje.so.1.7.99
40a51000 40b09000 r-xp /usr/lib/libcairo.so.2.11200.14
40b14000 40bf5000 r-xp /usr/lib/libX11.so.6.3.0
40c00000 40c09000 r-xp /usr/lib/libXi.so.6.1.0
40c11000 40c2a000 r-xp /usr/lib/libeet.so.1.7.99
40c3b000 40c40000 r-xp /usr/lib/libecore_file.so.1.7.99
40c48000 40c59000 r-xp /usr/lib/libecore_input.so.1.7.99
40c61000 40c6a000 r-xp /usr/lib/libedbus.so.1.7.99
40c72000 40c9c000 r-xp /usr/lib/libdbus-1.so.3.8.12
40ca5000 40cbf000 r-xp /usr/lib/libecore_con.so.1.7.99
40cc8000 40cdb000 r-xp /usr/lib/libfribidi.so.0.3.1
40ce3000 40d20000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d29000 40d7f000 r-xp /usr/lib/libfreetype.so.6.11.3
40d8b000 40de1000 r-xp /usr/lib/libpixman-1.so.0.28.2
40dee000 40df4000 r-xp /usr/lib/libappsvc.so.0.1.0
40dfc000 40dff000 r-xp /usr/lib/libbundle.so.0.1.22
40e07000 40e0d000 r-xp /usr/lib/libecore_imf.so.1.7.99
40e16000 40e4a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40e53000 40e55000 r-xp /usr/lib/libiniparser.so.0
40e5e000 40e75000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e7d000 40e82000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e8a000 40ec6000 r-xp /usr/lib/libsystemd.so.0.4.0
40ed0000 40ed4000 r-xp /usr/lib/libproc-stat.so.0.2.86
40edd000 40ef3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40efc000 40f71000 r-xp /usr/lib/libsqlite3.so.0.8.6
40f7b000 40f81000 r-xp /lib/librt-2.13.so
40f8a000 40fb8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40fc2000 41095000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
410a0000 410a3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
410ab000 410ad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410b6000 410bc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
410c5000 410cd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
410d6000 410e0000 r-xp /usr/lib/libsensord-shared.so
410e9000 410f0000 r-xp /usr/lib/libXcursor.so.1.0.2
410f8000 410fa000 r-xp /usr/lib/libXdamage.so.1.1.0
41102000 41104000 r-xp /usr/lib/libXcomposite.so.1.0.0
4110c000 4110e000 r-xp /usr/lib/libXgesture.so.7.0.0
41117000 4111a000 r-xp /usr/lib/libXfixes.so.3.1.0
41122000 41123000 r-xp /usr/lib/libXinerama.so.1.0.0
4112c000 41132000 r-xp /usr/lib/libXrandr.so.2.2.0
4113a000 41140000 r-xp /usr/lib/libXrender.so.1.3.0
41148000 4114c000 r-xp /usr/lib/libXtst.so.6.1.0
41154000 4115e000 r-xp /usr/lib/libXext.so.6.4.0
41168000 4116d000 r-xp /usr/lib/libecore_fb.so.1.7.99
41176000 4117a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41183000 41186000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4118e000 411a4000 r-xp /lib/libexpat.so.1.5.2
411ae000 411c4000 r-xp /lib/libz.so.1.2.5
411cd000 411df000 r-xp /usr/lib/libtts.so
411e7000 41209000 r-xp /usr/lib/libui-extension.so.0.1.0
41212000 41219000 r-xp /usr/lib/libtbm.so.1.0.0
41221000 41228000 r-xp /usr/lib/libembryo.so.1.7.99
41230000 41247000 r-xp /usr/lib/liblua-5.1.so
41251000 41252000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4125a000 41268000 r-xp /usr/lib/libGLESv2.so.2.0
41271000 41289000 r-xp /usr/lib/libpng12.so.0.50.0
41291000 41292000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4129b000 412a1000 r-xp /usr/lib/libxcb-render.so.0.0.0
412aa000 412bd000 r-xp /usr/lib/libxcb.so.1.1.0
412c6000 412c9000 r-xp /usr/lib/libEGL.so.1.4
412d1000 412f4000 r-xp /usr/lib/libjpeg.so.8.0.2
4130c000 41350000 r-xp /usr/lib/libcurl.so.4.3.0
4135a000 4135b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41363000 41368000 r-xp /usr/lib/libffi.so.5.0.10
41370000 41388000 r-xp /usr/lib/liblzma.so.5.0.3
41390000 4140c000 r-xp /usr/lib/libgcrypt.so.20.0.3
41418000 41428000 r-xp /lib/libresolv-2.13.so
4142d000 4142f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41437000 4143b000 r-xp /usr/lib/libsmack.so.1.0.0
41444000 41461000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4146a000 4146c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41474000 41481000 r-xp /usr/lib/libail.so.0.1.0
4148b000 415c8000 r-xp /usr/lib/libicui18n.so.51.1
415d8000 416bc000 r-xp /usr/lib/libicuuc.so.51.1
42c5a000 42c76000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42c80000 42c83000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
42c8b000 42c8c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
42c95000 42c9d000 r-xp /usr/lib/libdrm.so.2.4.0
42ca5000 42ca7000 r-xp /usr/lib/libdri2.so.0.0.0
42cb0000 42cb2000 r-xp /usr/lib/libXau.so.6.0.0
42cba000 42cc3000 r-xp /usr/lib/libcares.so.2.1.0
42ccc000 42cfa000 r-xp /usr/lib/libidn.so.11.5.44
42d02000 42d49000 r-xp /usr/lib/libssl.so.1.0.0
42d55000 42efe000 r-xp /usr/lib/libcrypto.so.1.0.0
42f20000 42f2b000 r-xp /usr/lib/libgpg-error.so.0.15.0
42f33000 42f35000 r-xp /usr/lib/libiri.so
42f3d000 42f40000 r-xp /lib/libcap.so.2.21
42f48000 42f4f000 r-xp /lib/libcrypt-2.13.so
42f7f000 42f86000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42f90000 42f92000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42f9a000 42fa1000 r-xp /usr/lib/libminizip.so.1.0.0
42fa9000 42faf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42fb7000 42fbc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42fc5000 42fc8000 r-xp /lib/libattr.so.1.1.0
42fd0000 42ff1000 r-xp /usr/lib/libexif.so.12.3.3
43004000 43006000 r-xp /usr/lib/libttrace.so.1.1
4300e000 43013000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43122000 431ec000 r-xp /usr/lib/libCOREGL.so.4.0
431fe000 43222000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4322b000 432fa000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43310000 4331a000 r-xp /lib/libnss_files-2.13.so
43524000 43e76000 rw-p [stack:20450]
beb62000 beb83000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20449)
Call Stack Count: 8
 0: start_bt_server + 0x13 (0x40003754) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3754
 1: app_create + 0x38 (0x40002039) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2039
 2: (0x400509c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x404b5457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x40051421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x40001f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
 6: __libc_start_main + 0x114 (0x4033c82c) [/lib/libc.so.6] + 0x1782c
 7: (0x40001ab0) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1ab0
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
:16.845+0200 E/RESOURCED(  566): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-music-transfer.consumer
10-26 13:14:16.845+0200 E/W_INDICATOR(  735): windicator_dbus.c: _windicator_get_angle(613) > [_windicator_get_angle:613] Unknown state(0)
10-26 13:14:16.850+0200 E/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(650) > [_windicator_rotation_changed_cb:650] invliad state, Add timer :0 angle:-1
10-26 13:14:16.875+0200 W/APP_CORE(  735): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000a
10-26 13:14:16.880+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 13:14:16.880+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.880+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.880+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.915+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-26 13:14:16.915+0200 W/W_HOME  (  769): dbox.c: _dbus_rotation_cb(1341) > angle changed:90
10-26 13:14:16.930+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:14:16.930+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:14:16.940+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 13:14:16.955+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 13:14:16.955+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 13:14:16.955+0200 W/SHealth_Service( 1085): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-26 13:14:16.975+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 13:14:16.975+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 13:14:16.975+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.975+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 13:14:16.980+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:14:16.980+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:14:16.980+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:14:16.980+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:14:16.980+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.980+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.980+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:14:16.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:14:16.990+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:14:17.000+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:14:17.000+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:14:17.000+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:14:17.000+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:14:17.000+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: RESUME State: PAUSED
10-26 13:14:17.000+0200 I/CAPI_APPFW_APPLICATION(  735): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 13:14:17.025+0200 I/W_INDICATOR(  735): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-26 13:14:17.025+0200 W/W_INDICATOR(  735): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-26 13:14:17.025+0200 W/W_INDICATOR(  735): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-26 13:14:17.025+0200 W/W_INDICATOR(  735): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5cb8) signal name : brightness.icon.7
10-26 13:14:17.040+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:14:17.050+0200 I/CAPI_APPFW_APPLICATION(20468): app_main.c: app_efl_main(129) > app_efl_main
10-26 13:14:17.090+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(657) > [_windicator_rotation_changed_cb:657] Got specific angle, so delete timer!
10-26 13:14:17.090+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:2 angle:3 / is_connected : 1
10-26 13:14:17.095+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(688) > [_windicator_rotation_changed_cb:688] [ROTATION] Refresh angle value only for 90`, 270`
10-26 13:14:17.095+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_moment_view_angle_changed(1600) > [windicator_moment_view_angle_changed:1600] [Rotation] Angle : 3 (check 1,3)
10-26 13:14:17.100+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-26 13:14:17.105+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-26 13:14:17.105+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 78, index 15, bg level 75
10-26 13:14:17.105+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
10-26 13:14:17.110+0200 E/EFL     (20468): elementary<20468> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:14:17.110+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 78
10-26 13:14:17.115+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:14:17.115+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:14:17.115+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:14  /5 / HH:mm
10-26 13:14:17.120+0200 E/EFL     (20468): elementary<20468> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:14
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 14
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  14
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 14 / 13:14
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:14:17.120+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_moment_view_charging_watch_ui_show(1442) > [windicator_moment_view_charging_watch_ui_show:1442] [Rotation] Degree : 90
10-26 13:14:17.125+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 13:14:17.135+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:14:17.195+0200 E/EFL     (20468): elementary<20468> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:14:17.195+0200 E/EFL     (20468): elementary<20468> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:14:17.350+0200 E/EFL     (20468): elementary<20468> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:14:17.350+0200 E/EFL     (20468): elementary<20468> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:14:17.355+0200 E/EFL     (20468): elementary<20468> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:14:17.355+0200 E/EFL     (20468): elementary<20468> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:14:17.355+0200 E/EFL     (20468): elementary<20468> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:14:17.400+0200 E/EFL     (20468): elementary<20468> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:14:17.400+0200 E/EFL     (20468): elementary<20468> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:14:17.400+0200 E/EFL     (20468): elementary<20468> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:14:17.465+0200 E/EFL     (20468): elementary<20468> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:14:17.495+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:14:17.515+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:14:17.515+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:14:17.600+0200 I/CAPI_APPFW_APPLICATION(20468): app_main.c: app_appcore_create(152) > app_appcore_create
10-26 13:14:18.000+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: _clock_viewer_set_current_clock(741) >  package[com.samsung.idle-clock-volt_sparkle] ambient type[3], current lcd[0] resume[0] ambient type[0]
10-26 13:14:18.160+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:18.170+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:14:18.195+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:18.205+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20468
10-26 13:14:18.240+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:18.275+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(219) > No cached cookie for [20468]
10-26 13:14:18.275+0200 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1643) > Try to read procfs status
10-26 13:14:18.275+0200 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1647) > Read procfs status successfully
10-26 13:14:18.345+0200 W/W_CLOCK_VIEWER(20468): clock-viewer-util-alarm.c: __clock_viewer_util_alarm_ids_cb(32) >  Delete alarm id[1527177354]
10-26 13:14:18.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [20468].
10-26 13:14:18.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1527177354)
10-26 13:14:18.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:14:18.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:45:00 (UTC).
10-26 13:14:18.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:14:18.350+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1527177354] is removed.
10-26 13:14:18.360+0200 I/SCONTEXT-LIB(20468): feature_wearable.cpp: cx_is_feature_supported(97) > Initializing the feature map
10-26 13:14:18.365+0200 I/SCONTEXT-LIB(20468): comm.c: cx_connect_dbus(123) > Connecting Dbus
10-26 13:14:18.420+0200 I/SCONTEXT-LIB(20468): comm.c: cx_connect_dbus(148) > Dbus connected: ':1.651'
10-26 13:14:18.420+0200 I/SCONTEXT-LIB(20468): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 45 (req_id=1)
10-26 13:14:18.420+0200 I/SCONTEXT-LIB(20468): scontext.c: context_get_context(108) > [SUCCESS] Get Context: 45 (req_id=2)
10-26 13:14:18.465+0200 W/W_CLOCK_VIEWER(20468): clock-viewer-util-dbus.c: clock_viewer_util_dbus_get_device_angle(152) >  Get device angle[2]
10-26 13:14:18.465+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-26 13:14:18.470+0200 I/APP_CORE(20468): appcore-efl.c: __do_app(429) > [APP 20468] Event: RESET State: CREATED
10-26 13:14:18.470+0200 I/CAPI_APPFW_APPLICATION(20468): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 13:14:18.510+0200 I/APP_CORE(20468): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 13:14:18.510+0200 I/APP_CORE(20468): appcore-efl.c: __do_app(474) > [APP 20468] Initial Launching, call the resume_cb
10-26 13:14:18.515+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:14:18.515+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:14:18.515+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:14:18.515+0200 E/wnoti-service(  876): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 2 
10-26 13:14:18.520+0200 I/CAPI_APPFW_APPLICATION(20468): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 13:14:18.520+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 2
10-26 13:14:18.530+0200 W/APP_CORE(20468): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5c00003
10-26 13:14:18.545+0200 I/MALI    (20468): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(742) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [216x432]
10-26 13:14:18.605+0200 W/W_CLOCK_VIEWER(20468): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(194) >  get_info_cb called err[0], context[45], data[{ "Time" : 1509016458514, "Reason" : 0, "Status" : 2 }], req_id[2]
10-26 13:14:18.605+0200 W/W_CLOCK_VIEWER(20468): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(214) >  status[2] Wear OFF
10-26 13:14:18.615+0200 E/DATA_PROVIDER_MASTER(  733): package.c: package_alter_instances_to_client(1695) > Failed to load a buffer
10-26 13:14:18.620+0200 E/WIDGET_VIEWER(20468): client.c: master_created(1712) > [14,692140] pkgname: com.samsung.idle-clock-volt_sparkle, id: file:///opt/usr/share/live_magazine/com.samsung.idle-clock-volt_sparkle_769_14,692140.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 216, widget_h: 432, cluster: user,created, category: default, widget_fname: "pixmap://29360130:4", gbar_fname: "", auto_launch: , priority: 0,000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0,000000, title: [], is_pinned_up: 0
10-26 13:14:18.625+0200 E/DATA_PROVIDER_MASTER(  733): shared_fd_service.c: direct_hello_handler(66) > Client is not exists: 
10-26 13:14:18.640+0200 E/WIDGET_EVAS(20468): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-26 13:14:18.640+0200 W/W_CLOCK_VIEWER(20468): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(257) >  DBOX Created[com.samsung.idle-clock-volt_sparkle] it should be [com.samsung.idle-clock-volt_sparkle]
10-26 13:14:18.640+0200 W/W_CLOCK_VIEWER(20468): clock-viewer-dbox.c: _clock_viewer_widget_list_append(128) >  >>>Append to list[com.samsung.idle-clock-volt_sparkle][0x43cfde00]
10-26 13:14:18.825+0200 E/EFL     (20443): elementary<20443> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:14:18.855+0200 E/EFL     (20443): elementary<20443> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:14:18.995+0200 E/EFL     (20443): elementary<20443> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:14:18.995+0200 E/EFL     (20443): elementary<20443> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:14:19.060+0200 E/EFL     (20443): elementary<20443> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:14:19.065+0200 E/EFL     (20443): elementary<20443> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:14:19.070+0200 E/EFL     (20443): elementary<20443> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:14:19.185+0200 I/APP_CORE(20455): appcore-efl.c: __do_app(429) > [APP 20455] Event: RESET State: CREATED
10-26 13:14:19.185+0200 I/CAPI_APPFW_APPLICATION(20455): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 13:14:19.190+0200 D/WAPP    (20455): WApp.cpp: _onAppControl(98) > [0;34m>>>HIT<<<[0;m
10-26 13:14:19.190+0200 D/STOPWATCH(20455): StopwatchApp.cpp: onAppControl(111) > [0;32mBEGIN >>>>[0;m
10-26 13:14:19.190+0200 D/WAPP    (20455): WContentViewController.cpp: WContentViewController(37) > [0;34m>>>HIT<<<[0;m
10-26 13:14:19.190+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: StopwatchViewController(52) > [0;34m>>>HIT<<<[0;m
10-26 13:14:19.190+0200 D/WAPP    (20455): WViewController.cpp: create(57) > [0;34m>>>HIT<<<[0;m
10-26 13:14:19.190+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: onCreateView(137) > [0;32mBEGIN >>>>[0;m
10-26 13:14:19.280+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: onCreateView(146) > Resource path: /opt/usr/apps/com.samsung.stopwatch-band/res/
10-26 13:14:19.280+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: onCreateView(148) > Edje path: /opt/usr/apps/com.samsung.stopwatch-band/res/edje/stopwatch.edj
10-26 13:14:19.285+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: onCreateView(150) > Edje theme path: /opt/usr/apps/com.samsung.stopwatch-band/res/edje/stopwatchCustomGenlist.edj
10-26 13:14:19.410+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: _initializeValue(206) > [0;32mBEGIN >>>>[0;m
10-26 13:14:19.425+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: _changeNumberToString(811) > number : 0, string : 0
10-26 13:14:19.425+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: _changeNumberToString(811) > number : 0, string : 0
10-26 13:14:19.425+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: _changeNumberToString(811) > number : 0, string : 0
10-26 13:14:19.430+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: _changeNumberToString(811) > number : 0, string : 0
10-26 13:14:19.445+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: onPushed(199) > [0;32mBEGIN >>>>[0;m
10-26 13:14:19.445+0200 D/STOPWATCH(20455): StopwatchApp.cpp: onAppControl(121) > [0;32mEND <<<<[0;m
10-26 13:14:19.485+0200 I/APP_CORE(20455): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 13:14:19.485+0200 I/APP_CORE(20455): appcore-efl.c: __do_app(474) > [APP 20455] Initial Launching, call the resume_cb
10-26 13:14:19.485+0200 I/CAPI_APPFW_APPLICATION(20455): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 13:14:19.485+0200 D/WAPP    (20455): WApp.cpp: _onResume(89) > [0;34m>>>HIT<<<[0;m
10-26 13:14:19.485+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: stopwatchResume(103) > [0;32mBEGIN >>>>[0;m
10-26 13:14:19.485+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: stopwatchResume(114) > Current State is not Start[currentState: 0]
10-26 13:14:19.495+0200 W/APP_CORE(20455): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800003
10-26 13:14:19.560+0200 I/MALI    (20455): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(742) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [216x432]
10-26 13:14:19.615+0200 I/APP_CORE(20455): appcore-efl.c: __do_app(429) > [APP 20455] Event: PAUSE State: RUNNING
10-26 13:14:19.615+0200 I/CAPI_APPFW_APPLICATION(20455): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 13:14:19.615+0200 D/WAPP    (20455): WApp.cpp: _onPause(78) > [0;34m>>>HIT<<<[0;m
10-26 13:14:19.615+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: stopwatchPause(90) > [0;32mBEGIN >>>>[0;m
10-26 13:14:19.615+0200 D/STOPWATCH(20455): StopwatchViewController.cpp: stopwatchPause(97) > Current State is not Start[currentState: 0]
10-26 13:14:19.955+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:14:20.135+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:20.145+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20468
10-26 13:14:20.150+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:20.200+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:20.210+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20472
10-26 13:14:20.225+0200 E/EFL     (20443): elementary<20443> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:14:20.230+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:20.255+0200 E/EFL     (20443): elementary<20443> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:14:20.295+0200 E/EFL     (20443): elementary<20443> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:14:20.770+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:20.780+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20475
10-26 13:14:20.780+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:20.790+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20472
10-26 13:14:20.805+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:20.895+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:21.130+0200 W/WG-CONSUMER(20472): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
10-26 13:14:21.240+0200 W/WG-CONSUMER(20472): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
10-26 13:14:21.260+0200 W/WG-CONSUMER(20472): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
10-26 13:14:21.280+0200 W/WG-CONSUMER(20472): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-26 13:14:21.300+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-26 13:14:21.350+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-26 13:14:21.405+0200 W/WG-CONSUMER(20472): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-26 13:14:21.500+0200 I/CAPI_CONTENT_MEDIA_CONTENT(20472): media_content.c: media_content_connect(870) > [32m[20472]ref count : 0
10-26 13:14:21.570+0200 I/CAPI_CONTENT_MEDIA_CONTENT(20472): media_content.c: media_content_connect(902) > [32m[20472]ref count changed to: 1
10-26 13:14:21.575+0200 W/WG-CONSUMER(20472): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-26 13:14:21.620+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:21.630+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20475
10-26 13:14:21.640+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:21.730+0200 E/EFL     (20443): elementary<20443> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:14:21.780+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:21.795+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20468
10-26 13:14:21.835+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:21.895+0200 E/EFL     (20443): elementary<20443> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:14:21.920+0200 E/EFL     (20443): elementary<20443> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:14:21.930+0200 E/EFL     (20443): elementary<20443> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:14:21.940+0200 E/EFL     (20443): elementary<20443> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:14:21.940+0200 W/WG-CONSUMER(20472): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-26 13:14:21.940+0200 W/WG-CONSUMER(20472): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-26 13:14:21.945+0200 E/EFL     (20443): elementary<20443> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:14:21.945+0200 E/EFL     (20443): elementary<20443> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:14:21.950+0200 I/AUL_PAD (20443): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:14:21.955+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-26 13:14:21.955+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-26 13:14:21.995+0200 W/SHealth_Service( 1085): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
10-26 13:14:22.000+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:14:22.010+0200 E/WG-CONSUMER(20472): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-26 13:14:22.015+0200 E/WG-CONSUMER(20472): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-26 13:14:22.045+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-26 13:14:22.045+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-26 13:14:22.045+0200 E/WG-CONSUMER(20472): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-26 13:14:22.045+0200 W/WG-CONSUMER(20472): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-26 13:14:22.045+0200 W/WG-CONSUMER(20472): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-26 13:14:22.045+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-26 13:14:22.055+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-26 13:14:22.055+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-26 13:14:22.055+0200 E/WG-CONSUMER(20472): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-26 13:14:22.090+0200 E/WG-CONSUMER(20472): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-26 13:14:22.115+0200 E/WG-CONSUMER(20472): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-26 13:14:22.125+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-26 13:14:22.125+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-26 13:14:22.125+0200 E/WG-CONSUMER(20472): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-26 13:14:22.175+0200 W/WG-CONSUMER(20472): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42ead758[0m
10-26 13:14:22.175+0200 W/CAPI_APPFW_APP_CONTROL(20472): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-26 13:14:22.175+0200 W/CAPI_APPFW_APP_CONTROL(20472): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-26 13:14:22.195+0200 W/WG-CONSUMER(20472): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-26 13:14:22.205+0200 I/CAPI_APPFW_APPLICATION(20472): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 13:14:22.210+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 13:14:22.210+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 13:14:22.210+0200 E/WIPC_SERVER(20472): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-26 13:14:22.210+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-26 13:14:22.215+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 13:14:22.225+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 13:14:22.225+0200 W/WG-CONSUMER(20472): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 13:14:22.230+0200 W/WG-CONSUMER(20472): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 13:14:22.240+0200 I/CAPI_CONTENT_MEDIA_CONTENT(20472): media_content.c: media_content_disconnect(958) > [32m[20472]ref count changed to: 0
10-26 13:14:22.350+0200 E/WG-CONSUMER(20472): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-26 13:14:22.355+0200 W/WG-CONSUMER(20472): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-26 13:14:22.355+0200 W/WG-CONSUMER(20472): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-26 13:14:22.355+0200 W/WG-CONSUMER(20472): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-26 13:14:22.355+0200 W/WG-CONSUMER(20472): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-26 13:14:22.355+0200 W/WG-CONSUMER(20472): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-26 13:14:22.355+0200 W/WG-CONSUMER(20472): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-26 13:14:22.580+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:14:22.600+0200 W/AUL     (20497): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-26 13:14:22.610+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:14:22.610+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:14:22.610+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20472
10-26 13:14:22.610+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:14:22.615+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20472
10-26 13:14:22.975+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:22.985+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:14:23.020+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:14:23.040+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:14:23.045+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 13:14:23.440+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-26 13:14:23.685+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:23.695+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20475
10-26 13:14:23.705+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:23.750+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 13:14:23.880+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 13:14:23.905+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 13:14:23.940+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 13:14:24.075+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 13:14:24.115+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 13:14:24.210+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 13:14:24.620+0200 I/APP_CORE(20455): appcore-efl.c: __do_app(429) > [APP 20455] Event: MEM_FLUSH State: PAUSED
10-26 13:14:24.700+0200 W/MUSIC_TRANSFER(20475): mt-service.c: main(142) > [33m[TID:20475]   service start[0m
10-26 13:14:24.725+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:14:24.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:14:24.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:14:24.785+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:14:24.880+0200 W/MUSIC_TRANSFER(20475): mt-service.c: _service_app_create(65) > [33m[TID:20475]   [0m
10-26 13:14:25.385+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 13:14:25.425+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:14:26.165+0200 W/MUSIC_PLAYER(20475): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:20475]   W_SERVICE_TYPE_BT[1][0m
10-26 13:14:26.165+0200 W/MUSIC_PLAYER(20475): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:20475]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-26 13:14:26.170+0200 W/MUSIC_TRANSFER(20475): mt-service.c: _service_app_create(88) > [31m[TID:20475]   SAP is disconnected.. Terminate process[0m
10-26 13:14:26.175+0200 I/CAPI_APPFW_APPLICATION(20475): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 13:14:26.455+0200 W/MUSIC_PLAYER(20475): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:20475]   vendor : LO[0m
10-26 13:14:26.475+0200 W/MUSIC_PLAYER(20475): mp-conf.c: mp_conf_init(262) > [33m[TID:20475]   iOS  connected..[0m
10-26 13:14:26.480+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20475): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-26 13:14:26.485+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20475): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-26 13:14:26.490+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20475): preference.c: preference_get_int(1132) > preference_get_int(20475) : key(tutorial_complete) error
10-26 13:14:26.495+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-26 13:14:26.500+0200 E/CAPI_NETWORK_BLUETOOTH( 1061): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1061]   bt_gatt_client_get_service Error[-22][0m
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1061]   remote mode[0][0m
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:14:26.510+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:14:26.535+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:14:26.535+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:14:26.535+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:14:26.540+0200 W/MUSIC_TRANSFER(20475): mt-service.c: _service_app_terminate(104) > [33m[TID:20475]   [0m
10-26 13:14:26.540+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 13:14:26.540+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 13:14:26.795+0200 W/AUL     (20507): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20475
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:14:26.815+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20475
10-26 13:14:27.100+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:14:28.545+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 13:14:28.570+0200 W/CRASH_MANAGER(20356): worker.c: worker_job(1205) > 1120449646174150901645
