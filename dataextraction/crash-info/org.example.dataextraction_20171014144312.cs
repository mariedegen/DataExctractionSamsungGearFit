S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 14827
Date: 2017-10-14 14:43:12+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xbe83e580, r3   = 0x41762114
r4   = 0xbe83e4e4, r5   = 0x4154ad30
r6   = 0x00000233, r7   = 0xbe83e378
r8   = 0xbe83e4b4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x41757995, sp   = 0xbe83e360
lr   = 0x4156be73, pc   = 0x4156be78
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     55392 KB
Buffers:     44880 KB
Cached:     164040 KB
VmPeak:      56960 KB
VmSize:      56960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11264 KB
VmRSS:       11264 KB
VmData:       4244 KB
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
40756000 4075e000 rw-p [heap]
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
be81e000 be83f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14827)
Call Stack Count: 10
 0: create_HRM_listener + 0x3b (0x4156be78) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1e78
 1: create_base_gui + 0x10 (0x4156b731) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1731
 2: app_create + 0x32 (0x4156b663) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1663
 3: (0x415409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x4156b5cb) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x15cb
 7: create_base_gui + 0x27a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 8: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 9: win_back_cb + 0x1f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
[31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 14:40:43.465+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 14:40:43.465+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 14:40:43.465+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 14:40:43.755+0200 W/AUL     (14552): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-14 14:40:43.760+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 14:40:43.760+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 14:40:43.760+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 14535
10-14 14:40:43.765+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 14:40:43.770+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14535
10-14 14:40:44.365+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:40:45.465+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 14:40:47.585+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 14:40:50.050+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 14:41:01.554+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 99
10-14 14:41:01.569+0200 E/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-14 14:41:01.574+0200 E/RESOURCED(  536): heart-battery.c: heart_battery_calculate_prediction(1057) > No battery capacity history data
10-14 14:41:11.085+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
10-14 14:41:11.085+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
10-14 14:41:11.085+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-14 14:41:11.085+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
10-14 14:41:11.100+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 14:41:11.100+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 14:41:11.105+0200 W/W_INDICATOR(  714): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
10-14 14:41:11.105+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 14:41:11.120+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-14 14:41:11.120+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-14 14:41:11.120+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 14:41:11.120+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 14:41:11.120+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 1
10-14 14:41:11.120+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-14 14:41:11.120+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 14:41:11.140+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-14 14:41:11.140+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-14 14:41:11.145+0200 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-14 14:41:11.145+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-14 14:41:11.145+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-14 14:41:11.195+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
10-14 14:41:11.195+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 14:41:11.200+0200 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-14 14:41:11.210+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:41:11.210+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 14:41:11.215+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:41:11.215+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 14:41:11.240+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 14:41:11.345+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
10-14 14:41:11.410+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-14 14:41:11.410+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
10-14 14:41:11.410+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-14 14:41:11.410+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-14 14:41:11.410+0200 E/ALARM_MANAGER(  705): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(14-10-2017, 14:41:31), repeat(1), interval(20), type(-1073741822)
10-14 14:41:11.425+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 14:41:11.425+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
10-14 14:41:11.425+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
10-14 14:41:11.430+0200 E/ALARM_MANAGER(14495): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(109), start(14-10-2017, 14:43:00), repeat(1), interval(120), type(-1073741822)
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 194774614, next duetime: 1507984891
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(194774614)
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1508014052), due_time(1507984891)
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:41:31 (UTC).
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:41:11.480+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:11.485+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:11.485+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [14495].
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 194774615, next duetime: 1507984980
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(194774615)
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1507984891), due_time(1507984980)
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:41:31 (UTC).
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:41:11.520+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:11.525+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:11.640+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 100
10-14 14:41:11.640+0200 E/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-14 14:41:11.930+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-14 14:41:11.930+0200 W/W_CLOCK_VIEWER(14495): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-14 14:41:16.210+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
10-14 14:41:31.000+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-14 14:41:31.060+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-14 14:41:31.145+0200 E/ALARM_MANAGER(  705): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [194774614]
10-14 14:41:31.145+0200 W/STARTER (  705): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [194774614]
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[194774614] is expired.
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 194774614, next duetime: 1507984911
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:41:51 (UTC).
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:31.155+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-14 14:41:31.160+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-14 14:41:31.160+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:41:31.165+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 705
10-14 14:41:31.175+0200 W/AUL_AMD (  532): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 1063
10-14 14:41:31.180+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESET State: PAUSED
10-14 14:41:31.180+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 14:41:31.180+0200 W/W_HOME  ( 1063): main.c: _app_control(1704) > Service value : show_clock
10-14 14:41:31.180+0200 W/W_HOME  ( 1063): main.c: _app_control(1746) > Show clock operation
10-14 14:41:31.180+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(245) > clock show
10-14 14:41:31.185+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(1063), cmd(0)
10-14 14:41:31.185+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(260) > home raise
10-14 14:41:31.185+0200 E/W_HOME  ( 1063): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-14 14:41:31.185+0200 W/W_HOME  ( 1063): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-14 14:41:31.185+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(263) > home raise done
10-14 14:41:31.185+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(270) > show clock
10-14 14:41:31.185+0200 W/W_HOME  ( 1063): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-14 14:41:31.190+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1063)
10-14 14:41:31.195+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-14 14:41:31.210+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
10-14 14:41:31.210+0200 W/W_HOME  ( 1063): move.c: _scroller_down_done(494) > down signal done
10-14 14:41:31.210+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-14 14:41:31.210+0200 W/W_HOME  ( 1063): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-14 14:41:31.210+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 14:41:31.215+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 14:41:31.215+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 14:41:31.215+0200 W/W_HOME  ( 1063): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-14 14:41:31.215+0200 W/W_HOME  ( 1063): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-14 14:41:31.215+0200 I/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-14 14:41:31.215+0200 I/wnotib  ( 1063): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-14 14:41:31.240+0200 E/APPS    ( 1063): apps_main.c: apps_main_pause(602) >  paused already
10-14 14:41:31.250+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(194774614)
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:43:00 (UTC).
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[194774614] is removed.
10-14 14:41:31.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:41:31.275+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f370] swap changed from sync to async
10-14 14:41:32.190+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 14:41:32.190+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 14:42:59.535+0200 E/PKGMGR_SERVER(14659): pkgmgr-server.c: main(2167) > package manager server start
10-14 14:42:59.640+0200 E/PKGMGR_SERVER(14659): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_486875168], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[BmkWH3NOBUCqXYECNMmbu/4wVKI=], backend_flag=[0]
10-14 14:42:59.650+0200 E/PKGMGR_SERVER(14660): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-14 14:42:59.660+0200 E/PKGMGR  (14657): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-14 14:42:59.765+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 14:42:59.775+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 14:42:59.785+0200 E/PKGMGR_SERVER(14660): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-14 14:42:59.805+0200 E/PKGMGR_SERVER(14659): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14660]
10-14 14:43:00.000+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-14 14:43:00.085+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-14 14:43:00.180+0200 E/ALARM_MANAGER(14495): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [194774615]
10-14 14:43:00.185+0200 E/WIDGET_EVAS(14495): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[194774615] is expired.
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 194774615, next duetime: 1507985100
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 12:45:00 (UTC).
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 14:43:00.195+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-14 14:43:00.225+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-14 14:43:01.645+0200 E/PKGMGR_SERVER(14659): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 14:43:01.645+0200 E/PKGMGR_SERVER(14659): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 14:43:02.975+0200 E/PKGMGR  (14753): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-14 14:43:03.165+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: main(2167) > package manager server start
10-14 14:43:03.280+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_490537713], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_490537713' '-r' 'org.example.dataextraction'], cookie=[IvkXIEDFKLh9DvXS+rH+6rbH/eQ=], backend_flag=[0]
10-14 14:43:03.285+0200 E/PKGMGR  (14755): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-14 14:43:03.285+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-14 14:43:03.290+0200 E/PKGMGR  (14753): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[147530002]
10-14 14:43:03.290+0200 E/PKGMGR_SERVER(14756): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-14 14:43:03.290+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 14:43:03.295+0200 E/PKGMGR_SERVER(14757): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 14:43:03.385+0200 E/PKGMGR_OBSERVER(14757): pkg_observer.c: main(601) > OBSERVER start
10-14 14:43:03.425+0200 E/rpm-installer(14756): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 14:43:03.425+0200 E/rpm-installer(14756): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 14:43:03.425+0200 E/rpm-installer(14756): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 14:43:03.665+0200 E/PKGMGR_OBSERVER(14757): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[147570002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-14 14:43:03.715+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-14 14:43:03.715+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-14 14:43:03.720+0200 E/PKGMGR_OBSERVER(14757): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[147570002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 14:43:03.730+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-14 14:43:03.755+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-14 14:43:03.780+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-14 14:43:03.865+0200 W/CERT_SVC(14756): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 14:43:03.875+0200 E/rpm-installer(14756): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-14 14:43:03.875+0200 E/rpm-installer(14756): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-14 14:43:03.875+0200 E/rpm-installer(14756): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-14 14:43:03.895+0200 E/PKGMGR_PARSER(14756): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-CLIENT(14756): SocketClient.cpp: SocketClient(37) > Client created
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: mainloop(227) > Got incoming connection
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-CLIENT(14756): SocketStream.h: SocketStream(31) > Created
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(253) > Starting connection thread
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-CLIENT(14756): SocketConnection.h: SocketConnection(44) > Created
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketStream.h: SocketStream(31) > Created
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketConnection.h: SocketConnection(44) > Created
10-14 14:43:03.910+0200 I/PRIVACY-MANAGER-CLIENT(14756): SocketClient.cpp: connect(62) > Client connected
10-14 14:43:03.915+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(304) > Calling service
10-14 14:43:03.915+0200 I/PRIVACY-MANAGER-CLIENT(14756): SocketClient.cpp: disconnect(72) > Client disconnected
10-14 14:43:03.925+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(307) > Removing client
10-14 14:43:03.925+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(311) > Call served
10-14 14:43:03.925+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(262) > Client serviced
10-14 14:43:03.925+0200 E/PKGMGR_CERT(14756): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-14 14:43:03.930+0200 E/PKGMGR_CERT(14756): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-14 14:43:03.950+0200 E/PKGMGR_CERT(14756): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-14 14:43:04.010+0200 E/rpm-installer(14756): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-14 14:43:04.015+0200 E/PKGMGR_OBSERVER(14757): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[147570002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-14 14:43:04.020+0200 E/PKGMGR_OBSERVER(14757): pkg_observer.c: main(620) > OBSERVER end
10-14 14:43:04.025+0200 E/APPS    ( 1063): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-14 14:43:04.025+0200 E/APPS    ( 1063): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-14 14:43:04.030+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 14:43:04.030+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14757]
10-14 14:43:04.045+0200 E/STARTER (  705): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-14 14:43:04.050+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-14 14:43:04.110+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-14 14:43:04.110+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 14:43:04.110+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 14:43:04.110+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 14:43:04.725+0200 E/rpm-installer(14756): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 14:43:04.725+0200 E/rpm-installer(14756): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 14:43:04.725+0200 E/rpm-installer(14756): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 14:43:04.745+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14756]
10-14 14:43:04.800+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/14756/oom_score_adj failed
10-14 14:43:04.800+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 14756
10-14 14:43:05.645+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 14:43:05.645+0200 E/PKGMGR_SERVER(14755): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 14:43:06.545+0200 E/PKGMGR  (14814): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-14 14:43:06.765+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: main(2167) > package manager server start
10-14 14:43:06.875+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_494092566], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_494092566' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[L3ZYMExmH+q4Mwx73183/UkDW0I=], backend_flag=[0]
10-14 14:43:06.880+0200 E/PKGMGR  (14816): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-14 14:43:06.885+0200 E/PKGMGR_SERVER(14817): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-14 14:43:06.885+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 14:43:06.890+0200 E/PKGMGR  (14814): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[148140002]
10-14 14:43:06.895+0200 E/PKGMGR_SERVER(14818): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 14:43:06.955+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: main(601) > OBSERVER start
10-14 14:43:06.985+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 14:43:06.985+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 14:43:06.985+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 14:43:07.100+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-14 14:43:07.110+0200 E/rpm-installer(14817): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-14 14:43:07.110+0200 E/rpm-installer(14817): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-14 14:43:07.115+0200 E/rpm-installer(14817): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-14 14:43:07.115+0200 E/rpm-installer(14817): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-14 14:43:07.115+0200 E/rpm-installer(14817): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-14 14:43:07.250+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[148180002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-14 14:43:07.260+0200 E/APPS    ( 1063): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-14 14:43:07.260+0200 E/APPS    ( 1063): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-14 14:43:07.290+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-14 14:43:07.300+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[148180002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 14:43:07.330+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-14 14:43:07.355+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 14:43:07.475+0200 W/CERT_SVC(14817): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 14:43:07.500+0200 E/rpm-installer(14817): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-14 14:43:07.505+0200 E/rpm-installer(14817): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-14 14:43:07.505+0200 E/rpm-installer(14817): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-14 14:43:07.505+0200 E/rpm-installer(14817): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-14 14:43:07.560+0200 E/PKGMGR_PARSER(14817): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-14 14:43:07.565+0200 E/PKGMGR_PARSER(14817): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 14:43:07.585+0200 E/PKGMGR_PARSER(14817): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-14 14:43:07.650+0200 I/PRIVACY-MANAGER-CLIENT(14817): SocketClient.cpp: SocketClient(37) > Client created
10-14 14:43:07.745+0200 I/efl-extension(14817): efl_extension.c: eext_mod_init(40) > Init
10-14 14:43:07.745+0200 I/efl-extension(14817): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 61
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 61
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-14 14:43:07.830+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-14 14:43:07.850+0200 E/PKGMGR_CERT(14817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-14 14:43:07.855+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[148180002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-14 14:43:07.910+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 14:43:07.910+0200 E/rpm-installer(14817): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-14 14:43:07.920+0200 E/rpm-installer(14817): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-14 14:43:07.935+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 14543 pgid = 14543
10-14 14:43:07.970+0200 E/rpm-installer(14817): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-14 14:43:07.975+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[148180002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-14 14:43:08.040+0200 E/rpm-installer(14817): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-14 14:43:08.070+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14543
10-14 14:43:08.080+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.968
10-14 14:43:08.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 14:43:08.145+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:43:08.145+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 14392 pgid = -1
10-14 14:43:08.145+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 14:43:08.155+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14392
10-14 14:43:08.165+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.969
10-14 14:43:08.500+0200 E/EFL     (14827): elementary<14827> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:43:08.500+0200 E/EFL     (14827): elementary<14827> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:43:08.550+0200 E/EFL     (14827): elementary<14827> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:43:08.560+0200 E/EFL     (14827): elementary<14827> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:43:08.610+0200 E/EFL     (14827): elementary<14827> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:43:08.615+0200 E/EFL     (14827): elementary<14827> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:43:08.615+0200 E/EFL     (14827): elementary<14827> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:43:08.615+0200 E/EFL     (14827): elementary<14827> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:43:08.615+0200 E/EFL     (14827): elementary<14827> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:43:08.630+0200 E/EFL     (14827): elementary<14827> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:43:08.635+0200 E/EFL     (14827): elementary<14827> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:43:08.635+0200 E/EFL     (14827): elementary<14827> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:43:08.645+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-14 14:43:08.670+0200 E/EFL     (14827): elementary<14827> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:43:08.680+0200 E/EFL     (14827): elementary<14827> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:43:08.680+0200 E/EFL     (14827): elementary<14827> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:43:08.680+0200 E/EFL     (14827): elementary<14827> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:43:08.680+0200 E/EFL     (14827): elementary<14827> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:43:08.680+0200 E/EFL     (14827): elementary<14827> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:43:08.680+0200 E/EFL     (14827): elementary<14827> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:43:08.680+0200 I/AUL_PAD (14827): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:43:08.990+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[148180002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-14 14:43:09.005+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-14 14:43:09.005+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-14 14:43:09.055+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-14 14:43:09.090+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 14:43:09.090+0200 W/APPS    ( 1063): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-14 14:43:09.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-14 14:43:09.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 14:43:09.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 14:43:09.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 14:43:09.100+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-14 14:43:09.105+0200 E/WMS     (  499): wms_db.c: wms_db_package_event_insert_record(177) > 
10-14 14:43:09.120+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-14 14:43:09.140+0200 E/PKGMGR_INFO(  498): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-14 14:43:09.160+0200 E/STARTER (  705): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-14 14:43:09.180+0200 E/EFL     ( 1063): evas_main<1063> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e1f0a0 is not stable during recalc loop
10-14 14:43:09.180+0200 E/EFL     ( 1063): evas_main<1063> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e1f0a0 is not stable during recalc loop
10-14 14:43:09.180+0200 E/PKGMGR_INFO(14818): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-14 14:43:09.215+0200 E/PKGMGR_OBSERVER(14818): pkg_observer.c: main(620) > OBSERVER end
10-14 14:43:09.230+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 14:43:09.230+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14818]
10-14 14:43:09.305+0200 I/efl-extension(14828): efl_extension.c: eext_mod_init(40) > Init
10-14 14:43:09.350+0200 E/EFL     (14828): elementary<14828> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 14:43:09.350+0200 E/EFL     (14828): elementary<14828> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 14:43:09.375+0200 E/EFL     (14828): elementary<14828> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 14:43:09.380+0200 I/UXT     (14828): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:43:09.385+0200 E/EFL     (14828): elementary<14828> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 14:43:09.435+0200 E/EFL     (14828): elementary<14828> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 14:43:09.440+0200 E/EFL     (14828): elementary<14828> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 14:43:09.440+0200 E/EFL     (14828): elementary<14828> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 14:43:09.440+0200 E/EFL     (14828): elementary<14828> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 14:43:09.440+0200 E/EFL     (14828): elementary<14828> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 14:43:09.455+0200 E/EFL     (14828): elementary<14828> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 14:43:09.460+0200 E/EFL     (14828): elementary<14828> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 14:43:09.460+0200 E/EFL     (14828): elementary<14828> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 14:43:09.495+0200 E/EFL     (14828): elementary<14828> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 14:43:09.505+0200 E/EFL     (14828): elementary<14828> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 14:43:09.505+0200 E/EFL     (14828): elementary<14828> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 14:43:09.505+0200 E/EFL     (14828): elementary<14828> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 14:43:09.505+0200 E/EFL     (14828): elementary<14828> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 14:43:09.505+0200 E/EFL     (14828): elementary<14828> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 14:43:09.505+0200 E/EFL     (14828): elementary<14828> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 14:43:09.505+0200 I/AUL_PAD (14828): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 14:43:10.130+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 14:43:10.130+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 14:43:10.130+0200 E/rpm-installer(14817): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 14:43:10.160+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: sighandler(409) > child NORMAL exit [14817]
10-14 14:43:10.290+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/14817/oom_score_adj failed
10-14 14:43:10.290+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 14817
10-14 14:43:10.645+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 14:43:10.645+0200 E/PKGMGR_SERVER(14816): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 14:43:12.525+0200 W/AUL     (14893): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 14:43:12.530+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 14:43:12.550+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-14 14:43:12.570+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-14 14:43:12.570+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 14:43:12.570+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 14893
10-14 14:43:12.585+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-14 14:43:12.585+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 14:43:12.590+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 14:43:12.590+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 14:43:12.590+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 14:43:12.650+0200 I/efl-extension(14827): efl_extension.c: eext_mod_init(40) > Init
10-14 14:43:12.655+0200 I/UXT     (14827): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 14:43:12.660+0200 I/CAPI_APPFW_APPLICATION(14827): app_main.c: ui_app_main(704) > app_efl_main
10-14 14:43:12.665+0200 I/CAPI_APPFW_APPLICATION(14827): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 14:43:12.695+0200 W/AUL     (14893): launch.c: app_request_to_launchpad(282) > request cmd(0) result(14827)
10-14 14:43:12.715+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 14:43:13.210+0200 W/CRASH_MANAGER(14896): worker.c: worker_job(1205) > 1114827646174150798499
