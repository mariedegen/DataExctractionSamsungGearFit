S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 6486
Date: 2017-11-10 13:10:45+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6486, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xdae03300, r3   = 0xdae03300
r4   = 0x43e83b08, r5   = 0x43e37960
r6   = 0x41c3ca20, r7   = 0xbec832a8
r8   = 0x00000000, r9   = 0x43e6bff0
r10  = 0x43e67bb8, fp   = 0x00000001
ip   = 0x40088a5c, sp   = 0xbec83280
lr   = 0x41645b5d, pc   = 0x41644b66
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     81668 KB
Buffers:     32544 KB
Cached:     157784 KB
VmPeak:      97804 KB
VmSize:      96328 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19328 KB
VmRSS:       19324 KB
VmData:      40456 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25016 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6486 TID = 6486
6486 6556 6568 

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
4146a000 41475000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 41648000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41658000 4168a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41693000 41697000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
416a0000 416c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
416ca000 41704000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4170d000 41726000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4172e000 41733000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4173b000 41765000 r-xp /usr/lib/libsensor.so.1.9.6
4176e000 41826000 r-xp /usr/lib/libcairo.so.2.11200.14
41831000 41834000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4183c000 41842000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4184b000 41853000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4185b000 41865000 r-xp /usr/lib/libsensord-shared.so
4186e000 4187c000 r-xp /usr/lib/libGLESv2.so.2.0
41885000 41886000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4188f000 41895000 r-xp /usr/lib/libxcb-render.so.0.0.0
4189d000 418a0000 r-xp /usr/lib/libEGL.so.1.4
418a8000 418b5000 r-xp /usr/lib/libail.so.0.1.0
418be000 419fb000 r-xp /usr/lib/libicui18n.so.51.1
41a0b000 41aef000 r-xp /usr/lib/libicuuc.so.51.1
41b04000 41b20000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b29000 41b30000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41b39000 41b3b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41b46000 41b4a000 rw-p [heap]
41b4a000 41c61000 rw-p [heap]
431ea000 431f1000 r-xp /usr/lib/libminizip.so.1.0.0
431f9000 432c3000 r-xp /usr/lib/libCOREGL.so.4.0
434d6000 43cd5000 rw-p [stack:6556]
43cd5000 43ce0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ce9000 43cee000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43cf6000 43cf7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43e00000 43e08000 r-xp /usr/lib/libdrm.so.2.4.0
43e10000 43e17000 r-xp /usr/lib/libtbm.so.1.0.0
43e1f000 43e21000 r-xp /usr/lib/libdri2.so.0.0.0
43fc4000 43fc6000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44fcf000 458ce000 rw-p [stack:6568]
459e2000 459e3000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
459fe000 45a05000 r-xp /usr/lib/libfeedback.so.0.1.4
45a0e000 45a0f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a17000 45a19000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a21000 45a2b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a33000 45a3a000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a42000 45a58000 r-xp /usr/lib/libmmfsound.so.0.1.0
45a6a000 45a6f000 r-xp /usr/lib/libmmfsession.so.0.0.0
45a77000 45a81000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45a8d000 45a91000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45a9a000 45aaf000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45ab7000 45b18000 r-xp /usr/lib/libasound.so.2.0.0
45b22000 45b25000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b2d000 45b65000 r-xp /usr/lib/libpulse.so.0.16.2
45b66000 45b97000 r-xp /usr/lib/libmdm.so.1.1.86
45b9f000 45ba4000 r-xp /usr/lib/libjson.so.0.0.1
45bac000 45bf4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45bf5000 45c3c000 r-xp /usr/lib/libsndfile.so.1.0.26
45c48000 45c50000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c51000 45c73000 r-xp /usr/lib/libvorbis.so.0.4.3
45c7b000 45c7f000 r-xp /usr/lib/libogg.so.0.7.1
bec63000 bec84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6486)
Call Stack Count: 18
 0: app_create + 0x5d (0x41644b66) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b66
 1: clicked_redo_app + 0x24 (0x41644d13) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d13
 2: evas_object_smart_callback_call + 0x88 (0x4022e725) [/usr/lib/libevas.so.1] + 0x35725
 3: (0x40360ad9) [/usr/lib/libedje.so.1] + 0x45ad9
 4: (0x40364ac1) [/usr/lib/libedje.so.1] + 0x49ac1
 5: (0x40361431) [/usr/lib/libedje.so.1] + 0x46431
 6: (0x403617e3) [/usr/lib/libedje.so.1] + 0x467e3
 7: (0x4036191d) [/usr/lib/libedje.so.1] + 0x4691d
 8: (0x402f83f5) [/usr/lib/libecore.so.1] + 0xb3f5
 9: (0x402f5e53) [/usr/lib/libecore.so.1] + 0x8e53
