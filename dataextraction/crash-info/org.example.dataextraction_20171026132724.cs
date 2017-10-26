S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 22095
Date: 2017-10-26 13:27:24+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b76b8, r1   = 0x00000001
r2   = 0x4044a250, r3   = 0x81525500
r4   = 0xbe8262fc, r5   = 0x40059d30
r6   = 0x00000233, r7   = 0xbe826220
r8   = 0xbe8262cc, r9   = 0x404bdc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40392a00, sp   = 0xbe8261f0
lr   = 0x40392ab4, pc   = 0x40002c3c
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:      8456 KB
Buffers:     48028 KB
Cached:     170712 KB
VmPeak:      64156 KB
VmSize:      64152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11788 KB
VmRSS:       11788 KB
VmData:      11544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23428 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22095 TID = 22095
22095 22097 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40015000 40032000 r-xp /lib/ld-2.13.so
4004e000 40052000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005a000 4008c000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
40095000 40099000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400a2000 400aa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400ab000 400ad000 r-xp /usr/lib/libdlog.so.0.0.0
400b5000 400d6000 r-xp /usr/lib/libefl-extension.so.0.1.0
400df000 40219000 r-xp /usr/lib/libelementary.so.1.7.99
40230000 402fe000 r-xp /usr/lib/libevas.so.1.7.99
40324000 4043f000 r-xp /lib/libc-2.13.so
4044d000 40455000 r-xp /lib/libgcc_s-4.6.so.1
40456000 40461000 r-xp /lib/libunwind.so.8.0.1
4048e000 40490000 r-xp /lib/libdl-2.13.so
40499000 4049d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404a6000 404a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404b1000 404b6000 r-xp /usr/lib/libappcore-efl.so.1.1
404be000 404c3000 r-xp /usr/lib/libappcore-common.so.1.1
404cb000 404d7000 r-xp /usr/lib/libaul.so.0.1.0
404e1000 40503000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4050b000 4054c000 r-xp /usr/lib/libeina.so.1.7.99
40555000 40569000 r-xp /lib/libpthread-2.13.so
40574000 405ae000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
405b7000 405d0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
405d8000 405dd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e5000 406b5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
406b6000 406bc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c5000 406ef000 r-xp /usr/lib/libsensor.so.1.9.6
406f8000 4078c000 r-xp /usr/lib/libstdc++.so.6.0.16
4079f000 40808000 r-xp /lib/libm-2.13.so
40811000 40861000 r-xp /usr/lib/libecore_x.so.1.7.99
40863000 40885000 r-xp /usr/lib/libecore_evas.so.1.7.99
4088e000 40897000 r-xp /usr/lib/libvconf.so.0.2.45
4089f000 408c7000 r-xp /usr/lib/libfontconfig.so.1.8.0
408c8000 40994000 r-xp /usr/lib/libxml2.so.2.7.8
409a1000 409b3000 r-xp /usr/lib/libefl-assist.so.0.1.0
409bb000 409d2000 r-xp /usr/lib/libecore.so.1.7.99
409e9000 40a47000 r-xp /usr/lib/libedje.so.1.7.99
40a50000 40b08000 r-xp /usr/lib/libcairo.so.2.11200.14
40b13000 40bf4000 r-xp /usr/lib/libX11.so.6.3.0
40bff000 40c08000 r-xp /usr/lib/libXi.so.6.1.0
40c10000 40c29000 r-xp /usr/lib/libeet.so.1.7.99
40c3a000 40c3f000 r-xp /usr/lib/libecore_file.so.1.7.99
40c47000 40c58000 r-xp /usr/lib/libecore_input.so.1.7.99
40c60000 40c69000 r-xp /usr/lib/libedbus.so.1.7.99
40c71000 40c9b000 r-xp /usr/lib/libdbus-1.so.3.8.12
40ca4000 40cbe000 r-xp /usr/lib/libecore_con.so.1.7.99
40cc7000 40cda000 r-xp /usr/lib/libfribidi.so.0.3.1
40ce3000 40d20000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d29000 40d7f000 r-xp /usr/lib/libfreetype.so.6.11.3
40d8b000 40de1000 r-xp /usr/lib/libpixman-1.so.0.28.2
40dee000 40df4000 r-xp /usr/lib/libappsvc.so.0.1.0
40dfc000 40dff000 r-xp /usr/lib/libbundle.so.0.1.22
40e08000 40e0e000 r-xp /usr/lib/libecore_imf.so.1.7.99
40e16000 40e4a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40e53000 40e55000 r-xp /usr/lib/libiniparser.so.0
40e5e000 40e75000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e7d000 40e82000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e8b000 40ec7000 r-xp /usr/lib/libsystemd.so.0.4.0
40ed0000 40ed4000 r-xp /usr/lib/libproc-stat.so.0.2.86
40edd000 40ef3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40efc000 40f71000 r-xp /usr/lib/libsqlite3.so.0.8.6
40f7b000 40f81000 r-xp /lib/librt-2.13.so
40f8b000 40fb9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40fc2000 41095000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
410a0000 410a3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
410ab000 410ad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410b6000 410bc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
410c6000 410ce000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
410d6000 410e0000 r-xp /usr/lib/libsensord-shared.so
410e9000 410f0000 r-xp /usr/lib/libXcursor.so.1.0.2
410f8000 410fa000 r-xp /usr/lib/libXdamage.so.1.1.0
41102000 41104000 r-xp /usr/lib/libXcomposite.so.1.0.0
4110d000 4110f000 r-xp /usr/lib/libXgesture.so.7.0.0
41117000 4111a000 r-xp /usr/lib/libXfixes.so.3.1.0
41122000 41123000 r-xp /usr/lib/libXinerama.so.1.0.0
4112c000 41132000 r-xp /usr/lib/libXrandr.so.2.2.0
4113a000 41140000 r-xp /usr/lib/libXrender.so.1.3.0
41148000 4114c000 r-xp /usr/lib/libXtst.so.6.1.0
41155000 4115f000 r-xp /usr/lib/libXext.so.6.4.0
41168000 4116d000 r-xp /usr/lib/libecore_fb.so.1.7.99
41176000 4117a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41183000 41186000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4118e000 411a4000 r-xp /lib/libexpat.so.1.5.2
411af000 411c5000 r-xp /lib/libz.so.1.2.5
411cd000 411df000 r-xp /usr/lib/libtts.so
411e7000 41209000 r-xp /usr/lib/libui-extension.so.0.1.0
41212000 41219000 r-xp /usr/lib/libtbm.so.1.0.0
41221000 41228000 r-xp /usr/lib/libembryo.so.1.7.99
41231000 41248000 r-xp /usr/lib/liblua-5.1.so
41251000 41252000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4125a000 41268000 r-xp /usr/lib/libGLESv2.so.2.0
41271000 41289000 r-xp /usr/lib/libpng12.so.0.50.0
41291000 41292000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4129c000 412a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
412aa000 412bd000 r-xp /usr/lib/libxcb.so.1.1.0
412c6000 412c9000 r-xp /usr/lib/libEGL.so.1.4
412d1000 412f4000 r-xp /usr/lib/libjpeg.so.8.0.2
4130c000 41350000 r-xp /usr/lib/libcurl.so.4.3.0
4135a000 4135b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41363000 41368000 r-xp /usr/lib/libffi.so.5.0.10
41370000 41388000 r-xp /usr/lib/liblzma.so.5.0.3
41390000 4140c000 r-xp /usr/lib/libgcrypt.so.20.0.3
41418000 41428000 r-xp /lib/libresolv-2.13.so
4142d000 4142f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41437000 4143b000 r-xp /usr/lib/libsmack.so.1.0.0
41444000 41461000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4146a000 4146c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41474000 41481000 r-xp /usr/lib/libail.so.0.1.0
4148b000 415c8000 r-xp /usr/lib/libicui18n.so.51.1
415d8000 416bc000 r-xp /usr/lib/libicuuc.so.51.1
42c5a000 42c76000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42c80000 42c83000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
42c8b000 42c8c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
42c95000 42c9d000 r-xp /usr/lib/libdrm.so.2.4.0
42ca5000 42ca7000 r-xp /usr/lib/libdri2.so.0.0.0
42cb0000 42cb2000 r-xp /usr/lib/libXau.so.6.0.0
42cba000 42cc3000 r-xp /usr/lib/libcares.so.2.1.0
42ccc000 42cfa000 r-xp /usr/lib/libidn.so.11.5.44
42d02000 42d49000 r-xp /usr/lib/libssl.so.1.0.0
42d55000 42efe000 r-xp /usr/lib/libcrypto.so.1.0.0
42f20000 42f2b000 r-xp /usr/lib/libgpg-error.so.0.15.0
42f33000 42f35000 r-xp /usr/lib/libiri.so
42f3d000 42f40000 r-xp /lib/libcap.so.2.21
42f48000 42f4f000 r-xp /lib/libcrypt-2.13.so
42f7f000 42f86000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42f90000 42f92000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42f9a000 42fa1000 r-xp /usr/lib/libminizip.so.1.0.0
42fa9000 42faf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42fb7000 42fbc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42fc5000 42fc8000 r-xp /lib/libattr.so.1.1.0
42fd0000 42ff1000 r-xp /usr/lib/libexif.so.12.3.3
43004000 43006000 r-xp /usr/lib/libttrace.so.1.1
4300e000 43013000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43122000 431ec000 r-xp /usr/lib/libCOREGL.so.4.0
431fe000 43222000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4322b000 432fa000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43310000 4331a000 r-xp /lib/libnss_files-2.13.so
43524000 43e76000 rw-p [stack:22097]
be806000 be827000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22095)
Call Stack Count: 8
 0: start_bt_server + 0x13 (0x40002c3c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2c3c
 1: app_create + 0x5e (0x40001b37) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b37
 2: (0x4004f9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x404b4457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x40050421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x40001a73) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1a73
 6: __libc_start_main + 0x114 (0x4033b82c) [/lib/libc.so.6] + 0x1782c
 7: (0x400016f4) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x16f4
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
17.715+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 13:30:17.720+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:30:18.375+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:30:18.790+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:18.800+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22654
10-26 13:30:18.845+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:30:19.490+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:30:19.490+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:30:19.490+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:30:19.495+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:30:19.495+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:30:19.495+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:30:19.635+0200 E/PKGMGR  (22762): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 13:30:19.855+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:30:20.015+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_2135023841], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_2135023841' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[Xkt/zQbqebNIOeyB1njQkXyLx34=], backend_flag=[0]
10-26 13:30:20.035+0200 E/PKGMGR  (22764): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 13:30:20.045+0200 E/PKGMGR  (22762): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[227620002]
10-26 13:30:20.075+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:30:20.085+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:30:20.085+0200 E/PKGMGR_SERVER(22766): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:30:20.090+0200 E/PKGMGR_SERVER(22765): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 13:30:20.240+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: main(601) > OBSERVER start
10-26 13:30:20.440+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:30:20.440+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:30:20.440+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:30:20.595+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 13:30:20.605+0200 E/rpm-installer(22765): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 13:30:20.605+0200 E/rpm-installer(22765): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 13:30:20.620+0200 E/rpm-installer(22765): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 13:30:20.620+0200 E/rpm-installer(22765): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 13:30:20.620+0200 E/rpm-installer(22765): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 13:30:20.750+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[227660002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 13:30:20.770+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 13:30:20.775+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[227660002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:30:20.805+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 13:30:20.830+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:30:21.200+0200 W/CERT_SVC(22765): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:30:21.265+0200 E/rpm-installer(22765): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 13:30:21.265+0200 E/rpm-installer(22765): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 13:30:21.265+0200 E/rpm-installer(22765): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 13:30:21.280+0200 E/rpm-installer(22765): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 13:30:21.410+0200 E/PKGMGR_PARSER(22765): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 13:30:21.430+0200 E/PKGMGR_PARSER(22765): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:30:21.480+0200 E/PKGMGR_PARSER(22765): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 13:30:21.585+0200 I/PRIVACY-MANAGER-CLIENT(22765): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:30:21.700+0200 I/efl-extension(22765): efl_extension.c: eext_mod_init(40) > Init
10-26 13:30:21.700+0200 I/efl-extension(22765): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 13:30:21.805+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 13:30:21.805+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 13:30:21.810+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 13:30:21.810+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 13:30:21.810+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 13:30:21.810+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 13:30:21.810+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 13:30:21.850+0200 E/PKGMGR_CERT(22765): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 13:30:21.865+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[227660002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 13:30:21.885+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:30:21.960+0200 E/rpm-installer(22765): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 13:30:21.970+0200 E/rpm-installer(22765): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 13:30:22.000+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 22641 pgid = 22641
10-26 13:30:22.125+0200 E/rpm-installer(22765): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 13:30:22.175+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:30:22.175+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22641
10-26 13:30:22.205+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.843
10-26 13:30:22.230+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[227660002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 13:30:22.270+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:30:22.345+0200 E/rpm-installer(22765): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 13:30:22.650+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:30:22.675+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 22642 pgid = 1167
10-26 13:30:22.735+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:30:22.750+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22642
10-26 13:30:22.765+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.844
10-26 13:30:22.805+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 13:30:22.805+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 13:30:23.670+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[227660002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 13:30:23.705+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 13:30:23.760+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 13:30:23.760+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:30:23.760+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:30:23.760+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:30:23.760+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 13:30:23.765+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 13:30:23.785+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 13:30:23.810+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 13:30:23.840+0200 E/PKGMGR_INFO(22766): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 13:30:23.860+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 13:30:23.870+0200 E/PKGMGR_OBSERVER(22766): pkg_observer.c: main(620) > OBSERVER end
10-26 13:30:23.930+0200 W/APPS    (  769): AppsItem.cpp: createItem(172) >  text length [Health Reacording][213,37]
10-26 13:30:24.115+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:30:24.115+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: sighandler(409) > child NORMAL exit [22766]
10-26 13:30:24.650+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:30:25.710+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:30:25.710+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:30:25.710+0200 E/rpm-installer(22765): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:30:25.780+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: sighandler(409) > child NORMAL exit [22765]
10-26 13:30:25.785+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/22765/oom_score_adj failed
10-26 13:30:25.785+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 22765
10-26 13:30:26.650+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:30:26.650+0200 E/PKGMGR_SERVER(22764): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:30:27.515+0200 W/AUL     (22832): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:30:27.530+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:30:27.545+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 13:30:27.555+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 13:30:27.555+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:30:27.555+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 22832
10-26 13:30:27.570+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:30:27.570+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:30:27.570+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:30:27.570+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:30:27.570+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:30:27.575+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 22833
10-26 13:30:27.625+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 22833
10-26 13:30:27.625+0200 W/AUL     (22832): launch.c: app_request_to_launchpad(282) > request cmd(0) result(22833)
10-26 13:30:27.745+0200 W/AUL     (22831): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.system-syspopup)
10-26 13:30:27.755+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:30:27.775+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/popup-launcher, ret : 0
10-26 13:30:27.790+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/dbus-daemon, ret : 0
10-26 13:30:27.790+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:30:27.790+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 22831
10-26 13:30:27.805+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:30:27.805+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:30:27.805+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:30:27.805+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:30:27.805+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:30:27.810+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 22834
10-26 13:30:27.830+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:30:27.830+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:30:27.845+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:30:27.850+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:30:27.865+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 22834
10-26 13:30:27.865+0200 W/AUL     (22831): launch.c: app_request_to_launchpad(282) > request cmd(0) result(22834)
10-26 13:30:27.865+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:30:27.875+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : com.samsung.system-syspopup
10-26 13:30:27.910+0200 I/efl-extension(22833): efl_extension.c: eext_mod_init(40) > Init
10-26 13:30:27.945+0200 I/CAPI_APPFW_APPLICATION(22833): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:30:27.970+0200 E/EFL     (22833): elementary<22833> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:30:27.980+0200 E/EFL     (22833): elementary<22833> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:30:28.010+0200 I/efl-extension(22834): efl_extension.c: eext_mod_init(40) > Init
10-26 13:30:28.020+0200 E/EFL     (22833): elementary<22833> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:30:28.025+0200 I/UXT     (22833): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:30:28.025+0200 E/EFL     (22833): elementary<22833> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:30:28.055+0200 E/EFL     (22834): elementary<22834> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:30:28.055+0200 E/EFL     (22834): elementary<22834> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:30:28.085+0200 E/EFL     (22833): elementary<22833> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:30:28.085+0200 E/EFL     (22833): elementary<22833> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:30:28.085+0200 E/EFL     (22833): elementary<22833> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:30:28.085+0200 E/EFL     (22833): elementary<22833> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:30:28.085+0200 E/EFL     (22833): elementary<22833> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:30:28.105+0200 E/EFL     (22834): elementary<22834> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:30:28.110+0200 I/UXT     (22834): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:30:28.115+0200 E/EFL     (22834): elementary<22834> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:30:28.120+0200 E/EFL     (22833): elementary<22833> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:30:28.120+0200 E/EFL     (22833): elementary<22833> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:30:28.125+0200 E/EFL     (22833): elementary<22833> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:30:28.170+0200 E/EFL     (22833): elementary<22833> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:30:28.180+0200 E/EFL     (22833): elementary<22833> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:30:28.180+0200 E/EFL     (22833): elementary<22833> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:30:28.180+0200 E/EFL     (22833): elementary<22833> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:30:28.180+0200 E/EFL     (22833): elementary<22833> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:30:28.180+0200 E/EFL     (22833): elementary<22833> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:30:28.180+0200 E/EFL     (22833): elementary<22833> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:30:28.195+0200 E/EFL     (22834): elementary<22834> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:30:28.195+0200 E/EFL     (22834): elementary<22834> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:30:28.195+0200 E/EFL     (22834): elementary<22834> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:30:28.195+0200 E/EFL     (22834): elementary<22834> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:30:28.195+0200 E/EFL     (22834): elementary<22834> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:30:28.225+0200 E/EFL     (22834): elementary<22834> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:30:28.225+0200 E/EFL     (22834): elementary<22834> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:30:28.230+0200 E/EFL     (22834): elementary<22834> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:30:28.310+0200 E/EFL     (22834): elementary<22834> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:30:28.320+0200 E/EFL     (22834): elementary<22834> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:30:28.320+0200 E/EFL     (22834): elementary<22834> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:30:28.325+0200 E/EFL     (22834): elementary<22834> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:30:28.325+0200 E/EFL     (22834): elementary<22834> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:30:28.325+0200 E/EFL     (22834): elementary<22834> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:30:28.325+0200 E/EFL     (22834): elementary<22834> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:30:28.385+0200 I/CAPI_APPFW_APPLICATION(22833): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:30:28.450+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:28.455+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22833
10-26 13:30:28.460+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:28.465+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22833
10-26 13:30:28.470+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:30:28.475+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:30:28.625+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:30:28.625+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:30:28.665+0200 I/Bluetooth(22833): [bt_initialize] success.
10-26 13:30:28.695+0200 I/Bluetooth(22833): [bt_adapter_get_state] success.
10-26 13:30:28.810+0200 I/APP_CORE(22834): appcore-efl.c: __do_app(429) > [APP 22834] Event: RESET State: CREATED
10-26 13:30:28.865+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:30:28.865+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:30:28.910+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:28.920+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:30:28.920+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
10-26 13:30:28.920+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:30:29.075+0200 E/AUL     (  564): app_sock.c: __app_recv_raw(518) > recv error: 4
10-26 13:30:29.100+0200 I/APP_CORE(22834): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 13:30:29.120+0200 I/APP_CORE(22834): appcore-efl.c: __do_app(474) > [APP 22834] Initial Launching, call the resume_cb
10-26 13:30:29.165+0200 W/APP_CORE(22834): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00003
10-26 13:30:29.195+0200 I/MALI    (22834): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(742) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [216x432]
10-26 13:30:29.230+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:30:29.230+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: PAUSE State: RUNNING
10-26 13:30:29.230+0200 I/CAPI_APPFW_APPLICATION(  735): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:30:29.250+0200 I/APP_CORE(22834): appcore-efl.c: __do_app(429) > [APP 22834] Event: RESUME State: RUNNING
10-26 13:30:29.260+0200 I/MALI    (22834): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x432aacd8] swap changed from async to sync
10-26 13:30:29.320+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:30:29.320+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:30:29.320+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:30:29.320+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:30:29.325+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:29.335+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22834
10-26 13:30:29.345+0200 W/AUL     (22841): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:30:29.350+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:30:29.350+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:30:29.350+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 22833
10-26 13:30:29.350+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:30:29.355+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:30:29.355+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 13:30:29.355+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22833
10-26 13:30:29.360+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:30:29.445+0200 I/efl-extension(22777): efl_extension.c: eext_mod_init(40) > Init
10-26 13:30:29.560+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:29.570+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22834
10-26 13:30:29.570+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:30:29.580+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22834
10-26 13:30:29.585+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:30:29.590+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:30:29.955+0200 E/EFL     (22777): elementary<22777> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:30:29.965+0200 E/EFL     (22777): elementary<22777> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:30:30.295+0200 E/EFL     (22777): elementary<22777> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:30:30.325+0200 I/UXT     (22777): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:30:30.325+0200 E/EFL     (22777): elementary<22777> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:30:30.415+0200 E/EFL     (22777): elementary<22777> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:30:30.415+0200 E/EFL     (22777): elementary<22777> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:30:30.425+0200 E/EFL     (22777): elementary<22777> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:30:30.430+0200 E/EFL     (22777): elementary<22777> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:30:30.435+0200 E/EFL     (22777): elementary<22777> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:30:30.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:30:30.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:30:30.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:30:30.495+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:30:30.495+0200 E/EFL     (22777): elementary<22777> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:30:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:30:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:30:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:30:30.505+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:30:30.505+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:30:30.505+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:30:30.505+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:30:30.505+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:30:30.510+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:30:30.520+0200 E/EFL     (22777): elementary<22777> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:30:30.535+0200 E/EFL     (22777): elementary<22777> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:30:30.570+0200 E/EFL     (22777): elementary<22777> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:30:30.585+0200 E/EFL     (22777): elementary<22777> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:30:30.585+0200 E/EFL     (22777): elementary<22777> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:30:30.585+0200 E/EFL     (22777): elementary<22777> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:30:30.585+0200 E/EFL     (22777): elementary<22777> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:30:30.585+0200 E/EFL     (22777): elementary<22777> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:30:30.590+0200 E/EFL     (22777): elementary<22777> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:30:30.590+0200 I/AUL_PAD (22777): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:30:30.950+0200 E/EFL     (22776): elementary<22776> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:30:30.965+0200 E/EFL     (22776): elementary<22776> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:30:31.240+0200 E/EFL     (22776): elementary<22776> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:30:31.240+0200 E/EFL     (22776): elementary<22776> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:30:31.395+0200 E/EFL     (22776): elementary<22776> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:30:31.420+0200 E/EFL     (22776): elementary<22776> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:30:31.420+0200 E/EFL     (22776): elementary<22776> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:30:31.460+0200 E/EFL     (22776): elementary<22776> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:30:31.465+0200 E/EFL     (22776): elementary<22776> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:30:31.595+0200 E/EFL     (22776): elementary<22776> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:30:31.625+0200 E/EFL     (22776): elementary<22776> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:30:31.670+0200 E/EFL     (22776): elementary<22776> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:30:32.045+0200 E/EFL     (22776): elementary<22776> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:30:32.065+0200 E/EFL     (22776): elementary<22776> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:30:32.065+0200 E/EFL     (22776): elementary<22776> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:30:32.075+0200 E/EFL     (22776): elementary<22776> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:30:32.080+0200 E/EFL     (22776): elementary<22776> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:30:32.085+0200 E/EFL     (22776): elementary<22776> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:30:32.085+0200 E/EFL     (22776): elementary<22776> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:30:32.085+0200 I/AUL_PAD (22776): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:30:32.670+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 13:30:32.670+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 13:30:33.015+0200 E/EFL     (22847): elementary<22847> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:30:33.055+0200 E/EFL     (22847): elementary<22847> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:30:33.300+0200 E/EFL     (22847): elementary<22847> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:30:33.320+0200 E/EFL     (22847): elementary<22847> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:30:33.440+0200 E/EFL     (22847): elementary<22847> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:30:33.445+0200 E/EFL     (22847): elementary<22847> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:30:33.455+0200 E/EFL     (22847): elementary<22847> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:30:33.460+0200 E/EFL     (22847): elementary<22847> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:30:33.465+0200 E/EFL     (22847): elementary<22847> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:30:33.560+0200 E/EFL     (22847): elementary<22847> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:30:33.580+0200 E/EFL     (22847): elementary<22847> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:30:33.580+0200 E/EFL     (22847): elementary<22847> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:30:33.870+0200 E/EFL     (22847): elementary<22847> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:30:33.905+0200 E/EFL     (22847): elementary<22847> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:30:33.910+0200 E/EFL     (22847): elementary<22847> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:30:33.910+0200 E/EFL     (22847): elementary<22847> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:30:33.910+0200 E/EFL     (22847): elementary<22847> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:30:33.915+0200 E/EFL     (22847): elementary<22847> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:30:33.915+0200 E/EFL     (22847): elementary<22847> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:30:33.925+0200 I/AUL_PAD (22847): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:30:34.230+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: MEM_FLUSH State: PAUSED
10-26 13:30:34.445+0200 E/AUL_PAD ( 1167): launchpad.c: main(879) > Refused candidate process connection
10-26 13:30:34.470+0200 E/AUL     (22847): process_pool.c: __connect_to_launchpad(148) > send error
10-26 13:30:34.655+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 22847 pgid = 22847
10-26 13:30:34.695+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:30:34.705+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22847
10-26 13:30:34.720+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.855
10-26 13:30:58.600+0200 W/W_INDICATOR(  735): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
10-26 13:30:58.655+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:30:58.655+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
10-26 13:30:58.655+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
10-26 13:30:58.655+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-26 13:30:58.655+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
10-26 13:30:58.665+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 13:30:58.670+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 13:30:58.670+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 13:30:58.670+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:30:58.670+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 13:30:58.670+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 13:30:58.670+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:30:58.675+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 13:30:58.675+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 13:30:58.675+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 13:30:58.675+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 13:30:58.675+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 13:30:58.705+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:30:58.730+0200 I/APP_CORE(22834): appcore-efl.c: __do_app(429) > [APP 22834] Event: PAUSE State: RUNNING
10-26 13:30:58.735+0200 I/APP_CORE(22834): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 13:30:58.745+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:30:58.755+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:30:58.755+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 13:30:58.755+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:30:58.755+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 13:30:58.805+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:30:58.835+0200 I/MALI    (22654): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42e15840] swap changed from async to sync
10-26 13:30:58.870+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
10-26 13:30:58.905+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 13:30:58.905+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
10-26 13:30:58.905+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 13:30:58.905+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 13:30:58.905+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 13:31:19), repeat(1), interval(20), type(-1073741822)
10-26 13:30:58.920+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:30:58.935+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
10-26 13:30:58.935+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
10-26 13:30:58.965+0200 E/ALARM_MANAGER(22654): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(62), start(26-10-2017, 13:32:01), repeat(1), interval(120), type(-1073741822)
10-26 13:30:58.970+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 692728132, next duetime: 1509017479
10-26 13:30:58.970+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(692728132)
10-26 13:30:58.970+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509017479)
10-26 13:30:58.975+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:30:58.975+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:31:19 (UTC).
10-26 13:30:58.980+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:30:58.985+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [22654].
10-26 13:30:59.015+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 386491651, next duetime: 1509017521
10-26 13:30:59.015+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(386491651)
10-26 13:30:59.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509017479), due_time(1509017521)
10-26 13:30:59.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:30:59.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:31:19 (UTC).
10-26 13:30:59.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:30:59.435+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-26 13:30:59.435+0200 W/W_CLOCK_VIEWER(22654): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-26 13:31:00.210+0200 W/W_INDICATOR(  735): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:31  /5 / HH:mm
10-26 13:31:00.210+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:31
10-26 13:31:00.210+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-26 13:31:00.210+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-26 13:31:00.210+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 31
10-26 13:31:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-26 13:31:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  31
10-26 13:31:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 31 / 13:31
10-26 13:31:00.215+0200 W/W_INDICATOR(  735): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-26 13:31:03.735+0200 I/APP_CORE(22834): appcore-efl.c: __do_app(429) > [APP 22834] Event: MEM_FLUSH State: PAUSED
10-26 13:31:08.145+0200 W/CRASH_MANAGER(21900): worker.c: worker_job(1205) > 1122095646174150901724
