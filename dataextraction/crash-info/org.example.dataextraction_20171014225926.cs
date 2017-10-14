S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 5463
Date: 2017-10-14 22:59:26+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5463, uid 5000)

Register Information
r0   = 0x0000000a, r1   = 0xfb9c15d4
r2   = 0x4146c023, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x416c77fc
r6   = 0x0000000a, r7   = 0xbee6ff10
r8   = 0x00000041, r9   = 0x40452824
r10  = 0xfb9c15d4, fp   = 0x00000000
ip   = 0x0000016c, sp   = 0xbee6fe30
lr   = 0x4146c023, pc   = 0x404e62d0
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     88036 KB
Buffers:     29248 KB
Cached:     156440 KB
VmPeak:      96156 KB
VmSize:      94680 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18236 KB
VmRSS:       18236 KB
VmData:      38448 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 5463 TID = 5463
5463 5553 5554 5555 5556 

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
419b6000 41a9a000 r-xp /usr/lib/libicuuc.so.51.1
41aaf000 41ab7000 r-xp /usr/lib/libdrm.so.2.4.0
41abf000 41ac1000 r-xp /usr/lib/libdri2.so.0.0.0
41ac9000 41acf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41ad7000 41adc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41ae4000 41afd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41b05000 41b26000 r-xp /usr/lib/libexif.so.12.3.3
41b39000 41b3b000 r-xp /usr/lib/libttrace.so.1.1
41b43000 41b48000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b50000 41b56000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41b5f000 41b67000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41b6f000 41b8b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b94000 41b9b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41ba4000 41ba6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41bae000 41bb5000 r-xp /usr/lib/libminizip.so.1.0.0
41bbd000 41bca000 r-xp /usr/lib/libail.so.0.1.0
41bd6000 41cee000 rw-p [heap]
43277000 43341000 r-xp /usr/lib/libCOREGL.so.4.0
43553000 4355e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43567000 4356c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4370f000 43710000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43719000 43f18000 rw-p [stack:5553]
43f19000 44718000 rw-p [stack:5554]
44719000 44f18000 rw-p [stack:5555]
44f74000 44f75000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44f90000 44f97000 r-xp /usr/lib/libfeedback.so.0.1.4
44fa0000 44fa1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44fa9000 44fab000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44fb3000 44fbd000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
44fc5000 44fcc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44fd4000 44fea000 r-xp /usr/lib/libmmfsound.so.0.1.0
45101000 45900000 rw-p [stack:5556]
45900000 45905000 r-xp /usr/lib/libmmfsession.so.0.0.0
4590d000 45917000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45923000 45927000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45930000 45945000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4594d000 459ae000 r-xp /usr/lib/libasound.so.2.0.0
459b8000 459bb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
459c3000 459fb000 r-xp /usr/lib/libpulse.so.0.16.2
459fc000 459ff000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45a07000 45a38000 r-xp /usr/lib/libmdm.so.1.1.86
45a40000 45a45000 r-xp /usr/lib/libjson.so.0.0.1
45a4d000 45a95000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a96000 45add000 r-xp /usr/lib/libsndfile.so.1.0.26
45ae9000 45af1000 r-xp /usr/lib/libmdm-common.so.1.0.89
45af2000 45b14000 r-xp /usr/lib/libvorbis.so.0.4.3
45b1c000 45b20000 r-xp /usr/lib/libogg.so.0.7.1
bee50000 bee71000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5463)
Call Stack Count: 1
 0: realloc + 0x50 (0x404e62d0) [/lib/libc.so.6] + 0x6f2d0
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
RVER( 5453): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-14 22:59:13.685+0200 E/APPS    (  767): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-14 22:59:13.685+0200 E/APPS    (  767): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-14 22:59:13.705+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-14 22:59:13.715+0200 E/PKGMGR_OBSERVER( 5453): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 22:59:13.745+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-14 22:59:13.770+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 22:59:13.895+0200 W/CERT_SVC( 5452): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 22:59:13.925+0200 E/rpm-installer( 5452): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-14 22:59:13.925+0200 E/rpm-installer( 5452): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-14 22:59:13.925+0200 E/rpm-installer( 5452): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-14 22:59:13.925+0200 E/rpm-installer( 5452): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-14 22:59:13.990+0200 E/PKGMGR_PARSER( 5452): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-14 22:59:13.995+0200 E/PKGMGR_PARSER( 5452): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 22:59:14.020+0200 E/PKGMGR_PARSER( 5452): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-14 22:59:14.090+0200 I/PRIVACY-MANAGER-CLIENT( 5452): SocketClient.cpp: SocketClient(37) > Client created
10-14 22:59:14.185+0200 I/efl-extension( 5452): efl_extension.c: eext_mod_init(40) > Init
10-14 22:59:14.185+0200 I/efl-extension( 5452): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-14 22:59:14.270+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-14 22:59:14.270+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 61
10-14 22:59:14.270+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 61
10-14 22:59:14.275+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-14 22:59:14.275+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-14 22:59:14.275+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-14 22:59:14.275+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-14 22:59:14.290+0200 E/PKGMGR_CERT( 5452): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-14 22:59:14.300+0200 E/PKGMGR_OBSERVER( 5453): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-14 22:59:14.345+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 22:59:14.365+0200 E/rpm-installer( 5452): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-14 22:59:14.375+0200 E/rpm-installer( 5452): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-14 22:59:14.380+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5061 pgid = 5061
10-14 22:59:14.425+0200 E/rpm-installer( 5452): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-14 22:59:14.465+0200 E/PKGMGR_OBSERVER( 5453): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-14 22:59:14.510+0200 E/rpm-installer( 5452): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-14 22:59:14.525+0200 I/AUL_AMD (  535): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5061
10-14 22:59:14.560+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 22:59:14.605+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 22:59:14.605+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4814 pgid = -1
10-14 22:59:14.605+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 22:59:14.615+0200 I/AUL_AMD (  535): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4814
10-14 22:59:14.630+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.351
10-14 22:59:14.930+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:59:14.930+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:59:14.985+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:59:14.990+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:59:15.050+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:59:15.050+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:59:15.055+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:59:15.060+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:59:15.060+0200 E/EFL     ( 5463): elementary<5463> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:59:15.095+0200 E/EFL     ( 5463): elementary<5463> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:59:15.105+0200 E/EFL     ( 5463): elementary<5463> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:59:15.105+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:59:15.185+0200 E/EFL     ( 5463): elementary<5463> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:59:15.200+0200 E/EFL     ( 5463): elementary<5463> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:59:15.200+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:59:15.200+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:59:15.200+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:59:15.200+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:59:15.200+0200 E/EFL     ( 5463): elementary<5463> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:59:15.200+0200 I/AUL_PAD ( 5463): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:59:15.525+0200 E/PKGMGR_OBSERVER( 5453): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[54530002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-14 22:59:15.540+0200 W/W_HOME  (  767): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-14 22:59:15.540+0200 W/W_HOME  (  767): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-14 22:59:15.575+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-14 22:59:15.600+0200 E/PKGMGR_INFO( 5453): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-14 22:59:15.615+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-14 22:59:15.615+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 22:59:15.615+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 22:59:15.620+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 22:59:15.620+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-14 22:59:15.620+0200 E/WMS     (  494): wms_db.c: wms_db_package_event_insert_record(177) > 
10-14 22:59:15.635+0200 E/PKGMGR_OBSERVER( 5453): pkg_observer.c: main(620) > OBSERVER end
10-14 22:59:15.650+0200 E/PKGMGR_SERVER( 5451): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-14 22:59:15.655+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-14 22:59:15.670+0200 E/PKGMGR_SERVER( 5451): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 22:59:15.670+0200 E/PKGMGR_SERVER( 5451): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5453]
10-14 22:59:15.695+0200 E/STARTER (  695): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-14 22:59:15.700+0200 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-14 22:59:15.740+0200 W/APPS    (  767): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 22:59:15.745+0200 W/APPS    (  767): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-14 22:59:15.880+0200 I/efl-extension( 5464): efl_extension.c: eext_mod_init(40) > Init
10-14 22:59:15.940+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:59:15.940+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:59:15.970+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:59:15.975+0200 I/UXT     ( 5464): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 22:59:15.975+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:59:16.025+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:59:16.030+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:59:16.030+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:59:16.030+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:59:16.030+0200 E/EFL     ( 5464): elementary<5464> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:59:16.050+0200 E/EFL     ( 5464): elementary<5464> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:59:16.055+0200 E/EFL     ( 5464): elementary<5464> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:59:16.060+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:59:16.100+0200 E/EFL     ( 5464): elementary<5464> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:59:16.110+0200 E/EFL     ( 5464): elementary<5464> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:59:16.110+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:59:16.115+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:59:16.115+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:59:16.115+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:59:16.115+0200 E/EFL     ( 5464): elementary<5464> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:59:16.115+0200 I/AUL_PAD ( 5464): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:59:16.665+0200 E/rpm-installer( 5452): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 22:59:16.665+0200 E/rpm-installer( 5452): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 22:59:16.665+0200 E/rpm-installer( 5452): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 22:59:16.700+0200 E/PKGMGR_SERVER( 5451): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5452]
10-14 22:59:16.835+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/5452/oom_score_adj failed
10-14 22:59:16.835+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 5452
10-14 22:59:17.650+0200 E/PKGMGR_SERVER( 5451): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 22:59:17.655+0200 E/PKGMGR_SERVER( 5451): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 22:59:20.175+0200 W/AUL     ( 5545): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 22:59:20.180+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 22:59:20.210+0200 I/AUL_AMD (  535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-14 22:59:20.230+0200 I/AUL_AMD (  535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-14 22:59:20.230+0200 E/AUL_AMD (  535): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 22:59:20.230+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 5545
10-14 22:59:20.250+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 22:59:20.250+0200 W/AUL_PAD ( 1190): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 22:59:20.250+0200 W/AUL_PAD ( 1190): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 22:59:20.250+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-14 22:59:20.255+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 22:59:20.335+0200 I/efl-extension( 5463): efl_extension.c: eext_mod_init(40) > Init
10-14 22:59:20.340+0200 I/UXT     ( 5463): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 22:59:20.340+0200 I/CAPI_APPFW_APPLICATION( 5463): app_main.c: ui_app_main(704) > app_efl_main
10-14 22:59:20.350+0200 I/CAPI_APPFW_APPLICATION( 5463): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 22:59:20.355+0200 W/AUL     ( 5545): launch.c: app_request_to_launchpad(282) > request cmd(0) result(5463)
10-14 22:59:20.355+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 22:59:20.485+0200 E/EFL     ( 5463): ecore_evas<5463> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 22:59:20.775+0200 I/APP_CORE( 5463): appcore-efl.c: __do_app(429) > [APP 5463] Event: RESET State: CREATED
10-14 22:59:20.775+0200 I/CAPI_APPFW_APPLICATION( 5463): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 22:59:20.825+0200 W/W_HOME  (  767): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 22:59:20.825+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:20.825+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:20.840+0200 I/APP_CORE( 5463): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 22:59:20.840+0200 I/APP_CORE( 5463): appcore-efl.c: __do_app(474) > [APP 5463] Initial Launching, call the resume_cb
10-14 22:59:20.840+0200 I/CAPI_APPFW_APPLICATION( 5463): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 22:59:20.850+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:20.860+0200 W/APP_CORE( 5463): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3a00002
10-14 22:59:20.930+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 22:59:20.930+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 22:59:20.930+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:20.930+0200 W/W_HOME  (  767): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 22:59:20.935+0200 I/APP_CORE( 5463): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
10-14 22:59:20.940+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: PAUSE State: PAUSED
10-14 22:59:20.940+0200 I/APP_CORE(  767): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-14 22:59:20.940+0200 W/wnotib  (  767): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 22:59:20.950+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 22:59:20.950+0200 W/AUL_AMD (  535): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 22:59:20.975+0200 I/INFO_TAG( 5463): HEART RATE AFTER : 0
10-14 22:59:20.975+0200 I/INFO_TAG( 5463): HEART RATE AFTER : 0
10-14 22:59:20.980+0200 I/INFO_TAG( 5463): HEART RATE AFTER : 0
10-14 22:59:21.195+0200 E/EFL     ( 5463): elementary<5463> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:59:21.250+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 22:59:21.555+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:59:21.575+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5463
10-14 22:59:21.575+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:59:21.590+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5463
10-14 22:59:21.590+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 22:59:21.595+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 22:59:21.705+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:59:21.705+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:59:21.730+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:59:21.730+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:59:21.745+0200 I/INFO_TAG( 5463): HEART RATE AFTER : -3
10-14 22:59:21.785+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:59:21.785+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:59:21.790+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:59:21.790+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:59:21.790+0200 E/EFL     ( 5557): elementary<5557> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:59:21.815+0200 E/EFL     ( 5557): elementary<5557> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:59:21.820+0200 E/EFL     ( 5557): elementary<5557> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:59:21.825+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:59:21.885+0200 E/EFL     ( 5557): elementary<5557> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:59:21.885+0200 E/EFL     ( 5557): elementary<5557> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:59:21.890+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:59:21.890+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:59:21.890+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:59:21.890+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:59:21.890+0200 E/EFL     ( 5557): elementary<5557> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:59:21.890+0200 I/AUL_PAD ( 5557): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:59:22.755+0200 I/INFO_TAG( 5463): HEART RATE AFTER : -3
10-14 22:59:23.755+0200 I/INFO_TAG( 5463): HEART RATE AFTER : -3
10-14 22:59:24.035+0200 W/WATCH_CORE(  813): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-14 22:59:24.035+0200 I/WATCH_CORE(  813): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-14 22:59:24.050+0200 I/CAPI_WATCH_APPLICATION(  813): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 22:59:24.075+0200 W/W_HOME  (  767): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-14 22:59:24.075+0200 W/W_HOME  (  767): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-14 22:59:24.075+0200 W/W_HOME  (  767): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 22:59:24.075+0200 W/W_HOME  (  767): gesture.c: _apps_status_get(126) > apps status:0
10-14 22:59:24.075+0200 W/W_HOME  (  767): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:23685
10-14 22:59:24.075+0200 W/W_HOME  (  767): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-14 22:59:24.075+0200 W/W_HOME  (  767): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-14 22:59:24.075+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:24.080+0200 W/STARTER (  695): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [23685]ms
10-14 22:59:24.080+0200 W/STARTER (  695): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-14 22:59:24.105+0200 I/APP_CORE( 5463): appcore-efl.c: __do_app(429) > [APP 5463] Event: RESUME State: RUNNING
10-14 22:59:24.200+0200 W/SHealth_Common(  826): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 22:59:24.205+0200 W/SHealth_Common( 1100): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 22:59:24.205+0200 W/SHealth_Service( 1100): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 22:59:24.235+0200 W/STARTER (  695): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
10-14 22:59:24.235+0200 W/STARTER (  695): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-14 22:59:24.245+0200 E/wnoti-service(  869): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-14 22:59:24.245+0200 E/wnoti-service(  869): wnoti-native-client.c: handle_cache_notification(603) > >>
10-14 22:59:24.250+0200 W/WATCH_CORE(  813): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 22:59:24.250+0200 I/WATCH_CORE(  813): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 22:59:24.250+0200 I/CAPI_WATCH_APPLICATION(  813): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 22:59:24.255+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_boolean(1173) > preference_get_boolean(1100) : test_healthy_pace error
10-14 22:59:24.260+0200 W/SHealth_Service( 1100): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_double(1214) > preference_get_double(1100) : pedometer_inactive_period error
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_double(1214) > preference_get_double(1100) : inactive_10min_precaution_millisec error
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-14 22:59:24.260+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_double(1214) > preference_get_double(1100) : inactive_before_10min_precaution_millisec error
10-14 22:59:24.265+0200 W/SHealth_Service( 1100): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-14 22:59:24.275+0200 W/W_HOME  (  767): gesture.c: _manual_render_disable_timer_cb(143) > timeout callback expired
10-14 22:59:24.275+0200 W/W_HOME  (  767): gesture.c: _manual_render_enable(136) > 0
10-14 22:59:24.275+0200 W/W_HOME  (  767): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 22:59:24.280+0200 E/EFL     (  767): evas_main<767> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e2a090 is not stable during recalc loop
10-14 22:59:24.280+0200 E/EFL     (  767): evas_main<767> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e2a090 is not stable during recalc loop
10-14 22:59:24.290+0200 I/MALI    (  767): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-14 22:59:24.760+0200 I/INFO_TAG( 5463): HEART RATE AFTER : 0
10-14 22:59:25.760+0200 I/INFO_TAG( 5463): HEART RATE AFTER : -3
10-14 22:59:25.840+0200 E/EFL     ( 5463): ecore_x<5463> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=831188 button=1
10-14 22:59:25.895+0200 E/EFL     ( 5463): ecore_x<5463> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=831246 button=1
10-14 22:59:26.125+0200 E/EFL     ( 5463): elementary<5463> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 22:59:26.150+0200 E/EFL     ( 5463): elementary<5463> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 22:59:26.505+0200 E/EFL     ( 5463): elementary<5463> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:59:26.765+0200 I/INFO_TAG_SENSOR_EVENT2( 5463): HEART RATE : -3
10-14 22:59:26.770+0200 F/EFL     ( 5463): evas_main<5463> main.c:122 evas_debug_magic_wrong() Input object is wrong type
10-14 22:59:26.770+0200 F/EFL     ( 5463):     Expected: 71737723 - Evas_Object
10-14 22:59:26.770+0200 F/EFL     ( 5463):     Supplied: 4146b70f - <UNKNOWN>
10-14 22:59:27.335+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 5463 pgid = 5463
10-14 22:59:27.525+0200 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-14 22:59:27.620+0200 W/W_HOME  (  767): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 22:59:27.630+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.630+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.660+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.685+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 22:59:27.685+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 22:59:27.685+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.685+0200 W/W_HOME  (  767): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 22:59:27.685+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: RESUME State: PAUSED
10-14 22:59:27.685+0200 I/CAPI_APPFW_APPLICATION(  767): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 22:59:27.685+0200 W/W_HOME  (  767): main.c: _appcore_resume_cb(687) > appcore resume
10-14 22:59:27.685+0200 W/W_HOME  (  767): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 22:59:27.685+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.690+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.690+0200 W/W_HOME  (  767): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
10-14 22:59:27.690+0200 W/W_HOME  (  767): main.c: home_resume(739) > clock/widget resumed
10-14 22:59:27.690+0200 W/W_HOME  (  767): clock_indicator.c: clock_indicator_resume(537) > 
10-14 22:59:27.695+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:59:27.705+0200 W/wnotib  (  767): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 22:59:27.715+0200 W/WATCH_CORE(  813): appcore-watch.c: __widget_resume(1039) > widget_resume
10-14 22:59:27.715+0200 I/CAPI_WATCH_APPLICATION(  813): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 22:59:27.720+0200 W/WSLib   (  826): LabelWidget.cpp: StartSliding(138) > [1;35m ###[0;m
10-14 22:59:27.740+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 22:59:27.740+0200 W/AUL_AMD (  535): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 22:59:27.745+0200 W/WATCH_CORE(  813): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-14 22:59:27.745+0200 I/WATCH_CORE(  813): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-14 22:59:27.745+0200 I/CAPI_WATCH_APPLICATION(  813): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 22:59:27.850+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:59:27.855+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:59:27.860+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-14 22:59:27.860+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-14 22:59:27.865+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
10-14 22:59:27.875+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-14 22:59:27.875+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-14 22:59:27.875+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-14 22:59:27.875+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-14 22:59:27.880+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-14 22:59:27.880+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-14 22:59:27.880+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-14 22:59:27.880+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-14 22:59:27.880+0200 W/SHealthWidget(  826): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>62</color> bpm</color>][0;m
10-14 22:59:27.880+0200 W/SHealth_Common(  826): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
10-14 22:59:27.885+0200 W/SHealth_Common(  826): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
10-14 22:59:27.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-14 22:59:27.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-14 22:59:27.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-14 22:59:27.885+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-14 22:59:27.895+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-14 22:59:27.895+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-14 22:59:27.895+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-14 22:59:27.895+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-14 22:59:27.900+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-14 22:59:27.900+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-14 22:59:27.900+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-14 22:59:27.900+0200 E/TIZEN_N_SYSTEM_SETTINGS(  826): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-14 22:59:27.920+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 22:59:27.930+0200 I/AUL_AMD (  535): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5463
10-14 22:59:27.930+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:59:27.930+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:59:27.930+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-14 22:59:27.940+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:59:27.945+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:59:27.945+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-14 22:59:27.965+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.359
10-14 22:59:27.965+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:59:27.980+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:59:27.980+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-14 22:59:27.985+0200 I/MALI    (  767): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
10-14 22:59:28.000+0200 W/SHealth_Common(  826): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 22:59:28.000+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 22:59:28.005+0200 I/CAPI_WIDGET_APPLICATION(  826): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-14 22:59:28.030+0200 W/CRASH_MANAGER( 5592): worker.c: worker_job(1205) > 1105463646174150801476
