S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2674
Date: 2017-12-09 11:20:16+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2674, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x43d00010, r3   = 0x40001d59
r4   = 0xbea9d48c, r5   = 0x40050980
r6   = 0x00000249, r7   = 0xbea9d3c8
r8   = 0xbea9d45c, r9   = 0x404c1c84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40014588, sp   = 0xbea9d3b0
lr   = 0x40001d75, pc   = 0x400032a8
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     85392 KB
Buffers:     27480 KB
Cached:     154108 KB
VmPeak:     119012 KB
VmSize:     115732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19428 KB
VmRSS:       19428 KB
VmData:      58012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26756 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 6
PID = 2674 TID = 2674
2674 2677 2679 2680 2687 2688 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40015000 40032000 r-xp /lib/ld-2.13.so
4003c000 4003f000 rw-p [stack:2680]
4003f000 40044000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4004e000 40052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005a000 4008c000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
40095000 4009a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400a2000 400a6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400af000 400b1000 r-xp /usr/lib/libdlog.so.0.0.0
400b9000 400da000 r-xp /usr/lib/libefl-extension.so.0.1.0
400e3000 4021d000 r-xp /usr/lib/libelementary.so.1.7.99
40234000 40302000 r-xp /usr/lib/libevas.so.1.7.99
40328000 40443000 r-xp /lib/libc-2.13.so
40451000 40459000 r-xp /lib/libgcc_s-4.6.so.1
4045a000 40465000 r-xp /lib/libunwind.so.8.0.1
40492000 40494000 r-xp /lib/libdl-2.13.so
4049d000 404a1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404aa000 404ac000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404b5000 404ba000 r-xp /usr/lib/libappcore-efl.so.1.1
404c2000 404c7000 r-xp /usr/lib/libappcore-common.so.1.1
404cf000 404db000 r-xp /usr/lib/libaul.so.0.1.0
404e5000 40507000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4050f000 40550000 r-xp /usr/lib/libeina.so.1.7.99
40559000 4056d000 r-xp /lib/libpthread-2.13.so
40578000 405b2000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
405bb000 405d4000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
405dc000 405e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e9000 406b9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
406ba000 406c0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c9000 406d2000 r-xp /usr/lib/libvconf.so.0.2.45
406da000 407ad000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
407b8000 407ec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
407f5000 4081f000 r-xp /usr/lib/libsensor.so.1.9.6
40828000 408bc000 r-xp /usr/lib/libstdc++.so.6.0.16
408cf000 40938000 r-xp /lib/libm-2.13.so
40941000 40991000 r-xp /usr/lib/libecore_x.so.1.7.99
40993000 409aa000 r-xp /usr/lib/libecore.so.1.7.99
409c1000 40a1f000 r-xp /usr/lib/libedje.so.1.7.99
40a28000 40ae0000 r-xp /usr/lib/libcairo.so.2.11200.14
40aeb000 40bcc000 r-xp /usr/lib/libX11.so.6.3.0
40bd7000 40be0000 r-xp /usr/lib/libXi.so.6.1.0
40be8000 40c10000 r-xp /usr/lib/libfontconfig.so.1.8.0
40c11000 40c2a000 r-xp /usr/lib/libeet.so.1.7.99
40c3b000 40c5d000 r-xp /usr/lib/libecore_evas.so.1.7.99
40c66000 40c6b000 r-xp /usr/lib/libecore_file.so.1.7.99
40c73000 40c84000 r-xp /usr/lib/libecore_input.so.1.7.99
40c8c000 40c95000 r-xp /usr/lib/libedbus.so.1.7.99
40c9d000 40cc7000 r-xp /usr/lib/libdbus-1.so.3.8.12
40cd0000 40cea000 r-xp /usr/lib/libecore_con.so.1.7.99
40cf3000 40d06000 r-xp /usr/lib/libfribidi.so.0.3.1
40d0f000 40d4c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d55000 40dab000 r-xp /usr/lib/libfreetype.so.6.11.3
40db7000 40e0d000 r-xp /usr/lib/libpixman-1.so.0.28.2
40e1a000 40e20000 r-xp /usr/lib/libappsvc.so.0.1.0
40e28000 40e2b000 r-xp /usr/lib/libbundle.so.0.1.22
40e34000 40e3a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40e42000 40e44000 r-xp /usr/lib/libiniparser.so.0
40e4d000 40e64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e6c000 40e71000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e79000 40eb5000 r-xp /usr/lib/libsystemd.so.0.4.0
40ebf000 40ec3000 r-xp /usr/lib/libproc-stat.so.0.2.86
40ecc000 40ee2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40eeb000 40f60000 r-xp /usr/lib/libsqlite3.so.0.8.6
40f6a000 40f70000 r-xp /lib/librt-2.13.so
40f79000 40fa7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40fb1000 40fb4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
40fbc000 40fbe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
40fc7000 40fcd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
40fd6000 40fde000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410c0000 410c1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
410c9000 410ce000 r-xp /usr/lib/libffi.so.5.0.10
410d6000 410d8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
410e0000 410f6000 r-xp /lib/libz.so.1.2.5
410fe000 4110e000 r-xp /lib/libresolv-2.13.so
41113000 4111d000 r-xp /usr/lib/libsensord-shared.so
41126000 4112d000 r-xp /usr/lib/libXcursor.so.1.0.2
41135000 41137000 r-xp /usr/lib/libXdamage.so.1.1.0
4113f000 41141000 r-xp /usr/lib/libXcomposite.so.1.0.0
41149000 4114b000 r-xp /usr/lib/libXgesture.so.7.0.0
41154000 41157000 r-xp /usr/lib/libXfixes.so.3.1.0
4115f000 41160000 r-xp /usr/lib/libXinerama.so.1.0.0
41169000 4116f000 r-xp /usr/lib/libXrandr.so.2.2.0
41177000 4117d000 r-xp /usr/lib/libXrender.so.1.3.0
41185000 41189000 r-xp /usr/lib/libXtst.so.6.1.0
41191000 4119b000 r-xp /usr/lib/libXext.so.6.4.0
411a5000 411ac000 r-xp /usr/lib/libembryo.so.1.7.99
411b4000 411cb000 r-xp /usr/lib/liblua-5.1.so
411d4000 411d5000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
411dd000 411eb000 r-xp /usr/lib/libGLESv2.so.2.0
411f4000 4120c000 r-xp /usr/lib/libpng12.so.0.50.0
41215000 41216000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4121f000 41225000 r-xp /usr/lib/libxcb-render.so.0.0.0
4122d000 41240000 r-xp /usr/lib/libxcb.so.1.1.0
41249000 4124c000 r-xp /usr/lib/libEGL.so.1.4
41254000 4126a000 r-xp /lib/libexpat.so.1.5.2
41275000 41298000 r-xp /usr/lib/libjpeg.so.8.0.2
412b0000 412b5000 r-xp /usr/lib/libecore_fb.so.1.7.99
412be000 412c2000 r-xp /usr/lib/libecore_ipc.so.1.7.99
412cb000 412ce000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
412d6000 4131a000 r-xp /usr/lib/libcurl.so.4.3.0
41324000 4133c000 r-xp /usr/lib/liblzma.so.5.0.3
41344000 413c0000 r-xp /usr/lib/libgcrypt.so.20.0.3
413cc000 413ce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
413d6000 413da000 r-xp /usr/lib/libsmack.so.1.0.0
413e4000 41401000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4140a000 41417000 r-xp /usr/lib/libail.so.0.1.0
41420000 4155d000 r-xp /usr/lib/libicui18n.so.51.1
4156d000 41651000 r-xp /usr/lib/libicuuc.so.51.1
42bf0000 42c0c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42c15000 42c17000 r-xp /usr/lib/libXau.so.6.0.0
42c1f000 42c28000 r-xp /usr/lib/libcares.so.2.1.0
42c32000 42c60000 r-xp /usr/lib/libidn.so.11.5.44
42c68000 42caf000 r-xp /usr/lib/libssl.so.1.0.0
42cbb000 42e64000 r-xp /usr/lib/libcrypto.so.1.0.0
42e85000 42e90000 r-xp /usr/lib/libgpg-error.so.0.15.0
42e98000 42e9a000 r-xp /usr/lib/libiri.so
42ea3000 42ea6000 r-xp /lib/libcap.so.2.21
42eae000 42eb5000 r-xp /lib/libcrypt-2.13.so
42ee5000 42eec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42ef5000 42ef7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42eff000 42f06000 r-xp /usr/lib/libminizip.so.1.0.0
42f0f000 42f12000 r-xp /lib/libattr.so.1.1.0
43020000 430ea000 r-xp /usr/lib/libCOREGL.so.4.0
430fc000 43120000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
43129000 431f8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4320e000 43218000 r-xp /lib/libnss_files-2.13.so
43422000 43c21000 rw-p [stack:2677]
43c21000 43c98000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43ca8000 43cb3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43cbc000 43cbe000 r-xp /usr/lib/libdri2.so.0.0.0
43cc6000 43cce000 r-xp /usr/lib/libdrm.so.2.4.0
43cd6000 43cdd000 r-xp /usr/lib/libtbm.so.1.0.0
43ce5000 43ce8000 r-xp /usr/lib/libnative-buffer.so.0.1.0
43e00000 43f48000 r-xp /usr/lib/egl/libMali.so
43f4e000 4474d000 rw-p [stack:2679]
44a84000 44a85000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44a8e000 4528d000 rw-p [stack:2687]
4528e000 45a8d000 rw-p [stack:2688]
46d24000 46d27000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
46d2f000 46d30000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
46d58000 46d59000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46d74000 46d7b000 r-xp /usr/lib/libfeedback.so.0.1.4
46d84000 46d85000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46d8d000 46d8f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
46d97000 46da1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
46da9000 46db0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
46db8000 46dce000 r-xp /usr/lib/libmmfsound.so.0.1.0
46de0000 46de5000 r-xp /usr/lib/libmmfsession.so.0.0.0
46ded000 46df7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46e03000 46e07000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
46e10000 46e25000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46e2d000 46e8e000 r-xp /usr/lib/libasound.so.2.0.0
46e98000 46e9b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46ea3000 46edb000 r-xp /usr/lib/libpulse.so.0.16.2
46edc000 46f0d000 r-xp /usr/lib/libmdm.so.1.1.86
46f15000 46f1a000 r-xp /usr/lib/libjson.so.0.0.1
46f22000 46f6a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46f6b000 46fb2000 r-xp /usr/lib/libsndfile.so.1.0.26
46fbe000 46fc6000 r-xp /usr/lib/libmdm-common.so.1.0.89
46fc7000 46fe9000 r-xp /usr/lib/libvorbis.so.0.4.3
46ff1000 46ff5000 r-xp /usr/lib/libogg.so.0.7.1
bea7d000 bea9e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2674)
Call Stack Count: 8
 0: stop_bt_server + 0x27 (0x400032a8) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x32a8
 1: app_terminate + 0x1c (0x40001d75) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d75
 2: (0x4004faf9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x404b8599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x40050421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x40001d07) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d07
 6: __libc_start_main + 0x114 (0x4033f82c) [/lib/libc.so.6] + 0x1782c
 7: (0x40001738) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1738
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
0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:19:05.970+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:19:06.030+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 282777001, next duetime: 1512811166
12-09 11:19:06.030+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(282777001)
12-09 11:19:06.030+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512811166)
12-09 11:19:06.030+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:19:06.030+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:19:26 (UTC).
12-09 11:19:06.030+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:19:06.045+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:19:06.425+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 59
12-09 11:19:06.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 59
12-09 11:19:07.410+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 58
12-09 11:19:07.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 58
12-09 11:19:08.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 57
12-09 11:19:08.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 57
12-09 11:19:08.655+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:19:08.655+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:19:08.660+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:19:08.665+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:19:08.665+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:19:08.665+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:19:08.665+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:19:08.670+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:3021
12-09 11:19:08.670+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:19:08.670+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:19:08.670+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:19:08.675+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [3021]ms
12-09 11:19:08.675+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:19:08.705+0200 I/APP_CORE( 2674): appcore-efl.c: __do_app(429) > [APP 2674] Event: RESUME State: PAUSED
12-09 11:19:08.705+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:19:08.715+0200 W/W_HOME  (  779): gesture.c: _widget_updated_cb(194) > widget updated
12-09 11:19:08.715+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:19:08.715+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:19:08.750+0200 I/MALI    (  779): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
12-09 11:19:08.755+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:19:08.765+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:19:08.765+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(282777001)
12-09 11:19:08.765+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:19:08.765+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:19:08.765+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:19:08.765+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[282777001] is removed.
12-09 11:19:08.780+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:08.795+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:19:08.845+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:19:08.850+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:19:08.850+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:19:08.875+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-09 11:19:08.875+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:19:09.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 57
12-09 11:19:09.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 57
12-09 11:19:10.415+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 57
12-09 11:19:10.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 57
12-09 11:19:11.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 58
12-09 11:19:11.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 58
12-09 11:19:12.425+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:12.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:13.410+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:19:13.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:19:14.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 64
12-09 11:19:14.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:19:15.415+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 65
12-09 11:19:15.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:19:16.430+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:16.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:17.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 61
12-09 11:19:17.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 61
12-09 11:19:17.650+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
12-09 11:19:17.650+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
12-09 11:19:18.430+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:18.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:19.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 57
12-09 11:19:19.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 57
12-09 11:19:20.415+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 56
12-09 11:19:20.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 56
12-09 11:19:21.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 57
12-09 11:19:21.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 57
12-09 11:19:22.425+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 59
12-09 11:19:22.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 59
12-09 11:19:23.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 61
12-09 11:19:23.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 61
12-09 11:19:24.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 61
12-09 11:19:24.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 61
12-09 11:19:25.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:25.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:26.425+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:26.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:27.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:27.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:28.430+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:28.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:29.425+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:29.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:30.000+0200 W/SHealth_Common( 1081): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1512777600000,000000[0;m
12-09 11:19:30.070+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (376089)]][0;m
12-09 11:19:30.180+0200 W/SHealthWidget(  839): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (376089), msgName: timeline_summary_updated[0;m
12-09 11:19:30.180+0200 W/SHealth_Common(  839): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
12-09 11:19:30.185+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
12-09 11:19:30.220+0200 I/HealthDataService(  783): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-09 11:19:30.225+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 11:19:30.225+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 11:19:30.225+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 11:19:30.225+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 11:19:30.265+0200 I/healthData( 1081): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-09 11:19:30.285+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_update_cb(281) > received updating signal
12-09 11:19:30.290+0200 E/EFL     (  839): edje<839> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-09 11:19:30.420+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 61
12-09 11:19:30.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 61
12-09 11:19:31.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:31.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:32.430+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 59
12-09 11:19:32.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 59
12-09 11:19:33.425+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:33.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:34.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:34.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:35.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:19:35.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:19:36.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:19:36.495+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:19:37.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:37.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:38.200+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:19:38.200+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:19:38.205+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:19:38.205+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:19:38.205+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:19:38.205+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:19:38.205+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:19:38.205+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
12-09 11:19:38.205+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:19:38.210+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:19:38.210+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:19:38.210+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:19:38.385+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:19:38.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 64
12-09 11:19:38.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:19:38.495+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
12-09 11:19:38.495+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:19:38.495+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:19:38.495+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:19:38.495+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:19:59), repeat(1), interval(20), type(-1073741822)
12-09 11:19:38.515+0200 I/APP_CORE( 2674): appcore-efl.c: __do_app(429) > [APP 2674] Event: PAUSE State: RUNNING
12-09 11:19:38.520+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:19:38.520+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:19:38.590+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 215969879, next duetime: 1512811199
12-09 11:19:38.590+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(215969879)
12-09 11:19:38.590+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512811199)
12-09 11:19:38.590+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:19:38.590+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:19:59 (UTC).
12-09 11:19:38.590+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:19:38.605+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:19:38.610+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:19:39.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 65
12-09 11:19:39.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:19:40.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 67
12-09 11:19:40.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:19:40.810+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:19:40.810+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:19:40.810+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:19:40.810+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:19:40.810+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:19:40.810+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:19:40.815+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:19:40.815+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:2626
12-09 11:19:40.815+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:19:40.815+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:19:40.815+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:19:40.815+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [2626]ms
12-09 11:19:40.815+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:19:40.840+0200 I/APP_CORE( 2674): appcore-efl.c: __do_app(429) > [APP 2674] Event: RESUME State: PAUSED
12-09 11:19:40.840+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:19:40.865+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:19:40.865+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(215969879)
12-09 11:19:40.870+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:19:40.870+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:19:40.870+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:19:40.870+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[215969879] is removed.
12-09 11:19:40.910+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:19:40.910+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:40.910+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:19:40.925+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:19:40.925+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:40.925+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:19:40.930+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:19:40.930+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:40.930+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:19:40.930+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:19:40.930+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:19:40.930+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:19:40.980+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:19:41.005+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-09 11:19:41.005+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:19:41.015+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-09 11:19:41.015+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:19:41.015+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:19:41.015+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:19:41.015+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:19:41.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 69
12-09 11:19:41.495+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:19:42.430+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 71
12-09 11:19:42.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:19:43.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 72
12-09 11:19:43.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 72
12-09 11:19:44.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 73
12-09 11:19:44.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 73
12-09 11:19:45.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 74
12-09 11:19:45.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 74
12-09 11:19:46.435+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 72
12-09 11:19:46.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 72
12-09 11:19:47.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 71
12-09 11:19:47.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:19:48.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 69
12-09 11:19:48.505+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:19:49.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 67
12-09 11:19:49.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:19:50.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 65
12-09 11:19:50.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:19:51.440+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:51.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:52.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:52.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:53.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 64
12-09 11:19:53.495+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:19:54.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:54.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:55.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:55.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:56.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:19:56.505+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:19:57.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:19:57.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:19:58.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:19:58.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:19:59.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:19:59.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:20:00.090+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:20:00.090+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:00.100+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:20:00.100+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:20:00.105+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:00.105+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:20:00.110+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:20:00.110+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:00.110+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:20:00.445+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:20:00.460+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:20:01.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:20:01.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:20:02.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:20:02.510+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:20:03.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:20:03.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:20:04.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 64
12-09 11:20:04.490+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:20:05.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:20:05.500+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:20:06.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:20:06.475+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:20:07.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 64
12-09 11:20:07.495+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:20:08.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 64
12-09 11:20:08.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:20:09.465+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 63
12-09 11:20:09.505+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:20:10.320+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
12-09 11:20:10.320+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:20:10.325+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:20:10.330+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:20:10.330+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:20:10.345+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:20:10.345+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:20:10.345+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:20:10.345+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:20:10.345+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:20:10.350+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:10.350+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:20:10.620+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:20:10.670+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:20:10.710+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
12-09 11:20:10.710+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:20:10.715+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:20:10.715+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:20:10.715+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:20:31), repeat(1), interval(20), type(-1073741822)
12-09 11:20:10.720+0200 I/APP_CORE( 2674): appcore-efl.c: __do_app(429) > [APP 2674] Event: PAUSE State: RUNNING
12-09 11:20:10.720+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:20:10.720+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:20:10.725+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:20:10.795+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 137326745, next duetime: 1512811231
12-09 11:20:10.800+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(137326745)
12-09 11:20:10.800+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512811231)
12-09 11:20:10.800+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:20:10.800+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:20:31 (UTC).
12-09 11:20:10.800+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:20:10.820+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:20:10.820+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:20:11.450+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:20:11.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:20:12.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 62
12-09 11:20:12.495+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:20:13.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:20:13.485+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:20:14.455+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:20:14.480+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:20:14.825+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:20:14.825+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:20:14.825+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:20:14.835+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:20:14.840+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:20:14.840+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:20:14.840+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:20:14.840+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:4456
12-09 11:20:14.840+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:20:14.840+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:20:14.840+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:14.840+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [4456]ms
12-09 11:20:14.840+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:20:14.845+0200 I/APP_CORE( 2674): appcore-efl.c: __do_app(429) > [APP 2674] Event: RESUME State: PAUSED
12-09 11:20:14.845+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:20:14.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:20:14.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(137326745)
12-09 11:20:14.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:20:14.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:20:14.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:20:14.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[137326745] is removed.
12-09 11:20:14.910+0200 W/W_HOME  (  779): gesture.c: _widget_updated_cb(194) > widget updated
12-09 11:20:14.910+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:20:14.910+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:20:14.920+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:20:14.935+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:20:14.935+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:20:14.940+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:14.940+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:20:14.950+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:20:14.965+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:20:14.965+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:20:14.990+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-09 11:20:14.990+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:20:15.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:20:15.470+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 HEART RATE : 60
12-09 11:20:15.520+0200 I/INFO_TAG( 2674): SENSOR_EVENT2 TAB VALUE : 60
12-09 11:20:15.925+0200 E/EFL     ( 2674): ecore_x<2674> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=663293 button=1
12-09 11:20:15.975+0200 E/EFL     ( 2674): ecore_x<2674> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=663341 button=1
12-09 11:20:15.975+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 22
12-09 11:20:15.975+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(916) > app status : 4
12-09 11:20:16.040+0200 E/APP_CORE( 2674): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-09 11:20:16.040+0200 I/APP_CORE( 2674): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-09 11:20:16.040+0200 I/APP_CORE( 2674): appcore-efl.c: __after_loop(1089) > [APP 2674] PAUSE before termination
12-09 11:20:16.040+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:20:16.040+0200 I/CAPI_APPFW_APPLICATION( 2674): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-09 11:20:16.660+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-09 11:20:16.760+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:20:16.760+0200 W/AUL_AMD (  530): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-09 11:20:16.800+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
12-09 11:20:16.800+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.815+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.815+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.830+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
12-09 11:20:16.830+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
12-09 11:20:16.830+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.830+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
12-09 11:20:16.830+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: RESUME State: PAUSED
12-09 11:20:16.830+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 11:20:16.830+0200 W/W_HOME  (  779): main.c: _appcore_resume_cb(687) > appcore resume
12-09 11:20:16.830+0200 W/W_HOME  (  779): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
12-09 11:20:16.830+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.835+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.835+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:20:16.845+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
12-09 11:20:16.860+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
12-09 11:20:16.860+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
12-09 11:20:16.860+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:20:16.875+0200 W/AUL     ( 2778): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
12-09 11:20:16.915+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 23
12-09 11:20:16.915+0200 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-09 11:20:16.915+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 2674
12-09 11:20:16.915+0200 W/AUL_AMD (  530): amd_request.c: __send_app_termination_signal(510) > send dead signal done
12-09 11:20:16.970+0200 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2674
12-09 11:20:16.975+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-09 11:20:17.015+0200 W/CRASH_MANAGER( 2784): worker.c: worker_job(1205) > 1102674646174151281121
