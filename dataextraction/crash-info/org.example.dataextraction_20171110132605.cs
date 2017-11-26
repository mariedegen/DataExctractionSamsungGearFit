S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10552
Date: 2017-11-10 13:26:05+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0x5652dc00
r4   = 0xbeb97504, r5   = 0x41541980
r6   = 0x00000249, r7   = 0xbeb97440
r8   = 0xbeb974d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbeb97428
lr   = 0x41744cb7, pc   = 0x41746210
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     62928 KB
Buffers:     38532 KB
Cached:     160060 KB
VmPeak:      93872 KB
VmSize:      93500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17096 KB
VmRSS:       17092 KB
VmData:      40124 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23076 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10552 TID = 10552
10552 10617 10626 10627 10628 

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
435b8000 43db7000 rw-p [stack:10617]
43db7000 43dc2000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dcb000 43dd0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43dde000 43de6000 r-xp /usr/lib/libdrm.so.2.4.0
43dee000 43df5000 r-xp /usr/lib/libtbm.so.1.0.0
43f00000 43f02000 r-xp /usr/lib/libdri2.so.0.0.0
43fa5000 43fa6000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fb0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43fb9000 447b8000 rw-p [stack:10626]
447b9000 44fb8000 rw-p [stack:10627]
44fb9000 458b8000 rw-p [stack:10628]
45914000 45917000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45a7b000 45a7c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
beb77000 beb98000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10552)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x41746210) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3210
 1: app_terminate + 0x26 (0x41744cb7) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1cb7
 2: (0x41540af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41744c3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
 6: create_base_gui + 0x4a (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: clicked_end_app + 0x3 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
_release() ButtonEvent:release time=2356439 button=1
11-10 13:25:52.075+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:25:52.080+0200 E/APPS    (  765): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
11-10 13:25:52.115+0200 E/PKGMGR  (10474): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
11-10 13:25:52.325+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: main(2167) > package manager server start
11-10 13:25:52.430+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_787405190], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_787405190' '-r' 'org.example.dataextraction'], cookie=[r5UZTCjU/GVwapByAMqaUH2LF9g=], backend_flag=[0]
11-10 13:25:52.435+0200 E/PKGMGR  (10476): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
11-10 13:25:52.435+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
11-10 13:25:52.445+0200 E/PKGMGR  (10474): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[104740002]
11-10 13:25:52.450+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
11-10 13:25:52.455+0200 E/PKGMGR_SERVER(10477): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
11-10 13:25:52.460+0200 E/PKGMGR_SERVER(10478): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
11-10 13:25:52.620+0200 E/PKGMGR_OBSERVER(10478): pkg_observer.c: main(601) > OBSERVER start
11-10 13:25:52.790+0200 E/rpm-installer(10477): rpm-appcore-intf.c: main(120) > ------------------------------------------------
11-10 13:25:52.790+0200 E/rpm-installer(10477): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
11-10 13:25:52.790+0200 E/rpm-installer(10477): rpm-appcore-intf.c: main(122) > ------------------------------------------------
11-10 13:25:53.015+0200 E/PKGMGR_OBSERVER(10478): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[104780002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
11-10 13:25:53.050+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
11-10 13:25:53.050+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
11-10 13:25:53.055+0200 E/PKGMGR_OBSERVER(10478): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[104780002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
11-10 13:25:53.055+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
11-10 13:25:53.090+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
11-10 13:25:53.135+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
11-10 13:25:53.290+0200 W/CERT_SVC(10477): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
11-10 13:25:53.305+0200 E/rpm-installer(10477): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
11-10 13:25:53.305+0200 E/rpm-installer(10477): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
11-10 13:25:53.305+0200 E/rpm-installer(10477): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
11-10 13:25:53.330+0200 E/PKGMGR_PARSER(10477): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
11-10 13:25:53.350+0200 I/PRIVACY-MANAGER-CLIENT(10477): SocketClient.cpp: SocketClient(37) > Client created
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: mainloop(227) > Got incoming connection
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-CLIENT(10477): SocketStream.h: SocketStream(31) > Created
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-CLIENT(10477): SocketConnection.h: SocketConnection(44) > Created
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-CLIENT(10477): SocketClient.cpp: connect(62) > Client connected
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionThread(253) > Starting connection thread
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketStream.h: SocketStream(31) > Created
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketConnection.h: SocketConnection(44) > Created
11-10 13:25:53.355+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionService(304) > Calling service
11-10 13:25:53.360+0200 I/PRIVACY-MANAGER-CLIENT(10477): SocketClient.cpp: disconnect(72) > Client disconnected
11-10 13:25:53.370+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionService(307) > Removing client
11-10 13:25:53.370+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionService(311) > Call served
11-10 13:25:53.370+0200 I/PRIVACY-MANAGER-SERVER(  485): SocketService.cpp: connectionThread(262) > Client serviced
11-10 13:25:53.375+0200 E/PKGMGR_CERT(10477): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
11-10 13:25:53.380+0200 E/PKGMGR_CERT(10477): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
11-10 13:25:53.405+0200 E/PKGMGR_CERT(10477): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
11-10 13:25:53.480+0200 E/rpm-installer(10477): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
11-10 13:25:53.490+0200 E/PKGMGR_OBSERVER(10478): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[104780002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
11-10 13:25:53.495+0200 E/APPS    (  765): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
11-10 13:25:53.495+0200 E/APPS    (  765): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
11-10 13:25:53.515+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
11-10 13:25:53.520+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
11-10 13:25:53.520+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
11-10 13:25:53.520+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
11-10 13:25:53.520+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
11-10 13:25:53.530+0200 E/PKGMGR_OBSERVER(10478): pkg_observer.c: main(620) > OBSERVER end
11-10 13:25:53.540+0200 E/STARTER (  720): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
11-10 13:25:53.550+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
11-10 13:25:53.550+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10478]
11-10 13:25:53.685+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=2358049 button=1
11-10 13:25:53.685+0200 E/W_HOME  (  765): move.c: _mouse_move_cb(546) > apps move is not allowed
11-10 13:25:53.685+0200 E/W_HOME  (  765): move.c: _mouse_down_cb(384) > apps move is not allowed
11-10 13:25:53.685+0200 W/APPS    (  765): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-10 13:25:53.735+0200 E/EFL     (  765): ecore_x<765> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=2358098 button=1
11-10 13:25:53.735+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-10 13:25:53.735+0200 E/APPS    (  765): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-10 13:25:53.735+0200 W/APPS    (  765): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-10 13:25:53.735+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:25:53.735+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:25:53.740+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 765
11-10 13:25:53.740+0200 W/AUL     (  765): launch.c: app_request_to_launchpad(282) > request cmd(0) result(-14)
11-10 13:25:53.740+0200 E/CAPI_APPFW_APP_CONTROL(  765): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
11-10 13:25:54.380+0200 E/rpm-installer(10477): rpm-appcore-intf.c: main(273) > ------------------------------------------------
11-10 13:25:54.380+0200 E/rpm-installer(10477): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
11-10 13:25:54.380+0200 E/rpm-installer(10477): rpm-appcore-intf.c: main(275) > ------------------------------------------------
11-10 13:25:54.425+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10477]
11-10 13:25:54.435+0200 E/RESOURCED(  514): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/10477/oom_score_adj failed
11-10 13:25:54.435+0200 E/RESOURCED(  514): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 10477
11-10 13:25:54.635+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-10 13:25:54.635+0200 E/PKGMGR_SERVER(10476): pkgmgr-server.c: main(2221) > package manager server terminated.
11-10 13:25:55.470+0200 E/PKGMGR  (10535): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
11-10 13:25:55.675+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: main(2167) > package manager server start
11-10 13:25:55.785+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_790737784], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_790737784' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[NNDpTv949EvE7ADl+7ICCzvlf3M=], backend_flag=[0]
11-10 13:25:55.790+0200 E/PKGMGR  (10537): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
11-10 13:25:55.795+0200 E/PKGMGR  (10535): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[105350002]
11-10 13:25:55.810+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
11-10 13:25:55.810+0200 E/PKGMGR_SERVER(10540): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
11-10 13:25:55.820+0200 E/PKGMGR_SERVER(10541): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
11-10 13:25:55.950+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: main(601) > OBSERVER start
11-10 13:25:56.005+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(120) > ------------------------------------------------
11-10 13:25:56.025+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
11-10 13:25:56.025+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(122) > ------------------------------------------------
11-10 13:25:56.165+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
11-10 13:25:56.185+0200 E/rpm-installer(10540): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
11-10 13:25:56.185+0200 E/rpm-installer(10540): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
11-10 13:25:56.190+0200 E/rpm-installer(10540): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
11-10 13:25:56.190+0200 E/rpm-installer(10540): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
11-10 13:25:56.190+0200 E/rpm-installer(10540): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
11-10 13:25:56.290+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[105410002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
11-10 13:25:56.305+0200 E/APPS    (  765): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
11-10 13:25:56.305+0200 E/APPS    (  765): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
11-10 13:25:56.325+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
11-10 13:25:56.330+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[105410002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
11-10 13:25:56.360+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
11-10 13:25:56.385+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:25:56.565+0200 W/CERT_SVC(10540): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
11-10 13:25:56.595+0200 E/rpm-installer(10540): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
11-10 13:25:56.595+0200 E/rpm-installer(10540): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
11-10 13:25:56.595+0200 E/rpm-installer(10540): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
11-10 13:25:56.600+0200 E/rpm-installer(10540): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
11-10 13:25:56.665+0200 E/PKGMGR_PARSER(10540): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
11-10 13:25:56.670+0200 E/PKGMGR_PARSER(10540): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
11-10 13:25:56.695+0200 E/PKGMGR_PARSER(10540): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
11-10 13:25:56.765+0200 I/PRIVACY-MANAGER-CLIENT(10540): SocketClient.cpp: SocketClient(37) > Client created
11-10 13:25:56.865+0200 I/efl-extension(10540): efl_extension.c: eext_mod_init(40) > Init
11-10 13:25:56.865+0200 I/efl-extension(10540): efl_extension.c: eext_mod_shutdown(46) > Shutdown
11-10 13:25:56.950+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
11-10 13:25:56.950+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
11-10 13:25:56.955+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
11-10 13:25:56.955+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
11-10 13:25:56.955+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
11-10 13:25:56.955+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
11-10 13:25:56.955+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
11-10 13:25:56.980+0200 E/PKGMGR_CERT(10540): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
11-10 13:25:57.005+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:25:57.010+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[105410002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
11-10 13:25:57.045+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:25:57.115+0200 E/rpm-installer(10540): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
11-10 13:25:57.125+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10323 pgid = 10323
11-10 13:25:57.145+0200 E/rpm-installer(10540): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
11-10 13:25:57.255+0200 E/rpm-installer(10540): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
11-10 13:25:57.310+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[105410002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
11-10 13:25:57.345+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10323
11-10 13:25:57.380+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
11-10 13:25:57.445+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:25:57.445+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10250 pgid = -1
11-10 13:25:57.445+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:25:57.460+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10250
11-10 13:25:57.475+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.590
11-10 13:25:57.490+0200 E/rpm-installer(10540): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
11-10 13:25:57.635+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
11-10 13:25:58.435+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[105410002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
11-10 13:25:58.455+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
11-10 13:25:58.455+0200 W/W_HOME  (  765): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
11-10 13:25:58.520+0200 W/AUL_AMD (  504): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
11-10 13:25:58.530+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
11-10 13:25:58.530+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
11-10 13:25:58.530+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
11-10 13:25:58.530+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
11-10 13:25:58.530+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
11-10 13:25:58.530+0200 E/WMS     (  493): wms_db.c: wms_db_package_event_insert_record(177) > 
11-10 13:25:58.560+0200 E/WMS     (  493): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
11-10 13:25:58.575+0200 E/PKGMGR_INFO(10541): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
11-10 13:25:58.605+0200 E/PKGMGR_OBSERVER(10541): pkg_observer.c: main(620) > OBSERVER end
11-10 13:25:58.620+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
11-10 13:25:58.620+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10541]
11-10 13:25:58.645+0200 E/STARTER (  720): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
11-10 13:25:58.700+0200 E/PKGMGR_INFO(  492): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
11-10 13:25:58.715+0200 W/APPS    (  765): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-10 13:25:58.715+0200 W/APPS    (  765): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
11-10 13:25:58.780+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:25:58.785+0200 E/EFL     (  765): evas_main<765> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e08ad8 is not stable during recalc loop
11-10 13:25:59.635+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
11-10 13:25:59.660+0200 E/EFL     (10552): elementary<10552> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:25:59.670+0200 E/EFL     (10552): elementary<10552> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:25:59.715+0200 E/EFL     (10552): elementary<10552> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:25:59.725+0200 E/EFL     (10552): elementary<10552> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:25:59.795+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(273) > ------------------------------------------------
11-10 13:25:59.795+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
11-10 13:25:59.795+0200 E/rpm-installer(10540): rpm-appcore-intf.c: main(275) > ------------------------------------------------
11-10 13:25:59.820+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10540]
11-10 13:25:59.855+0200 E/EFL     (10552): elementary<10552> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:25:59.895+0200 E/RESOURCED(  514): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/10540/oom_score_adj failed
11-10 13:25:59.895+0200 E/RESOURCED(  514): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 10540
11-10 13:25:59.910+0200 E/EFL     (10552): elementary<10552> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:25:59.910+0200 E/EFL     (10552): elementary<10552> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:25:59.915+0200 E/EFL     (10552): elementary<10552> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:25:59.915+0200 E/EFL     (10552): elementary<10552> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:25:59.945+0200 E/EFL     (10552): elementary<10552> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:25:59.965+0200 E/EFL     (10552): elementary<10552> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:25:59.965+0200 E/EFL     (10552): elementary<10552> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:26:00.030+0200 E/EFL     (10552): elementary<10552> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:26:00.045+0200 E/EFL     (10552): elementary<10552> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:26:00.045+0200 E/EFL     (10552): elementary<10552> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:26:00.045+0200 E/EFL     (10552): elementary<10552> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:26:00.045+0200 E/EFL     (10552): elementary<10552> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:26:00.045+0200 E/EFL     (10552): elementary<10552> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:26:00.050+0200 E/EFL     (10552): elementary<10552> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:26:00.050+0200 I/AUL_PAD (10552): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:26:00.295+0200 I/efl-extension(10553): efl_extension.c: eext_mod_init(40) > Init
11-10 13:26:00.350+0200 E/EFL     (10553): elementary<10553> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:26:00.350+0200 E/EFL     (10553): elementary<10553> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:26:00.375+0200 E/EFL     (10553): elementary<10553> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:26:00.380+0200 I/UXT     (10553): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
11-10 13:26:00.385+0200 E/EFL     (10553): elementary<10553> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:26:00.435+0200 E/EFL     (10553): elementary<10553> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:26:00.440+0200 E/EFL     (10553): elementary<10553> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:26:00.440+0200 E/EFL     (10553): elementary<10553> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:26:00.440+0200 E/EFL     (10553): elementary<10553> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:26:00.445+0200 E/EFL     (10553): elementary<10553> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:26:00.510+0200 E/EFL     (10553): elementary<10553> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:26:00.515+0200 E/EFL     (10553): elementary<10553> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:26:00.530+0200 E/EFL     (10553): elementary<10553> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:26:00.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
11-10 13:26:00.545+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : pedometer_inactive_period error
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_10min_precaution_millisec error
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
11-10 13:26:00.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1107): preference.c: preference_get_double(1214) > preference_get_double(1107) : inactive_before_10min_precaution_millisec error
11-10 13:26:00.595+0200 E/EFL     (10553): elementary<10553> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:26:00.610+0200 E/EFL     (10553): elementary<10553> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:26:00.610+0200 E/EFL     (10553): elementary<10553> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:26:00.610+0200 E/EFL     (10553): elementary<10553> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:26:00.615+0200 E/EFL     (10553): elementary<10553> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:26:00.630+0200 E/EFL     (10553): elementary<10553> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:26:00.640+0200 E/EFL     (10553): elementary<10553> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:26:00.640+0200 I/AUL_PAD (10553): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:26:01.585+0200 W/AUL     (10616): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:26:01.590+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:26:01.605+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 13:26:01.620+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 13:26:01.620+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 13:26:01.620+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 10616
11-10 13:26:01.635+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-10 13:26:01.635+0200 E/PKGMGR_SERVER(10537): pkgmgr-server.c: main(2221) > package manager server terminated.
11-10 13:26:01.640+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
11-10 13:26:01.640+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:26:01.640+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:26:01.645+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:26:01.645+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:26:01.750+0200 I/efl-extension(10552): efl_extension.c: eext_mod_init(40) > Init
11-10 13:26:01.750+0200 I/CAPI_APPFW_APPLICATION(10552): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:26:01.765+0200 I/CAPI_APPFW_APPLICATION(10552): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:26:01.850+0200 W/AUL     (10616): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10552)
11-10 13:26:01.905+0200 I/Bluetooth(10552): [bt_initialize] success.
11-10 13:26:01.945+0200 I/Bluetooth(10552): [bt_adapter_get_state] success.
11-10 13:26:02.030+0200 E/EFL     (10552): ecore_evas<10552> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:26:02.400+0200 I/APP_CORE(10552): appcore-efl.c: __do_app(429) > [APP 10552] Event: RESET State: CREATED
11-10 13:26:02.400+0200 I/CAPI_APPFW_APPLICATION(10552): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:26:02.425+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:26:02.425+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.425+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.425+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.480+0200 I/APP_CORE(10552): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:26:02.480+0200 I/APP_CORE(10552): appcore-efl.c: __do_app(474) > [APP 10552] Initial Launching, call the resume_cb
11-10 13:26:02.480+0200 I/CAPI_APPFW_APPLICATION(10552): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:26:02.490+0200 W/APP_CORE(10552): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3e00002
11-10 13:26:02.590+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:26:02.590+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:26:02.590+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.590+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:26:02.595+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:26:02.595+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:26:02.595+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:26:02.595+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:26:02.595+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.595+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.595+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:02.605+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:02.610+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:02.610+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:26:02.610+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:26:02.625+0200 I/APP_CORE(10552): appcore-efl.c: __do_app(429) > [APP 10552] Event: RESUME State: RUNNING
11-10 13:26:02.635+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:26:02.635+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:26:02.665+0200 I/INFO_TAG(10552): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:02.665+0200 I/INFO_TAG(10552): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:02.710+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:26:02.840+0200 E/EFL     (10552): elementary<10552> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:02.840+0200 E/EFL     (10552): elementary<10552> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:02.840+0200 E/EFL     (10552): elementary<10552> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:02.940+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.596
11-10 13:26:02.950+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:02.955+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10552
11-10 13:26:02.970+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:26:02.970+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:02.990+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:03.000+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10552
11-10 13:26:03.000+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:03.115+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:26:03.165+0200 E/EFL     (10630): elementary<10630> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:26:03.170+0200 E/EFL     (10630): elementary<10630> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:26:03.195+0200 E/EFL     (10630): elementary<10630> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:26:03.200+0200 E/EFL     (10630): elementary<10630> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:26:03.255+0200 E/EFL     (10630): elementary<10630> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:26:03.255+0200 E/EFL     (10630): elementary<10630> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:26:03.260+0200 E/EFL     (10630): elementary<10630> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:26:03.260+0200 E/EFL     (10630): elementary<10630> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:26:03.260+0200 E/EFL     (10630): elementary<10630> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:26:03.280+0200 E/EFL     (10630): elementary<10630> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:26:03.285+0200 E/EFL     (10630): elementary<10630> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:26:03.285+0200 E/EFL     (10630): elementary<10630> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:26:03.325+0200 E/EFL     (10630): elementary<10630> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:26:03.340+0200 E/EFL     (10630): elementary<10630> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:26:03.340+0200 E/EFL     (10630): elementary<10630> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:26:03.345+0200 E/EFL     (10630): elementary<10630> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:26:03.345+0200 E/EFL     (10630): elementary<10630> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:26:03.345+0200 E/EFL     (10630): elementary<10630> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:26:03.345+0200 E/EFL     (10630): elementary<10630> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:26:03.345+0200 I/AUL_PAD (10630): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:26:03.360+0200 I/INFO_TAG(10552): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:03.660+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
11-10 13:26:03.660+0200 W/W_INDICATOR(  740): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-10 13:26:04.360+0200 I/INFO_TAG(10552): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:04.690+0200 E/PKGMGR_SERVER(10666): pkgmgr-server.c: main(2167) > package manager server start
11-10 13:26:04.835+0200 E/PKGMGR_SERVER(10666): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_799733901], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[x9qLHgA3n4XG5icOsc938ijUyn0=], backend_flag=[0]
11-10 13:26:04.845+0200 E/PKGMGR_SERVER(10684): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
11-10 13:26:04.850+0200 E/PKGMGR  (10664): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
11-10 13:26:04.960+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:04.970+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10552
11-10 13:26:04.970+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:04.970+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(268) > request cmd(5) to(2278)
11-10 13:26:04.975+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:26:04.975+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(2278) is dead. cmd(5) is canceled
11-10 13:26:04.975+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:26:04.975+0200 E/PKGMGR_SERVER(10684): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:26:04.975+0200 E/PKGMGR_SERVER(10684): [0;m
11-10 13:26:04.975+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(268) > request cmd(5) to(2514)
11-10 13:26:04.975+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:26:04.980+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(2514) is dead. cmd(5) is canceled
11-10 13:26:04.980+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:26:04.980+0200 E/PKGMGR_SERVER(10684): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:26:04.980+0200 E/PKGMGR_SERVER(10684): [0;m
11-10 13:26:04.980+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(268) > request cmd(5) to(2876)
11-10 13:26:04.980+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:26:04.980+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(2876) is dead. cmd(5) is canceled
11-10 13:26:04.985+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:26:04.985+0200 E/PKGMGR_SERVER(10684): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:26:04.985+0200 E/PKGMGR_SERVER(10684): [0;m
11-10 13:26:04.985+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(268) > request cmd(5) to(3782)
11-10 13:26:04.985+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:26:04.985+0200 E/AUL_AMD (  504): amd_request.c: __app_process_by_pid(193) > pid(3782) is dead. cmd(5) is canceled
11-10 13:26:04.985+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(282) > request cmd(5) result(-3)
11-10 13:26:04.985+0200 E/PKGMGR_SERVER(10684): pkgmgr-server.c: __terminate_app(1420) > [0;31m[__terminate_app(): 1420](ret < 0) aul_terminate_pid[-3] fail
11-10 13:26:04.985+0200 E/PKGMGR_SERVER(10684): [0;m
11-10 13:26:04.985+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(268) > request cmd(5) to(10552)
11-10 13:26:04.985+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 5
11-10 13:26:04.990+0200 I/APP_CORE(10552): appcore-efl.c: __do_app(429) > [APP 10552] Event: TERMINATE State: RUNNING
11-10 13:26:04.995+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 22
11-10 13:26:04.995+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(916) > app status : 4
11-10 13:26:04.995+0200 W/AUL_AMD (  504): amd_launch.c: __reply_handler(922) > listen fd(22) , send fd(21), pid(10552), cmd(4)
11-10 13:26:04.995+0200 W/AUL     (10684): launch.c: app_request_to_launchpad(282) > request cmd(5) result(0)
11-10 13:26:04.995+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:05.010+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10552
11-10 13:26:05.070+0200 E/APP_CORE(10552): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-10 13:26:05.070+0200 I/APP_CORE(10552): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-10 13:26:05.075+0200 I/CAPI_APPFW_APPLICATION(10552): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-10 13:26:05.075+0200 I/Bluetooth(10552): [bt_deinitialize] success.
11-10 13:26:05.110+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:05.120+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10552
11-10 13:26:05.200+0200 W/CRASH_MANAGER(10383): worker.c: worker_job(1205) > 1110552646174151031316
