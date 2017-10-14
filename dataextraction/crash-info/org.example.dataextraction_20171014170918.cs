S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 11398
Date: 2017-10-14 17:09:18+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x123afffc

Register Information
r0   = 0x123b0000, r1   = 0x000661dc
r2   = 0x4156be83, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x417c77fc
r6   = 0x123b0000, r7   = 0xbe823f18
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x000661dc, fp   = 0x00000000
ip   = 0x0000016c, sp   = 0xbe823e30
lr   = 0x4156be83, pc   = 0x404e62d0
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     20212 KB
Buffers:     61728 KB
Cached:     165344 KB
VmPeak:      92436 KB
VmSize:      91696 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16112 KB
VmRSS:       16112 KB
VmData:      38084 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23132 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 11398 TID = 11398
11398 11463 11464 11465 11466 

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
4156a000 4156d000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4157d000 41581000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4158a000 4158c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41595000 4159b000 r-xp /usr/lib/libappsvc.so.0.1.0
415a3000 415c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415d0000 4169f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416b5000 416bf000 r-xp /lib/libnss_files-2.13.so
41743000 4174e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41756000 4175a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41763000 4176b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4176c000 4178d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41796000 417c0000 r-xp /usr/lib/libsensor.so.1.9.6
417c9000 417db000 r-xp /usr/lib/libefl-assist.so.0.1.0
417e3000 4189b000 r-xp /usr/lib/libcairo.so.2.11200.14
418a6000 418b0000 r-xp /usr/lib/libsensord-shared.so
418b9000 418cb000 r-xp /usr/lib/libtts.so
418d3000 418f5000 r-xp /usr/lib/libui-extension.so.0.1.0
418fe000 41905000 r-xp /usr/lib/libtbm.so.1.0.0
4190d000 4191b000 r-xp /usr/lib/libGLESv2.so.2.0
41924000 41925000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4192e000 41934000 r-xp /usr/lib/libxcb-render.so.0.0.0
4193c000 4193f000 r-xp /usr/lib/libEGL.so.1.4
41947000 4194c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41954000 41957000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4195f000 41960000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41969000 41aa6000 r-xp /usr/lib/libicui18n.so.51.1
41ab6000 41b9a000 r-xp /usr/lib/libicuuc.so.51.1
41baf000 41bb7000 r-xp /usr/lib/libdrm.so.2.4.0
41bbf000 41bc1000 r-xp /usr/lib/libdri2.so.0.0.0
41bc9000 41bcf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bd7000 41bdc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41be4000 41bfd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4318e000 431af000 r-xp /usr/lib/libexif.so.12.3.3
431c2000 431c4000 r-xp /usr/lib/libttrace.so.1.1
431cc000 431d1000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431d9000 431df000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
431e8000 431f0000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
431f8000 43214000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4321d000 43224000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4322d000 4322f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43237000 4323e000 r-xp /usr/lib/libminizip.so.1.0.0
43246000 43253000 r-xp /usr/lib/libail.so.0.1.0
4335c000 43426000 r-xp /usr/lib/libCOREGL.so.4.0
43638000 43643000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4364c000 43651000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
436f7000 436f8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43701000 43f00000 rw-p [stack:11463]
43f01000 44700000 rw-p [stack:11464]
44701000 44f00000 rw-p [stack:11465]
45001000 45800000 rw-p [stack:11466]
be804000 be825000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11398)
Call Stack Count: 1
 0: realloc + 0x50 (0x404e62d0) [/lib/libc.so.6] + 0x6f2d0
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
atch_core_time_tick
10-14 17:09:28.250+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESUME State: PAUSED
10-14 17:09:28.250+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:09:28.250+0200 W/W_HOME  ( 1063): main.c: _appcore_resume_cb(687) > appcore resume
10-14 17:09:28.250+0200 W/W_HOME  ( 1063): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 17:09:28.250+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.250+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.250+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.265+0200 I/CAPI_APPFW_APPLICATION(11503): app_main.c: app_efl_main(129) > app_efl_main
10-14 17:09:28.285+0200 I/CAPI_APPFW_APPLICATION(11503): app_main.c: app_appcore_create(152) > app_appcore_create
10-14 17:09:28.285+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 17:09:28.295+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-14 17:09:28.295+0200 W/W_HOME  ( 1063): dbox.c: _dbus_rotation_cb(1344) > invalid angle, skipped:0
10-14 17:09:28.315+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : com.samsung.w-clock-viewer
10-14 17:09:28.315+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(305) > [windicator_battery_icon_update:305] 100%
10-14 17:09:28.320+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(11503)
10-14 17:09:28.320+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [charge] after screen off time [1567]ms
10-14 17:09:28.320+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[1]
10-14 17:09:28.330+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 17:09:28.335+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(315) > [windicator_battery_icon_update:315] battery_level: 100, isCharging: 1
10-14 17:09:28.335+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 17:09:28.340+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(342) > [windicator_battery_icon_update:342] [SIGNAL] battery file : change_level_100
10-14 17:09:28.345+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 17:09:28.345+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 17:09:28.345+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 17:09:28.345+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 17:09:28.345+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 17:09:28.350+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 17:09:28.350+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 17:09:28.350+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 532
10-14 17:09:28.360+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(177) > [_battery_charger_status_changed_cb:177] TA connected or abnormal
10-14 17:09:28.360+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(195) > [_battery_charger_status_changed_cb:195] Show Moment View to display charging animation
10-14 17:09:28.365+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 11570
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(804233936)
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 20:47:32 (UTC).
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[804233936] is removed.
10-14 17:09:28.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 17:09:28.415+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_show(1505) > [windicator_moment_view_show:1505] Show Moment View : type(1)
10-14 17:09:28.415+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 11570
10-14 17:09:28.430+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 17:09:28.440+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
10-14 17:09:28.440+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 0
10-14 17:09:28.440+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 17:09:28.445+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 17:09:28.445+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 17:09:28.445+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 532
10-14 17:09:28.445+0200 E/RESOURCED(  536): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-gallery.consumer
10-14 17:09:28.445+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : com.samsung.w-gallery
10-14 17:09:28.455+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1648) > [windicator_init_battery_rect:1648] battery level 100, index 20, bg level 100
10-14 17:09:28.455+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1652) > [windicator_init_battery_rect:1652] Battery signal emit : bg_level_90
10-14 17:09:28.460+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 11571
10-14 17:09:28.510+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 11571
10-14 17:09:28.525+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [charge]
10-14 17:09:28.525+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[1]
10-14 17:09:28.535+0200 E/RESOURCED(  536): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-music-transfer.consumer
10-14 17:09:28.545+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] PRE LCD ON - charge
10-14 17:09:28.550+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 17:09:28.600+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_get_angle(613) > [_windicator_get_angle:613] Unknown state(0)
10-14 17:09:28.600+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(650) > [_windicator_rotation_changed_cb:650] invliad state, Add timer :0 angle:-1
10-14 17:09:28.635+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:09:28.635+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.635+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.635+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.665+0200 W/APP_CORE(  714): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000a
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:09:28.700+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:09:28.700+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:09:28.700+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.705+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.705+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:28.730+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:28.730+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:28.735+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:09:28.735+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:28.735+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:28.735+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:09:28.735+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:09:28.735+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 17:09:28.740+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:09:28.740+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 17:09:28.770+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:09:28.770+0200 W/W_CLOCK_VIEWER(11503): clock-viewer.c: _clock_viewer_set_current_clock(741) >  package[com.samsung.idle-clock-volt_sparkle] ambient type[3], current lcd[0] resume[0] ambient type[0]
10-14 17:09:28.785+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 17:09:28.785+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 17:09:28.785+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 17:09:28.785+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 17:09:28.790+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 17:09:28.805+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:09:28.810+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-14 17:09:28.810+0200 W/W_HOME  ( 1063): dbox.c: _dbus_rotation_cb(1341) > angle changed:90
10-14 17:09:28.815+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 17:09:28.815+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(657) > [_windicator_rotation_changed_cb:657] Got specific angle, so delete timer!
10-14 17:09:28.815+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:2 angle:3 / is_connected : 1
10-14 17:09:28.820+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(688) > [_windicator_rotation_changed_cb:688] [ROTATION] Refresh angle value only for 90`, 270`
10-14 17:09:28.820+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_angle_changed(1600) > [windicator_moment_view_angle_changed:1600] [Rotation] Angle : 3 (check 1,3)
10-14 17:09:28.820+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 17:09:28.825+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 17:09:28.825+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 17:09:28.825+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 17:09:28.825+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 17:09  /5 / HH:mm
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 17:09
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 17
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 09
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  17
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  09
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 17 / 9 / 17:09
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 17:09:28.830+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_charging_watch_ui_show(1442) > [windicator_moment_view_charging_watch_ui_show:1442] [Rotation] Degree : 90
10-14 17:09:28.835+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 17:09:28.925+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 17:09:29.075+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(219) > No cached cookie for [11503]
10-14 17:09:29.075+0200 W/ALARM_MANAGER(  484): alarm-manager.c: __check_privilege_by_cookie(1643) > Try to read procfs status
10-14 17:09:29.075+0200 W/ALARM_MANAGER(  484): alarm-manager.c: __check_privilege_by_cookie(1647) > Read procfs status successfully
10-14 17:09:29.105+0200 I/SCONTEXT-LIB(11503): feature_wearable.cpp: cx_is_feature_supported(97) > Initializing the feature map
10-14 17:09:29.110+0200 I/SCONTEXT-LIB(11503): comm.c: cx_connect_dbus(123) > Connecting Dbus
10-14 17:09:29.150+0200 W/MUSIC_TRANSFER(11571): mt-service.c: main(142) > [33m[TID:11571]   service start[0m
10-14 17:09:29.150+0200 I/SCONTEXT-LIB(11503): comm.c: cx_connect_dbus(148) > Dbus connected: ':1.2888'
10-14 17:09:29.150+0200 I/SCONTEXT-LIB(11503): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 45 (req_id=1)
10-14 17:09:29.150+0200 I/SCONTEXT-LIB(11503): scontext.c: context_get_context(108) > [SUCCESS] Get Context: 45 (req_id=2)
10-14 17:09:29.155+0200 W/MUSIC_TRANSFER(11571): mt-service.c: _service_app_create(65) > [33m[TID:11571]   [0m
10-14 17:09:29.195+0200 W/W_CLOCK_VIEWER(11503): clock-viewer-util-dbus.c: clock_viewer_util_dbus_get_device_angle(152) >  Get device angle[2]
10-14 17:09:29.195+0200 W/W_CLOCK_VIEWER(11503): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-14 17:09:29.200+0200 I/APP_CORE(11503): appcore-efl.c: __do_app(429) > [APP 11503] Event: RESET State: CREATED
10-14 17:09:29.200+0200 I/CAPI_APPFW_APPLICATION(11503): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 17:09:29.210+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 17:09:29.215+0200 I/APP_CORE(11503): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:09:29.215+0200 I/APP_CORE(11503): appcore-efl.c: __do_app(474) > [APP 11503] Initial Launching, call the resume_cb
10-14 17:09:29.215+0200 I/CAPI_APPFW_APPLICATION(11503): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:09:29.220+0200 W/APP_CORE(11503): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000002
10-14 17:09:29.240+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:09:29.270+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 17:09:29.270+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 17:09:29.270+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:09:29.275+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 2
10-14 17:09:29.280+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 2 
10-14 17:09:29.290+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:29.315+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 17:09:29.315+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 17:09:29.300+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 17:09:29.330+0200 E/DATA_PROVIDER_MASTER(  706): package.c: package_alter_instances_to_client(1695) > Failed to load a buffer
10-14 17:09:29.335+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-14 17:09:29.355+0200 W/W_CLOCK_VIEWER(11503): clock-viewer.c: __clock_viewer_lcdon_completed_cb(471) >  event lcdon completed[1]
10-14 17:09:29.355+0200 W/W_CLOCK_VIEWER(11503): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[1]
10-14 17:09:29.355+0200 W/W_CLOCK_VIEWER(11503): clock-viewer.c: clock_viewer_hide(1298) >  reservied[0], gesture[0], clock visible[0]
10-14 17:09:29.355+0200 W/W_CLOCK_VIEWER(11503): clock-viewer.c: _clock_viewer_send_clock_changed(919) >  clock changed <<
10-14 17:09:29.370+0200 E/DATA_PROVIDER_MASTER(  706): shared_fd_service.c: direct_hello_handler(66) > Client is not exists: 
10-14 17:09:29.400+0200 W/W_CLOCK_VIEWER(11503): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(194) >  get_info_cb called err[0], context[45], data[{ "Time" : 1507993769274, "Reason" : 0, "Status" : 2 }], req_id[2]
10-14 17:09:29.400+0200 W/W_CLOCK_VIEWER(11503): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(214) >  status[2] Wear OFF
10-14 17:09:29.410+0200 E/WIDGET_VIEWER(11503): client.c: master_created(1712) > [31,331347] pkgname: com.samsung.idle-clock-volt_sparkle, id: file:///opt/usr/share/live_magazine/com.samsung.idle-clock-volt_sparkle_1063_31,331347.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 216, widget_h: 432, cluster: user,created, category: default, widget_fname: "pixmap://29360130:4", gbar_fname: "", auto_launch: , priority: 0,000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0,000000, title: [], is_pinned_up: 0
10-14 17:09:29.485+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.2890
10-14 17:09:29.520+0200 E/WIDGET_EVAS(11503): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-14 17:09:29.520+0200 W/W_CLOCK_VIEWER(11503): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(257) >  DBOX Created[com.samsung.idle-clock-volt_sparkle] it should be [com.samsung.idle-clock-volt_sparkle]
10-14 17:09:29.520+0200 W/W_CLOCK_VIEWER(11503): clock-viewer-dbox.c: _clock_viewer_widget_list_append(128) >  >>>Append to list[com.samsung.idle-clock-volt_sparkle][0x41aacdc8]
10-14 17:09:29.540+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:29.550+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11570
10-14 17:09:29.555+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:09:29.605+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:29.620+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11571
10-14 17:09:29.625+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:09:29.670+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:29.685+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11503
10-14 17:09:29.690+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:09:29.805+0200 W/MUSIC_PLAYER(11571): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:11571]   W_SERVICE_TYPE_BT[1][0m
10-14 17:09:29.810+0200 W/MUSIC_PLAYER(11571): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:11571]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-14 17:09:29.810+0200 W/MUSIC_TRANSFER(11571): mt-service.c: _service_app_create(88) > [31m[TID:11571]   SAP is disconnected.. Terminate process[0m
10-14 17:09:29.810+0200 I/CAPI_APPFW_APPLICATION(11571): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 17:09:29.965+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:29.970+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11570
10-14 17:09:29.970+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:09:30.045+0200 W/MUSIC_PLAYER(11571): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:11571]   vendor : LO[0m
10-14 17:09:30.065+0200 W/MUSIC_PLAYER(11571): mp-conf.c: mp_conf_init(262) > [33m[TID:11571]   iOS  connected..[0m
10-14 17:09:30.065+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:30.075+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(11571): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-14 17:09:30.075+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(11571): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:30.075+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(11571): preference.c: preference_get_int(1132) > preference_get_int(11571) : key(tutorial_complete) error
10-14 17:09:30.075+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-14 17:09:30.075+0200 E/CAPI_NETWORK_BLUETOOTH( 1814): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-14 17:09:30.075+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11571
10-14 17:09:30.075+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1814]   bt_gatt_client_get_service Error[-22][0m
10-14 17:09:30.080+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1814]   remote mode[0][0m
10-14 17:09:30.080+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:09:30.080+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:09:30.080+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:09:30.080+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:09:30.080+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:30.080+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:09:30.085+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:09:30.085+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 17:09:30.085+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:09:30.095+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:09:30.095+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:09:30.095+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:09:30.115+0200 W/MUSIC_TRANSFER(11571): mt-service.c: _service_app_terminate(104) > [33m[TID:11571]   [0m
10-14 17:09:30.115+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 17:09:30.115+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 17:09:30.180+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:09:30.200+0200 E/EFL     (11579): elementary<11579> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 17:09:30.215+0200 E/EFL     (11579): elementary<11579> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 17:09:30.250+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:30.260+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11503
10-14 17:09:30.260+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:09:30.275+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:09:30.300+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 17:09:30.305+0200 E/EFL     (11579): elementary<11579> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 17:09:30.325+0200 E/EFL     (11579): elementary<11579> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 17:09:30.350+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 17:09:30.410+0200 E/EFL     (11579): elementary<11579> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 17:09:30.430+0200 E/EFL     (11579): elementary<11579> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 17:09:30.435+0200 E/EFL     (11579): elementary<11579> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 17:09:30.450+0200 E/EFL     (11579): elementary<11579> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 17:09:30.455+0200 E/EFL     (11579): elementary<11579> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 17:09:30.540+0200 W/WG-CONSUMER(11570): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
10-14 17:09:30.540+0200 W/WG-CONSUMER(11570): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
10-14 17:09:30.540+0200 W/WG-CONSUMER(11570): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
10-14 17:09:30.545+0200 W/WG-CONSUMER(11570): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-14 17:09:30.545+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-14 17:09:30.545+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-14 17:09:30.545+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 17:09:30.545+0200 W/WG-CONSUMER(11570): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-14 17:09:30.550+0200 W/WG-CONSUMER(11570): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-14 17:09:30.550+0200 W/WG-CONSUMER(11570): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-14 17:09:30.550+0200 W/WG-CONSUMER(11570): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-14 17:09:30.550+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-14 17:09:30.555+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 17:09:30.595+0200 W/WG-CONSUMER(11570): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-14 17:09:30.595+0200 I/CAPI_CONTENT_MEDIA_CONTENT(11570): media_content.c: media_content_connect(870) > [32m[11570]ref count : 0
10-14 17:09:30.595+0200 W/AUL     (11586): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-14 17:09:30.600+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 17:09:30.600+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 17:09:30.600+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 11571
10-14 17:09:30.600+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 17:09:30.615+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11571
10-14 17:09:30.620+0200 I/CAPI_CONTENT_MEDIA_CONTENT(11570): media_content.c: media_content_connect(902) > [32m[11570]ref count changed to: 1
10-14 17:09:30.625+0200 W/WG-CONSUMER(11570): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-14 17:09:30.640+0200 W/WG-CONSUMER(11570): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-14 17:09:30.645+0200 W/WG-CONSUMER(11570): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-14 17:09:30.645+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 17:09:30.645+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-14 17:09:30.645+0200 E/WG-CONSUMER(11570): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 17:09:30.650+0200 E/WG-CONSUMER(11570): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 17:09:30.650+0200 E/WG-CONSUMER(11570): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-14 17:09:30.650+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-14 17:09:30.650+0200 E/WG-CONSUMER(11570): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-14 17:09:30.655+0200 E/WG-CONSUMER(11570): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 17:09:30.655+0200 E/WG-CONSUMER(11570): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 17:09:30.660+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 17:09:30.660+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 17:09:30.660+0200 E/WG-CONSUMER(11570): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-14 17:09:30.660+0200 W/WG-CONSUMER(11570): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42eaf8d0[0m
10-14 17:09:30.665+0200 W/CAPI_APPFW_APP_CONTROL(11570): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 17:09:30.665+0200 W/CAPI_APPFW_APP_CONTROL(11570): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 17:09:30.685+0200 W/WG-CONSUMER(11570): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-14 17:09:30.700+0200 E/EFL     (11579): elementary<11579> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 17:09:30.705+0200 E/EFL     (11579): elementary<11579> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 17:09:30.705+0200 I/CAPI_APPFW_APPLICATION(11570): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 17:09:30.705+0200 W/WG-CONSUMER(11570): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-14 17:09:30.710+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 17:09:30.710+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 17:09:30.710+0200 W/WG-CONSUMER(11570): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-14 17:09:30.710+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-14 17:09:30.710+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-14 17:09:30.715+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 17:09:30.715+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 17:09:30.715+0200 W/WG-CONSUMER(11570): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 17:09:30.715+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 17:09:30.715+0200 E/WIPC_SERVER(11570): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-14 17:09:30.720+0200 W/WG-CONSUMER(11570): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-14 17:09:30.720+0200 W/WG-CONSUMER(11570): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-14 17:09:30.720+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-14 17:09:30.720+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-14 17:09:30.720+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 17:09:30.725+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 17:09:30.725+0200 W/WG-CONSUMER(11570): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 17:09:30.725+0200 W/WG-CONSUMER(11570): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 17:09:30.730+0200 E/EFL     (11579): elementary<11579> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 17:09:30.735+0200 I/CAPI_CONTENT_MEDIA_CONTENT(11570): media_content.c: media_content_disconnect(958) > [32m[11570]ref count changed to: 0
10-14 17:09:30.895+0200 E/WG-CONSUMER(11570): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-14 17:09:30.900+0200 W/WG-CONSUMER(11570): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-14 17:09:30.900+0200 E/EFL     (11579): elementary<11579> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 17:09:30.900+0200 W/WG-CONSUMER(11570): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-14 17:09:30.900+0200 W/WG-CONSUMER(11570): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-14 17:09:30.900+0200 W/WG-CONSUMER(11570): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-14 17:09:30.905+0200 W/WG-CONSUMER(11570): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-14 17:09:30.905+0200 W/WG-CONSUMER(11570): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-14 17:09:30.920+0200 E/EFL     (11579): elementary<11579> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 17:09:30.925+0200 E/EFL     (11579): elementary<11579> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 17:09:30.925+0200 E/EFL     (11579): elementary<11579> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 17:09:30.925+0200 E/EFL     (11579): elementary<11579> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 17:09:30.925+0200 E/EFL     (11579): elementary<11579> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 17:09:30.925+0200 E/EFL     (11579): elementary<11579> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 17:09:30.925+0200 I/AUL_PAD (11579): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 17:09:31.120+0200 W/AUL     (11590): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-14 17:09:31.125+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 17:09:31.125+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 17:09:31.125+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 11570
10-14 17:09:31.125+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 17:09:31.130+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11570
10-14 17:09:32.115+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 17:09:32.710+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 17:09:33.740+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:09:34.030+0200 W/CRASH_MANAGER(11039): worker.c: worker_job(1205) > 11113346461741507993752
10-14 17:09:36.950+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 17:09:42.065+0200 W/CRASH_MANAGER(11039): worker.c: worker_job(1205) > 06113996461741507993755
10-14 17:09:44.675+0200 W/CRASH_MANAGER(11039): worker.c: worker_job(1205) > 1111398646174150799375
