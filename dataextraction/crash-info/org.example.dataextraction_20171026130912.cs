S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18520
Date: 2017-10-26 13:09:12+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x41723668, r1   = 0x00000001
r2   = 0x4059d250, r3   = 0xf1a14a00
r4   = 0xbec944d4, r5   = 0x4144ad30
r6   = 0x00000233, r7   = 0xbec94400
r8   = 0xbec944a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e5a00, sp   = 0xbec943d0
lr   = 0x404e5ab4, pc   = 0x414e6754
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     18144 KB
Buffers:     44128 KB
Cached:     174624 KB
VmPeak:      65876 KB
VmSize:      65872 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11956 KB
VmRSS:       11952 KB
VmData:      12624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18520 TID = 18520
18520 18556 

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
414d0000 414da000 r-xp /lib/libnss_files-2.13.so
414e3000 414e8000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
414f9000 4152b000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41534000 41538000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41541000 41549000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4154a000 4154f000 rw-p [heap]
4154f000 41570000 rw-p [heap]
41570000 4163f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
417d0000 417f1000 r-xp /usr/lib/libefl-extension.so.0.1.0
417fa000 41834000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4183d000 41856000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4185e000 41863000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4186b000 41895000 r-xp /usr/lib/libsensor.so.1.9.6
4189e000 418b0000 r-xp /usr/lib/libefl-assist.so.0.1.0
418b8000 41970000 r-xp /usr/lib/libcairo.so.2.11200.14
4197b000 4197e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41986000 4198c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41995000 4199d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
419a5000 419af000 r-xp /usr/lib/libsensord-shared.so
419b8000 419ca000 r-xp /usr/lib/libtts.so
419d2000 419f4000 r-xp /usr/lib/libui-extension.so.0.1.0
419fd000 41a04000 r-xp /usr/lib/libtbm.so.1.0.0
41a0c000 41a1a000 r-xp /usr/lib/libGLESv2.so.2.0
41a23000 41a24000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a2d000 41a33000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a3b000 41a3e000 r-xp /usr/lib/libEGL.so.1.4
41a46000 41a53000 r-xp /usr/lib/libail.so.0.1.0
41a5c000 41b99000 r-xp /usr/lib/libicui18n.so.51.1
41ba9000 41c8d000 r-xp /usr/lib/libicuuc.so.51.1
4322b000 43247000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43250000 43253000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4325b000 4325c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
43265000 4326d000 r-xp /usr/lib/libdrm.so.2.4.0
43275000 43277000 r-xp /usr/lib/libdri2.so.0.0.0
4327f000 43286000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4328f000 43291000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43299000 432a0000 r-xp /usr/lib/libminizip.so.1.0.0
432a8000 432ae000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
432b6000 432bb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
432c3000 432e4000 r-xp /usr/lib/libexif.so.12.3.3
432f7000 432f9000 r-xp /usr/lib/libttrace.so.1.1
43301000 43306000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4330e000 433d8000 r-xp /usr/lib/libCOREGL.so.4.0
435eb000 43e00000 rw-p [stack:18556]
bec74000 bec95000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18520)
Call Stack Count: 9
 0: start_bt_server + 0x13 (0x414e6754) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3754
 1: app_create + 0x38 (0x414e5039) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2039
 2: (0x414409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x414e4f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
 6: (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: bluetooth_screen + 0xd7 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
ED
10-26 13:09:16.655+0200 E/EFL     (18562): elementary<18562> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:16.700+0200 E/EFL     (18562): elementary<18562> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:16.790+0200 E/EFL     (18562): elementary<18562> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:16.795+0200 E/EFL     (18562): elementary<18562> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:16.860+0200 E/EFL     (18562): elementary<18562> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:16.865+0200 E/EFL     (18562): elementary<18562> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:16.865+0200 E/EFL     (18562): elementary<18562> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:16.870+0200 E/EFL     (18562): elementary<18562> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:16.870+0200 E/EFL     (18562): elementary<18562> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:16.895+0200 E/EFL     (18562): elementary<18562> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:16.900+0200 E/EFL     (18562): elementary<18562> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:16.900+0200 E/EFL     (18562): elementary<18562> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:16.950+0200 E/EFL     (18562): elementary<18562> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:16.965+0200 E/EFL     (18562): elementary<18562> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:16.970+0200 E/EFL     (18562): elementary<18562> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:16.975+0200 I/AUL_PAD (18562): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:09:17.010+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185236461741509016147
10-26 13:09:18.465+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:09:19.585+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185326461741509016148
10-26 13:09:20.605+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:09:26.995+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:09:26.995+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:09:26.995+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:09:27.000+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
10-26 13:09:27.000+0200 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-26 13:09:27.035+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-26 13:09:27.035+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-26 13:09:27.035+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:09:27.040+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-26 13:09:27.040+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-26 13:09:27.040+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:09:27.040+0200 W/W_HOME  (  769): gesture.c: _apps_status_get(126) > apps status:0
10-26 13:09:27.040+0200 W/W_HOME  (  769): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:1 info->offtime:11695
10-26 13:09:27.040+0200 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-26 13:09:27.040+0200 W/W_HOME  (  769): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-26 13:09:27.040+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:27.045+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [11695]ms
10-26 13:09:27.045+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:09:27.055+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESUME State: PAUSED
10-26 13:09:27.055+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 13:09:27.055+0200 W/W_HOME  (  769): main.c: _appcore_resume_cb(687) > appcore resume
10-26 13:09:27.055+0200 W/W_HOME  (  769): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-26 13:09:27.055+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:27.060+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:27.060+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:27.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:09:27.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(748102704)
10-26 13:09:27.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:27.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:45:00 (UTC).
10-26 13:09:27.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:27.105+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[748102704] is removed.
10-26 13:09:27.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 13:09:27.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:27.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 13:09:27.185+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 13:09:27.190+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:27.195+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 13:09:27.195+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 13:09:27.195+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:27.200+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 13:09:27.215+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 13:09:27.220+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:27.220+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 13:09:27.240+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
10-26 13:09:27.240+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 0
10-26 13:09:27.240+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 13:09:27.250+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:09:27.275+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:09:27.275+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:09:27.275+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:09:27.300+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
10-26 13:09:27.300+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:09:27.790+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7562141 button=1
10-26 13:09:27.790+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:27.790+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:27.790+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:09:27.805+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7562154 button=1
10-26 13:09:27.805+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:09:27.810+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:09:27.810+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:09:27.810+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:09:27.810+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:27.815+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:09:27.815+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:09:27.825+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:09:27.825+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:09:27.825+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:09:27.830+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:09:27.830+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:09:27.885+0200 I/efl-extension(18562): efl_extension.c: eext_mod_init(40) > Init
10-26 13:09:27.885+0200 I/UXT     (18562): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:09:27.890+0200 I/CAPI_APPFW_APPLICATION(18562): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:09:27.895+0200 I/CAPI_APPFW_APPLICATION(18562): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:27.925+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:27.925+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18562)
10-26 13:09:27.925+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:09:27.930+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:09:27.985+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7562337 button=1
10-26 13:09:28.010+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7562363 button=1
10-26 13:09:28.040+0200 I/Bluetooth(18562): [bt_initialize] success.
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:28.060+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.065+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:09:28.065+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [true][0m
10-26 13:09:28.065+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:28.070+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
10-26 13:09:28.090+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:09:28.100+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:28.135+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.135+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:09:28.135+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:09:28.140+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:28.145+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:28.150+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.150+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:09:28.150+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:09:28.160+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:09:28.170+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7562521 button=1
10-26 13:09:28.175+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:09:28.175+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:28.175+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:28.195+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7562547 button=1
10-26 13:09:28.340+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7562692 button=1
10-26 13:09:28.365+0200 E/EFL     (  564): ecore_x<564> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7562718 button=1
10-26 13:09:28.790+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 13:09:28.790+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 13:09:28.790+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:09:28.810+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 13:09:28.810+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 13:09:28.810+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 13:09:28.810+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:09:28.810+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 13:09:28.810+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 13:09:28.810+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:28.810+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-26 13:09:28.810+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 13:09:28.810+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 13:09:28.810+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 13:09:28.810+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 13:09:28.955+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18562 pgid = 18562
10-26 13:09:28.965+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.537
10-26 13:09:29.005+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:09:29.015+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.538
10-26 13:09:29.035+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:09:29.035+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:09:29.035+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:29.035+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:09:29.035+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:09:29.035+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:29.045+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:09:29.045+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:09:29.045+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:09:29.055+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18562
10-26 13:09:29.075+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-26 13:09:29.075+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:09:29.075+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:09:29.075+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:09:29.075+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:09:29.075+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:09:29.075+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:29.080+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 13:09:29.080+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 13:09:29.080+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 13:09:49), repeat(1), interval(20), type(-1073741822)
10-26 13:09:29.080+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:29.080+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:29.080+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:29.100+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:09:29.110+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:09:29.125+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:09:29.130+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:29.130+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:29.135+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:09:29.140+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:09:29.140+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 790820476, next duetime: 1509016189
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(790820476)
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509016189)
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:09:49 (UTC).
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:29.590+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:09:29.755+0200 E/EFL     (18667): elementary<18667> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:29.755+0200 E/EFL     (18667): elementary<18667> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:29.815+0200 E/EFL     (18667): elementary<18667> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:29.815+0200 E/EFL     (18667): elementary<18667> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:29.910+0200 E/EFL     (18667): elementary<18667> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:29.910+0200 E/EFL     (18667): elementary<18667> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:29.950+0200 E/EFL     (18667): elementary<18667> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:29.985+0200 E/EFL     (18667): elementary<18667> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:30.000+0200 E/EFL     (18667): elementary<18667> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:30.280+0200 E/EFL     (18667): elementary<18667> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:30.325+0200 E/EFL     (18667): elementary<18667> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:30.325+0200 E/EFL     (18667): elementary<18667> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:30.565+0200 E/EFL     (18667): elementary<18667> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:30.605+0200 E/EFL     (18667): elementary<18667> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:30.610+0200 E/EFL     (18667): elementary<18667> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:30.620+0200 E/EFL     (18667): elementary<18667> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:30.625+0200 E/EFL     (18667): elementary<18667> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:30.625+0200 E/EFL     (18667): elementary<18667> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:30.630+0200 E/EFL     (18667): elementary<18667> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:30.630+0200 I/AUL_PAD (18667): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:09:34.100+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:09:35.515+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185416461741509016150
10-26 13:09:37.370+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185486461741509016151
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:46.050+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:46.060+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>64</color> bpm</color>][0;m
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:48.995+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 13:09:49.010+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[790820476] is expired.
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 790820476, next duetime: 1509016209
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:49.035+0200 E/RESOURCED(  566): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 732
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:10:09 (UTC).
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 13:09:49.040+0200 E/ALARM_MANAGER(  732): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [790820476]
10-26 13:09:49.040+0200 W/STARTER (  732): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [790820476]
10-26 13:09:49.050+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 13:09:49.055+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 13:09:49.060+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:49.060+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 13:09:49.070+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 13:09:49.075+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(769), cmd(0)
10-26 13:09:49.075+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: PAUSED
10-26 13:09:49.075+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 13:09:49.075+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : show_clock
10-26 13:09:49.075+0200 W/W_HOME  (  769): main.c: _app_control(1746) > Show clock operation
10-26 13:09:49.075+0200 W/W_HOME  (  769): gesture.c: _clock_show(245) > clock show
10-26 13:09:49.075+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 13:09:49.080+0200 W/W_HOME  (  769): gesture.c: _clock_show(260) > home raise
10-26 13:09:49.080+0200 E/W_HOME  (  769): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(790820476)
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:45:00 (UTC).
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[790820476] is removed.
10-26 13:09:49.085+0200 W/W_HOME  (  769): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-26 13:09:49.085+0200 W/W_HOME  (  769): gesture.c: _clock_show(263) > home raise done
10-26 13:09:49.085+0200 W/W_HOME  (  769): gesture.c: _clock_show(270) > show clock
10-26 13:09:49.090+0200 W/W_HOME  (  769): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-26 13:09:49.090+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 13:09:49.105+0200 W/W_HOME  (  769): move.c: _scroller_down_done(494) > down signal done
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:49.110+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 1, scroll 0
10-26 13:09:49.115+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:49.115+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-26 13:09:49.115+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-26 13:09:49.115+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-26 13:09:49.120+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-26 13:09:49.130+0200 E/APPS    (  769): apps_main.c: apps_main_pause(602) >  paused already
10-26 13:09:50.075+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:09:50.075+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:09:53.970+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 1118520646174150901615
