S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18523
Date: 2017-10-26 13:09:07+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b65b8, r1   = 0x00000001
r2   = 0x4044b250, r3   = 0xd5a34000
r4   = 0xbec0a2fc, r5   = 0x4005ad30
r6   = 0x00000233, r7   = 0xbec0a228
r8   = 0xbec0a2cc, r9   = 0x404bec84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40393a00, sp   = 0xbec0a1f8
lr   = 0x40393ab4, pc   = 0x40003754
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     17740 KB
Buffers:     44100 KB
Cached:     175208 KB
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
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18523 TID = 18523
18523 18526 

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
43524000 43e76000 rw-p [stack:18526]
bebea000 bec0b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18523)
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
elm_config_init done.
10-26 13:09:08.615+0200 E/EFL     (18532): elementary<18532> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:08.625+0200 E/EFL     (18532): elementary<18532> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:08.625+0200 E/EFL     (18532): elementary<18532> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:08.630+0200 E/EFL     (18532): elementary<18532> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:08.630+0200 E/EFL     (18532): elementary<18532> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:08.630+0200 E/EFL     (18532): elementary<18532> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:08.630+0200 E/EFL     (18532): elementary<18532> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:08.695+0200 I/CAPI_APPFW_APPLICATION(18532): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:08.805+0200 I/Bluetooth(18532): [bt_initialize] success.
10-26 13:09:09.035+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:09.040+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:09.040+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7543354 button=1
10-26 13:09:09.040+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:09.045+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:09.050+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:09.060+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:09.080+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:09.080+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:09.080+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:09.080+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:09.095+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:09.095+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:09.115+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7543464 button=1
10-26 13:09:09.205+0200 W/AUL     (18539): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:09:09.210+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:09:09.210+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:09:09.210+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 18532
10-26 13:09:09.210+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:09:09.215+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18532
10-26 13:09:09.615+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7543966 button=1
10-26 13:09:09.615+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:09.615+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:09.615+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:09:09.665+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:09.725+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7544076 button=1
10-26 13:09:09.725+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:09:09.725+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:09:09.725+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:09:09.725+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:09:09.725+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:09.725+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:09:09.725+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:09:09.740+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:09:09.740+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:09:09.740+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:09:09.740+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:09:09.740+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:09:09.740+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:09:09.745+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:09:09.745+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 18541
10-26 13:09:09.795+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 18541
10-26 13:09:09.795+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:09.795+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18541)
10-26 13:09:09.795+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:09:09.800+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:09:09.970+0200 I/efl-extension(18541): efl_extension.c: eext_mod_init(40) > Init
10-26 13:09:09.990+0200 I/CAPI_APPFW_APPLICATION(18541): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:09:10.000+0200 E/EFL     (18541): elementary<18541> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:10.000+0200 E/EFL     (18541): elementary<18541> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:10.025+0200 E/EFL     (18541): elementary<18541> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:10.025+0200 I/UXT     (18541): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:09:10.025+0200 E/EFL     (18541): elementary<18541> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:10.085+0200 E/EFL     (18541): elementary<18541> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:10.085+0200 E/EFL     (18541): elementary<18541> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:10.085+0200 E/EFL     (18541): elementary<18541> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:10.085+0200 E/EFL     (18541): elementary<18541> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:10.085+0200 E/EFL     (18541): elementary<18541> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:10.115+0200 E/EFL     (18541): elementary<18541> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:10.115+0200 E/EFL     (18541): elementary<18541> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:10.115+0200 E/EFL     (18541): elementary<18541> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:10.145+0200 E/EFL     (18541): elementary<18541> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:10.155+0200 E/EFL     (18541): elementary<18541> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:10.155+0200 E/EFL     (18541): elementary<18541> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:10.155+0200 E/EFL     (18541): elementary<18541> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:10.155+0200 E/EFL     (18541): elementary<18541> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:10.155+0200 E/EFL     (18541): elementary<18541> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:10.155+0200 E/EFL     (18541): elementary<18541> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:10.205+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7544556 button=1
10-26 13:09:10.225+0200 I/CAPI_APPFW_APPLICATION(18541): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:10.235+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:10.240+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18541
10-26 13:09:10.240+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:10.250+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18541
10-26 13:09:10.255+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:09:10.255+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:09:10.265+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7544616 button=1
10-26 13:09:10.355+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:10.360+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18541
10-26 13:09:10.365+0200 I/Bluetooth(18541): [bt_initialize] success.
10-26 13:09:10.385+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:09:10.515+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7544864 button=1
10-26 13:09:10.650+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7544999 button=1
10-26 13:09:10.765+0200 W/AUL     (18545): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:09:10.765+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:09:10.770+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:09:10.770+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 18541
10-26 13:09:10.770+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:09:10.780+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18541
10-26 13:09:10.905+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7545258 button=1
10-26 13:09:10.910+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:10.910+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:10.910+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:09:11.005+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:11.040+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7545393 button=1
10-26 13:09:11.045+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:09:11.045+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:09:11.045+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:09:11.045+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:09:11.045+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:11.045+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:09:11.045+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:09:11.060+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:09:11.060+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:09:11.060+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:09:11.060+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:09:11.060+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:09:11.060+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 18548
10-26 13:09:11.065+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:09:11.065+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:09:11.115+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 18548
10-26 13:09:11.115+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:11.115+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18548)
10-26 13:09:11.115+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:09:11.125+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:09:11.220+0200 I/efl-extension(18548): efl_extension.c: eext_mod_init(40) > Init
10-26 13:09:11.235+0200 I/CAPI_APPFW_APPLICATION(18548): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:09:11.250+0200 E/EFL     (18548): elementary<18548> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:11.250+0200 E/EFL     (18548): elementary<18548> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:11.280+0200 E/EFL     (18548): elementary<18548> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:11.280+0200 I/UXT     (18548): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:09:11.285+0200 E/EFL     (18548): elementary<18548> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:11.320+0200 E/EFL     (18548): elementary<18548> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:11.320+0200 E/EFL     (18548): elementary<18548> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:11.320+0200 E/EFL     (18548): elementary<18548> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:11.320+0200 E/EFL     (18548): elementary<18548> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:11.320+0200 E/EFL     (18548): elementary<18548> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:11.340+0200 E/EFL     (18548): elementary<18548> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:11.340+0200 E/EFL     (18548): elementary<18548> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:11.345+0200 E/EFL     (18548): elementary<18548> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:11.375+0200 E/EFL     (18548): elementary<18548> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:11.385+0200 E/EFL     (18548): elementary<18548> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:11.385+0200 E/EFL     (18548): elementary<18548> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:11.385+0200 E/EFL     (18548): elementary<18548> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:11.385+0200 E/EFL     (18548): elementary<18548> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:11.385+0200 E/EFL     (18548): elementary<18548> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:11.385+0200 E/EFL     (18548): elementary<18548> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:11.435+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7545784 button=1
10-26 13:09:11.445+0200 I/CAPI_APPFW_APPLICATION(18548): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:11.555+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7545907 button=1
10-26 13:09:11.575+0200 I/Bluetooth(18548): [bt_initialize] success.
10-26 13:09:11.680+0200 E/EFL     (18520): elementary<18520> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:11.680+0200 E/EFL     (18520): elementary<18520> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:11.700+0200 E/EFL     (18520): elementary<18520> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:11.705+0200 E/EFL     (18520): elementary<18520> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:11.760+0200 E/EFL     (18520): elementary<18520> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:11.760+0200 E/EFL     (18520): elementary<18520> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:11.760+0200 E/EFL     (18520): elementary<18520> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:11.760+0200 E/EFL     (18520): elementary<18520> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:11.760+0200 E/EFL     (18520): elementary<18520> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:11.780+0200 E/EFL     (18520): elementary<18520> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:11.780+0200 E/EFL     (18520): elementary<18520> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:11.780+0200 E/EFL     (18520): elementary<18520> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:11.810+0200 E/EFL     (18520): elementary<18520> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:11.820+0200 E/EFL     (18520): elementary<18520> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:11.820+0200 E/EFL     (18520): elementary<18520> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:11.820+0200 E/EFL     (18520): elementary<18520> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:11.820+0200 E/EFL     (18520): elementary<18520> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:11.820+0200 E/EFL     (18520): elementary<18520> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:11.820+0200 E/EFL     (18520): elementary<18520> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:11.820+0200 I/AUL_PAD (18520): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:09:11.925+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7546276 button=1
10-26 13:09:11.935+0200 W/AUL     (18552): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:09:11.935+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:09:11.935+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:09:11.935+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 18548
10-26 13:09:11.935+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:09:11.975+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18548
10-26 13:09:12.045+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7546398 button=1
10-26 13:09:12.095+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:12.100+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:12.100+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:12.105+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:12.105+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:12.105+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:12.110+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:12.120+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:12.120+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:12.125+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:12.140+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:12.140+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:12.320+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7546670 button=1
10-26 13:09:12.320+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:12.320+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:12.320+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:09:12.370+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:12.415+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:12.430+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:12.480+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7546830 button=1
10-26 13:09:12.480+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:09:12.480+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:09:12.480+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:09:12.480+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:09:12.480+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:12.485+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:09:12.485+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:09:12.495+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:09:12.495+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:09:12.495+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:09:12.500+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:09:12.500+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:09:12.560+0200 I/efl-extension(18520): efl_extension.c: eext_mod_init(40) > Init
10-26 13:09:12.560+0200 I/UXT     (18520): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:09:12.565+0200 I/CAPI_APPFW_APPLICATION(18520): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:09:12.570+0200 I/CAPI_APPFW_APPLICATION(18520): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:12.600+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:12.600+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18520)
10-26 13:09:12.600+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:09:12.630+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:09:12.720+0200 I/Bluetooth(18520): [bt_initialize] success.
10-26 13:09:12.915+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7547266 button=1
10-26 13:09:13.075+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7547425 button=1
10-26 13:09:13.335+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7547685 button=1
10-26 13:09:13.480+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7547832 button=1
10-26 13:09:13.640+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18520 pgid = 18520
10-26 13:09:13.655+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:09:13.655+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:09:13.655+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:09:13.655+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:09:13.655+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:13.655+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:13.685+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:09:13.685+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:09:13.690+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:13.700+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:09:13.705+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18520
10-26 13:09:13.710+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.528
10-26 13:09:13.730+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7548080 button=1
10-26 13:09:13.730+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:13.730+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:13.730+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:09:13.775+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:13.890+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7548239 button=1
10-26 13:09:13.890+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:09:13.890+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:09:13.890+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:09:13.890+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:09:13.890+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:13.895+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:09:13.895+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:09:13.905+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:09:13.905+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:09:13.905+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:09:13.905+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:09:13.905+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:09:13.910+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:09:13.910+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 18564
10-26 13:09:13.910+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:09:13.960+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 18564
10-26 13:09:13.960+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:13.960+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18564)
10-26 13:09:13.960+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:09:13.965+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:09:14.035+0200 I/efl-extension(18564): efl_extension.c: eext_mod_init(40) > Init
10-26 13:09:14.055+0200 I/CAPI_APPFW_APPLICATION(18564): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:09:14.070+0200 E/EFL     (18564): elementary<18564> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:14.075+0200 E/EFL     (18564): elementary<18564> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:14.105+0200 E/EFL     (18564): elementary<18564> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:14.110+0200 I/UXT     (18564): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:09:14.110+0200 E/EFL     (18564): elementary<18564> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:14.145+0200 E/EFL     (18564): elementary<18564> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:14.145+0200 E/EFL     (18564): elementary<18564> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:14.145+0200 E/EFL     (18564): elementary<18564> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:14.145+0200 E/EFL     (18564): elementary<18564> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:14.145+0200 E/EFL     (18564): elementary<18564> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:14.170+0200 E/EFL     (18564): elementary<18564> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:14.175+0200 E/EFL     (18564): elementary<18564> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:14.175+0200 E/EFL     (18564): elementary<18564> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:14.215+0200 E/EFL     (18564): elementary<18564> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:14.220+0200 E/EFL     (18564): elementary<18564> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:14.220+0200 E/EFL     (18564): elementary<18564> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:14.220+0200 E/EFL     (18564): elementary<18564> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:14.220+0200 E/EFL     (18564): elementary<18564> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:14.220+0200 E/EFL     (18564): elementary<18564> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:14.220+0200 E/EFL     (18564): elementary<18564> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:14.250+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:14.285+0200 I/CAPI_APPFW_APPLICATION(18564): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:14.415+0200 I/Bluetooth(18564): [bt_initialize] success.
10-26 13:09:14.440+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18564
10-26 13:09:14.440+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7548653 button=1
10-26 13:09:14.440+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7548751 button=1
10-26 13:09:14.735+0200 E/AUL     (  564): app_sock.c: __app_recv_raw(518) > recv error: 4
10-26 13:09:14.885+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:14.890+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:14.890+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:09:14.895+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:14.895+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:14.910+0200 W/AUL     (18567): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:09:14.910+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:09:14.915+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:09:14.915+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 18564
10-26 13:09:14.915+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:09:14.915+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:14.920+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:09:14.920+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18564
10-26 13:09:14.970+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:09:14.970+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:15.060+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:09:15.305+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:09:15.305+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:09:15.305+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:09:15.330+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 13:09:15.330+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 13:09:15.330+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 13:09:15.330+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:09:15.330+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _state_control(344) > appcore paused manually
10-26 13:09:15.330+0200 W/W_HOME  (  769): main.c: home_appcore_pause(723) > Home Appcore Paused
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:15.330+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:15.335+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:15.340+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:15.345+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-26 13:09:15.345+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 13:09:15.345+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 13:09:15.345+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 13:09:15.345+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 13:09:15.350+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:09:15.360+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:09:15.585+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-26 13:09:15.585+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:09:15.590+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 13:09:15.590+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 13:09:15.590+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 13:09:36), repeat(1), interval(20), type(-1073741822)
10-26 13:09:15.595+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:09:15.595+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:09:15.595+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:09:15.595+0200 E/W_HOME  (  769): main.c: _pause_cb(674) > paused already
10-26 13:09:15.610+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:09:15.650+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:15.665+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 748102704, next duetime: 1509016176
10-26 13:09:15.665+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:15.670+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(748102704)
10-26 13:09:15.670+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509016176)
10-26 13:09:15.670+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:15.670+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:09:36 (UTC).
10-26 13:09:15.670+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:15.685+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:09:15.690+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:15.895+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:09:16.655+0200 E/EFL     (18562): elementary<18562> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:16.700+0200 E/EFL     (18562): elementary<18562> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:16.790+0200 E/EFL     (18562): elementary<18562> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:16.795+0200 E/EFL     (18562): elementary<18562> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:16.860+0200 E/EFL     (18562): elementary<18562> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:16.865+0200 E/EFL     (18562): elementary<18562> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:16.865+0200 E/EFL     (18562): elementary<18562> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:16.870+0200 E/EFL     (18562): elementary<18562> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:16.870+0200 E/EFL     (18562): elementary<18562> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:16.895+0200 E/EFL     (18562): elementary<18562> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:16.900+0200 E/EFL     (18562): elementary<18562> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:16.900+0200 E/EFL     (18562): elementary<18562> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:16.950+0200 E/EFL     (18562): elementary<18562> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:16.965+0200 E/EFL     (18562): elementary<18562> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:16.975+0200 I/AUL_PAD (18562): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:09:17.010+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 1118523646174150901614
