S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 1439
Date: 2018-01-07 18:12:05+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1439, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x43d00010, r3   = 0x41765d51
r4   = 0xbe9e9504, r5   = 0x41441980
r6   = 0x00000249, r7   = 0xbe9e9440
r8   = 0xbe9e94d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbe9e9428
lr   = 0x41765d6d, pc   = 0x4176729c
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:    102960 KB
Buffers:     24548 KB
Cached:     149348 KB
VmPeak:      97008 KB
VmSize:      94444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18472 KB
VmRSS:       18468 KB
VmData:      38480 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25044 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1439 TID = 1439
1439 1502 1511 1512 

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
41452000 41473000 rw-p [heap]
41473000 41478000 r-xp /usr/lib/libappcore-common.so.1.1
41480000 41482000 r-xp /usr/lib/libiniparser.so.0
4148b000 41496000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
4149e000 414a2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414ab000 414ad000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414b6000 414bc000 r-xp /usr/lib/libappsvc.so.0.1.0
414c4000 414e8000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414f1000 415c0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415d6000 415e0000 r-xp /lib/libnss_files-2.13.so
41764000 41769000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41779000 417ab000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
417b4000 417b9000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417c1000 417c5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417ce000 417ef000 r-xp /usr/lib/libefl-extension.so.0.1.0
417f8000 41832000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4183b000 41854000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4185c000 41861000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41869000 41893000 r-xp /usr/lib/libsensor.so.1.9.6
4189c000 41954000 r-xp /usr/lib/libcairo.so.2.11200.14
4195f000 41962000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4196a000 41970000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41979000 41981000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41989000 41993000 r-xp /usr/lib/libsensord-shared.so
4199c000 419aa000 r-xp /usr/lib/libGLESv2.so.2.0
419b3000 419b4000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419bd000 419c3000 r-xp /usr/lib/libxcb-render.so.0.0.0
419cb000 419ce000 r-xp /usr/lib/libEGL.so.1.4
419d6000 419e3000 r-xp /usr/lib/libail.so.0.1.0
419ec000 41b29000 r-xp /usr/lib/libicui18n.so.51.1
41b39000 41c1d000 r-xp /usr/lib/libicuuc.so.51.1
431bb000 431d7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431e0000 431e7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431f0000 431f2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431fa000 43201000 r-xp /usr/lib/libminizip.so.1.0.0
43209000 432d3000 r-xp /usr/lib/libCOREGL.so.4.0
434e6000 43ce5000 rw-p [stack:1502]
43ce5000 43cf0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e00000 43e05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43e13000 43e1b000 r-xp /usr/lib/libdrm.so.2.4.0
43e23000 43e2a000 r-xp /usr/lib/libtbm.so.1.0.0
43e32000 43e34000 r-xp /usr/lib/libdri2.so.0.0.0
43fd7000 43fd8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fe1000 447e0000 rw-p [stack:1511]
447e1000 44fe0000 rw-p [stack:1512]
45950000 45951000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45959000 4595c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4596c000 45973000 r-xp /usr/lib/libfeedback.so.0.1.4
4597c000 4597d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45985000 45987000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
4598f000 45999000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
459a1000 459a8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
459b0000 459c6000 r-xp /usr/lib/libmmfsound.so.0.1.0
459d8000 459dd000 r-xp /usr/lib/libmmfsession.so.0.0.0
459e5000 459ef000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
459fb000 459ff000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45a08000 45a1d000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45a25000 45a86000 r-xp /usr/lib/libasound.so.2.0.0
45a90000 45a93000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a9b000 45ad3000 r-xp /usr/lib/libpulse.so.0.16.2
45ad4000 45b05000 r-xp /usr/lib/libmdm.so.1.1.86
45b0d000 45b12000 r-xp /usr/lib/libjson.so.0.0.1
45b1a000 45b62000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b63000 45baa000 r-xp /usr/lib/libsndfile.so.1.0.26
45bb6000 45bbe000 r-xp /usr/lib/libmdm-common.so.1.0.89
45bbf000 45be1000 r-xp /usr/lib/libvorbis.so.0.4.3
45be9000 45bed000 r-xp /usr/lib/libogg.so.0.7.1
45cad000 45cae000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
be9c9000 be9ea000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1439)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x4176729c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x329c
 1: app_terminate + 0x1c (0x41765d6d) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d6d
 2: (0x41440af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41765cff) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1cff
 6: bluetooth_screen + 0xe2 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: main + 0x77 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
