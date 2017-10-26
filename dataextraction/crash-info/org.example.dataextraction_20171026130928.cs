S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18562
Date: 2017-10-26 13:09:28+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x41fd9e70, r1   = 0x00000001
r2   = 0x4059d250, r3   = 0x99d78e00
r4   = 0xbea524d4, r5   = 0x4144ad30
r6   = 0x00000233, r7   = 0xbea52400
r8   = 0xbea524a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x00000021, sp   = 0xbea523d0
lr   = 0x404e5ab4, pc   = 0x41646754
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     14388 KB
Buffers:     44372 KB
Cached:     179324 KB
VmPeak:      64776 KB
VmSize:      64772 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11924 KB
VmRSS:       11920 KB
VmData:      11524 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18562 TID = 18562
18562 18662 

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
4147d000 41481000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4148a000 4148c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
41495000 4149b000 r-xp /usr/lib/libappsvc.so.0.1.0
414a3000 414c7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d0000 4159f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415b5000 415bf000 r-xp /lib/libnss_files-2.13.so
41643000 41648000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
41659000 4168b000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41694000 41698000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
416a1000 416a9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
416aa000 416cb000 r-xp /usr/lib/libefl-extension.so.0.1.0
416d4000 4170e000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41717000 41730000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41738000 4173d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41745000 4176f000 r-xp /usr/lib/libsensor.so.1.9.6
41778000 4178a000 r-xp /usr/lib/libefl-assist.so.0.1.0
41792000 4184a000 r-xp /usr/lib/libcairo.so.2.11200.14
41855000 41858000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41860000 41866000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4186f000 41877000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4187f000 41889000 r-xp /usr/lib/libsensord-shared.so
41892000 418a4000 r-xp /usr/lib/libtts.so
418ac000 418ce000 r-xp /usr/lib/libui-extension.so.0.1.0
418d7000 418de000 r-xp /usr/lib/libtbm.so.1.0.0
418e6000 418f4000 r-xp /usr/lib/libGLESv2.so.2.0
418fd000 418fe000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41907000 4190d000 r-xp /usr/lib/libxcb-render.so.0.0.0
41915000 41918000 r-xp /usr/lib/libEGL.so.1.4
41920000 4192d000 r-xp /usr/lib/libail.so.0.1.0
41936000 41a73000 r-xp /usr/lib/libicui18n.so.51.1
41a83000 41b67000 r-xp /usr/lib/libicuuc.so.51.1
41b7c000 41b98000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41ba1000 41ba4000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41bac000 41bad000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41bb6000 41bbe000 r-xp /usr/lib/libdrm.so.2.4.0
41bc6000 41bc8000 r-xp /usr/lib/libdri2.so.0.0.0
41bd0000 41bd7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41be0000 41be2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41bea000 41bf1000 r-xp /usr/lib/libminizip.so.1.0.0
41bf9000 41bff000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41c07000 41c0c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41c14000 41c35000 r-xp /usr/lib/libexif.so.12.3.3
41c48000 41c4a000 r-xp /usr/lib/libttrace.so.1.1
41c52000 41c57000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41c5f000 41d29000 r-xp /usr/lib/libCOREGL.so.4.0
41ee4000 41ffa000 rw-p [heap]
43784000 43f83000 rw-p [stack:18662]
bea32000 bea53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18562)
Call Stack Count: 9
 0: start_bt_server + 0x13 (0x41646754) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3754
 1: app_create + 0x38 (0x41645039) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2039
 2: (0x414409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x41644f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
 6: (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: bluetooth_screen + 0xd7 (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:29.085+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:29.100+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:09:29.110+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:09:29.125+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:09:29.130+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:29.130+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:29.135+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 13:09:29.140+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:09:29.140+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 790820476, next duetime: 1509016189
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(790820476)
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509016189)
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:09:49 (UTC).
10-26 13:09:29.150+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:29.590+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:09:29.755+0200 E/EFL     (18667): elementary<18667> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:09:29.755+0200 E/EFL     (18667): elementary<18667> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:09:29.815+0200 E/EFL     (18667): elementary<18667> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:09:29.815+0200 E/EFL     (18667): elementary<18667> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:09:29.910+0200 E/EFL     (18667): elementary<18667> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:09:29.910+0200 E/EFL     (18667): elementary<18667> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:09:29.950+0200 E/EFL     (18667): elementary<18667> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:09:29.985+0200 E/EFL     (18667): elementary<18667> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:09:30.000+0200 E/EFL     (18667): elementary<18667> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:09:30.280+0200 E/EFL     (18667): elementary<18667> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:09:30.325+0200 E/EFL     (18667): elementary<18667> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:09:30.325+0200 E/EFL     (18667): elementary<18667> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:09:30.565+0200 E/EFL     (18667): elementary<18667> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:09:30.605+0200 E/EFL     (18667): elementary<18667> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:09:30.610+0200 E/EFL     (18667): elementary<18667> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:09:30.620+0200 E/EFL     (18667): elementary<18667> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:09:30.625+0200 E/EFL     (18667): elementary<18667> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:09:30.625+0200 E/EFL     (18667): elementary<18667> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:09:30.630+0200 E/EFL     (18667): elementary<18667> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:09:30.630+0200 I/AUL_PAD (18667): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:09:34.100+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 13:09:35.515+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185416461741509016150
10-26 13:09:37.370+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185486461741509016151
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:46.025+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:46.050+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:46.060+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>64</color> bpm</color>][0;m
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:46.060+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:48.995+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 13:09:49.010+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[790820476] is expired.
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 790820476, next duetime: 1509016209
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:49.035+0200 E/RESOURCED(  566): freezer-process.c: freezer_process_pid_set(147) > Cant find process info for 732
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:10:09 (UTC).
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:49.035+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 13:09:49.040+0200 E/ALARM_MANAGER(  732): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [790820476]
10-26 13:09:49.040+0200 W/STARTER (  732): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(1027) > [__starter_clock_mgr_homescreen_alarm_cb:1027] homescreen alarm timer expired [790820476]
10-26 13:09:49.050+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 13:09:49.055+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 13:09:49.060+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:49.060+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 13:09:49.070+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 13:09:49.075+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(769), cmd(0)
10-26 13:09:49.075+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: PAUSED
10-26 13:09:49.075+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 13:09:49.075+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : show_clock
10-26 13:09:49.075+0200 W/W_HOME  (  769): main.c: _app_control(1746) > Show clock operation
10-26 13:09:49.075+0200 W/W_HOME  (  769): gesture.c: _clock_show(245) > clock show
10-26 13:09:49.075+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 13:09:49.080+0200 W/W_HOME  (  769): gesture.c: _clock_show(260) > home raise
10-26 13:09:49.080+0200 E/W_HOME  (  769): gesture.c: gesture_win_aux_set(415) > wm.policy.win.do.not.use.deiconify.approve:-1
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(790820476)
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:45:00 (UTC).
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:09:49.080+0200 E/ALARM_MANAGER(  494): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[790820476] is removed.
10-26 13:09:49.085+0200 W/W_HOME  (  769): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
10-26 13:09:49.085+0200 W/W_HOME  (  769): gesture.c: _clock_show(263) > home raise done
10-26 13:09:49.085+0200 W/W_HOME  (  769): gesture.c: _clock_show(270) > show clock
10-26 13:09:49.090+0200 W/W_HOME  (  769): move.c: move_back_to_home_no_anim(280) > back to home no anim
10-26 13:09:49.090+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 13:09:49.105+0200 W/W_HOME  (  769): move.c: _scroller_down_done(494) > down signal done
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,hide
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:49.105+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:49.110+0200 W/W_INDICATOR(  735): windicator_dbus.c: _windicator_dbus_home_button_clicked_cb(355) > [_windicator_dbus_home_button_clicked_cb:355] show 1, scroll 0
10-26 13:09:49.115+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:49.115+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,hide
10-26 13:09:49.115+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80001
10-26 13:09:49.115+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80001
10-26 13:09:49.120+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 0
10-26 13:09:49.130+0200 E/APPS    (  769): apps_main.c: apps_main_pause(602) >  paused already
10-26 13:09:50.075+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:09:50.075+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:09:53.970+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185206461741509016152
10-26 13:09:54.945+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11185646461741509016154
10-26 13:09:56.710+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:10:03.350+0200 E/PKGMGR_SERVER(18891): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:10:03.450+0200 E/PKGMGR_SERVER(18891): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_918553268], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[aMAxdICHE06P4GyDCCaaD0CIyjI=], backend_flag=[0]
10-26 13:10:03.465+0200 E/PKGMGR_SERVER(18892): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-26 13:10:03.470+0200 E/PKGMGR  (18889): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-26 13:10:03.555+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:10:03.565+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:10:03.575+0200 E/PKGMGR_SERVER(18892): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-26 13:10:03.600+0200 E/PKGMGR_SERVER(18891): pkgmgr-server.c: sighandler(409) > child NORMAL exit [18892]
10-26 13:10:05.650+0200 E/PKGMGR_SERVER(18891): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:10:05.650+0200 E/PKGMGR_SERVER(18891): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:10:06.040+0200 E/PKGMGR  (18982): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-26 13:10:06.245+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:10:06.340+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_921452620], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_921452620' '-r' 'org.example.dataextraction'], cookie=[V+0XPQbootMKGsKI5Q6Lz/DS3VQ=], backend_flag=[0]
10-26 13:10:06.345+0200 E/PKGMGR  (18985): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-26 13:10:06.345+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-26 13:10:06.350+0200 E/PKGMGR  (18982): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[189820002]
10-26 13:10:06.355+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:10:06.360+0200 E/PKGMGR_SERVER(18986): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-26 13:10:06.375+0200 E/PKGMGR_SERVER(18987): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:10:06.450+0200 E/PKGMGR_OBSERVER(18987): pkg_observer.c: main(601) > OBSERVER start
10-26 13:10:06.485+0200 E/rpm-installer(18986): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:10:06.485+0200 E/rpm-installer(18986): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:10:06.485+0200 E/rpm-installer(18986): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:10:06.715+0200 E/PKGMGR_OBSERVER(18987): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[189870002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-26 13:10:06.750+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-26 13:10:06.750+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-26 13:10:06.765+0200 E/PKGMGR_OBSERVER(18987): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[189870002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:10:06.795+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-26 13:10:06.800+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-26 13:10:06.840+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-26 13:10:07.020+0200 W/CERT_SVC(18986): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:10:07.040+0200 E/rpm-installer(18986): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-26 13:10:07.040+0200 E/rpm-installer(18986): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-26 13:10:07.045+0200 E/rpm-installer(18986): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-26 13:10:07.065+0200 E/PKGMGR_PARSER(18986): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:10:07.090+0200 I/PRIVACY-MANAGER-CLIENT(18986): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: mainloop(227) > Got incoming connection
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-CLIENT(18986): SocketStream.h: SocketStream(31) > Created
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-CLIENT(18986): SocketConnection.h: SocketConnection(44) > Created
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-CLIENT(18986): SocketClient.cpp: connect(62) > Client connected
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(253) > Starting connection thread
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketStream.h: SocketStream(31) > Created
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketConnection.h: SocketConnection(44) > Created
10-26 13:10:07.095+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(304) > Calling service
10-26 13:10:07.100+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(307) > Removing client
10-26 13:10:07.100+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(311) > Call served
10-26 13:10:07.105+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(262) > Client serviced
10-26 13:10:07.105+0200 I/PRIVACY-MANAGER-CLIENT(18986): SocketClient.cpp: disconnect(72) > Client disconnected
10-26 13:10:07.115+0200 E/PKGMGR_CERT(18986): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-26 13:10:07.125+0200 E/PKGMGR_CERT(18986): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-26 13:10:07.140+0200 E/PKGMGR_CERT(18986): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-26 13:10:07.230+0200 E/rpm-installer(18986): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-26 13:10:07.235+0200 E/PKGMGR_OBSERVER(18987): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[189870002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-26 13:10:07.240+0200 E/PKGMGR_OBSERVER(18987): pkg_observer.c: main(620) > OBSERVER end
10-26 13:10:07.250+0200 E/APPS    (  769): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-26 13:10:07.250+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-26 13:10:07.255+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:10:07.255+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: sighandler(409) > child NORMAL exit [18987]
10-26 13:10:07.265+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-26 13:10:07.305+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-26 13:10:07.350+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-26 13:10:07.350+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:10:07.350+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:10:07.350+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:10:08.060+0200 E/rpm-installer(18986): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:10:08.060+0200 E/rpm-installer(18986): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:10:08.060+0200 E/rpm-installer(18986): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:10:08.075+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: sighandler(409) > child NORMAL exit [18986]
10-26 13:10:08.155+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/18986/oom_score_adj failed
10-26 13:10:08.155+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 18986
10-26 13:10:08.190+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:10:08.655+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:10:08.660+0200 E/PKGMGR_SERVER(18985): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:10:09.320+0200 E/PKGMGR  (19042): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 13:10:09.540+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:10:09.640+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_924712668], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_924712668' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[XejCGS5MO2HlrlGd6P1qny6jwqI=], backend_flag=[0]
10-26 13:10:09.650+0200 E/PKGMGR  (19044): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 13:10:09.655+0200 E/PKGMGR  (19042): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[190420002]
10-26 13:10:09.655+0200 E/PKGMGR_SERVER(19045): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 13:10:09.655+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:10:09.665+0200 E/PKGMGR_SERVER(19046): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:10:09.735+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: main(601) > OBSERVER start
10-26 13:10:09.790+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:10:09.790+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:10:09.795+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:10:09.925+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 13:10:09.940+0200 E/rpm-installer(19045): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 13:10:09.945+0200 E/rpm-installer(19045): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 13:10:09.945+0200 E/rpm-installer(19045): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 13:10:09.950+0200 E/rpm-installer(19045): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 13:10:09.950+0200 E/rpm-installer(19045): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 13:10:10.060+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[190460002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 13:10:10.080+0200 E/APPS    (  769): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 13:10:10.080+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 13:10:10.095+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 13:10:10.110+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[190460002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:10:10.135+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 13:10:10.190+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:10:10.365+0200 W/CERT_SVC(19045): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:10:10.395+0200 E/rpm-installer(19045): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 13:10:10.400+0200 E/rpm-installer(19045): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 13:10:10.400+0200 E/rpm-installer(19045): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 13:10:10.400+0200 E/rpm-installer(19045): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 13:10:10.500+0200 E/PKGMGR_PARSER(19045): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 13:10:10.510+0200 E/PKGMGR_PARSER(19045): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:10:10.540+0200 E/PKGMGR_PARSER(19045): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 13:10:10.635+0200 I/PRIVACY-MANAGER-CLIENT(19045): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:10:10.760+0200 I/efl-extension(19045): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:10.765+0200 I/efl-extension(19045): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 13:10:10.880+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 13:10:10.895+0200 E/PKGMGR_CERT(19045): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 13:10:10.905+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[190460002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 13:10:10.935+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:10:10.985+0200 E/rpm-installer(19045): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 13:10:11.000+0200 E/rpm-installer(19045): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 13:10:11.005+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18667 pgid = 18667
10-26 13:10:11.050+0200 E/rpm-installer(19045): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 13:10:11.095+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18667
10-26 13:10:11.115+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.552
10-26 13:10:11.130+0200 E/rpm-installer(19045): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 13:10:11.140+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[190460002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 13:10:11.225+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:10:11.225+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18416 pgid = -1
10-26 13:10:11.225+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:10:11.230+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:10:11.240+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18416
10-26 13:10:11.255+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.553
10-26 13:10:11.650+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:10:12.145+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[190460002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 13:10:12.165+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 13:10:12.165+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 13:10:12.210+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 13:10:12.265+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 13:10:12.265+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:10:12.265+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:10:12.265+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:10:12.265+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 13:10:12.270+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 13:10:12.295+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 13:10:12.320+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 13:10:12.330+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 13:10:12.340+0200 E/PKGMGR_INFO(19046): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 13:10:12.360+0200 E/PKGMGR_OBSERVER(19046): pkg_observer.c: main(620) > OBSERVER end
10-26 13:10:12.395+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:10:12.395+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: sighandler(409) > child NORMAL exit [19046]
10-26 13:10:12.410+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 13:10:12.420+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 13:10:13.420+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:10:13.420+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:10:13.420+0200 E/rpm-installer(19045): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:10:13.450+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: sighandler(409) > child NORMAL exit [19045]
10-26 13:10:13.530+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/19045/oom_score_adj failed
10-26 13:10:13.530+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 19045
10-26 13:10:13.530+0200 E/EFL     (19057): elementary<19057> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:13.530+0200 E/EFL     (19057): elementary<19057> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:13.635+0200 E/EFL     (19057): elementary<19057> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:13.640+0200 E/EFL     (19057): elementary<19057> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:13.650+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:10:13.650+0200 E/PKGMGR_SERVER(19044): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:10:13.740+0200 E/EFL     (19057): elementary<19057> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:13.755+0200 E/EFL     (19057): elementary<19057> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:13.755+0200 E/EFL     (19057): elementary<19057> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:13.765+0200 E/EFL     (19057): elementary<19057> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:13.770+0200 E/EFL     (19057): elementary<19057> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:13.875+0200 E/EFL     (19057): elementary<19057> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:13.900+0200 E/EFL     (19057): elementary<19057> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:13.905+0200 E/EFL     (19057): elementary<19057> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:14.115+0200 E/EFL     (19057): elementary<19057> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:14.130+0200 E/EFL     (19057): elementary<19057> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:14.130+0200 E/EFL     (19057): elementary<19057> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:14.130+0200 E/EFL     (19057): elementary<19057> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:14.130+0200 E/EFL     (19057): elementary<19057> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:14.130+0200 E/EFL     (19057): elementary<19057> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:14.130+0200 E/EFL     (19057): elementary<19057> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:14.135+0200 I/AUL_PAD (19057): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:10:15.285+0200 I/efl-extension(19058): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:15.370+0200 E/EFL     (19058): elementary<19058> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:15.370+0200 E/EFL     (19058): elementary<19058> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:15.445+0200 E/EFL     (19058): elementary<19058> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:15.455+0200 I/UXT     (19058): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:15.455+0200 E/EFL     (19058): elementary<19058> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:15.505+0200 E/EFL     (19058): elementary<19058> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:15.510+0200 E/EFL     (19058): elementary<19058> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:15.510+0200 E/EFL     (19058): elementary<19058> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:15.510+0200 E/EFL     (19058): elementary<19058> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:15.510+0200 E/EFL     (19058): elementary<19058> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:15.540+0200 E/EFL     (19058): elementary<19058> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:15.550+0200 E/EFL     (19058): elementary<19058> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:15.560+0200 E/EFL     (19058): elementary<19058> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:15.680+0200 E/EFL     (19058): elementary<19058> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:15.695+0200 E/EFL     (19058): elementary<19058> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:15.695+0200 E/EFL     (19058): elementary<19058> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:15.695+0200 E/EFL     (19058): elementary<19058> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:15.700+0200 E/EFL     (19058): elementary<19058> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:15.700+0200 E/EFL     (19058): elementary<19058> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:15.700+0200 E/EFL     (19058): elementary<19058> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:15.700+0200 I/AUL_PAD (19058): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:10:17.250+0200 W/AUL     (19120): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:10:17.255+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:10:17.275+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 13:10:17.290+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 13:10:17.290+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:10:17.290+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 19120
10-26 13:10:17.305+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:10:17.310+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:10:17.310+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:10:17.325+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:10:17.325+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:10:17.390+0200 I/efl-extension(19057): efl_extension.c: eext_mod_init(40) > Init
10-26 13:10:17.395+0200 I/UXT     (19057): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:10:17.400+0200 I/CAPI_APPFW_APPLICATION(19057): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:10:17.410+0200 I/CAPI_APPFW_APPLICATION(19057): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:10:17.410+0200 W/AUL     (19120): launch.c: app_request_to_launchpad(282) > request cmd(0) result(19057)
10-26 13:10:17.420+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:10:17.580+0200 I/Bluetooth(19057): [bt_initialize] success.
10-26 13:10:18.420+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:10:18.420+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:10:18.460+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 19057 pgid = 19057
10-26 13:10:18.480+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.559
10-26 13:10:18.530+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:10:18.535+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19057
10-26 13:10:18.545+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.560
10-26 13:10:18.565+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:18.565+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:18.565+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:18.565+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:18.565+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:18.565+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:18.570+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:10:18.570+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:10:18.570+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:10:18.990+0200 E/EFL     (19125): elementary<19125> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:10:18.990+0200 E/EFL     (19125): elementary<19125> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:10:19.025+0200 E/EFL     (19125): elementary<19125> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:10:19.025+0200 E/EFL     (19125): elementary<19125> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:10:19.075+0200 E/EFL     (19125): elementary<19125> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:10:19.075+0200 E/EFL     (19125): elementary<19125> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:10:19.080+0200 E/EFL     (19125): elementary<19125> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:10:19.080+0200 E/EFL     (19125): elementary<19125> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:10:19.085+0200 E/EFL     (19125): elementary<19125> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:10:19.125+0200 E/EFL     (19125): elementary<19125> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:10:19.135+0200 E/EFL     (19125): elementary<19125> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:10:19.135+0200 E/EFL     (19125): elementary<19125> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:10:19.245+0200 E/EFL     (19125): elementary<19125> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:10:19.265+0200 E/EFL     (19125): elementary<19125> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:10:19.265+0200 E/EFL     (19125): elementary<19125> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:10:19.265+0200 E/EFL     (19125): elementary<19125> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:10:19.265+0200 E/EFL     (19125): elementary<19125> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:10:19.265+0200 E/EFL     (19125): elementary<19125> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:10:19.265+0200 E/EFL     (19125): elementary<19125> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:10:19.270+0200 I/AUL_PAD (19125): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:10:19.940+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:10:20.180+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 1118562646174150901616
