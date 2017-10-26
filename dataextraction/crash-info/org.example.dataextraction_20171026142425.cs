S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2171
Date: 2017-10-26 14:24:25+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b7710, r1   = 0x00000001
r2   = 0x4044a250, r3   = 0x3f36a100
r4   = 0xbeac92fc, r5   = 0x40059d30
r6   = 0x00000233, r7   = 0xbeac9220
r8   = 0xbeac92cc, r9   = 0x404bdc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40392a00, sp   = 0xbeac91f0
lr   = 0x40392ab4, pc   = 0x40002c3c
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     95852 KB
Buffers:     25504 KB
Cached:     155780 KB
VmPeak:      64156 KB
VmSize:      64152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11788 KB
VmRSS:       11788 KB
VmData:      11544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23428 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2171 TID = 2171
2171 2173 

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
43524000 43e76000 rw-p [stack:2173]
beaa9000 beaca000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2171)
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
 2, messageName: app_paused[0;m
10-26 14:24:20.251+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-26 14:24:20.451+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236351 button=1
10-26 14:24:20.451+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.451+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:20.451+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-26 14:24:20.486+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.501+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.501+0200 W/APPS    (  766): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 14:24:20.511+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.526+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.536+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.551+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.561+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.576+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.586+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236484 button=1
10-26 14:24:20.586+0200 E/APPS    (  766): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-26 14:24:20.826+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 14:24:20.826+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 14:24:21.561+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=237462 button=1
10-26 14:24:21.561+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:21.566+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:21.566+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:21.651+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=237544 button=1
10-26 14:24:21.651+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:21.656+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:21.656+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:21.656+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:21.656+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:21.661+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:21.661+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:21.676+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:21.676+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 14:24:21.676+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:21.706+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:21.706+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:21.741+0200 I/efl-extension( 2047): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:21.746+0200 I/UXT     ( 2047): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:21.746+0200 I/CAPI_APPFW_APPLICATION( 2047): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:21.751+0200 I/CAPI_APPFW_APPLICATION( 2047): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:21.781+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:21.781+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2047)
10-26 14:24:21.781+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:21.781+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:21.871+0200 I/Bluetooth( 2047): [bt_initialize] success.
10-26 14:24:21.911+0200 I/Bluetooth( 2047): [bt_adapter_get_state] success.
10-26 14:24:22.116+0200 W/CRASH_MANAGER( 2141): worker.c: worker_job(1205) > 11020476461741509020661
10-26 14:24:22.426+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=238323 button=1
10-26 14:24:22.521+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=238419 button=1
10-26 14:24:22.811+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2047 pgid = 2047
10-26 14:24:22.826+0200 E/RESOURCED(  510): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.181
10-26 14:24:22.861+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 14:24:22.866+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2047
10-26 14:24:22.876+0200 E/RESOURCED(  510): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.182
10-26 14:24:22.886+0200 E/RESOURCED( 1074): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 14:24:22.886+0200 E/AUL     ( 1074): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 14:24:22.886+0200 E/CAPI_APPFW_APP_MANAGER( 1074): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 14:24:22.886+0200 E/RESOURCED(  835): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 14:24:22.891+0200 E/AUL     (  835): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 14:24:22.891+0200 E/CAPI_APPFW_APP_MANAGER(  835): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 14:24:23.031+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:24:23.036+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:24:23.061+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:24:23.061+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:24:23.096+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:24:23.096+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:24:23.096+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:24:23.096+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:24:23.096+0200 E/EFL     ( 2153): elementary<2153> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:24:23.111+0200 E/EFL     ( 2153): elementary<2153> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:24:23.116+0200 E/EFL     ( 2153): elementary<2153> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:24:23.116+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:24:23.121+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=239022 button=1
10-26 14:24:23.121+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:23.121+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:23.121+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:23.146+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:23.151+0200 E/EFL     ( 2153): elementary<2153> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:24:23.151+0200 E/EFL     ( 2153): elementary<2153> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:24:23.156+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:24:23.156+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:24:23.156+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:24:23.156+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:24:23.156+0200 E/EFL     ( 2153): elementary<2153> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:24:23.156+0200 I/AUL_PAD ( 2153): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 14:24:23.341+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=239241 button=1
10-26 14:24:23.341+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:23.341+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:23.341+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:23.341+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:23.366+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:23.366+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:23.366+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:23.376+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:23.376+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 14:24:23.376+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:23.421+0200 I/efl-extension( 2153): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:23.421+0200 I/UXT     ( 2153): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:23.426+0200 I/CAPI_APPFW_APPLICATION( 2153): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:23.426+0200 I/CAPI_APPFW_APPLICATION( 2153): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:23.431+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:23.436+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:23.476+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:23.481+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2153)
10-26 14:24:23.481+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:23.491+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:23.576+0200 I/Bluetooth( 2153): [bt_initialize] success.
10-26 14:24:23.606+0200 I/Bluetooth( 2153): [bt_adapter_get_state] success.
10-26 14:24:23.706+0200 W/CRASH_MANAGER( 2141): worker.c: worker_job(1205) > 11021536461741509020663
10-26 14:24:23.966+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=239866 button=1
10-26 14:24:24.291+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=240193 button=1
10-26 14:24:24.521+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2153 pgid = 2153
10-26 14:24:24.541+0200 E/RESOURCED(  510): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.187
10-26 14:24:24.581+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 14:24:24.586+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2153
10-26 14:24:24.591+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=240492 button=1
10-26 14:24:24.591+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.591+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:24.591+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:24.601+0200 E/RESOURCED(  510): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.188
10-26 14:24:24.611+0200 E/RESOURCED(  835): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 14:24:24.611+0200 E/RESOURCED( 1074): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 14:24:24.611+0200 E/AUL     (  835): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 14:24:24.611+0200 E/AUL     ( 1074): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 14:24:24.616+0200 E/CAPI_APPFW_APP_MANAGER(  835): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 14:24:24.616+0200 E/CAPI_APPFW_APP_MANAGER( 1074): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 14:24:24.666+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.686+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.701+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.711+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.736+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.751+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.821+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:24.836+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=240734 button=1
10-26 14:24:24.836+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:24.836+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:24.836+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:24.836+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:24.836+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:24.841+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:24.841+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:24.851+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:24.851+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 14:24:24.851+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:24.851+0200 E/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 14:24:24.851+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 14:24:24.856+0200 W/AUL_AMD (  509): amd_launch.c: start_process(580) > child process: 2171
10-26 14:24:24.856+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:24.856+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:24.906+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 2171
10-26 14:24:24.906+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:24.906+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2171)
10-26 14:24:24.906+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:24.911+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:25.061+0200 I/efl-extension( 2171): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:25.081+0200 I/CAPI_APPFW_APPLICATION( 2171): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:25.091+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:24:25.091+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:24:25.111+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:24:25.116+0200 I/UXT     ( 2171): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:25.116+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:24:25.151+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:24:25.156+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:24:25.156+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:24:25.156+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:24:25.156+0200 E/EFL     ( 2171): elementary<2171> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:24:25.176+0200 E/EFL     ( 2171): elementary<2171> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:24:25.176+0200 E/EFL     ( 2171): elementary<2171> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:24:25.176+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:24:25.221+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:24:25.221+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:24:25.231+0200 E/EFL     ( 2171): elementary<2171> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:24:25.236+0200 E/EFL     ( 2171): elementary<2171> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:24:25.241+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:24:25.241+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:24:25.241+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:24:25.241+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:24:25.241+0200 E/EFL     ( 2171): elementary<2171> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:24:25.286+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=241185 button=1
10-26 14:24:25.306+0200 W/WECONN  (  577): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 14:24:25.381+0200 I/CAPI_APPFW_APPLICATION( 2171): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:25.556+0200 I/Bluetooth( 2171): [bt_initialize] success.
10-26 14:24:25.566+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=241465 button=1
10-26 14:24:25.596+0200 I/Bluetooth( 2171): [bt_adapter_get_state] success.
10-26 14:24:25.761+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=241660 button=1
10-26 14:24:25.891+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:25.896+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 14:24:25.921+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:25.926+0200 E/CAPI_APPFW_APP_MANAGER(  835): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 14:24:25.926+0200 E/CAPI_APPFW_APP_MANAGER(  835): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 14:24:25.931+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:25.931+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 14:24:25.931+0200 E/CAPI_APPFW_APP_MANAGER( 1074): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 14:24:25.931+0200 E/CAPI_APPFW_APP_MANAGER( 1074): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 14:24:25.976+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=241879 button=1
10-26 14:24:26.016+0200 W/AUL     ( 2176): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 14:24:26.016+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 14:24:26.016+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 14:24:26.016+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2171
10-26 14:24:26.016+0200 W/AUL_AMD (  509): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 14:24:26.071+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2171
10-26 14:24:26.276+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=242177 button=1
10-26 14:24:26.276+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:26.276+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:26.276+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:26.376+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:26.521+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=242420 button=1
10-26 14:24:26.521+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:26.521+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:26.521+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:26.521+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:26.521+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:26.526+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:26.526+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:26.541+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:26.541+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 14:24:26.541+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:26.541+0200 E/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 14:24:26.541+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 14:24:26.541+0200 W/AUL_AMD (  509): amd_launch.c: start_process(580) > child process: 2178
10-26 14:24:26.546+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:26.546+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:26.596+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 2178
10-26 14:24:26.601+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:26.601+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:26.601+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2178)
10-26 14:24:26.601+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:26.821+0200 I/efl-extension( 2178): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:26.856+0200 I/CAPI_APPFW_APPLICATION( 2178): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:26.881+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:24:26.891+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:24:26.926+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:24:26.946+0200 I/UXT     ( 2178): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:26.946+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:24:26.996+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:24:26.996+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:24:27.001+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:24:27.001+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:24:27.001+0200 E/EFL     ( 2178): elementary<2178> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:24:27.031+0200 E/EFL     ( 2178): elementary<2178> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:24:27.031+0200 E/EFL     ( 2178): elementary<2178> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:24:27.041+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:24:27.096+0200 E/EFL     ( 2178): elementary<2178> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:24:27.101+0200 E/EFL     ( 2178): elementary<2178> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:24:27.106+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:24:27.106+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:24:27.106+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:24:27.106+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:24:27.106+0200 E/EFL     ( 2178): elementary<2178> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:24:27.191+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:27.196+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2178
10-26 14:24:27.241+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:27.251+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2178
10-26 14:24:27.251+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 14:24:27.251+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 14:24:27.261+0200 I/CAPI_APPFW_APPLICATION( 2178): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:27.386+0200 I/Bluetooth( 2178): [bt_initialize] success.
10-26 14:24:27.416+0200 I/Bluetooth( 2178): [bt_adapter_get_state] success.
10-26 14:24:27.566+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:24:27.746+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:24:27.811+0200 W/AUL     ( 2187): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 14:24:27.821+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 14:24:27.826+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 14:24:27.826+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2178
10-26 14:24:27.826+0200 W/AUL_AMD (  509): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 14:24:27.856+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2178
10-26 14:24:27.871+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 14:24:28.346+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:24:28.366+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:24:28.536+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:24:28.536+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:24:28.536+0200 E/EFL     ( 2165): elementary<2165> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:24:29.236+0200 E/EFL     ( 2165): elementary<2165> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:24:29.236+0200 E/EFL     ( 2165): elementary<2165> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:24:29.241+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:24:29.246+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=245144 button=1
10-26 14:24:29.246+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:29.246+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:29.246+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:29.296+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=245195 button=1
10-26 14:24:29.296+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:29.296+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:29.296+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:29.296+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:29.301+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:29.306+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:29.306+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:29.316+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:29.316+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 14:24:29.316+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:29.316+0200 E/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 14:24:29.316+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 14:24:29.321+0200 W/AUL_AMD (  509): amd_launch.c: start_process(580) > child process: 2192
10-26 14:24:29.321+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:29.321+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:29.381+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 2192
10-26 14:24:29.381+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:29.386+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2192)
10-26 14:24:29.386+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:29.391+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:29.471+0200 I/efl-extension( 2192): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:29.506+0200 I/CAPI_APPFW_APPLICATION( 2192): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:29.531+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:24:29.531+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:24:29.566+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:24:29.581+0200 I/UXT     ( 2192): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:29.581+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:24:29.621+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:24:29.626+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:24:29.626+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:24:29.626+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:24:29.626+0200 E/EFL     ( 2192): elementary<2192> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:24:29.656+0200 E/EFL     ( 2192): elementary<2192> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:24:29.656+0200 E/EFL     ( 2192): elementary<2192> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:24:29.661+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:24:29.711+0200 E/EFL     ( 2192): elementary<2192> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:24:29.711+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:29.721+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2192
10-26 14:24:29.726+0200 E/EFL     ( 2192): elementary<2192> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:24:29.731+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:24:29.731+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:24:29.731+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:24:29.731+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:24:29.731+0200 E/EFL     ( 2192): elementary<2192> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:24:29.836+0200 I/CAPI_APPFW_APPLICATION( 2192): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:29.981+0200 I/Bluetooth( 2192): [bt_initialize] success.
10-26 14:24:30.011+0200 I/Bluetooth( 2192): [bt_adapter_get_state] success.
10-26 14:24:30.141+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:30.146+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2192
10-26 14:24:30.146+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=246037 button=1
10-26 14:24:30.146+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 14:24:30.146+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 14:24:30.196+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=246096 button=1
10-26 14:24:30.406+0200 W/AUL     ( 2197): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 14:24:30.406+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 14:24:30.406+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 14:24:30.406+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2192
10-26 14:24:30.406+0200 W/AUL_AMD (  509): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 14:24:30.446+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2192
10-26 14:24:30.691+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=246592 button=1
10-26 14:24:30.691+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:30.691+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:30.691+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:30.746+0200 E/EFL     ( 2165): elementary<2165> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:24:30.751+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:30.766+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=246664 button=1
10-26 14:24:30.766+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:30.766+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:30.766+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:30.766+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:30.766+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:30.766+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:30.766+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:30.776+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:30.781+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 14:24:30.781+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:30.781+0200 E/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 14:24:30.781+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:30.781+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:30.781+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 14:24:30.781+0200 W/AUL_AMD (  509): amd_launch.c: start_process(580) > child process: 2199
10-26 14:24:30.831+0200 W/AUL_AMD (  509): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 2199
10-26 14:24:30.836+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:30.836+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2199)
10-26 14:24:30.836+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:30.836+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:30.986+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=246884 button=1
10-26 14:24:31.006+0200 I/efl-extension( 2199): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:31.016+0200 E/EFL     ( 2165): elementary<2165> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:24:31.041+0200 I/CAPI_APPFW_APPLICATION( 2199): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:31.046+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=246944 button=1
10-26 14:24:31.061+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:24:31.066+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:24:31.076+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:24:31.101+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:24:31.116+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:24:31.126+0200 I/UXT     ( 2199): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:31.131+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:24:31.131+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:24:31.141+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:24:31.151+0200 E/EFL     ( 2165): elementary<2165> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:24:31.156+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=247055 button=1
10-26 14:24:31.156+0200 I/AUL_PAD ( 2165): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 14:24:31.181+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:24:31.181+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:24:31.181+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:24:31.181+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:24:31.181+0200 E/EFL     ( 2199): elementary<2199> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:24:31.211+0200 E/EFL     ( 2199): elementary<2199> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:24:31.216+0200 E/EFL     (  509): ecore_x<509> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=247115 button=1
10-26 14:24:31.216+0200 E/EFL     ( 2199): elementary<2199> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:24:31.221+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:24:31.271+0200 E/EFL     ( 2199): elementary<2199> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:24:31.281+0200 E/EFL     ( 2199): elementary<2199> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:24:31.281+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:24:31.281+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:24:31.281+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:24:31.281+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:24:31.281+0200 E/EFL     ( 2199): elementary<2199> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:24:31.296+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:31.301+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2199
10-26 14:24:31.301+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:31.311+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2199
10-26 14:24:31.311+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 14:24:31.311+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 14:24:31.411+0200 I/CAPI_APPFW_APPLICATION( 2199): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:31.541+0200 I/Bluetooth( 2199): [bt_initialize] success.
10-26 14:24:31.566+0200 I/Bluetooth( 2199): [bt_adapter_get_state] success.
10-26 14:24:31.986+0200 W/AUL     ( 2204): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 14:24:31.991+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 14:24:31.991+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 14:24:31.991+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2199
10-26 14:24:31.991+0200 W/AUL_AMD (  509): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 14:24:32.026+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2199
10-26 14:24:32.691+0200 W/CRASH_MANAGER( 2141): worker.c: worker_job(1205) > 1102171646174150902066
