S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2316
Date: 2017-10-14 13:21:17+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x40

Register Information
r0   = 0x00000000, r1   = 0x0000000d
r2   = 0xffffffff, r3   = 0xcafecafe
r4   = 0x41a598fc, r5   = 0x41a58768
r6   = 0x00000040, r7   = 0x00000000
r8   = 0x00000000, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeb543d0
lr   = 0x400933f8, pc   = 0x41657a30
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     99156 KB
Buffers:     28196 KB
Cached:     152036 KB
VmPeak:      88804 KB
VmSize:      88800 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11852 KB
VmData:      36112 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23020 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2316 TID = 2316
2316 2388 2389 2390 2391 

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
41869000 4194d000 r-xp /usr/lib/libicuuc.so.51.1
41962000 4196a000 r-xp /usr/lib/libdrm.so.2.4.0
41972000 41976000 rw-p [heap]
41976000 41a8d000 rw-p [heap]
41a8d000 41bca000 r-xp /usr/lib/libicui18n.so.51.1
41bda000 41bdc000 r-xp /usr/lib/libdri2.so.0.0.0
41be4000 41bea000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41bf2000 41bf7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41bff000 41c18000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
431a9000 431ca000 r-xp /usr/lib/libexif.so.12.3.3
431dd000 431df000 r-xp /usr/lib/libttrace.so.1.1
431e7000 431ec000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
431f4000 431fa000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43203000 4320b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43213000 4322f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43238000 4323f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43248000 4324a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43252000 43259000 r-xp /usr/lib/libminizip.so.1.0.0
43261000 4326e000 r-xp /usr/lib/libail.so.0.1.0
43277000 43341000 r-xp /usr/lib/libCOREGL.so.4.0
43554000 43d53000 rw-p [stack:2388]
43d54000 44553000 rw-p [stack:2389]
44554000 44d5c000 rw-p [stack:2390]
44d5d000 45688000 rw-p [stack:2391]
beb34000 beb55000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2316)
Call Stack Count: 10
 0: sensor_create_listener + 0x9b (0x41657a30) [/usr/lib/libcapi-system-sensor.so.0] + 0x1a30
 1: create_HRM_listener + 0x50 (0x4146bf15) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f15
 2: app_create + 0x38 (0x4146b6e9) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x16e9
 3: (0x414409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x4146b64b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x164b
 7: create_base_gui + 0x1ee (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 8: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 9: create_base_gui + 0x563 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
ager.c: __save_module_log(1765) > The file is not ready.
10-14 13:17:27.870+0200 W/W_CLOCK_VIEWER( 1784): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-14 13:17:27.870+0200 W/W_CLOCK_VIEWER( 1784): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-14 13:17:32.155+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
10-14 13:17:37.115+0200 I/DOWNLOAD_PROVIDER(  831): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
10-14 13:17:37.120+0200 W/WIFI_DIRECT_MANAGER(  883): wifi-direct-client.c: wfd_client_process_request(869) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 28 bytes read from socket[6]
10-14 13:17:37.230+0200 I/CAPI_NETWORK_CONNECTION(  831): connection.c: __connection_set_type_changed_callback(163) > Successfully de-registered(0)
10-14 13:17:37.270+0200 I/CAPI_NETWORK_CONNECTION(  831): connection.c: __connection_set_ip_changed_callback(248) > Successfully de-registered(0)
10-14 13:17:37.300+0200 I/CAPI_NETWORK_CONNECTION(  831): connection.c: connection_destroy(390) > Destroy handle: 0x42520ad0
10-14 13:17:37.325+0200 I/DOWNLOAD_PROVIDER(  831): download-provider-main.c: main(64) > download-provider's working is done
10-14 13:17:46.999+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-14 13:17:47.059+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-14 13:17:47.155+0200 E/ALARM_MANAGER(  705): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [199716756]
10-14 13:17:47.155+0200 W/STARTER (  705): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [199716756]
10-14 13:17:47.165+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-14 13:17:47.165+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 13:17:47.170+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 705
10-14 13:17:47.180+0200 W/AUL_AMD (  532): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 1063
10-14 13:17:47.185+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESET State: PAUSED
10-14 13:17:47.185+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 13:17:47.185+0200 W/W_HOME  ( 1063): main.c: _app_control(1704) > Service value : show_clock
10-14 13:17:47.185+0200 W/W_HOME  ( 1063): main.c: _app_control(1746) > Show clock operation
10-14 13:17:47.185+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(245) > clock show
10-14 13:17:47.190+0200 W/AUL_AMD (  532): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(1063), cmd(0)
10-14 13:17:47.190+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(260) > home raise
10-14 13:17:47.195+0200 W/AUL     (  705): launch.c: app_request_to_launchpad(282) > request cmd(0) result(1063)
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[199716756] is expired.
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 199716756, next duetime: 1507979887
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 11:18:07 (UTC).
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:17:47.200+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-14 13:17:47.200+0200 E/W_HOME  ( 1063): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-14 13:17:47.200+0200 W/W_HOME  ( 1063): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-14 13:17:47.200+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(263) > home raise done
10-14 13:17:47.200+0200 W/W_HOME  ( 1063): gesture.c: _clock_show(270) > show clock
10-14 13:17:47.200+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-14 13:17:47.225+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 0, scroll 0
10-14 13:17:47.250+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(199716756)
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 11:19:00 (UTC).
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[199716756] is removed.
10-14 13:17:47.255+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:17:48.195+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 13:17:48.195+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:18  /5 / HH:mm
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:18
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 18
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  18
10-14 13:18:00.170+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 18 / 13:18
10-14 13:18:00.175+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 13:18:00.205+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 13:19:00.000+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-14 13:19:00.045+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-14 13:19:00.160+0200 E/ALARM_MANAGER( 1784): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [199716757]
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[199716757] is expired.
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 199716757, next duetime: 1507980060
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 11:21:00 (UTC).
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:19:00.180+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-14 13:19:00.190+0200 E/WIDGET_EVAS( 1784): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-14 13:19:00.245+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:19  /5 / HH:mm
10-14 13:19:00.245+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:19
10-14 13:19:00.245+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 13:19:00.245+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-14 13:19:00.245+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 19
10-14 13:19:00.245+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-14 13:19:00.250+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-14 13:19:00.255+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  19
10-14 13:19:00.255+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 19 / 13:19
10-14 13:19:00.255+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 13:19:00.255+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 13:19:17.975+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 86
10-14 13:19:17.990+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 13:19:17.990+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 13:19:17.990+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 86, index 17, bg level 85
10-14 13:19:17.990+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_85
10-14 13:19:18.040+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 86
10-14 13:19:18.070+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 13:20:00.195+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:20  /5 / HH:mm
10-14 13:20:00.195+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:20
10-14 13:20:00.195+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 13:20:00.195+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-14 13:20:00.195+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 20
10-14 13:20:00.195+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-14 13:20:00.200+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  20
10-14 13:20:00.200+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 20 / 13:20
10-14 13:20:00.200+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 13:20:00.225+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 13:20:58.585+0200 W/W_INDICATOR(  714): windicator_moment_view.c: _watch_battery_capacity_cb(1455) > [_watch_battery_capacity_cb:1455] percentage 87
10-14 13:20:58.590+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(162) > [wnidicator_moment_view_battery_image_update:162] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
10-14 13:20:58.590+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(166) > [wnidicator_moment_view_battery_image_update:166] [SHOW charging icon] Connected / not Full / not charge -1
10-14 13:20:58.590+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(179) > [wnidicator_moment_view_battery_image_update:179] battery level 87, index 17, bg level 85
10-14 13:20:58.590+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(183) > [wnidicator_moment_view_battery_image_update:183] Battery signal emit : bg_level_85
10-14 13:20:58.590+0200 W/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(229) > [wnidicator_moment_view_battery_image_update:229] Battery level : 87
10-14 13:20:58.605+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 13:20:59.995+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-14 13:21:00.030+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-14 13:21:00.085+0200 E/ALARM_MANAGER( 1784): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.aw-clock-viewer] : Alarm id [199716757]
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_expired(1432) > alarm_id[199716757] is expired.
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 199716757, next duetime: 1507980180
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 11:23:00 (UTC).
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 13:21:00.110+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-14 13:21:00.125+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-14 13:21:00.215+0200 W/W_INDICATOR(  714): windicator_moment_view.c: indicator_get_time_by_region(1112) > [indicator_get_time_by_region:1112] DATE & TIME is / fr_FR / 13:21  /5 / HH:mm
10-14 13:21:00.215+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1218) > [windicator_clock_changed_cb:1218] [Time] PM / 13:21
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1227) > [windicator_clock_changed_cb:1227] Not Korean
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1238) > [windicator_clock_changed_cb:1238] ptr1 : 13
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1247) > [windicator_clock_changed_cb:1247] ptr2 : 21
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1266) > [windicator_clock_changed_cb:1266] [Time] hour :  13
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1271) > [windicator_clock_changed_cb:1271] [Time] min :  21
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1278) > [windicator_clock_changed_cb:1278] [Time] 13 / 21 / 13:21
10-14 13:21:00.220+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_clock_changed_cb(1335) > [windicator_clock_changed_cb:1335] Hide AMPM (2)
10-14 13:21:00.250+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/moment_view/charging_ui has a non-fixed part 'txt.hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 13:21:02.510+0200 E/PKGMGR_SERVER( 2149): pkgmgr-server.c: main(2167) > package manager server start
10-14 13:21:02.605+0200 E/PKGMGR_SERVER( 2149): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-135153764], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[FsCwW1/H9ZPPBgEcCIh7CpbMtMI=], backend_flag=[0]
10-14 13:21:02.615+0200 E/PKGMGR_SERVER( 2150): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-14 13:21:02.620+0200 E/PKGMGR  ( 2147): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-14 13:21:02.700+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 13:21:02.710+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-14 13:21:02.720+0200 E/PKGMGR_SERVER( 2150): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-14 13:21:02.735+0200 E/PKGMGR_SERVER( 2149): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2150]
10-14 13:21:04.655+0200 E/PKGMGR_SERVER( 2149): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 13:21:04.655+0200 E/PKGMGR_SERVER( 2149): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 13:21:07.220+0200 E/PKGMGR  ( 2248): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-14 13:21:07.455+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: main(2167) > package manager server start
10-14 13:21:07.555+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_-130251854], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_-130251854' '-r' 'org.example.dataextraction'], cookie=[40L1x1VEoor2Wyo03MfNtJxKK5A=], backend_flag=[0]
10-14 13:21:07.560+0200 E/PKGMGR  ( 2250): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-14 13:21:07.560+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-14 13:21:07.565+0200 E/PKGMGR_SERVER( 2251): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-14 13:21:07.565+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 13:21:07.570+0200 E/PKGMGR_SERVER( 2252): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 13:21:07.570+0200 E/PKGMGR  ( 2248): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[22480002]
10-14 13:21:07.630+0200 E/PKGMGR_OBSERVER( 2252): pkg_observer.c: main(601) > OBSERVER start
10-14 13:21:07.690+0200 E/rpm-installer( 2251): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 13:21:07.690+0200 E/rpm-installer( 2251): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 13:21:07.690+0200 E/rpm-installer( 2251): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 13:21:07.890+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-14 13:21:07.890+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-14 13:21:07.890+0200 E/PKGMGR_OBSERVER( 2252): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[22520002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-14 13:21:07.905+0200 E/PKGMGR_OBSERVER( 2252): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[22520002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 13:21:07.910+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-14 13:21:07.920+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-14 13:21:07.940+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-14 13:21:08.110+0200 W/CERT_SVC( 2251): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 13:21:08.125+0200 E/rpm-installer( 2251): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-14 13:21:08.125+0200 E/rpm-installer( 2251): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-14 13:21:08.125+0200 E/rpm-installer( 2251): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-14 13:21:08.150+0200 E/PKGMGR_PARSER( 2251): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-CLIENT( 2251): SocketClient.cpp: SocketClient(37) > Client created
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: mainloop(227) > Got incoming connection
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-CLIENT( 2251): SocketStream.h: SocketStream(31) > Created
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-CLIENT( 2251): SocketConnection.h: SocketConnection(44) > Created
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-CLIENT( 2251): SocketClient.cpp: connect(62) > Client connected
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(253) > Starting connection thread
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketStream.h: SocketStream(31) > Created
10-14 13:21:08.175+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketConnection.h: SocketConnection(44) > Created
10-14 13:21:08.180+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(304) > Calling service
10-14 13:21:08.180+0200 I/PRIVACY-MANAGER-CLIENT( 2251): SocketClient.cpp: disconnect(72) > Client disconnected
10-14 13:21:08.190+0200 E/PKGMGR_CERT( 2251): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-14 13:21:08.190+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(307) > Removing client
10-14 13:21:08.190+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionService(311) > Call served
10-14 13:21:08.190+0200 I/PRIVACY-MANAGER-SERVER(  488): SocketService.cpp: connectionThread(262) > Client serviced
10-14 13:21:08.200+0200 E/PKGMGR_CERT( 2251): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-14 13:21:08.215+0200 E/PKGMGR_CERT( 2251): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-14 13:21:08.300+0200 E/rpm-installer( 2251): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-14 13:21:08.305+0200 E/PKGMGR_OBSERVER( 2252): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[22520002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-14 13:21:08.310+0200 E/APPS    ( 1063): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-14 13:21:08.310+0200 E/APPS    ( 1063): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-14 13:21:08.315+0200 E/PKGMGR_OBSERVER( 2252): pkg_observer.c: main(620) > OBSERVER end
10-14 13:21:08.330+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 13:21:08.330+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2252]
10-14 13:21:08.380+0200 E/STARTER (  705): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-14 13:21:08.420+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-14 13:21:08.440+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-14 13:21:08.440+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 13:21:08.440+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 13:21:08.440+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 13:21:09.115+0200 E/rpm-installer( 2251): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 13:21:09.115+0200 E/rpm-installer( 2251): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 13:21:09.115+0200 E/rpm-installer( 2251): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 13:21:09.150+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2251]
10-14 13:21:09.160+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/2251/oom_score_adj failed
10-14 13:21:09.160+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 2251
10-14 13:21:09.645+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 13:21:09.645+0200 E/PKGMGR_SERVER( 2250): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 13:21:11.205+0200 E/PKGMGR  ( 2303): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-14 13:21:11.465+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: main(2167) > package manager server start
10-14 13:21:11.590+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_-126283975], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_-126283975' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[8LJClRlqRB8EtYgqVyyDip+qkjo=], backend_flag=[0]
10-14 13:21:11.595+0200 E/PKGMGR  ( 2305): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-14 13:21:11.600+0200 E/PKGMGR_SERVER( 2306): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-14 13:21:11.610+0200 E/PKGMGR  ( 2303): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[23030002]
10-14 13:21:11.610+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-14 13:21:11.615+0200 E/PKGMGR_SERVER( 2307): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-14 13:21:11.680+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: main(601) > OBSERVER start
10-14 13:21:11.705+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-14 13:21:11.705+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-14 13:21:11.705+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-14 13:21:11.835+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-14 13:21:11.840+0200 E/rpm-installer( 2306): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-14 13:21:11.845+0200 E/rpm-installer( 2306): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-14 13:21:11.845+0200 E/rpm-installer( 2306): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-14 13:21:11.850+0200 E/rpm-installer( 2306): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-14 13:21:11.850+0200 E/rpm-installer( 2306): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-14 13:21:11.955+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[23070002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-14 13:21:11.960+0200 E/APPS    ( 1063): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-14 13:21:11.960+0200 E/APPS    ( 1063): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-14 13:21:11.980+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-14 13:21:11.985+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[23070002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-14 13:21:12.010+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-14 13:21:12.035+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 13:21:12.220+0200 W/CERT_SVC( 2306): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-14 13:21:12.255+0200 E/rpm-installer( 2306): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-14 13:21:12.260+0200 E/rpm-installer( 2306): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-14 13:21:12.260+0200 E/rpm-installer( 2306): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-14 13:21:12.260+0200 E/rpm-installer( 2306): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-14 13:21:12.335+0200 E/PKGMGR_PARSER( 2306): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-14 13:21:12.340+0200 E/PKGMGR_PARSER( 2306): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-14 13:21:12.365+0200 E/PKGMGR_PARSER( 2306): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-14 13:21:12.460+0200 I/PRIVACY-MANAGER-CLIENT( 2306): SocketClient.cpp: SocketClient(37) > Client created
10-14 13:21:12.580+0200 I/efl-extension( 2306): efl_extension.c: eext_mod_init(40) > Init
10-14 13:21:12.585+0200 I/efl-extension( 2306): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-14 13:21:12.660+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-14 13:21:12.660+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 61
10-14 13:21:12.660+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 61
10-14 13:21:12.660+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-14 13:21:12.665+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-14 13:21:12.665+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-14 13:21:12.665+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-14 13:21:12.680+0200 E/PKGMGR_CERT( 2306): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-14 13:21:12.685+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[23070002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-14 13:21:12.715+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 13:21:12.760+0200 E/rpm-installer( 2306): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-14 13:21:12.770+0200 E/rpm-installer( 2306): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-14 13:21:12.785+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1860 pgid = 1860
10-14 13:21:12.815+0200 E/rpm-installer( 2306): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-14 13:21:12.820+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[23070002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-14 13:21:12.850+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-14 13:21:12.885+0200 E/rpm-installer( 2306): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-14 13:21:12.925+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1860
10-14 13:21:12.935+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.185
10-14 13:21:13.005+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 13:21:13.005+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 1591 pgid = -1
10-14 13:21:13.005+0200 W/AUL_PAD ( 1304): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-14 13:21:13.010+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 1591
10-14 13:21:13.020+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.186
10-14 13:21:13.630+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 13:21:13.630+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 13:21:13.645+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-14 13:21:13.680+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 13:21:13.680+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 13:21:13.740+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 13:21:13.740+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 13:21:13.740+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 13:21:13.740+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 13:21:13.740+0200 E/EFL     ( 2316): elementary<2316> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 13:21:13.775+0200 E/EFL     ( 2316): elementary<2316> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 13:21:13.775+0200 E/EFL     ( 2316): elementary<2316> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 13:21:13.785+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 13:21:13.835+0200 E/EFL     ( 2316): elementary<2316> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 13:21:13.845+0200 E/EFL     ( 2316): elementary<2316> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 13:21:13.845+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 13:21:13.845+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 13:21:13.845+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 13:21:13.845+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 13:21:13.845+0200 E/EFL     ( 2316): elementary<2316> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 13:21:13.845+0200 I/AUL_PAD ( 2316): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 13:21:14.030+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[23070002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-14 13:21:14.035+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-14 13:21:14.035+0200 W/W_HOME  ( 1063): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-14 13:21:14.070+0200 W/AUL_AMD (  532): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-14 13:21:14.085+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-14 13:21:14.085+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-14 13:21:14.085+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-14 13:21:14.085+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-14 13:21:14.085+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-14 13:21:14.085+0200 E/WMS     (  499): wms_db.c: wms_db_package_event_insert_record(177) > 
10-14 13:21:14.110+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-14 13:21:14.170+0200 E/PKGMGR_INFO( 2307): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-14 13:21:14.195+0200 E/PKGMGR_OBSERVER( 2307): pkg_observer.c: main(620) > OBSERVER end
10-14 13:21:14.200+0200 E/STARTER (  705): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-14 13:21:14.200+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-14 13:21:14.200+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2307]
10-14 13:21:14.240+0200 W/APPS    ( 1063): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-14 13:21:14.240+0200 W/APPS    ( 1063): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-14 13:21:14.305+0200 E/PKGMGR_INFO(  498): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-14 13:21:14.345+0200 E/EFL     ( 1063): evas_main<1063> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e1f0a0 is not stable during recalc loop
10-14 13:21:14.350+0200 E/EFL     ( 1063): evas_main<1063> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e1f0a0 is not stable during recalc loop
10-14 13:21:14.440+0200 I/efl-extension( 2317): efl_extension.c: eext_mod_init(40) > Init
10-14 13:21:14.520+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-14 13:21:14.525+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-14 13:21:14.575+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-14 13:21:14.580+0200 I/UXT     ( 2317): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 13:21:14.580+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-14 13:21:14.675+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-14 13:21:14.680+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 13:21:14.680+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 13:21:14.680+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 13:21:14.680+0200 E/EFL     ( 2317): elementary<2317> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 13:21:14.695+0200 E/EFL     ( 2317): elementary<2317> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 13:21:14.700+0200 E/EFL     ( 2317): elementary<2317> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 13:21:14.700+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 13:21:14.730+0200 E/EFL     ( 2317): elementary<2317> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 13:21:14.740+0200 E/EFL     ( 2317): elementary<2317> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 13:21:14.740+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 13:21:14.745+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 13:21:14.745+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 13:21:14.745+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 13:21:14.745+0200 E/EFL     ( 2317): elementary<2317> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 13:21:14.745+0200 I/AUL_PAD ( 2317): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 13:21:15.290+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-14 13:21:15.290+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-14 13:21:15.290+0200 E/rpm-installer( 2306): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-14 13:21:15.315+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2306]
10-14 13:21:15.410+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/2306/oom_score_adj failed
10-14 13:21:15.410+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 2306
10-14 13:21:15.645+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-14 13:21:15.645+0200 E/PKGMGR_SERVER( 2305): pkgmgr-server.c: main(2221) > package manager server terminated.
10-14 13:21:17.660+0200 W/AUL     ( 2381): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-14 13:21:17.665+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 0
10-14 13:21:17.685+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-14 13:21:17.700+0200 I/AUL_AMD (  532): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-14 13:21:17.700+0200 E/AUL_AMD (  532): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-14 13:21:17.700+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(1710) > caller pid : 2381
10-14 13:21:17.715+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-14 13:21:17.715+0200 W/AUL_AMD (  532): amd_launch.c: _start_app(2124) > pad pid(-5)
10-14 13:21:17.715+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-14 13:21:17.715+0200 W/AUL_PAD ( 1304): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-14 13:21:17.715+0200 W/AUL_PAD ( 1304): launchpad.c: __send_result_to_caller(272) > Check app launching
10-14 13:21:17.790+0200 I/efl-extension( 2316): efl_extension.c: eext_mod_init(40) > Init
10-14 13:21:17.795+0200 I/UXT     ( 2316): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-14 13:21:17.795+0200 I/CAPI_APPFW_APPLICATION( 2316): app_main.c: ui_app_main(704) > app_efl_main
10-14 13:21:17.800+0200 I/CAPI_APPFW_APPLICATION( 2316): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 13:21:17.820+0200 W/AUL     ( 2381): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2316)
10-14 13:21:17.850+0200 E/RESOURCED(  536): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-14 13:21:18.220+0200 W/CRASH_MANAGER( 2392): worker.c: worker_job(1205) > 1102316646174150798007
