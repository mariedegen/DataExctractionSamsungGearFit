S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2705
Date: 2017-12-07 19:11:48+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2705, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0x41744cf9
r4   = 0xbeab6504, r5   = 0x41541980
r6   = 0x00000249, r7   = 0xbeab6440
r8   = 0xbeab64d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbeab6428
lr   = 0x41744d15, pc   = 0x41746238
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     93480 KB
Buffers:     25692 KB
Cached:     153052 KB
VmPeak:      96656 KB
VmSize:      96284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18044 KB
VmRSS:       18040 KB
VmData:      40372 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25024 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2705 TID = 2705
2705 2797 2805 2806 

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
435b8000 43db7000 rw-p [stack:2797]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
440af000 448ae000 rw-p [stack:2805]
448af000 450ae000 rw-p [stack:2806]
4590a000 4590d000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45915000 45916000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45931000 45938000 r-xp /usr/lib/libfeedback.so.0.1.4
45941000 45942000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4594a000 4594c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45954000 4595e000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45966000 45969000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a71000 45a72000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45a7a000 45a81000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a89000 45a9f000 r-xp /usr/lib/libmmfsound.so.0.1.0
45ab1000 45ab6000 r-xp /usr/lib/libmmfsession.so.0.0.0
45abe000 45ac8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45ad4000 45ad8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45ae1000 45af6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45afe000 45b5f000 r-xp /usr/lib/libasound.so.2.0.0
45b69000 45ba1000 r-xp /usr/lib/libpulse.so.0.16.2
45ba2000 45bd3000 r-xp /usr/lib/libmdm.so.1.1.86
45bdb000 45be0000 r-xp /usr/lib/libjson.so.0.0.1
45be8000 45c30000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c31000 45c78000 r-xp /usr/lib/libsndfile.so.1.0.26
45c84000 45c8c000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c8d000 45caf000 r-xp /usr/lib/libvorbis.so.0.4.3
45cb7000 45cbb000 r-xp /usr/lib/libogg.so.0.7.1
bea96000 beab7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2705)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x41746238) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3238
 1: app_terminate + 0x1c (0x41744d15) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d15
 2: (0x41540af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41744ca7) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1ca7
 6: bluetooth_screen + 0x13a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: app_terminate + 0x17 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
 19:11:16.211+0200 E/EFL     (  828): edje<828> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:11:16.226+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [touch]
