S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 16013
Date: 2017-10-26 12:34:07+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x36302e31

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x41657f40, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbef263f8
r8   = 0xbef264a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbef263a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     32136 KB
Buffers:     39456 KB
Cached:     166732 KB
VmPeak:      96580 KB
VmSize:      94580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19356 KB
VmRSS:       19356 KB
VmData:      40292 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23608 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 16013 TID = 16013
16013 16076 16078 16088 16089 

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
41693000 41697000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
416a0000 416a8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
416a9000 416ca000 r-xp /usr/lib/libefl-extension.so.0.1.0
416d3000 4170d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41716000 4172f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41737000 4173c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41744000 4176e000 r-xp /usr/lib/libsensor.so.1.9.6
41777000 41789000 r-xp /usr/lib/libefl-assist.so.0.1.0
41791000 41849000 r-xp /usr/lib/libcairo.so.2.11200.14
41854000 41857000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4185f000 41865000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4186e000 41876000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4187e000 41888000 r-xp /usr/lib/libsensord-shared.so
41891000 418a3000 r-xp /usr/lib/libtts.so
418ab000 418cd000 r-xp /usr/lib/libui-extension.so.0.1.0
418d6000 418dd000 r-xp /usr/lib/libtbm.so.1.0.0
418e5000 418f3000 r-xp /usr/lib/libGLESv2.so.2.0
418fc000 418fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41906000 4190c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41914000 41917000 r-xp /usr/lib/libEGL.so.1.4
4191f000 4192c000 r-xp /usr/lib/libail.so.0.1.0
41935000 41a72000 r-xp /usr/lib/libicui18n.so.51.1
41a82000 41b66000 r-xp /usr/lib/libicuuc.so.51.1
41b7b000 41b97000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41ba0000 41ba3000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41bab000 41bac000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41bb5000 41bbd000 r-xp /usr/lib/libdrm.so.2.4.0
41bc5000 41bc7000 r-xp /usr/lib/libdri2.so.0.0.0
41bcf000 41bd6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41bdf000 41be1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41be9000 41bf0000 r-xp /usr/lib/libminizip.so.1.0.0
41bf8000 41bfe000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c06000 41c0b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c13000 41c34000 r-xp /usr/lib/libexif.so.12.3.3
41c47000 41c49000 r-xp /usr/lib/libttrace.so.1.1
41c51000 41c56000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c5e000 41d28000 r-xp /usr/lib/libCOREGL.so.4.0
41f3a000 41f45000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41f4e000 41f53000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41f6d000 41f6e000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
41f76000 41f78000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41f80000 41f83000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41f8b000 41f8c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
41f94000 41fb2000 rw-p [heap]
41fb2000 420c8000 rw-p [heap]
43652000 43e51000 rw-p [stack:16076]
44001000 44900000 rw-p [stack:16078]
44901000 45100000 rw-p [stack:16088]
45101000 45900000 rw-p [stack:16089]
bef06000 bef27000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16013)
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
): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=5424869
10-26 12:33:50.660+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 12:33:50.660+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 12:33:50.665+0200 W/STARTER (  732): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-26 12:33:50.665+0200 W/STARTER (  732): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-26 12:33:50.670+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=5425011
10-26 12:33:50.680+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-26 12:33:50.680+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-26 12:33:50.680+0200 E/STARTER (  732): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-26 12:33:50.685+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 12:33:50.685+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 12:33:50.685+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 12:33:50.695+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 12:33:50.710+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(769), cmd(0)
10-26 12:33:50.710+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 12:33:50.730+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: RUNNING
10-26 12:33:50.730+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 12:33:50.730+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : powerkey
10-26 12:33:50.730+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-26 12:33:50.730+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-26 12:33:50.730+0200 W/W_HOME  (  769): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-26 12:33:50.730+0200 E/W_HOME  (  769): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-26 12:33:50.735+0200 W/W_HOME  (  769): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-26 12:33:50.735+0200 W/W_HOME  (  769): move.c: move_move_to_apps(220) > move to apps
10-26 12:33:50.745+0200 E/PKGMGR_OBSERVER(16002): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[160020002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 12:33:50.755+0200 W/W_HOME  (  769): move.c: _create_fake_apps(823) > fake image position : 432
10-26 12:33:50.765+0200 W/W_HOME  (  769): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-26 12:33:50.765+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-26 12:33:50.765+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:33:50.765+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:33:50.780+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 12:33:50.785+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 12:33:50.785+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-26 12:33:50.790+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 12:33:50.790+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:33:50.790+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:33:50.790+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:33:50.790+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-26 12:33:50.790+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-26 12:33:50.795+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-26 12:33:50.795+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-26 12:33:50.800+0200 E/PKGMGR_OBSERVER(16002): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[160020002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 12:33:50.835+0200 E/AUL     (  732): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 12:33:50.835+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 12:33:50.840+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 12:33:50.870+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 12:33:50.875+0200 E/APPS    (  769): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 12:33:50.875+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 12:33:51.040+0200 W/CERT_SVC(16001): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 12:33:51.070+0200 E/rpm-installer(16001): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 12:33:51.070+0200 E/rpm-installer(16001): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 12:33:51.070+0200 E/rpm-installer(16001): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 12:33:51.070+0200 E/rpm-installer(16001): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 12:33:51.105+0200 W/W_HOME  (  769): move.c: _transit_del_cb(115) > transit end
10-26 12:33:51.105+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-26 12:33:51.105+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 12:33:51.120+0200 W/W_HOME  (  769): move.c: _scroller_up_done(515) > up signal done
10-26 12:33:51.130+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-26 12:33:51.130+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-26 12:33:51.130+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:51.130+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:51.130+0200 W/W_HOME  (  769): main.c: home_pause(766) > clock/widget paused
10-26 12:33:51.130+0200 W/W_HOME  (  769): clock_indicator.c: clock_indicator_pause(554) > 
10-26 12:33:51.135+0200 E/PKGMGR_PARSER(16001): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 12:33:51.135+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:51.135+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-26 12:33:51.135+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-26 12:33:51.135+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-26 12:33:51.135+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-26 12:33:51.135+0200 E/APPS    (  769): apps_main.c: apps_main_resume(636) >  resumed already
10-26 12:33:51.140+0200 E/PKGMGR_PARSER(16001): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 12:33:51.150+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
10-26 12:33:51.170+0200 E/PKGMGR_PARSER(16001): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 12:33:51.240+0200 I/PRIVACY-MANAGER-CLIENT(16001): SocketClient.cpp: SocketClient(37) > Client created
10-26 12:33:51.330+0200 I/efl-extension(16001): efl_extension.c: eext_mod_init(40) > Init
10-26 12:33:51.330+0200 I/efl-extension(16001): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 12:33:51.410+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 12:33:51.425+0200 E/PKGMGR_CERT(16001): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 12:33:51.425+0200 E/PKGMGR_OBSERVER(16002): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[160020002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 12:33:51.450+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 12:33:51.475+0200 E/rpm-installer(16001): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 12:33:51.495+0200 E/rpm-installer(16001): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 12:33:51.505+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 15593 pgid = 15593
10-26 12:33:51.525+0200 E/rpm-installer(16001): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 12:33:51.535+0200 E/PKGMGR_OBSERVER(16002): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[160020002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 12:33:51.580+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15593
10-26 12:33:51.585+0200 E/rpm-installer(16001): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 12:33:51.590+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.395
10-26 12:33:51.625+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 12:33:51.665+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 12:33:51.665+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 15295 pgid = -1
10-26 12:33:51.665+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 12:33:51.670+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15295
10-26 12:33:51.680+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.396
10-26 12:33:51.700+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:33:51.700+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 12:33:52.325+0200 E/EFL     (16013): elementary<16013> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 12:33:52.340+0200 E/EFL     (16013): elementary<16013> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 12:33:52.395+0200 E/EFL     (16013): elementary<16013> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 12:33:52.400+0200 E/EFL     (16013): elementary<16013> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 12:33:52.525+0200 E/EFL     (16013): elementary<16013> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 12:33:52.540+0200 E/PKGMGR_OBSERVER(16002): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[160020002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 12:33:52.560+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 12:33:52.560+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 12:33:52.610+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 12:33:52.645+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 12:33:52.645+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 12:33:52.645+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 12:33:52.645+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 12:33:52.645+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 12:33:52.645+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 12:33:52.655+0200 E/PKGMGR_SERVER(15999): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 12:33:52.660+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 12:33:52.705+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 12:33:52.750+0200 E/PKGMGR_INFO(16002): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 12:33:52.760+0200 E/PKGMGR_OBSERVER(16002): pkg_observer.c: main(620) > OBSERVER end
10-26 12:33:52.780+0200 E/PKGMGR_SERVER(15999): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 12:33:52.780+0200 E/PKGMGR_SERVER(15999): pkgmgr-server.c: sighandler(409) > child NORMAL exit [16002]
10-26 12:33:52.785+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 12:33:52.800+0200 E/EFL     (16013): elementary<16013> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 12:33:52.800+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 12:33:52.800+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 12:33:52.840+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 12:33:52.840+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 12:33:52.920+0200 E/EFL     (16013): elementary<16013> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 12:33:52.925+0200 E/EFL     (16013): elementary<16013> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 12:33:52.930+0200 E/EFL     (16013): elementary<16013> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 12:33:53.105+0200 E/EFL     (16013): elementary<16013> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 12:33:53.110+0200 E/EFL     (16013): elementary<16013> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 12:33:53.110+0200 E/EFL     (16013): elementary<16013> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 12:33:53.150+0200 E/EFL     (16013): elementary<16013> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 12:33:53.165+0200 E/EFL     (16013): elementary<16013> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 12:33:53.165+0200 E/EFL     (16013): elementary<16013> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 12:33:53.165+0200 E/EFL     (16013): elementary<16013> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 12:33:53.165+0200 E/EFL     (16013): elementary<16013> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 12:33:53.165+0200 E/EFL     (16013): elementary<16013> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 12:33:53.165+0200 E/EFL     (16013): elementary<16013> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 12:33:53.165+0200 I/AUL_PAD (16013): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 12:33:53.585+0200 I/efl-extension(16014): efl_extension.c: eext_mod_init(40) > Init
10-26 12:33:53.675+0200 E/rpm-installer(16001): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 12:33:53.675+0200 E/rpm-installer(16001): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 12:33:53.675+0200 E/rpm-installer(16001): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 12:33:53.705+0200 E/PKGMGR_SERVER(15999): pkgmgr-server.c: sighandler(409) > child NORMAL exit [16001]
10-26 12:33:53.755+0200 E/EFL     (16014): elementary<16014> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 12:33:53.755+0200 E/EFL     (16014): elementary<16014> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 12:33:53.770+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/16001/oom_score_adj failed
10-26 12:33:53.770+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 16001
10-26 12:33:53.790+0200 E/EFL     (16014): elementary<16014> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 12:33:53.800+0200 I/UXT     (16014): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 12:33:53.800+0200 E/EFL     (16014): elementary<16014> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 12:33:53.850+0200 E/EFL     (16014): elementary<16014> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 12:33:53.850+0200 E/EFL     (16014): elementary<16014> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 12:33:53.855+0200 E/EFL     (16014): elementary<16014> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 12:33:53.860+0200 E/EFL     (16014): elementary<16014> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 12:33:53.860+0200 E/EFL     (16014): elementary<16014> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 12:33:53.880+0200 E/EFL     (16014): elementary<16014> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 12:33:53.880+0200 E/EFL     (16014): elementary<16014> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 12:33:53.885+0200 E/EFL     (16014): elementary<16014> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 12:33:53.925+0200 E/EFL     (16014): elementary<16014> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 12:33:53.930+0200 E/EFL     (16014): elementary<16014> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 12:33:53.930+0200 E/EFL     (16014): elementary<16014> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 12:33:53.935+0200 E/EFL     (16014): elementary<16014> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 12:33:53.935+0200 E/EFL     (16014): elementary<16014> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 12:33:53.935+0200 E/EFL     (16014): elementary<16014> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 12:33:53.935+0200 E/EFL     (16014): elementary<16014> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 12:33:53.935+0200 I/AUL_PAD (16014): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 12:33:54.650+0200 E/PKGMGR_SERVER(15999): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 12:33:54.650+0200 E/PKGMGR_SERVER(15999): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 12:33:55.790+0200 W/AUL     (16075): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 12:33:55.800+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 12:33:55.815+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 12:33:55.830+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 12:33:55.830+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 12:33:55.830+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 16075
10-26 12:33:55.845+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 12:33:55.845+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 12:33:55.845+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 12:33:55.850+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 12:33:55.850+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 12:33:55.915+0200 I/efl-extension(16013): efl_extension.c: eext_mod_init(40) > Init
10-26 12:33:55.920+0200 I/UXT     (16013): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 12:33:55.925+0200 I/CAPI_APPFW_APPLICATION(16013): app_main.c: ui_app_main(704) > app_efl_main
10-26 12:33:55.935+0200 I/CAPI_APPFW_APPLICATION(16013): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 12:33:55.945+0200 W/AUL     (16075): launch.c: app_request_to_launchpad(282) > request cmd(0) result(16013)
10-26 12:33:55.990+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 12:33:56.115+0200 I/Bluetooth(16013): [bt_initialize] success.
10-26 12:33:56.185+0200 I/Bluetooth(16013): [bt_socket_create_rfcomm] success.
10-26 12:33:56.245+0200 I/BluetoothServer(16013): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
10-26 12:33:56.245+0200 I/Bluetooth(16013): [bt_adapter_le_create_advertiser] success.
10-26 12:33:56.265+0200 I/Bluetooth(16013): [bt_adapter_le_set_advertising_mode] success.
10-26 12:33:56.275+0200 I/Bluetooth(16013): [bt_adapter_le_set_advertising_connectable] success.
10-26 12:33:56.275+0200 I/Bluetooth(16013): [bt_adapter_le_set_advertising_device_name] success.
10-26 12:33:56.275+0200 I/Bluetooth(16013): [bt_adapter_le_set_advertising_device_name] success.
10-26 12:33:56.440+0200 I/Bluetooth(16013): [bt_adapter_le_start_advertising_new] success.
10-26 12:33:56.440+0200 I/Bluetooth(16013): Heart Rate Measurement advertiser started.
10-26 12:33:56.505+0200 I/Bluetooth(16013): [bt_adapter_le_stop_advertising] success.
10-26 12:33:56.505+0200 I/Bluetooth(16013): [bt_adapter_le_clear_advertising_data] success.
10-26 12:33:56.505+0200 I/Bluetooth(16013): [bt_adapter_le_set_advertising_device_name] success.
10-26 12:33:56.505+0200 I/Bluetooth(16013): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 12:33:56.640+0200 I/Bluetooth(16013): [bt_adapter_le_start_advertising_new] success.
10-26 12:33:56.740+0200 E/EFL     (16013): ecore_evas<16013> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 12:33:56.950+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:33:56.950+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 12:33:57.030+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.402
10-26 12:33:57.140+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 12:33:57.140+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.140+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.145+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.190+0200 I/APP_CORE(16013): appcore-efl.c: __do_app(429) > [APP 16013] Event: RESET State: CREATED
10-26 12:33:57.190+0200 I/CAPI_APPFW_APPLICATION(16013): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 12:33:57.215+0200 I/APP_CORE(16013): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 12:33:57.215+0200 I/APP_CORE(16013): appcore-efl.c: __do_app(474) > [APP 16013] Initial Launching, call the resume_cb
10-26 12:33:57.215+0200 I/CAPI_APPFW_APPLICATION(16013): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 12:33:57.230+0200 W/APP_CORE(16013): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
10-26 12:33:57.240+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:33:57.245+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16013
10-26 12:33:57.245+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:33:57.255+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16013
10-26 12:33:57.255+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 12:33:57.265+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16013
10-26 12:33:57.265+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:33:57.270+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:33:57.270+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _state_control(344) > appcore paused manually
10-26 12:33:57.320+0200 W/W_HOME  (  769): main.c: home_appcore_pause(723) > Home Appcore Paused
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.320+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.325+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 12:33:57.340+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 12:33:57.340+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 12:33:57.360+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 12:33:57.365+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 12:33:57.365+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 12:33:57.365+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 12:33:57.365+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 12:33:57.370+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 12:33:57.370+0200 E/W_HOME  (  769): main.c: _pause_cb(674) > paused already
10-26 12:33:57.375+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 12:33:57.390+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 12:33:57.390+0200 E/TBM     (  406): tbm_bufmgr.c: _tgl_destroy(151) > [libtbm:406] error(Device or resource busy) _tgl_destroy:151 key:33
10-26 12:33:57.405+0200 I/APP_CORE(16013): appcore-efl.c: __do_app(429) > [APP 16013] Event: RESUME State: RUNNING
10-26 12:33:57.495+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 12:33:57.575+0200 E/EFL     (16013): elementary<16013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:33:57.575+0200 E/EFL     (16013): elementary<16013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:33:57.620+0200 E/EFL     (16013): elementary<16013> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 12:33:57.630+0200 E/EFL     (16013): elementary<16013> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 12:33:57.655+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 12:33:57.760+0200 E/EFL     (16080): elementary<16080> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 12:33:57.765+0200 E/EFL     (16080): elementary<16080> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 12:33:57.805+0200 E/EFL     (16080): elementary<16080> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 12:33:57.810+0200 E/EFL     (16080): elementary<16080> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 12:33:57.835+0200 E/EFL     (16080): elementary<16080> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 12:33:57.840+0200 E/EFL     (16080): elementary<16080> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 12:33:57.840+0200 E/EFL     (16080): elementary<16080> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 12:33:57.840+0200 E/EFL     (16080): elementary<16080> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 12:33:57.840+0200 E/EFL     (16080): elementary<16080> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 12:33:57.870+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 12:33:57.875+0200 E/EFL     (16080): elementary<16080> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 12:33:57.890+0200 E/EFL     (16080): elementary<16080> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 12:33:57.890+0200 E/EFL     (16080): elementary<16080> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 12:33:57.940+0200 E/EFL     (16080): elementary<16080> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 12:33:57.950+0200 E/EFL     (16080): elementary<16080> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 12:33:57.950+0200 E/EFL     (16080): elementary<16080> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 12:33:57.950+0200 E/EFL     (16080): elementary<16080> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 12:33:57.955+0200 E/EFL     (16080): elementary<16080> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 12:33:57.955+0200 E/EFL     (16080): elementary<16080> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 12:33:57.955+0200 E/EFL     (16080): elementary<16080> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 12:33:57.955+0200 I/AUL_PAD (16080): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 12:33:57.985+0200 E/EFL     (16013): elementary<16013> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 12:33:58.520+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 12:33:58.590+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 12:33:58.645+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 12:33:58.650+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 12:33:58.650+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 12:33:58.665+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 12:33:58.690+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 12:33:58.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 12:33:58.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 12:33:58.750+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 12:33:58.755+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 12:33:58.960+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 12:33:58.980+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 12:34:00.695+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 12:34:00.695+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:00.695+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 12:34:00.695+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:34:00.700+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:00.700+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 12:34:00.705+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 12:34:00.705+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 12:34:00.705+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 12:34:02.370+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 12:34:07.360+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 12:34:07.405+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-26 12:34:07.405+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-26 12:34:07.405+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 12:34:07.440+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 12:34:07.440+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 12:34:07.440+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 12:34:07.440+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 12:34:07.440+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 12:34:07.440+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 12:34:07.440+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 12:34:07.445+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-26 12:34:07.445+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 12:34:07.445+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 12:34:07.445+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 12:34:07.445+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 12:34:07.685+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:34:07.685+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 12:34:07.710+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-26 12:34:07.710+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 12:34:07.710+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 12:34:07.715+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 12:34:07.715+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 12:34:28), repeat(1), interval(20), type(-1073741822)
10-26 12:34:07.715+0200 I/APP_CORE(16013): appcore-efl.c: __do_app(429) > [APP 16013] Event: PAUSE State: RUNNING
10-26 12:34:07.715+0200 I/CAPI_APPFW_APPLICATION(16013): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 12:34:07.725+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 12:34:07.765+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1904746357, next duetime: 1509014068
10-26 12:34:07.765+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1904746357)
10-26 12:34:07.765+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509014068)
10-26 12:34:07.770+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:34:07.770+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 12:34:07.770+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 10:34:28 (UTC).
10-26 12:34:07.770+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 12:34:07.775+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 12:34:07.795+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 12:34:07.795+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 12:34:07.840+0200 I/APP_CORE(16013): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 12:34:07.840+0200 I/CAPI_APPFW_APPLICATION(16013): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 12:34:08.135+0200 W/CRASH_MANAGER(16112): worker.c: worker_job(1205) > 1116013646174150901404
