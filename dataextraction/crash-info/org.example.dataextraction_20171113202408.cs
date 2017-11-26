S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 1867
Date: 2017-11-13 20:24:08+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x43e00010, r3   = 0x9d982f00
r4   = 0xbe87a50c, r5   = 0x41541980
r6   = 0x00000249, r7   = 0xbe87a448
r8   = 0xbe87a4dc, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbe87a430
lr   = 0x41744caf, pc   = 0x41746170
cpsr = 0x80000030

Memory Information
MemTotal:   491672 KB
MemFree:     94908 KB
Buffers:     24760 KB
Cached:     150236 KB
VmPeak:      92176 KB
VmSize:      91436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16668 KB
VmRSS:       16664 KB
VmData:      38060 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23076 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 1867 TID = 1867
1867 1934 1941 1942 1943 

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
435b8000 43db7000 rw-p [stack:1934]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43fb9000 447b8000 rw-p [stack:1941]
447b9000 44fb8000 rw-p [stack:1942]
44fb9000 457b8000 rw-p [stack:1943]
45870000 45873000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4587b000 4587c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
be85a000 be87b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1867)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x41746170) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3170
 1: app_terminate + 0x26 (0x41744caf) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1caf
 2: (0x41540af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41744c37) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c37
 6: create_base_gui + 0x52 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
