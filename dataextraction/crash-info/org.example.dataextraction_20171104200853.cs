S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 20018
Date: 2017-11-04 20:08:53+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 20018, uid 5000)

Register Information
r0   = 0x433509b8, r1   = 0x00000041
r2   = 0x00000000, r3   = 0x00000100
r4   = 0x43350ce8, r5   = 0x4059d250
r6   = 0x00000040, r7   = 0x00000050
r8   = 0x00000140, r9   = 0x4059d250
r10  = 0x43350d28, fp   = 0x41801b1e
ip   = 0x00000020, sp   = 0xbefc0bb0
lr   = 0x404e6388, pc   = 0x404e471c
cpsr = 0x80000010

Memory Information
MemTotal:   491948 KB
MemFree:     36208 KB
Buffers:     46804 KB
Cached:     164948 KB
VmPeak:      98796 KB
VmSize:      97320 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19812 KB
VmRSS:       19812 KB
VmData:      40460 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25564 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 20018 TID = 20018
20018 20084 20281 

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
436c4000 43ec3000 rw-p [stack:20084]
43ec3000 43ece000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ed7000 43edc000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43ef6000 43ef7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4408c000 4408e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
44097000 44896000 rw-p [stack:20281]
459f2000 459f5000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
45afd000 45afe000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
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
befa1000 befc2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20018)
Call Stack Count: 1
 0: (0x404e471c) [/lib/libc.so.6] + 0x6d71c
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
200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=6657100
11-04 20:08:20.693+0200 W/W_HOME  (  759): move.c: move_back_to_home(252) > back to home
11-04 20:08:20.698+0200 W/W_HOME  (  759): move.c: _create_fake_apps(823) > fake image position : 0
11-04 20:08:20.703+0200 W/W_HOME  (  759): move.c: _create_fake_apps(847) > move_info.current_y_coord: 0
11-04 20:08:20.703+0200 W/W_HOME  (  759): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
11-04 20:08:20.703+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:20.703+0200 W/W_HOME  (  759): event_manager.c: _state_control(314) > clock/widget (force) resumed
11-04 20:08:20.703+0200 W/W_HOME  (  759): clock_indicator.c: clock_indicator_resume(537) > 
11-04 20:08:20.703+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:20.708+0200 W/W_HOME  (  759): key.c: _execute_cbs(123) > back key execution has been stopped
11-04 20:08:20.708+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(583) > apps,hide,start
11-04 20:08:20.708+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(601) > state: 0 -> 1
11-04 20:08:20.708+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:20.708+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:20.708+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:20.708+0200 W/W_HOME  (  759): noti_broker.c: _apptray_visibility_cb(789) > apps,hide,start
11-04 20:08:20.708+0200 W/W_HOME  (  759): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
11-04 20:08:20.708+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
11-04 20:08:20.708+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
11-04 20:08:20.858+0200 W/WATCH_CORE(  823): appcore-watch.c: __widget_resume(1039) > widget_resume
11-04 20:08:20.858+0200 I/CAPI_WATCH_APPLICATION(  823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-04 20:08:20.998+0200 W/W_HOME  (  759): move.c: _transit_del_cb(115) > transit end
11-04 20:08:20.998+0200 W/W_HOME  (  759): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
11-04 20:08:20.998+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:21.013+0200 W/W_HOME  (  759): move.c: _scroller_down_done(494) > down signal done
11-04 20:08:21.018+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(583) > apps,hide
11-04 20:08:21.018+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(601) > state: 0 -> 0
11-04 20:08:21.018+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:21.018+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:21.018+0200 W/W_HOME  (  759): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
11-04 20:08:21.018+0200 W/W_HOME  (  759): main.c: home_resume(739) > clock/widget resumed
11-04 20:08:21.018+0200 W/W_HOME  (  759): clock_indicator.c: clock_indicator_resume(537) > 
11-04 20:08:21.023+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:21.023+0200 W/W_HOME  (  759): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
11-04 20:08:21.023+0200 W/W_HOME  (  759): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
11-04 20:08:21.023+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
11-04 20:08:21.023+0200 I/wnotib  (  759): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
11-04 20:08:21.028+0200 E/APPS    (  759): apps_main.c: apps_main_pause(602) >  paused already
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-04 20:08:21.168+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.168+0200 E/CAPI_APPFW_APP_CONTROL( 1385): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-04 20:08:21.168+0200 W/MUSIC_CONTROL_SERVICE( 1385): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1385]   [com.samsung.w-home]register msg port [true][0m
11-04 20:08:21.173+0200 W/AUL_AMD (  538): amd_request.c: __request_handler(645) > __request_handler: 14
11-04 20:08:21.183+0200 W/AUL_AMD (  538): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 759
11-04 20:08:21.223+0200 W/MUSIC_CONTROL_SERVICE( 1385): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1385]   [MUSIC_PLAYER_EVENT][0m
11-04 20:08:21.228+0200 W/MUSIC_CONTROL_SERVICE( 1385): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1385]   bundle_add_str() .. [0xffffffea][0m
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-04 20:08:21.228+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.233+0200 W/MUSIC_CONTROL_SERVICE( 1385): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1385]   [MUSIC_PLAYER_EVENT][0m
11-04 20:08:21.238+0200 W/W_HOME  (  759): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-04 20:08:21.238+0200 E/W_HOME  (  759): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-04 20:08:21.238+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.248+0200 I/TIZEN_N_SOUND_MANAGER( 1385): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-04 20:08:21.248+0200 E/TIZEN_N_SOUND_MANAGER( 1385): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-04 20:08:21.248+0200 W/MUSIC_CONTROL_SERVICE( 1385): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1385]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-04 20:08:21.248+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.263+0200 W/W_HOME  (  759): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-04 20:08:21.263+0200 E/W_HOME  (  759): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-04 20:08:21.263+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:21.373+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3117) > Deliver KeyPress
11-04 20:08:21.373+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3128) > Deliver KeyRelease
11-04 20:08:21.393+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=6657542
11-04 20:08:21.393+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=6657786
11-04 20:08:21.393+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40000
11-04 20:08:21.393+0200 W/W_HOME  (  759): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
11-04 20:08:21.393+0200 E/W_HOME  (  759): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
11-04 20:08:21.393+0200 W/W_HOME  (  759): main.c: _back_key_cb(1596) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-04 20:08:21.393+0200 W/W_HOME  (  759): main.c: _back_key_cb(1613) > emit:signal => key,back,clicked
11-04 20:08:21.393+0200 W/W_HOME  (  759): clock_event.c: _back_key_cb(286) > 
11-04 20:08:21.408+0200 W/WATCH_CORE(  823): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
11-04 20:08:22.018+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3117) > Deliver KeyPress
11-04 20:08:22.018+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3128) > Deliver KeyRelease
11-04 20:08:22.023+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=6658135
11-04 20:08:22.023+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=6658432
11-04 20:08:22.023+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40000
11-04 20:08:22.023+0200 W/W_HOME  (  759): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
11-04 20:08:22.023+0200 E/W_HOME  (  759): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
11-04 20:08:22.023+0200 W/W_HOME  (  759): main.c: _back_key_cb(1596) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-04 20:08:22.023+0200 W/W_HOME  (  759): main.c: _back_key_cb(1613) > emit:signal => key,back,clicked
11-04 20:08:22.023+0200 W/W_HOME  (  759): clock_event.c: _back_key_cb(286) > 
11-04 20:08:22.038+0200 W/WATCH_CORE(  823): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
11-04 20:08:23.173+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3117) > Deliver KeyPress
11-04 20:08:23.173+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3128) > Deliver KeyRelease
11-04 20:08:23.178+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=6659336
11-04 20:08:23.178+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=6659586
11-04 20:08:23.178+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40000
11-04 20:08:23.178+0200 W/W_HOME  (  759): noti_broker.c: _noti_broker_back_cb(765) > continue the back key execution
11-04 20:08:23.178+0200 E/W_HOME  (  759): cs_broker.c: _cs_broker_back_cb(238) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
11-04 20:08:23.178+0200 W/W_HOME  (  759): main.c: _back_key_cb(1596) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-04 20:08:23.178+0200 W/W_HOME  (  759): main.c: _back_key_cb(1613) > emit:signal => key,back,clicked
11-04 20:08:23.178+0200 W/W_HOME  (  759): clock_event.c: _back_key_cb(286) > 
11-04 20:08:23.193+0200 W/WATCH_CORE(  823): appcore-watch.c: __widget_text_signal_cb(1055) > widget_text_signal
11-04 20:08:24.608+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
11-04 20:08:24.608+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
11-04 20:08:24.613+0200 W/STARTER (  721): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
11-04 20:08:24.613+0200 W/STARTER (  721): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
11-04 20:08:24.613+0200 W/STARTER (  721): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
11-04 20:08:24.618+0200 E/STARTER (  721): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
11-04 20:08:24.618+0200 W/STARTER (  721): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
11-04 20:08:24.618+0200 W/STARTER (  721): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
11-04 20:08:24.623+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=6661020
11-04 20:08:24.988+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-04 20:08:24.988+0200 W/KEYROUTER(  408): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
11-04 20:08:24.993+0200 W/STARTER (  721): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
11-04 20:08:24.993+0200 W/STARTER (  721): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
11-04 20:08:25.003+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=6661400
11-04 20:08:25.008+0200 W/STARTER (  721): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
11-04 20:08:25.013+0200 W/STARTER (  721): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
11-04 20:08:25.018+0200 E/STARTER (  721): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
11-04 20:08:25.018+0200 W/AUL     (  721): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
11-04 20:08:25.018+0200 W/AUL_AMD (  538): amd_request.c: __request_handler(645) > __request_handler: 0
11-04 20:08:25.028+0200 W/AUL_AMD (  538): amd_launch.c: _start_app(1710) > caller pid : 721
11-04 20:08:25.058+0200 W/AUL_AMD (  538): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 759
11-04 20:08:25.063+0200 I/APP_CORE(  759): appcore-efl.c: __do_app(429) > [APP 759] Event: RESET State: RUNNING
11-04 20:08:25.063+0200 I/CAPI_APPFW_APPLICATION(  759): app_main.c: app_appcore_reset(245) > app_appcore_reset
11-04 20:08:25.063+0200 W/AUL_AMD (  538): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(759), cmd(0)
11-04 20:08:25.063+0200 W/W_HOME  (  759): main.c: _app_control(1704) > Service value : powerkey
11-04 20:08:25.063+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
11-04 20:08:25.063+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
11-04 20:08:25.063+0200 W/W_HOME  (  759): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
11-04 20:08:25.063+0200 E/W_HOME  (  759): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
11-04 20:08:25.063+0200 W/W_HOME  (  759): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
11-04 20:08:25.068+0200 W/AUL     (  721): launch.c: app_request_to_launchpad(282) > request cmd(0) result(759)
11-04 20:08:25.068+0200 W/W_HOME  (  759): move.c: move_move_to_apps(220) > move to apps
11-04 20:08:25.068+0200 E/AUL     (  721): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-04 20:08:25.068+0200 E/AUL     (  538): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-04 20:08:25.068+0200 W/W_HOME  (  759): move.c: _create_fake_apps(823) > fake image position : 432
11-04 20:08:25.068+0200 W/W_HOME  (  759): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
11-04 20:08:25.068+0200 W/W_HOME  (  759): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
11-04 20:08:25.068+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:25.068+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:25.068+0200 I/APP_CORE(  759): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
11-04 20:08:25.073+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
11-04 20:08:25.073+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
11-04 20:08:25.073+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:25.073+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:25.073+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:25.073+0200 W/W_HOME  (  759): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
11-04 20:08:25.073+0200 W/W_HOME  (  759): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
11-04 20:08:25.073+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
11-04 20:08:25.073+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
11-04 20:08:25.093+0200 I/APP_CORE(20018): appcore-efl.c: __do_app(429) > [APP 20018] Event: MEM_FLUSH State: PAUSED
11-04 20:08:25.383+0200 W/W_HOME  (  759): move.c: _transit_del_cb(115) > transit end
11-04 20:08:25.383+0200 W/W_HOME  (  759): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
11-04 20:08:25.383+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
11-04 20:08:25.398+0200 W/W_HOME  (  759): move.c: _scroller_up_done(515) > up signal done
11-04 20:08:25.403+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(583) > apps,show
11-04 20:08:25.403+0200 W/W_HOME  (  759): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
11-04 20:08:25.403+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:25.403+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:25.403+0200 W/W_HOME  (  759): main.c: home_pause(766) > clock/widget paused
11-04 20:08:25.403+0200 W/W_HOME  (  759): clock_indicator.c: clock_indicator_pause(554) > 
11-04 20:08:25.408+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:25.408+0200 W/W_HOME  (  759): noti_broker.c: _apptray_visibility_cb(789) > apps,show
11-04 20:08:25.408+0200 W/W_HOME  (  759): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
11-04 20:08:25.408+0200 I/wnotib  (  759): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
11-04 20:08:25.408+0200 I/wnotib  (  759): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
11-04 20:08:25.408+0200 E/APPS    (  759): apps_main.c: apps_main_resume(636) >  resumed already
11-04 20:08:25.418+0200 W/WATCH_CORE(  823): appcore-watch.c: __widget_pause(1028) > widget_pause
11-04 20:08:25.873+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6662288 button=1
11-04 20:08:25.873+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.873+0200 E/W_HOME  (  759): move.c: _mouse_down_cb(384) > apps move is not allowed
11-04 20:08:25.873+0200 W/APPS    (  759): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
11-04 20:08:25.888+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.898+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.898+0200 W/APPS    (  759): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
11-04 20:08:25.913+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.923+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.933+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.948+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.963+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:25.973+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6662384 button=1
11-04 20:08:25.973+0200 E/APPS    (  759): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
11-04 20:08:26.063+0200 W/AUL_AMD (  538): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-04 20:08:26.063+0200 W/AUL_AMD (  538): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
11-04 20:08:26.598+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6663011 button=1
11-04 20:08:26.598+0200 E/W_HOME  (  759): move.c: _mouse_move_cb(546) > apps move is not allowed
11-04 20:08:26.598+0200 E/W_HOME  (  759): move.c: _mouse_down_cb(384) > apps move is not allowed
11-04 20:08:26.598+0200 W/APPS    (  759): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
11-04 20:08:26.673+0200 E/EFL     (  759): ecore_x<759> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6663084 button=1
11-04 20:08:26.673+0200 W/APPS    (  759): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
11-04 20:08:26.673+0200 E/APPS    (  759): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
11-04 20:08:26.673+0200 W/APPS    (  759): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
11-04 20:08:26.673+0200 W/AUL     (  759): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-04 20:08:26.673+0200 W/AUL_AMD (  538): amd_request.c: __request_handler(645) > __request_handler: 0
11-04 20:08:26.678+0200 W/AUL_AMD (  538): amd_launch.c: _start_app(1710) > caller pid : 759
11-04 20:08:26.678+0200 I/AUL_AMD (  538): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
11-04 20:08:26.688+0200 W/AUL_AMD (  538): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 20018
11-04 20:08:26.693+0200 W/AUL_AMD (  538): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(20018), cmd(0)
11-04 20:08:26.693+0200 W/AUL     (  759): launch.c: app_request_to_launchpad(282) > request cmd(0) result(20018)
11-04 20:08:26.693+0200 E/W_HOME  (  759): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
11-04 20:08:26.693+0200 E/AUL     (  538): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-04 20:08:26.693+0200 I/APP_CORE(20018): appcore-efl.c: __do_app(429) > [APP 20018] Event: RESET State: PAUSED
11-04 20:08:26.693+0200 I/CAPI_APPFW_APPLICATION(20018): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-04 20:08:26.693+0200 I/APP_CORE(20018): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
11-04 20:08:26.693+0200 I/APP_CORE(20018): appcore-efl.c: __do_app(481) > [APP 20018] App already running, raise the window
11-04 20:08:26.703+0200 I/APP_CORE(20018): appcore-efl.c: __do_app(485) > [APP 20018] Call the resume_cb
11-04 20:08:26.703+0200 I/CAPI_APPFW_APPLICATION(20018): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-04 20:08:26.733+0200 W/W_HOME  (  759): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-04 20:08:26.733+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.733+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.733+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.773+0200 W/W_HOME  (  759): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-04 20:08:26.773+0200 W/W_HOME  (  759): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-04 20:08:26.773+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.773+0200 W/W_HOME  (  759): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-04 20:08:26.773+0200 I/APP_CORE(20018): appcore-efl.c: __do_app(429) > [APP 20018] Event: RESUME State: RUNNING
11-04 20:08:26.773+0200 I/APP_CORE(  759): appcore-efl.c: __do_app(429) > [APP 759] Event: PAUSE State: RUNNING
11-04 20:08:26.773+0200 I/CAPI_APPFW_APPLICATION(  759): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-04 20:08:26.773+0200 W/W_HOME  (  759): main.c: _appcore_pause_cb(696) > appcore pause
11-04 20:08:26.773+0200 W/W_HOME  (  759): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-04 20:08:26.773+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.778+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.778+0200 W/W_HOME  (  759): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-04 20:08:26.778+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-04 20:08:26.778+0200 E/CAPI_APPFW_APP_CONTROL( 1385): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-04 20:08:26.778+0200 W/MUSIC_CONTROL_SERVICE( 1385): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1385]   [com.samsung.w-home]register msg port [false][0m
11-04 20:08:26.818+0200 W/wnotib  (  759): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-04 20:08:27.093+0200 E/AUL     (  538): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-04 20:08:27.283+0200 I/APP_CORE(  759): appcore-efl.c: __do_app(429) > [APP 759] Event: MEM_FLUSH State: PAUSED
11-04 20:08:28.123+0200 E/EFL     (20018): ecore_x<20018> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6664534 button=1
11-04 20:08:28.278+0200 E/EFL     (20018): ecore_x<20018> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6664689 button=1
11-04 20:08:28.488+0200 E/RECORDING_TAG(20018): sensor_listener_unset_event_cb error: -38010874
11-04 20:08:28.493+0200 E/EFL     (20018): elementary<20018> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-04 20:08:28.518+0200 E/EFL     (20018): elementary<20018> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-04 20:08:28.878+0200 E/EFL     (20018): elementary<20018> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-04 20:08:29.078+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 125
11-04 20:08:29.123+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 125
11-04 20:08:30.073+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 124
11-04 20:08:30.088+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 124
11-04 20:08:31.083+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 123
11-04 20:08:31.108+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 123
11-04 20:08:31.838+0200 I/APP_CORE(  759): appcore-efl.c: __do_app(429) > [APP 759] Event: MEM_FLUSH State: PAUSED
11-04 20:08:32.093+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 123
11-04 20:08:32.118+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 123
11-04 20:08:33.083+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 121
11-04 20:08:33.103+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 121
11-04 20:08:34.083+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 123
11-04 20:08:34.108+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 123
11-04 20:08:35.083+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 124
11-04 20:08:35.093+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 124
11-04 20:08:36.078+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 125
11-04 20:08:36.093+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 125
11-04 20:08:37.083+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 124
11-04 20:08:37.103+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 124
11-04 20:08:38.083+0200 I/INFO_TAG(20018): SENSOR_EVENT2 HEART RATE : 127
11-04 20:08:38.108+0200 I/INFO_TAG(20018): SENSOR_EVENT2 TAB VALUE : 127
11-04 20:08:38.818+0200 E/EFL     (20018): ecore_x<20018> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=6675232 button=1
11-04 20:08:38.843+0200 E/EFL     (20018): ecore_x<20018> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=6675254 button=1
11-04 20:08:38.858+0200 E/EFL     (20018): elementary<20018> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-04 20:08:38.933+0200 I/Bluetooth(20018): [bt_socket_create_rfcomm] success.
11-04 20:08:39.033+0200 I/BluetoothServer(20018): [bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.
11-04 20:08:39.058+0200 E/EFL     (20018): elementary<20018> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-04 20:08:39.408+0200 E/EFL     (20018): elementary<20018> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-04 20:08:45.618+0200 W/W_INDICATOR(  725): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
11-04 20:08:45.618+0200 W/W_INDICATOR(  725): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
11-04 20:08:47.468+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-04 20:08:47.468+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-04 20:08:47.468+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-04 20:08:47.468+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-04 20:08:47.478+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-04 20:08:47.478+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-04 20:08:47.478+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-04 20:08:47.478+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-04 20:08:47.478+0200 W/SHealthWidget(  846): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>58</color> bpm</color>][0;m
11-04 20:08:47.483+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
11-04 20:08:47.483+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
11-04 20:08:47.483+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
11-04 20:08:47.483+0200 E/TIZEN_N_SYSTEM_SETTINGS(  846): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
11-04 20:08:53.133+0200 I/BluetoothServer(20018): Callback: Connected.
11-04 20:08:53.133+0200 I/BluetoothServer(20018): Callback: Socket of connection - 34.
11-04 20:08:53.133+0200 I/BluetoothServer(20018): Callback: Role of connection - 1.
11-04 20:08:53.133+0200 I/BluetoothServer(20018): Callback: Address of connection - B8:81:98:D4:F2:78.
11-04 20:08:53.538+0200 I/MALI    (  759): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-04 20:08:53.593+0200 W/AUL_PAD ( 1240): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20018 pgid = 20018
11-04 20:08:53.623+0200 W/AUL_AMD (  538): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-04 20:08:53.623+0200 W/AUL_AMD (  538): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-04 20:08:53.628+0200 W/CRASH_MANAGER(20300): worker.c: worker_job(1205) > 1120018646174150981893
