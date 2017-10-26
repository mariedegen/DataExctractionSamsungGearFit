S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 1969
Date: 2017-10-26 14:23:42+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x41a76650, r1   = 0x00000001
r2   = 0x4059d250, r3   = 0xb4973e00
r4   = 0xbeefa4d4, r5   = 0x4144ad30
r6   = 0x00000233, r7   = 0xbeefa3f8
r8   = 0xbeefa4a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e5a00, sp   = 0xbeefa3c8
lr   = 0x404e5ab4, pc   = 0x41645c3c
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     97408 KB
Buffers:     24840 KB
Cached:     154436 KB
VmPeak:      65824 KB
VmSize:      65820 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12032 KB
VmRSS:       12028 KB
VmData:      12576 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 1969 TID = 1969
1969 2032 

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
4143f000 41443000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
41452000 41457000 r-xp /usr/lib/libappcore-common.so.1.1
4145f000 41461000 r-xp /usr/lib/libiniparser.so.0
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 41648000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41658000 4168a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41693000 41697000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
416a0000 416a8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
416a9000 416ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
416d3000 4170d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41716000 4172f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41737000 4173c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41744000 4176e000 r-xp /usr/lib/libsensor.so.1.9.6
41777000 41789000 r-xp /usr/lib/libefl-assist.so.0.1.0
41791000 41849000 r-xp /usr/lib/libcairo.so.2.11200.14
41854000 41857000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4185f000 41865000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4186e000 41876000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4187e000 41888000 r-xp /usr/lib/libsensord-shared.so
41891000 418a3000 r-xp /usr/lib/libtts.so
418ab000 418cd000 r-xp /usr/lib/libui-extension.so.0.1.0
418d6000 418dd000 r-xp /usr/lib/libtbm.so.1.0.0
418e5000 418f3000 r-xp /usr/lib/libGLESv2.so.2.0
418fc000 418fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41906000 4190c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41914000 41917000 r-xp /usr/lib/libEGL.so.1.4
4191f000 4192c000 r-xp /usr/lib/libail.so.0.1.0
41935000 41951000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4195a000 4195d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41965000 41966000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4196f000 41977000 r-xp /usr/lib/libdrm.so.2.4.0
4197f000 41981000 r-xp /usr/lib/libdri2.so.0.0.0
41989000 4198d000 rw-p [heap]
4198d000 41aa4000 rw-p [heap]
41aa4000 41be1000 r-xp /usr/lib/libicui18n.so.51.1
41bf1000 41cd5000 r-xp /usr/lib/libicuuc.so.51.1
43273000 4327a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43283000 43285000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4328d000 43294000 r-xp /usr/lib/libminizip.so.1.0.0
4329c000 432a2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
432aa000 432af000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
432b7000 432d8000 r-xp /usr/lib/libexif.so.12.3.3
432eb000 432ed000 r-xp /usr/lib/libttrace.so.1.1
432f5000 432fa000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43302000 433cc000 r-xp /usr/lib/libCOREGL.so.4.0
435df000 43e00000 rw-p [stack:2032]
beeda000 beefb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1969)
Call Stack Count: 9
 0: start_bt_server + 0x13 (0x41645c3c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2c3c
 1: app_create + 0x5e (0x41644b37) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b37
 2: (0x414409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x41644a73) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1a73
 6: main + 0x36 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: create_base_gui + 0x8f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
r_get_volume() .. [0xfe6a0001][0m
10-26 14:22:55.391+0200 W/AUL     ( 1529): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-26 14:22:55.411+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 14:22:55.411+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 14:22:55.411+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 1511
10-26 14:22:55.411+0200 W/AUL_AMD (  509): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 14:22:55.416+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1511
10-26 14:22:55.826+0200 W/AUL_AMD (  509): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 14:22:56.056+0200 I/BUSACTD (  485): busact.c: busact_method_control_unit(158) > Controlling(StartUnit) unit(debug-launchpad.service) with mode(no-block)
10-26 14:22:56.086+0200 I/BUSACTD (  485): busact.c: busact_method_control_unit(170) > Successed to control unit: method(StartUnit), unit(debug-launchpad.service), mode(no-block)
10-26 14:22:56.836+0200 W/AUL_AMD (  509): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 14:22:57.516+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: MEM_FLUSH State: PAUSED
10-26 14:22:58.121+0200 W/W_INDICATOR(  731): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 14:22:58.121+0200 W/W_INDICATOR(  731): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 14:22:58.341+0200 E/CAPI_SYSTEM_INFO( 1546): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
10-26 14:22:58.351+0200 E/CAPI_SYSTEM_INFO( 1546): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 14:23  /5 / HH:mm
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 14:23
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 14
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 23
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  14
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  23
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 14 / 23 / 14:23
10-26 14:23:00.791+0200 W/W_INDICATOR(  731): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 14:23:00.801+0200 E/EFL     (  731): edje<731> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 14:23:01.311+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 14:23:21.741+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 14:23:21.751+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
10-26 14:23:21.751+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
10-26 14:23:21.751+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-26 14:23:21.751+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
10-26 14:23:21.756+0200 W/W_HOME  (  766): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 14:23:21.756+0200 W/W_HOME  (  766): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 14:23:21.756+0200 W/W_HOME  (  766): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 14:23:21.756+0200 W/W_HOME  (  766): gesture.c: _manual_render_enable(136) > 1
10-26 14:23:21.766+0200 W/STARTER (  723): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 14:23:21.766+0200 W/STARTER (  723): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 14:23:21.766+0200 E/STARTER (  723): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 14:23:21.771+0200 W/W_HOME  (  766): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 14:23:21.771+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 14:23:21.771+0200 W/STARTER (  723): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 14:23:21.771+0200 W/STARTER (  723): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 14:23:21.931+0200 W/W_INDICATOR(  731): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
10-26 14:23:21.951+0200 W/SHealth_Common( 1074): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 14:23:21.956+0200 W/SHealth_Service( 1074): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 14:23:21.956+0200 W/SHealth_Common(  835): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 14:23:21.986+0200 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: PAUSE State: RUNNING
10-26 14:23:21.986+0200 I/CAPI_APPFW_APPLICATION(  731): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 14:23:21.991+0200 I/APP_CORE(  731): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 14:23:22.006+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 14:23:22.006+0200 W/AUL_AMD (  509): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 14:23:22.011+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 14:23:22.011+0200 W/AUL_AMD (  509): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 14:23:22.046+0200 E/W_INDICATOR(  731): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 14:23:22.131+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
10-26 14:23:22.186+0200 W/STARTER (  723): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 14:23:22.186+0200 W/STARTER (  723): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
10-26 14:23:22.186+0200 W/STARTER (  723): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 14:23:22.186+0200 W/STARTER (  723): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 14:23:22.191+0200 E/ALARM_MANAGER(  723): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 14:23:42), repeat(1), interval(20), type(-1073741822)
10-26 14:23:22.226+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
10-26 14:23:22.226+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [723].
10-26 14:23:22.226+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
10-26 14:23:22.231+0200 E/ALARM_MANAGER( 1170): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(98), start(26-10-2017, 14:25:00), repeat(1), interval(120), type(-1073741822)
10-26 14:23:22.296+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1224514704, next duetime: 1509020622
10-26 14:23:22.296+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1224514704)
10-26 14:23:22.296+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509020622)
10-26 14:23:22.301+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 14:23:22.301+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:23:42 (UTC).
10-26 14:23:22.301+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 14:23:22.306+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [1170].
10-26 14:23:22.351+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1224514705, next duetime: 1509020700
10-26 14:23:22.351+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1224514705)
10-26 14:23:22.351+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509020622), due_time(1509020700)
10-26 14:23:22.351+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 14:23:22.351+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:23:42 (UTC).
10-26 14:23:22.351+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 14:23:22.731+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-26 14:23:22.731+0200 W/W_CLOCK_VIEWER( 1170): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-26 14:23:27.001+0200 I/APP_CORE(  731): appcore-efl.c: __do_app(429) > [APP 731] Event: MEM_FLUSH State: PAUSED
10-26 14:23:29.646+0200 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: main(2167) > package manager server start
10-26 14:23:29.726+0200 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1029893798], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[cFcICioiPse7CXuVx8xIHz5lTcI=], backend_flag=[0]
10-26 14:23:29.741+0200 E/PKGMGR_SERVER( 1807): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-26 14:23:29.801+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:23:29.811+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 14:23:29.821+0200 E/PKGMGR_SERVER( 1807): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-26 14:23:29.841+0200 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1807]
10-26 14:23:29.846+0200 E/PKGMGR  ( 1804): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-26 14:23:32.101+0200 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 14:23:32.101+0200 E/PKGMGR_SERVER( 1806): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 14:23:32.411+0200 E/PKGMGR  ( 1902): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-26 14:23:32.596+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: main(2167) > package manager server start
10-26 14:23:32.681+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1032857147], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_1032857147' '-r' 'org.example.dataextraction'], cookie=[gKjJ1dv91L5xDnW5CBI1MlNt1KU=], backend_flag=[0]
10-26 14:23:32.686+0200 E/PKGMGR  ( 1904): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-26 14:23:32.686+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-26 14:23:32.691+0200 E/PKGMGR  ( 1902): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[19020002]
10-26 14:23:32.696+0200 E/PKGMGR_SERVER( 1905): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-26 14:23:32.696+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 14:23:32.696+0200 E/PKGMGR_SERVER( 1906): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 14:23:32.786+0200 E/PKGMGR_OBSERVER( 1906): pkg_observer.c: main(601) > OBSERVER start
10-26 14:23:32.821+0200 E/rpm-installer( 1905): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 14:23:32.821+0200 E/rpm-installer( 1905): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 14:23:32.821+0200 E/rpm-installer( 1905): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 14:23:33.026+0200 E/PKGMGR_OBSERVER( 1906): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-26 14:23:33.066+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-26 14:23:33.066+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-26 14:23:33.076+0200 E/PKGMGR_OBSERVER( 1906): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 14:23:33.076+0200 W/W_HOME  (  766): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-26 14:23:33.106+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-26 14:23:33.131+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-26 14:23:33.261+0200 W/CERT_SVC( 1905): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 14:23:33.281+0200 E/rpm-installer( 1905): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-26 14:23:33.281+0200 E/rpm-installer( 1905): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-26 14:23:33.281+0200 E/rpm-installer( 1905): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-26 14:23:33.301+0200 E/PKGMGR_PARSER( 1905): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 14:23:33.321+0200 I/PRIVACY-MANAGER-CLIENT( 1905): SocketClient.cpp: SocketClient(37) > Client created
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: mainloop(227) > Got incoming connection
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-CLIENT( 1905): SocketStream.h: SocketStream(31) > Created
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-CLIENT( 1905): SocketConnection.h: SocketConnection(44) > Created
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-CLIENT( 1905): SocketClient.cpp: connect(62) > Client connected
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(253) > Starting connection thread
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketStream.h: SocketStream(31) > Created
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketConnection.h: SocketConnection(44) > Created
10-26 14:23:33.326+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(304) > Calling service
10-26 14:23:33.341+0200 I/PRIVACY-MANAGER-CLIENT( 1905): SocketClient.cpp: disconnect(72) > Client disconnected
10-26 14:23:33.341+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(307) > Removing client
10-26 14:23:33.341+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(311) > Call served
10-26 14:23:33.341+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(262) > Client serviced
10-26 14:23:33.346+0200 E/PKGMGR_CERT( 1905): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-26 14:23:33.351+0200 E/PKGMGR_CERT( 1905): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-26 14:23:33.366+0200 E/PKGMGR_CERT( 1905): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-26 14:23:33.431+0200 E/rpm-installer( 1905): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-26 14:23:33.441+0200 E/PKGMGR_OBSERVER( 1906): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-26 14:23:33.441+0200 E/PKGMGR_OBSERVER( 1906): pkg_observer.c: main(620) > OBSERVER end
10-26 14:23:33.451+0200 E/APPS    (  766): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-26 14:23:33.451+0200 E/APPS    (  766): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-26 14:23:33.471+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-26 14:23:33.471+0200 E/STARTER (  723): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-26 14:23:33.476+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 14:23:33.476+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1906]
10-26 14:23:33.536+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-26 14:23:33.536+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 14:23:33.536+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 14:23:33.536+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 14:23:34.191+0200 E/rpm-installer( 1905): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 14:23:34.191+0200 E/rpm-installer( 1905): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 14:23:34.191+0200 E/rpm-installer( 1905): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 14:23:34.256+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1905]
10-26 14:23:34.306+0200 E/RESOURCED(  510): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/1905/oom_score_adj failed
10-26 14:23:34.311+0200 E/RESOURCED(  510): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 1905
10-26 14:23:35.101+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 14:23:35.101+0200 E/PKGMGR_SERVER( 1904): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 14:23:35.581+0200 E/PKGMGR  ( 1956): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 14:23:35.771+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: main(2167) > package manager server start
10-26 14:23:35.866+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1036009466], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1036009466' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[0cwEpG7uo6+4a8RF5yFbVIWsvIk=], backend_flag=[0]
10-26 14:23:35.876+0200 E/PKGMGR  ( 1958): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 14:23:35.886+0200 E/PKGMGR  ( 1956): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[19560002]
10-26 14:23:35.886+0200 E/PKGMGR_SERVER( 1959): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 14:23:35.886+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 14:23:35.891+0200 E/PKGMGR_SERVER( 1960): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 14:23:35.961+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: main(601) > OBSERVER start
10-26 14:23:35.996+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 14:23:35.996+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 14:23:35.996+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 14:23:36.111+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 14:23:36.121+0200 E/rpm-installer( 1959): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 14:23:36.121+0200 E/rpm-installer( 1959): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 14:23:36.126+0200 E/rpm-installer( 1959): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 14:23:36.131+0200 E/rpm-installer( 1959): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 14:23:36.131+0200 E/rpm-installer( 1959): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 14:23:36.226+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19600002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 14:23:36.236+0200 E/APPS    (  766): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 14:23:36.236+0200 E/APPS    (  766): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 14:23:36.256+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 14:23:36.261+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19600002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 14:23:36.286+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 14:23:36.311+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 14:23:36.431+0200 W/CERT_SVC( 1959): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 14:23:36.466+0200 E/rpm-installer( 1959): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 14:23:36.466+0200 E/rpm-installer( 1959): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 14:23:36.466+0200 E/rpm-installer( 1959): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 14:23:36.466+0200 E/rpm-installer( 1959): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 14:23:36.536+0200 E/PKGMGR_PARSER( 1959): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 14:23:36.546+0200 E/PKGMGR_PARSER( 1959): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 14:23:36.566+0200 E/PKGMGR_PARSER( 1959): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 14:23:36.641+0200 I/PRIVACY-MANAGER-CLIENT( 1959): SocketClient.cpp: SocketClient(37) > Client created
10-26 14:23:36.741+0200 I/efl-extension( 1959): efl_extension.c: eext_mod_init(40) > Init
10-26 14:23:36.741+0200 I/efl-extension( 1959): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 14:23:36.836+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 14:23:36.836+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 14:23:36.836+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 14:23:36.836+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 14:23:36.836+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 14:23:36.836+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 14:23:36.841+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 14:23:36.856+0200 E/PKGMGR_CERT( 1959): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 14:23:36.861+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19600002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 14:23:36.916+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 14:23:36.931+0200 E/rpm-installer( 1959): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 14:23:36.946+0200 E/rpm-installer( 1959): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 14:23:36.966+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1138 pgid = 1138
10-26 14:23:36.996+0200 E/rpm-installer( 1959): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 14:23:37.026+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19600002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 14:23:37.061+0200 E/rpm-installer( 1959): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 14:23:37.116+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1138
10-26 14:23:37.126+0200 E/RESOURCED(  510): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.165
10-26 14:23:37.146+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 14:23:37.191+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 14:23:37.191+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1516 pgid = -1
10-26 14:23:37.191+0200 W/AUL_PAD ( 1136): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 14:23:37.196+0200 I/AUL_AMD (  509): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1516
10-26 14:23:37.206+0200 E/RESOURCED(  510): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.166
10-26 14:23:37.661+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:23:37.666+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:23:37.716+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:23:37.726+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:23:37.786+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:23:37.786+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:23:37.796+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:23:37.796+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:23:37.796+0200 E/EFL     ( 1969): elementary<1969> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:23:37.836+0200 E/EFL     ( 1969): elementary<1969> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:23:37.836+0200 E/EFL     ( 1969): elementary<1969> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:23:37.846+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:23:37.901+0200 E/EFL     ( 1969): elementary<1969> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:23:37.926+0200 E/EFL     ( 1969): elementary<1969> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:23:37.926+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:23:37.926+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:23:37.926+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:23:37.926+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:23:37.926+0200 E/EFL     ( 1969): elementary<1969> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:23:37.926+0200 I/AUL_PAD ( 1969): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 14:23:38.031+0200 I/efl-extension( 1970): efl_extension.c: eext_mod_init(40) > Init
10-26 14:23:38.096+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[19600002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 14:23:38.101+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 14:23:38.111+0200 W/W_HOME  (  766): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 14:23:38.111+0200 W/W_HOME  (  766): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 14:23:38.151+0200 W/AUL_AMD (  509): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 14:23:38.166+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 14:23:38.166+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 14:23:38.166+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 14:23:38.166+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 14:23:38.166+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 14:23:38.166+0200 E/WMS     (  493): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 14:23:38.221+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 14:23:38.226+0200 E/PKGMGR_INFO( 1960): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 14:23:38.251+0200 E/PKGMGR_OBSERVER( 1960): pkg_observer.c: main(620) > OBSERVER end
10-26 14:23:38.266+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 14:23:38.266+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1960]
10-26 14:23:38.301+0200 E/STARTER (  723): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 14:23:38.301+0200 E/PKGMGR_INFO(  492): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 14:23:38.336+0200 W/APPS    (  766): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 14:23:38.341+0200 W/APPS    (  766): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 14:23:38.411+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 14:23:38.411+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 14:23:38.436+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 14:23:38.446+0200 I/UXT     ( 1970): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:23:38.446+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 14:23:38.506+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 14:23:38.506+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 14:23:38.511+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 14:23:38.511+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 14:23:38.511+0200 E/EFL     ( 1970): elementary<1970> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 14:23:38.531+0200 E/EFL     ( 1970): elementary<1970> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 14:23:38.531+0200 E/EFL     ( 1970): elementary<1970> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 14:23:38.536+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 14:23:38.571+0200 E/EFL     ( 1970): elementary<1970> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 14:23:38.586+0200 E/EFL     ( 1970): elementary<1970> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 14:23:38.586+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 14:23:38.586+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 14:23:38.586+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 14:23:38.586+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 14:23:38.586+0200 E/EFL     ( 1970): elementary<1970> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 14:23:38.586+0200 I/AUL_PAD ( 1970): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 14:23:39.231+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 14:23:39.231+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 14:23:39.231+0200 E/rpm-installer( 1959): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 14:23:39.266+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1959]
10-26 14:23:39.321+0200 E/RESOURCED(  510): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/1959/oom_score_adj failed
10-26 14:23:39.321+0200 E/RESOURCED(  510): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 1959
10-26 14:23:40.106+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 14:23:40.106+0200 E/PKGMGR_SERVER( 1958): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 14:23:41.621+0200 W/AUL     ( 2031): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:23:41.626+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:23:41.651+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 14:23:41.671+0200 I/AUL_AMD (  509): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 14:23:41.671+0200 E/AUL_AMD (  509): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 14:23:41.671+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 2031
10-26 14:23:41.696+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:23:41.696+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:23:41.701+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:23:41.701+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 14:23:41.701+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:23:41.791+0200 I/efl-extension( 1969): efl_extension.c: eext_mod_init(40) > Init
10-26 14:23:41.796+0200 I/UXT     ( 1969): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:23:41.801+0200 I/CAPI_APPFW_APPLICATION( 1969): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:23:41.811+0200 I/CAPI_APPFW_APPLICATION( 1969): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:23:41.906+0200 W/AUL     ( 2031): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1969)
10-26 14:23:41.921+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:23:41.991+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 14:23:41.991+0200 I/Bluetooth( 1969): [bt_initialize] success.
10-26 14:23:42.026+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 14:23:42.046+0200 I/Bluetooth( 1969): [bt_adapter_get_state] success.
10-26 14:23:42.056+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[1224514704] is expired.
10-26 14:23:42.056+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1224514704, next duetime: 1509020642
10-26 14:23:42.061+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 14:23:42.061+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:24:02 (UTC).
10-26 14:23:42.061+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 14:23:42.066+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 14:23:42.076+0200 E/RESOURCED(  510): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 723
10-26 14:23:42.086+0200 E/ALARM_MANAGER(  723): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1224514704]
10-26 14:23:42.086+0200 W/STARTER (  723): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [1224514704]
10-26 14:23:42.101+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 14:23:42.106+0200 W/AUL     (  723): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 14:23:42.111+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:23:42.116+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 723
10-26 14:23:42.121+0200 W/AUL_AMD (  509): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 766
10-26 14:23:42.126+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: RESET State: PAUSED
10-26 14:23:42.126+0200 I/CAPI_APPFW_APPLICATION(  766): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 14:23:42.126+0200 W/W_HOME  (  766): main.c: _app_control(1704) > Service value : show_clock
10-26 14:23:42.126+0200 W/W_HOME  (  766): main.c: _app_control(1746) > Show clock operation
10-26 14:23:42.126+0200 W/W_HOME  (  766): gesture.c: _clock_show(245) > clock show
10-26 14:23:42.131+0200 W/AUL_AMD (  509): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(766), cmd(0)
10-26 14:23:42.131+0200 W/AUL     (  723): launch.c: app_request_to_launchpad(282) > request cmd(0) result(766)
10-26 14:23:42.136+0200 W/W_HOME  (  766): gesture.c: _clock_show(260) > home raise
10-26 14:23:42.136+0200 E/W_HOME  (  766): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-26 14:23:42.136+0200 W/W_HOME  (  766): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-26 14:23:42.136+0200 W/W_HOME  (  766): gesture.c: _clock_show(263) > home raise done
10-26 14:23:42.136+0200 W/W_HOME  (  766): gesture.c: _clock_show(270) > show clock
10-26 14:23:42.136+0200 W/W_HOME  (  766): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-26 14:23:42.141+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 14:23:42.146+0200 W/W_HOME  (  766): move.c: _scroller_down_done(494) > down signal done
10-26 14:23:42.146+0200 W/W_HOME  (  766): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-26 14:23:42.146+0200 W/W_HOME  (  766): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 14:23:42.146+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:23:42.156+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:23:42.161+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [723].
10-26 14:23:42.161+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1224514704)
10-26 14:23:42.161+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 14:23:42.161+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:25:00 (UTC).
10-26 14:23:42.161+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 14:23:42.161+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1224514704] is removed.
10-26 14:23:42.166+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:23:42.166+0200 W/W_HOME  (  766): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-26 14:23:42.166+0200 W/W_HOME  (  766): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-26 14:23:42.166+0200 I/wnotib  (  766): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-26 14:23:42.166+0200 I/wnotib  (  766): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-26 14:23:42.176+0200 W/W_INDICATOR(  731): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 1, scroll 0
10-26 14:23:42.201+0200 E/APPS    (  766): apps_main.c: apps_main_pause(602) >  paused already
10-26 14:23:42.211+0200 E/EFL     (  766): evas_main<766> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46b4edb8 is not stable during recalc loop
10-26 14:23:42.211+0200 E/EFL     (  766): evas_main<766> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46b4edb8 is not stable during recalc loop
10-26 14:23:42.341+0200 W/W_INDICATOR(  731): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 74
10-26 14:23:42.341+0200 W/W_INDICATOR(  731): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-26 14:23:42.341+0200 W/W_INDICATOR(  731): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-26 14:23:42.341+0200 W/W_INDICATOR(  731): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 74, index 14, bg level 70
10-26 14:23:42.341+0200 W/W_INDICATOR(  731): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_70
10-26 14:23:42.341+0200 W/W_INDICATOR(  731): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 74
10-26 14:23:42.346+0200 E/EFL     (  731): edje<731> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 14:23:42.411+0200 W/CRASH_MANAGER( 2034): worker.c: worker_job(1205) > 1101969646174150902062
