S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 19224
Date: 2017-10-26 13:10:32+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b71a8, r1   = 0x00000001
r2   = 0x00000001, r3   = 0xfa9c3700
r4   = 0xbee2a2fc, r5   = 0x40059d30
r6   = 0x00000233, r7   = 0xbee2a228
r8   = 0xbee2a2cc, r9   = 0x404bdc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40392a00, sp   = 0xbee2a1f8
lr   = 0x40392ab4, pc   = 0x40003718
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:      9512 KB
Buffers:     45416 KB
Cached:     179452 KB
VmPeak:      64156 KB
VmSize:      64152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11716 KB
VmRSS:       11716 KB
VmData:      11544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23428 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19224 TID = 19224
19224 19225 

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
43524000 43e76000 rw-p [stack:19225]
bee0a000 bee2b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19224)
Call Stack Count: 8
 0: start_bt_server + 0x13 (0x40003718) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3718
 1: app_create + 0x38 (0x40001ffd) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1ffd
 2: (0x4004f9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x404b4457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x40050421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x40001f5f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f5f
 6: __libc_start_main + 0x114 (0x4033b82c) [/lib/libc.so.6] + 0x1782c
 7: (0x40001a74) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1a74
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
/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:10:30.825+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:10:30.830+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:10:30.830+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:10:30.885+0200 I/efl-extension(19125): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:30.885+0200 I/UXT     (19125): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:30.890+0200 I/CAPI_APPFW_APPLICATION(19125): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:10:30.890+0200 I/CAPI_APPFW_APPLICATION(19125): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:10:30.930+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:10:30.930+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(19125)
10-26 13:10:30.930+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:10:30.930+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:10:31.025+0200 I/Bluetooth(19125): [bt_initialize] success.
10-26 13:10:31.775+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7626127 button=1
10-26 13:10:31.835+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7626188 button=1
10-26 13:10:31.960+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19125 pgid = 19125
10-26 13:10:31.970+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.565
10-26 13:10:32.010+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:10:32.010+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19125
10-26 13:10:32.020+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.566
10-26 13:10:32.030+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:32.030+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:32.030+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:32.030+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:32.030+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:32.030+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:32.030+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:32.030+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:32.030+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:32.210+0200 E/EFL     (19222): elementary<19222> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:32.215+0200 E/EFL     (19222): elementary<19222> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:32.280+0200 E/EFL     (19222): elementary<19222> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:32.295+0200 E/EFL     (19222): elementary<19222> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:32.340+0200 E/EFL     (19222): elementary<19222> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:32.340+0200 E/EFL     (19222): elementary<19222> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:32.365+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7626713 button=1
10-26 13:10:32.365+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:32.365+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:10:32.365+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:10:32.370+0200 E/EFL     (19222): elementary<19222> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:32.370+0200 E/EFL     (19222): elementary<19222> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:32.370+0200 E/EFL     (19222): elementary<19222> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:32.450+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7626799 button=1
10-26 13:10:32.450+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:10:32.450+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:10:32.450+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:10:32.450+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:10:32.450+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:10:32.455+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:10:32.455+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:10:32.470+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:10:32.470+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:10:32.470+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:10:32.470+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:10:32.470+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:10:32.470+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:10:32.470+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:10:32.475+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 19224
10-26 13:10:32.525+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 19224
10-26 13:10:32.525+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:10:32.525+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(19224)
10-26 13:10:32.525+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:10:32.525+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:10:32.570+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:32.610+0200 I/efl-extension(19224): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:32.625+0200 I/CAPI_APPFW_APPLICATION(19224): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:10:32.630+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19224
10-26 13:10:32.635+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:32.640+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19224
10-26 13:10:32.640+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:32.640+0200 E/EFL     (19222): elementary<19222> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:32.640+0200 E/EFL     (19222): elementary<19222> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:32.640+0200 E/EFL     (19222): elementary<19222> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:32.650+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19224
10-26 13:10:32.650+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:10:32.650+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:10:32.650+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:10:32.665+0200 E/EFL     (19224): elementary<19224> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:32.665+0200 E/EFL     (19224): elementary<19224> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:32.690+0200 E/EFL     (19224): elementary<19224> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:32.690+0200 I/UXT     (19224): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:32.690+0200 E/EFL     (19224): elementary<19224> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:32.730+0200 E/EFL     (19224): elementary<19224> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:32.730+0200 E/EFL     (19224): elementary<19224> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:32.730+0200 E/EFL     (19224): elementary<19224> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:32.730+0200 E/EFL     (19224): elementary<19224> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:32.730+0200 E/EFL     (19224): elementary<19224> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:32.750+0200 E/EFL     (19224): elementary<19224> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:32.750+0200 E/EFL     (19224): elementary<19224> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:32.750+0200 E/EFL     (19224): elementary<19224> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:32.760+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:10:32.785+0200 E/EFL     (19224): elementary<19224> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:32.795+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7627145 button=1
10-26 13:10:32.795+0200 E/EFL     (19224): elementary<19224> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:32.795+0200 E/EFL     (19224): elementary<19224> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:32.795+0200 E/EFL     (19224): elementary<19224> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:32.795+0200 E/EFL     (19224): elementary<19224> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:32.795+0200 E/EFL     (19224): elementary<19224> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:32.800+0200 E/EFL     (19224): elementary<19224> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:32.850+0200 I/CAPI_APPFW_APPLICATION(19224): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:10:32.880+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7627231 button=1
10-26 13:10:32.900+0200 E/EFL     (19222): elementary<19222> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:32.905+0200 E/EFL     (19222): elementary<19222> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:32.905+0200 E/EFL     (19222): elementary<19222> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:32.910+0200 E/EFL     (19222): elementary<19222> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:32.910+0200 E/EFL     (19222): elementary<19222> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:32.910+0200 E/EFL     (19222): elementary<19222> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:32.910+0200 E/EFL     (19222): elementary<19222> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:32.910+0200 I/AUL_PAD (19222): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:10:32.980+0200 I/Bluetooth(19224): [bt_initialize] success.
10-26 13:10:33.115+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7627466 button=1
10-26 13:10:33.260+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7627613 button=1
10-26 13:10:33.380+0200 W/AUL     (19229): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:10:33.380+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:10:33.380+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:10:33.380+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 19224
10-26 13:10:33.380+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:10:33.385+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19224
10-26 13:10:33.475+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7627824 button=1
10-26 13:10:33.535+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.570+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.595+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7627947 button=1
10-26 13:10:33.780+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7628133 button=1
10-26 13:10:33.780+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.785+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:10:33.785+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:10:33.805+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.820+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.830+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.840+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.855+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.880+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.890+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.915+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:33.930+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7628280 button=1
10-26 13:10:33.930+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:10:33.930+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:10:33.930+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:10:33.930+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:10:33.930+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:10:33.930+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:10:33.930+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:10:33.945+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:10:33.945+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:10:33.945+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:10:33.945+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:10:33.945+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:10:33.995+0200 I/efl-extension(19222): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:34.000+0200 I/UXT     (19222): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:34.000+0200 I/CAPI_APPFW_APPLICATION(19222): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:10:34.005+0200 I/CAPI_APPFW_APPLICATION(19222): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:10:34.050+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(19222)
10-26 13:10:34.050+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:10:34.050+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:10:34.065+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:10:34.125+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7628478 button=1
10-26 13:10:34.145+0200 I/Bluetooth(19222): [bt_initialize] success.
10-26 13:10:34.235+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7628589 button=1
10-26 13:10:34.520+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7628873 button=1
10-26 13:10:34.620+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7628972 button=1
10-26 13:10:34.855+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7629207 button=1
10-26 13:10:34.990+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7629342 button=1
10-26 13:10:35.080+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19222 pgid = 19222
10-26 13:10:35.085+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:35.085+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:35.085+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:35.090+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.575
10-26 13:10:35.115+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:35.115+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:35.115+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:35.130+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:10:35.130+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19222
10-26 13:10:35.135+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:35.135+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:35.140+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:35.140+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.576
10-26 13:10:35.190+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7629540 button=1
10-26 13:10:35.190+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:35.190+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:10:35.190+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:10:35.310+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7629663 button=1
10-26 13:10:35.310+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:10:35.315+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:10:35.315+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:10:35.315+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:10:35.315+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:10:35.315+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:10:35.315+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:10:35.330+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:10:35.330+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:10:35.330+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:10:35.330+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:10:35.330+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:10:35.330+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:10:35.330+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:10:35.330+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 19238
10-26 13:10:35.380+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 19238
10-26 13:10:35.380+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:10:35.385+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(19238)
10-26 13:10:35.385+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:10:35.385+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:10:35.445+0200 I/efl-extension(19238): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:35.460+0200 I/CAPI_APPFW_APPLICATION(19238): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:10:35.475+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:35.475+0200 E/EFL     (19238): elementary<19238> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:35.480+0200 E/EFL     (19238): elementary<19238> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:35.485+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19238
10-26 13:10:35.485+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:35.490+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19238
10-26 13:10:35.495+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:10:35.500+0200 E/EFL     (19238): elementary<19238> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:35.505+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:10:35.510+0200 I/UXT     (19238): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:35.510+0200 E/EFL     (19238): elementary<19238> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:35.540+0200 E/EFL     (19238): elementary<19238> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:35.545+0200 E/EFL     (19238): elementary<19238> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:35.545+0200 E/EFL     (19238): elementary<19238> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:35.545+0200 E/EFL     (19238): elementary<19238> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:35.545+0200 E/EFL     (19238): elementary<19238> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:35.575+0200 E/EFL     (19238): elementary<19238> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:35.575+0200 E/EFL     (19238): elementary<19238> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:35.575+0200 E/EFL     (19238): elementary<19238> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:35.600+0200 E/EFL     (19236): elementary<19236> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:35.600+0200 E/EFL     (19236): elementary<19236> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:35.605+0200 E/EFL     (19238): elementary<19238> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:35.615+0200 E/EFL     (19238): elementary<19238> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:35.615+0200 E/EFL     (19238): elementary<19238> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:35.615+0200 E/EFL     (19238): elementary<19238> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:35.615+0200 E/EFL     (19238): elementary<19238> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:35.615+0200 E/EFL     (19238): elementary<19238> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:35.615+0200 E/EFL     (19238): elementary<19238> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:35.650+0200 E/EFL     (19236): elementary<19236> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:35.655+0200 E/EFL     (19236): elementary<19236> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:35.675+0200 I/CAPI_APPFW_APPLICATION(19238): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:10:35.680+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:35.685+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19238
10-26 13:10:35.695+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:10:35.700+0200 E/EFL     (19236): elementary<19236> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:35.700+0200 E/EFL     (19236): elementary<19236> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:35.700+0200 E/EFL     (19236): elementary<19236> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:35.700+0200 E/EFL     (19236): elementary<19236> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:35.700+0200 E/EFL     (19236): elementary<19236> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:35.830+0200 I/Bluetooth(19238): [bt_initialize] success.
10-26 13:10:35.865+0200 E/EFL     (19236): elementary<19236> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:35.880+0200 E/EFL     (19236): elementary<19236> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:35.890+0200 E/EFL     (19236): elementary<19236> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:36.015+0200 E/EFL     (19236): elementary<19236> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:36.025+0200 E/EFL     (19236): elementary<19236> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:36.025+0200 E/EFL     (19236): elementary<19236> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:36.025+0200 E/EFL     (19236): elementary<19236> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:36.025+0200 E/EFL     (19236): elementary<19236> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:36.025+0200 E/EFL     (19236): elementary<19236> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:36.025+0200 E/EFL     (19236): elementary<19236> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:36.025+0200 I/AUL_PAD (19236): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:10:36.175+0200 W/AUL     (19243): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:10:36.175+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:10:36.175+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:10:36.175+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 19238
10-26 13:10:36.175+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:10:36.210+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19238
10-26 13:10:37.020+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7631368 button=1
10-26 13:10:37.020+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:37.020+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:10:37.020+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:10:37.065+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:10:37.080+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7631428 button=1
10-26 13:10:37.080+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:10:37.080+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:10:37.080+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:10:37.080+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:10:37.080+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:10:37.085+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:10:37.085+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:10:37.095+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:10:37.095+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:10:37.095+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:10:37.100+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:10:37.100+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:10:37.145+0200 I/efl-extension(19236): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:37.150+0200 I/UXT     (19236): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:37.150+0200 I/CAPI_APPFW_APPLICATION(19236): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:10:37.155+0200 I/CAPI_APPFW_APPLICATION(19236): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:10:37.200+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:10:37.200+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(19236)
10-26 13:10:37.200+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:10:37.230+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:10:37.265+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7631614 button=1
10-26 13:10:37.295+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:10:37.310+0200 I/Bluetooth(19236): [bt_initialize] success.
10-26 13:10:37.360+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7631712 button=1
10-26 13:10:37.595+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7631947 button=1
10-26 13:10:37.680+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7632033 button=1
10-26 13:10:37.905+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7632256 button=1
10-26 13:10:37.980+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7632329 button=1
10-26 13:10:38.230+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19236 pgid = 19236
10-26 13:10:38.245+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.585
10-26 13:10:38.280+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:10:38.285+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19236
10-26 13:10:38.290+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.586
10-26 13:10:38.305+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:38.305+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:38.305+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:38.305+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:38.305+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:38.305+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:38.305+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:38.305+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:38.305+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:38.480+0200 E/EFL     (19253): elementary<19253> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:38.485+0200 E/EFL     (19253): elementary<19253> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:38.535+0200 E/EFL     (19253): elementary<19253> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:38.535+0200 E/EFL     (19253): elementary<19253> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:38.580+0200 E/EFL     (19253): elementary<19253> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:38.580+0200 E/EFL     (19253): elementary<19253> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:38.585+0200 E/EFL     (19253): elementary<19253> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:38.585+0200 E/EFL     (19253): elementary<19253> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:38.585+0200 E/EFL     (19253): elementary<19253> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:38.655+0200 E/EFL     (19253): elementary<19253> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:38.670+0200 E/EFL     (19253): elementary<19253> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:38.670+0200 E/EFL     (19253): elementary<19253> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:38.765+0200 E/EFL     (19253): elementary<19253> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:38.775+0200 E/EFL     (19253): elementary<19253> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:38.780+0200 E/EFL     (19253): elementary<19253> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:38.780+0200 E/EFL     (19253): elementary<19253> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:38.785+0200 E/EFL     (19253): elementary<19253> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:38.785+0200 E/EFL     (19253): elementary<19253> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:38.785+0200 E/EFL     (19253): elementary<19253> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:38.785+0200 I/AUL_PAD (19253): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:10:38.805+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:10:38.805+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:10:38.805+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:10:38.825+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 13:10:38.825+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 13:10:38.825+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 13:10:38.825+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:10:38.825+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _state_control(344) > appcore paused manually
10-26 13:10:38.825+0200 W/W_HOME  (  769): main.c: home_appcore_pause(723) > Home Appcore Paused
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:10:38.825+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:10:38.835+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-26 13:10:38.835+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 13:10:38.835+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 13:10:38.835+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 13:10:38.835+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:10:38.835+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:10:38.835+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:10:38.835+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:10:39.070+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:10:39.080+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:10:39.080+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:10:39.095+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-26 13:10:39.095+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:10:39.095+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 13:10:39.095+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 13:10:39.095+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 13:10:59), repeat(1), interval(20), type(-1073741822)
10-26 13:10:39.100+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:10:39.100+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:10:39.100+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:10:39.100+0200 E/W_HOME  (  769): main.c: _pause_cb(674) > paused already
10-26 13:10:39.130+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:10:39.155+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:10:39.175+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2054309840, next duetime: 1509016259
10-26 13:10:39.175+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(2054309840)
10-26 13:10:39.175+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509016259)
10-26 13:10:39.175+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:10:39.175+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:10:59 (UTC).
10-26 13:10:39.175+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:10:39.395+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:10:39.705+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11191256461741509016231
10-26 13:10:39.885+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 1119224646174150901623
