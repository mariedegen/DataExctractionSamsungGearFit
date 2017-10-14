S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 21033
Date: 2017-10-12 17:57:52+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 6
      (SIGABRT)
      si_code: 0
      signal sent by kill (sent by pid 536, uid 0)

Register Information
r0   = 0xfffffffc, r1   = 0xbeb6c398
r2   = 0x42f93224, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x00000000
r6   = 0x00010000, r7   = 0x000000a2
r8   = 0xbeb6c398, r9   = 0x40480c84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeb6c200
lr   = 0x403b8bd0, pc   = 0x4037b484
cpsr = 0x80000010

Memory Information
MemTotal:   491948 KB
MemFree:     44032 KB
Buffers:     48152 KB
Cached:     168488 KB
VmPeak:      69104 KB
VmSize:      69036 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15956 KB
VmRSS:       15952 KB
VmData:      13672 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       24852 KB
VmPTE:          44 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 21033 TID = 21033
21033 21035 21036 

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40005000 40009000 r-xp /usr/lib/libsys-assert.so
40013000 40030000 r-xp /lib/ld-2.13.so
4003a000 4003d000 rw-p [stack:21036]
4003d000 40042000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4004c000 40050000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
40058000 4005c000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
40065000 4006d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
4006e000 40070000 r-xp /usr/lib/libdlog.so.0.0.0
40078000 40099000 r-xp /usr/lib/libefl-extension.so.0.1.0
400a2000 401dc000 r-xp /usr/lib/libelementary.so.1.7.99
401f3000 402c1000 r-xp /usr/lib/libevas.so.1.7.99
402e7000 40402000 r-xp /lib/libc-2.13.so
40410000 40418000 r-xp /lib/libgcc_s-4.6.so.1
40419000 40424000 r-xp /lib/libunwind.so.8.0.1
40451000 40453000 r-xp /lib/libdl-2.13.so
4045c000 40460000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40469000 4046b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40474000 40479000 r-xp /usr/lib/libappcore-efl.so.1.1
40481000 40486000 r-xp /usr/lib/libappcore-common.so.1.1
4048e000 4049a000 r-xp /usr/lib/libaul.so.0.1.0
404a4000 404c6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404ce000 4050f000 r-xp /usr/lib/libeina.so.1.7.99
40518000 4052c000 r-xp /lib/libpthread-2.13.so
40537000 40561000 r-xp /usr/lib/libsensor.so.1.9.6
4056a000 405fe000 r-xp /usr/lib/libstdc++.so.6.0.16
40611000 4067a000 r-xp /lib/libm-2.13.so
40683000 406d3000 r-xp /usr/lib/libecore_x.so.1.7.99
406d5000 406f7000 r-xp /usr/lib/libecore_evas.so.1.7.99
40700000 40709000 r-xp /usr/lib/libvconf.so.0.2.45
40711000 40739000 r-xp /usr/lib/libfontconfig.so.1.8.0
4073a000 40806000 r-xp /usr/lib/libxml2.so.2.7.8
40813000 408e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
408e4000 408f6000 r-xp /usr/lib/libefl-assist.so.0.1.0
408fe000 40915000 r-xp /usr/lib/libecore.so.1.7.99
4092c000 4098a000 r-xp /usr/lib/libedje.so.1.7.99
40993000 40a4b000 r-xp /usr/lib/libcairo.so.2.11200.14
40a56000 40b37000 r-xp /usr/lib/libX11.so.6.3.0
40b42000 40b4b000 r-xp /usr/lib/libXi.so.6.1.0
40b53000 40b6c000 r-xp /usr/lib/libeet.so.1.7.99
40b7d000 40b82000 r-xp /usr/lib/libecore_file.so.1.7.99
40b8a000 40b9b000 r-xp /usr/lib/libecore_input.so.1.7.99
40ba3000 40bac000 r-xp /usr/lib/libedbus.so.1.7.99
40bb4000 40bde000 r-xp /usr/lib/libdbus-1.so.3.8.12
40be7000 40c01000 r-xp /usr/lib/libecore_con.so.1.7.99
40c0a000 40c1d000 r-xp /usr/lib/libfribidi.so.0.3.1
40c25000 40c62000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40c6b000 40cc1000 r-xp /usr/lib/libfreetype.so.6.11.3
40ccd000 40d23000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d30000 40d36000 r-xp /usr/lib/libappsvc.so.0.1.0
40d3e000 40d41000 r-xp /usr/lib/libbundle.so.0.1.22
40d4a000 40d50000 r-xp /usr/lib/libecore_imf.so.1.7.99
40d58000 40d8c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40d95000 40d97000 r-xp /usr/lib/libiniparser.so.0
40da0000 40db7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40dbf000 40dc4000 r-xp /usr/lib/libxdgmime.so.1.1.0
40dcd000 40e09000 r-xp /usr/lib/libsystemd.so.0.4.0
40e12000 40e16000 r-xp /usr/lib/libproc-stat.so.0.2.86
40e1f000 40e35000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e3e000 40eb3000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ebd000 40ec3000 r-xp /lib/librt-2.13.so
40ecd000 40fa0000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40fab000 40fb1000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
40fba000 40fc4000 r-xp /usr/lib/libsensord-shared.so
40fcd000 40fd4000 r-xp /usr/lib/libXcursor.so.1.0.2
40fdc000 40fde000 r-xp /usr/lib/libXdamage.so.1.1.0
40fe7000 40fe9000 r-xp /usr/lib/libXcomposite.so.1.0.0
40ff1000 40ff3000 r-xp /usr/lib/libXgesture.so.7.0.0
40ffb000 40ffe000 r-xp /usr/lib/libXfixes.so.3.1.0
41006000 41007000 r-xp /usr/lib/libXinerama.so.1.0.0
41010000 41016000 r-xp /usr/lib/libXrandr.so.2.2.0
4101e000 41024000 r-xp /usr/lib/libXrender.so.1.3.0
4102d000 41031000 r-xp /usr/lib/libXtst.so.6.1.0
41039000 41043000 r-xp /usr/lib/libXext.so.6.4.0
4104c000 41051000 r-xp /usr/lib/libecore_fb.so.1.7.99
4105a000 4105e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41067000 4106a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
41073000 41089000 r-xp /lib/libexpat.so.1.5.2
41093000 410a9000 r-xp /lib/libz.so.1.2.5
410b1000 410c3000 r-xp /usr/lib/libtts.so
410cb000 410ed000 r-xp /usr/lib/libui-extension.so.0.1.0
410f6000 410fd000 r-xp /usr/lib/libtbm.so.1.0.0
41106000 4110d000 r-xp /usr/lib/libembryo.so.1.7.99
41115000 4112c000 r-xp /usr/lib/liblua-5.1.so
41135000 41136000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4113e000 4114c000 r-xp /usr/lib/libGLESv2.so.2.0
41155000 4116d000 r-xp /usr/lib/libpng12.so.0.50.0
41176000 41177000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41180000 41186000 r-xp /usr/lib/libxcb-render.so.0.0.0
4118e000 411a1000 r-xp /usr/lib/libxcb.so.1.1.0
411aa000 411ad000 r-xp /usr/lib/libEGL.so.1.4
411b5000 411d8000 r-xp /usr/lib/libjpeg.so.8.0.2
411f1000 41235000 r-xp /usr/lib/libcurl.so.4.3.0
4123e000 4123f000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41247000 4124c000 r-xp /usr/lib/libffi.so.5.0.10
41254000 4126c000 r-xp /usr/lib/liblzma.so.5.0.3
41275000 412f1000 r-xp /usr/lib/libgcrypt.so.20.0.3
412fd000 4130d000 r-xp /lib/libresolv-2.13.so
41311000 41313000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4131c000 4131e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41326000 41328000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41331000 41336000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4133e000 41341000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41349000 4134a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41353000 41490000 r-xp /usr/lib/libicui18n.so.51.1
414a0000 41584000 r-xp /usr/lib/libicuuc.so.51.1
4159a000 415a2000 r-xp /usr/lib/libdrm.so.2.4.0
415aa000 415ac000 r-xp /usr/lib/libdri2.so.0.0.0
415b4000 415b6000 r-xp /usr/lib/libXau.so.6.0.0
415be000 415c7000 r-xp /usr/lib/libcares.so.2.1.0
415d0000 415fe000 r-xp /usr/lib/libidn.so.11.5.44
41607000 4164e000 r-xp /usr/lib/libssl.so.1.0.0
4165a000 41803000 r-xp /usr/lib/libcrypto.so.1.0.0
41824000 4182f000 r-xp /usr/lib/libgpg-error.so.0.15.0
41837000 4183d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41845000 4184a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41853000 41857000 r-xp /usr/lib/libsmack.so.1.0.0
41860000 41879000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
42e0a000 42e2b000 r-xp /usr/lib/libexif.so.12.3.3
42e3e000 42e40000 r-xp /usr/lib/libttrace.so.1.1
42e49000 42e4e000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42e56000 42e5c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
42e65000 42e6d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
42e75000 42e91000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42e9b000 42ea2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42eab000 42ead000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42eb5000 42ee3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
42eec000 42ef3000 r-xp /usr/lib/libminizip.so.1.0.0
42efb000 42f08000 r-xp /usr/lib/libail.so.0.1.0
42f12000 42f2f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
42f38000 42f3a000 r-xp /usr/lib/libiri.so
42f42000 42f45000 r-xp /lib/libcap.so.2.21
42f4d000 42f54000 r-xp /lib/libcrypt-2.13.so
42f84000 42f87000 r-xp /lib/libattr.so.1.1.0
43095000 4315f000 r-xp /usr/lib/libCOREGL.so.4.0
43171000 43195000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4319e000 4326d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43283000 4328d000 r-xp /lib/libnss_files-2.13.so
43496000 4350d000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
4351d000 43528000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43531000 43679000 r-xp /usr/lib/egl/libMali.so
4367e000 43681000 r-xp /usr/lib/libnative-buffer.so.0.1.0
4368a000 43e89000 rw-p [stack:21035]
441d0000 441d1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
beb4c000 beb6d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21033)
Call Stack Count: 9
 0: nanosleep + 0x44 (0x4037b484) [/lib/libc.so.6] + 0x94484
 1: sleep + 0xd0 (0x4037b244) [/lib/libc.so.6] + 0x94244
 2: app_create + 0x38 (0x40001719) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1719
 3: (0x4004d9c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 4: appcore_efl_main + 0x13e (0x40477457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 5: ui_app_main + 0xb0 (0x4004e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 6: main + 0x10e (0x4000167b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x167b
 7: __libc_start_main + 0x114 (0x402fe82c) [/lib/libc.so.6] + 0x1782c
 8: (0x400013e4) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x13e4
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
7) > MessagePort message received
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:44.381+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:44.381+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-12 17:57:44.386+0200 W/AUL     (21049): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-clock-viewer]
10-12 17:57:44.391+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 23
10-12 17:57:44.391+0200 W/AUL_AMD (  533): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-12 17:57:44.391+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20532
10-12 17:57:44.391+0200 W/AUL_AMD (  533): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-12 17:57:44.396+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/20532/oom_score_adj failed
10-12 17:57:44.396+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 20532
10-12 17:57:44.396+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-12 17:57:44.401+0200 E/STARTER (  718): starter.c: _w_app_dead_cb(241) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.6.37/src/starter.c:241:E] w-clock-viewer (pid:20532) is destroyed. ambient mode[0], charging[0], sports mode[0]
10-12 17:57:44.401+0200 W/STARTER (  718): starter.c: _w_app_dead_cb(249) > [_w_app_dead_cb:249] >> clockstop
10-12 17:57:44.401+0200 I/AUL_AMD (  533): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20532
10-12 17:57:44.406+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_alpm_handler(1066) > signal_alpm_handler: ambient mode: 0, state: 2
10-12 17:57:44.406+0200 E/WATCH_CORE(18014): appcore-watch.c: __signal_alpm_handler(1070) > invalid state
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-12 17:57:45.191+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.196+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.196+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:45.201+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.201+0200 E/CAPI_APPFW_APP_CONTROL(18126): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-12 17:57:45.201+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:18126]   [com.samsung.w-home]register msg port [true][0m
10-12 17:57:45.206+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 14
10-12 17:57:45.236+0200 W/AUL_AMD (  533): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17973
10-12 17:57:45.251+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:18126]   [MUSIC_PLAYER_EVENT][0m
10-12 17:57:45.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-12 17:57:45.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-12 17:57:45.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: preference_get_int(1132) > preference_get_int(18126) : key(music-control-service_native/playing_diration) error
10-12 17:57:45.271+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:18126]   preference_get_int() .. [0xfef00030][0m
10-12 17:57:45.276+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-message.c: music_control_message_add_data(64) > [31m[TID:18126]   bundle_add_str() .. [0xffffffea][0m
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:45.281+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.286+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:18126]   [MUSIC_PLAYER_EVENT][0m
10-12 17:57:45.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-12 17:57:45.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-12 17:57:45.291+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: preference_get_int(1132) > preference_get_int(18126) : key(music-control-service_native/playing_diration) error
10-12 17:57:45.291+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:18126]   preference_get_int() .. [0xfef00030][0m
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-12 17:57:45.291+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.296+0200 W/W_HOME  (17973): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-12 17:57:45.296+0200 E/W_HOME  (17973): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:45.296+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.301+0200 W/W_HOME  (17973): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-12 17:57:45.301+0200 E/W_HOME  (17973): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-12 17:57:45.306+0200 I/TIZEN_N_SOUND_MANAGER(18126): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-12 17:57:45.306+0200 E/TIZEN_N_SOUND_MANAGER(18126): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-12 17:57:45.306+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:18126]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-12 17:57:45.306+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:45.316+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:45.516+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-12 17:57:45.516+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-12 17:57:45.521+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-12 17:57:45.521+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-12 17:57:45.521+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=11183826
10-12 17:57:45.521+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-12 17:57:45.521+0200 E/STARTER (  718): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-12 17:57:45.521+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-12 17:57:45.521+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-12 17:57:45.666+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-12 17:57:45.666+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-12 17:57:45.666+0200 W/STARTER (  718): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-12 17:57:45.671+0200 W/STARTER (  718): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-12 17:57:45.676+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=11183976
10-12 17:57:45.681+0200 W/STARTER (  718): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-12 17:57:45.686+0200 W/STARTER (  718): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-12 17:57:45.696+0200 E/STARTER (  718): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-12 17:57:45.696+0200 W/AUL     (  718): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-12 17:57:45.696+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:57:45.701+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 718
10-12 17:57:45.706+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 17973
10-12 17:57:45.706+0200 I/APP_CORE(17973): appcore-efl.c: __do_app(429) > [APP 17973] Event: RESET State: RUNNING
10-12 17:57:45.706+0200 I/CAPI_APPFW_APPLICATION(17973): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-12 17:57:45.706+0200 W/W_HOME  (17973): main.c: _app_control(1704) > Service value : powerkey
10-12 17:57:45.706+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-12 17:57:45.706+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-12 17:57:45.706+0200 W/W_HOME  (17973): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-12 17:57:45.706+0200 E/W_HOME  (17973): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-12 17:57:45.706+0200 W/W_HOME  (17973): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-12 17:57:45.706+0200 W/W_HOME  (17973): move.c: move_move_to_apps(220) > move to apps
10-12 17:57:45.711+0200 W/AUL_AMD (  533): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(15), pid(17973), cmd(0)
10-12 17:57:45.711+0200 W/AUL     (  718): launch.c: app_request_to_launchpad(282) > request cmd(0) result(17973)
10-12 17:57:45.711+0200 E/AUL     (  718): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:57:45.711+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:57:45.711+0200 W/W_HOME  (17973): move.c: _create_fake_apps(823) > fake image position : 432
10-12 17:57:45.711+0200 W/W_HOME  (17973): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-12 17:57:45.711+0200 W/W_HOME  (17973): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-12 17:57:45.711+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:57:45.711+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:57:45.711+0200 I/APP_CORE(17973): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-12 17:57:45.711+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-12 17:57:45.711+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-12 17:57:45.711+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:57:45.716+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:57:45.716+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:57:45.716+0200 W/W_HOME  (17973): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-12 17:57:45.716+0200 W/W_HOME  (17973): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-12 17:57:45.716+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-12 17:57:45.716+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-12 17:57:45.846+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 2
10-12 17:57:45.846+0200 I/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-12 17:57:45.846+0200 I/CAPI_WATCH_APPLICATION(18014): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-12 17:57:45.851+0200 E/wnoti-service(  868): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
10-12 17:57:45.851+0200 E/wnoti-service(  868): wnoti-native-client.c: handle_cache_notification(603) > >>
10-12 17:57:45.851+0200 E/WMS     (  495): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 1
10-12 17:57:45.951+0200 W/SHealth_Service( 1074): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
10-12 17:57:46.001+0200 W/AUL_AMD (  533): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-12 17:57:46.021+0200 W/W_HOME  (17973): move.c: _transit_del_cb(115) > transit end
10-12 17:57:46.021+0200 W/W_HOME  (17973): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-12 17:57:46.021+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:57:46.036+0200 W/W_HOME  (17973): move.c: _scroller_up_done(515) > up signal done
10-12 17:57:46.036+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-12 17:57:46.041+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-12 17:57:46.041+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-12 17:57:46.041+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-12 17:57:46.041+0200 W/W_HOME  (17973): main.c: home_pause(766) > clock/widget paused
10-12 17:57:46.041+0200 W/W_HOME  (17973): clock_indicator.c: clock_indicator_pause(554) > 
10-12 17:57:46.041+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-12 17:57:46.041+0200 W/W_HOME  (17973): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-12 17:57:46.041+0200 W/W_HOME  (17973): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-12 17:57:46.041+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-12 17:57:46.041+0200 I/wnotib  (17973): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-12 17:57:46.041+0200 E/APPS    (17973): apps_main.c: apps_main_resume(636) >  resumed already
10-12 17:57:46.056+0200 W/WATCH_CORE(18014): appcore-watch.c: __widget_pause(1028) > widget_pause
10-12 17:57:46.061+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:57:46.061+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:46.061+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:46.066+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:46.066+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:57:46.066+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:57:46.071+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:46.071+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:46.071+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:57:46.081+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:57:46.081+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:46.081+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:46.081+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:57:46.086+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:46.091+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:46.091+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:57:46.096+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:57:46.101+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:57:46.101+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:57:46.101+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:57:46.101+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:57:46.101+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:57:46.101+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-12 17:57:46.426+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11184735 button=1
10-12 17:57:46.426+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.426+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:57:46.426+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-12 17:57:46.436+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.446+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.451+0200 W/APPS    (17973): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-12 17:57:46.461+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.471+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.486+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.501+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.511+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.521+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:46.536+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11184844 button=1
10-12 17:57:46.541+0200 E/APPS    (17973): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-12 17:57:46.706+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-12 17:57:46.706+0200 W/AUL_AMD (  533): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-12 17:57:46.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-12 17:57:46.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-12 17:57:46.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_boolean(1173) > preference_get_boolean(1074) : test_healthy_pace error
10-12 17:57:46.871+0200 W/SHealth_Service( 1074): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-12 17:57:46.916+0200 W/SHealth_Common( 1074): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507766400000,000000[0;m
10-12 17:57:46.931+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-12 17:57:46.931+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-12 17:57:46.936+0200 I/HealthDataService(  776): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-12 17:57:46.956+0200 I/healthData( 1074): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-12 17:57:47.406+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11185717 button=1
10-12 17:57:47.406+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:47.411+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:57:47.411+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-12 17:57:47.456+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11185763 button=1
10-12 17:57:47.456+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-12 17:57:47.456+0200 E/APPS    (17973): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-12 17:57:47.456+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-12 17:57:47.456+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-12 17:57:47.461+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:57:47.461+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 17973
10-12 17:57:47.461+0200 I/AUL_AMD (  533): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-12 17:57:47.481+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 21033
10-12 17:57:47.481+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:57:48.036+0200 E/EFL     (  533): ecore_x<533> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11186346 button=1
10-12 17:57:48.171+0200 E/EFL     (  533): ecore_x<533> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11186479 button=1
10-12 17:57:49.166+0200 I/APP_CORE(  721): appcore-efl.c: __do_app(429) > [APP 721] Event: MEM_FLUSH State: PAUSED
10-12 17:57:52.491+0200 E/AUL_AMD (  533): amd_launch.c: __recv_timeout_handler(941) > application is not responding : pid(21033) cmd(0)
10-12 17:57:52.491+0200 W/AUL_AMD (  533): amd_launch.c: __send_watchdog_signal(425) > send a watchdog signal done: 21033
10-12 17:57:52.506+0200 E/RESOURCED(  536): proc-monitor.c: proc_dbus_watchdog_handler(782) > Receive watchdog signal to pid: 21033(dataextraction)
10-12 17:57:52.506+0200 E/RESOURCED(  536): proc-monitor.c: proc_dbus_watchdog_handler(793) > just kill watchdog process when debug enabled pid: 21033(dataextraction)
10-12 17:57:52.676+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-12 17:57:52.676+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-12 17:57:52.681+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-12 17:57:52.681+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-12 17:57:52.681+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-12 17:57:52.681+0200 E/STARTER (  718): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-12 17:57:52.681+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-12 17:57:52.681+0200 W/STARTER (  718): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-12 17:57:52.681+0200 E/AUL     (17973): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
10-12 17:57:52.686+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(282) > request cmd(0) result(-6)
10-12 17:57:52.686+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11186931 button=1
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11187077 button=1
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11187425 button=1
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11187592 button=1
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11187876 button=1
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11188044 button=1
10-12 17:57:52.751+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11188322 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11188489 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11188711 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11188891 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11189069 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11189237 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11189377 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11189507 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11189634 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11189716 button=1
10-12 17:57:52.761+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=11190976
10-12 17:57:52.761+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:57:52.761+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:57:52.761+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-12 17:57:52.766+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-12 17:57:52.766+0200 E/APPS    (17973): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-12 17:57:52.766+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-12 17:57:52.766+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-12 17:57:52.766+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:57:52.776+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 17973
10-12 17:57:52.776+0200 I/AUL_AMD (  533): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-12 17:57:52.791+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 21033
10-12 17:57:52.791+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-12 17:57:52.791+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-12 17:57:52.791+0200 W/STARTER (  718): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-12 17:57:52.796+0200 W/STARTER (  718): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-12 17:57:52.796+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:57:52.806+0200 W/STARTER (  718): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-12 17:57:52.806+0200 W/STARTER (  718): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-12 17:57:52.806+0200 E/STARTER (  718): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-12 17:57:52.806+0200 W/AUL     (  718): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-12 17:57:52.806+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:57:52.811+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 718
10-12 17:57:52.816+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 17973
10-12 17:57:52.821+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:57:52.911+0200 W/CRASH_MANAGER(21086): worker.c: worker_job(1205) > 0621033646174150782387
