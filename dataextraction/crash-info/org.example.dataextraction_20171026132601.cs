S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 21762
Date: 2017-10-26 13:26:01+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x41f0ff60, r1   = 0x00000001
r2   = 0x4059d250, r3   = 0x388c1a00
r4   = 0xbed814d4, r5   = 0x4144ad30
r6   = 0x00000233, r7   = 0xbed813f8
r8   = 0xbed814a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e5a00, sp   = 0xbed813c8
lr   = 0x404e5ab4, pc   = 0x41645c3c
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     18128 KB
Buffers:     47488 KB
Cached:     163052 KB
VmPeak:      65816 KB
VmSize:      65812 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12016 KB
VmRSS:       12012 KB
VmData:      12568 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21762 TID = 21762
21762 21821 

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
41935000 41a72000 r-xp /usr/lib/libicui18n.so.51.1
41a82000 41b66000 r-xp /usr/lib/libicuuc.so.51.1
41b7b000 41b97000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41ba0000 41ba3000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41bab000 41bac000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41bb5000 41bbd000 r-xp /usr/lib/libdrm.so.2.4.0
41bc5000 41bc7000 r-xp /usr/lib/libdri2.so.0.0.0
41bcf000 41bd6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41bdf000 41be1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41be9000 41bf0000 r-xp /usr/lib/libminizip.so.1.0.0
41bf8000 41bfe000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c06000 41c0b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c13000 41c34000 r-xp /usr/lib/libexif.so.12.3.3
41c47000 41c49000 r-xp /usr/lib/libttrace.so.1.1
41c51000 41c56000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c5e000 41d28000 r-xp /usr/lib/libCOREGL.so.4.0
41d32000 41e25000 rw-p [heap]
41e25000 41f3c000 rw-p [heap]
436c6000 43f00000 rw-p [stack:21821]
bed61000 bed82000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21762)
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
DICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:22:00.270+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:22:08.730+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:22:19.745+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:22:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:22:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:22:30.565+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:22:30.570+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:22:30.585+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:22:30.585+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:22:30.590+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:22:30.590+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:22:30.600+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:22:30.625+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:22:30.625+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:22:30.635+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:22:30.635+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:22:31.230+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:22:42.870+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:22:59.995+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 13:23:00.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 13:23:00.075+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[1768392212] is expired.
10-26 13:23:00.075+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1768392212, next duetime: 1509017100
10-26 13:23:00.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:23:00.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:25:00 (UTC).
10-26 13:23:00.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:23:00.080+0200 E/ALARM_MANAGER(20930): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [1768392212]
10-26 13:23:00.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 13:23:00.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:23  /5 / HH:mm
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:23
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 23
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  23
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 23 / 13:23
10-26 13:23:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:23:00.225+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:23:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:23:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:23:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:23:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:23:30.570+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:23:30.570+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:23:30.575+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:23:30.585+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:23:30.590+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:23:30.620+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:23:30.620+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:23:30.625+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:23:30.630+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:24  /5 / HH:mm
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:24
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 24
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  24
10-26 13:24:00.230+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 24 / 13:24
10-26 13:24:00.235+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:24:00.245+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:24:30.520+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:24:30.525+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:24:30.535+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:24:30.535+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:24:30.545+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:24:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:24:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:24:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:24:30.555+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:24:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:24:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:24:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:24:30.565+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:24:59.995+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 13:25:00.075+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 13:25:00.160+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[1768392212] is expired.
10-26 13:25:00.160+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1768392212, next duetime: 1509017220
10-26 13:25:00.165+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:25:00.165+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:27:00 (UTC).
10-26 13:25:00.165+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:25:00.165+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 13:25:00.165+0200 E/ALARM_MANAGER(20930): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [1768392212]
10-26 13:25:00.200+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 13:25:00.255+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:25  /5 / HH:mm
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:25
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 25
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  25
10-26 13:25:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 25 / 13:25
10-26 13:25:00.265+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:25:00.270+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:25:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:25:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:25:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:25:30.550+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:25:30.555+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:25:30.555+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:25:30.555+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:25:30.555+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:25:30.555+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:25:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:25:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:25:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:25:30.560+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:25:47.400+0200 E/PKGMGR_SERVER(21609): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:25:47.510+0200 E/PKGMGR_SERVER(21609): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1862564623], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[NeVqK0DZ8zNMEegrLUPYgnDW0a8=], backend_flag=[0]
10-26 13:25:47.525+0200 E/PKGMGR_SERVER(21610): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-26 13:25:47.530+0200 E/PKGMGR  (21607): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-26 13:25:47.615+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:25:47.625+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:25:47.640+0200 E/PKGMGR_SERVER(21610): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-26 13:25:47.660+0200 E/PKGMGR_SERVER(21609): pkgmgr-server.c: sighandler(409) > child NORMAL exit [21610]
10-26 13:25:49.665+0200 E/PKGMGR_SERVER(21609): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:25:49.665+0200 E/PKGMGR_SERVER(21609): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:25:49.870+0200 E/PKGMGR  (21694): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-26 13:25:50.205+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:25:50.405+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1865291135], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_1865291135' '-r' 'org.example.dataextraction'], cookie=[6Y7M5fVxX965HGHdQEQgNibqJec=], backend_flag=[0]
10-26 13:25:50.410+0200 E/PKGMGR  (21696): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-26 13:25:50.410+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-26 13:25:50.415+0200 E/PKGMGR  (21694): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[216940002]
10-26 13:25:50.415+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:25:50.425+0200 E/PKGMGR_SERVER(21697): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-26 13:25:50.425+0200 E/PKGMGR_SERVER(21698): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:25:50.590+0200 E/PKGMGR_OBSERVER(21698): pkg_observer.c: main(601) > OBSERVER start
10-26 13:25:50.625+0200 E/rpm-installer(21697): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:25:50.625+0200 E/rpm-installer(21697): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:25:50.630+0200 E/rpm-installer(21697): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:25:50.875+0200 E/PKGMGR_OBSERVER(21698): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[216980002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-26 13:25:50.910+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-26 13:25:50.910+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-26 13:25:50.925+0200 E/PKGMGR_OBSERVER(21698): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[216980002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:25:50.940+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-26 13:25:50.950+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-26 13:25:50.980+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-26 13:25:51.080+0200 W/CERT_SVC(21697): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:25:51.105+0200 E/rpm-installer(21697): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-26 13:25:51.105+0200 E/rpm-installer(21697): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-26 13:25:51.105+0200 E/rpm-installer(21697): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-26 13:25:51.135+0200 E/PKGMGR_PARSER(21697): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:25:51.170+0200 I/PRIVACY-MANAGER-CLIENT(21697): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:25:51.175+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: mainloop(227) > Got incoming connection
10-26 13:25:51.175+0200 I/PRIVACY-MANAGER-CLIENT(21697): SocketStream.h: SocketStream(31) > Created
10-26 13:25:51.175+0200 I/PRIVACY-MANAGER-CLIENT(21697): SocketConnection.h: SocketConnection(44) > Created
10-26 13:25:51.175+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(253) > Starting connection thread
10-26 13:25:51.175+0200 I/PRIVACY-MANAGER-CLIENT(21697): SocketClient.cpp: connect(62) > Client connected
10-26 13:25:51.185+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketStream.h: SocketStream(31) > Created
10-26 13:25:51.185+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketConnection.h: SocketConnection(44) > Created
10-26 13:25:51.185+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(304) > Calling service
10-26 13:25:51.195+0200 I/PRIVACY-MANAGER-CLIENT(21697): SocketClient.cpp: disconnect(72) > Client disconnected
10-26 13:25:51.210+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(307) > Removing client
10-26 13:25:51.210+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(311) > Call served
10-26 13:25:51.210+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(262) > Client serviced
10-26 13:25:51.215+0200 E/PKGMGR_CERT(21697): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-26 13:25:51.230+0200 E/PKGMGR_CERT(21697): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-26 13:25:51.275+0200 E/PKGMGR_CERT(21697): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-26 13:25:51.440+0200 E/rpm-installer(21697): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-26 13:25:51.445+0200 E/PKGMGR_OBSERVER(21698): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[216980002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-26 13:25:51.460+0200 E/APPS    (  769): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-26 13:25:51.460+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-26 13:25:51.485+0200 E/PKGMGR_OBSERVER(21698): pkg_observer.c: main(620) > OBSERVER end
10-26 13:25:51.505+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:25:51.505+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: sighandler(409) > child NORMAL exit [21698]
10-26 13:25:51.515+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-26 13:25:51.520+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-26 13:25:51.560+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-26 13:25:51.560+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:25:51.560+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:25:51.560+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:25:52.560+0200 E/rpm-installer(21697): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:25:52.560+0200 E/rpm-installer(21697): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:25:52.560+0200 E/rpm-installer(21697): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:25:52.605+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: sighandler(409) > child NORMAL exit [21697]
10-26 13:25:52.630+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/21697/oom_score_adj failed
10-26 13:25:52.630+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 21697
10-26 13:25:52.650+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:25:52.650+0200 E/PKGMGR_SERVER(21696): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:25:53.985+0200 E/PKGMGR  (21749): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 13:25:54.205+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:25:54.350+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1869377466], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1869377466' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[WxJuHDXzfggxIwFa3Wech8IjXao=], backend_flag=[0]
10-26 13:25:54.370+0200 E/PKGMGR  (21751): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 13:25:54.375+0200 E/PKGMGR  (21749): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[217490002]
10-26 13:25:54.390+0200 E/PKGMGR_SERVER(21752): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 13:25:54.395+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:25:54.420+0200 E/PKGMGR_SERVER(21753): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:25:54.565+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: main(601) > OBSERVER start
10-26 13:25:54.620+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:25:54.620+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:25:54.620+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:25:54.800+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 13:25:54.810+0200 E/rpm-installer(21752): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 13:25:54.815+0200 E/rpm-installer(21752): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 13:25:54.820+0200 E/rpm-installer(21752): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 13:25:54.820+0200 E/rpm-installer(21752): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 13:25:54.825+0200 E/rpm-installer(21752): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 13:25:54.930+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[217530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 13:25:54.940+0200 E/APPS    (  769): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 13:25:54.940+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 13:25:54.960+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 13:25:54.965+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[217530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:25:54.990+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 13:25:55.015+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:25:55.140+0200 W/CERT_SVC(21752): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:25:55.175+0200 E/rpm-installer(21752): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 13:25:55.175+0200 E/rpm-installer(21752): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 13:25:55.175+0200 E/rpm-installer(21752): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 13:25:55.175+0200 E/rpm-installer(21752): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 13:25:55.270+0200 E/PKGMGR_PARSER(21752): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 13:25:55.285+0200 E/PKGMGR_PARSER(21752): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:25:55.325+0200 E/PKGMGR_PARSER(21752): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 13:25:55.440+0200 I/PRIVACY-MANAGER-CLIENT(21752): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:25:55.620+0200 I/efl-extension(21752): efl_extension.c: eext_mod_init(40) > Init
10-26 13:25:55.620+0200 I/efl-extension(21752): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 13:25:55.765+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 13:25:55.765+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 13:25:55.770+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 13:25:55.770+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 13:25:55.770+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 13:25:55.770+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 13:25:55.770+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 13:25:55.790+0200 E/PKGMGR_CERT(21752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 13:25:55.795+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[217530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 13:25:55.860+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:25:55.890+0200 E/rpm-installer(21752): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 13:25:55.900+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20961 pgid = 20961
10-26 13:25:55.920+0200 E/rpm-installer(21752): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 13:25:56.015+0200 E/rpm-installer(21752): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 13:25:56.080+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20961
10-26 13:25:56.090+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.716
10-26 13:25:56.115+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[217530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 13:25:56.125+0200 E/rpm-installer(21752): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 13:25:56.145+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:25:56.195+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:25:56.195+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20734 pgid = -1
10-26 13:25:56.195+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:25:56.210+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20734
10-26 13:25:56.225+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.717
10-26 13:25:56.265+0200 E/EFL     (21762): elementary<21762> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:25:56.265+0200 E/EFL     (21762): elementary<21762> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:25:56.345+0200 E/EFL     (21762): elementary<21762> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:25:56.355+0200 E/EFL     (21762): elementary<21762> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:25:56.430+0200 E/EFL     (21762): elementary<21762> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:25:56.435+0200 E/EFL     (21762): elementary<21762> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:25:56.445+0200 E/EFL     (21762): elementary<21762> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:25:56.450+0200 E/EFL     (21762): elementary<21762> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:25:56.450+0200 E/EFL     (21762): elementary<21762> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:25:56.495+0200 E/EFL     (21762): elementary<21762> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:25:56.510+0200 E/EFL     (21762): elementary<21762> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:25:56.515+0200 E/EFL     (21762): elementary<21762> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:25:56.650+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:25:56.715+0200 E/EFL     (21762): elementary<21762> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:25:56.745+0200 E/EFL     (21762): elementary<21762> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:25:56.745+0200 E/EFL     (21762): elementary<21762> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:25:56.745+0200 E/EFL     (21762): elementary<21762> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:25:56.745+0200 E/EFL     (21762): elementary<21762> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:25:56.745+0200 E/EFL     (21762): elementary<21762> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:25:56.745+0200 E/EFL     (21762): elementary<21762> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:25:56.745+0200 I/AUL_PAD (21762): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:25:57.150+0200 I/efl-extension(21763): efl_extension.c: eext_mod_init(40) > Init
10-26 13:25:57.215+0200 E/EFL     (21763): elementary<21763> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:25:57.220+0200 E/EFL     (21763): elementary<21763> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:25:57.255+0200 E/EFL     (21763): elementary<21763> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:25:57.265+0200 I/UXT     (21763): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:25:57.270+0200 E/EFL     (21763): elementary<21763> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:25:57.360+0200 E/EFL     (21763): elementary<21763> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:25:57.360+0200 E/EFL     (21763): elementary<21763> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:25:57.375+0200 E/EFL     (21763): elementary<21763> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:25:57.390+0200 E/EFL     (21763): elementary<21763> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:25:57.400+0200 E/EFL     (21763): elementary<21763> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:25:57.495+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[217530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 13:25:57.525+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 13:25:57.525+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 13:25:57.585+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 13:25:57.605+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 13:25:57.605+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:25:57.605+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:25:57.605+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:25:57.605+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 13:25:57.605+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 13:25:57.625+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 13:25:57.720+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 13:25:57.740+0200 E/PKGMGR_INFO(21753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 13:25:57.760+0200 E/PKGMGR_OBSERVER(21753): pkg_observer.c: main(620) > OBSERVER end
10-26 13:25:57.785+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:25:57.785+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: sighandler(409) > child NORMAL exit [21753]
10-26 13:25:57.815+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 13:25:57.855+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 13:25:57.855+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 13:25:57.900+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 13:25:57.905+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 13:25:57.945+0200 E/EFL     (21763): elementary<21763> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:25:57.965+0200 E/EFL     (21763): elementary<21763> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:25:58.010+0200 E/EFL     (21763): elementary<21763> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:25:58.510+0200 E/EFL     (21763): elementary<21763> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:25:58.580+0200 E/EFL     (21763): elementary<21763> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:25:58.600+0200 E/EFL     (21763): elementary<21763> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:25:58.605+0200 E/EFL     (21763): elementary<21763> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:25:58.605+0200 E/EFL     (21763): elementary<21763> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:25:58.605+0200 E/EFL     (21763): elementary<21763> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:25:58.605+0200 E/EFL     (21763): elementary<21763> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:25:58.605+0200 I/AUL_PAD (21763): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:25:58.650+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:25:58.910+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:25:58.910+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:25:58.910+0200 E/rpm-installer(21752): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:25:58.935+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: sighandler(409) > child NORMAL exit [21752]
10-26 13:25:59.010+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/21752/oom_score_adj failed
10-26 13:25:59.010+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 21752
10-26 13:26:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:26  /5 / HH:mm
10-26 13:26:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:26
10-26 13:26:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:26:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:26:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 26
10-26 13:26:00.260+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:26:00.265+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  26
10-26 13:26:00.265+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 26 / 13:26
10-26 13:26:00.265+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:26:00.265+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:26:00.650+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:26:00.650+0200 E/PKGMGR_SERVER(21751): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:26:00.750+0200 W/AUL     (21819): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:26:00.755+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:26:00.775+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 13:26:00.790+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 13:26:00.790+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:26:00.790+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 21819
10-26 13:26:00.805+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:26:00.805+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:26:00.805+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:26:00.810+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:26:00.810+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:26:00.890+0200 I/efl-extension(21762): efl_extension.c: eext_mod_init(40) > Init
10-26 13:26:00.895+0200 I/UXT     (21762): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:26:00.905+0200 I/CAPI_APPFW_APPLICATION(21762): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:26:00.915+0200 I/CAPI_APPFW_APPLICATION(21762): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:26:01.010+0200 W/AUL     (21819): launch.c: app_request_to_launchpad(282) > request cmd(0) result(21762)
10-26 13:26:01.020+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:26:01.175+0200 I/Bluetooth(21762): [bt_initialize] success.
10-26 13:26:01.240+0200 I/Bluetooth(21762): [bt_adapter_get_state] success.
10-26 13:26:01.600+0200 W/CRASH_MANAGER(21822): worker.c: worker_job(1205) > 1121762646174150901716
