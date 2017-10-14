S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 14954
Date: 2017-10-14 14:43:22+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xbef2c3a8, r3   = 0x40064114
r4   = 0xbef2c30c, r5   = 0x40057d30
r6   = 0x00000233, r7   = 0xbef2c1a0
r8   = 0xbef2c2dc, r9   = 0x40480c84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40059995, sp   = 0xbef2c188
lr   = 0x40001e73, pc   = 0x40001e78
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     50080 KB
Buffers:     45144 KB
Cached:     168984 KB
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
bef0c000 bef2d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14954)
Call Stack Count: 9
 0: create_HRM_listener + 0x3b (0x40001e78) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1e78
 1: create_base_gui + 0x10 (0x40001731) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1731
 2: app_create + 0x32 (0x40001663) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1663
 3: (0x4004d9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40477457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x4004e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x400015cb) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x15cb
 7: __libc_start_main + 0x114 (0x402fe82c) [/lib/libc.so.6] + 0x1782c
 8: (0x40001334) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1334
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
: 23
10-14 14:43:23.295+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:43:23.295+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 14954
10-14 14:43:23.295+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:43:23.300+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14954
10-14 14:43:23.650+0200 E/EFL     (14938): elementary<14938> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:43:23.955+0200 E/EFL     (14938): elementary<14938> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:43:23.955+0200 E/EFL     (14938): elementary<14938> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:43:23.955+0200 E/EFL     (14938): elementary<14938> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:43:23.955+0200 E/EFL     (14938): elementary<14938> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:43:23.955+0200 E/EFL     (14938): elementary<14938> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:43:23.955+0200 E/EFL     (14938): elementary<14938> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:43:23.955+0200 I/AUL_PAD (14938): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:43:24.520+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_charger_status_changed_cb(437) > 
10-14 14:43:24.520+0200 W/wnotib  ( 1063): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1619) > num_categoreis: 0
10-14 14:43:24.520+0200 I/wnotib  ( 1063): w-notification-board-panel-summary.c: _wnb_summary_draw_static_empty_view(1246) > Use existing static_empty_view.
10-14 14:43:24.520+0200 W/wnotib  ( 1063): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1640) > current_summary_type: 1, new_summary_type: 1
10-14 14:43:24.525+0200 W/STARTER (  705): clock-mgr.c: _charger_status_setting_changed_cb(890) > [_charger_status_setting_changed_cb:890] charger status is changed to [1] ambient[0]
10-14 14:43:24.525+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-clock-viewer)
10-14 14:43:24.535+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 14:43:24.545+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 14:43:24.545+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 14:43:24.545+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 532
10-14 14:43:24.555+0200 E/RESOURCED(  536): heart-battery.c: heart_battery_calculate_prediction(1057) > No battery capacity history data
10-14 14:43:24.575+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 14:43:24.575+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 14:43:24.575+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:43:24.620+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-14 14:43:24.620+0200 W/W_HOME  ( 1063): dbox.c: _dbus_rotation_cb(1344) > invalid angle, skipped:0
10-14 14:43:24.630+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 14972
10-14 14:43:24.640+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 1 -> 2
10-14 14:43:24.640+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(305) > [windicator_battery_icon_update:305] 100%
10-14 14:43:24.640+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 14:43:24.640+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(315) > [windicator_battery_icon_update:315] battery_level: 100, isCharging: 1
10-14 14:43:24.640+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(342) > [windicator_battery_icon_update:342] [SIGNAL] battery file : change_level_100
10-14 14:43:24.645+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 1 to 2 
10-14 14:43:24.680+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 14972
10-14 14:43:24.695+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 14:43:24.710+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/amd, ret : 0
10-14 14:43:24.710+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 14:43:24.710+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 532
10-14 14:43:24.790+0200 E/RESOURCED(  536): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-gallery.consumer
10-14 14:43:24.790+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : com.samsung.w-gallery
10-14 14:43:24.935+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-14 14:43:24.935+0200 W/W_HOME  ( 1063): dbox.c: _dbus_rotation_cb(1341) > angle changed:270
10-14 14:43:25.060+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 14:43:25.060+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 14:43:25.060+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 14:43:25.060+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 14:43:25.065+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 14:43:25.065+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(177) > [_battery_charger_status_changed_cb:177] TA connected or abnormal
10-14 14:43:25.065+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(195) > [_battery_charger_status_changed_cb:195] Show Moment View to display charging animation
10-14 14:43:25.070+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 14976
10-14 14:43:25.120+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 14976
10-14 14:43:25.125+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:43:25.130+0200 E/RESOURCED(  536): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-music-transfer.consumer
10-14 14:43:25.140+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 705
10-14 14:43:25.155+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:43:25.155+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 14:43:25.155+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:43:25.205+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 14:43:25.205+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 14:43:25.205+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 14:43:25.205+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-14 14:43:25.205+0200 I/CAPI_APPFW_APPLICATION(14938): app_main.c: app_efl_main(129) > app_efl_main
10-14 14:43:25.215+0200 I/CAPI_APPFW_APPLICATION(14938): app_main.c: app_appcore_create(152) > app_appcore_create
10-14 14:43:25.260+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(14938)
10-14 14:43:25.305+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:43:25.305+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : com.samsung.w-clock-viewer
10-14 14:43:25.370+0200 W/MUSIC_TRANSFER(14976): mt-service.c: main(142) > [33m[TID:14976]   service start[0m
10-14 14:43:25.380+0200 W/MUSIC_TRANSFER(14976): mt-service.c: _service_app_create(65) > [33m[TID:14976]   [0m
10-14 14:43:25.450+0200 W/W_CLOCK_VIEWER(14938): clock-viewer.c: _clock_viewer_set_current_clock(741) >  package[com.samsung.idle-clock-volt_sparkle] ambient type[3], current lcd[0] resume[0] ambient type[0]
10-14 14:43:25.630+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(219) > No cached cookie for [14938]
10-14 14:43:25.630+0200 W/ALARM_MANAGER(  484): alarm-manager.c: __check_privilege_by_cookie(1643) > Try to read procfs status
10-14 14:43:25.635+0200 W/ALARM_MANAGER(  484): alarm-manager.c: __check_privilege_by_cookie(1647) > Read procfs status successfully
10-14 14:43:25.665+0200 I/SCONTEXT-LIB(14938): feature_wearable.cpp: cx_is_feature_supported(97) > Initializing the feature map
10-14 14:43:25.670+0200 I/SCONTEXT-LIB(14938): comm.c: cx_connect_dbus(123) > Connecting Dbus
10-14 14:43:25.715+0200 I/SCONTEXT-LIB(14938): comm.c: cx_connect_dbus(148) > Dbus connected: ':1.989'
10-14 14:43:25.715+0200 I/SCONTEXT-LIB(14938): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 45 (req_id=1)
10-14 14:43:25.715+0200 I/SCONTEXT-LIB(14938): scontext.c: context_get_context(108) > [SUCCESS] Get Context: 45 (req_id=2)
10-14 14:43:25.760+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 14:43:25.760+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 14:43:25.760+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:43:25.760+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 2 
10-14 14:43:25.760+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 2
10-14 14:43:25.775+0200 W/W_CLOCK_VIEWER(14938): clock-viewer-util-dbus.c: clock_viewer_util_dbus_get_device_angle(152) >  Get device angle[4]
10-14 14:43:25.775+0200 W/W_CLOCK_VIEWER(14938): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-14 14:43:25.775+0200 I/APP_CORE(14938): appcore-efl.c: __do_app(429) > [APP 14938] Event: RESET State: CREATED
10-14 14:43:25.775+0200 I/CAPI_APPFW_APPLICATION(14938): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 14:43:25.790+0200 I/APP_CORE(14938): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 14:43:25.790+0200 I/APP_CORE(14938): appcore-efl.c: __do_app(474) > [APP 14938] Initial Launching, call the resume_cb
10-14 14:43:25.790+0200 I/CAPI_APPFW_APPLICATION(14938): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:43:25.800+0200 W/APP_CORE(14938): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4200002
10-14 14:43:25.890+0200 E/DATA_PROVIDER_MASTER(  706): package.c: package_alter_instances_to_client(1695) > Failed to load a buffer
10-14 14:43:25.895+0200 W/W_CLOCK_VIEWER(14938): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(194) >  get_info_cb called err[0], context[45], data[{ "Time" : 1507985005755, "Reason" : 0, "Status" : 2 }], req_id[2]
10-14 14:43:25.895+0200 W/W_CLOCK_VIEWER(14938): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(214) >  status[2] Wear OFF
10-14 14:43:25.895+0200 E/WIDGET_VIEWER(14938): client.c: master_created(1712) > [31,331347] pkgname: com.samsung.idle-clock-volt_sparkle, id: file:///opt/usr/share/live_magazine/com.samsung.idle-clock-volt_sparkle_1063_31,331347.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 216, widget_h: 432, cluster: user,created, category: default, widget_fname: "pixmap://29360130:4", gbar_fname: "", auto_launch: , priority: 0,000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0,000000, title: [], is_pinned_up: 0
10-14 14:43:25.905+0200 E/DATA_PROVIDER_MASTER(  706): shared_fd_service.c: direct_hello_handler(66) > Client is not exists: 
10-14 14:43:25.910+0200 E/WIDGET_EVAS(14938): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-14 14:43:25.910+0200 W/W_CLOCK_VIEWER(14938): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(257) >  DBOX Created[com.samsung.idle-clock-volt_sparkle] it should be [com.samsung.idle-clock-volt_sparkle]
10-14 14:43:25.910+0200 W/W_CLOCK_VIEWER(14938): clock-viewer-dbox.c: _clock_viewer_widget_list_append(128) >  >>>Append to list[com.samsung.idle-clock-volt_sparkle][0x4152bee8]
10-14 14:43:25.975+0200 W/MUSIC_PLAYER(14976): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:14976]   W_SERVICE_TYPE_BT[1][0m
10-14 14:43:25.975+0200 W/MUSIC_PLAYER(14976): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:14976]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-14 14:43:25.975+0200 W/MUSIC_TRANSFER(14976): mt-service.c: _service_app_create(88) > [31m[TID:14976]   SAP is disconnected.. Terminate process[0m
10-14 14:43:25.975+0200 I/CAPI_APPFW_APPLICATION(14976): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 14:43:26.030+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_show(1505) > [windicator_moment_view_show:1505] Show Moment View : type(1)
10-14 14:43:26.030+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1648) > [windicator_init_battery_rect:1648] battery level 100, index 20, bg level 100
10-14 14:43:26.030+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1652) > [windicator_init_battery_rect:1652] Battery signal emit : bg_level_90
10-14 14:43:26.050+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_get_angle(613) > [_windicator_get_angle:613] Unknown state(0)
10-14 14:43:26.050+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(650) > [_windicator_rotation_changed_cb:650] invliad state, Add timer :0 angle:-1
10-14 14:43:26.050+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(657) > [_windicator_rotation_changed_cb:657] Got specific angle, so delete timer!
10-14 14:43:26.050+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:4 angle:1 / is_connected : 1
10-14 14:43:26.050+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(688) > [_windicator_rotation_changed_cb:688] [ROTATION] Refresh angle value only for 90`, 270`
10-14 14:43:26.050+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_angle_changed(1600) > [windicator_moment_view_angle_changed:1600] [Rotation] Angle : 1 (check 1,3)
10-14 14:43:26.050+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_angle_changed(1607) > [windicator_moment_view_angle_changed:1607] Target is taken to charger with portrait mode. and rotated at this time.
10-14 14:43:26.065+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:43:26.085+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 14:43:26.085+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 14:43:26.085+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 14:43:26.085+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 14:43  /5 / HH:mm
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 14:43
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 14
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 43
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  14
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  43
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 14 / 43 / 14:43
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 14:43:26.090+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_charging_watch_ui_show(1442) > [windicator_moment_view_charging_watch_ui_show:1442] [Rotation] Degree : 270
10-14 14:43:26.125+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 14:43:26.125+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.125+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.130+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.175+0200 W/APP_CORE(  714): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000a
10-14 14:43:26.175+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:43:26.180+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(344) > appcore paused manually
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): main.c: home_appcore_pause(723) > Home Appcore Paused
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 14:43:26.210+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:43:26.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:43:26.215+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 14:43:26.215+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 14:43:26.220+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 14:43:26.225+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 14:43:26.225+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 14:43:26.225+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 14:43:26.225+0200 E/W_HOME  ( 1063): main.c: _pause_cb(674) > paused already
10-14 14:43:26.240+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:43:26.240+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:43:26.240+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:43:26.245+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 14:43:26.245+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:43:26.260+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:43:26.260+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 14:43:26.320+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.992
10-14 14:43:26.335+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 14:43:26.335+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 14:43:26.335+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 14:43:26.335+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 14:43:26.350+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 14:43:26.010+0200 W/MUSIC_PLAYER(14976): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:14976]   vendor : LO[0m
10-14 14:43:26.350+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:43:26.370+0200 W/MUSIC_PLAYER(14976): mp-conf.c: mp_conf_init(262) > [33m[TID:14976]   iOS  connected..[0m
10-14 14:43:26.380+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(14976): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-14 14:43:26.380+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(14976): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-14 14:43:26.380+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(14976): preference.c: preference_get_int(1132) > preference_get_int(14976) : key(tutorial_complete) error
10-14 14:43:26.425+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 14:43:26.425+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 14:43:26.435+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:43:26.445+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14972
10-14 14:43:26.460+0200 W/MUSIC_TRANSFER(14976): mt-service.c: _service_app_terminate(104) > [33m[TID:14976]   [0m
10-14 14:43:26.490+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-14 14:43:26.610+0200 E/CAPI_NETWORK_BLUETOOTH( 1814): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1814]   bt_gatt_client_get_service Error[-22][0m
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1814]   remote mode[0][0m
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:43:26.610+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 14:43:26.610+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 14:43:26.610+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 14:43:26.610+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 14:43:26.620+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 14:43:26.620+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 14:43:26.620+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 14:43:26.720+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 14:43:26.830+0200 W/AUL     (14988): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-14 14:43:26.830+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:43:26.830+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:43:26.830+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 14976
10-14 14:43:26.830+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:43:26.850+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14976
10-14 14:43:26.985+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:43:26.995+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:43:27.025+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-14 14:43:27.025+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:43:27.265+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:43:27.275+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14938
10-14 14:43:27.305+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:43:27.390+0200 W/SHealth_Service( 1005): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
10-14 14:43:27.390+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 14:43:27.545+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-14 14:43:27.595+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 14:43:27.645+0200 W/WG-CONSUMER(14972): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-14 14:43:27.645+0200 I/CAPI_CONTENT_MEDIA_CONTENT(14972): media_content.c: media_content_connect(870) > [32m[14972]ref count : 0
10-14 14:43:27.665+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:43:27.675+0200 I/CAPI_CONTENT_MEDIA_CONTENT(14972): media_content.c: media_content_connect(902) > [32m[14972]ref count changed to: 1
10-14 14:43:27.675+0200 W/WG-CONSUMER(14972): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-14 14:43:27.675+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14972
10-14 14:43:27.705+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-14 14:43:27.705+0200 E/WG-CONSUMER(14972): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 14:43:27.705+0200 E/WG-CONSUMER(14972): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 14:43:27.705+0200 E/WG-CONSUMER(14972): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-14 14:43:27.705+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-14 14:43:27.705+0200 E/WG-CONSUMER(14972): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-14 14:43:27.705+0200 E/WG-CONSUMER(14972): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 14:43:27.760+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 14:43:27.845+0200 E/WG-CONSUMER(14972): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 14:43:27.845+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 14:43:27.845+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 14:43:27.845+0200 E/WG-CONSUMER(14972): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-14 14:43:27.845+0200 W/WG-CONSUMER(14972): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42eaf8d0[0m
10-14 14:43:27.845+0200 W/CAPI_APPFW_APP_CONTROL(14972): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 14:43:27.845+0200 W/CAPI_APPFW_APP_CONTROL(14972): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 14:43:27.970+0200 E/RESOURCED( 1005): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 14:43:27.970+0200 E/AUL     ( 1005): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 14:43:27.970+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:43:28.035+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 14:43:28.085+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-14 14:43:28.125+0200 I/CAPI_APPFW_APPLICATION(14972): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 14:43:28.125+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 14:43:28.125+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 14:43:28.125+0200 E/WIPC_SERVER(14972): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 14:43:28.125+0200 W/WG-CONSUMER(14972): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 14:43:28.155+0200 I/CAPI_CONTENT_MEDIA_CONTENT(14972): media_content.c: media_content_disconnect(958) > [32m[14972]ref count changed to: 0
10-14 14:43:28.260+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:43:28.265+0200 E/WG-CONSUMER(14972): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-14 14:43:28.265+0200 W/WG-CONSUMER(14972): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-14 14:43:28.265+0200 W/WG-CONSUMER(14972): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-14 14:43:28.265+0200 W/WG-CONSUMER(14972): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-14 14:43:28.265+0200 W/WG-CONSUMER(14972): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-14 14:43:28.265+0200 W/WG-CONSUMER(14972): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-14 14:43:28.265+0200 W/WG-CONSUMER(14972): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-14 14:43:28.270+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14938
10-14 14:43:28.275+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:43:28.325+0200 E/EFL     (14984): elementary<14984> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:43:28.325+0200 E/EFL     (14984): elementary<14984> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:43:28.345+0200 E/EFL     (14984): elementary<14984> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:43:28.350+0200 E/EFL     (14984): elementary<14984> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:43:28.395+0200 E/EFL     (14984): elementary<14984> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:43:28.395+0200 E/EFL     (14984): elementary<14984> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:43:28.395+0200 E/EFL     (14984): elementary<14984> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:43:28.395+0200 E/EFL     (14984): elementary<14984> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:43:28.395+0200 E/EFL     (14984): elementary<14984> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:43:28.425+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:43:28.440+0200 E/EFL     (14984): elementary<14984> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:43:28.445+0200 E/EFL     (14984): elementary<14984> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:43:28.445+0200 E/EFL     (14984): elementary<14984> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:43:28.470+0200 W/AUL     (14993): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-14 14:43:28.475+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:43:28.475+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:43:28.475+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 14972
10-14 14:43:28.475+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:43:28.480+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14972
10-14 14:43:28.515+0200 E/EFL     (14984): elementary<14984> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:43:28.540+0200 E/EFL     (14984): elementary<14984> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:43:28.540+0200 E/EFL     (14984): elementary<14984> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:43:28.540+0200 E/EFL     (14984): elementary<14984> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:43:28.540+0200 E/EFL     (14984): elementary<14984> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:43:28.540+0200 E/EFL     (14984): elementary<14984> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:43:28.540+0200 E/EFL     (14984): elementary<14984> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:43:28.540+0200 I/AUL_PAD (14984): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:43:28.695+0200 W/CRASH_MANAGER(14896): worker.c: worker_job(1205) > 11149426461741507985001
10-14 14:43:30.125+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:43:31.230+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 14:43:33.245+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 14:43:33.575+0200 W/CRASH_MANAGER(14896): worker.c: worker_job(1205) > 1114954646174150798500
