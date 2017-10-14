S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 11335
Date: 2017-10-14 14:11:33+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x42ffac88, r3   = 0x40064114
r4   = 0xbeb2830c, r5   = 0x40057d30
r6   = 0x00000233, r7   = 0xbeb281a0
r8   = 0xbeb282dc, r9   = 0x40480c84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40059995, sp   = 0xbeb28180
lr   = 0x40001ec5, pc   = 0x40001eca
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     62536 KB
Buffers:     41104 KB
Cached:     161936 KB
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
beb08000 beb29000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11335)
Call Stack Count: 9
 0: create_HRM_listener + 0x4d (0x40001eca) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1eca
 1: create_base_gui + 0x10 (0x40001771) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1771
 2: app_create + 0x32 (0x400016a3) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x16a3
 3: (0x4004d9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40477457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x4004e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x4000160b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x160b
 7: __libc_start_main + 0x114 (0x402fe82c) [/lib/libc.so.6] + 0x1782c
 8: (0x40001374) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1374
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
05+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:11:29.710+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f370] swap changed from sync to async
10-14 14:11:29.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 14:11:29.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(318173205)
10-14 14:11:29.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:11:29.735+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:13:00 (UTC).
10-14 14:11:29.735+0200 W/W_HOME  ( 1063): gesture.c: _manual_render(180) > 
10-14 14:11:29.740+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:11:29.740+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:11:29.740+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[318173205] is removed.
10-14 14:11:29.740+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 0
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): gesture.c: _apps_status_get(126) > apps status:0
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:19842
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-14 14:11:29.745+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:29.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 14:11:29.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 14:11:29.750+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 14:11:29.785+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 14:11:29.805+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 14:11:29.815+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 14:11:29.835+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 14:11:29.945+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
10-14 14:11:29.945+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 0
10-14 14:11:29.945+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 14:11:29.970+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 14:11:30.010+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: __clock_viewer_lcdon_completed_cb(471) >  event lcdon completed[1]
10-14 14:11:30.010+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: __clock_viewer_lcdon_completed_cb(475) >  Exit from charger alpm mode
10-14 14:11:30.010+0200 W/W_CLOCK_VIEWER(10940): clock-viewer.c: _clock_viewer_send_clock_changed(919) >  clock changed <<
10-14 14:11:30.020+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
10-14 14:11:30.020+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[1]
10-14 14:11:30.025+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 14:11:30.030+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 14:11:30.030+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [10940].
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(318173206)
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 20:47:32 (UTC).
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[318173206] is removed.
10-14 14:11:30.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:11:30.095+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 14:11:30.095+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:11:30.120+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 14:11:30.120+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 14:11:30.120+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 14:11:30.120+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 14:11:30.125+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:11:30.125+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:11:30.145+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(305) > [windicator_battery_icon_update:305] 100%
10-14 14:11:30.145+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 14:11:30.145+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(315) > [windicator_battery_icon_update:315] battery_level: 100, isCharging: 0
10-14 14:11:30.145+0200 W/STARTER (  705): clock-mgr.c: _charger_status_setting_changed_cb(890) > [_charger_status_setting_changed_cb:890] charger status is changed to [0] ambient[0]
10-14 14:11:30.145+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(4) to(10940)
10-14 14:11:30.145+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(342) > [windicator_battery_icon_update:342] [SIGNAL] battery file : change_level_100
10-14 14:11:30.145+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 4
10-14 14:11:30.160+0200 W/W_CLOCK_VIEWER(10940): clock-viewer-util-status.c: __clock_viewer_util_status_rotation_changed_cb(237) >  Rotation is changed[1]
10-14 14:11:30.160+0200 W/W_CLOCK_VIEWER(10940): clock-viewer-charging.c: __clock_viewer_charging_device_angle_changed_cb(48) >  Hide status. Skip
10-14 14:11:30.165+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_charger_status_changed_cb(437) > 
10-14 14:11:30.165+0200 W/wnotib  ( 1063): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1619) > num_categoreis: 0
10-14 14:11:30.165+0200 I/wnotib  ( 1063): w-notification-board-panel-summary.c: _wnb_summary_draw_static_empty_view(1246) > Use existing static_empty_view.
10-14 14:11:30.165+0200 W/wnotib  ( 1063): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1640) > current_summary_type: 1, new_summary_type: 1
10-14 14:11:30.170+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(10940), cmd(4)
10-14 14:11:30.170+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(4) result(0)
10-14 14:11:30.175+0200 I/APP_CORE(10940): appcore-efl.c: __do_app(429) > [APP 10940] Event: TERMINATE State: RUNNING
10-14 14:11:30.175+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 14:11:30.175+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 14:11:30.175+0200 E/APP_CORE(10940): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
10-14 14:11:30.175+0200 I/APP_CORE(10940): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-14 14:11:30.175+0200 I/CAPI_APPFW_APPLICATION(10940): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
10-14 14:11:30.175+0200 I/SCONTEXT-LIB(10940): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 45
10-14 14:11:30.180+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
10-14 14:11:30.180+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(171) > [wnidicator_moment_view_battery_image_update:171] [HIDE charging icon] Not connected or Battery full (5)
10-14 14:11:30.180+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 14:11:30.180+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 14:11:30.180+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
10-14 14:11:30.180+0200 W/W_HOME  ( 1063): dbox.c: _dbus_rotation_cb(1341) > angle changed:0
10-14 14:11:30.180+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 14:11:30.180+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charging_changed_cb(117) > [_battery_charging_changed_cb:117] Hide Moment View (unconnected)
10-14 14:11:30.180+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(1)
10-14 14:11:30.180+0200 E/EFL     (  714): <714> elm_main.c:1608 elm_object_signal_emit() safety check failed: obj == NULL
10-14 14:11:30.180+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 14:11:30.180+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 14:11:30.185+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(164) > [_battery_charger_status_changed_cb:164] Hide Moment View (unconnected)
10-14 14:11:30.185+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(-1)
10-14 14:11:30.185+0200 E/EFL     (  714): <714> elm_main.c:1608 elm_object_signal_emit() safety check failed: obj == NULL
10-14 14:11:30.185+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 14:11:30.185+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
10-14 14:11:30.215+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:11:30.260+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:1 angle:0 / is_connected : 0
10-14 14:11:30.260+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(676) > [_windicator_rotation_changed_cb:676] [ROTATION] DBus rotation callback error
10-14 14:11:30.390+0200 I/SCONTEXT-LIB(10940): comm.c: disconnect_dbus(105) > Disconnecting Dbus
10-14 14:11:30.440+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _charging_watch_fade_out_end_cb(1618) > [_charging_watch_fade_out_end_cb:1618] 
10-14 14:11:30.450+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 14:11:30.450+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 14:11:30.450+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:11:30.450+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
10-14 14:11:30.495+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-14 14:11:30.495+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:11:30.495+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 14:11:30.500+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-14 14:11:30.500+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-14 14:11:30.500+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:11:30.520+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 14:11:30.520+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.520+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.525+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 14:11:30.540+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESUME State: PAUSED
10-14 14:11:30.540+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): main.c: _appcore_resume_cb(687) > appcore resume
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 14:11:30.540+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.545+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.545+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:11:30.555+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 14:11:30.560+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10940 pgid = 10940
10-14 14:11:30.570+0200 E/DATA_PROVIDER_MASTER(  706): client_life.c: client_deactivated_by_fault(494) > Client[0x43946c78] is faulted(1), pid(10940)
10-14 14:11:30.590+0200 W/APP_CORE(  714): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000a
10-14 14:11:30.590+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
10-14 14:11:30.590+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 14:11:30.605+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f370] swap changed from async to sync
10-14 14:11:30.605+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:11:30.615+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:11:30.655+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/10940/oom_score_adj failed
10-14 14:11:30.655+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 10940
10-14 14:11:30.690+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:11:30.695+0200 E/STARTER (  705): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:10940) is destroyed. ambient mode[0], charging[0], sports mode[0]
10-14 14:11:30.695+0200 W/STARTER (  705): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
10-14 14:11:30.695+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10940
10-14 14:11:30.705+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.749
10-14 14:11:30.715+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 3
10-14 14:11:30.715+0200 E/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
10-14 14:11:31.545+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3373899 button=1
10-14 14:11:31.545+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:11:31.545+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:11:31.545+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 14:11:31.550+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:11:31.555+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.555+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 14:11:31.555+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 14:11:31.555+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:11:31.570+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 14:11:31.575+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:11:31.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 14:11:31.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 14:11:31.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 14:11:31.575+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 14:11:31.575+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 14:11:31.575+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.580+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 14:11:31.580+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 14:11:31.580+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 14:11:31.580+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 14:11:31.580+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 14:11:31.580+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 14:11:31.580+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 14:11:31.580+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:11:31.585+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.585+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 14:11:31.585+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 14:11:31.590+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 14:11:31.590+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 14:11:31.590+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 14:11:31.590+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 14:11:31.600+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:11:31.655+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:11:31.665+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3374017 button=1
10-14 14:11:31.665+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:11:31.670+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:11:31.670+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:11:31.675+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:11:31.675+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:11:31.675+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:11:31.675+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:11:31.685+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:11:31.685+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:11:31.690+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:11:31.690+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 14:11:31.690+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:11:31.735+0200 I/efl-extension(11183): efl_extension.c: eext_mod_init(40) > Init
10-14 14:11:31.740+0200 I/UXT     (11183): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:11:31.740+0200 I/CAPI_APPFW_APPLICATION(11183): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:11:31.740+0200 I/CAPI_APPFW_APPLICATION(11183): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:11:31.790+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:11:31.790+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(11183)
10-14 14:11:31.790+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:11:31.795+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:11:31.855+0200 W/CRASH_MANAGER(10835): worker.c: worker_job(1205) > 11111836461741507983091
10-14 14:11:32.180+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:11:32.335+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3374690 button=1
10-14 14:11:32.420+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3374775 button=1
10-14 14:11:32.825+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 11183 pgid = 11183
10-14 14:11:32.835+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.751
10-14 14:11:32.850+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3375206 button=1
10-14 14:11:32.850+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 14:11:32.850+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 14:11:32.850+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 14:11:32.850+0200 E/RESOURCED( 1005): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 14:11:32.850+0200 E/AUL     ( 1005): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 14:11:32.850+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:11:32.855+0200 E/RESOURCED( 1156): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 14:11:32.855+0200 E/AUL     ( 1156): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 14:11:32.855+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 14:11:32.875+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:11:32.875+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11183
10-14 14:11:32.885+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.752
10-14 14:11:32.960+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3375316 button=1
10-14 14:11:32.960+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 14:11:32.960+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 14:11:32.960+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 14:11:32.960+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:11:32.965+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:11:32.965+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 14:11:32.965+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 14:11:32.975+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:11:32.975+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:11:32.975+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:11:32.975+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-14 14:11:32.975+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:11:32.975+0200 E/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(278) > launching failed
10-14 14:11:32.975+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-14 14:11:32.980+0200 W/AUL_AMD (  532): amd_launch.c: start_process(580) > child process: 11335
10-14 14:11:33.015+0200 E/EFL     (11333): elementary<11333> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:11:33.015+0200 E/EFL     (11333): elementary<11333> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:11:33.055+0200 E/EFL     (11333): elementary<11333> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:11:33.055+0200 E/EFL     (11333): elementary<11333> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:11:33.070+0200 I/efl-extension(11335): efl_extension.c: eext_mod_init(40) > Init
10-14 14:11:33.085+0200 I/CAPI_APPFW_APPLICATION(11335): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:11:33.090+0200 E/EFL     (11333): elementary<11333> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:11:33.090+0200 E/EFL     (11333): elementary<11333> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:11:33.095+0200 E/EFL     (11335): elementary<11335> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:11:33.095+0200 E/EFL     (11333): elementary<11333> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:11:33.095+0200 E/EFL     (11333): elementary<11333> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:11:33.095+0200 E/EFL     (11333): elementary<11333> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:11:33.095+0200 E/EFL     (11335): elementary<11335> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:11:33.115+0200 E/EFL     (11335): elementary<11335> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:11:33.120+0200 I/UXT     (11335): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:11:33.120+0200 E/EFL     (11335): elementary<11335> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:11:33.120+0200 W/AUL_AMD (  532): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 11335
10-14 14:11:33.125+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 14:11:33.125+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(11335)
10-14 14:11:33.125+0200 E/W_HOME  ( 1063): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-14 14:11:33.125+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:11:33.145+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:11:33.150+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11335
10-14 14:11:33.150+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:11:33.165+0200 E/EFL     (11335): elementary<11335> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:11:33.165+0200 E/EFL     (11335): elementary<11335> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:11:33.165+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:11:33.165+0200 E/EFL     (11335): elementary<11335> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:11:33.165+0200 E/EFL     (11335): elementary<11335> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:11:33.165+0200 E/EFL     (11335): elementary<11335> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:11:33.170+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 11335
10-14 14:11:33.170+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 14:11:33.175+0200 E/EFL     (11333): elementary<11333> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:11:33.175+0200 E/EFL     (11333): elementary<11333> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:11:33.175+0200 E/EFL     (11333): elementary<11333> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:11:33.185+0200 E/EFL     (11335): elementary<11335> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:11:33.185+0200 E/EFL     (11335): elementary<11335> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:11:33.190+0200 E/EFL     (11335): elementary<11335> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:11:33.220+0200 E/EFL     (11335): elementary<11335> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:11:33.235+0200 E/EFL     (11335): elementary<11335> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:11:33.235+0200 E/EFL     (11335): elementary<11335> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:11:33.235+0200 E/EFL     (11335): elementary<11335> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:11:33.235+0200 E/EFL     (11335): elementary<11335> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:11:33.235+0200 E/EFL     (11335): elementary<11335> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:11:33.235+0200 E/EFL     (11335): elementary<11335> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:11:33.305+0200 I/CAPI_APPFW_APPLICATION(11335): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:11:33.310+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=3375661 button=1
10-14 14:11:33.310+0200 E/EFL     (11333): elementary<11333> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:11:33.325+0200 E/EFL     (11333): elementary<11333> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:11:33.325+0200 E/EFL     (11333): elementary<11333> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:11:33.325+0200 E/EFL     (11333): elementary<11333> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:11:33.325+0200 E/EFL     (11333): elementary<11333> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:11:33.325+0200 E/EFL     (11333): elementary<11333> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:11:33.325+0200 E/EFL     (11333): elementary<11333> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:11:33.325+0200 I/AUL_PAD (11333): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:11:33.400+0200 E/EFL     (  532): ecore_x<532> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=3375758 button=1
10-14 14:11:33.430+0200 W/CRASH_MANAGER(10835): worker.c: worker_job(1205) > 1111335646174150798309