10: (0x402f946b) [/usr/lib/libecore.so.1] + 0xc46b
11: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
13: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x66 (0x41644c3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
15: create_base_gui + 0x4a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
16: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
17: clicked_redo_app + 0x21 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
alth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:10:08.390+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:10:08.405+0200 W/W_HOME  (  765): gesture.c: _manual_render(180) > 
11-10 13:10:08.410+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
11-10 13:10:08.410+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:10:08.425+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 0
11-10 13:10:08.450+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:10:08.450+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : test_healthy_pace error
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:10:08.455+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:10:08.680+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:09.405+0200 E/EFL     ( 6401): ecore_x<6401> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1413763 button=1
11-10 13:10:09.450+0200 E/EFL     ( 6401): ecore_x<6401> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1413814 button=1
11-10 13:10:09.615+0200 E/RECORDING_TAG( 6401): sensor_listener_unset_event_cb error: -38010874
11-10 13:10:09.620+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:09.625+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:09.815+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:10.310+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 HEART RATE : 72
11-10 13:10:10.360+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 TAB VALUE : 72
11-10 13:10:11.310+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 HEART RATE : 71
11-10 13:10:11.345+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 TAB VALUE : 71
11-10 13:10:12.295+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 HEART RATE : 72
11-10 13:10:12.330+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 TAB VALUE : 72
11-10 13:10:12.665+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:10:13.315+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 HEART RATE : 71
11-10 13:10:13.345+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 TAB VALUE : 71
11-10 13:10:14.295+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 HEART RATE : 71
11-10 13:10:14.315+0200 I/INFO_TAG( 6401): SENSOR_EVENT2 TAB VALUE : 71
11-10 13:10:14.450+0200 E/EFL     ( 6401): ecore_x<6401> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1418816 button=1
11-10 13:10:14.475+0200 E/EFL     ( 6401): ecore_x<6401> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1418840 button=1
11-10 13:10:14.495+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:14.575+0200 I/Bluetooth( 6401): [bt_socket_create_rfcomm] success.
11-10 13:10:14.670+0200 I/BluetoothServer( 6401): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:10:14.710+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:15.070+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:20.935+0200 I/BluetoothServer( 6401): Callback: Connected.
11-10 13:10:20.935+0200 I/BluetoothServer( 6401): Callback: Socket of connection - 29.
11-10 13:10:20.935+0200 I/BluetoothServer( 6401): Callback: Role of connection - 1.
11-10 13:10:20.935+0200 I/BluetoothServer( 6401): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:10:20.940+0200 I/BluetoothServer( 6401): Sent: 'Ø9C671,000000 72,000000 71,000000 71,000000 0,000000 '
11-10 13:10:21.025+0200 E/Bluetooth( 6401): [bt_socket_send_data] unknown error code : 54.
11-10 13:10:21.025+0200 E/Bluetooth( 6401): [bt_socket_send_data] unknown error code : 3.
11-10 13:10:21.025+0200 I/BluetoothServer( 6401): All data sent
11-10 13:10:21.025+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:21.055+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:21.145+0200 I/BluetoothServer( 6401): Callback: Disconnected.
11-10 13:10:21.145+0200 I/BluetoothServer( 6401): Callback: Socket of disconnection - 29.
11-10 13:10:21.145+0200 I/BluetoothServer( 6401): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:10:21.430+0200 E/EFL     ( 6401): elementary<6401> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:22.559+0200 E/EFL     ( 6401): ecore_x<6401> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1426925 button=1
11-10 13:10:22.605+0200 E/EFL     ( 6401): ecore_x<6401> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1426970 button=1
11-10 13:10:22.605+0200 I/Bluetooth( 6401): [bt_initialize] success.
11-10 13:10:22.645+0200 I/Bluetooth( 6401): [bt_adapter_get_state] success.
11-10 13:10:22.985+0200 W/CRASH_MANAGER( 6536): worker.c: worker_job(1205) > 11064016461741510312222
11-10 13:10:22.995+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:10:22.995+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:10:23.040+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6401 pgid = 6401
11-10 13:10:23.080+0200 W/PROCESSMGR(  408): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
11-10 13:10:23.095+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
11-10 13:10:23.095+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.095+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.150+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.160+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
11-10 13:10:23.160+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
11-10 13:10:23.160+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.160+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
11-10 13:10:23.165+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESUME State: PAUSED
11-10 13:10:23.165+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_resume(223) > app_appcore_resume
11-10 13:10:23.165+0200 W/W_HOME  (  765): main.c: _appcore_resume_cb(687) > appcore resume
11-10 13:10:23.165+0200 W/W_HOME  (  765): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
11-10 13:10:23.165+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.175+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.175+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:23.175+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
11-10 13:10:23.180+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
11-10 13:10:23.180+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
11-10 13:10:23.180+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:10:23.240+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:10:23.245+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6401
11-10 13:10:23.260+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.361
11-10 13:10:23.545+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
11-10 13:10:24.175+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1428541 button=1
11-10 13:10:24.175+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:10:24.175+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:10:24.175+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:10:24.185+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:10:24.190+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.190+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:10:24.190+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [true][0m
11-10 13:10:24.210+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:10:24.215+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 765
11-10 13:10:24.230+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:10:24.235+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1428599 button=1
11-10 13:10:24.235+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-10 13:10:24.235+0200 E/APPS    (  765): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-10 13:10:24.235+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-10 13:10:24.235+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:10:24.240+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1779]   bundle_add_str() .. [0xffffffea][0m
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.240+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:10:24.240+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.245+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:10:24.245+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 765
11-10 13:10:24.245+0200 I/AUL_AMD (  504): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
11-10 13:10:24.255+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-10 13:10:24.260+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:10:24.260+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:10:24.260+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:10:24.260+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:10:24.260+0200 I/TIZEN_N_SOUND_MANAGER( 1779): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-10 13:10:24.260+0200 E/TIZEN_N_SOUND_MANAGER( 1779): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-10 13:10:24.260+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1779]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:10:24.260+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.300+0200 I/efl-extension( 6486): efl_extension.c: eext_mod_init(40) > Init
11-10 13:10:24.300+0200 I/CAPI_APPFW_APPLICATION( 6486): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:10:24.305+0200 I/CAPI_APPFW_APPLICATION( 6486): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:10:24.360+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(282) > request cmd(0) result(6486)
11-10 13:10:24.360+0200 E/W_HOME  (  765): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
11-10 13:10:24.360+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:10:24.375+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:10:24.375+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:10:24.375+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:10:24.375+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:10:24.405+0200 I/Bluetooth( 6486): [bt_initialize] success.
11-10 13:10:24.435+0200 I/Bluetooth( 6486): [bt_adapter_get_state] success.
11-10 13:10:24.500+0200 E/EFL     ( 6486): ecore_evas<6486> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:10:24.615+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:10:24.785+0200 I/APP_CORE( 6486): appcore-efl.c: __do_app(429) > [APP 6486] Event: RESET State: CREATED
11-10 13:10:24.785+0200 I/CAPI_APPFW_APPLICATION( 6486): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:10:24.800+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:10:24.800+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.800+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.800+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.815+0200 I/APP_CORE( 6486): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:10:24.820+0200 I/APP_CORE( 6486): appcore-efl.c: __do_app(474) > [APP 6486] Initial Launching, call the resume_cb
11-10 13:10:24.820+0200 I/CAPI_APPFW_APPLICATION( 6486): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:10:24.830+0200 W/APP_CORE( 6486): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
11-10 13:10:24.885+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:10:24.885+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:10:24.885+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.885+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:10:24.890+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:10:24.890+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:10:24.890+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:10:24.890+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:10:24.890+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.890+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.890+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:10:24.890+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:10:24.905+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:10:24.905+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:10:24.905+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:10:24.930+0200 I/APP_CORE( 6486): appcore-efl.c: __do_app(429) > [APP 6486] Event: RESUME State: RUNNING
11-10 13:10:24.975+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:24.980+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:10:24.985+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:25.165+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:25.165+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:25.230+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:10:25.340+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:25.410+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:10:25.475+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.365
11-10 13:10:25.510+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:10:25.520+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6486
11-10 13:10:25.520+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:10:25.635+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:10:25.635+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:10:25.670+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:10:25.670+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:10:25.730+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:10:25.730+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:10:25.740+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:10:25.740+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:10:25.740+0200 E/EFL     ( 6570): elementary<6570> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:10:25.765+0200 E/EFL     ( 6570): elementary<6570> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:10:25.770+0200 E/EFL     ( 6570): elementary<6570> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:10:25.770+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:10:25.820+0200 E/EFL     ( 6570): elementary<6570> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:10:25.830+0200 E/EFL     ( 6570): elementary<6570> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:10:25.830+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:10:25.835+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:10:25.835+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:10:25.835+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:10:25.835+0200 E/EFL     ( 6570): elementary<6570> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:10:25.835+0200 I/AUL_PAD ( 6570): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:10:25.915+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:10:25.925+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6486
11-10 13:10:25.925+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:10:26.080+0200 E/EFL     ( 6486): ecore_x<6486> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1430443 button=1
11-10 13:10:26.100+0200 E/EFL     ( 6486): ecore_x<6486> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1430466 button=1
11-10 13:10:26.255+0200 E/RECORDING_TAG( 6486): sensor_listener_unset_event_cb error: -38010874
11-10 13:10:26.265+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:26.265+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:26.310+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 67
11-10 13:10:26.325+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 67
11-10 13:10:26.460+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:27.300+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 67
11-10 13:10:27.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 67
11-10 13:10:28.300+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 67
11-10 13:10:28.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 67
11-10 13:10:29.300+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 67
11-10 13:10:29.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 67
11-10 13:10:29.780+0200 W/SHealth_Common( 1107): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:10:29.780+0200 W/SHealth_Common( 1107): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:10:29.785+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
11-10 13:10:29.805+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
11-10 13:10:29.840+0200 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-10 13:10:29.840+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: latest_hr_updated client list: [2:com.samsung.shealth.heartrate_widget (431101)]][0;m
11-10 13:10:29.900+0200 W/SHealthWidget(  837): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.heartrate_widget (431101), msgName: latest_hr_updated[0;m
11-10 13:10:29.900+0200 W/SHealth_Common(  837): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: latest_hr_updated[0;m
11-10 13:10:29.910+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:10:29.920+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
11-10 13:10:29.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:10:29.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:10:29.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:10:29.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:10:29.925+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:10:29.930+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:10:29.930+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:10:29.930+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:10:29.930+0200 W/SHealthWidget(  837): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>118</color> bpm</color>][0;m
11-10 13:10:29.945+0200 W/SHealth_Common(  837): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:10:29.950+0200 W/SHealth_Common(  837): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:10:29.950+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:10:29.950+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:10:29.950+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:10:29.950+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:10:29.960+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:10:29.960+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:10:29.960+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:10:29.960+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:10:29.965+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:10:29.965+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:10:29.965+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:10:29.965+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:10:29.985+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_update_cb(281) > received updating signal
11-10 13:10:30.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 68
11-10 13:10:30.310+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 68
11-10 13:10:31.310+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 68
11-10 13:10:31.315+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 68
11-10 13:10:32.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 68
11-10 13:10:32.310+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 68
11-10 13:10:33.310+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 68
11-10 13:10:33.310+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 68
11-10 13:10:34.290+0200 E/EFL     ( 6486): ecore_x<6486> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1438652 button=1
11-10 13:10:34.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 HEART RATE : 68
11-10 13:10:34.305+0200 I/INFO_TAG( 6486): SENSOR_EVENT2 TAB VALUE : 68
11-10 13:10:34.360+0200 E/EFL     ( 6486): ecore_x<6486> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1438725 button=1
11-10 13:10:34.375+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:34.445+0200 I/Bluetooth( 6486): [bt_socket_create_rfcomm] success.
11-10 13:10:34.540+0200 I/BluetoothServer( 6486): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:10:34.580+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:34.940+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:36.010+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:10:44.080+0200 I/BluetoothServer( 6486): Callback: Connected.
11-10 13:10:44.115+0200 I/BluetoothServer( 6486): Callback: Socket of connection - 27.
11-10 13:10:44.115+0200 I/BluetoothServer( 6486): Callback: Role of connection - 1.
11-10 13:10:44.115+0200 I/BluetoothServer( 6486): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:10:44.115+0200 I/BluetoothServer( 6486): Sent: 'xÜðC667,000000 67,000000 67,000000 68,000000 68,000000 68,000000 68,000000 68,000000 0,000000 '
11-10 13:10:44.175+0200 E/Bluetooth( 6486): [bt_socket_send_data] unknown error code : 94.
11-10 13:10:44.175+0200 E/Bluetooth( 6486): [bt_socket_send_data] unknown error code : 3.
11-10 13:10:44.180+0200 I/BluetoothServer( 6486): All data sent
11-10 13:10:44.180+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:10:44.205+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:10:44.370+0200 I/BluetoothServer( 6486): Callback: Disconnected.
11-10 13:10:44.370+0200 I/BluetoothServer( 6486): Callback: Socket of disconnection - 27.
11-10 13:10:44.370+0200 I/BluetoothServer( 6486): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:10:44.570+0200 E/EFL     ( 6486): elementary<6486> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:10:45.710+0200 E/EFL     ( 6486): ecore_x<6486> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1450077 button=1
11-10 13:10:45.780+0200 E/EFL     ( 6486): ecore_x<6486> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1450146 button=1
11-10 13:10:45.780+0200 I/Bluetooth( 6486): [bt_initialize] success.
11-10 13:10:45.820+0200 I/Bluetooth( 6486): [bt_adapter_get_state] success.
11-10 13:10:45.980+0200 W/CRASH_MANAGER( 6536): worker.c: worker_job(1205) > 1106486646174151031224
