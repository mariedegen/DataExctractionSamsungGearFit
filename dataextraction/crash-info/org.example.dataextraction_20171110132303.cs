S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 9707
Date: 2017-11-10 13:23:03+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x43e00010, r3   = 0x775dfb00
r4   = 0xbef09504, r5   = 0x41541980
r6   = 0x00000249, r7   = 0xbef09440
r8   = 0xbef094d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbef09428
lr   = 0x41744cb7, pc   = 0x4174623c
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     67468 KB
Buffers:     37304 KB
Cached:     159396 KB
VmPeak:      93872 KB
VmSize:      93500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17516 KB
VmRSS:       17512 KB
VmData:      40124 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23076 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9707 TID = 9707
9707 9770 9778 9779 9780 

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
435b8000 43db7000 rw-p [stack:9770]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43fb9000 447b8000 rw-p [stack:9778]
447b9000 44fb8000 rw-p [stack:9779]
44fb9000 458b8000 rw-p [stack:9780]
45914000 45917000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45a7b000 45a7c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
beee9000 bef0a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9707)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x4174623c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x323c
 1: app_terminate + 0x26 (0x41744cb7) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1cb7
 2: (0x41540af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41744c3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
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
1-10 13:22:57.770+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 13:22:57.790+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 13:22:57.790+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 13:22:57.790+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 9769
11-10 13:22:57.815+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:22:57.815+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:22:57.815+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:22:57.815+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
11-10 13:22:57.815+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:22:57.895+0200 I/efl-extension( 9707): efl_extension.c: eext_mod_init(40) > Init
11-10 13:22:57.895+0200 I/CAPI_APPFW_APPLICATION( 9707): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:22:57.910+0200 I/CAPI_APPFW_APPLICATION( 9707): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:22:57.920+0200 W/AUL     ( 9769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(9707)
11-10 13:22:58.050+0200 I/Bluetooth( 9707): [bt_initialize] success.
11-10 13:22:58.100+0200 I/Bluetooth( 9707): [bt_adapter_get_state] success.
11-10 13:22:58.190+0200 E/EFL     ( 9707): ecore_evas<9707> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:22:58.505+0200 I/APP_CORE( 9707): appcore-efl.c: __do_app(429) > [APP 9707] Event: RESET State: CREATED
11-10 13:22:58.505+0200 I/CAPI_APPFW_APPLICATION( 9707): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:22:58.525+0200 I/APP_CORE( 9707): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:22:58.530+0200 I/APP_CORE( 9707): appcore-efl.c: __do_app(474) > [APP 9707] Initial Launching, call the resume_cb
11-10 13:22:58.530+0200 I/CAPI_APPFW_APPLICATION( 9707): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:22:58.530+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:22:58.530+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:22:58.530+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:22:58.535+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:22:58.575+0200 W/APP_CORE( 9707): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
11-10 13:22:58.660+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:22:58.660+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:22:58.660+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:22:58.660+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:22:58.660+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: PAUSED
11-10 13:22:58.665+0200 I/APP_CORE(  765): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
11-10 13:22:58.665+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:22:58.680+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:22:58.680+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:22:58.715+0200 I/APP_CORE( 9707): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
11-10 13:22:58.745+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:22:58.745+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:22:58.745+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:22:58.875+0200 E/EFL     ( 9707): elementary<9707> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:22:58.875+0200 E/EFL     ( 9707): elementary<9707> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:22:58.880+0200 E/EFL     ( 9707): elementary<9707> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:22:59.020+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:22:59.030+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9707
11-10 13:22:59.030+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:22:59.045+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.545
11-10 13:22:59.065+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:22:59.075+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9707
11-10 13:22:59.075+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:22:59.080+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:22:59.175+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:22:59.175+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:22:59.205+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:22:59.205+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:22:59.255+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:22:59.255+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:22:59.260+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:22:59.260+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:22:59.260+0200 E/EFL     ( 9781): elementary<9781> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:22:59.280+0200 E/EFL     ( 9781): elementary<9781> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:22:59.285+0200 E/EFL     ( 9781): elementary<9781> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:22:59.285+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:22:59.325+0200 E/EFL     ( 9781): elementary<9781> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:22:59.335+0200 E/EFL     ( 9781): elementary<9781> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:22:59.335+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:22:59.335+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:22:59.335+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:22:59.335+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:22:59.335+0200 E/EFL     ( 9781): elementary<9781> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:22:59.335+0200 I/AUL_PAD ( 9781): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:22:59.450+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:23:00.455+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:23:01.470+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:23:01.580+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:23:01.595+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
11-10 13:23:01.595+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
11-10 13:23:01.595+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:23:01.605+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
11-10 13:23:01.605+0200 W/W_HOME  (  765): gesture.c: _manual_render_schedule(212) > schedule, manual render
11-10 13:23:01.645+0200 W/W_HOME  (  765): gesture.c: _widget_updated_cb(194) > widget updated
11-10 13:23:01.645+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:23:01.645+0200 W/W_HOME  (  765): gesture.c: _manual_render(180) > 
11-10 13:23:01.655+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:23:01.655+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:23:01.680+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:23:01.695+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
11-10 13:23:01.695+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
11-10 13:23:01.695+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:23:01.695+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [32958]ms
11-10 13:23:01.695+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:23:01.710+0200 I/APP_CORE( 9707): appcore-efl.c: __do_app(429) > [APP 9707] Event: RESUME State: RUNNING
11-10 13:23:01.725+0200 W/W_HOME  (  765): gesture.c: _manual_render(180) > 
11-10 13:23:01.740+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 0
11-10 13:23:01.740+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(186) > LCD on
11-10 13:23:01.740+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_set(165) > timer set
11-10 13:23:01.740+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:23:01.740+0200 W/W_HOME  (  765): gesture.c: _apps_status_get(126) > apps status:0
11-10 13:23:01.745+0200 W/W_HOME  (  765): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:32958
11-10 13:23:01.745+0200 W/W_HOME  (  765): gesture.c: _manual_render_schedule(212) > schedule, manual render
11-10 13:23:01.745+0200 W/W_HOME  (  765): event_manager.c: _lcd_on_cb(696) > lcd state: 1
11-10 13:23:01.745+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:01.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
11-10 13:23:01.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
11-10 13:23:01.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : test_healthy_pace error
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:23:01.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:23:01.870+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:23:01.900+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
11-10 13:23:01.900+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:23:01.915+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:23:01.915+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:23:01.940+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
11-10 13:23:01.940+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 0
11-10 13:23:01.940+0200 W/W_HOME  (  765): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-10 13:23:01.980+0200 W/SHealth_Common( 1107): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1510272000000,000000[0;m
11-10 13:23:02.010+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (622030)]][0;m
11-10 13:23:02.065+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
11-10 13:23:02.065+0200 W/SHealthWidget(  837): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (622030), msgName: timeline_summary_updated[0;m
11-10 13:23:02.065+0200 W/SHealth_Common(  837): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
11-10 13:23:02.080+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
11-10 13:23:02.100+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:23:02.100+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:23:02.100+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:23:02.100+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:23:02.110+0200 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-10 13:23:02.130+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_update_cb(281) > received updating signal
11-10 13:23:02.135+0200 E/EFL     (  837): edje<837> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
11-10 13:23:02.465+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
11-10 13:23:02.465+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
11-10 13:23:02.465+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
11-10 13:23:02.470+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
11-10 13:23:02.470+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
11-10 13:23:02.475+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=2186821
11-10 13:23:02.495+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
11-10 13:23:02.545+0200 I/INFO_TAG( 9707): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:23:02.550+0200 E/STARTER (  720): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
11-10 13:23:02.550+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
11-10 13:23:02.550+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
11-10 13:23:02.560+0200 E/EFL     ( 9707): ecore_x<9707> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=2186821
11-10 13:23:02.650+0200 E/W_HOME  (  765): key.c: _key_press_cb(218) > (APP_STATE_PAUSE == main_get_info()->state) -> _key_press_cb() return
11-10 13:23:02.670+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:23:02.670+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:23:02.670+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:23:02.675+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=2187033
11-10 13:23:02.675+0200 W/STARTER (  720): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
11-10 13:23:02.685+0200 E/EFL     ( 9707): ecore_x<9707> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=2187033
11-10 13:23:02.690+0200 W/STARTER (  720): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
11-10 13:23:02.715+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
11-10 13:23:02.725+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
11-10 13:23:02.730+0200 E/STARTER (  720): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
11-10 13:23:02.730+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
11-10 13:23:02.740+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:23:02.740+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 720
11-10 13:23:02.745+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 765
11-10 13:23:02.745+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESET State: PAUSED
11-10 13:23:02.745+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_reset(245) > app_appcore_reset
11-10 13:23:02.745+0200 W/W_HOME  (  765): main.c: _app_control(1704) > Service value : powerkey
11-10 13:23:02.745+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
11-10 13:23:02.745+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
11-10 13:23:02.745+0200 W/W_HOME  (  765): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
11-10 13:23:02.745+0200 E/W_HOME  (  765): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
11-10 13:23:02.745+0200 W/W_HOME  (  765): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:0 clock:1 apps:0
11-10 13:23:02.745+0200 E/W_HOME  (  765): move.c: move_back_to_home_no_anim(276) > home is already on position
11-10 13:23:02.745+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
11-10 13:23:02.745+0200 W/W_HOME  (  765): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
11-10 13:23:02.745+0200 W/W_HOME  (  765): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
11-10 13:23:02.745+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.745+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.745+0200 W/W_HOME  (  765): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
11-10 13:23:02.745+0200 W/W_HOME  (  765): main.c: home_resume(739) > clock/widget resumed
11-10 13:23:02.750+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(765), cmd(0)
11-10 13:23:02.750+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_resume(537) > 
11-10 13:23:02.750+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.750+0200 W/W_INDICATOR(  740): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
11-10 13:23:02.755+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:23:02.755+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:23:02.755+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:23:02.760+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(282) > request cmd(0) result(765)
11-10 13:23:02.760+0200 E/AUL     (  720): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:23:02.770+0200 W/WSLib   (  837): LabelWidget.cpp: StartSliding(138) > [1;35m ###[0;m
11-10 13:23:02.775+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_resume(1039) > widget_resume
11-10 13:23:02.775+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:23:02.780+0200 W/PROCESSMGR(  408): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
11-10 13:23:02.780+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
11-10 13:23:02.780+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.780+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.785+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.785+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
11-10 13:23:02.785+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
11-10 13:23:02.785+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:23:02.795+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:23:02.795+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:23:02.800+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:23:02.805+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:23:02.805+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:23:02.805+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:23:02.805+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:23:02.805+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:23:02.810+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:23:02.810+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:23:02.810+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:23:02.810+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:23:02.810+0200 W/SHealthWidget(  837): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>118</color> bpm</color>][0;m
11-10 13:23:02.810+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
11-10 13:23:02.810+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
11-10 13:23:02.810+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:02.810+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
11-10 13:23:02.810+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESUME State: RUNNING
11-10 13:23:02.810+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
11-10 13:23:02.820+0200 I/APP_CORE( 9707): appcore-efl.c: __do_app(429) > [APP 9707] Event: PAUSE State: RUNNING
11-10 13:23:02.820+0200 I/CAPI_APPFW_APPLICATION( 9707): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
11-10 13:23:02.840+0200 W/SHealth_Common(  837): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:23:02.840+0200 W/SHealth_Common(  837): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:23:02.845+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:23:02.845+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:23:02.845+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:23:02.845+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:23:02.845+0200 E/TBM     (  408): tbm_bufmgr.c: _tgl_destroy(151) > [libtbm:408] error(Device or resource busy) _tgl_destroy:151 key:22
11-10 13:23:02.860+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:23:02.860+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:23:02.865+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:23:02.865+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:23:02.865+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:23:02.870+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:23:02.870+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:23:02.870+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:23:02.905+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:23:02.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:23:02.905+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:23:02.905+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:23:02.920+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:23:02.920+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:23:02.925+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:23:02.930+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:23:02.930+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:23:02.935+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:23:02.940+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:23:02.945+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:23:02.945+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:23:02.965+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:23:02.965+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:23:02.965+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:23:02.965+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:23:02.995+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 22
11-10 13:23:02.995+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(916) > app status : 4
11-10 13:23:03.035+0200 E/APP_CORE( 9707): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-10 13:23:03.035+0200 I/APP_CORE( 9707): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-10 13:23:03.035+0200 I/CAPI_APPFW_APPLICATION( 9707): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-10 13:23:03.045+0200 I/Bluetooth( 9707): [bt_deinitialize] success.
11-10 13:23:03.060+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
11-10 13:23:03.060+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
11-10 13:23:03.065+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
11-10 13:23:03.065+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
11-10 13:23:03.065+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
11-10 13:23:03.065+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=2187422
11-10 13:23:03.065+0200 E/STARTER (  720): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
11-10 13:23:03.065+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
11-10 13:23:03.065+0200 W/STARTER (  720): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
11-10 13:23:03.215+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
11-10 13:23:03.225+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:23:03.225+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-10 13:23:03.225+0200 W/STARTER (  720): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
11-10 13:23:03.225+0200 W/STARTER (  720): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
11-10 13:23:03.230+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=2187593
11-10 13:23:03.240+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
11-10 13:23:03.240+0200 W/STARTER (  720): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
11-10 13:23:03.240+0200 E/STARTER (  720): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
11-10 13:23:03.240+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
11-10 13:23:03.240+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:23:03.240+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 720
11-10 13:23:03.250+0200 W/AUL_AMD (  504): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 765
11-10 13:23:03.250+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESET State: RUNNING
11-10 13:23:03.250+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_reset(245) > app_appcore_reset
11-10 13:23:03.250+0200 W/W_HOME  (  765): main.c: _app_control(1704) > Service value : powerkey
11-10 13:23:03.250+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
11-10 13:23:03.250+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
11-10 13:23:03.250+0200 W/W_HOME  (  765): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
11-10 13:23:03.250+0200 E/W_HOME  (  765): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
11-10 13:23:03.250+0200 W/W_HOME  (  765): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-10 13:23:03.250+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(765), cmd(0)
11-10 13:23:03.255+0200 W/AUL     (  720): launch.c: app_request_to_launchpad(282) > request cmd(0) result(765)
11-10 13:23:03.255+0200 E/AUL     (  720): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:23:03.255+0200 W/W_HOME  (  765): move.c: move_move_to_apps(220) > move to apps
11-10 13:23:03.255+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:23:03.255+0200 W/W_HOME  (  765): move.c: _create_fake_apps(823) > fake image position : 432
11-10 13:23:03.260+0200 W/W_HOME  (  765): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
11-10 13:23:03.260+0200 W/W_HOME  (  765): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
11-10 13:23:03.260+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:03.260+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:03.260+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
11-10 13:23:03.260+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
11-10 13:23:03.260+0200 W/W_HOME  (  765): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
11-10 13:23:03.260+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:03.270+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:03.280+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:23:03.280+0200 W/W_HOME  (  765): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
11-10 13:23:03.280+0200 W/W_HOME  (  765): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
11-10 13:23:03.280+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
11-10 13:23:03.280+0200 I/wnotib  (  765): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
11-10 13:23:03.385+0200 W/CRASH_MANAGER( 9802): worker.c: worker_job(1205) > 1109707646174151031298
