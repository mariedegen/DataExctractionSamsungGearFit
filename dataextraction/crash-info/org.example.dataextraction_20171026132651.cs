S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 21933
Date: 2017-10-26 13:26:51+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b5e00, r1   = 0x00000001
r2   = 0x4044a250, r3   = 0xbb4ea800
r4   = 0xbedbb2fc, r5   = 0x40059d30
r6   = 0x00000233, r7   = 0xbedbb220
r8   = 0xbedbb2cc, r9   = 0x404bdc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40392a00, sp   = 0xbedbb1f0
lr   = 0x40392ab4, pc   = 0x40002c3c
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     17556 KB
Buffers:     47848 KB
Cached:     163616 KB
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
PID = 21933 TID = 21933
21933 21934 

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
43524000 43e76000 rw-p [stack:21934]
bed9b000 bedbc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21933)
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
-> apps_util_launch_main_operation() return
10-26 13:26:47.945+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:26:48.045+0200 I/Bluetooth(21896): [bt_initialize] success.
10-26 13:26:48.065+0200 I/Bluetooth(21896): [bt_adapter_get_state] success.
10-26 13:26:48.300+0200 W/CRASH_MANAGER(21900): worker.c: worker_job(1205) > 11218966461741509017208
10-26 13:26:48.310+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8602659 button=1
10-26 13:26:48.550+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8602903 button=1
10-26 13:26:48.900+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8603249 button=1
10-26 13:26:48.970+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 21896 pgid = 21896
10-26 13:26:48.980+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:48.980+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:48.980+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:48.980+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:48.980+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:48.985+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.738
10-26 13:26:48.985+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:49.020+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.025+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:26:49.030+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21896
10-26 13:26:49.035+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.739
10-26 13:26:49.050+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:49.050+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:49.050+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:49.070+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8603421 button=1
10-26 13:26:49.200+0200 E/EFL     (21913): elementary<21913> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:26:49.200+0200 E/EFL     (21913): elementary<21913> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:26:49.345+0200 E/EFL     (21913): elementary<21913> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:26:49.345+0200 E/EFL     (21913): elementary<21913> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:26:49.375+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8603723 button=1
10-26 13:26:49.375+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.375+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:26:49.375+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:26:49.410+0200 E/EFL     (21913): elementary<21913> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:26:49.410+0200 E/EFL     (21913): elementary<21913> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:26:49.410+0200 E/EFL     (21913): elementary<21913> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:26:49.410+0200 E/EFL     (21913): elementary<21913> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:26:49.410+0200 E/EFL     (21913): elementary<21913> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:26:49.435+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.435+0200 E/EFL     (21913): elementary<21913> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:26:49.440+0200 E/EFL     (21913): elementary<21913> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:26:49.440+0200 E/EFL     (21913): elementary<21913> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:26:49.460+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.485+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.495+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.505+0200 E/EFL     (21913): elementary<21913> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:26:49.515+0200 E/EFL     (21913): elementary<21913> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:26:49.515+0200 E/EFL     (21913): elementary<21913> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:26:49.515+0200 E/EFL     (21913): elementary<21913> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:26:49.515+0200 E/EFL     (21913): elementary<21913> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:26:49.515+0200 E/EFL     (21913): elementary<21913> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:26:49.515+0200 E/EFL     (21913): elementary<21913> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:26:49.515+0200 I/AUL_PAD (21913): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:26:49.635+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:49.640+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8603993 button=1
10-26 13:26:49.645+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:26:49.645+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:26:49.645+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:26:49.645+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:26:49.645+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:26:49.650+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:26:49.650+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:26:49.660+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:26:49.660+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:26:49.660+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:26:49.665+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:26:49.665+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:26:49.720+0200 I/efl-extension(21913): efl_extension.c: eext_mod_init(40) > Init
10-26 13:26:49.725+0200 I/UXT     (21913): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:26:49.730+0200 I/CAPI_APPFW_APPLICATION(21913): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:26:49.735+0200 I/CAPI_APPFW_APPLICATION(21913): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:26:49.765+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(21913)
10-26 13:26:49.765+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:26:49.800+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:26:49.800+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:26:49.865+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8604215 button=1
10-26 13:26:49.890+0200 I/Bluetooth(21913): [bt_initialize] success.
10-26 13:26:49.915+0200 I/Bluetooth(21913): [bt_adapter_get_state] success.
10-26 13:26:50.020+0200 W/CRASH_MANAGER(21900): worker.c: worker_job(1205) > 11219136461741509017209
10-26 13:26:50.120+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8604474 button=1
10-26 13:26:50.370+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8604721 button=1
10-26 13:26:50.665+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8605016 button=1
10-26 13:26:50.810+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 21913 pgid = 21913
10-26 13:26:50.825+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.744
10-26 13:26:50.875+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:26:50.880+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21913
10-26 13:26:50.895+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.745
10-26 13:26:50.965+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8605318 button=1
10-26 13:26:50.965+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:50.970+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:26:50.970+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:26:51.005+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:51.005+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:51.010+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:51.025+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:51.025+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:51.025+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:51.040+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.065+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.115+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.160+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:51.160+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:51.160+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:51.190+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.225+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.235+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.260+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.310+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.325+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:51.335+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8605687 button=1
10-26 13:26:51.340+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:26:51.340+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:26:51.340+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:26:51.340+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:26:51.345+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:26:51.345+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:26:51.345+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:26:51.365+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:26:51.370+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:26:51.370+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:26:51.370+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:26:51.370+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:26:51.370+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 21933
10-26 13:26:51.375+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:26:51.375+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:26:51.420+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 21933
10-26 13:26:51.420+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:26:51.425+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(21933)
10-26 13:26:51.425+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:26:51.435+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:26:51.515+0200 I/efl-extension(21933): efl_extension.c: eext_mod_init(40) > Init
10-26 13:26:51.535+0200 I/CAPI_APPFW_APPLICATION(21933): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:26:51.545+0200 E/EFL     (21933): elementary<21933> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:26:51.545+0200 E/EFL     (21933): elementary<21933> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:26:51.570+0200 E/EFL     (21933): elementary<21933> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:26:51.570+0200 I/UXT     (21933): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:26:51.570+0200 E/EFL     (21933): elementary<21933> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:26:51.605+0200 E/EFL     (21933): elementary<21933> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:26:51.605+0200 E/EFL     (21933): elementary<21933> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:26:51.605+0200 E/EFL     (21933): elementary<21933> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:26:51.605+0200 E/EFL     (21933): elementary<21933> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:26:51.610+0200 E/EFL     (21933): elementary<21933> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:26:51.630+0200 E/EFL     (21933): elementary<21933> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:26:51.630+0200 E/EFL     (21933): elementary<21933> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:26:51.630+0200 E/EFL     (21933): elementary<21933> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:26:51.660+0200 E/EFL     (21933): elementary<21933> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:26:51.670+0200 E/EFL     (21933): elementary<21933> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:26:51.670+0200 E/EFL     (21933): elementary<21933> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:26:51.670+0200 E/EFL     (21933): elementary<21933> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:26:51.670+0200 E/EFL     (21933): elementary<21933> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:26:51.670+0200 E/EFL     (21933): elementary<21933> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:26:51.670+0200 E/EFL     (21933): elementary<21933> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:26:51.720+0200 I/CAPI_APPFW_APPLICATION(21933): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:26:51.810+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 13:26:51.830+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 13:26:51.840+0200 I/Bluetooth(21933): [bt_initialize] success.
10-26 13:26:51.870+0200 I/Bluetooth(21933): [bt_adapter_get_state] success.
10-26 13:26:52.035+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:26:52.040+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:26:52.045+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:26:52.050+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:26:52.050+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:26:52.050+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:52.055+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:26:52.055+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:52.220+0200 W/AUL     (21936): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:26:52.245+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:26:52.245+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:26:52.245+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 21933
10-26 13:26:52.245+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:26:52.270+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21933
10-26 13:26:53.155+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:26:53.155+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:26:53.155+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:26:53.155+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
10-26 13:26:53.275+0200 I/AUL     ( 5342): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:26:53.325+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:53.325+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(234) > Failed to get the cmdline of pgid, error: -1
10-26 13:26:53.325+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:53.600+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-26 13:26:53.600+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:26:53.600+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:26:53.600+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:26:53.600+0200 E/wnoti-service(  876): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-26 13:26:53.600+0200 E/wnoti-service(  876): wnoti-native-client.c: handle_cache_notification(603) > >>
10-26 13:26:53.755+0200 W/SHealth_Service( 1085): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-26 13:26:54.240+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 13:26:54.240+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 13:26:54.240+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 13:26:54.240+0200 W/SHealth_Service( 1085): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-26 13:26:55.935+0200 E/EFL     (21927): elementary<21927> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:26:56.300+0200 E/EFL     (21927): elementary<21927> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:26:56.645+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8610993 button=1
10-26 13:26:56.645+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.645+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:26:56.645+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:26:56.690+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.715+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.755+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.815+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.840+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.865+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.875+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.885+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.900+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:56.915+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8611263 button=1
10-26 13:26:56.915+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:26:56.915+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:26:56.915+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:26:56.915+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:26:56.920+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:26:56.920+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:26:56.920+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:26:56.930+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:26:56.930+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:26:56.930+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:26:56.930+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:26:56.935+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:26:56.935+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:26:56.935+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:26:56.940+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 21953
10-26 13:26:56.990+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 21953
10-26 13:26:56.990+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:26:56.995+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(21953)
10-26 13:26:56.995+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:26:57.000+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:26:57.110+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8611461 button=1
10-26 13:26:57.150+0200 I/efl-extension(21953): efl_extension.c: eext_mod_init(40) > Init
10-26 13:26:57.180+0200 I/CAPI_APPFW_APPLICATION(21953): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:26:57.200+0200 E/EFL     (21953): elementary<21953> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:26:57.210+0200 E/EFL     (21953): elementary<21953> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:26:57.250+0200 E/EFL     (21953): elementary<21953> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:26:57.260+0200 I/UXT     (21953): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:26:57.265+0200 E/EFL     (21953): elementary<21953> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:26:57.305+0200 E/EFL     (21953): elementary<21953> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:26:57.305+0200 E/EFL     (21953): elementary<21953> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:26:57.310+0200 E/EFL     (21953): elementary<21953> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:26:57.310+0200 E/EFL     (21953): elementary<21953> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:26:57.310+0200 E/EFL     (21953): elementary<21953> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:26:57.330+0200 E/EFL     (21953): elementary<21953> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:26:57.345+0200 E/EFL     (21953): elementary<21953> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:26:57.345+0200 E/EFL     (21953): elementary<21953> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:26:57.395+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8611744 button=1
10-26 13:26:57.410+0200 E/EFL     (21953): elementary<21953> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:26:57.420+0200 E/EFL     (21953): elementary<21953> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:26:57.420+0200 E/EFL     (21953): elementary<21953> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:26:57.420+0200 E/EFL     (21953): elementary<21953> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:26:57.420+0200 E/EFL     (21953): elementary<21953> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:26:57.420+0200 E/EFL     (21953): elementary<21953> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:26:57.420+0200 E/EFL     (21953): elementary<21953> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:26:57.555+0200 I/CAPI_APPFW_APPLICATION(21953): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:26:57.605+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8611954 button=1
10-26 13:26:57.730+0200 I/Bluetooth(21953): [bt_initialize] success.
10-26 13:26:57.765+0200 I/Bluetooth(21953): [bt_adapter_get_state] success.
10-26 13:26:57.875+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8612225 button=1
10-26 13:26:57.940+0200 I/AUL     (  836): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:26:57.980+0200 E/EFL     (21927): elementary<21927> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:26:57.995+0200 E/EFL     (21927): elementary<21927> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:26:58.045+0200 E/EFL     (21927): elementary<21927> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:26:58.045+0200 E/EFL     (21927): elementary<21927> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:26:58.090+0200 E/EFL     (21927): elementary<21927> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:26:58.090+0200 E/EFL     (21927): elementary<21927> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:26:58.100+0200 E/EFL     (21927): elementary<21927> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:26:58.110+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8612460 button=1
10-26 13:26:58.110+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.110+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:26:58.110+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:26:58.140+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.145+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.160+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.160+0200 W/AUL     (21960): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:26:58.160+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:26:58.160+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:26:58.160+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 21953
10-26 13:26:58.160+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:26:58.170+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.195+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.205+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.220+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.225+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21953
10-26 13:26:58.245+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.280+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.305+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.330+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.340+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.365+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.380+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:26:58.390+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8612742 button=1
10-26 13:26:58.390+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:26:58.390+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:26:58.390+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:26:58.390+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:26:58.395+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:26:58.395+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:26:58.395+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:26:58.405+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:26:58.405+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:26:58.405+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:26:58.405+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:26:58.405+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:26:58.410+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 21962
10-26 13:26:58.410+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:26:58.410+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:26:58.465+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 21962
10-26 13:26:58.470+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(21962)
10-26 13:26:58.470+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:26:58.470+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:26:58.475+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:26:58.505+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 13:26:58.625+0200 I/efl-extension(21962): efl_extension.c: eext_mod_init(40) > Init
10-26 13:26:58.660+0200 I/CAPI_APPFW_APPLICATION(21962): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:26:58.685+0200 E/EFL     (21962): elementary<21962> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:26:58.685+0200 E/EFL     (21962): elementary<21962> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:26:58.725+0200 E/EFL     (21962): elementary<21962> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:26:58.740+0200 I/UXT     (21962): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:26:58.740+0200 E/EFL     (21962): elementary<21962> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:26:58.785+0200 E/EFL     (21962): elementary<21962> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:26:58.785+0200 E/EFL     (21962): elementary<21962> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:26:58.790+0200 E/EFL     (21962): elementary<21962> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:26:58.790+0200 E/EFL     (21962): elementary<21962> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:26:58.790+0200 E/EFL     (21962): elementary<21962> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:26:58.810+0200 E/EFL     (21962): elementary<21962> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:26:58.810+0200 E/EFL     (21962): elementary<21962> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:26:58.825+0200 E/EFL     (21962): elementary<21962> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:26:58.875+0200 E/EFL     (21962): elementary<21962> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:26:58.885+0200 E/EFL     (21962): elementary<21962> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:26:58.885+0200 E/EFL     (21962): elementary<21962> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:26:58.885+0200 E/EFL     (21962): elementary<21962> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:26:58.885+0200 E/EFL     (21962): elementary<21962> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:26:58.885+0200 E/EFL     (21962): elementary<21962> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:26:58.885+0200 E/EFL     (21962): elementary<21962> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:26:58.900+0200 I/AUL     (  836): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:26:58.985+0200 I/CAPI_APPFW_APPLICATION(21962): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:26:59.145+0200 I/Bluetooth(21962): [bt_initialize] success.
10-26 13:26:59.170+0200 I/Bluetooth(21962): [bt_adapter_get_state] success.
10-26 13:26:59.305+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:59.435+0200 E/EFL     (21927): elementary<21927> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:26:59.600+0200 W/AUL     (21968): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:26:59.600+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:26:59.600+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:26:59.600+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 21962
10-26 13:26:59.600+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:26:59.645+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21962
10-26 13:26:59.655+0200 E/EFL     (21927): elementary<21927> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:26:59.660+0200 E/EFL     (21927): elementary<21927> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:26:59.685+0200 I/AUL     (  836): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:26:59.685+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:59.685+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(234) > Failed to get the cmdline of pgid, error: -1
10-26 13:26:59.685+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:59.905+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-26 13:26:59.915+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:26:59.915+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:26:59.915+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:26:59.965+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 13:27:00.070+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 13:27:00.070+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 13:27:00.110+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 13:27:00.175+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 13:27:00.205+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 13:27:00.215+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:00.215+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:27:00.220+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:00.365+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:27:00.375+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:27:00.380+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:27:00.380+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:27:00.480+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 13:27:00.500+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:27:00.565+0200 I/AUL     ( 5342): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:27:00.570+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:00.570+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(234) > Failed to get the cmdline of pgid, error: -1
10-26 13:27:00.570+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:00.580+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:27:00.580+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:27:00.580+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:27:00.745+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 13:27:00.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 13:27:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 13:27:01.385+0200 E/EFL     (21927): elementary<21927> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:27:01.455+0200 E/EFL     (21927): elementary<21927> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:27:01.455+0200 E/EFL     (21927): elementary<21927> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:27:01.550+0200 E/EFL     (21927): elementary<21927> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:27:01.550+0200 E/EFL     (21927): elementary<21927> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:27:01.550+0200 E/EFL     (21927): elementary<21927> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:27:01.550+0200 E/EFL     (21927): elementary<21927> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:27:01.550+0200 I/AUL_PAD (21927): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:27:01.665+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 13:27:01.670+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 13:27:02.785+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:27:03.965+0200 W/CRASH_MANAGER(21900): worker.c: worker_job(1205) > 1121933646174150901721