7 18:11:38.865+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
01-07 18:11:38.865+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
01-07 18:11:38.870+0200 E/EFL     ( 1440): elementary<1440> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
01-07 18:11:38.890+0200 E/EFL     ( 1440): elementary<1440> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
01-07 18:11:38.890+0200 E/EFL     ( 1440): elementary<1440> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
01-07 18:11:38.890+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
01-07 18:11:38.935+0200 E/EFL     ( 1440): elementary<1440> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
01-07 18:11:38.960+0200 E/EFL     ( 1440): elementary<1440> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
01-07 18:11:38.960+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
01-07 18:11:38.960+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
01-07 18:11:38.960+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
01-07 18:11:38.960+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
01-07 18:11:38.960+0200 E/EFL     ( 1440): elementary<1440> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
01-07 18:11:38.960+0200 I/AUL_PAD ( 1440): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
01-07 18:11:39.550+0200 E/rpm-installer( 1429): rpm-appcore-intf.c: main(273) > ------------------------------------------------
01-07 18:11:39.550+0200 E/rpm-installer( 1429): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
01-07 18:11:39.550+0200 E/rpm-installer( 1429): rpm-appcore-intf.c: main(275) > ------------------------------------------------
01-07 18:11:39.590+0200 E/PKGMGR_SERVER( 1428): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1429]
01-07 18:11:39.600+0200 E/RESOURCED(  539): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/1429/oom_score_adj failed
01-07 18:11:39.600+0200 E/RESOURCED(  539): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 1429
01-07 18:11:39.650+0200 E/PKGMGR_SERVER( 1428): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
01-07 18:11:39.650+0200 E/PKGMGR_SERVER( 1428): pkgmgr-server.c: main(2221) > package manager server terminated.
01-07 18:11:40.605+0200 W/WATCH_CORE(  808): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
01-07 18:11:40.610+0200 W/STARTER (  724): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
01-07 18:11:40.610+0200 W/STARTER (  724): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
01-07 18:11:40.610+0200 E/STARTER (  724): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
01-07 18:11:40.610+0200 W/STARTER (  724): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
01-07 18:11:40.610+0200 W/STARTER (  724): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
01-07 18:11:40.615+0200 W/W_HOME  (  766): dbus.c: _dbus_message_recv_cb(204) > LCD off
01-07 18:11:40.615+0200 W/W_HOME  (  766): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
01-07 18:11:40.615+0200 W/W_HOME  (  766): gesture.c: _manual_render_disable_timer_del(155) > timer del
01-07 18:11:40.615+0200 W/W_HOME  (  766): gesture.c: _manual_render_enable(136) > 1
01-07 18:11:40.615+0200 W/W_HOME  (  766): event_manager.c: _lcd_off_cb(704) > lcd state: 0
01-07 18:11:40.615+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:40.850+0200 W/SHealth_Common(  827): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
01-07 18:11:40.870+0200 W/STARTER (  724): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
01-07 18:11:40.870+0200 W/STARTER (  724): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
01-07 18:11:40.870+0200 W/STARTER (  724): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
01-07 18:11:40.870+0200 W/STARTER (  724): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[1]
01-07 18:11:40.875+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: PAUSE State: RUNNING
01-07 18:11:40.875+0200 I/CAPI_APPFW_APPLICATION(  766): app_main.c: app_appcore_pause(202) > app_appcore_pause
01-07 18:11:40.875+0200 W/W_HOME  (  766): main.c: _appcore_pause_cb(696) > appcore pause
01-07 18:11:40.875+0200 W/W_HOME  (  766): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
01-07 18:11:40.875+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:40.875+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:40.875+0200 W/W_HOME  (  766): main.c: home_pause(766) > clock/widget paused
01-07 18:11:40.875+0200 W/W_HOME  (  766): clock_indicator.c: clock_indicator_pause(554) > 
01-07 18:11:40.880+0200 W/SHealth_Common( 1109): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
01-07 18:11:40.880+0200 W/SHealth_Service( 1109): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
01-07 18:11:40.880+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:11:40.885+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:11:40.930+0200 E/CAPI_APPFW_APP_CONTROL( 1085): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
01-07 18:11:40.930+0200 W/MUSIC_CONTROL_SERVICE( 1085): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1085]   [com.samsung.w-home]register msg port [false][0m
01-07 18:11:40.960+0200 W/WATCH_CORE(  808): appcore-watch.c: __widget_pause(1028) > widget_pause
01-07 18:11:40.970+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:11:40.970+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:11:40.975+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_pause_cb(298) > widget obj was paused
01-07 18:11:40.980+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:11:40.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:11:40.990+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_pause_cb(298) > widget obj was paused
01-07 18:11:40.995+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:11:40.995+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:11:41.000+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_pause_cb(298) > widget obj was paused
01-07 18:11:41.015+0200 W/SHealth_Common( 1109): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
01-07 18:11:41.015+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:11:41.015+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:11:41.015+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_pause_cb(298) > widget obj was paused
01-07 18:11:41.020+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __check_status_for_cgroup(145) > enter background group
01-07 18:11:41.020+0200 W/SHealth_Common( 1109): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
01-07 18:11:41.025+0200 W/SHealth_Common( 1109): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
01-07 18:11:41.025+0200 W/SHealth_Common( 1109): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
01-07 18:11:41.390+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: MEM_FLUSH State: PAUSED
01-07 18:11:42.860+0200 W/AUL     ( 1499): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
01-07 18:11:42.865+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
01-07 18:11:42.885+0200 I/AUL_AMD (  533): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
01-07 18:11:42.900+0200 I/AUL_AMD (  533): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
01-07 18:11:42.900+0200 E/AUL_AMD (  533): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
01-07 18:11:42.900+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 1499
01-07 18:11:42.915+0200 E/RESOURCED(  539): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
01-07 18:11:42.915+0200 E/RESOURCED(  539): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
01-07 18:11:42.915+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(2124) > pad pid(-5)
01-07 18:11:42.920+0200 W/AUL_PAD ( 1237): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
01-07 18:11:42.930+0200 W/AUL_PAD ( 1237): launchpad.c: __send_result_to_caller(272) > Check app launching
01-07 18:11:42.975+0200 I/efl-extension( 1439): efl_extension.c: eext_mod_init(40) > Init
01-07 18:11:42.990+0200 I/CAPI_APPFW_APPLICATION( 1439): app_main.c: ui_app_main(704) > app_efl_main
01-07 18:11:42.995+0200 I/CAPI_APPFW_APPLICATION( 1439): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
01-07 18:11:43.035+0200 W/AUL     ( 1499): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1439)
01-07 18:11:43.075+0200 E/RESOURCED(  539): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
01-07 18:11:43.125+0200 I/Bluetooth( 1439): [bt_initialize] success.
01-07 18:11:43.155+0200 I/Bluetooth( 1439): [bt_adapter_get_state] success.
01-07 18:11:43.235+0200 E/EFL     ( 1439): ecore_evas<1439> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
01-07 18:11:43.530+0200 I/APP_CORE( 1439): appcore-efl.c: __do_app(429) > [APP 1439] Event: RESET State: CREATED
01-07 18:11:43.530+0200 I/CAPI_APPFW_APPLICATION( 1439): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
01-07 18:11:43.550+0200 I/APP_CORE( 1439): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
01-07 18:11:43.550+0200 I/APP_CORE( 1439): appcore-efl.c: __do_app(474) > [APP 1439] Initial Launching, call the resume_cb
01-07 18:11:43.550+0200 I/CAPI_APPFW_APPLICATION( 1439): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
01-07 18:11:43.570+0200 W/W_HOME  (  766): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
01-07 18:11:43.570+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:43.570+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:43.575+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:43.600+0200 W/APP_CORE( 1439): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
01-07 18:11:43.735+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:43.735+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:43.735+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:43.760+0200 W/W_HOME  (  766): event_manager.c: _window_visibility_cb(453) > Window [0x2200003] is now visible(1)
01-07 18:11:43.760+0200 W/W_HOME  (  766): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
01-07 18:11:43.760+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:11:43.760+0200 W/W_HOME  (  766): main.c: _window_visibility_cb(1211) > Window [0x2200003] is now visible(1)
01-07 18:11:43.770+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: PAUSE State: PAUSED
01-07 18:11:43.775+0200 I/APP_CORE(  766): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
01-07 18:11:43.775+0200 W/wnotib  (  766): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
01-07 18:11:43.775+0200 I/APP_CORE( 1439): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
01-07 18:11:43.780+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-07 18:11:43.780+0200 W/AUL_AMD (  533): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
01-07 18:11:43.900+0200 E/EFL     ( 1439): elementary<1439> elc_naviframe.c:1211 _on_item_show_finished() item show finished
01-07 18:11:43.900+0200 E/EFL     ( 1439): elementary<1439> elc_naviframe.c:1211 _on_item_show_finished() item show finished
01-07 18:11:43.900+0200 E/EFL     ( 1439): elementary<1439> elc_naviframe.c:1211 _on_item_show_finished() item show finished
01-07 18:11:44.020+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
01-07 18:11:44.175+0200 E/RESOURCED(  539): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.151
01-07 18:11:44.240+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 14
01-07 18:11:44.250+0200 W/AUL_AMD (  533): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1439
01-07 18:11:44.250+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 14
01-07 18:11:44.260+0200 W/AUL_AMD (  533): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1439
01-07 18:11:44.265+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 12
01-07 18:11:44.265+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 12
01-07 18:11:44.340+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:558 elm_quicklaunch_init() eet_init done.
01-07 18:11:44.340+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
01-07 18:11:44.365+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
01-07 18:11:44.365+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
01-07 18:11:44.410+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
01-07 18:11:44.410+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
01-07 18:11:44.415+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
01-07 18:11:44.415+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
01-07 18:11:44.415+0200 E/EFL     ( 1516): elementary<1516> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
01-07 18:11:44.430+0200 E/EFL     ( 1516): elementary<1516> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
01-07 18:11:44.430+0200 E/EFL     ( 1516): elementary<1516> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
01-07 18:11:44.430+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
01-07 18:11:44.465+0200 E/EFL     ( 1516): elementary<1516> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
01-07 18:11:44.470+0200 E/EFL     ( 1516): elementary<1516> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
01-07 18:11:44.470+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
01-07 18:11:44.470+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
01-07 18:11:44.470+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
01-07 18:11:44.470+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
01-07 18:11:44.470+0200 E/EFL     ( 1516): elementary<1516> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
01-07 18:11:44.470+0200 I/AUL_PAD ( 1516): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
01-07 18:11:44.505+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:45.510+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:45.890+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: MEM_FLUSH State: PAUSED
01-07 18:11:46.515+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:47.510+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:48.520+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:49.515+0200 I/INFO_TAG( 1439): SENSOR_EVENT HEART RATE < 40 : 0
01-07 18:11:50.515+0200 E/EFL     ( 1439): elementary<1439> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
01-07 18:11:50.555+0200 E/EFL     ( 1439): elementary<1439> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
01-07 18:11:50.930+0200 E/EFL     ( 1439): elementary<1439> elc_naviframe.c:1211 _on_item_show_finished() item show finished
01-07 18:12:03.535+0200 W/WATCH_CORE(  808): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
01-07 18:12:03.535+0200 I/WATCH_CORE(  808): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
01-07 18:12:03.535+0200 I/CAPI_WATCH_APPLICATION(  808): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-07 18:12:03.540+0200 W/W_HOME  (  766): dbus.c: _dbus_message_recv_cb(186) > LCD on
01-07 18:12:03.540+0200 W/W_HOME  (  766): gesture.c: _manual_render_disable_timer_set(165) > timer set
01-07 18:12:03.540+0200 W/W_HOME  (  766): gesture.c: _manual_render_disable_timer_del(155) > timer del
01-07 18:12:03.545+0200 W/W_HOME  (  766): gesture.c: _apps_status_get(126) > apps status:0
01-07 18:12:03.545+0200 W/W_HOME  (  766): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:22800
01-07 18:12:03.545+0200 W/W_HOME  (  766): gesture.c: _manual_render_schedule(212) > schedule, manual render
01-07 18:12:03.545+0200 W/W_HOME  (  766): event_manager.c: _lcd_on_cb(696) > lcd state: 1
01-07 18:12:03.545+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:03.550+0200 W/STARTER (  724): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [22800]ms
01-07 18:12:03.550+0200 W/STARTER (  724): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
01-07 18:12:03.580+0200 I/APP_CORE( 1439): appcore-efl.c: __do_app(429) > [APP 1439] Event: RESUME State: RUNNING
01-07 18:12:03.605+0200 W/W_HOME  (  766): gesture.c: _widget_updated_cb(194) > widget updated
01-07 18:12:03.605+0200 W/W_HOME  (  766): gesture.c: _manual_render_disable_timer_del(155) > timer del
01-07 18:12:03.605+0200 W/W_HOME  (  766): gesture.c: _manual_render(180) > 
01-07 18:12:03.625+0200 I/MALI    (  766): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f2f8] swap changed from sync to async
01-07 18:12:03.685+0200 W/W_HOME  (  766): gesture.c: _manual_render(180) > 
01-07 18:12:03.725+0200 W/SHealth_Common(  827): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
01-07 18:12:03.730+0200 W/SHealth_Common( 1109): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
01-07 18:12:03.730+0200 W/SHealth_Service( 1109): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
01-07 18:12:03.730+0200 W/W_HOME  (  766): gesture.c: _manual_render_enable(136) > 0
01-07 18:12:03.760+0200 W/STARTER (  724): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
01-07 18:12:03.760+0200 W/STARTER (  724): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: preference_get_boolean(1173) > preference_get_boolean(1109) : test_healthy_pace error
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: preference_get_double(1214) > preference_get_double(1109) : pedometer_inactive_period error
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: preference_get_double(1214) > preference_get_double(1109) : inactive_10min_precaution_millisec error
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
01-07 18:12:03.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1109): preference.c: preference_get_double(1214) > preference_get_double(1109) : inactive_before_10min_precaution_millisec error
01-07 18:12:05.005+0200 E/EFL     ( 1439): ecore_x<1439> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=92352 button=1
01-07 18:12:05.070+0200 E/EFL     ( 1439): ecore_x<1439> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=92421 button=1
01-07 18:12:05.245+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 22
01-07 18:12:05.245+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(916) > app status : 4
01-07 18:12:05.300+0200 E/APP_CORE( 1439): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
01-07 18:12:05.300+0200 I/APP_CORE( 1439): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
01-07 18:12:05.300+0200 I/APP_CORE( 1439): appcore-efl.c: __after_loop(1089) > [APP 1439] PAUSE before termination
01-07 18:12:05.300+0200 I/CAPI_APPFW_APPLICATION( 1439): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
01-07 18:12:05.330+0200 I/CAPI_APPFW_APPLICATION( 1439): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
01-07 18:12:05.690+0200 W/AUL_PAD ( 1237): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1439 pgid = 1439
01-07 18:12:05.755+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
01-07 18:12:05.755+0200 W/AUL_AMD (  533): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
01-07 18:12:05.830+0200 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
01-07 18:12:05.835+0200 W/W_HOME  (  766): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
01-07 18:12:05.835+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.835+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.870+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.895+0200 W/W_HOME  (  766): event_manager.c: _window_visibility_cb(453) > Window [0x2200003] is now visible(0)
01-07 18:12:05.895+0200 W/W_HOME  (  766): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
01-07 18:12:05.895+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.895+0200 W/W_HOME  (  766): main.c: _window_visibility_cb(1211) > Window [0x2200003] is now visible(0)
01-07 18:12:05.895+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: RESUME State: PAUSED
01-07 18:12:05.895+0200 I/CAPI_APPFW_APPLICATION(  766): app_main.c: app_appcore_resume(223) > app_appcore_resume
01-07 18:12:05.895+0200 W/W_HOME  (  766): main.c: _appcore_resume_cb(687) > appcore resume
01-07 18:12:05.895+0200 W/W_HOME  (  766): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
01-07 18:12:05.895+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.895+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.895+0200 W/W_HOME  (  766): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
01-07 18:12:05.895+0200 W/W_HOME  (  766): main.c: home_resume(739) > clock/widget resumed
01-07 18:12:05.895+0200 W/W_HOME  (  766): clock_indicator.c: clock_indicator_resume(537) > 
01-07 18:12:05.900+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
01-07 18:12:05.955+0200 W/wnotib  (  766): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
01-07 18:12:05.955+0200 W/WATCH_CORE(  808): appcore-watch.c: __widget_resume(1039) > widget_resume
01-07 18:12:05.960+0200 I/CAPI_WATCH_APPLICATION(  808): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-07 18:12:05.960+0200 W/WATCH_CORE(  808): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
01-07 18:12:05.960+0200 I/WATCH_CORE(  808): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
01-07 18:12:05.960+0200 I/CAPI_WATCH_APPLICATION(  808): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
01-07 18:12:06.035+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-07 18:12:06.035+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-07 18:12:06.035+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-07 18:12:06.035+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-07 18:12:06.040+0200 W/SHealthWidget(  827): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>77</color> bpm</color>][0;m
01-07 18:12:06.040+0200 W/SHealth_Common(  827): HeartRateStorage.cpp: ExecuteSelectQuery(152) > [1;40;33mNo record[0;m
01-07 18:12:06.040+0200 W/SHealth_Common(  827): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
01-07 18:12:06.040+0200 W/SHealth_Common(  827): HeartRateStorage.cpp: ExecuteSelectQuery(152) > [1;40;33mNo record[0;m
01-07 18:12:06.040+0200 W/SHealth_Common(  827): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
01-07 18:12:06.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  827): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
01-07 18:12:06.060+0200 W/WSLib   (  827): ICUStringUtil.cpp: GetStrFromIcu(138) > [1;35mts:1513280190733,000000, pattern:[d MMM][0;m
01-07 18:12:06.060+0200 E/WSLib   (  827): ICUStringUtil.cpp: GetStrFromIcu(161) > [0;40;31mlocale fr_FR[0;m
01-07 18:12:06.060+0200 W/WSLib   (  827): ICUStringUtil.cpp: GetStrFromIcu(186) > [1;35mformattedString:[14 déc.][0;m
01-07 18:12:06.070+0200 W/AUL_PAD ( 1237): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
01-07 18:12:06.070+0200 I/AUL_AMD (  533): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1439
01-07 18:12:06.075+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:12:06.075+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:12:06.080+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:12:06.080+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:12:06.080+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
01-07 18:12:06.080+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
01-07 18:12:06.090+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:12:06.090+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:12:06.090+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
01-07 18:12:06.095+0200 E/RESOURCED(  539): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.153
01-07 18:12:06.120+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:12:06.120+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:12:06.120+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
01-07 18:12:06.125+0200 W/SHealth_Common(  827): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
01-07 18:12:06.125+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
01-07 18:12:06.130+0200 I/CAPI_WIDGET_APPLICATION(  827): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
01-07 18:12:06.170+0200 W/CRASH_MANAGER( 1545): worker.c: worker_job(1205) > 1101439646174151534152
