S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10630
Date: 2017-11-10 13:26:23+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0xe46a8d00
r4   = 0xbedbc504, r5   = 0x41441980
r6   = 0x00000249, r7   = 0xbedbc440
r8   = 0xbedbc4d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e6120, sp   = 0xbedbc428
lr   = 0x41644cb7, pc   = 0x41646210
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     65176 KB
Buffers:     38696 KB
Cached:     160152 KB
VmPeak:      94644 KB
VmSize:      92580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17712 KB
VmRSS:       17708 KB
VmData:      39204 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23076 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10630 TID = 10630
10630 10752 10763 10764 

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
416a0000 416c1000 r-xp /usr/lib/libefl-extension.so.0.1.0
416ca000 41704000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4170d000 41726000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4172e000 41733000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4173b000 41765000 r-xp /usr/lib/libsensor.so.1.9.6
4176e000 41826000 r-xp /usr/lib/libcairo.so.2.11200.14
41831000 41834000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
4183c000 41842000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4184b000 41853000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4185b000 41865000 r-xp /usr/lib/libsensord-shared.so
4186e000 4187c000 r-xp /usr/lib/libGLESv2.so.2.0
41885000 41886000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4188f000 41895000 r-xp /usr/lib/libxcb-render.so.0.0.0
4189d000 418a0000 r-xp /usr/lib/libEGL.so.1.4
418a8000 418b5000 r-xp /usr/lib/libail.so.0.1.0
418be000 419fb000 r-xp /usr/lib/libicui18n.so.51.1
41a0b000 41aef000 r-xp /usr/lib/libicuuc.so.51.1
41b04000 41b20000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b29000 41b30000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41b39000 41b3b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41b43000 41b4a000 r-xp /usr/lib/libminizip.so.1.0.0
41b52000 41c1c000 r-xp /usr/lib/libCOREGL.so.4.0
41c2e000 41c39000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41c42000 41c47000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41c55000 41c5d000 r-xp /usr/lib/libdrm.so.2.4.0
41c65000 41c6c000 rw-p [heap]
41c6c000 41d82000 rw-p [heap]
4350c000 43d0b000 rw-p [stack:10752]
43d0b000 43d12000 r-xp /usr/lib/libtbm.so.1.0.0
43d1a000 43d1c000 r-xp /usr/lib/libdri2.so.0.0.0
43dbf000 43dc0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43dc8000 43dca000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43dd2000 43dd5000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43ddd000 43dde000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
44001000 44800000 rw-p [stack:10763]
44801000 45000000 rw-p [stack:10764]
bed9c000 bedbd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10630)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x41646210) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3210
 1: app_terminate + 0x26 (0x41644cb7) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1cb7
 2: (0x41440af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41644c3f) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1c3f
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
p: OnSendMessage(126) > MessagePort OnSendMessage
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
11-10 13:26:05.200+0200 W/CRASH_MANAGER(10383): worker.c: worker_job(1205) > 11105526461741510313165
11-10 13:26:05.220+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:05.235+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
11-10 13:26:05.245+0200 E/PKGMGR_SERVER(10684): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
11-10 13:26:05.285+0200 E/PKGMGR_SERVER(10666): pkgmgr-server.c: sighandler(409) > child NORMAL exit [10684]
11-10 13:26:05.375+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
11-10 13:26:05.395+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:26:05.395+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:26:05.410+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10552 pgid = 10552
11-10 13:26:05.435+0200 W/PROCESSMGR(  408): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
11-10 13:26:05.435+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
11-10 13:26:05.435+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.440+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.440+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.470+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
11-10 13:26:05.470+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
11-10 13:26:05.470+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.470+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
11-10 13:26:05.470+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: RESUME State: PAUSED
11-10 13:26:05.470+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_resume(223) > app_appcore_resume
11-10 13:26:05.470+0200 W/W_HOME  (  765): main.c: _appcore_resume_cb(687) > appcore resume
11-10 13:26:05.470+0200 W/W_HOME  (  765): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
11-10 13:26:05.470+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.475+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.475+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:05.475+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
11-10 13:26:05.510+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
11-10 13:26:05.510+0200 I/WATCH_CORE(  816): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
11-10 13:26:05.510+0200 I/CAPI_WATCH_APPLICATION(  816): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
11-10 13:26:05.565+0200 W/AUL_PAD ( 1194): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
11-10 13:26:05.570+0200 I/AUL_AMD (  504): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10552
11-10 13:26:05.585+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.600
11-10 13:26:05.880+0200 I/MALI    (  765): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
11-10 13:26:06.250+0200 W/AUL     (10750): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
11-10 13:26:06.255+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 0
11-10 13:26:06.270+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
11-10 13:26:06.280+0200 I/AUL_AMD (  504): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
11-10 13:26:06.280+0200 E/AUL_AMD (  504): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
11-10 13:26:06.280+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(1710) > caller pid : 10750
11-10 13:26:06.295+0200 E/RESOURCED(  514): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
11-10 13:26:06.300+0200 E/RESOURCED(  514): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
11-10 13:26:06.300+0200 W/AUL_AMD (  504): amd_launch.c: _start_app(2124) > pad pid(-5)
11-10 13:26:06.300+0200 W/AUL_PAD ( 1194): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
11-10 13:26:06.300+0200 W/AUL_PAD ( 1194): launchpad.c: __send_result_to_caller(272) > Check app launching
11-10 13:26:06.360+0200 I/efl-extension(10630): efl_extension.c: eext_mod_init(40) > Init
11-10 13:26:06.360+0200 I/CAPI_APPFW_APPLICATION(10630): app_main.c: ui_app_main(704) > app_efl_main
11-10 13:26:06.370+0200 I/CAPI_APPFW_APPLICATION(10630): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
11-10 13:26:06.410+0200 W/AUL     (10750): launch.c: app_request_to_launchpad(282) > request cmd(0) result(10630)
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:06.480+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.530+0200 I/Bluetooth(10630): [bt_initialize] success.
11-10 13:26:06.560+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:26:06.565+0200 I/Bluetooth(10630): [bt_adapter_get_state] success.
11-10 13:26:06.585+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [true][0m
11-10 13:26:06.595+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:06.605+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 765
11-10 13:26:06.615+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:26:06.615+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1779]   bundle_add_str() .. [0xffffffea][0m
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:06.620+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.625+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:26:06.625+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:26:06.625+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1779]   [MUSIC_PLAYER_EVENT][0m
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:06.630+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:06.635+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.635+0200 W/W_HOME  (  765): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
11-10 13:26:06.635+0200 E/W_HOME  (  765): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
11-10 13:26:06.635+0200 E/PKGMGR_SERVER(10666): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
11-10 13:26:06.635+0200 E/PKGMGR_SERVER(10666): pkgmgr-server.c: main(2221) > package manager server terminated.
11-10 13:26:06.725+0200 I/TIZEN_N_SOUND_MANAGER( 1779): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
11-10 13:26:06.725+0200 E/TIZEN_N_SOUND_MANAGER( 1779): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
11-10 13:26:06.725+0200 E/EFL     (10630): ecore_evas<10630> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
11-10 13:26:06.725+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1779]   sound_manager_get_volume() .. [0xfe6a0001][0m
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:06.725+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:06.730+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:06.995+0200 W/AUL_AMD (  504): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
11-10 13:26:07.065+0200 I/APP_CORE(10630): appcore-efl.c: __do_app(429) > [APP 10630] Event: RESET State: CREATED
11-10 13:26:07.065+0200 I/CAPI_APPFW_APPLICATION(10630): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
11-10 13:26:07.100+0200 W/W_HOME  (  765): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
11-10 13:26:07.100+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.105+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.110+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.150+0200 I/APP_CORE(10630): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
11-10 13:26:07.150+0200 I/APP_CORE(10630): appcore-efl.c: __do_app(474) > [APP 10630] Initial Launching, call the resume_cb
11-10 13:26:07.150+0200 I/CAPI_APPFW_APPLICATION(10630): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
11-10 13:26:07.165+0200 W/APP_CORE(10630): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00002
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.265+0200 W/W_HOME  (  765): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
11-10 13:26:07.265+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: PAUSE State: RUNNING
11-10 13:26:07.265+0200 I/CAPI_APPFW_APPLICATION(  765): app_main.c: app_appcore_pause(202) > app_appcore_pause
11-10 13:26:07.265+0200 W/W_HOME  (  765): main.c: _appcore_pause_cb(696) > appcore pause
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.265+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:07.280+0200 W/AUL_AMD (  504): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
11-10 13:26:07.280+0200 W/AUL_AMD (  504): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:07.300+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
11-10 13:26:07.305+0200 I/MESSAGE_PORT(  486): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
11-10 13:26:07.305+0200 E/CAPI_APPFW_APP_CONTROL( 1779): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
11-10 13:26:07.305+0200 W/MUSIC_CONTROL_SERVICE( 1779): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1779]   [com.samsung.w-home]register msg port [false][0m
11-10 13:26:07.360+0200 I/APP_CORE(10630): appcore-efl.c: __do_app(429) > [APP 10630] Event: RESUME State: RUNNING
11-10 13:26:07.380+0200 W/wnotib  (  765): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
11-10 13:26:07.380+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:07.380+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:07.505+0200 E/RESOURCED(  514): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.604
11-10 13:26:07.515+0200 E/EFL     (10630): elementary<10630> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:07.520+0200 E/EFL     (10630): elementary<10630> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:07.525+0200 E/EFL     (10630): elementary<10630> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:07.525+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:07.535+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10630
11-10 13:26:07.540+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:07.590+0200 E/AUL     (  504): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
11-10 13:26:07.675+0200 E/EFL     (10766): elementary<10766> elm_main.c:558 elm_quicklaunch_init() eet_init done.
11-10 13:26:07.675+0200 E/EFL     (10766): elementary<10766> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
11-10 13:26:07.705+0200 E/EFL     (10766): elementary<10766> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
11-10 13:26:07.720+0200 E/EFL     (10766): elementary<10766> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
11-10 13:26:07.725+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 14
11-10 13:26:07.735+0200 W/AUL_AMD (  504): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10630
11-10 13:26:07.755+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 12
11-10 13:26:07.790+0200 E/EFL     (10766): elementary<10766> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
11-10 13:26:07.790+0200 E/EFL     (10766): elementary<10766> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
11-10 13:26:07.795+0200 E/EFL     (10766): elementary<10766> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
11-10 13:26:07.795+0200 E/EFL     (10766): elementary<10766> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
11-10 13:26:07.795+0200 E/EFL     (10766): elementary<10766> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
11-10 13:26:07.815+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:26:07.830+0200 E/EFL     (10766): elementary<10766> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
11-10 13:26:07.830+0200 E/EFL     (10766): elementary<10766> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
11-10 13:26:07.835+0200 E/EFL     (10766): elementary<10766> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
11-10 13:26:07.875+0200 E/EFL     (10766): elementary<10766> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
11-10 13:26:07.890+0200 E/EFL     (10766): elementary<10766> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
11-10 13:26:07.890+0200 E/EFL     (10766): elementary<10766> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
11-10 13:26:07.895+0200 E/EFL     (10766): elementary<10766> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
11-10 13:26:07.895+0200 E/EFL     (10766): elementary<10766> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
11-10 13:26:07.895+0200 E/EFL     (10766): elementary<10766> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
11-10 13:26:07.895+0200 E/EFL     (10766): elementary<10766> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
11-10 13:26:07.895+0200 I/AUL_PAD (10766): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
11-10 13:26:08.040+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:09.040+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:09.445+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:26:10.040+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:11.040+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:12.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:12.325+0200 I/APP_CORE(  765): appcore-efl.c: __do_app(429) > [APP 765] Event: MEM_FLUSH State: PAUSED
11-10 13:26:13.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:14.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:15.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:16.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:17.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:18.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:19.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:20.045+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:20.150+0200 W/WECONN  (  501): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
11-10 13:26:21.050+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:22.050+0200 I/INFO_TAG(10630): SENSOR_EVENT HEART RATE < 40 : 0
11-10 13:26:23.050+0200 E/EFL     (10630): elementary<10630> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
11-10 13:26:23.060+0200 E/EFL     (10630): elementary<10630> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
11-10 13:26:23.220+0200 W/WATCH_CORE(  816): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
11-10 13:26:23.225+0200 W/W_HOME  (  765): dbus.c: _dbus_message_recv_cb(204) > LCD off
11-10 13:26:23.225+0200 W/W_HOME  (  765): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
11-10 13:26:23.225+0200 W/W_HOME  (  765): gesture.c: _manual_render_disable_timer_del(155) > timer del
11-10 13:26:23.225+0200 W/W_HOME  (  765): gesture.c: _manual_render_enable(136) > 1
11-10 13:26:23.225+0200 W/W_HOME  (  765): event_manager.c: _lcd_off_cb(704) > lcd state: 0
11-10 13:26:23.225+0200 W/W_HOME  (  765): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
11-10 13:26:23.225+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
11-10 13:26:23.225+0200 W/STARTER (  720): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
11-10 13:26:23.225+0200 E/STARTER (  720): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
11-10 13:26:23.225+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
11-10 13:26:23.225+0200 W/STARTER (  720): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
11-10 13:26:23.470+0200 W/SHealth_Common(  837): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:26:23.500+0200 W/STARTER (  720): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
11-10 13:26:23.500+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
11-10 13:26:23.500+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
11-10 13:26:23.500+0200 W/STARTER (  720): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
11-10 13:26:23.500+0200 E/ALARM_MANAGER(  720): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(10-11-2017, 13:26:44), repeat(1), interval(20), type(-1073741822)
11-10 13:26:23.510+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [720].
11-10 13:26:23.520+0200 W/SHealth_Common( 1107): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
11-10 13:26:23.520+0200 E/EFL     (10630): elementary<10630> elc_naviframe.c:1211 _on_item_show_finished() item show finished
11-10 13:26:23.535+0200 I/APP_CORE(10630): appcore-efl.c: __do_app(429) > [APP 10630] Event: PAUSE State: RUNNING
11-10 13:26:23.535+0200 I/CAPI_APPFW_APPLICATION(10630): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1875213999, next duetime: 1510313204
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1875213999)
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1510317900), due_time(1510313204)
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 10-11-2017, 11:26:44 (UTC).
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
11-10 13:26:23.570+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-10 13:26:23.585+0200 E/ALARM_MANAGER(  481): alarm-manager.c: __save_module_log(1765) > The file is not ready.
11-10 13:26:23.600+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(645) > __request_handler: 22
11-10 13:26:23.600+0200 W/AUL_AMD (  504): amd_request.c: __request_handler(916) > app status : 4
11-10 13:26:23.600+0200 W/SHealth_Service( 1107): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
11-10 13:26:23.650+0200 E/APP_CORE(10630): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
11-10 13:26:23.650+0200 I/APP_CORE(10630): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
11-10 13:26:23.650+0200 I/CAPI_APPFW_APPLICATION(10630): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
11-10 13:26:23.660+0200 I/Bluetooth(10630): [bt_deinitialize] success.
11-10 13:26:23.770+0200 W/CRASH_MANAGER(10383): worker.c: worker_job(1205) > 1110630646174151031318
