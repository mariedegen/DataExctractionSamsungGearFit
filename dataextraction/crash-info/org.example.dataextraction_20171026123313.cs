S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 15475
Date: 2017-10-26 12:33:13+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15475, uid 5000)

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x41757f2c, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbebc53f8
r8   = 0xbebc54a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbebc53a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     32348 KB
Buffers:     38960 KB
Cached:     165692 KB
VmPeak:     100148 KB
VmSize:      98356 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21192 KB
VmRSS:       21192 KB
VmData:      41492 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25564 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15475 TID = 15475
15475 15582 

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
436c4000 43ec3000 rw-p [stack:15582]
43ec3000 43ece000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ed7000 43edc000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43ef6000 43ef7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4488c000 4488e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45a06000 45a07000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a0f000 45a12000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45a22000 45a29000 r-xp /usr/lib/libfeedback.so.0.1.4
45a32000 45a33000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a3b000 45a3d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a45000 45a4f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a57000 45a5e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a66000 45a7c000 r-xp /usr/lib/libmmfsound.so.0.1.0
45a8e000 45a93000 r-xp /usr/lib/libmmfsession.so.0.0.0
45a9b000 45aa5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45ab1000 45ab5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45abe000 45ad3000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45adb000 45b3c000 r-xp /usr/lib/libasound.so.2.0.0
45b46000 45b49000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b51000 45b89000 r-xp /usr/lib/libpulse.so.0.16.2
45b8a000 45bbb000 r-xp /usr/lib/libmdm.so.1.1.86
45bc3000 45bc8000 r-xp /usr/lib/libjson.so.0.0.1
45bd0000 45c18000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c19000 45c60000 r-xp /usr/lib/libsndfile.so.1.0.26
45c6c000 45c74000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c75000 45c97000 r-xp /usr/lib/libvorbis.so.0.4.3
45c9f000 45ca3000 r-xp /usr/lib/libogg.so.0.7.1
45cab000 45cac000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
beba5000 bebc6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15475)
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
issue - no interface
10-26 12:32:24.015+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(15475)
10-26 12:32:24.015+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 12:32:24.035+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 12:32:24.125+0200 I/Bluetooth(15475): [bt_initialize] success.
10-26 12:32:24.175+0200 I/Bluetooth(15475): [bt_socket_create_rfcomm] success.
10-26 12:32:24.260+0200 I/dataextraction(15475): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
10-26 12:32:24.260+0200 I/Bluetooth(15475): [bt_adapter_le_create_advertiser] success.
10-26 12:32:24.275+0200 I/Bluetooth(15475): [bt_adapter_le_set_advertising_mode] success.
10-26 12:32:24.280+0200 I/Bluetooth(15475): [bt_adapter_le_set_advertising_connectable] success.
10-26 12:32:24.280+0200 I/Bluetooth(15475): [bt_adapter_le_set_advertising_device_name] success.
10-26 12:32:24.280+0200 I/Bluetooth(15475): [bt_adapter_le_set_advertising_device_name] success.
10-26 12:32:24.410+0200 I/Bluetooth(15475): [bt_adapter_le_start_advertising_new] success.
10-26 12:32:24.410+0200 I/Bluetooth(15475): Heart Rate Measurement advertiser started.
10-26 12:32:24.445+0200 I/Bluetooth(15475): [bt_adapter_le_stop_advertising] success.
10-26 12:32:24.445+0200 I/Bluetooth(15475): [bt_adapter_le_clear_advertising_data] success.
10-26 12:32:24.445+0200 I/Bluetooth(15475): [bt_adapter_le_set_advertising_device_name] success.
10-26 12:32:24.445+0200 I/Bluetooth(15475): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 12:32:24.545+0200 I/Bluetooth(15475): [bt_adapter_le_start_advertising_new] success.
10-26 12:32:24.610+0200 E/EFL     (15475): ecore_evas<15475> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 12:32:24.830+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 12:32:24.830+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.830+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.830+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.855+0200 I/APP_CORE(15475): appcore-efl.c: __do_app(429) > [APP 15475] Event: RESET State: CREATED
10-26 12:32:24.855+0200 I/CAPI_APPFW_APPLICATION(15475): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 12:32:24.870+0200 I/APP_CORE(15475): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 12:32:24.870+0200 I/APP_CORE(15475): appcore-efl.c: __do_app(474) > [APP 15475] Initial Launching, call the resume_cb
10-26 12:32:24.870+0200 I/CAPI_APPFW_APPLICATION(15475): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 12:32:24.880+0200 W/APP_CORE(15475): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.935+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 12:32:24.935+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 12:32:24.935+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 12:32:24.935+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.935+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 12:32:24.940+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 12:32:24.970+0200 E/TBM     (  406): tbm_bufmgr.c: _tgl_destroy(151) > [libtbm:406] error(Device or resource busy) _tgl_destroy:151 key:33
10-26 12:32:24.985+0200 I/APP_CORE(15475): appcore-efl.c: __do_app(429) > [APP 15475] Event: RESUME State: RUNNING
10-26 12:32:24.990+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 12:32:25.010+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 12:32:25.030+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 12:32:25.170+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:32:25.180+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15475
10-26 12:32:25.180+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:32:25.190+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15475
10-26 12:32:25.190+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:32:25.190+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:32:25.205+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:32:25.210+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15475
10-26 12:32:25.220+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:32:25.235+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:32:25.235+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:32:25.285+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 12:32:25.445+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 12:32:25.535+0200 E/EFL     (15593): elementary<15593> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 12:32:25.540+0200 E/EFL     (15593): elementary<15593> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 12:32:25.555+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:32:25.575+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:32:25.765+0200 E/EFL     (15593): elementary<15593> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 12:32:25.765+0200 E/EFL     (15593): elementary<15593> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 12:32:25.830+0200 E/EFL     (15593): elementary<15593> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 12:32:25.830+0200 E/EFL     (15593): elementary<15593> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 12:32:25.845+0200 E/EFL     (15593): elementary<15593> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 12:32:25.845+0200 E/EFL     (15593): elementary<15593> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 12:32:25.845+0200 E/EFL     (15593): elementary<15593> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 12:32:25.865+0200 E/EFL     (15593): elementary<15593> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 12:32:25.870+0200 E/EFL     (15593): elementary<15593> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 12:32:25.870+0200 E/EFL     (15593): elementary<15593> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 12:32:25.925+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:32:25.950+0200 E/EFL     (15593): elementary<15593> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 12:32:25.955+0200 E/EFL     (15593): elementary<15593> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 12:32:25.955+0200 E/EFL     (15593): elementary<15593> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 12:32:25.960+0200 E/EFL     (15593): elementary<15593> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 12:32:25.960+0200 E/EFL     (15593): elementary<15593> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 12:32:25.960+0200 E/EFL     (15593): elementary<15593> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 12:32:25.960+0200 E/EFL     (15593): elementary<15593> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 12:32:25.960+0200 I/AUL_PAD (15593): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 12:32:27.105+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5341453 button=1
10-26 12:32:27.160+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5341512 button=1
10-26 12:32:27.330+0200 E/RECORDING_TAG(15475): sensor_listener_unset_event_cb error: -38010874
10-26 12:32:27.335+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:32:27.360+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:32:27.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 63
10-26 12:32:27.575+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 63
10-26 12:32:27.730+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:32:28.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 63
10-26 12:32:28.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 63
10-26 12:32:29.380+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:32:29.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 63
10-26 12:32:29.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 63
10-26 12:32:29.955+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 12:32:30.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 63
10-26 12:32:30.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 63
10-26 12:32:31.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 65
10-26 12:32:31.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 65
10-26 12:32:32.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 66
10-26 12:32:32.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 66
10-26 12:32:33.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 66
10-26 12:32:33.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 66
10-26 12:32:34.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 65
10-26 12:32:34.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 65
10-26 12:32:35.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 64
10-26 12:32:35.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 64
10-26 12:32:36.375+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5350726 button=1
10-26 12:32:36.425+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5350774 button=1
10-26 12:32:36.540+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5350886 button=1
10-26 12:32:36.560+0200 I/INFO_TAG(15475): SENSOR_EVENT2 HEART RATE : 63
10-26 12:32:36.565+0200 I/INFO_TAG(15475): SENSOR_EVENT2 TAB VALUE : 63
10-26 12:32:36.585+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5350934 button=1
10-26 12:32:37.085+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5351435 button=1
10-26 12:32:37.145+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5351496 button=1
10-26 12:32:37.155+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:32:37.170+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:32:37.520+0200 E/EFL     (15475): elementary<15475> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:32:44.115+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5358466 button=1
10-26 12:32:44.150+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5358500 button=1
10-26 12:32:44.275+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5358625 button=1
10-26 12:32:44.345+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5358697 button=1
10-26 12:32:44.530+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5358883 button=1
10-26 12:32:44.595+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5358943 button=1
10-26 12:32:44.665+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5359018 button=1
10-26 12:32:44.750+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5359103 button=1
10-26 12:32:44.990+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5359339 button=1
10-26 12:32:45.025+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5359374 button=1
10-26 12:32:45.135+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5359486 button=1
10-26 12:32:45.185+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5359534 button=1
10-26 12:32:45.270+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5359621 button=1
10-26 12:32:45.320+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5359669 button=1
10-26 12:32:45.545+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5359894 button=1
10-26 12:32:45.600+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5359953 button=1
10-26 12:32:45.700+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5360052 button=1
10-26 12:32:45.750+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5360100 button=1
10-26 12:32:45.850+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5360199 button=1
10-26 12:32:45.885+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5360235 button=1
10-26 12:32:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:32:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:32:46.035+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:32:46.035+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:32:46.040+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>64</color> bpm</color>][0;m
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:32:46.040+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:32:46.110+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5360458 button=1
10-26 12:32:46.145+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5360494 button=1
10-26 12:32:46.315+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5360667 button=1
10-26 12:32:46.350+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5360703 button=1
10-26 12:32:46.855+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5361204 button=1
10-26 12:32:46.875+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5361227 button=1
10-26 12:32:47.085+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5361437 button=1
10-26 12:32:47.135+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5361486 button=1
10-26 12:32:47.295+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5361647 button=1
10-26 12:32:47.345+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5361695 button=1
10-26 12:32:47.590+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5361942 button=1
10-26 12:32:47.650+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5362002 button=1
10-26 12:32:47.825+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5362176 button=1
10-26 12:32:47.900+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5362249 button=1
10-26 12:32:48.120+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5362471 button=1
10-26 12:32:48.170+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5362519 button=1
10-26 12:32:48.345+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5362693 button=1
10-26 12:32:48.405+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5362753 button=1
10-26 12:32:48.475+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5362828 button=1
10-26 12:32:48.565+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5362913 button=1
10-26 12:32:48.600+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5362951 button=1
10-26 12:32:48.685+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5363037 button=1
10-26 12:32:48.920+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5363271 button=1
10-26 12:32:48.980+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5363332 button=1
10-26 12:32:49.080+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5363431 button=1
10-26 12:32:49.140+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5363492 button=1
10-26 12:32:49.340+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5363693 button=1
10-26 12:32:49.390+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5363740 button=1
10-26 12:32:49.490+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5363841 button=1
10-26 12:32:49.560+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5363913 button=1
10-26 12:32:49.785+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5364135 button=1
10-26 12:32:49.830+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5364183 button=1
10-26 12:32:49.935+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5364283 button=1
10-26 12:32:50.005+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5364356 button=1
10-26 12:32:50.120+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5364468 button=1
10-26 12:32:50.200+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5364552 button=1
10-26 12:32:50.380+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5364729 button=1
10-26 12:32:50.435+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5364788 button=1
10-26 12:32:50.550+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5364900 button=1
10-26 12:32:50.620+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5364972 button=1
10-26 12:32:50.700+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5365047 button=1
10-26 12:32:50.770+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5365120 button=1
10-26 12:32:50.940+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5365293 button=1
10-26 12:32:51.005+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5365353 button=1
10-26 12:32:51.215+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5365564 button=1
10-26 12:32:51.300+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5365649 button=1
10-26 12:32:51.525+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5365875 button=1
10-26 12:32:51.570+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5365921 button=1
10-26 12:32:51.660+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5366009 button=1
10-26 12:32:51.745+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5366094 button=1
10-26 12:32:51.955+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5366304 button=1
10-26 12:32:52.015+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5366364 button=1
10-26 12:32:52.250+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5366599 button=1
10-26 12:32:52.285+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5366635 button=1
10-26 12:32:52.510+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5366863 button=1
10-26 12:32:52.560+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5366910 button=1
10-26 12:32:52.810+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5367158 button=1
10-26 12:32:52.880+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5367230 button=1
10-26 12:32:53.035+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:32:53.055+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5367403 button=1
10-26 12:32:53.115+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5367463 button=1
10-26 12:32:53.225+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5367575 button=1
10-26 12:32:53.270+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5367623 button=1
10-26 12:32:53.360+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5367710 button=1
10-26 12:32:53.420+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5367771 button=1
10-26 12:32:53.680+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5368032 button=1
10-26 12:32:53.730+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5368079 button=1
10-26 12:32:53.825+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5368178 button=1
10-26 12:32:53.900+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5368251 button=1
10-26 12:32:54.035+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5368387 button=1
10-26 12:32:54.110+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5368460 button=1
10-26 12:32:54.170+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5368522 button=1
10-26 12:32:54.260+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5368608 button=1
10-26 12:32:54.480+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5368830 button=1
10-26 12:32:54.530+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5368878 button=1
10-26 12:32:54.640+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5368990 button=1
10-26 12:32:54.685+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5369038 button=1
10-26 12:32:55.035+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5369384 button=1
10-26 12:32:55.095+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5369444 button=1
10-26 12:32:55.180+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5369531 button=1
10-26 12:32:55.265+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5369617 button=1
10-26 12:32:55.365+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5369716 button=1
10-26 12:32:55.475+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5369826 button=1
10-26 12:32:55.665+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5370013 button=1
10-26 12:32:55.735+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5370085 button=1
10-26 12:32:55.895+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5370247 button=1
10-26 12:32:55.965+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5370318 button=1
10-26 12:32:56.155+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=5370506 button=1
10-26 12:32:56.225+0200 E/EFL     (15475): ecore_x<15475> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5370577 button=1
10-26 12:32:57.705+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 12:32:58.085+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 12:32:58.355+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 12:32:58.460+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 12:32:58.460+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 12:32:58.465+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 12:32:58.485+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 12:32:58.550+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 12:32:58.575+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:32:58.580+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:32:58.580+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:32:58.585+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:32:58.875+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 12:32:58.965+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 12:33:00.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 12:33:00.760+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 12:33:00.760+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 12:33:00.760+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:33:00.765+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:33:00.765+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 12:33:00.765+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:33:00.765+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:33:00.765+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 12:33:02.460+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:33:12.680+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:33:12.750+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 12:33:12.750+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 12:33:12.750+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 12:33:12.850+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 12:33:12.850+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 12:33:12.850+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 12:33:12.850+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 12:33:12.850+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 12:33:12.850+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:12.850+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-26 12:33:12.850+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 12:33:12.855+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 12:33:12.855+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 12:33:12.855+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 12:33:12.865+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 12:33:13.100+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:33:13.105+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:33:13.110+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 12:33:13.110+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-26 12:33:13.110+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 12:33:13.110+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 12:33:13.110+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 12:33:13.110+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 12:33:33), repeat(1), interval(20), type(-1073741822)
10-26 12:33:13.120+0200 I/APP_CORE(15475): appcore-efl.c: __do_app(429) > [APP 15475] Event: PAUSE State: RUNNING
10-26 12:33:13.120+0200 I/CAPI_APPFW_APPLICATION(15475): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 12:33:13.135+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 12:33:13.165+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:33:13.200+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 75481807, next duetime: 1509014013
10-26 12:33:13.200+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(75481807)
10-26 12:33:13.200+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509014013)
10-26 12:33:13.200+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 12:33:13.205+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 10:33:33 (UTC).
10-26 12:33:13.205+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 12:33:13.225+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 12:33:13.225+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 12:33:13.265+0200 I/APP_CORE(15475): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 12:33:13.265+0200 I/CAPI_APPFW_APPLICATION(15475): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 12:33:13.665+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:33:13.665+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 12:33:13.675+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 15475 pgid = 15475
10-26 12:33:13.700+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 12:33:13.800+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-26 12:33:13.800+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:13.805+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:13.805+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:13.815+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-26 12:33:13.815+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-26 12:33:13.820+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:13.820+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-26 12:33:13.820+0200 I/APP_CORE(  769): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
10-26 12:33:13.820+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-26 12:33:13.865+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 12:33:13.870+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15475
10-26 12:33:13.885+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.381
10-26 12:33:13.940+0200 W/CRASH_MANAGER(15699): worker.c: worker_job(1205) > 1115475646174150901399
