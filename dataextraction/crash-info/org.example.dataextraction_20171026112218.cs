S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2615
Date: 2017-10-26 11:22:18+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x36302e31

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x4175790c, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbe99a3f8
r8   = 0xbe99a4a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbe99a3a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     92348 KB
Buffers:     26816 KB
Cached:     151672 KB
VmPeak:      93168 KB
VmSize:      92428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17024 KB
VmRSS:       17024 KB
VmData:      38140 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23608 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2615 TID = 2615
2615 2683 2690 2691 2692 

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
417a0000 417a8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417a9000 417ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d3000 4180d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41816000 4182f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41837000 4183c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41844000 4186e000 r-xp /usr/lib/libsensor.so.1.9.6
41877000 41889000 r-xp /usr/lib/libefl-assist.so.0.1.0
41891000 41949000 r-xp /usr/lib/libcairo.so.2.11200.14
41954000 41957000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4195f000 41965000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4196e000 41976000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4197e000 41988000 r-xp /usr/lib/libsensord-shared.so
41991000 419a3000 r-xp /usr/lib/libtts.so
419ab000 419cd000 r-xp /usr/lib/libui-extension.so.0.1.0
419d6000 419dd000 r-xp /usr/lib/libtbm.so.1.0.0
419e5000 419f3000 r-xp /usr/lib/libGLESv2.so.2.0
419fc000 419fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a06000 41a0c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a14000 41a17000 r-xp /usr/lib/libEGL.so.1.4
41a1f000 41a2c000 r-xp /usr/lib/libail.so.0.1.0
41a35000 41b72000 r-xp /usr/lib/libicui18n.so.51.1
41b82000 41c66000 r-xp /usr/lib/libicuuc.so.51.1
43204000 43220000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43229000 4322c000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43234000 43235000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4323e000 43246000 r-xp /usr/lib/libdrm.so.2.4.0
4324e000 43250000 r-xp /usr/lib/libdri2.so.0.0.0
43258000 4325f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43268000 4326a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43272000 43279000 r-xp /usr/lib/libminizip.so.1.0.0
43281000 43287000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4328f000 43294000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4329c000 432bd000 r-xp /usr/lib/libexif.so.12.3.3
432d0000 432d2000 r-xp /usr/lib/libttrace.so.1.1
432da000 432df000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e7000 434b1000 r-xp /usr/lib/libCOREGL.so.4.0
436c4000 43ec3000 rw-p [stack:2683]
43ec3000 43ece000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ed7000 43edc000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43ef6000 43ef7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4408c000 4408e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44097000 44896000 rw-p [stack:2690]
44897000 45096000 rw-p [stack:2691]
45097000 45896000 rw-p [stack:2692]
4594e000 45951000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45959000 4595a000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
be97a000 be99b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2615)
Call Stack Count: 1
 0: cfree + 0x30 (0x404e6150) [/lib/libc.so.6] + 0x6f150
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
viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-26 11:15:14.630+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: MEM_FLUSH State: PAUSED
10-26 11:15:30.000+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:15:30.070+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:15:30.135+0200 E/RESOURCED(  566): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 732
10-26 11:15:30.155+0200 E/ALARM_MANAGER(  732): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [819788354]
10-26 11:15:30.155+0200 W/STARTER (  732): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [819788354]
10-26 11:15:30.170+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 11:15:30.170+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:15:30.175+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 11:15:30.185+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 11:15:30.190+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(769), cmd(0)
10-26 11:15:30.190+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: PAUSED
10-26 11:15:30.190+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 11:15:30.190+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : show_clock
10-26 11:15:30.190+0200 W/W_HOME  (  769): main.c: _app_control(1746) > Show clock operation
10-26 11:15:30.190+0200 W/W_HOME  (  769): gesture.c: _clock_show(245) > clock show
10-26 11:15:30.195+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 11:15:30.200+0200 W/W_HOME  (  769): gesture.c: _clock_show(260) > home raise
10-26 11:15:30.215+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[819788354] is expired.
10-26 11:15:30.220+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 819788354, next duetime: 1509009350
10-26 11:15:30.220+0200 E/W_HOME  (  769): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-26 11:15:30.220+0200 W/W_HOME  (  769): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-26 11:15:30.225+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:15:30.225+0200 W/W_HOME  (  769): gesture.c: _clock_show(263) > home raise done
10-26 11:15:30.225+0200 W/W_HOME  (  769): gesture.c: _clock_show(270) > show clock
10-26 11:15:30.225+0200 W/W_HOME  (  769): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-26 11:15:30.225+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 11:15:30.230+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:15:50 (UTC).
10-26 11:15:30.235+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:15:30.245+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:15:30.245+0200 W/W_HOME  (  769): move.c: _scroller_down_done(494) > down signal done
10-26 11:15:30.255+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-26 11:15:30.255+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 11:15:30.255+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:15:30.260+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:15:30.265+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:15:30.265+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-26 11:15:30.265+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-26 11:15:30.265+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-26 11:15:30.265+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-26 11:15:30.270+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
10-26 11:15:30.290+0200 E/APPS    (  769): apps_main.c: apps_main_pause(602) >  paused already
10-26 11:15:30.300+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 11:15:30.305+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:15:30.310+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 11:15:30.310+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(819788354)
10-26 11:15:30.310+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:15:30.310+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:17:01 (UTC).
10-26 11:15:30.310+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:15:30.310+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[819788354] is removed.
10-26 11:15:31.195+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:15:31.195+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 11:15:50.010+0200 W/W_INDICATOR(  735): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 91
10-26 11:15:50.015+0200 E/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-26 11:15:50.055+0200 E/RESOURCED(  566): heart-battery.c: heart_battery_calculate_prediction(1057) > No battery capacity history data
10-26 11:17:01.000+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:17:01.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:17:01.150+0200 E/ALARM_MANAGER( 2179): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [819788355]
10-26 11:17:01.155+0200 E/WIDGET_EVAS( 2179): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-26 11:17:01.175+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[819788355] is expired.
10-26 11:17:01.175+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 819788355, next duetime: 1509009541
10-26 11:17:01.180+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:17:01.180+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:19:01 (UTC).
10-26 11:17:01.180+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:17:01.185+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:17:01.215+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:17:10.515+0200 W/W_INDICATOR(  735): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 92
10-26 11:17:10.520+0200 E/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-26 11:18:31.010+0200 W/W_INDICATOR(  735): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 93
10-26 11:18:31.010+0200 E/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-26 11:19:01.000+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:19:01.075+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:19:01.160+0200 E/ALARM_MANAGER( 2179): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [819788355]
10-26 11:19:01.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[819788355] is expired.
10-26 11:19:01.200+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 819788355, next duetime: 1509009661
10-26 11:19:01.205+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:19:01.205+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:21:01 (UTC).
10-26 11:19:01.205+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:19:01.210+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:19:01.240+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:20:01.610+0200 W/W_INDICATOR(  735): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 94
10-26 11:20:01.615+0200 E/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-26 11:21:01.000+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:21:01.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:21:01.160+0200 E/ALARM_MANAGER( 2179): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [819788355]
10-26 11:21:01.185+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[819788355] is expired.
10-26 11:21:01.190+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 819788355, next duetime: 1509009781
10-26 11:21:01.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:21:01.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:23:01 (UTC).
10-26 11:21:01.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:21:01.195+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:21:01.215+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:21:22.145+0200 W/W_INDICATOR(  735): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 95
10-26 11:21:22.150+0200 E/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-26 11:22:02.750+0200 E/PKGMGR_SERVER( 2455): pkgmgr-server.c: main(2167) > package manager server start
10-26 11:22:02.850+0200 E/PKGMGR_SERVER( 2455): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-1267052155], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[FbgYzbkJnAg+k5JXneaI5T9Jl6w=], backend_flag=[0]
10-26 11:22:02.860+0200 E/PKGMGR_SERVER( 2457): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-26 11:22:02.870+0200 E/PKGMGR  ( 2448): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-26 11:22:02.945+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:02.955+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 11:22:02.965+0200 E/PKGMGR_SERVER( 2457): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-26 11:22:02.985+0200 E/PKGMGR_SERVER( 2455): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2457]
10-26 11:22:04.650+0200 E/PKGMGR_SERVER( 2455): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 11:22:04.650+0200 E/PKGMGR_SERVER( 2455): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 11:22:06.285+0200 E/PKGMGR  ( 2548): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-26 11:22:06.480+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: main(2167) > package manager server start
10-26 11:22:06.570+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-1263336704], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_-1263336704' '-r' 'org.example.dataextraction'], cookie=[Qj/pO/hvaTFibgd0wK+TyCgF4+4=], backend_flag=[0]
10-26 11:22:06.575+0200 E/PKGMGR  ( 2550): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-26 11:22:06.575+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-26 11:22:06.575+0200 E/PKGMGR  ( 2548): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[25480002]
10-26 11:22:06.580+0200 E/PKGMGR_SERVER( 2551): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-26 11:22:06.585+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 11:22:06.590+0200 E/PKGMGR_SERVER( 2552): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 11:22:06.660+0200 E/PKGMGR_OBSERVER( 2552): pkg_observer.c: main(601) > OBSERVER start
10-26 11:22:06.710+0200 E/rpm-installer( 2551): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 11:22:06.710+0200 E/rpm-installer( 2551): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 11:22:06.710+0200 E/rpm-installer( 2551): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 11:22:06.925+0200 E/PKGMGR_OBSERVER( 2552): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[25520002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-26 11:22:06.960+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-26 11:22:06.965+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-26 11:22:06.965+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-26 11:22:06.970+0200 E/PKGMGR_OBSERVER( 2552): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[25520002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 11:22:06.985+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-26 11:22:07.005+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-26 11:22:07.110+0200 W/CERT_SVC( 2551): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 11:22:07.125+0200 E/rpm-installer( 2551): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-26 11:22:07.125+0200 E/rpm-installer( 2551): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-26 11:22:07.125+0200 E/rpm-installer( 2551): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-26 11:22:07.140+0200 E/PKGMGR_PARSER( 2551): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 11:22:07.160+0200 I/PRIVACY-MANAGER-CLIENT( 2551): SocketClient.cpp: SocketClient(37) > Client created
10-26 11:22:07.160+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: mainloop(227) > Got incoming connection
10-26 11:22:07.160+0200 I/PRIVACY-MANAGER-CLIENT( 2551): SocketStream.h: SocketStream(31) > Created
10-26 11:22:07.160+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(253) > Starting connection thread
10-26 11:22:07.160+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketStream.h: SocketStream(31) > Created
10-26 11:22:07.160+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketConnection.h: SocketConnection(44) > Created
10-26 11:22:07.165+0200 I/PRIVACY-MANAGER-CLIENT( 2551): SocketConnection.h: SocketConnection(44) > Created
10-26 11:22:07.165+0200 I/PRIVACY-MANAGER-CLIENT( 2551): SocketClient.cpp: connect(62) > Client connected
10-26 11:22:07.165+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(304) > Calling service
10-26 11:22:07.170+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(307) > Removing client
10-26 11:22:07.170+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(311) > Call served
10-26 11:22:07.170+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(262) > Client serviced
10-26 11:22:07.170+0200 I/PRIVACY-MANAGER-CLIENT( 2551): SocketClient.cpp: disconnect(72) > Client disconnected
10-26 11:22:07.180+0200 E/PKGMGR_CERT( 2551): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-26 11:22:07.185+0200 E/PKGMGR_CERT( 2551): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-26 11:22:07.195+0200 E/PKGMGR_CERT( 2551): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-26 11:22:07.265+0200 E/rpm-installer( 2551): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-26 11:22:07.275+0200 E/PKGMGR_OBSERVER( 2552): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[25520002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-26 11:22:07.280+0200 E/PKGMGR_OBSERVER( 2552): pkg_observer.c: main(620) > OBSERVER end
10-26 11:22:07.295+0200 E/APPS    (  769): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-26 11:22:07.295+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-26 11:22:07.305+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 11:22:07.305+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2552]
10-26 11:22:07.310+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-26 11:22:07.325+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-26 11:22:07.385+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-26 11:22:07.385+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 11:22:07.385+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 11:22:07.385+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 11:22:08.010+0200 E/rpm-installer( 2551): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 11:22:08.010+0200 E/rpm-installer( 2551): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 11:22:08.010+0200 E/rpm-installer( 2551): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 11:22:08.045+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2551]
10-26 11:22:08.095+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/2551/oom_score_adj failed
10-26 11:22:08.095+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 2551
10-26 11:22:08.650+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 11:22:08.650+0200 E/PKGMGR_SERVER( 2550): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 11:22:09.760+0200 E/PKGMGR  ( 2602): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 11:22:09.945+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: main(2167) > package manager server start
10-26 11:22:10.040+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_-1259881648], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_-1259881648' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[mz4KI0z50G2nZsOabU1ytKDqis8=], backend_flag=[0]
10-26 11:22:10.050+0200 E/PKGMGR  ( 2604): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 11:22:10.050+0200 E/PKGMGR  ( 2602): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[26020002]
10-26 11:22:10.060+0200 E/PKGMGR_SERVER( 2605): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 11:22:10.060+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 11:22:10.065+0200 E/PKGMGR_SERVER( 2606): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 11:22:10.135+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: main(601) > OBSERVER start
10-26 11:22:10.165+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 11:22:10.165+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 11:22:10.165+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 11:22:10.280+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 11:22:10.295+0200 E/rpm-installer( 2605): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 11:22:10.295+0200 E/rpm-installer( 2605): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 11:22:10.295+0200 E/rpm-installer( 2605): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 11:22:10.300+0200 E/rpm-installer( 2605): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 11:22:10.300+0200 E/rpm-installer( 2605): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 11:22:10.435+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[26060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 11:22:10.450+0200 E/APPS    (  769): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 11:22:10.450+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 11:22:10.470+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 11:22:10.475+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[26060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 11:22:10.500+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 11:22:10.525+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 11:22:10.635+0200 W/CERT_SVC( 2605): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 11:22:10.665+0200 E/rpm-installer( 2605): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 11:22:10.665+0200 E/rpm-installer( 2605): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 11:22:10.665+0200 E/rpm-installer( 2605): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 11:22:10.665+0200 E/rpm-installer( 2605): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 11:22:10.725+0200 E/PKGMGR_PARSER( 2605): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 11:22:10.730+0200 E/PKGMGR_PARSER( 2605): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 11:22:10.755+0200 E/PKGMGR_PARSER( 2605): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 11:22:10.830+0200 I/PRIVACY-MANAGER-CLIENT( 2605): SocketClient.cpp: SocketClient(37) > Client created
10-26 11:22:10.930+0200 I/efl-extension( 2605): efl_extension.c: eext_mod_init(40) > Init
10-26 11:22:10.930+0200 I/efl-extension( 2605): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 11:22:11.020+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 11:22:11.020+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 61
10-26 11:22:11.020+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 61
10-26 11:22:11.025+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 11:22:11.025+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 11:22:11.025+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 11:22:11.025+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 11:22:11.040+0200 E/PKGMGR_CERT( 2605): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 11:22:11.050+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[26060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 11:22:11.075+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 11:22:11.145+0200 E/rpm-installer( 2605): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 11:22:11.160+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2255 pgid = 2255
10-26 11:22:11.180+0200 E/rpm-installer( 2605): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 11:22:11.255+0200 E/rpm-installer( 2605): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 11:22:11.255+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2255
10-26 11:22:11.265+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.197
10-26 11:22:11.310+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[26060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 11:22:11.360+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 11:22:11.360+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1961 pgid = -1
10-26 11:22:11.360+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 11:22:11.365+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1961
10-26 11:22:11.375+0200 E/rpm-installer( 2605): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 11:22:11.395+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.198
10-26 11:22:11.410+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 11:22:11.580+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:22:11.585+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:22:11.650+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:22:11.665+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:22:11.720+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:22:11.720+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:22:11.725+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:22:11.730+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:22:11.730+0200 E/EFL     ( 2615): elementary<2615> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:22:11.765+0200 E/EFL     ( 2615): elementary<2615> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:22:11.775+0200 E/EFL     ( 2615): elementary<2615> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:22:11.775+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:22:12.005+0200 I/efl-extension( 2616): efl_extension.c: eext_mod_init(40) > Init
10-26 11:22:12.065+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:22:12.065+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:22:12.080+0200 E/EFL     ( 2615): elementary<2615> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:22:12.090+0200 E/EFL     ( 2615): elementary<2615> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:22:12.095+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:22:12.095+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:22:12.095+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:22:12.095+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:22:12.095+0200 E/EFL     ( 2615): elementary<2615> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:22:12.095+0200 I/AUL_PAD ( 2615): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:22:12.120+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:22:12.130+0200 I/UXT     ( 2616): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 11:22:12.140+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:22:12.195+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:22:12.200+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:22:12.200+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:22:12.205+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:22:12.210+0200 E/EFL     ( 2616): elementary<2616> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:22:12.240+0200 E/EFL     ( 2616): elementary<2616> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:22:12.250+0200 E/EFL     ( 2616): elementary<2616> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:22:12.255+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:22:12.290+0200 E/EFL     ( 2616): elementary<2616> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:22:12.300+0200 E/EFL     ( 2616): elementary<2616> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:22:12.300+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:22:12.300+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:22:12.300+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:22:12.300+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:22:12.300+0200 E/EFL     ( 2616): elementary<2616> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:22:12.300+0200 I/AUL_PAD ( 2616): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:22:12.455+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[26060002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 11:22:12.465+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 11:22:12.465+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 11:22:12.495+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 11:22:12.530+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 11:22:12.530+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 11:22:12.530+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 11:22:12.530+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 11:22:12.530+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 11:22:12.535+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 11:22:12.555+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 11:22:12.590+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 11:22:12.615+0200 E/PKGMGR_INFO( 2606): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 11:22:12.635+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 11:22:12.645+0200 E/PKGMGR_OBSERVER( 2606): pkg_observer.c: main(620) > OBSERVER end
10-26 11:22:12.650+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 11:22:12.655+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 11:22:12.655+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2606]
10-26 11:22:12.675+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 11:22:12.680+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 11:22:12.720+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 11:22:12.720+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 11:22:13.540+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 11:22:13.540+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 11:22:13.540+0200 E/rpm-installer( 2605): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 11:22:13.565+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2605]
10-26 11:22:13.590+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/2605/oom_score_adj failed
10-26 11:22:13.590+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 2605
10-26 11:22:14.650+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 11:22:14.650+0200 E/PKGMGR_SERVER( 2604): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 11:22:16.495+0200 W/AUL     ( 2681): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 11:22:16.495+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:22:16.530+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 11:22:16.550+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 11:22:16.550+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 11:22:16.550+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 2681
10-26 11:22:16.575+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 11:22:16.575+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 11:22:16.575+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 11:22:16.575+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 11:22:16.580+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 11:22:16.670+0200 I/efl-extension( 2615): efl_extension.c: eext_mod_init(40) > Init
10-26 11:22:16.675+0200 I/UXT     ( 2615): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 11:22:16.680+0200 I/CAPI_APPFW_APPLICATION( 2615): app_main.c: ui_app_main(704) > app_efl_main
10-26 11:22:16.690+0200 I/CAPI_APPFW_APPLICATION( 2615): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 11:22:16.780+0200 W/AUL     ( 2681): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2615)
10-26 11:22:16.800+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 11:22:16.860+0200 I/Bluetooth( 2615): [bt_initialize] success.
10-26 11:22:16.865+0200 I/Bluetooth( 2615): [bt_adapter_le_create_advertiser] success.
10-26 11:22:16.895+0200 I/Bluetooth( 2615): [bt_adapter_le_set_advertising_mode] success.
10-26 11:22:16.900+0200 I/Bluetooth( 2615): [bt_adapter_le_set_advertising_connectable] success.
10-26 11:22:16.905+0200 I/Bluetooth( 2615): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:16.905+0200 I/Bluetooth( 2615): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:17.080+0200 I/Bluetooth( 2615): [bt_adapter_le_start_advertising_new] success.
10-26 11:22:17.080+0200 I/Bluetooth( 2615): Heart Rate Measurement advertiser started.
10-26 11:22:17.150+0200 I/Bluetooth( 2615): [bt_adapter_le_stop_advertising] success.
10-26 11:22:17.150+0200 I/Bluetooth( 2615): [bt_adapter_le_clear_advertising_data] success.
10-26 11:22:17.150+0200 I/Bluetooth( 2615): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:22:17.150+0200 I/Bluetooth( 2615): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 11:22:17.355+0200 I/Bluetooth( 2615): [bt_adapter_le_start_advertising_new] success.
10-26 11:22:17.445+0200 E/EFL     ( 2615): ecore_evas<2615> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 11:22:17.725+0200 I/APP_CORE( 2615): appcore-efl.c: __do_app(429) > [APP 2615] Event: RESET State: CREATED
10-26 11:22:17.725+0200 I/CAPI_APPFW_APPLICATION( 2615): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 11:22:17.750+0200 I/APP_CORE( 2615): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 11:22:17.750+0200 I/APP_CORE( 2615): appcore-efl.c: __do_app(474) > [APP 2615] Initial Launching, call the resume_cb
10-26 11:22:17.750+0200 I/CAPI_APPFW_APPLICATION( 2615): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 11:22:17.760+0200 W/APP_CORE( 2615): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
10-26 11:22:17.785+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:22:17.785+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 11:22:17.855+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.205
10-26 11:22:17.900+0200 I/APP_CORE( 2615): appcore-efl.c: __do_app(429) > [APP 2615] Event: PAUSE State: RUNNING
10-26 11:22:17.900+0200 I/CAPI_APPFW_APPLICATION( 2615): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 11:22:17.900+0200 I/APP_CORE( 2615): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 11:22:17.910+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:22:17.910+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:22:17.925+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:17.940+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2615
10-26 11:22:17.940+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:22:17.950+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2615
10-26 11:22:17.955+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:22:17.955+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:22:18.015+0200 I/APP_CORE( 2615): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 11:22:18.015+0200 I/CAPI_APPFW_APPLICATION( 2615): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 11:22:18.105+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:22:18.105+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:22:18.130+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:22:18.135+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:22:18.185+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:22:18.185+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:22:18.190+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:22:18.190+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:22:18.190+0200 E/EFL     ( 2694): elementary<2694> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:22:18.210+0200 E/EFL     ( 2694): elementary<2694> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:22:18.210+0200 E/EFL     ( 2694): elementary<2694> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:22:18.215+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:22:18.295+0200 E/EFL     ( 2694): elementary<2694> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:22:18.310+0200 E/EFL     ( 2694): elementary<2694> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:22:18.310+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:22:18.310+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:22:18.310+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:22:18.315+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:22:18.315+0200 E/EFL     ( 2694): elementary<2694> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:22:18.315+0200 I/AUL_PAD ( 2694): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:22:18.365+0200 W/CRASH_MANAGER( 2695): worker.c: worker_job(1205) > 1102615646174150900973
