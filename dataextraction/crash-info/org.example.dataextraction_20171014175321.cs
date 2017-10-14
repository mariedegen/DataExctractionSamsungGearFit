S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18824
Date: 2017-10-14 17:53:21+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18824, uid 5000)

Register Information
r0   = 0x123b0000, r1   = 0x401d4e58
r2   = 0xbed66ea4, r3   = 0xbed66f09
r4   = 0x401d4e58, r5   = 0x123b0000
r6   = 0x402cfb88, r7   = 0xbed66f18
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x41a7fd08, fp   = 0x00000000
ip   = 0x401ebc20, sp   = 0xbed66e30
lr   = 0x4019d13f, pc   = 0x4022df5e
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     19640 KB
Buffers:     64036 KB
Cached:     163552 KB
VmPeak:      97204 KB
VmSize:      95728 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18332 KB
VmRSS:       18328 KB
VmData:      39496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 18824 TID = 18824
18824 18878 18879 18880 18881 

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
4146a000 4146d000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 4164e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
41656000 4165a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41663000 4166b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4166c000 4168d000 r-xp /usr/lib/libefl-extension.so.0.1.0
41696000 416c0000 r-xp /usr/lib/libsensor.so.1.9.6
416c9000 416db000 r-xp /usr/lib/libefl-assist.so.0.1.0
416e3000 4179b000 r-xp /usr/lib/libcairo.so.2.11200.14
417a6000 417b0000 r-xp /usr/lib/libsensord-shared.so
417b9000 417cb000 r-xp /usr/lib/libtts.so
417d3000 417f5000 r-xp /usr/lib/libui-extension.so.0.1.0
417fe000 41805000 r-xp /usr/lib/libtbm.so.1.0.0
4180d000 4181b000 r-xp /usr/lib/libGLESv2.so.2.0
41824000 41825000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4182e000 41834000 r-xp /usr/lib/libxcb-render.so.0.0.0
4183c000 4183f000 r-xp /usr/lib/libEGL.so.1.4
41847000 4184c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41854000 41857000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
4185f000 41860000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41869000 419a6000 r-xp /usr/lib/libicui18n.so.51.1
419b6000 419be000 r-xp /usr/lib/libdrm.so.2.4.0
419c6000 419c8000 r-xp /usr/lib/libdri2.so.0.0.0
419d0000 419d6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
419de000 419e3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
419ee000 419f1000 rw-p [heap]
419f1000 41b08000 rw-p [heap]
41b08000 41bec000 r-xp /usr/lib/libicuuc.so.51.1
41c01000 41c1a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431ab000 431cc000 r-xp /usr/lib/libexif.so.12.3.3
431df000 431e1000 r-xp /usr/lib/libttrace.so.1.1
431e9000 431ee000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431f6000 431fc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43205000 4320d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43215000 43231000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4323a000 43241000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4324a000 4324c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43254000 4325b000 r-xp /usr/lib/libminizip.so.1.0.0
43263000 43270000 r-xp /usr/lib/libail.so.0.1.0
43279000 43343000 r-xp /usr/lib/libCOREGL.so.4.0
43555000 43560000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43569000 4356e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43711000 43712000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4371b000 43f1a000 rw-p [stack:18878]
43f1b000 4471a000 rw-p [stack:18879]
4471b000 44f1a000 rw-p [stack:18880]
44f1b000 4571a000 rw-p [stack:18881]
45776000 45777000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45792000 45799000 r-xp /usr/lib/libfeedback.so.0.1.4
457a2000 457a3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
457ab000 457ad000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
457b5000 457bf000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
457c7000 457ca000 r-xp /usr/lib/libpulse-simple.so.0.0.4
458d2000 458d9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
458e1000 458f7000 r-xp /usr/lib/libmmfsound.so.0.1.0
45909000 4590e000 r-xp /usr/lib/libmmfsession.so.0.0.0
45916000 45920000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4592c000 45930000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45939000 4594e000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45956000 459b7000 r-xp /usr/lib/libasound.so.2.0.0
459c1000 459f9000 r-xp /usr/lib/libpulse.so.0.16.2
459fa000 459fd000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45a05000 45a36000 r-xp /usr/lib/libmdm.so.1.1.86
45a3e000 45a43000 r-xp /usr/lib/libjson.so.0.0.1
45a4b000 45a93000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a94000 45adb000 r-xp /usr/lib/libsndfile.so.1.0.26
45ae7000 45aef000 r-xp /usr/lib/libmdm-common.so.1.0.89
45af0000 45b12000 r-xp /usr/lib/libvorbis.so.0.4.3
45b1a000 45b1e000 r-xp /usr/lib/libogg.so.0.7.1
bed47000 bed68000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18824)
Call Stack Count: 17
 0: evas_object_smart_type_check_ptr + 0xd (0x4022df5e) [/usr/lib/libevas.so.1] + 0x34f5e
 1: elm_widget_text_part_set + 0x12 (0x4019d13f) [/usr/lib/libelementary.so.1] + 0xf513f
 2: on_sensor_event_2 + 0xc0 (0x4146bef1) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1ef1
 3: (0x4165782f) [/usr/lib/libcapi-system-sensor.so.0] + 0x182f
 4: (0x416aaaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403b5fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403b77a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x402fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402f95a7) [/usr/lib/libecore.so.1] + 0xc5a7