t_item], index = 13, key = 13, type = 0
11-13 20:23:18.671+0200 E/TIZEN_N_SYSTEM_SETTINGS(  860): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-13 20:23:18.671+0200 E/TIZEN_N_SYSTEM_SETTINGS(  860): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-13 20:23:18.671+0200 E/TIZEN_N_SYSTEM_SETTINGS(  860): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-13 20:23:18.671+0200 E/TIZEN_N_SYSTEM_SETTINGS(  860): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-13 20:23:18.671+0200 W/SHealthWidget(  860): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>70</color> bpm</color>][0;m
11-13 20:23:34.016+0200 W/SHealth_Common(  860): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-13 20:23:34.036+0200 W/W_INDICATOR(  716): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
11-13 20:23:34.076+0200 W/SHealth_Common( 1118): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-13 20:23:34.076+0200 W/SHealth_Service( 1118): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-13 20:23:34.086+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
11-13 20:23:34.086+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
11-13 20:23:34.086+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
11-13 20:23:34.086+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
11-13 20:23:34.101+0200 W/WATCH_CORE(  811): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
11-13 20:23:34.101+0200 W/W_HOME  (  770): dbus.c: _dbus_message_recv_cb(204) > LCD off
11-13 20:23:34.101+0200 W/W_HOME  (  770): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-13 20:23:34.101+0200 W/W_HOME  (  770): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-13 20:23:34.101+0200 W/W_HOME  (  770): gesture.c: _manual_render_enable(136) > 1
11-13 20:23:34.101+0200 W/W_HOME  (  770): event_manager.c: _lcd_off_cb(704) > lcd state: 0
11-13 20:23:34.101+0200 W/W_HOME  (  770): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-13 20:23:34.106+0200 W/STARTER (  709): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
11-13 20:23:34.106+0200 W/STARTER (  709): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
11-13 20:23:34.106+0200 E/STARTER (  709): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
11-13 20:23:34.106+0200 W/STARTER (  709): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
11-13 20:23:34.106+0200 W/STARTER (  709): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
11-13 20:23:34.166+0200 I/APP_CORE(  716): appcore-efl.c: __do_app(429) > [APP 716] Event: PAUSE State: RUNNING
11-13 20:23:34.166+0200 I/CAPI_APPFW_APPLICATION(  716): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-13 20:23:34.166+0200 I/APP_CORE(  716): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
11-13 20:23:34.181+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-13 20:23:34.181+0200 W/AUL_AMD (  533): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-13 20:23:34.186+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-13 20:23:34.186+0200 W/AUL_AMD (  533): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-13 20:23:34.211+0200 E/W_INDICATOR(  716): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
11-13 20:23:34.326+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
11-13 20:23:34.381+0200 W/STARTER (  709): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
11-13 20:23:34.381+0200 W/STARTER (  709): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
11-13 20:23:34.381+0200 W/STARTER (  709): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
11-13 20:23:34.381+0200 W/STARTER (  709): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
11-13 20:23:34.381+0200 E/ALARM_MANAGER(  709): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(13-11-2017, 20:23:54), repeat(1), interval(20), type(-1073741822)
11-13 20:23:34.396+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
11-13 20:23:34.396+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
11-13 20:23:34.401+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [709].
11-13 20:23:34.406+0200 E/ALARM_MANAGER( 1192): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(86), start(13-11-2017, 20:25:00), repeat(1), interval(120), type(-1073741822)
11-13 20:23:34.456+0200 E/ALARM_MANAGER(  481): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1058996972, next duetime: 1510597434
11-13 20:23:34.456+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1058996972)
11-13 20:23:34.456+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1510606052), due_time(1510597434)
11-13 20:23:34.461+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-13 20:23:34.461+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 13-11-2017, 18:23:54 (UTC).
11-13 20:23:34.461+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-13 20:23:34.461+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:34.461+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:34.461+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [1192].
11-13 20:23:34.496+0200 E/ALARM_MANAGER(  481): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1058996973, next duetime: 1510597500
11-13 20:23:34.496+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1058996973)
11-13 20:23:34.496+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1510597434), due_time(1510597500)
11-13 20:23:34.501+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-13 20:23:34.501+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 13-11-2017, 18:23:54 (UTC).
11-13 20:23:34.501+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-13 20:23:34.501+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:34.501+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:34.906+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
11-13 20:23:34.906+0200 W/W_CLOCK_VIEWER( 1192): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
11-13 20:23:39.176+0200 I/APP_CORE(  716): appcore-efl.c: __do_app(429) > [APP 716] Event: MEM_FLUSH State: PAUSED
11-13 20:23:45.971+0200 E/AUL_AMD (  533): amd_main.c: __platform_ready_handler(371) > [Info]__platform_ready_handler
11-13 20:23:52.731+0200 E/PKGMGR_SERVER( 1681): pkgmgr-server.c: main(2167) > package manager server start
11-13 20:23:52.816+0200 E/PKGMGR_SERVER( 1681): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1600003783], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[lRoHMON/H9q2B2u8+gplbCkjAco=], backend_flag=[0]
11-13 20:23:52.826+0200 E/PKGMGR_SERVER( 1682): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
11-13 20:23:52.886+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 14
11-13 20:23:52.896+0200 W/AUL_AMD (  533): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
11-13 20:23:52.906+0200 E/PKGMGR_SERVER( 1682): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
11-13 20:23:52.921+0200 E/PKGMGR_SERVER( 1681): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1682]
11-13 20:23:52.936+0200 E/PKGMGR  ( 1679): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
11-13 20:23:53.996+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
11-13 20:23:54.046+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
11-13 20:23:54.121+0200 E/RESOURCED(  535): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 709
11-13 20:23:54.131+0200 E/ALARM_MANAGER(  709): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1058996972]
11-13 20:23:54.131+0200 W/STARTER (  709): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [1058996972]
11-13 20:23:54.141+0200 W/AUL     (  709): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
11-13 20:23:54.146+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
11-13 20:23:54.146+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 709
11-13 20:23:54.161+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 770
11-13 20:23:54.166+0200 I/APP_CORE(  770): appcore-efl.c: __do_app(429) > [APP 770] Event: RESET State: PAUSED
11-13 20:23:54.166+0200 I/CAPI_APPFW_APPLICATION(  770): app_main.c: app_appcore_reset(245) > app_appcore_reset
11-13 20:23:54.166+0200 W/W_HOME  (  770): main.c: _app_control(1704) > Service value : show_clock
11-13 20:23:54.166+0200 W/W_HOME  (  770): main.c: _app_control(1746) > Show clock operation
11-13 20:23:54.166+0200 W/W_HOME  (  770): gesture.c: _clock_show(245) > clock show
11-13 20:23:54.171+0200 W/AUL_AMD (  533): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(770), cmd(0)
11-13 20:23:54.176+0200 W/W_HOME  (  770): gesture.c: _clock_show(260) > home raise
11-13 20:23:54.176+0200 E/W_HOME  (  770): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
11-13 20:23:54.176+0200 W/W_HOME  (  770): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
11-13 20:23:54.176+0200 W/W_HOME  (  770): gesture.c: _clock_show(263) > home raise done
11-13 20:23:54.176+0200 W/W_HOME  (  770): gesture.c: _clock_show(270) > show clock
11-13 20:23:54.176+0200 I/APP_CORE(  770): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
11-13 20:23:54.186+0200 W/AUL     (  709): launch.c: app_request_to_launchpad(282) > request cmd(0) result(770)
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_expired(1432) > alarm_id[1058996972] is expired.
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1058996972, next duetime: 1510597454
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 13-11-2017, 18:24:14 (UTC).
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:54.191+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
11-13 20:23:54.196+0200 W/W_INDICATOR(  716): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [709].
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1058996972)
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 13-11-2017, 18:25:00 (UTC).
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1058996972] is removed.
11-13 20:23:54.236+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-13 20:23:54.571+0200 E/PKGMGR_SERVER( 1681): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-13 20:23:54.571+0200 E/PKGMGR_SERVER( 1681): pkgmgr-server.c: main(2221) > package manager server terminated.
11-13 20:23:55.171+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-13 20:23:55.171+0200 W/AUL_AMD (  533): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-13 20:23:57.341+0200 E/PKGMGR  ( 1790): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
11-13 20:23:57.541+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: main(2167) > package manager server start
11-13 20:23:57.631+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1604794532], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_1604794532' '-r' 'org.example.dataextraction'], cookie=[ZciX3bh37lW6JrnJPaifX2bRXWw=], backend_flag=[0]
11-13 20:23:57.636+0200 E/PKGMGR  ( 1793): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
11-13 20:23:57.636+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
11-13 20:23:57.641+0200 E/PKGMGR_SERVER( 1794): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
11-13 20:23:57.641+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
11-13 20:23:57.641+0200 E/PKGMGR_SERVER( 1795): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
11-13 20:23:57.646+0200 E/PKGMGR  ( 1790): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[17900002]
11-13 20:23:57.781+0200 E/PKGMGR_OBSERVER( 1795): pkg_observer.c: main(601) > OBSERVER start
11-13 20:23:57.831+0200 E/rpm-installer( 1794): rpm-appcore-intf.c: main(120) > ------------------------------------------------
11-13 20:23:57.831+0200 E/rpm-installer( 1794): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
11-13 20:23:57.831+0200 E/rpm-installer( 1794): rpm-appcore-intf.c: main(122) > ------------------------------------------------
11-13 20:23:58.041+0200 E/PKGMGR_OBSERVER( 1795): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[17950002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
11-13 20:23:58.071+0200 W/AUL_AMD (  533): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
11-13 20:23:58.071+0200 W/AUL_AMD (  533): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
11-13 20:23:58.081+0200 E/PKGMGR_OBSERVER( 1795): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[17950002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
11-13 20:23:58.101+0200 W/W_HOME  (  770): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
11-13 20:23:58.106+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
11-13 20:23:58.131+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
11-13 20:23:58.271+0200 W/CERT_SVC( 1794): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
11-13 20:23:58.286+0200 E/rpm-installer( 1794): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
11-13 20:23:58.286+0200 E/rpm-installer( 1794): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
11-13 20:23:58.286+0200 E/rpm-installer( 1794): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
11-13 20:23:58.301+0200 E/PKGMGR_PARSER( 1794): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-CLIENT( 1794): SocketClient.cpp: SocketClient(37) > Client created
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: mainloop(227) > Got incoming connection
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionThread(253) > Starting connection thread
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-CLIENT( 1794): SocketStream.h: SocketStream(31) > Created
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-CLIENT( 1794): SocketConnection.h: SocketConnection(44) > Created
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketStream.h: SocketStream(31) > Created
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-CLIENT( 1794): SocketClient.cpp: connect(62) > Client connected
11-13 20:23:58.321+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketConnection.h: SocketConnection(44) > Created
11-13 20:23:58.326+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionService(304) > Calling service
11-13 20:23:58.336+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionService(307) > Removing client
11-13 20:23:58.336+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionService(311) > Call served
11-13 20:23:58.336+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionThread(262) > Client serviced
11-13 20:23:58.336+0200 I/PRIVACY-MANAGER-CLIENT( 1794): SocketClient.cpp: disconnect(72) > Client disconnected
11-13 20:23:58.341+0200 E/PKGMGR_CERT( 1794): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
11-13 20:23:58.346+0200 E/PKGMGR_CERT( 1794): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
11-13 20:23:58.361+0200 E/PKGMGR_CERT( 1794): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
11-13 20:23:58.426+0200 E/rpm-installer( 1794): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
11-13 20:23:58.436+0200 E/PKGMGR_OBSERVER( 1795): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[17950002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
11-13 20:23:58.446+0200 E/PKGMGR_OBSERVER( 1795): pkg_observer.c: main(620) > OBSERVER end
11-13 20:23:58.456+0200 E/APPS    (  770): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
11-13 20:23:58.456+0200 E/APPS    (  770): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
11-13 20:23:58.476+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
11-13 20:23:58.476+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1795]
11-13 20:23:58.481+0200 W/AUL_AMD (  533): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
11-13 20:23:58.481+0200 E/STARTER (  709): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
11-13 20:23:58.561+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
11-13 20:23:58.561+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
11-13 20:23:58.561+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
11-13 20:23:58.561+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
11-13 20:23:59.206+0200 E/rpm-installer( 1794): rpm-appcore-intf.c: main(273) > ------------------------------------------------
11-13 20:23:59.206+0200 E/rpm-installer( 1794): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
11-13 20:23:59.206+0200 E/rpm-installer( 1794): rpm-appcore-intf.c: main(275) > ------------------------------------------------
11-13 20:23:59.251+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1794]
11-13 20:23:59.321+0200 E/RESOURCED(  535): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/1794/oom_score_adj failed
11-13 20:23:59.321+0200 E/RESOURCED(  535): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 1794
11-13 20:23:59.571+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-13 20:23:59.571+0200 E/PKGMGR_SERVER( 1793): pkgmgr-server.c: main(2221) > package manager server terminated.
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 20:24  /5 / HH:mm
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 20:24
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 20
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 24
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  20
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  24
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 20 / 24 / 20:24
11-13 20:24:00.611+0200 W/W_INDICATOR(  716): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
11-13 20:24:00.621+0200 E/EFL     (  716): edje<716> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
11-13 20:24:01.271+0200 E/PKGMGR  ( 1854): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
11-13 20:24:01.546+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: main(2167) > package manager server start
11-13 20:24:01.651+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1608702513], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1608702513' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[cu/lrecKQUbH6kRMP78B/7wG4a4=], backend_flag=[0]
11-13 20:24:01.661+0200 E/PKGMGR  ( 1856): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
11-13 20:24:01.666+0200 E/PKGMGR  ( 1854): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[18540002]
11-13 20:24:01.671+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
11-13 20:24:01.676+0200 E/PKGMGR_SERVER( 1857): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
11-13 20:24:01.681+0200 E/PKGMGR_SERVER( 1858): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
11-13 20:24:01.781+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: main(601) > OBSERVER start
11-13 20:24:01.786+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(120) > ------------------------------------------------
11-13 20:24:01.786+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
11-13 20:24:01.786+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(122) > ------------------------------------------------
11-13 20:24:01.921+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
11-13 20:24:01.931+0200 E/rpm-installer( 1857): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
11-13 20:24:01.931+0200 E/rpm-installer( 1857): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
11-13 20:24:01.936+0200 E/rpm-installer( 1857): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
11-13 20:24:01.936+0200 E/rpm-installer( 1857): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
11-13 20:24:01.936+0200 E/rpm-installer( 1857): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
11-13 20:24:02.046+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[18580002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
11-13 20:24:02.056+0200 E/APPS    (  770): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
11-13 20:24:02.056+0200 E/APPS    (  770): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
11-13 20:24:02.071+0200 W/AUL_AMD (  533): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
11-13 20:24:02.076+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[18580002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
11-13 20:24:02.101+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
11-13 20:24:02.126+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-13 20:24:02.281+0200 W/CERT_SVC( 1857): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
11-13 20:24:02.321+0200 E/rpm-installer( 1857): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
11-13 20:24:02.326+0200 E/rpm-installer( 1857): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
11-13 20:24:02.326+0200 E/rpm-installer( 1857): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
11-13 20:24:02.326+0200 E/rpm-installer( 1857): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
11-13 20:24:02.421+0200 E/PKGMGR_PARSER( 1857): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
11-13 20:24:02.431+0200 E/PKGMGR_PARSER( 1857): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
11-13 20:24:02.456+0200 E/PKGMGR_PARSER( 1857): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
11-13 20:24:02.571+0200 I/PRIVACY-MANAGER-CLIENT( 1857): SocketClient.cpp: SocketClient(37) > Client created
11-13 20:24:02.716+0200 I/efl-extension( 1857): efl_extension.c: eext_mod_init(40) > Init
11-13 20:24:02.721+0200 I/efl-extension( 1857): efl_extension.c: eext_mod_shutdown(46) > Shutdown
11-13 20:24:02.821+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
11-13 20:24:02.826+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
11-13 20:24:02.826+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
11-13 20:24:02.826+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
11-13 20:24:02.826+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
11-13 20:24:02.826+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
11-13 20:24:02.826+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
11-13 20:24:02.836+0200 E/PKGMGR_CERT( 1857): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
11-13 20:24:02.846+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[18580002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
11-13 20:24:02.891+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-13 20:24:02.931+0200 E/rpm-installer( 1857): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
11-13 20:24:02.941+0200 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1397 pgid = 1397
11-13 20:24:02.951+0200 E/rpm-installer( 1857): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
11-13 20:24:02.986+0200 E/rpm-installer( 1857): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
11-13 20:24:03.016+0200 I/AUL_AMD (  533): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1397
11-13 20:24:03.031+0200 E/RESOURCED(  535): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.157
11-13 20:24:03.046+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[18580002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
11-13 20:24:03.056+0200 E/rpm-installer( 1857): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
11-13 20:24:03.096+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-13 20:24:03.141+0200 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-13 20:24:03.141+0200 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1193 pgid = -1
11-13 20:24:03.141+0200 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-13 20:24:03.151+0200 I/AUL_AMD (  533): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1193
11-13 20:24:03.161+0200 E/RESOURCED(  535): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.158
11-13 20:24:03.571+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
11-13 20:24:03.706+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-13 20:24:03.706+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-13 20:24:03.786+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-13 20:24:03.786+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-13 20:24:03.841+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-13 20:24:03.841+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-13 20:24:03.841+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-13 20:24:03.841+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-13 20:24:03.841+0200 E/EFL     ( 1867): elementary<1867> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-13 20:24:03.881+0200 E/EFL     ( 1867): elementary<1867> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-13 20:24:03.881+0200 E/EFL     ( 1867): elementary<1867> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-13 20:24:03.881+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-13 20:24:03.951+0200 E/EFL     ( 1867): elementary<1867> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-13 20:24:03.961+0200 E/EFL     ( 1867): elementary<1867> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-13 20:24:03.961+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-13 20:24:03.961+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-13 20:24:03.961+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-13 20:24:03.961+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-13 20:24:03.961+0200 E/EFL     ( 1867): elementary<1867> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-13 20:24:03.961+0200 I/AUL_PAD ( 1867): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-13 20:24:04.181+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[18580002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
11-13 20:24:04.201+0200 W/W_HOME  (  770): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
11-13 20:24:04.201+0200 W/W_HOME  (  770): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
11-13 20:24:04.241+0200 W/AUL_AMD (  533): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
11-13 20:24:04.296+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
11-13 20:24:04.296+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
11-13 20:24:04.296+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
11-13 20:24:04.296+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
11-13 20:24:04.296+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
11-13 20:24:04.301+0200 E/WMS     (  490): wms_db.c: wms_db_package_event_insert_record(177) > 
11-13 20:24:04.356+0200 E/WMS     (  490): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
11-13 20:24:04.416+0200 E/STARTER (  709): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
11-13 20:24:04.421+0200 E/PKGMGR_INFO( 1858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
11-13 20:24:04.461+0200 E/PKGMGR_OBSERVER( 1858): pkg_observer.c: main(620) > OBSERVER end
11-13 20:24:04.496+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
11-13 20:24:04.496+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1858]
11-13 20:24:04.501+0200 E/PKGMGR_INFO(  489): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
11-13 20:24:04.511+0200 W/APPS    (  770): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-13 20:24:04.511+0200 W/APPS    (  770): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
11-13 20:24:04.551+0200 E/EFL     (  770): evas_main<770> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x465ac968 is not stable during recalc loop
11-13 20:24:04.551+0200 E/EFL     (  770): evas_main<770> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x465ac968 is not stable during recalc loop
11-13 20:24:04.586+0200 I/efl-extension( 1868): efl_extension.c: eext_mod_init(40) > Init
11-13 20:24:04.651+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-13 20:24:04.651+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-13 20:24:04.696+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-13 20:24:04.706+0200 I/UXT     ( 1868): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
11-13 20:24:04.706+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-13 20:24:04.776+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-13 20:24:04.776+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-13 20:24:04.776+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-13 20:24:04.776+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-13 20:24:04.776+0200 E/EFL     ( 1868): elementary<1868> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-13 20:24:04.796+0200 E/EFL     ( 1868): elementary<1868> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-13 20:24:04.796+0200 E/EFL     ( 1868): elementary<1868> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-13 20:24:04.796+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-13 20:24:04.856+0200 E/EFL     ( 1868): elementary<1868> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-13 20:24:04.871+0200 E/EFL     ( 1868): elementary<1868> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-13 20:24:04.871+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-13 20:24:04.871+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-13 20:24:04.871+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-13 20:24:04.871+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-13 20:24:04.871+0200 E/EFL     ( 1868): elementary<1868> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-13 20:24:04.871+0200 I/AUL_PAD ( 1868): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-13 20:24:05.556+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(273) > ------------------------------------------------
11-13 20:24:05.556+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
11-13 20:24:05.556+0200 E/rpm-installer( 1857): rpm-appcore-intf.c: main(275) > ------------------------------------------------
11-13 20:24:05.571+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1857]
11-13 20:24:05.571+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-13 20:24:05.571+0200 E/PKGMGR_SERVER( 1856): pkgmgr-server.c: main(2221) > package manager server terminated.
11-13 20:24:05.636+0200 E/RESOURCED(  535): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/1857/oom_score_adj failed
11-13 20:24:05.636+0200 E/RESOURCED(  535): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 1857
11-13 20:24:07.841+0200 W/AUL     ( 1933): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-13 20:24:07.841+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
11-13 20:24:07.861+0200 I/AUL_AMD (  533): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-13 20:24:07.871+0200 I/AUL_AMD (  533): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-13 20:24:07.871+0200 E/AUL_AMD (  533): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-13 20:24:07.871+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 1933
11-13 20:24:07.886+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(2124) > pad pid(-5)
11-13 20:24:07.891+0200 W/AUL_PAD ( 1186): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-13 20:24:07.891+0200 W/AUL_PAD ( 1186): launchpad.c: __send_result_to_caller(272) > Check app launching
11-13 20:24:07.891+0200 E/RESOURCED(  535): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-13 20:24:07.891+0200 E/RESOURCED(  535): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-13 20:24:07.946+0200 I/efl-extension( 1867): efl_extension.c: eext_mod_init(40) > Init
11-13 20:24:07.946+0200 I/CAPI_APPFW_APPLICATION( 1867): app_main.c: ui_app_main(704) > app_efl_main
11-13 20:24:07.951+0200 I/CAPI_APPFW_APPLICATION( 1867): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-13 20:24:07.996+0200 W/AUL     ( 1933): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1867)
11-13 20:24:08.011+0200 E/RESOURCED(  535): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
11-13 20:24:08.061+0200 I/Bluetooth( 1867): [bt_initialize] success.
11-13 20:24:08.096+0200 I/Bluetooth( 1867): [bt_adapter_get_state] success.
11-13 20:24:08.216+0200 E/EFL     ( 1867): ecore_evas<1867> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-13 20:24:08.586+0200 I/APP_CORE( 1867): appcore-efl.c: __do_app(429) > [APP 1867] Event: RESET State: CREATED
11-13 20:24:08.586+0200 I/CAPI_APPFW_APPLICATION( 1867): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-13 20:24:08.621+0200 I/APP_CORE( 1867): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-13 20:24:08.621+0200 I/APP_CORE( 1867): appcore-efl.c: __do_app(474) > [APP 1867] Initial Launching, call the resume_cb
11-13 20:24:08.621+0200 I/CAPI_APPFW_APPLICATION( 1867): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-13 20:24:08.626+0200 W/APP_CORE( 1867): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1600002
11-13 20:24:08.726+0200 I/APP_CORE( 1867): appcore-efl.c: __do_app(429) > [APP 1867] Event: PAUSE State: RUNNING
11-13 20:24:08.726+0200 I/CAPI_APPFW_APPLICATION( 1867): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
11-13 20:24:08.726+0200 I/APP_CORE( 1867): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
11-13 20:24:08.731+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 22
11-13 20:24:08.731+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(916) > app status : 4
11-13 20:24:08.801+0200 E/APP_CORE( 1867): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-13 20:24:08.801+0200 I/APP_CORE( 1867): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-13 20:24:08.801+0200 I/CAPI_APPFW_APPLICATION( 1867): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-13 20:24:08.801+0200 I/Bluetooth( 1867): [bt_deinitialize] success.
11-13 20:24:08.996+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-13 20:24:08.996+0200 W/AUL_AMD (  533): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-13 20:24:09.126+0200 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1867 pgid = 1867
11-13 20:24:09.141+0200 E/RESOURCED(  535): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.164
11-13 20:24:09.146+0200 I/AUL     (  860): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
11-13 20:24:09.146+0200 E/RESOURCED(  860): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
11-13 20:24:09.146+0200 E/AUL     (  860): pkginfo.c: __get_id_bypid(234) > Failed to get the cmdline of pgid, error: -1
11-13 20:24:09.146+0200 E/CAPI_APPFW_APP_MANAGER(  860): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
11-13 20:24:09.281+0200 E/RESOURCED( 1118): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
11-13 20:24:09.281+0200 E/AUL     ( 1118): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
11-13 20:24:09.281+0200 E/CAPI_APPFW_APP_MANAGER( 1118): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
11-13 20:24:09.341+0200 W/AUL_PAD ( 1186): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-13 20:24:09.351+0200 I/AUL_AMD (  533): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1867
11-13 20:24:09.361+0200 E/RESOURCED(  535): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.165
11-13 20:24:09.431+0200 W/CRASH_MANAGER( 1946): worker.c: worker_job(1205) > 1101867646174151059744
