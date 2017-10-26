S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18012
Date: 2017-10-26 13:07:51+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18012, uid 5000)

Register Information
r0   = 0x4335d618, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0x4334d1c8
r4   = 0x4338a2d0, r5   = 0x43357400
r6   = 0x432f7108, r7   = 0xbed4f258
r8   = 0x00000000, r9   = 0x43367be8
r10  = 0x43365118, fp   = 0x00000001
ip   = 0x41758214, sp   = 0xbed4f228
lr   = 0x404e5ab4, pc   = 0x41746750
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     17064 KB
Buffers:     43456 KB
Cached:     174060 KB
VmPeak:      98684 KB
VmSize:      97208 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19452 KB
VmRSS:       19448 KB
VmData:      40420 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25548 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 18012 TID = 18012
18012 18048 18057 

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
436c5000 43ec4000 rw-p [stack:18048]
43ec4000 43ecf000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ed8000 43edd000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43ef7000 43ef8000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4408c000 4408e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45097000 45996000 rw-p [stack:18057]
45b06000 45b07000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45b22000 45b29000 r-xp /usr/lib/libfeedback.so.0.1.4
45b32000 45b33000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45b3b000 45b3d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45b45000 45b4f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45b57000 45b5e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45b66000 45b7c000 r-xp /usr/lib/libmmfsound.so.0.1.0
45b8e000 45b93000 r-xp /usr/lib/libmmfsession.so.0.0.0
45b9b000 45ba5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45bb1000 45bb5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45bbe000 45bd3000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45bdb000 45c3c000 r-xp /usr/lib/libasound.so.2.0.0
45c46000 45c49000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45c51000 45c89000 r-xp /usr/lib/libpulse.so.0.16.2
45c8a000 45cbb000 r-xp /usr/lib/libmdm.so.1.1.86
45cc3000 45cc8000 r-xp /usr/lib/libjson.so.0.0.1
45cd0000 45d18000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45d19000 45d60000 r-xp /usr/lib/libsndfile.so.1.0.26
45d6c000 45d74000 r-xp /usr/lib/libmdm-common.so.1.0.89
45d75000 45d97000 r-xp /usr/lib/libvorbis.so.0.4.3
45d9f000 45da3000 r-xp /usr/lib/libogg.so.0.7.1
bed2f000 bed50000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18012)
Call Stack Count: 18
 0: start_bt_server + 0x13 (0x41746750) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3750
 1: clicked_recording_stop + 0xda (0x41745a9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2a9b
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
13: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x10e (0x41744f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
15: (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
16: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
17: bluetooth_screen + 0xd7 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 13:07:32.510+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.510+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.510+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.535+0200 I/APP_CORE(17943): appcore-efl.c: __do_app(429) > [APP 17943] Event: RESET State: CREATED
10-26 13:07:32.540+0200 I/CAPI_APPFW_APPLICATION(17943): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 13:07:32.555+0200 I/APP_CORE(17943): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 13:07:32.555+0200 I/APP_CORE(17943): appcore-efl.c: __do_app(474) > [APP 17943] Initial Launching, call the resume_cb
10-26 13:07:32.555+0200 I/CAPI_APPFW_APPLICATION(17943): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 13:07:32.565+0200 W/APP_CORE(17943): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200002
10-26 13:07:32.615+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 13:07:32.615+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 13:07:32.615+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.615+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 13:07:32.615+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:07:32.615+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:07:32.615+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:07:32.615+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:07:32.615+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.620+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.620+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:07:32.625+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:07:32.640+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:32.640+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:07:32.640+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:07:32.655+0200 I/APP_CORE(17943): appcore-efl.c: __do_app(429) > [APP 17943] Event: RESUME State: RUNNING
10-26 13:07:32.725+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 13:07:32.915+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:32.920+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:32.955+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:07:33.025+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 13:07:33.045+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 13:07:33.145+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:07:33.230+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.469
10-26 13:07:33.300+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:33.305+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17943
10-26 13:07:33.310+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:33.315+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17943
10-26 13:07:33.315+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:07:33.325+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:07:33.350+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:33.355+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17943
10-26 13:07:33.360+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:07:33.400+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:33.440+0200 E/EFL     (18012): elementary<18012> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:07:33.440+0200 E/EFL     (18012): elementary<18012> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:07:33.465+0200 E/EFL     (18012): elementary<18012> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:07:33.465+0200 E/EFL     (18012): elementary<18012> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:07:33.500+0200 E/EFL     (18012): elementary<18012> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:07:33.500+0200 E/EFL     (18012): elementary<18012> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:07:33.505+0200 E/EFL     (18012): elementary<18012> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:07:33.505+0200 E/EFL     (18012): elementary<18012> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:07:33.505+0200 E/EFL     (18012): elementary<18012> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:07:33.530+0200 E/EFL     (18012): elementary<18012> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:07:33.530+0200 E/EFL     (18012): elementary<18012> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:07:33.530+0200 E/EFL     (18012): elementary<18012> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:07:33.585+0200 E/EFL     (18012): elementary<18012> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:07:33.605+0200 E/EFL     (18012): elementary<18012> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:07:33.605+0200 E/EFL     (18012): elementary<18012> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:07:33.610+0200 E/EFL     (18012): elementary<18012> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:07:33.610+0200 E/EFL     (18012): elementary<18012> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:07:33.610+0200 E/EFL     (18012): elementary<18012> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:07:33.610+0200 E/EFL     (18012): elementary<18012> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:07:33.610+0200 I/AUL_PAD (18012): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:07:35.875+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:07:36.810+0200 E/EFL     (17943): ecore_x<17943> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7451159 button=1
10-26 13:07:36.900+0200 E/EFL     (17943): ecore_x<17943> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7451251 button=1
10-26 13:07:37.085+0200 E/RECORDING_TAG(17943): sensor_listener_unset_event_cb error: -38010874
10-26 13:07:37.095+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 13:07:37.095+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 13:07:37.255+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:37.645+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:07:38.025+0200 I/INFO_TAG(17943): SENSOR_EVENT2 HEART RATE : 78
10-26 13:07:38.045+0200 I/INFO_TAG(17943): SENSOR_EVENT2 TAB VALUE : 78
10-26 13:07:39.020+0200 I/INFO_TAG(17943): SENSOR_EVENT2 HEART RATE : 79
10-26 13:07:39.025+0200 I/INFO_TAG(17943): SENSOR_EVENT2 TAB VALUE : 79
10-26 13:07:40.020+0200 I/INFO_TAG(17943): SENSOR_EVENT2 HEART RATE : 80
10-26 13:07:40.025+0200 I/INFO_TAG(17943): SENSOR_EVENT2 TAB VALUE : 80
10-26 13:07:40.940+0200 E/EFL     (17943): ecore_x<17943> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7455292 button=1
10-26 13:07:41.005+0200 E/EFL     (17943): ecore_x<17943> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7455357 button=1
10-26 13:07:41.020+0200 E/EFL     (17943): elementary<17943> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 13:07:41.300+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:07:41.300+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 13:07:41.340+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 13:07:41.345+0200 W/CRASH_MANAGER(18030): worker.c: worker_job(1205) > 11179436461741509016061
10-26 13:07:41.350+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 17943 pgid = 17943
10-26 13:07:41.405+0200 W/PROCESSMGR(  406): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-26 13:07:41.445+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-26 13:07:41.445+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.445+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.460+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.465+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-26 13:07:41.465+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-26 13:07:41.465+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.465+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-26 13:07:41.465+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESUME State: PAUSED
10-26 13:07:41.465+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-26 13:07:41.465+0200 W/W_HOME  (  769): main.c: _appcore_resume_cb(687) > appcore resume
10-26 13:07:41.465+0200 W/W_HOME  (  769): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-26 13:07:41.465+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.480+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.490+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:41.490+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-26 13:07:41.570+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-26 13:07:41.570+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-26 13:07:41.570+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:07:41.615+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:07:41.620+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 17943
10-26 13:07:41.630+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.472
10-26 13:07:41.835+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:07:42.495+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.495+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:07:42.510+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [true][0m
10-26 13:07:42.510+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:42.515+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
10-26 13:07:42.525+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:07:42.530+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:07:42.530+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.535+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:07:42.535+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:07:42.535+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:07:42.540+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.545+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:07:42.545+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:07:42.545+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:07:42.550+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:07:42.550+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:07:42.550+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:43.040+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7457391 button=1
10-26 13:07:43.040+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:07:43.040+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:07:43.040+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:07:43.055+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:07:43.080+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7457429 button=1
10-26 13:07:43.080+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:07:43.080+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:07:43.080+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:07:43.080+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:07:43.085+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:07:43.085+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:07:43.085+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:07:43.095+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:07:43.095+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:07:43.095+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:07:43.105+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:07:43.105+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:07:43.150+0200 I/efl-extension(18012): efl_extension.c: eext_mod_init(40) > Init
10-26 13:07:43.155+0200 I/UXT     (18012): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:07:43.155+0200 I/CAPI_APPFW_APPLICATION(18012): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:07:43.160+0200 I/CAPI_APPFW_APPLICATION(18012): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:07:43.200+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:07:43.200+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18012)
10-26 13:07:43.200+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:07:43.200+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:07:43.300+0200 I/Bluetooth(18012): [bt_initialize] success.
10-26 13:07:43.370+0200 E/EFL     (18012): ecore_evas<18012> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 13:07:43.590+0200 I/APP_CORE(18012): appcore-efl.c: __do_app(429) > [APP 18012] Event: RESET State: CREATED
10-26 13:07:43.590+0200 I/CAPI_APPFW_APPLICATION(18012): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 13:07:43.610+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 13:07:43.610+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.610+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.615+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.645+0200 I/APP_CORE(18012): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 13:07:43.645+0200 I/APP_CORE(18012): appcore-efl.c: __do_app(474) > [APP 18012] Initial Launching, call the resume_cb
10-26 13:07:43.645+0200 I/CAPI_APPFW_APPLICATION(18012): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 13:07:43.655+0200 W/APP_CORE(18012): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.715+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 13:07:43.715+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 13:07:43.715+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:07:43.715+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.715+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:07:43.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:07:43.770+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:07:43.770+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:07:43.805+0200 I/APP_CORE(18012): appcore-efl.c: __do_app(429) > [APP 18012] Event: RESUME State: RUNNING
10-26 13:07:44.005+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:44.005+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:44.005+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 13:07:44.030+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 13:07:44.040+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 13:07:44.055+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:07:44.255+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:07:44.285+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.477
10-26 13:07:44.380+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:44.465+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:44.470+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18012
10-26 13:07:44.490+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:44.500+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18012
10-26 13:07:44.505+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:07:44.520+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:07:44.530+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:07:44.540+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18012
10-26 13:07:44.545+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:07:46.000+0200 E/EFL     (18061): elementary<18061> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:07:46.015+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:07:46.020+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:07:46.020+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:07:46.020+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:07:46.030+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>64</color> bpm</color>][0;m
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:07:46.030+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:07:46.050+0200 E/EFL     (18061): elementary<18061> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:07:46.220+0200 E/EFL     (18012): ecore_x<18012> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7460569 button=1
10-26 13:07:46.235+0200 E/EFL     (18061): elementary<18061> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:07:46.285+0200 E/EFL     (18012): ecore_x<18012> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7460634 button=1
10-26 13:07:46.300+0200 E/EFL     (18061): elementary<18061> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:07:46.395+0200 E/EFL     (18061): elementary<18061> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:07:46.400+0200 E/EFL     (18061): elementary<18061> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:07:46.440+0200 E/EFL     (18061): elementary<18061> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:07:46.460+0200 E/EFL     (18061): elementary<18061> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:07:46.460+0200 E/EFL     (18061): elementary<18061> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:07:46.600+0200 E/RECORDING_TAG(18012): sensor_listener_unset_event_cb error: -38010874
10-26 13:07:46.610+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 13:07:46.635+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 13:07:46.820+0200 E/EFL     (18061): elementary<18061> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:07:46.860+0200 E/EFL     (18061): elementary<18061> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:07:46.865+0200 E/EFL     (18061): elementary<18061> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:07:47.010+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 13:07:47.085+0200 I/INFO_TAG(18012): SENSOR_EVENT2 HEART RATE : 79
10-26 13:07:47.115+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:07:47.125+0200 I/INFO_TAG(18012): SENSOR_EVENT2 TAB VALUE : 79
10-26 13:07:47.445+0200 E/EFL     (18061): elementary<18061> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:07:47.505+0200 E/EFL     (18061): elementary<18061> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:07:47.540+0200 E/EFL     (18061): elementary<18061> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:07:47.540+0200 E/EFL     (18061): elementary<18061> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:07:47.540+0200 E/EFL     (18061): elementary<18061> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:07:47.540+0200 E/EFL     (18061): elementary<18061> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:07:47.555+0200 E/EFL     (18061): elementary<18061> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:07:47.555+0200 I/AUL_PAD (18061): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:07:48.025+0200 I/INFO_TAG(18012): SENSOR_EVENT2 HEART RATE : 78
10-26 13:07:48.030+0200 I/INFO_TAG(18012): SENSOR_EVENT2 TAB VALUE : 78
10-26 13:07:48.755+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:07:49.025+0200 I/INFO_TAG(18012): SENSOR_EVENT2 HEART RATE : 76
10-26 13:07:49.030+0200 I/INFO_TAG(18012): SENSOR_EVENT2 TAB VALUE : 76
10-26 13:07:50.030+0200 I/INFO_TAG(18012): SENSOR_EVENT2 HEART RATE : 72
10-26 13:07:50.035+0200 I/INFO_TAG(18012): SENSOR_EVENT2 TAB VALUE : 72
10-26 13:07:51.025+0200 I/INFO_TAG(18012): SENSOR_EVENT2 HEART RATE : 71
10-26 13:07:51.030+0200 I/INFO_TAG(18012): SENSOR_EVENT2 TAB VALUE : 71
10-26 13:07:51.225+0200 E/EFL     (18012): ecore_x<18012> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7465572 button=1
10-26 13:07:51.260+0200 E/EFL     (18012): ecore_x<18012> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7465610 button=1
10-26 13:07:51.275+0200 E/EFL     (18012): elementary<18012> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 13:07:51.435+0200 W/CRASH_MANAGER(18030): worker.c: worker_job(1205) > 1118012646174150901607
