S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 11336
Date: 2017-10-14 17:09:10+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 11336, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002c48
r2   = 0x00000006, r3   = 0x00002c48
r4   = 0x00000006, r5   = 0x000f5528
r6   = 0x4040cbec, r7   = 0x0000010c
r8   = 0x42f931a0, r9   = 0x00000002
r10  = 0x0000007f, fp   = 0xbed13c20
ip   = 0x42f93660, sp   = 0xbed134e8
lr   = 0x403176bc, pc   = 0x403139e8
cpsr = 0x20000010

Memory Information
MemTotal:   491948 KB
MemFree:     15720 KB
Buffers:     61632 KB
Cached:     168420 KB
VmPeak:     105528 KB
VmSize:     103908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17596 KB
VmRSS:       17592 KB
VmData:      48544 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       24852 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 7
PID = 11336 TID = 11336
11336 11337 11338 11346 11347 11348 11349 

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40005000 40009000 r-xp /usr/lib/libsys-assert.so
40013000 40030000 r-xp /lib/ld-2.13.so
4003a000 4003d000 rw-p [stack:11338]
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
4368a000 43e89000 rw-p [stack:11337]
441d0000 441d1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
441da000 449d9000 rw-p [stack:11346]
449da000 451d9000 rw-p [stack:11347]
451da000 459d9000 rw-p [stack:11348]
459da000 461d9000 rw-p [stack:11349]
becf4000 bed15000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11336)
Call Stack Count: 1
 0: gsignal + 0x3c (0x403139e8) [/lib/libc.so.6] + 0x2c9e8
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
) e_dbus_init done.
10-14 17:09:24.330+0200 E/EFL     (11505): elementary<11505> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-14 17:09:24.335+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:09:24.335+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 17:09:24.335+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:24.340+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 17:09:24.340+0200 E/EFL     (11505): elementary<11505> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-14 17:09:24.340+0200 E/EFL     (11505): elementary<11505> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-14 17:09:24.340+0200 E/EFL     (11505): elementary<11505> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-14 17:09:24.345+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:09:24.350+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:09:24.350+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:24.350+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:09:24.350+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:09:24.350+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:24.355+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:24.355+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:09:24.355+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:09:24.355+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:09:24.355+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:09:24.355+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:24.360+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:09:24.360+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:24.360+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:24.360+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:09:24.360+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:09:24.365+0200 E/EFL     (11505): elementary<11505> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-14 17:09:24.365+0200 E/EFL     (11505): elementary<11505> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-14 17:09:24.365+0200 E/EFL     (11505): elementary<11505> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-14 17:09:24.370+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:09:24.370+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:09:24.370+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:24.370+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:24.375+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:24.395+0200 E/EFL     (11505): elementary<11505> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 17:09:24.405+0200 E/EFL     (11505): elementary<11505> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 17:09:24.405+0200 E/EFL     (11505): elementary<11505> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 17:09:24.405+0200 E/EFL     (11505): elementary<11505> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 17:09:24.405+0200 E/EFL     (11505): elementary<11505> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 17:09:24.405+0200 E/EFL     (11505): elementary<11505> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 17:09:24.405+0200 E/EFL     (11505): elementary<11505> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 17:09:24.460+0200 I/CAPI_APPFW_APPLICATION(11505): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-14 17:09:24.475+0200 E/EFL     (11503): elementary<11503> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-14 17:09:24.480+0200 E/EFL     (11503): elementary<11503> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-14 17:09:24.485+0200 E/EFL     (11503): elementary<11503> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-14 17:09:24.485+0200 E/EFL     (11503): elementary<11503> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-14 17:09:24.485+0200 E/EFL     (11503): elementary<11503> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-14 17:09:24.485+0200 E/EFL     (11503): elementary<11503> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-14 17:09:24.485+0200 E/EFL     (11503): elementary<11503> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-14 17:09:24.485+0200 I/AUL_PAD (11503): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-14 17:09:24.655+0200 E/EFL     (11505): ecore_evas<11505> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-14 17:09:24.950+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:09:24.950+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:24.950+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:24.950+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:24.975+0200 I/APP_CORE(11505): appcore-efl.c: __do_app(429) > [APP 11505] Event: RESET State: CREATED
10-14 17:09:24.975+0200 I/CAPI_APPFW_APPLICATION(11505): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-14 17:09:25.000+0200 I/APP_CORE(11505): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:09:25.000+0200 I/APP_CORE(11505): appcore-efl.c: __do_app(474) > [APP 11505] Initial Launching, call the resume_cb
10-14 17:09:25.000+0200 I/CAPI_APPFW_APPLICATION(11505): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-14 17:09:25.005+0200 W/APP_CORE(11505): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
10-14 17:09:25.025+0200 I/MALI    (11505): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(742) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [216x432]
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:09:25.045+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:09:25.045+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.045+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.060+0200 I/APP_CORE(11505): appcore-efl.c: __do_app(429) > [APP 11505] Event: RESUME State: RUNNING
10-14 17:09:25.070+0200 E/TBM     (  409): tbm_bufmgr.c: _tgl_destroy(151) > [libtbm:409] error(Device or resource busy) _tgl_destroy:151 key:29
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:25.075+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:25.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:25.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:25.080+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:09:25.080+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:09:25.145+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:09:25.150+0200 I/HEART_RATE(11505): HEART RATE : 0
10-14 17:09:25.385+0200 E/AUL     (  532): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-14 17:09:25.575+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f370] swap changed from sync to async
10-14 17:09:25.605+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:09:25.635+0200 W/AUL     (11523): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-14 17:09:25.655+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
10-14 17:09:25.655+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
10-14 17:09:25.655+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.655+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.655+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
10-14 17:09:25.690+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: RESUME State: PAUSED
10-14 17:09:25.690+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): main.c: _appcore_resume_cb(687) > appcore resume
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-14 17:09:25.690+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.695+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.695+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:25.705+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
10-14 17:09:25.715+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 17:09:25.715+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 17:09:25.715+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 11399
10-14 17:09:25.715+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 17:09:25.730+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 17:09:25.730+0200 W/AUL_AMD (  532): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-14 17:09:25.730+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
10-14 17:09:25.730+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
10-14 17:09:25.730+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:09:25.735+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11399
10-14 17:09:26.085+0200 I/MALI    ( 1063): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f370] swap changed from async to sync
10-14 17:09:26.330+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-14 17:09:26.590+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 17:09:26.590+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 17:09:26.595+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:09:26.625+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-14 17:09:26.625+0200 W/W_HOME  ( 1063): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-14 17:09:26.625+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-14 17:09:26.625+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-14 17:09:26.625+0200 W/W_HOME  ( 1063): gesture.c: _manual_render_enable(136) > 1
10-14 17:09:26.625+0200 W/W_HOME  ( 1063): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-14 17:09:26.625+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:26.630+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-14 17:09:26.630+0200 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-14 17:09:26.635+0200 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-14 17:09:26.635+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-14 17:09:26.635+0200 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:26.705+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.705+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:09:26.705+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 17:09:26.710+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:09:26.720+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 17:09:26.740+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:09:26.740+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:09:26.740+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:26.740+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:09:26.740+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:09:26.740+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:26.740+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:26.745+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.745+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:09:26.745+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:09:26.745+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:09:26.745+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:09:26.745+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:09:26.745+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:09:26.750+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:26.750+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.750+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:09:26.750+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:09:26.755+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:09:26.755+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:09:26.755+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:26.755+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.880+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 17:09:26.890+0200 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-14 17:09:26.890+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-14 17:09:26.890+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-14 17:09:26.890+0200 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-14 17:09:26.890+0200 E/ALARM_MANAGER(  705): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(14-10-2017, 17:09:47), repeat(1), interval(20), type(-1073741822)
10-14 17:09:26.900+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:09:26.900+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:09:26.900+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:09:26.900+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:09:26.900+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:26.900+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:26.900+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:26.905+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:09:26.910+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:09:26.910+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:09:26.910+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:09:26.910+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [705].
10-14 17:09:26.960+0200 E/ALARM_MANAGER(  484): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 804233936, next duetime: 1507993787
10-14 17:09:26.960+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(804233936)
10-14 17:09:26.960+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1508014052), due_time(1507993787)
10-14 17:09:26.965+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-14 17:09:26.965+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 14-10-2017, 15:09:47 (UTC).
10-14 17:09:26.965+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-14 17:09:26.965+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 17:09:26.975+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-14 17:09:26.975+0200 W/SHealth_Common( 1156): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-14 17:09:26.975+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 17:09:27.410+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:09:27.550+0200 W/CRASH_MANAGER(11039): worker.c: worker_job(1205) > 0611336646174150799375
