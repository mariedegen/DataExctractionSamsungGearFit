S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 4813
Date: 2017-10-14 22:57:36+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4813, uid 5000)

Register Information
r0   = 0x0000000a, r1   = 0xfaac95d4
r2   = 0x4146c06b, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x417fb7fc
r6   = 0x0000000a, r7   = 0xbeab1f10
r8   = 0x00000041, r9   = 0x40452824
r10  = 0xfaac95d4, fp   = 0x00000000
ip   = 0x0000016c, sp   = 0xbeab1e30
lr   = 0x4146c06b, pc   = 0x404e62d0
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     91680 KB
Buffers:     28196 KB
Cached:     155532 KB
VmPeak:      97216 KB
VmSize:      95740 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18612 KB
VmRSS:       18612 KB
VmData:      39508 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4813 TID = 4813
4813 4885 4886 4887 4888 

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
41696000 416a8000 r-xp /usr/lib/libefl-assist.so.0.1.0
416b3000 417ca000 rw-p [heap]
417ca000 417f4000 r-xp /usr/lib/libsensor.so.1.9.6
417fd000 418b5000 r-xp /usr/lib/libcairo.so.2.11200.14
418c0000 418ca000 r-xp /usr/lib/libsensord-shared.so
418d3000 418e5000 r-xp /usr/lib/libtts.so
418ed000 4190f000 r-xp /usr/lib/libui-extension.so.0.1.0
41918000 4191f000 r-xp /usr/lib/libtbm.so.1.0.0
41927000 41935000 r-xp /usr/lib/libGLESv2.so.2.0
4193e000 4193f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41948000 4194e000 r-xp /usr/lib/libxcb-render.so.0.0.0
41956000 41959000 r-xp /usr/lib/libEGL.so.1.4
41961000 41966000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4196e000 41971000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41979000 4197a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41983000 41ac0000 r-xp /usr/lib/libicui18n.so.51.1
41ad0000 41bb4000 r-xp /usr/lib/libicuuc.so.51.1
41bc9000 41bd1000 r-xp /usr/lib/libdrm.so.2.4.0
41bd9000 41bdb000 r-xp /usr/lib/libdri2.so.0.0.0
41be3000 41be9000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bf1000 41bf6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41bfe000 41c17000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431a8000 431c9000 r-xp /usr/lib/libexif.so.12.3.3
431dc000 431de000 r-xp /usr/lib/libttrace.so.1.1
431e6000 431eb000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431f3000 431f9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43202000 4320a000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43212000 4322e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43237000 4323e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43247000 43249000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43251000 43258000 r-xp /usr/lib/libminizip.so.1.0.0
43260000 4326d000 r-xp /usr/lib/libail.so.0.1.0
43276000 43340000 r-xp /usr/lib/libCOREGL.so.4.0
43552000 4355d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43566000 4356b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4370e000 4370f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43718000 43f17000 rw-p [stack:4885]
43f18000 44717000 rw-p [stack:4886]
44718000 44f17000 rw-p [stack:4887]
44fcf000 44fd0000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44feb000 44ff2000 r-xp /usr/lib/libfeedback.so.0.1.4
45101000 45900000 rw-p [stack:4888]
459b8000 459b9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
459c1000 459c3000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
459cb000 459d5000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
459dd000 459e4000 r-xp /usr/lib/libmmfcommon.so.0.0.0
459ec000 459f1000 r-xp /usr/lib/libmmfsession.so.0.0.0
45b00000 45b16000 r-xp /usr/lib/libmmfsound.so.0.1.0
45b28000 45b32000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45b3e000 45b42000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45b4b000 45b60000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45b68000 45bc9000 r-xp /usr/lib/libasound.so.2.0.0
45bd3000 45bd6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45bde000 45c16000 r-xp /usr/lib/libpulse.so.0.16.2
45c17000 45c1a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45c22000 45c53000 r-xp /usr/lib/libmdm.so.1.1.86
45c5b000 45c60000 r-xp /usr/lib/libjson.so.0.0.1
45c68000 45cb0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45cb1000 45cf8000 r-xp /usr/lib/libsndfile.so.1.0.26
45d04000 45d0c000 r-xp /usr/lib/libmdm-common.so.1.0.89
45d0d000 45d2f000 r-xp /usr/lib/libvorbis.so.0.4.3
45d37000 45d3b000 r-xp /usr/lib/libogg.so.0.7.1
bea92000 beab3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4813)
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
0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:56:28.240+0200 W/W_HOME  (  767): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-14 22:56:28.240+0200 W/W_HOME  (  767): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-14 22:56:28.240+0200 I/wnotib  (  767): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-14 22:56:28.240+0200 I/wnotib  (  767): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-14 22:56:28.265+0200 W/W_INDICATOR(  700): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 1, scroll 0
10-14 22:56:28.290+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [695].
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(830682461)
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 22:00:00 (UTC).
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[830682461] is removed.
10-14 22:56:28.295+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 22:56:28.305+0200 E/APPS    (  767): apps_main.c: apps_main_pause(602) >  paused already
10-14 22:56:29.200+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 22:56:29.200+0200 W/AUL_AMD (  535): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 22:57:12.535+0200 E/PKGMGR_SERVER( 4647): pkgmgr-server.c: main(2167) > package manager server start
10-14 22:57:12.655+0200 E/PKGMGR_SERVER( 4647): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_75123038], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[vp3bum99OcNecKdrezTEBLKCqdo=], backend_flag=[0]
10-14 22:57:12.665+0200 E/PKGMGR_SERVER( 4648): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-14 22:57:12.670+0200 E/PKGMGR  ( 4645): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-14 22:57:12.745+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:57:12.755+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 22:57:12.765+0200 E/PKGMGR_SERVER( 4648): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-14 22:57:12.790+0200 E/PKGMGR_SERVER( 4647): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4648]
10-14 22:57:14.655+0200 E/PKGMGR_SERVER( 4647): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 22:57:14.665+0200 E/PKGMGR_SERVER( 4647): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 22:57:15.890+0200 E/PKGMGR  ( 4746): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-14 22:57:16.105+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: main(2167) > package manager server start
10-14 22:57:16.190+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_78684253], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_78684253' '-r' 'org.example.dataextraction'], cookie=[ya8xwlyu7HO/E6hAXvEDHVAvDuU=], backend_flag=[0]
10-14 22:57:16.195+0200 E/PKGMGR  ( 4748): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-14 22:57:16.195+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-14 22:57:16.200+0200 E/PKGMGR  ( 4746): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[47460002]
10-14 22:57:16.200+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 22:57:16.200+0200 E/PKGMGR_SERVER( 4749): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-14 22:57:16.205+0200 E/PKGMGR_SERVER( 4750): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 22:57:16.270+0200 E/PKGMGR_OBSERVER( 4750): pkg_observer.c: main(601) > OBSERVER start
10-14 22:57:16.325+0200 E/rpm-installer( 4749): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 22:57:16.325+0200 E/rpm-installer( 4749): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 22:57:16.325+0200 E/rpm-installer( 4749): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 22:57:16.530+0200 E/PKGMGR_OBSERVER( 4750): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[47500002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-14 22:57:16.555+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-14 22:57:16.555+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-14 22:57:16.560+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-14 22:57:16.560+0200 E/PKGMGR_OBSERVER( 4750): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[47500002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 22:57:16.580+0200 W/W_HOME  (  767): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-14 22:57:16.600+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-14 22:57:16.720+0200 W/CERT_SVC( 4749): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 22:57:16.735+0200 E/rpm-installer( 4749): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-14 22:57:16.735+0200 E/rpm-installer( 4749): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-14 22:57:16.735+0200 E/rpm-installer( 4749): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-14 22:57:16.755+0200 E/PKGMGR_PARSER( 4749): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-CLIENT( 4749): SocketClient.cpp: SocketClient(37) > Client created
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketService.cpp: mainloop(227) > Got incoming connection
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-CLIENT( 4749): SocketStream.h: SocketStream(31) > Created
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-CLIENT( 4749): SocketConnection.h: SocketConnection(44) > Created
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-CLIENT( 4749): SocketClient.cpp: connect(62) > Client connected
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketService.cpp: connectionThread(253) > Starting connection thread
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketStream.h: SocketStream(31) > Created
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketConnection.h: SocketConnection(44) > Created
10-14 22:57:16.775+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketService.cpp: connectionService(304) > Calling service
10-14 22:57:16.780+0200 I/PRIVACY-MANAGER-CLIENT( 4749): SocketClient.cpp: disconnect(72) > Client disconnected
10-14 22:57:16.785+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketService.cpp: connectionService(307) > Removing client
10-14 22:57:16.785+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketService.cpp: connectionService(311) > Call served
10-14 22:57:16.785+0200 I/PRIVACY-MANAGER-SERVER(  486): SocketService.cpp: connectionThread(262) > Client serviced
10-14 22:57:16.790+0200 E/PKGMGR_CERT( 4749): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-14 22:57:16.795+0200 E/PKGMGR_CERT( 4749): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-14 22:57:16.810+0200 E/PKGMGR_CERT( 4749): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-14 22:57:16.875+0200 E/rpm-installer( 4749): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-14 22:57:16.880+0200 E/PKGMGR_OBSERVER( 4750): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[47500002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-14 22:57:16.890+0200 E/APPS    (  767): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-14 22:57:16.890+0200 E/APPS    (  767): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-14 22:57:16.900+0200 E/PKGMGR_OBSERVER( 4750): pkg_observer.c: main(620) > OBSERVER end
10-14 22:57:16.910+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-14 22:57:16.915+0200 E/STARTER (  695): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-14 22:57:16.935+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 22:57:16.935+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4750]
10-14 22:57:16.980+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-14 22:57:16.980+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 22:57:16.980+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 22:57:16.980+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 22:57:17.625+0200 E/rpm-installer( 4749): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 22:57:17.625+0200 E/rpm-installer( 4749): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 22:57:17.625+0200 E/rpm-installer( 4749): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 22:57:17.655+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4749]
10-14 22:57:17.810+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/4749/oom_score_adj failed
10-14 22:57:17.815+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 4749
10-14 22:57:18.650+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 22:57:18.650+0200 E/PKGMGR_SERVER( 4748): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 22:57:18.980+0200 E/PKGMGR  ( 4800): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-14 22:57:19.190+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: main(2167) > package manager server start
10-14 22:57:19.275+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_81753233], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_81753233' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[VcMFe7hdQch+qvDBlaS023fm5Ow=], backend_flag=[0]
10-14 22:57:19.285+0200 E/PKGMGR  ( 4802): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-14 22:57:19.290+0200 E/PKGMGR  ( 4800): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[48000002]
10-14 22:57:19.295+0200 E/PKGMGR_SERVER( 4803): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-14 22:57:19.295+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 22:57:19.300+0200 E/PKGMGR_SERVER( 4804): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 22:57:19.370+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: main(601) > OBSERVER start
10-14 22:57:19.405+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 22:57:19.405+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 22:57:19.405+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 22:57:19.525+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-14 22:57:19.535+0200 E/rpm-installer( 4803): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-14 22:57:19.540+0200 E/rpm-installer( 4803): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-14 22:57:19.540+0200 E/rpm-installer( 4803): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-14 22:57:19.545+0200 E/rpm-installer( 4803): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-14 22:57:19.545+0200 E/rpm-installer( 4803): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-14 22:57:19.665+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[48040002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-14 22:57:19.680+0200 E/APPS    (  767): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-14 22:57:19.680+0200 E/APPS    (  767): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-14 22:57:19.715+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-14 22:57:19.715+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-14 22:57:19.730+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[48040002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 22:57:19.760+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 22:57:19.890+0200 W/CERT_SVC( 4803): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 22:57:19.920+0200 E/rpm-installer( 4803): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-14 22:57:19.920+0200 E/rpm-installer( 4803): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-14 22:57:19.920+0200 E/rpm-installer( 4803): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-14 22:57:19.920+0200 E/rpm-installer( 4803): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-14 22:57:19.985+0200 E/PKGMGR_PARSER( 4803): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-14 22:57:19.995+0200 E/PKGMGR_PARSER( 4803): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 22:57:20.020+0200 E/PKGMGR_PARSER( 4803): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-14 22:57:20.090+0200 I/PRIVACY-MANAGER-CLIENT( 4803): SocketClient.cpp: SocketClient(37) > Client created
10-14 22:57:20.190+0200 I/efl-extension( 4803): efl_extension.c: eext_mod_init(40) > Init
10-14 22:57:20.190+0200 I/efl-extension( 4803): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-14 22:57:20.275+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-14 22:57:20.275+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 61
10-14 22:57:20.275+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 61
10-14 22:57:20.280+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-14 22:57:20.280+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-14 22:57:20.280+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-14 22:57:20.280+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-14 22:57:20.295+0200 E/PKGMGR_CERT( 4803): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-14 22:57:20.305+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[48040002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-14 22:57:20.350+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 22:57:20.375+0200 E/rpm-installer( 4803): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-14 22:57:20.385+0200 E/rpm-installer( 4803): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-14 22:57:20.405+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4403 pgid = 4403
10-14 22:57:20.430+0200 E/rpm-installer( 4803): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-14 22:57:20.455+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[48040002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-14 22:57:20.500+0200 E/rpm-installer( 4803): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-14 22:57:20.525+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 22:57:20.570+0200 I/AUL_AMD (  535): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4403
10-14 22:57:20.580+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.321
10-14 22:57:20.640+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 22:57:20.640+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4133 pgid = -1
10-14 22:57:20.640+0200 W/AUL_PAD ( 1190): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 22:57:20.650+0200 I/AUL_AMD (  535): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4133
10-14 22:57:20.655+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.322
10-14 22:57:21.135+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:57:21.135+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:57:21.185+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:57:21.190+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:57:21.250+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:57:21.250+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:57:21.255+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:57:21.260+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:57:21.260+0200 E/EFL     ( 4813): elementary<4813> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:57:21.300+0200 E/EFL     ( 4813): elementary<4813> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:57:21.305+0200 E/EFL     ( 4813): elementary<4813> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:57:21.310+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:57:21.350+0200 E/EFL     ( 4813): elementary<4813> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:57:21.365+0200 E/EFL     ( 4813): elementary<4813> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:57:21.365+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:57:21.365+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:57:21.365+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:57:21.365+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:57:21.370+0200 E/EFL     ( 4813): elementary<4813> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:57:21.370+0200 I/AUL_PAD ( 4813): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:57:21.455+0200 I/efl-extension( 4814): efl_extension.c: eext_mod_init(40) > Init
10-14 22:57:21.525+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[48040002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-14 22:57:21.545+0200 W/W_HOME  (  767): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-14 22:57:21.545+0200 W/W_HOME  (  767): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-14 22:57:21.595+0200 W/AUL_AMD (  535): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-14 22:57:21.610+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-14 22:57:21.610+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 22:57:21.610+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 22:57:21.610+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 22:57:21.610+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-14 22:57:21.610+0200 E/WMS     (  494): wms_db.c: wms_db_package_event_insert_record(177) > 
10-14 22:57:21.635+0200 E/WMS     (  494): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-14 22:57:21.650+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-14 22:57:21.660+0200 E/STARTER (  695): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-14 22:57:21.710+0200 E/PKGMGR_INFO(  493): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-14 22:57:21.720+0200 W/APPS    (  767): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 22:57:21.720+0200 W/APPS    (  767): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-14 22:57:21.725+0200 E/PKGMGR_INFO( 4804): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-14 22:57:21.745+0200 E/PKGMGR_OBSERVER( 4804): pkg_observer.c: main(620) > OBSERVER end
10-14 22:57:21.755+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 22:57:21.755+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4804]
10-14 22:57:21.785+0200 E/EFL     (  767): evas_main<767> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e2a090 is not stable during recalc loop
10-14 22:57:21.790+0200 E/EFL     (  767): evas_main<767> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e2a090 is not stable during recalc loop
10-14 22:57:21.810+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:57:21.810+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:57:21.855+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:57:21.860+0200 I/UXT     ( 4814): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 22:57:21.860+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:57:21.910+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:57:21.910+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:57:21.915+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:57:21.915+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:57:21.915+0200 E/EFL     ( 4814): elementary<4814> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:57:21.935+0200 E/EFL     ( 4814): elementary<4814> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:57:21.935+0200 E/EFL     ( 4814): elementary<4814> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:57:21.940+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:57:21.980+0200 E/EFL     ( 4814): elementary<4814> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:57:21.995+0200 E/EFL     ( 4814): elementary<4814> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:57:21.995+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:57:22.000+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:57:22.000+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:57:22.000+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:57:22.000+0200 E/EFL     ( 4814): elementary<4814> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:57:22.000+0200 I/AUL_PAD ( 4814): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:57:22.705+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 22:57:22.705+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 22:57:22.705+0200 E/rpm-installer( 4803): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 22:57:22.730+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4803]
10-14 22:57:22.760+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/4803/oom_score_adj failed
10-14 22:57:22.760+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 4803
10-14 22:57:23.650+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 22:57:23.650+0200 E/PKGMGR_SERVER( 4802): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 22:57:24.910+0200 W/AUL     ( 4878): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 22:57:24.915+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 22:57:24.940+0200 I/AUL_AMD (  535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-14 22:57:24.960+0200 I/AUL_AMD (  535): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-14 22:57:24.960+0200 E/AUL_AMD (  535): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 22:57:24.960+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(1710) > caller pid : 4878
10-14 22:57:24.975+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-14 22:57:24.980+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 22:57:24.980+0200 W/AUL_AMD (  535): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 22:57:24.980+0200 W/AUL_PAD ( 1190): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 22:57:24.980+0200 W/AUL_PAD ( 1190): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 22:57:25.045+0200 I/efl-extension( 4813): efl_extension.c: eext_mod_init(40) > Init
10-14 22:57:25.050+0200 I/UXT     ( 4813): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 22:57:25.050+0200 I/CAPI_APPFW_APPLICATION( 4813): app_main.c: ui_app_main(704) > app_efl_main
10-14 22:57:25.060+0200 I/CAPI_APPFW_APPLICATION( 4813): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 22:57:25.085+0200 W/AUL     ( 4878): launch.c: app_request_to_launchpad(282) > request cmd(0) result(4813)
10-14 22:57:25.105+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 22:57:25.175+0200 E/EFL     ( 4813): ecore_evas<4813> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 22:57:25.450+0200 I/APP_CORE( 4813): appcore-efl.c: __do_app(429) > [APP 4813] Event: RESET State: CREATED
10-14 22:57:25.450+0200 I/CAPI_APPFW_APPLICATION( 4813): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 22:57:25.490+0200 I/APP_CORE( 4813): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 22:57:25.490+0200 I/APP_CORE( 4813): appcore-efl.c: __do_app(474) > [APP 4813] Initial Launching, call the resume_cb
10-14 22:57:25.495+0200 I/CAPI_APPFW_APPLICATION( 4813): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 22:57:25.500+0200 W/W_HOME  (  767): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 22:57:25.500+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:57:25.500+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:57:25.505+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:57:25.545+0200 W/APP_CORE( 4813): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3a00002
10-14 22:57:25.620+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 22:57:25.620+0200 W/W_HOME  (  767): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 22:57:25.620+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:57:25.620+0200 W/W_HOME  (  767): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 22:57:25.625+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: PAUSE State: RUNNING
10-14 22:57:25.625+0200 I/CAPI_APPFW_APPLICATION(  767): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 22:57:25.625+0200 W/W_HOME  (  767): main.c: _appcore_pause_cb(696) > appcore pause
10-14 22:57:25.625+0200 E/W_HOME  (  767): main.c: _pause_cb(674) > paused already
10-14 22:57:25.630+0200 I/APP_CORE(  767): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-14 22:57:25.635+0200 W/AUL_AMD (  535): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 22:57:25.635+0200 W/AUL_AMD (  535): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 22:57:25.635+0200 W/wnotib  (  767): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 22:57:25.655+0200 I/APP_CORE( 4813): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
10-14 22:57:25.665+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:25.715+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:25.735+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:25.920+0200 E/AUL     (  535): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 22:57:26.110+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:26.115+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:26.170+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.327
10-14 22:57:26.210+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:57:26.225+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4813
10-14 22:57:26.225+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 22:57:26.235+0200 W/AUL_AMD (  535): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4813
10-14 22:57:26.235+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 22:57:26.235+0200 W/AUL_AMD (  535): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 22:57:26.325+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 22:57:26.325+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 22:57:26.365+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 22:57:26.370+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 22:57:26.410+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:26.445+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 22:57:26.450+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 22:57:26.455+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 22:57:26.455+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 22:57:26.455+0200 E/EFL     ( 4890): elementary<4890> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 22:57:26.475+0200 E/EFL     ( 4890): elementary<4890> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 22:57:26.480+0200 E/EFL     ( 4890): elementary<4890> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 22:57:26.480+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 22:57:26.530+0200 E/EFL     ( 4890): elementary<4890> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 22:57:26.530+0200 E/EFL     ( 4890): elementary<4890> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 22:57:26.535+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 22:57:26.535+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 22:57:26.535+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 22:57:26.535+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 22:57:26.535+0200 E/EFL     ( 4890): elementary<4890> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 22:57:26.535+0200 I/AUL_PAD ( 4890): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 22:57:26.810+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:27.415+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:27.870+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:28.415+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:28.885+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:29.420+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:29.690+0200 W/WATCH_CORE(  813): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-14 22:57:29.690+0200 I/WATCH_CORE(  813): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-14 22:57:29.695+0200 I/CAPI_WATCH_APPLICATION(  813): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 22:57:29.695+0200 W/W_HOME  (  767): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-14 22:57:29.695+0200 W/W_HOME  (  767): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-14 22:57:29.695+0200 W/W_HOME  (  767): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 22:57:29.695+0200 W/W_HOME  (  767): gesture.c: _apps_status_get(126) > apps status:0
10-14 22:57:29.695+0200 W/W_HOME  (  767): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:0 info->offtime:81862
10-14 22:57:29.695+0200 W/W_HOME  (  767): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-14 22:57:29.695+0200 W/W_HOME  (  767): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-14 22:57:29.695+0200 W/W_HOME  (  767): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-14 22:57:29.700+0200 W/STARTER (  695): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [81862]ms
10-14 22:57:29.700+0200 W/STARTER (  695): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-14 22:57:29.715+0200 I/APP_CORE( 4813): appcore-efl.c: __do_app(429) > [APP 4813] Event: RESUME State: RUNNING
10-14 22:57:29.740+0200 W/W_HOME  (  767): gesture.c: _widget_updated_cb(194) > widget updated
10-14 22:57:29.740+0200 W/W_HOME  (  767): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 22:57:29.740+0200 W/W_HOME  (  767): gesture.c: _manual_render(180) > 
10-14 22:57:29.755+0200 I/MALI    (  767): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-14 22:57:29.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 22:57:29.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 22:57:29.755+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_boolean(1173) > preference_get_boolean(1100) : test_healthy_pace error
10-14 22:57:29.775+0200 W/W_HOME  (  767): gesture.c: _manual_render(180) > 
10-14 22:57:29.785+0200 W/W_HOME  (  767): gesture.c: _manual_render_enable(136) > 0
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_double(1214) > preference_get_double(1100) : pedometer_inactive_period error
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_double(1214) > preference_get_double(1100) : inactive_10min_precaution_millisec error
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-14 22:57:29.805+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1100): preference.c: preference_get_double(1214) > preference_get_double(1100) : inactive_before_10min_precaution_millisec error
10-14 22:57:29.890+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:29.890+0200 W/STARTER (  695): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
10-14 22:57:29.890+0200 W/STARTER (  695): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-14 22:57:29.900+0200 W/SHealth_Common(  826): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 22:57:29.900+0200 W/SHealth_Common( 1100): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 22:57:29.900+0200 W/SHealth_Service( 1100): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 22:57:29.945+0200 W/SHealth_Common( 1100): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 22:57:29.975+0200 W/SHealth_Common( 1100): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 22:57:29.985+0200 I/HealthDataService(  779): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 22:57:30.010+0200 I/healthData( 1100): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 22:57:30.420+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:30.625+0200 I/APP_CORE(  767): appcore-efl.c: __do_app(429) > [APP 767] Event: MEM_FLUSH State: PAUSED
10-14 22:57:30.870+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:31.420+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:31.880+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:32.420+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:32.875+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:33.420+0200 I/INFO_TAG( 4813): HEART RATE 0: 0
10-14 22:57:33.875+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:34.405+0200 E/EFL     ( 4813): ecore_x<4813> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=719753 button=1
10-14 22:57:34.600+0200 E/EFL     ( 4813): ecore_x<4813> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=719946 button=1
10-14 22:57:34.825+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:35.460+0200 E/EFL     ( 4813): ecore_x<4813> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=720786 button=1
10-14 22:57:35.490+0200 E/EFL     ( 4813): ecore_x<4813> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=720832 button=1
10-14 22:57:35.815+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-14 22:57:36.050+0200 E/EFL     ( 4813): ecore_x<4813> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=721398 button=1
10-14 22:57:36.130+0200 E/EFL     ( 4813): ecore_x<4813> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=721480 button=1
10-14 22:57:36.365+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-14 22:57:36.385+0200 E/EFL     ( 4813): elementary<4813> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-14 22:57:36.430+0200 I/INFO_TAG_SENSOR_EVENT2( 4813): HEART RATE : 59
10-14 22:57:36.430+0200 F/EFL     ( 4813): evas_main<4813> main.c:122 evas_debug_magic_wrong() Input object is wrong type
10-14 22:57:36.430+0200 F/EFL     ( 4813):     Expected: 71737723 - Evas_Object
10-14 22:57:36.430+0200 F/EFL     ( 4813):     Supplied: 4146b70f - <UNKNOWN>
10-14 22:57:36.750+0200 W/CRASH_MANAGER( 4969): worker.c: worker_job(1205) > 1104813646174150801465
