S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 21962
Date: 2017-10-26 13:26:59+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x43e01948, r1   = 0x00000001
r2   = 0x43e00010, r3   = 0xfc179000
r4   = 0xbed672fc, r5   = 0x40059d30
r6   = 0x00000233, r7   = 0xbed67220
r8   = 0xbed672cc, r9   = 0x404bdc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40392a00, sp   = 0xbed671f0
lr   = 0x40392ab4, pc   = 0x40002c3c
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:      7488 KB
Buffers:     47856 KB
Cached:     171716 KB
VmPeak:      65196 KB
VmSize:      65192 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11820 KB
VmRSS:       11820 KB
VmData:      12584 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23428 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21962 TID = 21962
21962 21964 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40015000 40032000 r-xp /lib/ld-2.13.so
4004e000 40052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005a000 4008c000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
40095000 40099000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400a2000 400aa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400ab000 400ad000 r-xp /usr/lib/libdlog.so.0.0.0
400b5000 400d6000 r-xp /usr/lib/libefl-extension.so.0.1.0
400df000 40219000 r-xp /usr/lib/libelementary.so.1.7.99
40230000 402fe000 r-xp /usr/lib/libevas.so.1.7.99
40324000 4043f000 r-xp /lib/libc-2.13.so
4044d000 40455000 r-xp /lib/libgcc_s-4.6.so.1
40456000 40461000 r-xp /lib/libunwind.so.8.0.1
4048e000 40490000 r-xp /lib/libdl-2.13.so
40499000 4049d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404a6000 404a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404b1000 404b6000 r-xp /usr/lib/libappcore-efl.so.1.1
404be000 404c3000 r-xp /usr/lib/libappcore-common.so.1.1
404cb000 404d7000 r-xp /usr/lib/libaul.so.0.1.0
404e1000 40503000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4050b000 4054c000 r-xp /usr/lib/libeina.so.1.7.99
40555000 40569000 r-xp /lib/libpthread-2.13.so
40574000 405ae000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
405b7000 405d0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
405d8000 405dd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e5000 406b5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
406b6000 406bc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c5000 406ef000 r-xp /usr/lib/libsensor.so.1.9.6
406f8000 4078c000 r-xp /usr/lib/libstdc++.so.6.0.16
4079f000 40808000 r-xp /lib/libm-2.13.so
40811000 40861000 r-xp /usr/lib/libecore_x.so.1.7.99
40863000 40885000 r-xp /usr/lib/libecore_evas.so.1.7.99
4088e000 40897000 r-xp /usr/lib/libvconf.so.0.2.45
4089f000 408c7000 r-xp /usr/lib/libfontconfig.so.1.8.0
408c8000 40994000 r-xp /usr/lib/libxml2.so.2.7.8
409a1000 409b3000 r-xp /usr/lib/libefl-assist.so.0.1.0
409bb000 409d2000 r-xp /usr/lib/libecore.so.1.7.99
409e9000 40a47000 r-xp /usr/lib/libedje.so.1.7.99
40a50000 40b08000 r-xp /usr/lib/libcairo.so.2.11200.14
40b13000 40bf4000 r-xp /usr/lib/libX11.so.6.3.0
40bff000 40c08000 r-xp /usr/lib/libXi.so.6.1.0
40c10000 40c29000 r-xp /usr/lib/libeet.so.1.7.99
40c3a000 40c3f000 r-xp /usr/lib/libecore_file.so.1.7.99
40c47000 40c58000 r-xp /usr/lib/libecore_input.so.1.7.99
40c60000 40c69000 r-xp /usr/lib/libedbus.so.1.7.99
40c71000 40c9b000 r-xp /usr/lib/libdbus-1.so.3.8.12
40ca4000 40cbe000 r-xp /usr/lib/libecore_con.so.1.7.99
40cc7000 40cda000 r-xp /usr/lib/libfribidi.so.0.3.1
40ce3000 40d20000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d29000 40d7f000 r-xp /usr/lib/libfreetype.so.6.11.3
40d8b000 40de1000 r-xp /usr/lib/libpixman-1.so.0.28.2
40dee000 40df4000 r-xp /usr/lib/libappsvc.so.0.1.0
40dfc000 40dff000 r-xp /usr/lib/libbundle.so.0.1.22
40e08000 40e0e000 r-xp /usr/lib/libecore_imf.so.1.7.99
40e16000 40e4a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40e53000 40e55000 r-xp /usr/lib/libiniparser.so.0
40e5e000 40e75000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e7d000 40e82000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e8b000 40ec7000 r-xp /usr/lib/libsystemd.so.0.4.0
40ed0000 40ed4000 r-xp /usr/lib/libproc-stat.so.0.2.86
40edd000 40ef3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40efc000 40f71000 r-xp /usr/lib/libsqlite3.so.0.8.6
40f7b000 40f81000 r-xp /lib/librt-2.13.so
40f8b000 40fb9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40fc2000 41095000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
410a0000 410a3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
410ab000 410ad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410b6000 410bc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
410c6000 410ce000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
410d6000 410e0000 r-xp /usr/lib/libsensord-shared.so
410e9000 410f0000 r-xp /usr/lib/libXcursor.so.1.0.2
410f8000 410fa000 r-xp /usr/lib/libXdamage.so.1.1.0
41102000 41104000 r-xp /usr/lib/libXcomposite.so.1.0.0
4110d000 4110f000 r-xp /usr/lib/libXgesture.so.7.0.0
41117000 4111a000 r-xp /usr/lib/libXfixes.so.3.1.0
41122000 41123000 r-xp /usr/lib/libXinerama.so.1.0.0
4112c000 41132000 r-xp /usr/lib/libXrandr.so.2.2.0
4113a000 41140000 r-xp /usr/lib/libXrender.so.1.3.0
41148000 4114c000 r-xp /usr/lib/libXtst.so.6.1.0
41155000 4115f000 r-xp /usr/lib/libXext.so.6.4.0
41168000 4116d000 r-xp /usr/lib/libecore_fb.so.1.7.99
41176000 4117a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41183000 41186000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4118e000 411a4000 r-xp /lib/libexpat.so.1.5.2
411af000 411c5000 r-xp /lib/libz.so.1.2.5
411cd000 411df000 r-xp /usr/lib/libtts.so
411e7000 41209000 r-xp /usr/lib/libui-extension.so.0.1.0
41212000 41219000 r-xp /usr/lib/libtbm.so.1.0.0
41221000 41228000 r-xp /usr/lib/libembryo.so.1.7.99
41231000 41248000 r-xp /usr/lib/liblua-5.1.so
41251000 41252000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4125a000 41268000 r-xp /usr/lib/libGLESv2.so.2.0
41271000 41289000 r-xp /usr/lib/libpng12.so.0.50.0
41291000 41292000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4129c000 412a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
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
43524000 43e00000 rw-p [stack:21964]
bed47000 bed68000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21962)
Call Stack Count: 8
 0: start_bt_server + 0x13 (0x40002c3c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2c3c
 1: app_create + 0x5e (0x40001b37) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b37
 2: (0x4004f9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x404b4457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x40050421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x40001a73) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1a73
 6: __libc_start_main + 0x114 (0x4033b82c) [/lib/libc.so.6] + 0x1782c
 7: (0x400016f4) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x16f4
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
10-26 13:27:30.060+0200 E/WIPC_SERVER(22122): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-26 13:27:30.060+0200 W/WG-CONSUMER(22122): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-26 13:27:30.125+0200 E/RESOURCED(  566): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-music-transfer.consumer
10-26 13:27:30.140+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-26 13:27:30.140+0200 W/W_HOME  (  769): dbox.c: _dbus_rotation_cb(1341) > angle changed:90
10-26 13:27:30.210+0200 E/EFL     (22116): elementary<22116> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:27:30.210+0200 E/EFL     (22116): elementary<22116> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:27:30.210+0200 E/EFL     (22116): elementary<22116> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:27:30.210+0200 E/EFL     (22116): elementary<22116> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:27:30.210+0200 E/EFL     (22116): elementary<22116> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:27:30.250+0200 E/EFL     (22116): elementary<22116> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:27:30.250+0200 E/EFL     (22116): elementary<22116> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:27:30.250+0200 E/EFL     (22116): elementary<22116> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:27:30.265+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:27:30.275+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
10-26 13:27:30.320+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_init_battery_rect(1648) > [windicator_init_battery_rect:1648] battery level 77, index 15, bg level 75
10-26 13:27:30.320+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_init_battery_rect(1652) > [windicator_init_battery_rect:1652] Battery signal emit : bg_level_65
10-26 13:27:30.330+0200 E/EFL     (22116): elementary<22116> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:27:30.345+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] PRE LCD ON - charge
10-26 13:27:30.360+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:27:30.430+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 13:27:30.430+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.430+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.430+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.490+0200 W/APP_CORE(  735): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000a
10-26 13:27:30.495+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:27:30.510+0200 E/W_INDICATOR(  735): windicator_dbus.c: _windicator_get_angle(613) > [_windicator_get_angle:613] Unknown state(0)
10-26 13:27:30.510+0200 E/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(650) > [_windicator_rotation_changed_cb:650] invliad state, Add timer :0 angle:-1
10-26 13:27:30.525+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:27:30.525+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:27:30.525+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 13:27:30.525+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 13:27:30.525+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.525+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 13:27:30.530+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:27:30.530+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:27:30.530+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:27:30.530+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:27:30.530+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.530+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.530+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:27:30.535+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:27:30.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.545+0200 E/EFL     (22116): elementary<22116> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:27:30.545+0200 E/EFL     (22116): elementary<22116> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:27:30.545+0200 E/EFL     (22116): elementary<22116> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:27:30.545+0200 E/EFL     (22116): elementary<22116> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:27:30.545+0200 E/EFL     (22116): elementary<22116> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:27:30.545+0200 E/EFL     (22116): elementary<22116> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:27:30.550+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:27:30.550+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: RESUME State: PAUSED
10-26 13:27:30.550+0200 I/CAPI_APPFW_APPLICATION(  735): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 13:27:30.565+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:27:30.570+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:27:30.570+0200 I/W_INDICATOR(  735): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-26 13:27:30.570+0200 W/W_INDICATOR(  735): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-26 13:27:30.570+0200 W/W_INDICATOR(  735): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-26 13:27:30.575+0200 W/W_INDICATOR(  735): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5cb8) signal name : brightness.icon.7
10-26 13:27:30.590+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:27:30.605+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(657) > [_windicator_rotation_changed_cb:657] Got specific angle, so delete timer!
10-26 13:27:30.605+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:2 angle:3 / is_connected : 1
10-26 13:27:30.605+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_rotation_changed_cb(688) > [_windicator_rotation_changed_cb:688] [ROTATION] Refresh angle value only for 90`, 270`
10-26 13:27:30.605+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_moment_view_angle_changed(1600) > [windicator_moment_view_angle_changed:1600] [Rotation] Angle : 3 (check 1,3)
10-26 13:27:30.610+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-26 13:27:30.610+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-26 13:27:30.610+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 77, index 15, bg level 75
10-26 13:27:30.610+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
10-26 13:27:30.610+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 77
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:27  /5 / HH:mm
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:27
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 27
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  27
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 27 / 13:27
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:27:30.630+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_moment_view_charging_watch_ui_show(1442) > [windicator_moment_view_charging_watch_ui_show:1442] [Rotation] Degree : 90
10-26 13:27:30.645+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:27:30.670+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 13:27:30.730+0200 I/CAPI_APPFW_APPLICATION(22116): app_main.c: app_appcore_create(152) > app_appcore_create
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:27:30.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.785+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:27:30.785+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:27:30.785+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 13:27:30.790+0200 W/WG-CONSUMER(22122): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:27:30.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.810+0200 I/CAPI_CONTENT_MEDIA_CONTENT(22122): media_content.c: media_content_disconnect(958) > [32m[22122]ref count changed to: 0
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:27:30.830+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.830+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:27:30.830+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:27:30.940+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:27:30.960+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:27:30.980+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:27:30.980+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:27:30.985+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:27:30.985+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:27:30.985+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:27:31.045+0200 E/WG-CONSUMER(22122): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-26 13:27:31.050+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:27:31.085+0200 W/WG-CONSUMER(22122): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-26 13:27:31.085+0200 W/WG-CONSUMER(22122): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-26 13:27:31.090+0200 W/WG-CONSUMER(22122): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-26 13:27:31.095+0200 W/WG-CONSUMER(22122): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-26 13:27:31.095+0200 W/WG-CONSUMER(22122): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-26 13:27:31.095+0200 W/WG-CONSUMER(22122): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-26 13:27:31.180+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:27:31.190+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22116
10-26 13:27:31.280+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:27:31.290+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22116
10-26 13:27:31.365+0200 W/W_CLOCK_VIEWER(22116): clock-viewer.c: _clock_viewer_set_current_clock(741) >  package[com.samsung.idle-clock-volt_sparkle] ambient type[3], current lcd[0] resume[0] ambient type[0]
10-26 13:27:31.470+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:27:31.475+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:27:31.490+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:27:31.505+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:27:31.505+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:27:31.515+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:27:31.555+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 13:27:31.640+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:27:31.705+0200 W/MUSIC_PLAYER(22125): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:22125]   W_SERVICE_TYPE_BT[1][0m
10-26 13:27:31.735+0200 W/MUSIC_PLAYER(22125): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:22125]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-26 13:27:31.735+0200 W/MUSIC_TRANSFER(22125): mt-service.c: _service_app_create(88) > [31m[TID:22125]   SAP is disconnected.. Terminate process[0m
10-26 13:27:31.735+0200 I/CAPI_APPFW_APPLICATION(22125): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 13:27:31.760+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(219) > No cached cookie for [22116]
10-26 13:27:31.760+0200 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1643) > Try to read procfs status
10-26 13:27:31.765+0200 W/ALARM_MANAGER(  494): alarm-manager.c: __check_privilege_by_cookie(1647) > Read procfs status successfully
10-26 13:27:31.780+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 13:27:31.780+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 13:27:31.810+0200 W/W_CLOCK_VIEWER(22116): clock-viewer-util-alarm.c: __clock_viewer_util_alarm_ids_cb(32) >  Delete alarm id[467742921]
10-26 13:27:31.820+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [22116].
10-26 13:27:31.820+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(467742921)
10-26 13:27:31.820+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:27:31.820+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:45:00 (UTC).
10-26 13:27:31.820+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:27:31.820+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[467742921] is removed.
10-26 13:27:31.830+0200 I/SCONTEXT-LIB(22116): feature_wearable.cpp: cx_is_feature_supported(97) > Initializing the feature map
10-26 13:27:31.835+0200 I/SCONTEXT-LIB(22116): comm.c: cx_connect_dbus(123) > Connecting Dbus
10-26 13:27:31.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 13:27:31.840+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 13:27:31.850+0200 W/SHealth_Service( 1085): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-26 13:27:31.855+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:27:31.860+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:27:31.865+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:27:31.865+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:27:31.870+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:27:31.895+0200 I/SCONTEXT-LIB(22116): comm.c: cx_connect_dbus(148) > Dbus connected: ':1.787'
10-26 13:27:31.895+0200 I/SCONTEXT-LIB(22116): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 45 (req_id=1)
10-26 13:27:31.895+0200 I/SCONTEXT-LIB(22116): scontext.c: context_get_context(108) > [SUCCESS] Get Context: 45 (req_id=2)
10-26 13:27:31.930+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:27:31.955+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:27:31.970+0200 W/W_CLOCK_VIEWER(22116): clock-viewer-util-dbus.c: clock_viewer_util_dbus_get_device_angle(152) >  Get device angle[2]
10-26 13:27:31.970+0200 W/W_CLOCK_VIEWER(22116): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-26 13:27:31.970+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:27:31.970+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:27:31.975+0200 I/APP_CORE(22116): appcore-efl.c: __do_app(429) > [APP 22116] Event: RESET State: CREATED
10-26 13:27:31.975+0200 I/CAPI_APPFW_APPLICATION(22116): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 13:27:31.975+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:27:31.980+0200 E/wnoti-service(  876): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 2 
10-26 13:27:31.985+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 2
10-26 13:27:32.010+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:27:32.015+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:27:32.045+0200 I/APP_CORE(22116): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 13:27:32.045+0200 I/APP_CORE(22116): appcore-efl.c: __do_app(474) > [APP 22116] Initial Launching, call the resume_cb
10-26 13:27:32.045+0200 I/CAPI_APPFW_APPLICATION(22116): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 13:27:32.070+0200 W/APP_CORE(22116): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200003
10-26 13:27:32.095+0200 I/MALI    (22116): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(742) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [216x432]
10-26 13:27:32.160+0200 W/W_CLOCK_VIEWER(22116): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(194) >  get_info_cb called err[0], context[45], data[{ "Time" : 1509017251966, "Reason" : 0, "Status" : 2 }], req_id[2]
10-26 13:27:32.160+0200 W/W_CLOCK_VIEWER(22116): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(214) >  status[2] Wear OFF
10-26 13:27:32.210+0200 E/DATA_PROVIDER_MASTER(  733): package.c: package_alter_instances_to_client(1695) > Failed to load a buffer
10-26 13:27:32.210+0200 E/WIDGET_VIEWER(22116): client.c: master_created(1712) > [14,692140] pkgname: com.samsung.idle-clock-volt_sparkle, id: file:///opt/usr/share/live_magazine/com.samsung.idle-clock-volt_sparkle_769_14,692140.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 216, widget_h: 432, cluster: user,created, category: default, widget_fname: "pixmap://29360130:4", gbar_fname: "", auto_launch: , priority: 0,000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0,000000, title: [], is_pinned_up: 0
10-26 13:27:32.230+0200 E/DATA_PROVIDER_MASTER(  733): shared_fd_service.c: direct_hello_handler(66) > Client is not exists: 
10-26 13:27:32.255+0200 E/WIDGET_EVAS(22116): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-26 13:27:32.260+0200 W/W_CLOCK_VIEWER(22116): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(257) >  DBOX Created[com.samsung.idle-clock-volt_sparkle] it should be [com.samsung.idle-clock-volt_sparkle]
10-26 13:27:32.270+0200 W/W_CLOCK_VIEWER(22116): clock-viewer-dbox.c: _clock_viewer_widget_list_append(128) >  >>>Append to list[com.samsung.idle-clock-volt_sparkle][0x43cfde00]
10-26 13:27:32.330+0200 W/AUL     (22142): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-26 13:27:32.330+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:27:32.330+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:27:32.330+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 22122
10-26 13:27:32.335+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:27:32.335+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22122
10-26 13:27:32.365+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:32.365+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:27:32.365+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:32.385+0200 E/EFL     (22106): elementary<22106> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:27:32.395+0200 E/EFL     (22106): elementary<22106> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:27:32.480+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:27:32.590+0200 W/MUSIC_PLAYER(22125): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:22125]   vendor : LO[0m
10-26 13:27:32.635+0200 W/MUSIC_PLAYER(22125): mp-conf.c: mp_conf_init(262) > [33m[TID:22125]   iOS  connected..[0m
10-26 13:27:32.815+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22125
10-26 13:27:32.825+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:27:32.830+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22125): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-26 13:27:32.840+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22125): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-26 13:27:32.840+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(22125): preference.c: preference_get_int(1132) > preference_get_int(22125) : key(tutorial_complete) error
10-26 13:27:32.865+0200 E/EFL     (22106): elementary<22106> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:27:32.875+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-26 13:27:32.880+0200 E/CAPI_NETWORK_BLUETOOTH( 1061): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-26 13:27:32.880+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1061]   bt_gatt_client_get_service Error[-22][0m
10-26 13:27:32.880+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1061]   remote mode[0][0m
10-26 13:27:32.880+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:27:32.880+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:27:32.885+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:27:32.885+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:27:32.890+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:27:32.890+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:27:32.905+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 13:27:32.905+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 13:27:32.920+0200 E/EFL     (22106): elementary<22106> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:27:32.930+0200 W/MUSIC_TRANSFER(22125): mt-service.c: _service_app_terminate(104) > [33m[TID:22125]   [0m
10-26 13:27:33.010+0200 E/EFL     (22106): elementary<22106> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:27:33.020+0200 E/EFL     (22106): elementary<22106> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:27:33.030+0200 E/EFL     (22106): elementary<22106> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:27:33.050+0200 E/EFL     (22106): elementary<22106> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:27:33.055+0200 E/EFL     (22106): elementary<22106> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:27:33.540+0200 E/EFL     (22106): elementary<22106> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:27:33.665+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:33.665+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:27:33.665+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:33.715+0200 I/AUL     ( 1085): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:27:33.740+0200 I/AUL     ( 1085): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:27:33.740+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:33.740+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 13:27:33.745+0200 E/EFL     (22106): elementary<22106> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:27:33.760+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-26 13:27:33.765+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 13:27:33.800+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 13:27:33.800+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 13:27:33.810+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 13:27:33.825+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 13:27:33.855+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 13:27:33.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:27:33.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:27:33.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:27:33.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:27:33.905+0200 E/EFL     (22106): elementary<22106> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:27:33.945+0200 E/EFL     (22106): elementary<22106> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:27:34.000+0200 E/EFL     (22106): elementary<22106> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:27:34.000+0200 E/EFL     (22106): elementary<22106> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:27:34.000+0200 E/EFL     (22106): elementary<22106> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:27:34.000+0200 E/EFL     (22106): elementary<22106> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:27:34.000+0200 E/EFL     (22106): elementary<22106> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:27:34.000+0200 E/EFL     (22106): elementary<22106> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:27:34.000+0200 I/AUL_PAD (22106): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:27:34.020+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 13:27:34.030+0200 W/AUL     (22145): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-26 13:27:34.035+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:27:34.035+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:27:34.035+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 22125
10-26 13:27:34.035+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:27:34.045+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22125
10-26 13:27:34.060+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:27:34.135+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:27:34.145+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22116
10-26 13:27:34.150+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:27:34.155+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:34.155+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:27:34.155+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:34.155+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:34.155+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:27:34.155+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:34.905+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 13:27:35.550+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:27:37.485+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:27:45.545+0200 W/CRASH_MANAGER(21900): worker.c: worker_job(1205) > 1121962646174150901721
