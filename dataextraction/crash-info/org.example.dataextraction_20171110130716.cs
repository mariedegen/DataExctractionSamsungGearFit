S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 5426
Date: 2017-11-10 13:07:16+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5426, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x06f88900, r3   = 0x06f88900
r4   = 0x43325730, r5   = 0x432daf88
r6   = 0x415389f8, r7   = 0xbe8672a0
r8   = 0x00000000, r9   = 0x4330a610
r10  = 0x43317e40, fp   = 0x00000001
ip   = 0x40088a5c, sp   = 0xbe867278
lr   = 0x41745b69, pc   = 0x41744b6a
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     85792 KB
Buffers:     30792 KB
Cached:     157288 KB
VmPeak:      97696 KB
VmSize:      96220 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19532 KB
VmRSS:       19528 KB
VmData:      40348 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25016 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5426 TID = 5426
5426 5491 5511 

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
435b8000 43db7000 rw-p [stack:5491]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43fb9000 447b8000 rw-p [stack:5511]
45a28000 45a29000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a44000 45a4b000 r-xp /usr/lib/libfeedback.so.0.1.4
45a54000 45a55000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45a5d000 45a5f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45a67000 45a71000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45a79000 45a80000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45a88000 45a9e000 r-xp /usr/lib/libmmfsound.so.0.1.0
45ab0000 45ab5000 r-xp /usr/lib/libmmfsession.so.0.0.0
45abd000 45ac7000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45ad3000 45ad7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45ae0000 45af5000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45afd000 45b5e000 r-xp /usr/lib/libasound.so.2.0.0
45b68000 45b6b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45b73000 45bab000 r-xp /usr/lib/libpulse.so.0.16.2
45bac000 45bdd000 r-xp /usr/lib/libmdm.so.1.1.86
45be5000 45bea000 r-xp /usr/lib/libjson.so.0.0.1
45bf2000 45c3a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45c3b000 45c82000 r-xp /usr/lib/libsndfile.so.1.0.26
45c8e000 45c96000 r-xp /usr/lib/libmdm-common.so.1.0.89
45c97000 45cb9000 r-xp /usr/lib/libvorbis.so.0.4.3
45cc1000 45cc5000 r-xp /usr/lib/libogg.so.0.7.1
be847000 be868000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5426)
Call Stack Count: 18
 0: app_create + 0x5d (0x41744b6a) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b6a
 1: clicked_redo_app + 0x2c (0x41744d1f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d1f
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
14: main + 0x66 (0x41744c43) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c43
15: create_base_gui + 0x46 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
16: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
17: clicked_redo_app + 0x1d (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
: coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
11-10 13:06:37.970+0200 E/rpm-installer( 5416): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
11-10 13:06:37.970+0200 E/rpm-installer( 5416): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
11-10 13:06:38.045+0200 E/PKGMGR_PARSER( 5416): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
11-10 13:06:38.055+0200 E/PKGMGR_PARSER( 5416): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
11-10 13:06:38.085+0200 E/PKGMGR_PARSER( 5416): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
11-10 13:06:38.165+0200 I/PRIVACY-MANAGER-CLIENT( 5416): SocketClient.cpp: SocketClient(37) > Client created
11-10 13:06:38.325+0200 I/efl-extension( 5416): efl_extension.c: eext_mod_init(40) > Init
11-10 13:06:38.325+0200 I/efl-extension( 5416): efl_extension.c: eext_mod_shutdown(46) > Shutdown
11-10 13:06:38.435+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
11-10 13:06:38.440+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
11-10 13:06:38.440+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
11-10 13:06:38.440+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
11-10 13:06:38.440+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
11-10 13:06:38.440+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
11-10 13:06:38.440+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
11-10 13:06:38.470+0200 E/PKGMGR_CERT( 5416): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
11-10 13:06:38.480+0200 E/PKGMGR_OBSERVER( 5417): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54170002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
11-10 13:06:38.510+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:06:38.570+0200 E/rpm-installer( 5416): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
11-10 13:06:38.585+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5093 pgid = 5093
11-10 13:06:38.590+0200 E/rpm-installer( 5416): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
11-10 13:06:38.645+0200 E/rpm-installer( 5416): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
11-10 13:06:38.675+0200 E/PKGMGR_OBSERVER( 5417): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54170002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
11-10 13:06:38.705+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:06:38.730+0200 E/rpm-installer( 5416): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
11-10 13:06:38.775+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5093
11-10 13:06:38.800+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.293
11-10 13:06:38.885+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:06:38.885+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4733 pgid = -1
11-10 13:06:38.885+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:06:38.905+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4733
11-10 13:06:38.915+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.294
11-10 13:06:39.345+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:06:39.355+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:06:39.425+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:06:39.440+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:06:39.515+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:06:39.515+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:06:39.520+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:06:39.525+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:06:39.525+0200 E/EFL     ( 5426): elementary<5426> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:06:39.580+0200 E/EFL     ( 5426): elementary<5426> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:06:39.580+0200 E/EFL     ( 5426): elementary<5426> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:06:39.590+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:06:39.635+0200 E/PKGMGR_SERVER( 5415): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
11-10 13:06:39.715+0200 E/EFL     ( 5426): elementary<5426> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:06:39.730+0200 E/EFL     ( 5426): elementary<5426> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:06:39.730+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:06:39.735+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:06:39.735+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:06:39.735+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:06:39.735+0200 E/EFL     ( 5426): elementary<5426> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:06:39.735+0200 I/AUL_PAD ( 5426): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:06:39.905+0200 E/PKGMGR_OBSERVER( 5417): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54170002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
11-10 13:06:39.925+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
11-10 13:06:39.925+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
11-10 13:06:39.980+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
11-10 13:06:40.005+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
11-10 13:06:40.005+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
11-10 13:06:40.005+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
11-10 13:06:40.005+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
11-10 13:06:40.005+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
11-10 13:06:40.005+0200 E/WMS     (  493): wms_db.c: wms_db_package_event_insert_record(177) > 
11-10 13:06:40.030+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
11-10 13:06:40.055+0200 E/PKGMGR_INFO( 5417): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
11-10 13:06:40.095+0200 E/PKGMGR_OBSERVER( 5417): pkg_observer.c: main(620) > OBSERVER end
11-10 13:06:40.110+0200 E/PKGMGR_SERVER( 5415): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
11-10 13:06:40.110+0200 E/PKGMGR_SERVER( 5415): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5417]
11-10 13:06:40.130+0200 E/STARTER (  720): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
11-10 13:06:40.140+0200 W/APPS    (  765): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-10 13:06:40.150+0200 W/APPS    (  765): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
11-10 13:06:40.190+0200 E/PKGMGR_INFO(  492): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
11-10 13:06:40.355+0200 I/efl-extension( 5427): efl_extension.c: eext_mod_init(40) > Init
11-10 13:06:40.430+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:06:40.435+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:06:40.470+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:06:40.475+0200 I/UXT     ( 5427): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
11-10 13:06:40.475+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:06:40.545+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:06:40.555+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:06:40.560+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:06:40.560+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:06:40.560+0200 E/EFL     ( 5427): elementary<5427> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:06:40.580+0200 E/EFL     ( 5427): elementary<5427> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:06:40.590+0200 E/EFL     ( 5427): elementary<5427> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:06:40.590+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:06:40.640+0200 E/EFL     ( 5427): elementary<5427> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:06:40.660+0200 E/EFL     ( 5427): elementary<5427> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:06:40.660+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:06:40.665+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:06:40.665+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:06:40.665+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:06:40.665+0200 E/EFL     ( 5427): elementary<5427> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:06:40.665+0200 I/AUL_PAD ( 5427): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:06:41.270+0200 E/rpm-installer( 5416): rpm-appcore-intf.c: main(273) > ------------------------------------------------
11-10 13:06:41.270+0200 E/rpm-installer( 5416): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
11-10 13:06:41.275+0200 E/rpm-installer( 5416): rpm-appcore-intf.c: main(275) > ------------------------------------------------
11-10 13:06:41.330+0200 E/PKGMGR_SERVER( 5415): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5416]
11-10 13:06:41.375+0200 E/RESOURCED(  514): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/5416/oom_score_adj failed
11-10 13:06:41.375+0200 E/RESOURCED(  514): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 5416
11-10 13:06:41.635+0200 E/PKGMGR_SERVER( 5415): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-10 13:06:41.635+0200 E/PKGMGR_SERVER( 5415): pkgmgr-server.c: main(2221) > package manager server terminated.
11-10 13:06:42.545+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:06:44.930+0200 W/AUL     ( 5490): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:06:44.935+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:06:44.970+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 13:06:45.000+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 13:06:45.000+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 13:06:45.000+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 5490
11-10 13:06:45.025+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:06:45.025+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:06:45.025+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:06:45.025+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
11-10 13:06:45.030+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:06:45.110+0200 I/efl-extension( 5426): efl_extension.c: eext_mod_init(40) > Init
11-10 13:06:45.110+0200 I/CAPI_APPFW_APPLICATION( 5426): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:06:45.120+0200 I/CAPI_APPFW_APPLICATION( 5426): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:06:45.130+0200 W/AUL     ( 5490): launch.c: app_request_to_launchpad(282) > request cmd(0) result(5426)
11-10 13:06:45.255+0200 I/Bluetooth( 5426): [bt_initialize] success.
11-10 13:06:45.290+0200 I/Bluetooth( 5426): [bt_adapter_get_state] success.
11-10 13:06:45.375+0200 E/EFL     ( 5426): ecore_evas<5426> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:06:45.710+0200 I/APP_CORE( 5426): appcore-efl.c: __do_app(429) > [APP 5426] Event: RESET State: CREATED
11-10 13:06:45.710+0200 I/CAPI_APPFW_APPLICATION( 5426): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:06:45.740+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:06:45.740+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:06:45.740+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:06:45.745+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:06:45.775+0200 I/APP_CORE( 5426): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:06:45.775+0200 I/APP_CORE( 5426): appcore-efl.c: __do_app(474) > [APP 5426] Initial Launching, call the resume_cb
11-10 13:06:45.775+0200 I/CAPI_APPFW_APPLICATION( 5426): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:06:45.795+0200 W/APP_CORE( 5426): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3c00002
11-10 13:06:45.880+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:06:45.880+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:06:45.880+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:06:45.880+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:06:45.880+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:06:45.880+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:06:45.880+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:06:45.880+0200 E/W_HOME  (  765): main.c: _pause_cb(674) > paused already
11-10 13:06:45.880+0200 I/APP_CORE(  765): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
11-10 13:06:45.880+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:06:45.895+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:06:45.895+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:06:45.935+0200 I/APP_CORE( 5426): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
11-10 13:06:45.950+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:45.950+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:45.950+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:46.120+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:06:46.120+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:06:46.145+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:06:46.240+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:06:46.245+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.300
11-10 13:06:46.250+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5426
11-10 13:06:46.270+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:06:46.270+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:06:46.270+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:06:46.280+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5426
11-10 13:06:46.285+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:06:46.400+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:06:46.405+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:06:46.440+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:06:46.440+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:06:46.500+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:06:46.505+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:06:46.510+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:06:46.510+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:06:46.510+0200 E/EFL     ( 5501): elementary<5501> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:06:46.545+0200 E/EFL     ( 5501): elementary<5501> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:06:46.550+0200 E/EFL     ( 5501): elementary<5501> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:06:46.550+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:06:46.615+0200 E/EFL     ( 5501): elementary<5501> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:06:46.615+0200 E/EFL     ( 5501): elementary<5501> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:06:46.620+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:06:46.620+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:06:46.625+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:06:46.625+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:06:46.625+0200 E/EFL     ( 5501): elementary<5501> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:06:46.625+0200 I/AUL_PAD ( 5501): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:06:46.675+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:47.680+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:48.685+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:49.690+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:50.690+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:50.880+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:06:51.685+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:52.690+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:53.685+0200 I/INFO_TAG( 5426): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:06:54.505+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:06:54.695+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:06:54.760+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:06:55.135+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:06:55.660+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
11-10 13:06:55.660+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
11-10 13:06:55.660+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:06:55.670+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(186) > LCD on
11-10 13:06:55.670+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_set(165) > timer set
11-10 13:06:55.670+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:06:55.675+0200 W/W_HOME  (  765): gesture.c: _apps_status_get(126) > apps status:0
11-10 13:06:55.675+0200 W/W_HOME  (  765): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:57013
11-10 13:06:55.675+0200 W/W_HOME  (  765): gesture.c: _manual_render_schedule(212) > schedule, manual render
11-10 13:06:55.675+0200 W/W_HOME  (  765): event_manager.c: _lcd_on_cb(696) > lcd state: 1
11-10 13:06:55.675+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:06:55.680+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [57013]ms
11-10 13:06:55.680+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:06:55.705+0200 W/W_HOME  (  765): gesture.c: _widget_updated_cb(194) > widget updated
11-10 13:06:55.705+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:06:55.705+0200 W/W_HOME  (  765): gesture.c: _manual_render(180) > 
11-10 13:06:55.715+0200 I/APP_CORE( 5426): appcore-efl.c: __do_app(429) > [APP 5426] Event: RESUME State: RUNNING
11-10 13:06:55.765+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:06:55.785+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:06:55.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
11-10 13:06:55.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
11-10 13:06:55.810+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_boolean(1173) > preference_get_boolean(1107) : test_healthy_pace error
11-10 13:06:55.810+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
11-10 13:06:55.810+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:06:55.815+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:06:55.860+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
11-10 13:06:55.860+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:06:55.885+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:06:55.910+0200 W/W_HOME  (  765): gesture.c: _manual_render(180) > 
11-10 13:06:55.915+0200 W/SHealth_Common( 1107): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1510272000000,000000[0;m
11-10 13:06:55.920+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 0
11-10 13:06:55.960+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:06:55.960+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:06:55.960+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:06:55.960+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:06:55.960+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:06:55.965+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:06:55.965+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:06:55.965+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:06:55.965+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:06:55.975+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (622030)]][0;m
11-10 13:06:56.020+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
11-10 13:06:56.020+0200 W/SHealthWidget(  837): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (622030), msgName: timeline_summary_updated[0;m
11-10 13:06:56.020+0200 W/SHealth_Common(  837): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
11-10 13:06:56.030+0200 I/HealthDataService(  784): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
11-10 13:06:56.060+0200 I/healthData( 1107): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
11-10 13:06:56.080+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:06:56.080+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:06:56.080+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:06:56.080+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:06:56.115+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_update_cb(281) > received updating signal
11-10 13:06:56.115+0200 E/EFL     (  837): edje<837> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
11-10 13:06:56.570+0200 E/EFL     ( 5426): ecore_x<5426> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1220936 button=1
11-10 13:06:56.590+0200 E/EFL     ( 5426): ecore_x<5426> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1220945 button=1
11-10 13:06:56.845+0200 E/RECORDING_TAG( 5426): sensor_listener_unset_event_cb error: -38010874
11-10 13:06:56.850+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:06:56.855+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:06:56.955+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:06:57.685+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 HEART RATE : 63
11-10 13:06:57.715+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 TAB VALUE : 63
11-10 13:06:58.685+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 HEART RATE : 63
11-10 13:06:58.705+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 TAB VALUE : 63
11-10 13:06:59.695+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 HEART RATE : 63
11-10 13:06:59.705+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 TAB VALUE : 63
11-10 13:07:00.565+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:07:00.565+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:07:00.570+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:07:00.570+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:07:00.570+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:07:00.570+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:07:00.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:07:00.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:07:00.575+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:07:00.690+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 HEART RATE : 63
11-10 13:07:00.710+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 TAB VALUE : 63
11-10 13:07:01.700+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 HEART RATE : 63
11-10 13:07:01.725+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 TAB VALUE : 63
11-10 13:07:02.695+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 HEART RATE : 62
11-10 13:07:02.705+0200 I/INFO_TAG( 5426): SENSOR_EVENT2 TAB VALUE : 62
11-10 13:07:03.585+0200 E/EFL     ( 5426): ecore_x<5426> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1227944 button=1
11-10 13:07:03.625+0200 E/EFL     ( 5426): ecore_x<5426> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1227992 button=1
11-10 13:07:03.650+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:07:03.750+0200 I/Bluetooth( 5426): [bt_socket_create_rfcomm] success.
11-10 13:07:03.915+0200 I/BluetoothServer( 5426): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-10 13:07:03.950+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:07:04.305+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:05.730+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:07:10.060+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
11-10 13:07:14.185+0200 I/BluetoothServer( 5426): Callback: Connected.
11-10 13:07:14.185+0200 I/BluetoothServer( 5426): Callback: Socket of connection - 29.
11-10 13:07:14.195+0200 I/BluetoothServer( 5426): Callback: Role of connection - 1.
11-10 13:07:14.195+0200 I/BluetoothServer( 5426): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:07:14.195+0200 I/BluetoothServer( 5426): Sent: '27C663,000000 63,000000 63,000000 63,000000 62,000000 0,000000 '
11-10 13:07:14.315+0200 E/Bluetooth( 5426): [bt_socket_send_data] unknown error code : 64.
11-10 13:07:14.315+0200 E/Bluetooth( 5426): [bt_socket_send_data] unknown error code : 3.
11-10 13:07:14.315+0200 I/BluetoothServer( 5426): All data sent
11-10 13:07:14.315+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:07:14.340+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:07:14.460+0200 I/BluetoothServer( 5426): Callback: Disconnected.
11-10 13:07:14.460+0200 I/BluetoothServer( 5426): Callback: Socket of disconnection - 29.
11-10 13:07:14.460+0200 I/BluetoothServer( 5426): Callback: Address of connection - B8:81:98:D4:F2:78.
11-10 13:07:14.705+0200 E/EFL     ( 5426): elementary<5426> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:07:15.980+0200 E/EFL     ( 5426): ecore_x<5426> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1240347 button=1
11-10 13:07:16.065+0200 E/EFL     ( 5426): ecore_x<5426> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1240429 button=1
11-10 13:07:16.070+0200 I/Bluetooth( 5426): [bt_deinitialize] success.
11-10 13:07:16.075+0200 I/Bluetooth( 5426): [bt_initialize] success.
11-10 13:07:16.115+0200 I/Bluetooth( 5426): [bt_adapter_get_state] success.
11-10 13:07:16.570+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:07:16.570+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:07:16.585+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5426 pgid = 5426
11-10 13:07:16.620+0200 W/PROCESSMGR(  408): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.665+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
11-10 13:07:16.665+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESUME State: PAUSED
11-10 13:07:16.665+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_resume(223) > app_appcore_resume
11-10 13:07:16.665+0200 W/W_HOME  (  765): main.c: _appcore_resume_cb(687) > appcore resume
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
11-10 13:07:16.665+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.670+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.670+0200 W/W_HOME  (  765): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
11-10 13:07:16.670+0200 W/W_HOME  (  765): main.c: home_resume(739) > clock/widget resumed
11-10 13:07:16.670+0200 W/W_HOME  (  765): clock_indicator.c: clock_indicator_resume(537) > 
11-10 13:07:16.670+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-10 13:07:16.685+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
11-10 13:07:16.690+0200 W/WSLib   (  837): LabelWidget.cpp: StartSliding(138) > [1;35m ###[0;m
11-10 13:07:16.690+0200 W/WATCH_CORE(  816): appcore-watch.c: __widget_resume(1039) > widget_resume
11-10 13:07:16.690+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:07:16.710+0200 W/SHealth_Common(  837): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:07:16.715+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:07:16.715+0200 W/SHealth_Common( 1107): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
11-10 13:07:16.720+0200 I/CAPI_WIDGET_APPLICATION(  837): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
11-10 13:07:16.725+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:07:16.725+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:07:16.725+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:07:16.725+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:07:16.735+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:07:16.735+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:07:16.735+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:07:16.735+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:07:16.735+0200 W/SHealthWidget(  837): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>118</color> bpm</color>][0;m
11-10 13:07:16.740+0200 W/SHealth_Common(  837): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:07:16.740+0200 W/SHealth_Common(  837): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
11-10 13:07:16.740+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:07:16.740+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:07:16.740+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:07:16.740+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:07:16.755+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:07:16.755+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:07:16.755+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:07:16.755+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:07:16.760+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-10 13:07:16.770+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-10 13:07:16.770+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-10 13:07:16.770+0200 E/TIZEN_N_SYSTEM_SETTINGS(  837): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-10 13:07:16.785+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
11-10 13:07:16.785+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
11-10 13:07:16.785+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:07:16.790+0200 W/CRASH_MANAGER( 5514): worker.c: worker_job(1205) > 1105426646174151031203
