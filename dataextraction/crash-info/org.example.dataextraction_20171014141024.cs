S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10763
Date: 2017-10-14 14:10:24+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x419439f0, r3   = 0x41662114
r4   = 0xbee884e4, r5   = 0x4144ad30
r6   = 0x00000233, r7   = 0xbee88378
r8   = 0xbee884b4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x41657995, sp   = 0xbee88358
lr   = 0x4146bec5, pc   = 0x4146beca
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     63408 KB
Buffers:     40272 KB
Cached:     161320 KB
VmPeak:      56028 KB
VmSize:      56028 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11272 KB
VmRSS:       11272 KB
VmData:       3312 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23020 KB
VmPTE:          40 KB
VmSwap:          0 KB

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
4146a000 4146d000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41656000 4165a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41663000 4166b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4166c000 4168d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41696000 416c0000 r-xp /usr/lib/libsensor.so.1.9.6
416c9000 416db000 r-xp /usr/lib/libefl-assist.so.0.1.0
416e3000 4179b000 r-xp /usr/lib/libcairo.so.2.11200.14
417a6000 417b0000 r-xp /usr/lib/libsensord-shared.so
417b9000 417cb000 r-xp /usr/lib/libtts.so
417d3000 417f5000 r-xp /usr/lib/libui-extension.so.0.1.0
417fe000 41805000 r-xp /usr/lib/libtbm.so.1.0.0
4180d000 4181b000 r-xp /usr/lib/libGLESv2.so.2.0
41824000 41825000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4182e000 41834000 r-xp /usr/lib/libxcb-render.so.0.0.0
4183c000 4183f000 r-xp /usr/lib/libEGL.so.1.4
41847000 4184c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41854000 41857000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4185f000 41977000 rw-p [heap]
41977000 41978000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41981000 41abe000 r-xp /usr/lib/libicui18n.so.51.1
41ace000 41bb2000 r-xp /usr/lib/libicuuc.so.51.1
41bc7000 41bcf000 r-xp /usr/lib/libdrm.so.2.4.0
41bd7000 41bd9000 r-xp /usr/lib/libdri2.so.0.0.0
41be1000 41be7000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bef000 41bf4000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41bfc000 41c15000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431a6000 431c7000 r-xp /usr/lib/libexif.so.12.3.3
431da000 431dc000 r-xp /usr/lib/libttrace.so.1.1
431e4000 431e9000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431f1000 431f7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43200000 43208000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43210000 4322c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43235000 4323c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43245000 43247000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4324f000 43256000 r-xp /usr/lib/libminizip.so.1.0.0
4325e000 4326b000 r-xp /usr/lib/libail.so.0.1.0
43274000 4333e000 r-xp /usr/lib/libCOREGL.so.4.0
bee68000 bee89000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10763)
Call Stack Count: 10
 0: create_HRM_listener + 0x4d (0x4146beca) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1eca
 1: create_base_gui + 0x10 (0x4146b771) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1771
 2: app_create + 0x32 (0x4146b6a3) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x16a3
 3: (0x414409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x4146b60b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x160b
 7: create_base_gui + 0x23a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 8: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 9: win_delete_request_cb + 0x3 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
hanged_cb:1271] [Time] min :  10
10-14 14:10:00.595+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 14 / 10 / 14:10
10-14 14:10:00.595+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 14:10:00.620+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:10:02.905+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 14:10:02.905+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 14:10:02.905+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:10:02.910+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
10-14 14:10:02.910+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-14 14:10:02.930+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdon_cb(410) >  event lcdon[1][0]
10-14 14:10:02.930+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdon_cb(420) >  Exit from charger alpm mode
10-14 14:10:02.930+0200 E/EFL     ( 9824): ecore<9824> ecore.c:573 _ecore_magic_fail() 
10-14 14:10:02.930+0200 E/EFL     ( 9824): *** ECORE ERROR: Ecore Magic Check Failed!!!
10-14 14:10:02.930+0200 E/EFL     ( 9824): *** IN FUNCTION: ecore_timer_del()
10-14 14:10:02.930+0200 E/EFL     ( 9824): ecore<9824> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
10-14 14:10:02.930+0200 E/EFL     ( 9824): ecore<9824> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
10-14 14:10:02.930+0200 E/EFL     ( 9824): *** SPANK SPANK SPANK!!!
10-14 14:10:02.930+0200 E/EFL     ( 9824): *** Now go fix your code. Tut tut tut!
10-14 14:10:02.930+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-14 14:10:02.940+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-14 14:10:02.940+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-14 14:10:02.940+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): gesture.c: _apps_status_get(126) > apps status:0
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:57907
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-14 14:10:02.940+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 14:10:02.945+0200 W/W_HOME  ( 1063): gesture.c: _widget_updated_cb(194) > widget updated
10-14 14:10:02.945+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 14:10:02.945+0200 W/W_HOME  ( 1063): gesture.c: _manual_render(180) > 
10-14 14:10:02.960+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 14:10:02.960+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 14:10:02.960+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 100, index 20, bg level 100
10-14 14:10:02.960+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_100
10-14 14:10:02.960+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 100
10-14 14:10:02.970+0200 W/W_HOME  ( 1063): gesture.c: _manual_render(180) > 
10-14 14:10:02.975+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [57907]ms
10-14 14:10:02.975+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[1]
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 14:10  /5 / HH:mm
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 14:10
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 14
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 10
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  14
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  10
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 14 / 10 / 14:10
10-14 14:10:02.995+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 14:10:03.000+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 0
10-14 14:10:03.015+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:10:03.035+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 14:10:03.035+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 14:10:03.035+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 14:10:03.080+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 14:10:03.105+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 14:10:03.110+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 14:10:03.125+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 14:10:03.285+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 14:10:03.285+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 14:10:03.300+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 14:10:03.300+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 14:10:03.320+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdon_completed_cb(471) >  event lcdon completed[1]
10-14 14:10:03.320+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdon_completed_cb(475) >  Exit from charger alpm mode
10-14 14:10:03.320+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: _clock_viewer_send_clock_changed(919) >  clock changed <<
10-14 14:10:03.335+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
10-14 14:10:03.335+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[1]
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [9824].
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(750465530)
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 20:47:32 (UTC).
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[750465530] is removed.
10-14 14:10:03.365+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:10:03.425+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 14:10:03.425+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 14:10:03.460+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 14:10:03.460+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 14:10:03.460+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 14:10:03.460+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 14:10:03.465+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 14:10:03.470+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:10:09.620+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
10-14 14:10:09.620+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
10-14 14:10:09.620+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-14 14:10:09.620+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
10-14 14:10:09.630+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-14 14:10:09.630+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-14 14:10:09.630+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 14:10:09.630+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 14:10:09.630+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 1
10-14 14:10:09.630+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-14 14:10:09.630+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 14:10:09.640+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-14 14:10:09.640+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-14 14:10:09.645+0200 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-14 14:10:09.645+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-14 14:10:09.645+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-14 14:10:09.745+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 14:10:09.755+0200 W/W_INDICATOR(  714): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
10-14 14:10:09.780+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 14:10:09.780+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 14:10:09.800+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
10-14 14:10:09.800+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 14:10:09.800+0200 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-14 14:10:09.820+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:10:09.820+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 14:10:09.840+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:10:09.965+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
10-14 14:10:10.070+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-14 14:10:10.070+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
10-14 14:10:10.075+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-14 14:10:10.075+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-14 14:10:10.075+0200 E/ALARM_MANAGER(  705): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(14-10-2017, 14:10:30), repeat(1), interval(20), type(-1073741822)
10-14 14:10:10.115+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
10-14 14:10:10.115+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
10-14 14:10:10.115+0200 E/ALARM_MANAGER( 9824): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(110), start(14-10-2017, 14:12:00), repeat(1), interval(120), type(-1073741822)
10-14 14:10:10.120+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1385245367, next duetime: 1507983030
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1385245367)
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1508014052), due_time(1507983030)
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:10:30 (UTC).
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:10:10.190+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [9824].
10-14 14:10:10.235+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1385245368, next duetime: 1507983120
10-14 14:10:10.235+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1385245368)
10-14 14:10:10.235+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1507983030), due_time(1507983120)
10-14 14:10:10.235+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:10:10.235+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:10:30 (UTC).
10-14 14:10:10.235+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:10:10.240+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:10:10.240+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:10:10.620+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-14 14:10:10.620+0200 W/W_CLOCK_VIEWER( 9824): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-14 14:10:12.400+0200 E/PKGMGR_SERVER(10578): pkgmgr-server.c: main(2167) > package manager server start
10-14 14:10:12.490+0200 E/PKGMGR_SERVER(10578): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-1480212234], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[is7Anl3cP1gJ7iU201lyEhTHhlQ=], backend_flag=[0]
10-14 14:10:12.500+0200 E/PKGMGR_SERVER(10579): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-14 14:10:12.505+0200 E/PKGMGR  (10576): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-14 14:10:12.585+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:10:12.595+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:10:12.600+0200 E/PKGMGR_SERVER(10579): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-14 14:10:12.620+0200 E/PKGMGR_SERVER(10578): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10579]
10-14 14:10:14.645+0200 E/PKGMGR_SERVER(10578): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 14:10:14.645+0200 E/PKGMGR_SERVER(10578): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 14:10:14.805+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
10-14 14:10:15.065+0200 E/PKGMGR  (10684): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-14 14:10:15.250+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: main(2167) > package manager server start
10-14 14:10:15.335+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-1477368696], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_-1477368696' '-r' 'org.example.dataextraction'], cookie=[jqL9dguGtLx7SwCMxkMit0+YsDc=], backend_flag=[0]
10-14 14:10:15.340+0200 E/PKGMGR  (10686): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-14 14:10:15.340+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-14 14:10:15.345+0200 E/PKGMGR  (10684): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[106840002]
10-14 14:10:15.345+0200 E/PKGMGR_SERVER(10687): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-14 14:10:15.345+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 14:10:15.350+0200 E/PKGMGR_SERVER(10688): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 14:10:15.410+0200 E/PKGMGR_OBSERVER(10688): pkg_observer.c: main(601) > OBSERVER start
10-14 14:10:15.450+0200 E/rpm-installer(10687): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 14:10:15.450+0200 E/rpm-installer(10687): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 14:10:15.450+0200 E/rpm-installer(10687): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 14:10:15.690+0200 E/PKGMGR_OBSERVER(10688): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[106880002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-14 14:10:15.725+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-14 14:10:15.725+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-14 14:10:15.725+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-14 14:10:15.730+0200 E/PKGMGR_OBSERVER(10688): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[106880002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 14:10:15.755+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-14 14:10:15.775+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-14 14:10:15.865+0200 W/CERT_SVC(10687): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 14:10:15.880+0200 E/rpm-installer(10687): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-14 14:10:15.880+0200 E/rpm-installer(10687): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-14 14:10:15.880+0200 E/rpm-installer(10687): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-14 14:10:15.895+0200 E/PKGMGR_PARSER(10687): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-CLIENT(10687): SocketClient.cpp: SocketClient(37) > Client created
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-CLIENT(10687): SocketStream.h: SocketStream(31) > Created
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-CLIENT(10687): SocketConnection.h: SocketConnection(44) > Created
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-CLIENT(10687): SocketClient.cpp: connect(62) > Client connected
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: mainloop(227) > Got incoming connection
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(253) > Starting connection thread
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketStream.h: SocketStream(31) > Created
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketConnection.h: SocketConnection(44) > Created
10-14 14:10:15.915+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(304) > Calling service
10-14 14:10:15.920+0200 I/PRIVACY-MANAGER-CLIENT(10687): SocketClient.cpp: disconnect(72) > Client disconnected
10-14 14:10:15.925+0200 E/PKGMGR_CERT(10687): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-14 14:10:15.930+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(307) > Removing client
10-14 14:10:15.930+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(311) > Call served
10-14 14:10:15.930+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(262) > Client serviced
10-14 14:10:15.930+0200 E/PKGMGR_CERT(10687): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-14 14:10:15.945+0200 E/PKGMGR_CERT(10687): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-14 14:10:16.015+0200 E/rpm-installer(10687): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-14 14:10:16.025+0200 E/PKGMGR_OBSERVER(10688): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[106880002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-14 14:10:16.035+0200 E/APPS    ( 1063): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-14 14:10:16.035+0200 E/APPS    ( 1063): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-14 14:10:16.035+0200 E/PKGMGR_OBSERVER(10688): pkg_observer.c: main(620) > OBSERVER end
10-14 14:10:16.050+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 14:10:16.050+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10688]
10-14 14:10:16.065+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-14 14:10:16.070+0200 E/STARTER (  705): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-14 14:10:16.150+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-14 14:10:16.150+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 14:10:16.150+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 14:10:16.150+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 14:10:16.800+0200 E/rpm-installer(10687): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 14:10:16.800+0200 E/rpm-installer(10687): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 14:10:16.800+0200 E/rpm-installer(10687): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 14:10:16.835+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10687]
10-14 14:10:16.960+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/10687/oom_score_adj failed
10-14 14:10:16.960+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 10687
10-14 14:10:17.645+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 14:10:17.645+0200 E/PKGMGR_SERVER(10686): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 14:10:18.495+0200 E/PKGMGR  (10748): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-14 14:10:18.715+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: main(2167) > package manager server start
10-14 14:10:18.820+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_-1473959360], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_-1473959360' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[/xOiYnRVOLu8++9A9UGb1200Ths=], backend_flag=[0]
10-14 14:10:18.830+0200 E/PKGMGR  (10750): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-14 14:10:18.835+0200 E/PKGMGR  (10748): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[107480002]
10-14 14:10:18.840+0200 E/PKGMGR_SERVER(10752): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-14 14:10:18.840+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 14:10:18.845+0200 E/PKGMGR_SERVER(10753): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 14:10:18.930+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: main(601) > OBSERVER start
10-14 14:10:18.965+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 14:10:18.965+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 14:10:18.965+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 14:10:19.075+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-14 14:10:19.085+0200 E/rpm-installer(10752): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-14 14:10:19.090+0200 E/rpm-installer(10752): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-14 14:10:19.090+0200 E/rpm-installer(10752): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-14 14:10:19.090+0200 E/rpm-installer(10752): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-14 14:10:19.090+0200 E/rpm-installer(10752): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-14 14:10:19.200+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[107530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-14 14:10:19.210+0200 E/APPS    ( 1063): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-14 14:10:19.210+0200 E/APPS    ( 1063): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-14 14:10:19.235+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-14 14:10:19.240+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[107530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 14:10:19.265+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-14 14:10:19.280+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 14:10:19.410+0200 W/CERT_SVC(10752): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 14:10:19.435+0200 E/rpm-installer(10752): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-14 14:10:19.440+0200 E/rpm-installer(10752): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-14 14:10:19.440+0200 E/rpm-installer(10752): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-14 14:10:19.440+0200 E/rpm-installer(10752): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-14 14:10:19.495+0200 E/PKGMGR_PARSER(10752): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-14 14:10:19.505+0200 E/PKGMGR_PARSER(10752): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 14:10:19.525+0200 E/PKGMGR_PARSER(10752): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-14 14:10:19.590+0200 I/PRIVACY-MANAGER-CLIENT(10752): SocketClient.cpp: SocketClient(37) > Client created
10-14 14:10:19.680+0200 I/efl-extension(10752): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:19.685+0200 I/efl-extension(10752): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 61
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 61
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-14 14:10:19.760+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-14 14:10:19.775+0200 E/PKGMGR_CERT(10752): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-14 14:10:19.785+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[107530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-14 14:10:19.815+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 14:10:19.865+0200 E/rpm-installer(10752): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-14 14:10:19.875+0200 E/rpm-installer(10752): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-14 14:10:19.890+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9874 pgid = 9874
10-14 14:10:19.955+0200 E/rpm-installer(10752): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-14 14:10:19.965+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9874
10-14 14:10:19.975+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.711
10-14 14:10:20.010+0200 E/rpm-installer(10752): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-14 14:10:20.010+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[107530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-14 14:10:20.070+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:10:20.070+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9708 pgid = -1
10-14 14:10:20.070+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:10:20.075+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9708
10-14 14:10:20.085+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.712
10-14 14:10:20.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 14:10:20.380+0200 E/EFL     (10763): elementary<10763> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:20.380+0200 E/EFL     (10763): elementary<10763> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:20.430+0200 E/EFL     (10763): elementary<10763> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:20.430+0200 E/EFL     (10763): elementary<10763> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:20.490+0200 E/EFL     (10763): elementary<10763> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:20.490+0200 E/EFL     (10763): elementary<10763> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:20.490+0200 E/EFL     (10763): elementary<10763> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:20.490+0200 E/EFL     (10763): elementary<10763> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:20.490+0200 E/EFL     (10763): elementary<10763> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:20.530+0200 E/EFL     (10763): elementary<10763> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:20.530+0200 E/EFL     (10763): elementary<10763> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:20.540+0200 E/EFL     (10763): elementary<10763> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:20.600+0200 E/EFL     (10763): elementary<10763> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:20.610+0200 E/EFL     (10763): elementary<10763> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:20.610+0200 E/EFL     (10763): elementary<10763> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:20.615+0200 E/EFL     (10763): elementary<10763> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:20.615+0200 E/EFL     (10763): elementary<10763> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:20.615+0200 E/EFL     (10763): elementary<10763> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:20.615+0200 E/EFL     (10763): elementary<10763> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:20.615+0200 I/AUL_PAD (10763): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:10:20.645+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-14 14:10:20.855+0200 I/efl-extension(10764): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:20.910+0200 E/EFL     (10764): elementary<10764> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:10:20.910+0200 E/EFL     (10764): elementary<10764> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:10:20.935+0200 E/EFL     (10764): elementary<10764> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:10:20.940+0200 I/UXT     (10764): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:20.940+0200 E/EFL     (10764): elementary<10764> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:10:20.990+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[107530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-14 14:10:21.000+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-14 14:10:21.000+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-14 14:10:21.020+0200 E/EFL     (10764): elementary<10764> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:10:21.065+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-14 14:10:21.090+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-14 14:10:21.090+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 14:10:21.090+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 14:10:21.090+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 14:10:21.090+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-14 14:10:21.090+0200 E/WMS     (  499): wms_db.c: wms_db_package_event_insert_record(177) > 
10-14 14:10:21.115+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-14 14:10:21.155+0200 E/PKGMGR_INFO(10753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-14 14:10:21.155+0200 E/STARTER (  705): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-14 14:10:21.165+0200 E/PKGMGR_INFO(  498): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-14 14:10:21.170+0200 E/PKGMGR_OBSERVER(10753): pkg_observer.c: main(620) > OBSERVER end
10-14 14:10:21.190+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 14:10:21.190+0200 W/APPS    ( 1063): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-14 14:10:21.205+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 14:10:21.205+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10753]
10-14 14:10:21.210+0200 E/EFL     (10764): elementary<10764> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:10:21.220+0200 E/EFL     (10764): elementary<10764> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:10:21.220+0200 E/EFL     (10764): elementary<10764> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:10:21.220+0200 E/EFL     (10764): elementary<10764> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:10:21.245+0200 E/EFL     (10764): elementary<10764> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:10:21.250+0200 E/EFL     (10764): elementary<10764> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:10:21.250+0200 E/EFL     (10764): elementary<10764> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:10:21.285+0200 E/EFL     (10764): elementary<10764> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:10:21.295+0200 E/EFL     (10764): elementary<10764> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:10:21.295+0200 E/EFL     (10764): elementary<10764> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:10:21.295+0200 E/EFL     (10764): elementary<10764> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:10:21.295+0200 E/EFL     (10764): elementary<10764> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:10:21.295+0200 E/EFL     (10764): elementary<10764> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:10:21.295+0200 E/EFL     (10764): elementary<10764> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:10:21.295+0200 I/AUL_PAD (10764): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:10:22.035+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 14:10:22.035+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 14:10:22.035+0200 E/rpm-installer(10752): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 14:10:22.055+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10752]
10-14 14:10:22.100+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/10752/oom_score_adj failed
10-14 14:10:22.115+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 10752
10-14 14:10:22.645+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 14:10:22.645+0200 E/PKGMGR_SERVER(10750): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 14:10:24.565+0200 W/AUL     (10832): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:10:24.570+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:10:24.590+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-14 14:10:24.605+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-14 14:10:24.605+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 14:10:24.605+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 10832
10-14 14:10:24.625+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:10:24.625+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:10:24.630+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:10:24.630+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 14:10:24.630+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:10:24.705+0200 I/efl-extension(10763): efl_extension.c: eext_mod_init(40) > Init
10-14 14:10:24.710+0200 I/UXT     (10763): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:10:24.710+0200 I/CAPI_APPFW_APPLICATION(10763): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:10:24.720+0200 I/CAPI_APPFW_APPLICATION(10763): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:10:24.735+0200 W/AUL     (10832): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10763)
10-14 14:10:24.785+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:10:25.140+0200 W/CRASH_MANAGER(10835): worker.c: worker_job(1205) > 1110763646174150798302
