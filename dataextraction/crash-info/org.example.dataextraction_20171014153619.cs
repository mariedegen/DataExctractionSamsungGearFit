S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 26284
Date: 2017-10-14 15:36:19+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 26284, uid 5000)

Register Information
r0   = 0x00200000, r1   = 0x48ec0004
r2   = 0x4146bdd1, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x416c77fc
r6   = 0x00200000, r7   = 0xbec15f18
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x48ec0004, fp   = 0x00000000
ip   = 0x0000016c, sp   = 0xbec15e48
lr   = 0x4146bdd1, pc   = 0x404e62d0
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     37464 KB
Buffers:     53932 KB
Cached:     167752 KB
VmPeak:      96460 KB
VmSize:      95720 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17104 KB
VmRSS:       17104 KB
VmData:      39488 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 26284 TID = 26284
26284 26308 26309 26310 26311 

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
41643000 4164e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41656000 4165a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41663000 4166b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4166c000 4168d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41696000 416c0000 r-xp /usr/lib/libsensor.so.1.9.6
416c9000 416db000 r-xp /usr/lib/libefl-assist.so.0.1.0
416e3000 4179b000 r-xp /usr/lib/libcairo.so.2.11200.14
417a6000 417b0000 r-xp /usr/lib/libsensord-shared.so
417b9000 417cb000 r-xp /usr/lib/libtts.so
417d6000 417db000 rw-p [heap]
417db000 418f2000 rw-p [heap]
418f2000 41914000 r-xp /usr/lib/libui-extension.so.0.1.0
4191d000 41924000 r-xp /usr/lib/libtbm.so.1.0.0
4192c000 4193a000 r-xp /usr/lib/libGLESv2.so.2.0
41943000 41944000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4194d000 41953000 r-xp /usr/lib/libxcb-render.so.0.0.0
4195b000 4195e000 r-xp /usr/lib/libEGL.so.1.4
41966000 4196b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41973000 41976000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4197e000 4197f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41988000 41ac5000 r-xp /usr/lib/libicui18n.so.51.1
41ad5000 41bb9000 r-xp /usr/lib/libicuuc.so.51.1
41bce000 41bd6000 r-xp /usr/lib/libdrm.so.2.4.0
41bde000 41be0000 r-xp /usr/lib/libdri2.so.0.0.0
41be8000 41bee000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bf6000 41bfb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c03000 41c1c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431ad000 431ce000 r-xp /usr/lib/libexif.so.12.3.3
431e1000 431e3000 r-xp /usr/lib/libttrace.so.1.1
431eb000 431f0000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431f8000 431fe000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43207000 4320f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43217000 43233000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4323c000 43243000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4324c000 4324e000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43256000 4325d000 r-xp /usr/lib/libminizip.so.1.0.0
43265000 43272000 r-xp /usr/lib/libail.so.0.1.0
4327b000 43345000 r-xp /usr/lib/libCOREGL.so.4.0
43558000 43d57000 rw-p [stack:26308]
43d58000 44557000 rw-p [stack:26309]
44558000 44d57000 rw-p [stack:26310]
44d57000 44d62000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44d6b000 44d70000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
44d87000 44d88000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
44dec000 44ded000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44df5000 44df6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44f01000 45800000 rw-p [stack:26311]
4589f000 458a6000 r-xp /usr/lib/libfeedback.so.0.1.4
458af000 458b1000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
458b9000 458c3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
458cb000 458d2000 r-xp /usr/lib/libmmfcommon.so.0.0.0
458da000 458f0000 r-xp /usr/lib/libmmfsound.so.0.1.0
45902000 45907000 r-xp /usr/lib/libmmfsession.so.0.0.0
4590f000 45919000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45925000 45929000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45932000 45947000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4594f000 459b0000 r-xp /usr/lib/libasound.so.2.0.0
459ba000 459bd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
459c5000 459fd000 r-xp /usr/lib/libpulse.so.0.16.2
459fe000 45a01000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45a09000 45a3a000 r-xp /usr/lib/libmdm.so.1.1.86
45a42000 45a47000 r-xp /usr/lib/libjson.so.0.0.1
45a4f000 45a97000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a98000 45adf000 r-xp /usr/lib/libsndfile.so.1.0.26
45aeb000 45af3000 r-xp /usr/lib/libmdm-common.so.1.0.89
45af4000 45b16000 r-xp /usr/lib/libvorbis.so.0.4.3
45b1e000 45b22000 r-xp /usr/lib/libogg.so.0.7.1
bebf6000 bec17000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26284)
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
39) > [PROCESSMGR] =====================> send UpdateClock
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(353) > appcore resumed manually
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): main.c: home_appcore_resume(714) > Home Appcore Resumed
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): main.c: home_resume(739) > clock/widget resumed
10-14 15:36:15.205+0200 W/W_HOME  ( 1063): clock_indicator.c: clock_indicator_resume(537) > 
10-14 15:36:15.210+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.210+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 15:36:15.210+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESUME State: RUNNING
10-14 15:36:15.240+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 15:36:15.245+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 15:36:15.245+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.245+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.245+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.255+0200 W/WATCH_CORE( 1130): appcore-watch.c: __widget_resume(1039) > widget_resume
10-14 15:36:15.260+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 15:36:15.260+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f370] swap changed from async to sync
10-14 15:36:15.270+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-14 15:36:15.270+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-14 15:36:15.270+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 15:36:15.275+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/25777/oom_score_adj failed
10-14 15:36:15.275+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 25777
10-14 15:36:15.325+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 15:36:15.330+0200 E/STARTER (  705): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:25777) is destroyed. ambient mode[0], charging[0], sports mode[0]
10-14 15:36:15.330+0200 W/STARTER (  705): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
10-14 15:36:15.340+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25777
10-14 15:36:15.365+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 2
10-14 15:36:15.365+0200 E/WATCH_CORE( 1130): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
10-14 15:36:15.375+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.1746
10-14 15:36:15.425+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-14 15:36:15.425+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-14 15:36:15.425+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=8457778
10-14 15:36:15.425+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-14 15:36:15.425+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-14 15:36:15.425+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-14 15:36:15.425+0200 E/STARTER (  705): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-14 15:36:15.425+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-14 15:36:15.425+0200 W/STARTER (  705): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-14 15:36:15.455+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 15:36:15.455+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 15:36:15.455+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 15:36:15.455+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 15:36:15.455+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 15:36:15.610+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 15:36:15.610+0200 W/KEYROUTER(  409): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-14 15:36:15.610+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=8457964
10-14 15:36:15.610+0200 W/STARTER (  705): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-14 15:36:15.615+0200 W/STARTER (  705): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-14 15:36:15.625+0200 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-14 15:36:15.630+0200 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-14 15:36:15.635+0200 E/STARTER (  705): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-14 15:36:15.635+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-14 15:36:15.635+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 15:36:15.640+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 705
10-14 15:36:15.665+0200 W/AUL_AMD (  532): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 1063
10-14 15:36:15.680+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 15:36:15.685+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(1063), cmd(0)
10-14 15:36:15.685+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1063)
10-14 15:36:15.685+0200 E/AUL     (  705): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 15:36:15.690+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESET State: RUNNING
10-14 15:36:15.690+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): main.c: _app_control(1704) > Service value : powerkey
10-14 15:36:15.690+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-14 15:36:15.690+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-14 15:36:15.690+0200 E/W_HOME  ( 1063): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): move.c: move_move_to_apps(220) > move to apps
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): move.c: _create_fake_apps(823) > fake image position : 432
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.690+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.690+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-14 15:36:15.695+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-14 15:36:15.695+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-14 15:36:15.695+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-14 15:36:15.995+0200 W/W_HOME  ( 1063): move.c: _transit_del_cb(115) > transit end
10-14 15:36:15.995+0200 W/W_HOME  ( 1063): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-14 15:36:15.995+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 15:36:16.010+0200 W/W_HOME  ( 1063): move.c: _scroller_up_done(515) > up signal done
10-14 15:36:16.015+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-14 15:36:16.015+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-14 15:36:16.015+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:16.015+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:16.020+0200 W/W_HOME  ( 1063): main.c: home_pause(766) > clock/widget paused
10-14 15:36:16.020+0200 W/W_HOME  ( 1063): clock_indicator.c: clock_indicator_pause(554) > 
10-14 15:36:16.020+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:16.020+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-14 15:36:16.020+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-14 15:36:16.020+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-14 15:36:16.020+0200 I/wnotib  ( 1063): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-14 15:36:16.020+0200 E/APPS    ( 1063): apps_main.c: apps_main_resume(636) >  resumed already
10-14 15:36:16.045+0200 W/WATCH_CORE( 1130): appcore-watch.c: __widget_pause(1028) > widget_pause
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 15:36:16.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.215+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 15:36:16.215+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 15:36:16.215+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 15:36:16.215+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 15:36:16.220+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 15:36:16.220+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 15:36:16.220+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 15:36:16.220+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 15:36:16.220+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 15:36:16.220+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 15:36:16.220+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 15:36:16.225+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.225+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 15:36:16.225+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 15:36:16.225+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 15:36:16.225+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 15:36:16.225+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 15:36:16.225+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 15:36:16.225+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 15:36:16.230+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.230+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 15:36:16.230+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 15:36:16.235+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 15:36:16.235+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 15:36:16.235+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 15:36:16.235+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:16.260+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8458616 button=1
10-14 15:36:16.260+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.260+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 15:36:16.260+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-14 15:36:16.285+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.285+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 15:36:16.295+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.310+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.320+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.335+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.345+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.360+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:16.370+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8458726 button=1
10-14 15:36:16.370+0200 E/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 15:36:16.445+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 15:36:16.445+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 15:36:16.445+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 15:36:16.450+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-14 15:36:16.450+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-14 15:36:16.450+0200 E/wnoti-service(  838): wnoti-native-client.c: handle_cache_notification(603) > >>
10-14 15:36:16.550+0200 W/SHealth_Service( 1005): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-14 15:36:16.675+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 15:36:16.675+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 15:36:16.885+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 15:36:17.135+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8459489 button=1
10-14 15:36:17.135+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 15:36:17.135+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 15:36:17.135+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 15:36:17.215+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8459573 button=1
10-14 15:36:17.215+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 15:36:17.220+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 15:36:17.220+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 15:36:17.220+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 15:36:17.220+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 15:36:17.220+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 15:36:17.220+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 15:36:17.230+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 15:36:17.230+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 15:36:17.230+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 15:36:17.230+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 15:36:17.230+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 15:36:17.270+0200 I/efl-extension(26284): efl_extension.c: eext_mod_init(40) > Init
10-14 15:36:17.275+0200 I/UXT     (26284): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 15:36:17.275+0200 I/CAPI_APPFW_APPLICATION(26284): app_main.c: ui_app_main(704) > app_efl_main
10-14 15:36:17.280+0200 I/CAPI_APPFW_APPLICATION(26284): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 15:36:17.330+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 15:36:17.330+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(26284)
10-14 15:36:17.370+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 15:36:17.390+0200 E/EFL     (26284): ecore_evas<26284> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 15:36:17.570+0200 I/APP_CORE(26284): appcore-efl.c: __do_app(429) > [APP 26284] Event: RESET State: CREATED
10-14 15:36:17.570+0200 I/CAPI_APPFW_APPLICATION(26284): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 15:36:17.590+0200 I/APP_CORE(26284): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 15:36:17.590+0200 I/APP_CORE(26284): appcore-efl.c: __do_app(474) > [APP 26284] Initial Launching, call the resume_cb
10-14 15:36:17.590+0200 I/CAPI_APPFW_APPLICATION(26284): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 15:36:17.590+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 15:36:17.590+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.590+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.595+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.615+0200 W/APP_CORE(26284): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4200002
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(344) > appcore paused manually
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): main.c: home_appcore_pause(723) > Home Appcore Paused
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.650+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 15:36:17.655+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 15:36:17.655+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 15:36:17.655+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 15:36:17.660+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 15:36:17.660+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 15:36:17.660+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 15:36:17.660+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 15:36:17.660+0200 E/W_HOME  ( 1063): main.c: _pause_cb(674) > paused already
10-14 15:36:17.660+0200 I/APP_CORE(26284): appcore-efl.c: __do_app(429) > [APP 26284] Event: RESUME State: RUNNING
10-14 15:36:17.730+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 15:36:17.890+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 15:36:17.890+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 15:36:17.890+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 15:36:17.890+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-14 15:36:17.935+0200 E/EFL     (26284): elementary<26284> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 15:36:17.970+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 15:36:17.985+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-14 15:36:17.990+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 15:36:17.995+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 15:36:17.995+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 15:36:18.020+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 15:36:18.165+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 15:36:18.575+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.1749
10-14 15:36:18.620+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 15:36:18.630+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26284
10-14 15:36:18.635+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 15:36:18.650+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26284
10-14 15:36:18.650+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 15:36:18.650+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 15:36:18.720+0200 E/EFL     (26284): ecore_x<26284> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=8461077 button=1
10-14 15:36:18.780+0200 E/EFL     (26284): ecore_x<26284> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=8461136 button=1
10-14 15:36:18.795+0200 E/EFL     (26315): elementary<26315> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 15:36:18.795+0200 E/EFL     (26315): elementary<26315> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 15:36:18.820+0200 E/EFL     (26315): elementary<26315> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 15:36:18.820+0200 E/EFL     (26315): elementary<26315> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 15:36:18.875+0200 E/EFL     (26315): elementary<26315> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 15:36:18.875+0200 E/EFL     (26315): elementary<26315> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 15:36:18.875+0200 E/EFL     (26315): elementary<26315> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 15:36:18.875+0200 E/EFL     (26315): elementary<26315> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 15:36:18.880+0200 E/EFL     (26315): elementary<26315> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 15:36:18.895+0200 E/EFL     (26315): elementary<26315> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 15:36:18.895+0200 E/EFL     (26315): elementary<26315> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 15:36:18.895+0200 E/EFL     (26315): elementary<26315> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 15:36:18.960+0200 E/EFL     (26315): elementary<26315> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 15:36:18.975+0200 E/EFL     (26315): elementary<26315> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 15:36:18.975+0200 E/EFL     (26315): elementary<26315> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 15:36:18.975+0200 E/EFL     (26315): elementary<26315> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 15:36:18.975+0200 E/EFL     (26315): elementary<26315> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 15:36:18.975+0200 E/EFL     (26315): elementary<26315> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 15:36:18.975+0200 E/EFL     (26315): elementary<26315> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 15:36:18.975+0200 I/AUL_PAD (26315): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 15:36:19.005+0200 E/EFL     (26284): elementary<26284> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 15:36:19.025+0200 E/EFL     (26284): elementary<26284> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 15:36:19.040+0200 E/EFL     (26284): <26284> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 15:36:19.375+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f370] swap changed from sync to async
10-14 15:36:19.385+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 26284 pgid = 26284
10-14 15:36:19.440+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 15:36:19.440+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 15:36:19.440+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-14 15:36:19.445+0200 W/CRASH_MANAGER(26323): worker.c: worker_job(1205) > 1126284646174150798817