10: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
12: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0x4146b62b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x162b
14: create_base_gui + 0x20e (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
15: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
16: create_base_gui + 0x583 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
09.215+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-14 17:53:09.235+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:09.250+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:09.250+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 17:53:09.265+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:09.275+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:09.285+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:09.300+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:09.310+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16671664 button=1
10-14 17:53:09.315+0200 E/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-14 17:53:10.375+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16672731 button=1
10-14 17:53:10.380+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:10.380+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 17:53:10.385+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 17:53:10.420+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16672776 button=1
10-14 17:53:10.420+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 17:53:10.420+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 17:53:10.420+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 17:53:10.435+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 17:53:10.435+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 17:53:10.435+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 17:53:10.435+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 17:53:10.445+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 17:53:10.445+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 17:53:10.445+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 17:53:10.455+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-14 17:53:10.455+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 17:53:10.505+0200 I/efl-extension(18725): efl_extension.c: eext_mod_init(40) > Init
10-14 17:53:10.510+0200 I/UXT     (18725): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 17:53:10.510+0200 I/CAPI_APPFW_APPLICATION(18725): app_main.c: ui_app_main(704) > app_efl_main
10-14 17:53:10.515+0200 I/CAPI_APPFW_APPLICATION(18725): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 17:53:10.550+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:53:10.550+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18725)
10-14 17:53:10.605+0200 E/EFL     (18725): ecore_evas<18725> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 17:53:10.855+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:53:10.855+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.855+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.860+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.865+0200 I/APP_CORE(18725): appcore-efl.c: __do_app(429) > [APP 18725] Event: RESET State: CREATED
10-14 17:53:10.865+0200 I/CAPI_APPFW_APPLICATION(18725): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 17:53:10.880+0200 I/APP_CORE(18725): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:53:10.880+0200 I/APP_CORE(18725): appcore-efl.c: __do_app(474) > [APP 18725] Initial Launching, call the resume_cb
10-14 17:53:10.880+0200 I/CAPI_APPFW_APPLICATION(18725): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 17:53:10.890+0200 W/APP_CORE(18725): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000002
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:53:10.930+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:53:10.930+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:53:10.930+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.935+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.935+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:53:10.945+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:53:10.950+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:10.950+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:53:10.950+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:53:10.960+0200 I/APP_CORE(18725): appcore-efl.c: __do_app(429) > [APP 18725] Event: RESUME State: RUNNING
10-14 17:53:10.985+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:10.985+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:10.985+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:11.010+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:53:11.235+0200 E/EFL     (18725): elementary<18725> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 17:53:11.275+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:53:11.460+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:53:11.745+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:53:11.755+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18725
10-14 17:53:11.760+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:53:11.770+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18725
10-14 17:53:11.775+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:53:11.775+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:53:11.815+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:11.890+0200 E/EFL     (18824): elementary<18824> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 17:53:11.890+0200 E/EFL     (18824): elementary<18824> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 17:53:11.920+0200 E/EFL     (18824): elementary<18824> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 17:53:11.920+0200 E/EFL     (18824): elementary<18824> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 17:53:11.975+0200 E/EFL     (18824): elementary<18824> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 17:53:11.975+0200 E/EFL     (18824): elementary<18824> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 17:53:11.985+0200 E/EFL     (18824): elementary<18824> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 17:53:11.985+0200 E/EFL     (18824): elementary<18824> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 17:53:11.985+0200 E/EFL     (18824): elementary<18824> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 17:53:12.015+0200 E/EFL     (18824): elementary<18824> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 17:53:12.020+0200 E/EFL     (18824): elementary<18824> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 17:53:12.020+0200 E/EFL     (18824): elementary<18824> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 17:53:12.080+0200 E/EFL     (18824): elementary<18824> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 17:53:12.085+0200 E/EFL     (18824): elementary<18824> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 17:53:12.085+0200 E/EFL     (18824): elementary<18824> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 17:53:12.085+0200 E/EFL     (18824): elementary<18824> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 17:53:12.090+0200 E/EFL     (18824): elementary<18824> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 17:53:12.090+0200 E/EFL     (18824): elementary<18824> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 17:53:12.090+0200 E/EFL     (18824): elementary<18824> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 17:53:12.090+0200 I/AUL_PAD (18824): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 17:53:12.830+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:13.825+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:14.825+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:15.300+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 17:53:15.825+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:15.960+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:53:16.310+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 17:53:16.825+0200 I/INFO_TAG(18725): HEART RATE : 0
10-14 17:53:17.195+0200 E/EFL     (18725): ecore_x<18725> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16679551 button=1
10-14 17:53:17.290+0200 E/EFL     (18725): ecore_x<18725> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16679645 button=1
10-14 17:53:17.515+0200 E/EFL     (18725): elementary<18725> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 17:53:17.535+0200 E/EFL     (18725): elementary<18725> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 17:53:17.550+0200 I/INFO_TAG_SENSOR_EVENT2(18725): HEART RATE : 0
10-14 17:53:17.865+0200 W/CRASH_MANAGER(18849): worker.c: worker_job(1205) > 11187256461741507996397
10-14 17:53:17.940+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f370] swap changed from sync to async
10-14 17:53:17.990+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18725 pgid = 18725
10-14 17:53:18.000+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 17:53:18.000+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 17:53:18.020+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-14 17:53:18.020+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 17:53:18.020+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.020+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.045+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.075+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 17:53:18.090+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 17:53:18.090+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.090+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 17:53:18.100+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESUME State: PAUSED
10-14 17:53:18.100+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:53:18.100+0200 W/W_HOME  ( 1063): main.c: _appcore_resume_cb(687) > appcore resume
10-14 17:53:18.100+0200 W/W_HOME  ( 1063): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 17:53:18.100+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.105+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.110+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:18.110+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 17:53:18.115+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-14 17:53:18.115+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-14 17:53:18.115+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:53:18.175+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 17:53:18.185+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18725
10-14 17:53:18.195+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.3372
10-14 17:53:18.455+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f370] swap changed from async to sync
10-14 17:53:18.710+0200 W/W_INDICATOR(  714): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-14 17:53:18.715+0200 W/W_INDICATOR(  714): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-14 17:53:19.015+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16681370 button=1
10-14 17:53:19.015+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:19.015+0200 E/W_HOME  ( 1063): move.c: _mouse_down_cb(384) > apps move is not allowed
10-14 17:53:19.015+0200 W/APPS    ( 1063): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-14 17:53:19.060+0200 E/W_HOME  ( 1063): move.c: _mouse_move_cb(546) > apps move is not allowed
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:53:19.110+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:53:19.115+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.115+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:53:19.115+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 17:53:19.130+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:53:19.140+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 17:53:19.145+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:53:19.145+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:53:19.145+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:53:19.145+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:53:19.145+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:53:19.145+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:53:19.150+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.150+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:53:19.150+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:53:19.150+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:53:19.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:53:19.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:53:19.155+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:53:19.155+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:53:19.155+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.160+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:53:19.160+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:53:19.160+0200 E/EFL     ( 1063): ecore_x<1063> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16681516 button=1
10-14 17:53:19.160+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-14 17:53:19.160+0200 E/APPS    ( 1063): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-14 17:53:19.160+0200 W/APPS    ( 1063): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-14 17:53:19.160+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 17:53:19.165+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 17:53:19.165+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 1063
10-14 17:53:19.165+0200 I/AUL_AMD (  532): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-14 17:53:19.180+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 17:53:19.180+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 17:53:19.180+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 17:53:19.180+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-14 17:53:19.180+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 17:53:19.190+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:53:19.200+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:53:19.205+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:53:19.205+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:53:19.215+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.235+0200 I/efl-extension(18824): efl_extension.c: eext_mod_init(40) > Init
10-14 17:53:19.240+0200 I/UXT     (18824): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 17:53:19.240+0200 I/CAPI_APPFW_APPLICATION(18824): app_main.c: ui_app_main(704) > app_efl_main
10-14 17:53:19.245+0200 I/CAPI_APPFW_APPLICATION(18824): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 17:53:19.280+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:53:19.280+0200 W/AUL     ( 1063): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18824)
10-14 17:53:19.345+0200 E/EFL     (18824): ecore_evas<18824> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 17:53:19.605+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:53:19.605+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.605+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.605+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.610+0200 I/APP_CORE(18824): appcore-efl.c: __do_app(429) > [APP 18824] Event: RESET State: CREATED
10-14 17:53:19.610+0200 I/CAPI_APPFW_APPLICATION(18824): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 17:53:19.665+0200 I/APP_CORE(18824): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:53:19.665+0200 I/APP_CORE(18824): appcore-efl.c: __do_app(474) > [APP 18824] Initial Launching, call the resume_cb
10-14 17:53:19.665+0200 I/CAPI_APPFW_APPLICATION(18824): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 17:53:19.670+0200 W/APP_CORE(18824): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00002
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:53:19.710+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:53:19.710+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.710+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:53:19.710+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.710+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:53:19.715+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:53:19.715+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:53:19.715+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:53:19.775+0200 I/APP_CORE(18824): appcore-efl.c: __do_app(429) > [APP 18824] Event: RESUME State: RUNNING
10-14 17:53:19.795+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:53:19.805+0200 I/INFO_TAG(18824): HEART RATE : 0
10-14 17:53:19.805+0200 I/INFO_TAG(18824): HEART RATE : 0
10-14 17:53:20.025+0200 E/EFL     (18824): elementary<18824> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 17:53:20.055+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:53:20.225+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:53:20.340+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.3375
10-14 17:53:20.390+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:53:20.400+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18824
10-14 17:53:20.400+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:53:20.410+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18824
10-14 17:53:20.415+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:53:20.415+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:53:20.470+0200 E/EFL     (18824): ecore_x<18824> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16682825 button=1
10-14 17:53:20.555+0200 E/EFL     (18824): ecore_x<18824> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16682908 button=1
10-14 17:53:20.585+0200 E/EFL     (18883): elementary<18883> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 17:53:20.585+0200 E/EFL     (18883): elementary<18883> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 17:53:20.610+0200 E/EFL     (18883): elementary<18883> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 17:53:20.610+0200 E/EFL     (18883): elementary<18883> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 17:53:20.655+0200 E/EFL     (18883): elementary<18883> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 17:53:20.660+0200 E/EFL     (18883): elementary<18883> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 17:53:20.660+0200 E/EFL     (18883): elementary<18883> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 17:53:20.665+0200 E/EFL     (18883): elementary<18883> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 17:53:20.665+0200 E/EFL     (18883): elementary<18883> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 17:53:20.685+0200 E/EFL     (18883): elementary<18883> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 17:53:20.690+0200 E/EFL     (18883): elementary<18883> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 17:53:20.690+0200 E/EFL     (18883): elementary<18883> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 17:53:20.730+0200 E/EFL     (18883): elementary<18883> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 17:53:20.745+0200 E/EFL     (18883): elementary<18883> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 17:53:20.745+0200 E/EFL     (18883): elementary<18883> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 17:53:20.750+0200 E/EFL     (18883): elementary<18883> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 17:53:20.750+0200 E/EFL     (18883): elementary<18883> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 17:53:20.750+0200 E/EFL     (18883): elementary<18883> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 17:53:20.750+0200 E/EFL     (18883): elementary<18883> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 17:53:20.750+0200 I/AUL_PAD (18883): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 17:53:20.930+0200 E/EFL     (18824): elementary<18824> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 17:53:20.950+0200 E/EFL     (18824): elementary<18824> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 17:53:21.305+0200 E/EFL     (18824): elementary<18824> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 17:53:21.560+0200 I/INFO_TAG_SENSOR_EVENT2(18824): HEART RATE : 0
10-14 17:53:21.690+0200 W/CRASH_MANAGER(18849): worker.c: worker_job(1205) > 1118824646174150799640