12-07 19:11:16.226+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[1]
12-07 19:11:16.241+0200 W/SHealth_Common(  828): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [2043].
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(708154044)
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:14:00 (UTC).
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[708154044] is removed.
12-07 19:11:16.256+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:16.341+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
12-07 19:11:16.341+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-07 19:11:16.361+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
12-07 19:11:16.361+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
12-07 19:11:16.361+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
12-07 19:11:16.361+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
12-07 19:11:16.371+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:11:16.376+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:11:16.646+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:17.646+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:18.646+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:19.651+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:20.391+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-07 19:11:20.636+0200 W/STARTER (  711): clock-mgr.c: _charger_status_setting_changed_cb(890) > [_charger_status_setting_changed_cb:890] charger status is changed to [0] ambient[0]
12-07 19:11:20.636+0200 W/AUL     (  711): launch.c: app_request_to_launchpad(268) > request cmd(4) to(2043)
12-07 19:11:20.636+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 4
12-07 19:11:20.636+0200 W/wnotib  (  776): w-notification-board-broker-main.c: _wnb_charger_status_changed_cb(437) > 
12-07 19:11:20.636+0200 W/wnotib  (  776): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1619) > num_categoreis: 0
12-07 19:11:20.636+0200 I/wnotib  (  776): w-notification-board-panel-summary.c: _wnb_summary_draw_static_empty_view(1246) > Use existing static_empty_view.
12-07 19:11:20.636+0200 W/wnotib  (  776): w-notification-board-panel-summary.c: wnb_summary_draw_summary_view(1640) > current_summary_type: 1, new_summary_type: 1
12-07 19:11:20.646+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(305) > [windicator_battery_icon_update:305] 82%
12-07 19:11:20.646+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
12-07 19:11:20.661+0200 W/AUL_AMD (  534): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(2043), cmd(4)
12-07 19:11:20.661+0200 I/APP_CORE( 2043): appcore-efl.c: __do_app(429) > [APP 2043] Event: TERMINATE State: RUNNING
12-07 19:11:20.661+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 22
12-07 19:11:20.661+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(916) > app status : 4
12-07 19:11:20.661+0200 E/APP_CORE( 2043): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-07 19:11:20.661+0200 I/APP_CORE( 2043): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-07 19:11:20.661+0200 I/CAPI_APPFW_APPLICATION( 2043): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
12-07 19:11:20.666+0200 W/AUL     (  711): launch.c: app_request_to_launchpad(282) > request cmd(4) result(0)
12-07 19:11:20.666+0200 I/SCONTEXT-LIB( 2043): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 45
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(315) > [windicator_battery_icon_update:315] battery_level: 82, isCharging: 0
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(342) > [windicator_battery_icon_update:342] [SIGNAL] battery file : change_level_85
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(171) > [wnidicator_moment_view_battery_image_update:171] [HIDE charging icon] Not connected or Battery full (5)
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 82, index 16, bg level 80
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_80
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 82
12-07 19:11:20.686+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charging_changed_cb(117) > [_battery_charging_changed_cb:117] Hide Moment View (unconnected)
12-07 19:11:20.686+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(1)
12-07 19:11:20.701+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:20.706+0200 E/EFL     (  714): <714> elm_main.c:1608 elm_object_signal_emit() safety check failed: obj == NULL
12-07 19:11:20.706+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
12-07 19:11:20.706+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
12-07 19:11:20.706+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(164) > [_battery_charger_status_changed_cb:164] Hide Moment View (unconnected)
12-07 19:11:20.706+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_hide(1534) > [windicator_moment_view_hide:1534] Hide Moment View : dynamic_layout((nil)),Type(-1)
12-07 19:11:20.726+0200 E/EFL     (  714): <714> elm_main.c:1608 elm_object_signal_emit() safety check failed: obj == NULL
12-07 19:11:20.726+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
12-07 19:11:20.726+0200 E/W_INDICATOR(  714): windicator_connection.c: windi_connection_pause(1642) > [windi_connection_pause:1642] There is no handle
12-07 19:11:20.731+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:11:20.846+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(240) > Coordination rotation changed received
12-07 19:11:20.846+0200 W/W_HOME  (  776): dbox.c: _dbus_rotation_cb(1341) > angle changed:0
12-07 19:11:20.866+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(668) > [_windicator_rotation_changed_cb:668] [ROTATION] ROT_CHANGE, state:1 angle:0 / is_connected : 0
12-07 19:11:20.866+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(676) > [_windicator_rotation_changed_cb:676] [ROTATION] DBus rotation callback error
12-07 19:11:20.891+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-07 19:11:20.891+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-07 19:11:20.891+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-07 19:11:20.896+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:20.946+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _charging_watch_fade_out_end_cb(1618) > [_charging_watch_fade_out_end_cb:1618] 
12-07 19:11:20.966+0200 I/SCONTEXT-LIB( 2043): comm.c: disconnect_dbus(105) > Disconnecting Dbus
12-07 19:11:20.991+0200 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 19:11:20.991+0200 W/AUL_AMD (  534): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-07 19:11:20.991+0200 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 19:11:20.991+0200 W/AUL_AMD (  534): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-07 19:11:21.056+0200 I/APP_CORE( 2705): appcore-efl.c: __do_app(429) > [APP 2705] Event: RESUME State: PAUSED
12-07 19:11:21.056+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-07 19:11:21.061+0200 W/APP_CORE(  714): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000a
12-07 19:11:21.061+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
12-07 19:11:21.061+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 19:11:21.061+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:11:21.061+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:11:21.061+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:11:21.061+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:11:21.061+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
12-07 19:11:21.111+0200 E/DATA_PROVIDER_MASTER(  712): client_life.c: client_deactivated_by_fault(494) > Client[0x42df5478] is faulted(1), pid(2043)
12-07 19:11:21.111+0200 W/AUL_PAD ( 1152): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2043 pgid = 2043
12-07 19:11:21.211+0200 E/RESOURCED(  537): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/2043/oom_score_adj failed
12-07 19:11:21.211+0200 E/RESOURCED(  537): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 2043
12-07 19:11:21.261+0200 W/AUL_PAD ( 1152): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
12-07 19:11:21.266+0200 E/STARTER (  711): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:2043) is destroyed. ambient mode[0], charging[0], sports mode[0]
12-07 19:11:21.266+0200 W/STARTER (  711): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
12-07 19:11:21.271+0200 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2043
12-07 19:11:21.276+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 3
12-07 19:11:21.276+0200 E/WATCH_CORE(  812): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
12-07 19:11:21.281+0200 E/RESOURCED(  537): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.203
12-07 19:11:21.386+0200 E/AUL     (  534): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-07 19:11:21.656+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:22.656+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:22.661+0200 W/AUL_AMD (  534): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 19:11:23.061+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-07 19:11:23.061+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-07 19:11:23.066+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:23.161+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-07 19:11:23.166+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 19:11:23.166+0200 W/W_HOME  (  776): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-07 19:11:23.166+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-07 19:11:23.166+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 1
12-07 19:11:23.166+0200 W/W_HOME  (  776): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-07 19:11:23.166+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:23.176+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
12-07 19:11:23.176+0200 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-07 19:11:23.176+0200 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 19:11:23.176+0200 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-07 19:11:23.176+0200 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-07 19:11:23.526+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
12-07 19:11:23.526+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-07 19:11:23.526+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-07 19:11:23.526+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-07 19:11:23.526+0200 E/ALARM_MANAGER(  711): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(7-12-2017, 19:11:44), repeat(1), interval(20), type(-1073741822)
12-07 19:11:23.546+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [711].
12-07 19:11:23.556+0200 I/APP_CORE( 2705): appcore-efl.c: __do_app(429) > [APP 2705] Event: PAUSE State: RUNNING
12-07 19:11:23.556+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1116810751, next duetime: 1512666704
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1116810751)
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512666840), due_time(1512666704)
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:11:44 (UTC).
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:11:23.666+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:23.676+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:23.681+0200 W/SHealth_Common( 1116): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-07 19:11:23.681+0200 W/SHealth_Service( 1116): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-07 19:11:23.686+0200 W/SHealth_Common(  828): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-07 19:11:23.711+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : 0
12-07 19:11:24.176+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-07 19:11:24.176+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-07 19:11:24.181+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:24.206+0200 E/wnoti-service(  907): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
12-07 19:11:24.206+0200 E/wnoti-service(  907): wnoti-native-client.c: handle_cache_notification(603) > >>
12-07 19:11:24.226+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
12-07 19:11:24.656+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : 0
12-07 19:11:25.656+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : 0
12-07 19:11:26.066+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-07 19:11:26.656+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : 0
12-07 19:11:27.666+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : 0
12-07 19:11:28.566+0200 I/APP_CORE( 2705): appcore-efl.c: __do_app(429) > [APP 2705] Event: MEM_FLUSH State: PAUSED
12-07 19:11:28.666+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:29.606+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-07 19:11:29.606+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-07 19:11:29.611+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:29.611+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-07 19:11:29.611+0200 W/W_HOME  (  776): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-07 19:11:29.651+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-07 19:11:29.651+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-07 19:11:29.651+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:29.656+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:29.656+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-07 19:11:29.656+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-07 19:11:29.656+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-07 19:11:29.656+0200 W/W_HOME  (  776): gesture.c: _apps_status_get(126) > apps status:0
12-07 19:11:29.656+0200 W/W_HOME  (  776): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:6532
12-07 19:11:29.656+0200 W/W_HOME  (  776): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-07 19:11:29.656+0200 W/W_HOME  (  776): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-07 19:11:29.656+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:29.656+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [6532]ms
12-07 19:11:29.656+0200 W/STARTER (  711): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-07 19:11:29.666+0200 I/APP_CORE( 2705): appcore-efl.c: __do_app(429) > [APP 2705] Event: RESUME State: PAUSED
12-07 19:11:29.666+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [711].
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1116810751)
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:14:00 (UTC).
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1116810751] is removed.
12-07 19:11:29.691+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:29.706+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-07 19:11:29.706+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:29.706+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_boolean(1173) > preference_get_boolean(1116) : test_healthy_pace error
12-07 19:11:29.706+0200 W/SHealth_Service( 1116): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
12-07 19:11:29.806+0200 W/SHealth_Common( 1116): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1512604800000,000000[0;m
12-07 19:11:29.826+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
12-07 19:11:29.826+0200 W/SHealth_Service( 1116): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
12-07 19:11:29.831+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (007427)]][0;m
12-07 19:11:29.856+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-07 19:11:29.856+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 0
12-07 19:11:29.856+0200 W/W_HOME  (  776): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-07 19:11:29.866+0200 W/SHealth_Common(  828): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-07 19:11:29.896+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
12-07 19:11:29.896+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-07 19:11:29.906+0200 W/SHealth_Common( 1116): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
12-07 19:11:29.906+0200 W/SHealth_Common( 1116): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-07 19:11:29.906+0200 W/SHealth_Service( 1116): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_double(1214) > preference_get_double(1116) : pedometer_inactive_period error
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_double(1214) > preference_get_double(1116) : inactive_10min_precaution_millisec error
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:29.906+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_double(1214) > preference_get_double(1116) : inactive_before_10min_precaution_millisec error
12-07 19:11:29.911+0200 W/SHealthWidget(  828): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (007427), msgName: timeline_summary_updated[0;m
12-07 19:11:29.911+0200 W/SHealth_Common(  828): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
12-07 19:11:29.916+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-07 19:11:29.946+0200 I/healthData( 1116): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-07 19:11:29.946+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-07 19:11:29.946+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 19:11:29.946+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-07 19:11:29.946+0200 E/TIZEN_N_SYSTEM_SETTINGS(  828): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-07 19:11:29.971+0200 I/CAPI_WIDGET_APPLICATION(  828): widget_app.c: __provider_update_cb(281) > received updating signal
12-07 19:11:29.971+0200 E/EFL     (  828): edje<828> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 19:11:30.666+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:31.661+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:32.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:33.661+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:34.666+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:35.661+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:36.246+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-07 19:11:36.256+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 19:11:36.256+0200 W/W_HOME  (  776): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-07 19:11:36.256+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-07 19:11:36.256+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 1
12-07 19:11:36.256+0200 W/W_HOME  (  776): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-07 19:11:36.256+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:36.296+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
12-07 19:11:36.296+0200 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-07 19:11:36.301+0200 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 19:11:36.301+0200 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-07 19:11:36.301+0200 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-07 19:11:36.511+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
12-07 19:11:36.511+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-07 19:11:36.511+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-07 19:11:36.511+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-07 19:11:36.511+0200 E/ALARM_MANAGER(  711): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(7-12-2017, 19:11:57), repeat(1), interval(20), type(-1073741822)
12-07 19:11:36.531+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [711].
12-07 19:11:36.541+0200 I/APP_CORE( 2705): appcore-efl.c: __do_app(429) > [APP 2705] Event: PAUSE State: RUNNING
12-07 19:11:36.541+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-07 19:11:36.631+0200 W/SHealth_Common( 1116): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-07 19:11:36.631+0200 W/SHealth_Service( 1116): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-07 19:11:36.631+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1460163590, next duetime: 1512666717
12-07 19:11:36.631+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1460163590)
12-07 19:11:36.631+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512666840), due_time(1512666717)
12-07 19:11:36.636+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:11:36.636+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:11:57 (UTC).
12-07 19:11:36.636+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:11:36.636+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:36.636+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:36.661+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:36.666+0200 W/SHealth_Common(  828): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-07 19:11:37.691+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:37.786+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-07 19:11:37.786+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-07 19:11:37.786+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:37.786+0200 W/W_HOME  (  776): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-07 19:11:37.786+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-07 19:11:37.786+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-07 19:11:37.791+0200 W/W_HOME  (  776): gesture.c: _apps_status_get(126) > apps status:0
12-07 19:11:37.791+0200 W/W_HOME  (  776): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:1494
12-07 19:11:37.791+0200 W/W_HOME  (  776): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-07 19:11:37.791+0200 W/W_HOME  (  776): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-07 19:11:37.791+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:37.791+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [1494]ms
12-07 19:11:37.791+0200 W/STARTER (  711): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-07 19:11:37.806+0200 I/APP_CORE( 2705): appcore-efl.c: __do_app(429) > [APP 2705] Event: RESUME State: PAUSED
12-07 19:11:37.806+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [711].
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1460163590)
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 7-12-2017, 17:14:00 (UTC).
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:37.851+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1460163590] is removed.
12-07 19:11:37.856+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
12-07 19:11:37.886+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-07 19:11:37.886+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:37.886+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_boolean(1173) > preference_get_boolean(1116) : test_healthy_pace error
12-07 19:11:37.956+0200 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-07 19:11:37.956+0200 W/STARTER (  711): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-07 19:11:37.961+0200 W/SHealth_Common(  828): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_double(1214) > preference_get_double(1116) : pedometer_inactive_period error
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_double(1214) > preference_get_double(1116) : inactive_10min_precaution_millisec error
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 19:11:37.971+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1116): preference.c: preference_get_double(1214) > preference_get_double(1116) : inactive_before_10min_precaution_millisec error
12-07 19:11:37.971+0200 W/SHealth_Common( 1116): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-07 19:11:37.971+0200 W/SHealth_Service( 1116): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-07 19:11:37.991+0200 W/W_HOME  (  776): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-07 19:11:37.991+0200 W/W_HOME  (  776): gesture.c: _manual_render_enable(136) > 0
12-07 19:11:37.991+0200 W/W_HOME  (  776): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-07 19:11:38.651+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-07 19:11:38.666+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:39.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:40.666+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:41.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:42.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:42.811+0200 E/EFL     ( 2705): ecore_x<2705> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=746562 button=1
12-07 19:11:42.916+0200 E/EFL     ( 2705): ecore_x<2705> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=746668 button=1
12-07 19:11:43.676+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:44.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:45.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:46.671+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:47.676+0200 I/INFO_TAG( 2705): SENSOR_EVENT HEART RATE < 40 : -3
12-07 19:11:47.886+0200 E/EFL     ( 2705): ecore_x<2705> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=751640 button=1
12-07 19:11:47.921+0200 E/EFL     ( 2705): ecore_x<2705> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=751675 button=1
12-07 19:11:48.096+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(645) > __request_handler: 22
12-07 19:11:48.096+0200 W/AUL_AMD (  534): amd_request.c: __request_handler(916) > app status : 4
12-07 19:11:48.136+0200 E/APP_CORE( 2705): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-07 19:11:48.136+0200 I/APP_CORE( 2705): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-07 19:11:48.136+0200 I/APP_CORE( 2705): appcore-efl.c: __after_loop(1089) > [APP 2705] PAUSE before termination
12-07 19:11:48.136+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-07 19:11:48.136+0200 I/CAPI_APPFW_APPLICATION( 2705): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-07 19:11:48.496+0200 W/AUL_PAD ( 1152): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2705 pgid = 2705
12-07 19:11:48.651+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-07 19:11:48.766+0200 W/W_HOME  (  776): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
12-07 19:11:48.766+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.766+0200 W/W_HOME  (  776): event_manager.c: _state_control(353) > appcore resumed manually
12-07 19:11:48.766+0200 W/W_HOME  (  776): main.c: home_appcore_resume(714) > Home Appcore Resumed
12-07 19:11:48.766+0200 W/W_HOME  (  776): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
12-07 19:11:48.766+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.811+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.811+0200 W/W_HOME  (  776): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
12-07 19:11:48.811+0200 W/W_HOME  (  776): main.c: home_resume(739) > clock/widget resumed
12-07 19:11:48.811+0200 W/W_HOME  (  776): clock_indicator.c: clock_indicator_resume(537) > 
12-07 19:11:48.821+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.821+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.821+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.826+0200 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(453) > Window [0x2800003] is now visible(0)
12-07 19:11:48.826+0200 W/W_HOME  (  776): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
12-07 19:11:48.826+0200 W/W_HOME  (  776): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 19:11:48.826+0200 W/W_HOME  (  776): main.c: _window_visibility_cb(1211) > Window [0x2800003] is now visible(0)
12-07 19:11:48.826+0200 I/APP_CORE(  776): appcore-efl.c: __do_app(429) > [APP 776] Event: RESUME State: RUNNING
12-07 19:11:48.826+0200 W/wnotib  (  776): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
12-07 19:11:48.831+0200 W/WATCH_CORE(  812): appcore-watch.c: __widget_resume(1039) > widget_resume
12-07 19:11:48.831+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:48.936+0200 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 19:11:48.936+0200 W/AUL_AMD (  534): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-07 19:11:48.936+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
12-07 19:11:48.936+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
12-07 19:11:48.936+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 19:11:49.021+0200 W/AUL_PAD ( 1152): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
12-07 19:11:49.031+0200 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2705
12-07 19:11:49.051+0200 E/RESOURCED(  537): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.204
12-07 19:11:49.096+0200 W/CRASH_MANAGER( 2971): worker.c: worker_job(1205) > 1102705646174151266670
