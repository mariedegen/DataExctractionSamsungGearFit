S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 20294
Date: 2017-10-26 13:13:46+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x4152c670, r1   = 0x00000001
r2   = 0x4059d250, r3   = 0x92771a00
r4   = 0xbed554d4, r5   = 0x4154ad30
r6   = 0x00000233, r7   = 0xbed55400
r8   = 0xbed554a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e5a00, sp   = 0xbed553d0
lr   = 0x404e5ab4, pc   = 0x41746754
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     16852 KB
Buffers:     46704 KB
Cached:     172700 KB
VmPeak:      66752 KB
VmSize:      66748 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11956 KB
VmRSS:       11952 KB
VmData:      13500 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20294 TID = 20294
20294 20353 

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
405f8000 4061d000 rw-p [heap]
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
4157d000 41581000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4158a000 4158c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41595000 4159b000 r-xp /usr/lib/libappsvc.so.0.1.0
415a3000 415c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415d0000 4169f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
416b5000 416bf000 r-xp /lib/libnss_files-2.13.so
41743000 41748000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41759000 4178b000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41794000 41798000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a1000 417a9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417aa000 417cb000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d4000 4180e000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41817000 41830000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41838000 4183d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41845000 4186f000 r-xp /usr/lib/libsensor.so.1.9.6
41878000 4188a000 r-xp /usr/lib/libefl-assist.so.0.1.0
41892000 4194a000 r-xp /usr/lib/libcairo.so.2.11200.14
41955000 41958000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41960000 41966000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4196f000 41977000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4197f000 41989000 r-xp /usr/lib/libsensord-shared.so
41992000 419a4000 r-xp /usr/lib/libtts.so
419ac000 419ce000 r-xp /usr/lib/libui-extension.so.0.1.0
419d7000 419de000 r-xp /usr/lib/libtbm.so.1.0.0
419e6000 419f4000 r-xp /usr/lib/libGLESv2.so.2.0
419fd000 419fe000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a07000 41a0d000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a15000 41a18000 r-xp /usr/lib/libEGL.so.1.4
41a20000 41a2d000 r-xp /usr/lib/libail.so.0.1.0
41a36000 41b73000 r-xp /usr/lib/libicui18n.so.51.1
41b83000 41c67000 r-xp /usr/lib/libicuuc.so.51.1
43205000 43221000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4322a000 4322d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43235000 43236000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4323f000 43247000 r-xp /usr/lib/libdrm.so.2.4.0
4324f000 43251000 r-xp /usr/lib/libdri2.so.0.0.0
43259000 43260000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43269000 4326b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43273000 4327a000 r-xp /usr/lib/libminizip.so.1.0.0
43282000 43288000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43290000 43295000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4329d000 432be000 r-xp /usr/lib/libexif.so.12.3.3
432d1000 432d3000 r-xp /usr/lib/libttrace.so.1.1
432db000 432e0000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e8000 434b2000 r-xp /usr/lib/libCOREGL.so.4.0
436c5000 43f00000 rw-p [stack:20353]
bed35000 bed56000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20294)
Call Stack Count: 9
 0: start_bt_server + 0x13 (0x41746754) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3754
 1: app_create + 0x38 (0x41745039) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2039
 2: (0x415409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x41744f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
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
ntrol_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:13:39.000+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:13:39.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-26 13:13:39.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-26 13:13:39.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 78, index 15, bg level 75
10-26 13:13:39.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_75
10-26 13:13:39.000+0200 W/W_INDICATOR(  735): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 78
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:13  /5 / HH:mm
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:13
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 13
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  13
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 13 / 13:13
10-26 13:13:39.015+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:13:39.020+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_moment_view_charging_watch_ui_show(1442) > [windicator_moment_view_charging_watch_ui_show:1442] [Rotation] Degree : 90
10-26 13:13:39.025+0200 E/EFL     (  735): edje<735> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:13:39.030+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:39.040+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20216
10-26 13:13:39.055+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:39.075+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 13:13:39.080+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
10-26 13:13:39.105+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:39.115+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20218
10-26 13:13:39.125+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:39.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 13:13:39.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 13:13:39.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 13:13:39.170+0200 W/SHealth_Service( 1085): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-26 13:13:39.205+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:39.210+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19444
10-26 13:13:39.215+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:39.235+0200 E/PKGMGR  (20275): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:AlarmSvc.cpp     L:   80][_HIGH]CAlarmSvc::CAlarmSvc()[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:TransferCtrl.cpp L:   81][_HIGH]CTransferCtrl::CTransferCtrl()[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:SAPClient.cpp    L:   79][_HIGH][TX]CSAPClient::BindPeer(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService nChannel=4444[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-26 13:13:39.325+0200 W/WG-CONSUMER(20216): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-26 13:13:39.330+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-26 13:13:39.330+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-26 13:13:39.335+0200 W/WG-CONSUMER(20216): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-26 13:13:39.335+0200 I/CAPI_CONTENT_MEDIA_CONTENT(20216): media_content.c: media_content_connect(870) > [32m[20216]ref count : 0
10-26 13:13:39.335+0200 I/CAPI_CONTENT_MEDIA_CONTENT(20216): media_content.c: media_content_connect(902) > [32m[20216]ref count changed to: 1
10-26 13:13:39.335+0200 W/WG-CONSUMER(20216): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-26 13:13:39.350+0200 W/WG-CONSUMER(20216): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-26 13:13:39.350+0200 W/WG-CONSUMER(20216): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-26 13:13:39.350+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-26 13:13:39.350+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-26 13:13:39.350+0200 E/WG-CONSUMER(20216): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-26 13:13:39.350+0200 E/WG-CONSUMER(20216): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-26 13:13:39.355+0200 E/WG-CONSUMER(20216): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-26 13:13:39.355+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-26 13:13:39.355+0200 E/WG-CONSUMER(20216): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-26 13:13:39.355+0200 E/WG-CONSUMER(20216): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-26 13:13:39.360+0200 E/WG-CONSUMER(20216): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-26 13:13:39.360+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-26 13:13:39.360+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-26 13:13:39.360+0200 E/WG-CONSUMER(20216): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-26 13:13:39.360+0200 W/WG-CONSUMER(20216): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42eaf8d0[0m
10-26 13:13:39.360+0200 W/CAPI_APPFW_APP_CONTROL(20216): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-26 13:13:39.360+0200 W/CAPI_APPFW_APP_CONTROL(20216): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-26 13:13:39.370+0200 W/WG-CONSUMER(20216): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-26 13:13:39.385+0200 I/CAPI_APPFW_APPLICATION(20216): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 13:13:39.385+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 13:13:39.385+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 13:13:39.385+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 13:13:39.385+0200 E/WIPC_SERVER(20216): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-26 13:13:39.390+0200 W/WG-CONSUMER(20216): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-26 13:13:39.395+0200 W/WG-CONSUMER(20216): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-26 13:13:39.400+0200 I/CAPI_CONTENT_MEDIA_CONTENT(20216): media_content.c: media_content_disconnect(958) > [32m[20216]ref count changed to: 0
10-26 13:13:39.425+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:13:39.470+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:13:39.480+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:39.490+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20218
10-26 13:13:39.495+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:39.620+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1134623341], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1134623341' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[p7G1kVuB02eym5RbK9fMnxME4D4=], backend_flag=[0]
10-26 13:13:39.635+0200 E/PKGMGR  (20277): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 13:13:39.645+0200 E/PKGMGR  (20275): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[202750002]
10-26 13:13:39.655+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:13:39.660+0200 E/PKGMGR_SERVER(20280): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 13:13:39.675+0200 E/PKGMGR_SERVER(20281): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:13:39.830+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: main(601) > OBSERVER start
10-26 13:13:39.890+0200 W/MUSIC_TRANSFER(20218): mt-service.c: main(142) > [33m[TID:20218]   service start[0m
10-26 13:13:39.890+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:13:39.890+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:13:39.890+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:13:39.920+0200 W/MUSIC_TRANSFER(20218): mt-service.c: _service_app_create(65) > [33m[TID:20218]   [0m
10-26 13:13:40.080+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 13:13:40.090+0200 E/rpm-installer(20280): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 13:13:40.095+0200 E/rpm-installer(20280): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 13:13:40.095+0200 E/rpm-installer(20280): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 13:13:40.095+0200 E/rpm-installer(20280): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 13:13:40.095+0200 E/rpm-installer(20280): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 13:13:40.115+0200 E/WG-CONSUMER(20216): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-26 13:13:40.115+0200 W/WG-CONSUMER(20216): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-26 13:13:40.120+0200 W/WG-CONSUMER(20216): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-26 13:13:40.120+0200 W/WG-CONSUMER(20216): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-26 13:13:40.120+0200 W/WG-CONSUMER(20216): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-26 13:13:40.120+0200 W/WG-CONSUMER(20216): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-26 13:13:40.120+0200 W/WG-CONSUMER(20216): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-26 13:13:40.245+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[202810002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 13:13:40.260+0200 E/APPS    (  769): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 13:13:40.260+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 13:13:40.275+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 13:13:40.280+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[202810002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:13:40.300+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 13:13:40.335+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:13:40.385+0200 W/MUSIC_PLAYER(20218): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:20218]   W_SERVICE_TYPE_BT[1][0m
10-26 13:13:40.385+0200 W/MUSIC_PLAYER(20218): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:20218]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-26 13:13:40.390+0200 W/MUSIC_TRANSFER(20218): mt-service.c: _service_app_create(88) > [31m[TID:20218]   SAP is disconnected.. Terminate process[0m
10-26 13:13:40.390+0200 I/CAPI_APPFW_APPLICATION(20218): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 13:13:40.435+0200 W/CERT_SVC(20280): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:13:40.470+0200 E/rpm-installer(20280): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 13:13:40.470+0200 E/rpm-installer(20280): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 13:13:40.470+0200 E/rpm-installer(20280): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 13:13:40.470+0200 E/rpm-installer(20280): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 13:13:40.565+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:40.575+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19444
10-26 13:13:40.595+0200 W/AUL     (20292): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-26 13:13:40.600+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:40.600+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:13:40.605+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:13:40.605+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20216
10-26 13:13:40.605+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:13:40.615+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20216
10-26 13:13:40.635+0200 E/PKGMGR_PARSER(20280): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 13:13:40.660+0200 E/PKGMGR_PARSER(20280): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:13:40.770+0200 E/PKGMGR_INFO(20218): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=0) is called. pid=[20218]
10-26 13:13:40.770+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=0) is called. pid=[1085]
10-26 13:13:40.790+0200 E/PKGMGR_INFO(20218): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=1) is called. pid=[20218]
10-26 13:13:40.795+0200 E/EFL     (20260): elementary<20260> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:13:40.795+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=1) is called. pid=[1085]
10-26 13:13:40.800+0200 E/EFL     (20260): elementary<20260> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:13:40.815+0200 E/PKGMGR_INFO(20218): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=2) is called. pid=[20218]
10-26 13:13:40.820+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=2) is called. pid=[1085]
10-26 13:13:40.835+0200 E/PKGMGR_INFO(20218): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=3) is called. pid=[20218]
10-26 13:13:40.845+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=3) is called. pid=[1085]
10-26 13:13:40.860+0200 E/EFL     (20260): elementary<20260> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:13:40.865+0200 E/EFL     (20260): elementary<20260> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:13:40.865+0200 E/PKGMGR_INFO(20218): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=4) is called. pid=[20218]
10-26 13:13:40.865+0200 E/PKGMGR_PARSER(20280): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 13:13:40.870+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=4) is called. pid=[1085]
10-26 13:13:40.900+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=5) is called. pid=[1085]
10-26 13:13:40.900+0200 E/PKGMGR_INFO(20218): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=5) is called. pid=[20218]
10-26 13:13:40.995+0200 I/AUL     ( 1085): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
10-26 13:13:40.995+0200 E/EFL     (20260): elementary<20260> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:13:41.000+0200 E/EFL     (20260): elementary<20260> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:13:41.010+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:13:41.015+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(234) > Failed to get the cmdline of pgid, error: -1
10-26 13:13:41.015+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:13:41.015+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 13:13:41.020+0200 E/EFL     (20260): elementary<20260> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:13:41.025+0200 E/EFL     (20260): elementary<20260> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:13:41.025+0200 E/EFL     (20260): elementary<20260> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:13:41.070+0200 I/PRIVACY-MANAGER-CLIENT(20280): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:13:41.105+0200 W/MUSIC_PLAYER(20218): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:20218]   vendor : LO[0m
10-26 13:13:41.155+0200 W/MUSIC_PLAYER(20218): mp-conf.c: mp_conf_init(262) > [33m[TID:20218]   iOS  connected..[0m
10-26 13:13:41.165+0200 E/EFL     (20260): elementary<20260> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:13:41.165+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20218): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-26 13:13:41.165+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20218): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-26 13:13:41.165+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20218): preference.c: preference_get_int(1132) > preference_get_int(20218) : key(tutorial_complete) error
10-26 13:13:41.170+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-26 13:13:41.170+0200 E/CAPI_NETWORK_BLUETOOTH( 1061): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-26 13:13:41.170+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1061]   bt_gatt_client_get_service Error[-22][0m
10-26 13:13:41.170+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1061]   remote mode[0][0m
10-26 13:13:41.170+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:13:41.170+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:13:41.175+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:13:41.180+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:13:41.180+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:13:41.180+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:13:41.195+0200 E/EFL     (20260): elementary<20260> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:13:41.195+0200 E/EFL     (20260): elementary<20260> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:13:41.205+0200 I/efl-extension(20280): efl_extension.c: eext_mod_init(40) > Init
10-26 13:13:41.205+0200 I/efl-extension(20280): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 13:13:41.215+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 13:13:41.215+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 13:13:41.215+0200 W/SHealth_Service( 1085): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
10-26 13:13:41.215+0200 W/MUSIC_TRANSFER(20218): mt-service.c: _service_app_terminate(104) > [33m[TID:20218]   [0m
10-26 13:13:41.285+0200 E/EFL     (20260): elementary<20260> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:13:41.285+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=0) is called. pid=[1085]
10-26 13:13:41.305+0200 E/EFL     (20260): elementary<20260> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:13:41.305+0200 E/EFL     (20260): elementary<20260> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:13:41.305+0200 E/EFL     (20260): elementary<20260> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:13:41.305+0200 E/EFL     (20260): elementary<20260> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:13:41.305+0200 E/EFL     (20260): elementary<20260> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:13:41.305+0200 E/EFL     (20260): elementary<20260> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:13:41.305+0200 I/AUL_PAD (20260): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:13:41.310+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=1) is called. pid=[1085]
10-26 13:13:41.330+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=2) is called. pid=[1085]
10-26 13:13:41.350+0200 E/PKGMGR_INFO( 1085): pkgmgrinfo_private.c: __db_busy_handler(248) > __db_busy_handler(count=3) is called. pid=[1085]
10-26 13:13:41.380+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:41.390+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20218
10-26 13:13:41.390+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 13:13:41.390+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:41.400+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-26 13:13:41.415+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 13:13:41.420+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 13:13:41.420+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 13:13:41.420+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 13:13:41.420+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 13:13:41.420+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 13:13:41.420+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 13:13:41.430+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 13:13:41.435+0200 E/PKGMGR_CERT(20280): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 13:13:41.445+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[202810002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 13:13:41.500+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:13:41.520+0200 E/rpm-installer(20280): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 13:13:41.530+0200 E/rpm-installer(20280): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 13:13:41.565+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20260 pgid = 20260
10-26 13:13:41.650+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:13:41.670+0200 E/rpm-installer(20280): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 13:13:41.705+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[202810002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 13:13:41.730+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20260
10-26 13:13:41.765+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:13:41.810+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:13:41.810+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19058 pgid = -1
10-26 13:13:41.810+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:13:41.825+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19058
10-26 13:13:41.835+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.619
10-26 13:13:41.870+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 13:13:41.870+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 13:13:41.895+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 13:13:41.910+0200 E/rpm-installer(20280): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 13:13:41.985+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 13:13:41.985+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 13:13:42.105+0200 W/AUL     (20298): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-26 13:13:42.105+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:13:42.110+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:13:42.110+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20218
10-26 13:13:42.110+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:13:42.115+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20218
10-26 13:13:42.130+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:13:42.135+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19444
10-26 13:13:42.160+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:13:42.310+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:13:42.330+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:13:42.330+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:13:42.335+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:13:42.570+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 13:13:42.655+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 13:13:42.695+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 13:13:42.725+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:13:43.190+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[202810002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 13:13:43.210+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 13:13:43.210+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 13:13:43.215+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 13:13:43.250+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 13:13:43.290+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 13:13:43.290+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:13:43.290+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:13:43.290+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:13:43.290+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 13:13:43.290+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 13:13:43.305+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 13:13:43.335+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 13:13:43.365+0200 E/PKGMGR_INFO(20281): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 13:13:43.380+0200 E/PKGMGR_OBSERVER(20281): pkg_observer.c: main(620) > OBSERVER end
10-26 13:13:43.410+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:13:43.410+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20281]
10-26 13:13:43.415+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 13:13:43.435+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 13:13:43.435+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 13:13:43.650+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:13:43.895+0200 E/EFL     (20294): elementary<20294> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:13:43.905+0200 E/EFL     (20294): elementary<20294> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:13:43.970+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:13:44.145+0200 E/EFL     (20294): elementary<20294> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:13:44.175+0200 E/EFL     (20294): elementary<20294> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:13:44.290+0200 E/EFL     (20294): elementary<20294> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:13:44.290+0200 E/EFL     (20294): elementary<20294> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:13:44.295+0200 E/EFL     (20294): elementary<20294> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:13:44.320+0200 E/EFL     (20294): elementary<20294> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:13:44.325+0200 E/EFL     (20294): elementary<20294> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:13:44.480+0200 E/EFL     (20294): elementary<20294> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:13:44.520+0200 E/EFL     (20294): elementary<20294> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:13:44.545+0200 E/EFL     (20294): elementary<20294> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:13:44.600+0200 E/EFL     (20294): elementary<20294> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:13:44.765+0200 E/EFL     (20294): elementary<20294> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:13:44.785+0200 E/EFL     (20294): elementary<20294> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:13:44.785+0200 E/EFL     (20294): elementary<20294> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:13:44.785+0200 E/EFL     (20294): elementary<20294> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:13:44.785+0200 E/EFL     (20294): elementary<20294> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:13:44.795+0200 E/EFL     (20294): elementary<20294> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:13:44.800+0200 I/AUL_PAD (20294): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:13:44.935+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:13:44.935+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:13:44.940+0200 E/rpm-installer(20280): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:13:44.990+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20280]
10-26 13:13:44.995+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/20280/oom_score_adj failed
10-26 13:13:44.995+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 20280
10-26 13:13:45.065+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:13:45.595+0200 I/efl-extension(20295): efl_extension.c: eext_mod_init(40) > Init
10-26 13:13:45.650+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:13:45.650+0200 E/PKGMGR_SERVER(20277): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:13:45.960+0200 E/EFL     (20295): elementary<20295> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:13:45.990+0200 E/EFL     (20295): elementary<20295> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:13:46.170+0200 E/EFL     (20295): elementary<20295> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:13:46.200+0200 I/UXT     (20295): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:13:46.210+0200 E/EFL     (20295): elementary<20295> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:13:46.320+0200 E/EFL     (20295): elementary<20295> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:13:46.320+0200 E/EFL     (20295): elementary<20295> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:13:46.325+0200 E/EFL     (20295): elementary<20295> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:13:46.325+0200 E/EFL     (20295): elementary<20295> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:13:46.325+0200 E/EFL     (20295): elementary<20295> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:13:46.335+0200 W/AUL     (20352): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:13:46.335+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:13:46.350+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 13:13:46.360+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 13:13:46.360+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:13:46.360+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 20352
10-26 13:13:46.375+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:13:46.375+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:13:46.375+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:13:46.380+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:13:46.380+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:13:46.405+0200 E/EFL     (20295): elementary<20295> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:13:46.420+0200 E/EFL     (20295): elementary<20295> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:13:46.430+0200 E/EFL     (20295): elementary<20295> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:13:46.435+0200 I/efl-extension(20294): efl_extension.c: eext_mod_init(40) > Init
10-26 13:13:46.445+0200 I/UXT     (20294): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:13:46.445+0200 I/CAPI_APPFW_APPLICATION(20294): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:13:46.450+0200 I/CAPI_APPFW_APPLICATION(20294): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:13:46.485+0200 W/AUL     (20352): launch.c: app_request_to_launchpad(282) > request cmd(0) result(20294)
10-26 13:13:46.495+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:13:46.525+0200 E/EFL     (20295): elementary<20295> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:13:46.545+0200 E/EFL     (20295): elementary<20295> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:13:46.545+0200 E/EFL     (20295): elementary<20295> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:13:46.550+0200 E/EFL     (20295): elementary<20295> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:13:46.550+0200 E/EFL     (20295): elementary<20295> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:13:46.550+0200 E/EFL     (20295): elementary<20295> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:13:46.550+0200 E/EFL     (20295): elementary<20295> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:13:46.550+0200 I/AUL_PAD (20295): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:13:46.620+0200 I/Bluetooth(20294): [bt_initialize] success.
10-26 13:13:46.955+0200 W/CRASH_MANAGER(20356): worker.c: worker_job(1205) > 1120294646174150901642
