S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 16080
Date: 2017-10-26 12:35:26+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16080, uid 5000)

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x4147ef40, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbe8bf3f8
r8   = 0xbe8bf4a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbe8bf3a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     29976 KB
Buffers:     39868 KB
Cached:     167760 KB
VmPeak:      99256 KB
VmSize:      97496 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20016 KB
VmRSS:       20016 KB
VmData:      40632 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25564 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16080 TID = 16080
16080 16285 

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
4146a000 4146f000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4147f000 41481000 rw-p [heap]
41481000 414a2000 rw-p [heap]
414a2000 414a6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414af000 414b1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ba000 414c0000 r-xp /usr/lib/libappsvc.so.0.1.0
414c8000 414ec000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414f5000 415c4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415da000 415e4000 r-xp /lib/libnss_files-2.13.so
41768000 41773000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
4177b000 417ad000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
417b6000 417ba000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417c3000 417cb000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417cc000 417ed000 r-xp /usr/lib/libefl-extension.so.0.1.0
417f6000 41830000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41839000 41852000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4185a000 4185f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41867000 41891000 r-xp /usr/lib/libsensor.so.1.9.6
4189a000 418ac000 r-xp /usr/lib/libefl-assist.so.0.1.0
418b4000 4196c000 r-xp /usr/lib/libcairo.so.2.11200.14
41977000 4197a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41982000 41988000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41991000 41999000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
419a1000 419ab000 r-xp /usr/lib/libsensord-shared.so
419b4000 419c6000 r-xp /usr/lib/libtts.so
419ce000 419f0000 r-xp /usr/lib/libui-extension.so.0.1.0
419f9000 41a00000 r-xp /usr/lib/libtbm.so.1.0.0
41a08000 41a16000 r-xp /usr/lib/libGLESv2.so.2.0
41a1f000 41a20000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a29000 41a2f000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a37000 41a3a000 r-xp /usr/lib/libEGL.so.1.4
41a42000 41a4f000 r-xp /usr/lib/libail.so.0.1.0
41a58000 41b95000 r-xp /usr/lib/libicui18n.so.51.1
41ba5000 41c89000 r-xp /usr/lib/libicuuc.so.51.1
43227000 43243000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4324c000 4324f000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43257000 43258000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
43261000 43269000 r-xp /usr/lib/libdrm.so.2.4.0
43271000 43273000 r-xp /usr/lib/libdri2.so.0.0.0
4327b000 43282000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4328b000 4328d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43295000 4329c000 r-xp /usr/lib/libminizip.so.1.0.0
432a4000 432aa000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
432b2000 432b7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
432bf000 432e0000 r-xp /usr/lib/libexif.so.12.3.3
432f3000 432f5000 r-xp /usr/lib/libttrace.so.1.1
432fd000 43302000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4330a000 433d4000 r-xp /usr/lib/libCOREGL.so.4.0
435e7000 43de6000 rw-p [stack:16285]
43de6000 43df1000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44700000 44705000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
448a8000 448a9000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
448b1000 448b3000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
459cf000 459d0000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
459d8000 459db000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
459eb000 459f2000 r-xp /usr/lib/libfeedback.so.0.1.4
45b5c000 45b5d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45b65000 45b67000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45b6f000 45b79000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45b81000 45b88000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45b90000 45ba6000 r-xp /usr/lib/libmmfsound.so.0.1.0
45bb8000 45bbd000 r-xp /usr/lib/libmmfsession.so.0.0.0
45bc5000 45bcf000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45bdb000 45bdf000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45be8000 45bfd000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45c05000 45c66000 r-xp /usr/lib/libasound.so.2.0.0
45c70000 45c73000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45c7b000 45cb3000 r-xp /usr/lib/libpulse.so.0.16.2
45cb4000 45ce5000 r-xp /usr/lib/libmdm.so.1.1.86
45ced000 45cf2000 r-xp /usr/lib/libjson.so.0.0.1
45cfa000 45d42000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d43000 45d8a000 r-xp /usr/lib/libsndfile.so.1.0.26
45d96000 45d9e000 r-xp /usr/lib/libmdm-common.so.1.0.89
45d9f000 45dc1000 r-xp /usr/lib/libvorbis.so.0.4.3
45dc9000 45dcd000 r-xp /usr/lib/libogg.so.0.7.1
45dd5000 45dd6000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
be89f000 be8c0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16080)
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
W_APPLICATION(16080): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 12:34:36.400+0200 W/APP_CORE(16080): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
10-26 12:34:36.490+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:34:36.500+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16080
10-26 12:34:36.500+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:34:36.510+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16080
10-26 12:34:36.510+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:34:36.515+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:34:36.520+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16080
10-26 12:34:36.520+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:34:36.530+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:34:36.530+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 12:34:36.530+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 12:34:36.535+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:34:36.535+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 12:34:36.535+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 12:34:36.535+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 12:34:36.535+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 12:34:36.535+0200 E/W_HOME  (  769): main.c: _pause_cb(674) > paused already
10-26 12:34:36.535+0200 I/APP_CORE(  769): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 12:34:36.535+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 12:34:36.550+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:34:36.550+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 12:34:36.575+0200 I/APP_CORE(16080): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
10-26 12:34:36.650+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:34:36.655+0200 E/PKGMGR_SERVER(16232): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 12:34:36.655+0200 E/PKGMGR_SERVER(16232): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 12:34:36.660+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:34:36.740+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:34:36.820+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 12:34:37.005+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:34:37.145+0200 E/EFL     (16288): elementary<16288> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 12:34:37.145+0200 E/EFL     (16288): elementary<16288> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 12:34:37.180+0200 E/EFL     (16288): elementary<16288> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 12:34:37.180+0200 E/EFL     (16288): elementary<16288> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 12:34:37.220+0200 E/EFL     (16288): elementary<16288> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 12:34:37.230+0200 E/EFL     (16288): elementary<16288> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 12:34:37.230+0200 E/EFL     (16288): elementary<16288> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 12:34:37.230+0200 E/EFL     (16288): elementary<16288> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 12:34:37.235+0200 E/EFL     (16288): elementary<16288> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 12:34:37.270+0200 E/EFL     (16288): elementary<16288> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 12:34:37.275+0200 E/EFL     (16288): elementary<16288> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 12:34:37.275+0200 E/EFL     (16288): elementary<16288> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 12:34:37.340+0200 E/EFL     (16288): elementary<16288> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 12:34:37.355+0200 E/EFL     (16288): elementary<16288> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 12:34:37.360+0200 E/EFL     (16288): elementary<16288> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 12:34:37.360+0200 E/EFL     (16288): elementary<16288> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 12:34:37.360+0200 E/EFL     (16288): elementary<16288> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 12:34:37.360+0200 E/EFL     (16288): elementary<16288> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 12:34:37.360+0200 E/EFL     (16288): elementary<16288> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 12:34:37.360+0200 I/AUL_PAD (16288): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 12:34:41.540+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 12:34:46.020+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:34:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:34:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:34:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:34:46.030+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>64</color> bpm</color>][0;m
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:34:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:34:48.370+0200 W/AUL     (  584): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.bt-syspopup)
10-26 12:34:48.375+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 12:34:48.395+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/bt-service, ret : 0
10-26 12:34:48.410+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/bt-service, ret : 0
10-26 12:34:48.410+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 12:34:48.410+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 584
10-26 12:34:48.410+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 12:34:48.415+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 12:34:48.415+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 12:34:48.415+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 12:34:48.495+0200 I/efl-extension(16288): efl_extension.c: eext_mod_init(40) > Init
10-26 12:34:48.500+0200 I/UXT     (16288): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 12:34:48.515+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_efl_main(129) > app_efl_main
10-26 12:34:48.525+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_create(152) > app_appcore_create
10-26 12:34:48.620+0200 W/AUL     (  584): launch.c: app_request_to_launchpad(282) > request cmd(0) result(16288)
10-26 12:34:48.620+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : com.samsung.bt-syspopup
10-26 12:34:48.995+0200 I/APP_CORE(16288): appcore-efl.c: __do_app(429) > [APP 16288] Event: RESET State: CREATED
10-26 12:34:48.995+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 12:34:49.220+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.220+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.225+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.225+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.330+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.330+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.345+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.350+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.350+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.350+0200 E/EFL     (16288): edje<16288> edje_util.c:3770 edje_object_size_min_restricted_calc() group group2_inner_ly has a non-fixed part 'check_bottom_padding'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 12:34:49.355+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.355+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.370+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.375+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.380+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.380+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.380+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.380+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.470+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-26 12:34:49.470+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-26 12:34:49.470+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 12:34:49.475+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-26 12:34:49.475+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-26 12:34:49.475+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 12:34:49.475+0200 W/W_HOME  (  769): gesture.c: _apps_status_get(126) > apps status:0
10-26 12:34:49.475+0200 W/W_HOME  (  769): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:42040
10-26 12:34:49.475+0200 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-26 12:34:49.475+0200 W/W_HOME  (  769): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-26 12:34:49.475+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:34:49.475+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [event] after screen off time [42040]ms
10-26 12:34:49.475+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 12:34:49.485+0200 I/APP_CORE(16288): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 12:34:49.485+0200 I/APP_CORE(16288): appcore-efl.c: __do_app(474) > [APP 16288] Initial Launching, call the resume_cb
10-26 12:34:49.485+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 12:34:49.495+0200 I/APP_CORE(16080): appcore-efl.c: __do_app(429) > [APP 16080] Event: RESUME State: RUNNING
10-26 12:34:49.495+0200 W/APP_CORE(16288): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800008
10-26 12:34:49.500+0200 W/APP_CORE(16288): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:4800008
10-26 12:34:49.500+0200 I/APP_CORE(16288): appcore-efl.c: __do_app(429) > [APP 16288] Event: PAUSE State: RUNNING
10-26 12:34:49.500+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 12:34:49.500+0200 W/APP_CORE(16288): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800008
10-26 12:34:49.510+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:49.515+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:49.530+0200 I/MALI    (16288): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(742) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [216x432]
10-26 12:34:49.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 12:34:49.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:49.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 12:34:49.570+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:34:49.570+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 12:34:49.585+0200 I/APP_CORE(16288): appcore-efl.c: __do_app(429) > [APP 16288] Event: RESUME State: PAUSED
10-26 12:34:49.590+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 12:34:49.600+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 12:34:49.605+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:49.605+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 12:34:49.605+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:34:49.605+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:49.605+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 12:34:49.610+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:34:49.610+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:49.615+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 12:34:49.675+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
10-26 12:34:49.675+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 0
10-26 12:34:49.675+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 12:34:49.740+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.417
10-26 12:34:49.795+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [event]
10-26 12:34:49.795+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 12:34:49.805+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 12:34:49.805+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 12:34:49.840+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 12:34:49.845+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 12:34:49.920+0200 E/EFL     (16327): elementary<16327> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 12:34:49.925+0200 E/EFL     (16327): elementary<16327> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 12:34:49.945+0200 E/EFL     (16327): elementary<16327> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 12:34:49.950+0200 E/EFL     (16327): elementary<16327> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 12:34:49.965+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:34:49.975+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16288
10-26 12:34:49.975+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:34:49.985+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16288
10-26 12:34:49.985+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:34:49.995+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16288
10-26 12:34:49.995+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:34:50.000+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:34:50.000+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:34:50.015+0200 E/EFL     (16327): elementary<16327> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 12:34:50.015+0200 E/EFL     (16327): elementary<16327> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 12:34:50.025+0200 E/EFL     (16327): elementary<16327> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 12:34:50.025+0200 E/EFL     (16327): elementary<16327> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 12:34:50.025+0200 E/EFL     (16327): elementary<16327> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 12:34:50.045+0200 E/EFL     (16327): elementary<16327> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 12:34:50.045+0200 E/EFL     (16327): elementary<16327> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 12:34:50.045+0200 E/EFL     (16327): elementary<16327> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 12:34:50.095+0200 E/EFL     (16327): elementary<16327> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 12:34:50.115+0200 E/EFL     (16327): elementary<16327> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 12:34:50.115+0200 E/EFL     (16327): elementary<16327> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 12:34:50.115+0200 E/EFL     (16327): elementary<16327> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 12:34:50.115+0200 E/EFL     (16327): elementary<16327> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 12:34:50.115+0200 E/EFL     (16327): elementary<16327> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 12:34:50.115+0200 E/EFL     (16327): elementary<16327> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 12:34:50.115+0200 I/AUL_PAD (16327): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 12:34:51.445+0200 E/EFL     (16288): ecore_x<16288> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5485797 button=1
10-26 12:34:51.505+0200 E/EFL     (16288): ecore_x<16288> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5485857 button=1
10-26 12:34:51.585+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:51.585+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:51.590+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating X [01] axes. Need to calculate X [01] axes
10-26 12:34:51.595+0200 E/EFL     (16288): edje<16288> edje_calc.c:3445 _edje_part_recalc() Circular dependency when calculating part "group1". Already calculating XY [03] axes. Need to calculate Y [02] axes
10-26 12:34:51.600+0200 I/BluetoothServer(16080): Callback: Connected.
10-26 12:34:51.600+0200 I/BluetoothServer(16080): Callback: Socket of connection - 44.
10-26 12:34:51.600+0200 I/BluetoothServer(16080): Callback: Role of connection - 1.
10-26 12:34:51.600+0200 I/BluetoothServer(16080): Callback: Address of connection - B8:81:98:D4:F2:78.
10-26 12:34:51.710+0200 I/MALI    (16288): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
10-26 12:34:51.710+0200 I/MALI    (16288): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=16288   close drm_fd=27 
10-26 12:34:51.710+0200 I/MALI    (16288): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
10-26 12:34:51.735+0200 W/APP_CORE(16288): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:4800008
10-26 12:34:51.735+0200 I/APP_CORE(16288): appcore-efl.c: __do_app(429) > [APP 16288] Event: PAUSE State: RUNNING
10-26 12:34:51.735+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 12:34:51.740+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 12:34:51.740+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 12:34:51.740+0200 E/APP_CORE(16288): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
10-26 12:34:51.740+0200 I/APP_CORE(16288): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 12:34:51.740+0200 I/CAPI_APPFW_APPLICATION(16288): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
10-26 12:34:51.815+0200 I/UXT     (16288): Uxt_ObjectManager.cpp: OnTerminating(752) > Terminating.
10-26 12:34:51.925+0200 I/efl-extension(16288): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 12:34:52.090+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 16288 pgid = 16288
10-26 12:34:52.155+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 12:34:52.160+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16288
10-26 12:34:52.175+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.419
10-26 12:34:52.340+0200 E/EFL     (16080): ecore_x<16080> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5486690 button=1
10-26 12:34:52.400+0200 E/EFL     (16080): ecore_x<16080> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5486751 button=1
10-26 12:34:52.580+0200 E/RECORDING_TAG(16080): sensor_listener_unset_event_cb error: -38010874
10-26 12:34:52.585+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:34:52.585+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:34:52.675+0200 I/INFO_TAG(16080): SENSOR_EVENT2 HEART RATE : 78
10-26 12:34:52.690+0200 I/INFO_TAG(16080): SENSOR_EVENT2 TAB VALUE : 78
10-26 12:34:52.745+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:34:53.655+0200 I/INFO_TAG(16080): SENSOR_EVENT2 HEART RATE : 77
10-26 12:34:53.660+0200 I/INFO_TAG(16080): SENSOR_EVENT2 TAB VALUE : 77
10-26 12:34:53.740+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 12:34:54.660+0200 I/INFO_TAG(16080): SENSOR_EVENT2 HEART RATE : 77
10-26 12:34:54.665+0200 I/INFO_TAG(16080): SENSOR_EVENT2 TAB VALUE : 77
10-26 12:34:55.660+0200 I/INFO_TAG(16080): SENSOR_EVENT2 HEART RATE : 77
10-26 12:34:55.665+0200 I/INFO_TAG(16080): SENSOR_EVENT2 TAB VALUE : 77
10-26 12:34:56.255+0200 E/EFL     (16080): ecore_x<16080> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5490608 button=1
10-26 12:34:56.355+0200 E/EFL     (16080): ecore_x<16080> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5490704 button=1
10-26 12:34:56.365+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:34:56.370+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:34:56.700+0200 E/EFL     (16080): elementary<16080> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:34:59.150+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 12:34:59.580+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 12:34:59.625+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 12:34:59.625+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 12:34:59.650+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 12:34:59.655+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 12:34:59.690+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:34:59.690+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:34:59.695+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:34:59.695+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:34:59.700+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 12:34:59.865+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 12:34:59.950+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 12:35:00.685+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 12:35:00.685+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 12:35:00.685+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 12:35:00.690+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:35:00.690+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:35:00.690+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 12:35:00.690+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:35:00.690+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:35:00.690+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 12:35:01.265+0200 W/SHealth_Service( 1085): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
10-26 12:35:03.155+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:35:14.030+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:35:25.785+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 12:35:25.785+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 12:35:25.785+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 12:35:25.785+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 12:35:25.785+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 12:35:25.785+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 12:35:25.785+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:35:25.785+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 12:35:25.785+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 12:35:25.790+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 12:35:25.790+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 12:35:25.790+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 12:35:26.035+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:35:26.040+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 12:35:26.060+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 12:35:26.060+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 12:35:26.060+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 12:35:26.060+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 12:35:26.060+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 12:35:46), repeat(1), interval(20), type(-1073741822)
10-26 12:35:26.070+0200 I/APP_CORE(16080): appcore-efl.c: __do_app(429) > [APP 16080] Event: PAUSE State: RUNNING
10-26 12:35:26.070+0200 I/CAPI_APPFW_APPLICATION(16080): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 12:35:26.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 12:35:26.110+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:35:26.125+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1503625260, next duetime: 1509014146
10-26 12:35:26.125+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1503625260)
10-26 12:35:26.125+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509014146)
10-26 12:35:26.125+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 12:35:26.125+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 10:35:46 (UTC).
10-26 12:35:26.125+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 12:35:26.135+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 12:35:26.135+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 12:35:26.140+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:35:26.190+0200 I/APP_CORE(16080): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 12:35:26.190+0200 I/CAPI_APPFW_APPLICATION(16080): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 12:35:26.595+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 12:35:26.595+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:35:26.595+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 12:35:26.690+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 16080 pgid = 16080
10-26 12:35:26.695+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-26 12:35:26.695+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:35:26.700+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:35:26.725+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:35:26.730+0200 W/CRASH_MANAGER(16387): worker.c: worker_job(1205) > 1116080646174150901412
