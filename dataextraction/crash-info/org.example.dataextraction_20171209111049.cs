S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 1461
Date: 2017-12-09 11:10:49+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1461, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x43d00010, r3   = 0x41644d59
r4   = 0xbe9df504, r5   = 0x41441980
r6   = 0x00000249, r7   = 0xbe9df440
r8   = 0xbe9df4d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbe9df428
lr   = 0x41644d75, pc   = 0x416462a8
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:    101384 KB
Buffers:     24948 KB
Cached:     149520 KB
VmPeak:      96812 KB
VmSize:      96440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18192 KB
VmRSS:       18188 KB
VmData:      40476 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25044 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1461 TID = 1461
1461 1532 1539 1540 

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
41693000 41698000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416a0000 416a4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
416ad000 416ce000 r-xp /usr/lib/libefl-extension.so.0.1.0
416d7000 41711000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4171a000 41733000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4173b000 41740000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41748000 41772000 r-xp /usr/lib/libsensor.so.1.9.6
4177b000 41833000 r-xp /usr/lib/libcairo.so.2.11200.14
4183e000 41841000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41849000 4184f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41858000 41860000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41868000 41872000 r-xp /usr/lib/libsensord-shared.so
4187b000 41889000 r-xp /usr/lib/libGLESv2.so.2.0
41892000 41893000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4189c000 418a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
418aa000 418ad000 r-xp /usr/lib/libEGL.so.1.4
418b5000 418c2000 r-xp /usr/lib/libail.so.0.1.0
418cb000 41a08000 r-xp /usr/lib/libicui18n.so.51.1
41a18000 41a34000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41a3d000 41a44000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41a4d000 41a4f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41a57000 41a5e000 r-xp /usr/lib/libminizip.so.1.0.0
41a66000 41a71000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41a7d000 41a7f000 rw-p [heap]
41a7f000 41b95000 rw-p [heap]
41b95000 41c79000 r-xp /usr/lib/libicuuc.so.51.1
43217000 432e1000 r-xp /usr/lib/libCOREGL.so.4.0
434f4000 43cf3000 rw-p [stack:1532]
43cf3000 43cf5000 r-xp /usr/lib/libdri2.so.0.0.0
43e00000 43e05000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43e13000 43e1b000 r-xp /usr/lib/libdrm.so.2.4.0
43e23000 43e2a000 r-xp /usr/lib/libtbm.so.1.0.0
43fcd000 43fce000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fd7000 447d6000 rw-p [stack:1539]
447d7000 44fd6000 rw-p [stack:1540]
45932000 45935000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
4593d000 4593e000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
45946000 45947000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45962000 45969000 r-xp /usr/lib/libfeedback.so.0.1.4
45972000 45973000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4597b000 4597d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45985000 4598f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45997000 4599e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
459a6000 459bc000 r-xp /usr/lib/libmmfsound.so.0.1.0
459ce000 459d3000 r-xp /usr/lib/libmmfsession.so.0.0.0
459db000 459e5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
459f1000 459f5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
459fe000 45a13000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45a1b000 45a7c000 r-xp /usr/lib/libasound.so.2.0.0
45a86000 45a89000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a91000 45ac9000 r-xp /usr/lib/libpulse.so.0.16.2
45aca000 45afb000 r-xp /usr/lib/libmdm.so.1.1.86
45b03000 45b08000 r-xp /usr/lib/libjson.so.0.0.1
45b10000 45b58000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45b59000 45ba0000 r-xp /usr/lib/libsndfile.so.1.0.26
45bac000 45bb4000 r-xp /usr/lib/libmdm-common.so.1.0.89
45bb5000 45bd7000 r-xp /usr/lib/libvorbis.so.0.4.3
45bdf000 45be3000 r-xp /usr/lib/libogg.so.0.7.1
be9bf000 be9e0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1461)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x416462a8) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x32a8
 1: app_terminate + 0x1c (0x41644d75) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d75
 2: (0x41440af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41644d07) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d07
 6: bluetooth_screen + 0xda (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: main + 0x6f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
-------
12-09 11:10:14.875+0200 E/rpm-installer( 1451): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
12-09 11:10:14.875+0200 E/rpm-installer( 1451): rpm-appcore-intf.c: main(275) > ------------------------------------------------
12-09 11:10:14.900+0200 E/PKGMGR_SERVER( 1450): pkgmgr-server.c: sighandler(409) > child NORMAL exit [1451]
12-09 11:10:15.010+0200 E/RESOURCED(  532): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/1451/oom_score_adj failed
12-09 11:10:15.010+0200 E/RESOURCED(  532): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 1451
12-09 11:10:15.635+0200 E/PKGMGR_SERVER( 1450): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
12-09 11:10:15.640+0200 E/PKGMGR_SERVER( 1450): pkgmgr-server.c: main(2221) > package manager server terminated.
12-09 11:10:18.080+0200 W/AUL     ( 1531): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
12-09 11:10:18.085+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 0
12-09 11:10:18.110+0200 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
12-09 11:10:18.125+0200 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
12-09 11:10:18.125+0200 E/AUL_AMD (  530): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
12-09 11:10:18.125+0200 W/AUL_AMD (  530): amd_launch.c: _start_app(1710) > caller pid : 1531
12-09 11:10:18.140+0200 W/AUL_AMD (  530): amd_launch.c: _start_app(2124) > pad pid(-5)
12-09 11:10:18.145+0200 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
12-09 11:10:18.145+0200 W/AUL_PAD ( 1231): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
12-09 11:10:18.145+0200 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
12-09 11:10:18.155+0200 W/AUL_PAD ( 1231): launchpad.c: __send_result_to_caller(272) > Check app launching
12-09 11:10:18.205+0200 I/efl-extension( 1461): efl_extension.c: eext_mod_init(40) > Init
12-09 11:10:18.220+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: ui_app_main(704) > app_efl_main
12-09 11:10:18.225+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
12-09 11:10:18.260+0200 W/AUL     ( 1531): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1461)
12-09 11:10:18.285+0200 E/RESOURCED(  532): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
12-09 11:10:18.335+0200 I/Bluetooth( 1461): [bt_initialize] success.
12-09 11:10:18.370+0200 I/Bluetooth( 1461): [bt_adapter_get_state] success.
12-09 11:10:18.445+0200 E/EFL     ( 1461): ecore_evas<1461> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
12-09 11:10:18.760+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: RESET State: CREATED
12-09 11:10:18.760+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
12-09 11:10:18.785+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
12-09 11:10:18.785+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(474) > [APP 1461] Initial Launching, call the resume_cb
12-09 11:10:18.785+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:10:18.820+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
12-09 11:10:18.835+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:18.835+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:18.840+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:18.840+0200 W/APP_CORE( 1461): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
12-09 11:10:18.925+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
12-09 11:10:18.925+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
12-09 11:10:18.925+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:18.925+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
12-09 11:10:18.940+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: PAUSE State: PAUSED
12-09 11:10:18.940+0200 I/APP_CORE(  779): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-09 11:10:18.940+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
12-09 11:10:18.945+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:10:18.945+0200 W/AUL_AMD (  530): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-09 11:10:18.960+0200 I/APP_CORE( 1461): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-09 11:10:18.965+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:18.965+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:18.965+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:19.180+0200 E/EFL     ( 1461): elementary<1461> elc_naviframe.c:1211 _on_item_show_finished() item show finished
12-09 11:10:19.180+0200 E/EFL     ( 1461): elementary<1461> elc_naviframe.c:1211 _on_item_show_finished() item show finished
12-09 11:10:19.185+0200 E/EFL     ( 1461): elementary<1461> elc_naviframe.c:1211 _on_item_show_finished() item show finished
12-09 11:10:19.255+0200 E/AUL     (  530): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
12-09 11:10:19.370+0200 E/RESOURCED(  532): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.150
12-09 11:10:19.415+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 14
12-09 11:10:19.425+0200 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1461
12-09 11:10:19.425+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 12
12-09 11:10:19.425+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 14
12-09 11:10:19.435+0200 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1461
12-09 11:10:19.435+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 12
12-09 11:10:19.560+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:558 elm_quicklaunch_init() eet_init done.
12-09 11:10:19.560+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
12-09 11:10:19.585+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
12-09 11:10:19.590+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
12-09 11:10:19.630+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
12-09 11:10:19.635+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
12-09 11:10:19.640+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
12-09 11:10:19.640+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
12-09 11:10:19.640+0200 E/EFL     ( 1542): elementary<1542> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
12-09 11:10:19.665+0200 E/EFL     ( 1542): elementary<1542> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
12-09 11:10:19.670+0200 E/EFL     ( 1542): elementary<1542> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
12-09 11:10:19.670+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
12-09 11:10:19.720+0200 E/EFL     ( 1542): elementary<1542> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
12-09 11:10:19.725+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:19.725+0200 E/EFL     ( 1542): elementary<1542> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
12-09 11:10:19.730+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
12-09 11:10:19.730+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
12-09 11:10:19.730+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
12-09 11:10:19.730+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
12-09 11:10:19.730+0200 E/EFL     ( 1542): elementary<1542> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
12-09 11:10:19.730+0200 I/AUL_PAD ( 1542): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
12-09 11:10:19.930+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:10:19.930+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:10:19.935+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:19.940+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-09 11:10:19.940+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:10:19.965+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:10:19.965+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:10:19.965+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:19.970+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:10:19.970+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:10:19.970+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:10:19.970+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:10:19.970+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:21923
12-09 11:10:19.970+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:10:19.970+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:10:19.970+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:19.970+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [21923]ms
12-09 11:10:19.970+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:19.980+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: RESUME State: RUNNING
12-09 11:10:20.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:10:20.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:20.010+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:10:20.050+0200 W/SHealth_Service( 1081): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
12-09 11:10:20.050+0200 W/SHealth_Service( 1081): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
12-09 11:10:20.050+0200 W/SHealth_Service( 1081): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:20.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:10:20.170+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-09 11:10:20.170+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:10:20.170+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:10:20.175+0200 E/EFL     (  779): evas_main<779> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46ed1578 is not stable during recalc loop
12-09 11:10:20.175+0200 E/EFL     (  779): evas_main<779> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46ed1578 is not stable during recalc loop
12-09 11:10:20.185+0200 I/MALI    (  779): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
12-09 11:10:20.215+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:10:20.215+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:10:20.230+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
12-09 11:10:20.230+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:20.245+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:10:20.730+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:21.735+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:22.040+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:10:22.040+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:10:22.050+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:22.175+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:10:22.175+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:10:22.175+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:10:22.175+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:10:22.175+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:10:22.175+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:10:22.175+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:22.185+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
12-09 11:10:22.185+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:10:22.190+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:10:22.190+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:10:22.190+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:10:22.475+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
12-09 11:10:22.475+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:22.480+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:10:22.480+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:10:22.510+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: PAUSE State: RUNNING
12-09 11:10:22.510+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:10:22.595+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:10:43), repeat(1), interval(20), type(-1073741822)
12-09 11:10:22.610+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:10:22.670+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 731691679, next duetime: 1512810643
12-09 11:10:22.670+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(731691679)
12-09 11:10:22.670+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512810643)
12-09 11:10:22.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:10:22.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:10:43 (UTC).
12-09 11:10:22.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:10:22.690+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:10:22.690+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:10:22.690+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:10:22.725+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:23.640+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:10:23.640+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:10:23.640+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:23.650+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-09 11:10:23.650+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:10:23.705+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:10:23.705+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:10:23.705+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:23.710+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:10:23.710+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:10:23.710+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:10:23.710+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:10:23.710+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:1576
12-09 11:10:23.710+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:10:23.710+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:10:23.710+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:23.710+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [1576]ms
12-09 11:10:23.710+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:23.730+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:23.735+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: RESUME State: PAUSED
12-09 11:10:23.735+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:10:23.760+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:10:23.760+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(731691679)
12-09 11:10:23.760+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:10:23.760+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:10:23.760+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:10:23.760+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[731691679] is removed.
12-09 11:10:23.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:10:23.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:23.780+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:23.835+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:10:23.915+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:10:23.920+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-09 11:10:23.920+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:10:23.920+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:10:23.930+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:10:23.930+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:10:23.945+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
12-09 11:10:23.945+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:24.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:25.735+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:26.345+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:10:26.345+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:10:26.360+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:26.480+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:10:26.480+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:10:26.480+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:10:26.480+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:10:26.480+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:10:26.480+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:10:26.480+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:26.495+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
12-09 11:10:26.495+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:10:26.495+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:10:26.495+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:10:26.495+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:10:26.780+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : 0
12-09 11:10:26.810+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
12-09 11:10:26.810+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:26.810+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:10:26.810+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:10:26.810+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:10:47), repeat(1), interval(20), type(-1073741822)
12-09 11:10:26.825+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: PAUSE State: RUNNING
12-09 11:10:26.825+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:10:26.880+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:10:26.930+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1655742677, next duetime: 1512810647
12-09 11:10:26.930+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1655742677)
12-09 11:10:26.935+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512810647)
12-09 11:10:26.935+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:10:26.935+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:10:47 (UTC).
12-09 11:10:26.935+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:10:26.940+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:10:26.950+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:10:26.950+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:10:27.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:28.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:29.745+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:29.865+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
12-09 11:10:29.865+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
12-09 11:10:29.900+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:29.930+0200 E/wnoti-service(  874): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
12-09 11:10:29.930+0200 E/wnoti-service(  874): wnoti-native-client.c: handle_cache_notification(603) > >>
12-09 11:10:29.960+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
12-09 11:10:30.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:31.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:31.830+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: MEM_FLUSH State: PAUSED
12-09 11:10:32.745+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:33.280+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:10:33.280+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:10:33.280+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:33.290+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:10:33.290+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:10:33.290+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:10:33.295+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:10:33.295+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:6738
12-09 11:10:33.295+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:10:33.295+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:10:33.295+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:33.295+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [6738]ms
12-09 11:10:33.295+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:33.340+0200 I/APP_CORE( 1461): appcore-efl.c: __do_app(429) > [APP 1461] Event: RESUME State: PAUSED
12-09 11:10:33.340+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:10:33.365+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:10:33.365+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1655742677)
12-09 11:10:33.365+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:10:33.365+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:10:33.365+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:10:33.365+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1655742677] is removed.
12-09 11:10:33.400+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:10:33.400+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:33.400+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:10:33.405+0200 W/SHealth_Service( 1081): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:10:33.410+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:10:33.415+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:10:33.415+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:10:33.415+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:10:33.415+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:10:33.430+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:10:33.450+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-09 11:10:33.450+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:10:33.490+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
12-09 11:10:33.490+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:10:33.490+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:10:33.745+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:34.745+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:35.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:36.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:37.680+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
12-09 11:10:37.680+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
12-09 11:10:37.740+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:38.745+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:39.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:40.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:41.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:42.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:43.745+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:44.755+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:45.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:46.315+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-09 11:10:46.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:47.750+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:48.755+0200 I/INFO_TAG( 1461): SENSOR_EVENT HEART RATE < 40 : -3
12-09 11:10:49.675+0200 E/EFL     ( 1461): ecore_x<1461> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=97039 button=1
12-09 11:10:49.720+0200 E/EFL     ( 1461): ecore_x<1461> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=97084 button=1
12-09 11:10:49.925+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 22
12-09 11:10:49.925+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(916) > app status : 4
12-09 11:10:49.970+0200 E/APP_CORE( 1461): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-09 11:10:49.970+0200 I/APP_CORE( 1461): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-09 11:10:49.970+0200 I/APP_CORE( 1461): appcore-efl.c: __after_loop(1089) > [APP 1461] PAUSE before termination
12-09 11:10:49.970+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:10:49.970+0200 I/CAPI_APPFW_APPLICATION( 1461): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-09 11:10:50.360+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1461 pgid = 1461
12-09 11:10:50.390+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:10:50.390+0200 W/AUL_AMD (  530): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-09 11:10:50.485+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-09 11:10:50.515+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
12-09 11:10:50.520+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.520+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.535+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.550+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
12-09 11:10:50.550+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
12-09 11:10:50.550+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
12-09 11:10:50.550+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:50.550+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
12-09 11:10:50.550+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.555+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
12-09 11:10:50.555+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: RESUME State: PAUSED
12-09 11:10:50.565+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 11:10:50.565+0200 W/W_HOME  (  779): main.c: _appcore_resume_cb(687) > appcore resume
12-09 11:10:50.565+0200 W/W_HOME  (  779): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
12-09 11:10:50.565+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.575+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.575+0200 W/W_HOME  (  779): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
12-09 11:10:50.575+0200 W/W_HOME  (  779): main.c: home_resume(739) > clock/widget resumed
12-09 11:10:50.575+0200 W/W_HOME  (  779): clock_indicator.c: clock_indicator_resume(537) > 
12-09 11:10:50.595+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 11:10:50.605+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
12-09 11:10:50.610+0200 W/WATCH_CORE(  812): appcore-watch.c: __widget_resume(1039) > widget_resume
12-09 11:10:50.610+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:10:50.660+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
12-09 11:10:50.660+0200 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1461
12-09 11:10:50.670+0200 E/RESOURCED(  532): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.152
12-09 11:10:50.755+0200 W/CRASH_MANAGER( 1596): worker.c: worker_job(1205) > 1101461646174151281064
