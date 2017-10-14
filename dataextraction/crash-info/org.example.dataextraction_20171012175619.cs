S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 20298
Date: 2017-10-12 17:56:19+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 20298, uid 5000)

Register Information
r0   = 0xfffffffc, r1   = 0xbeed81f8
r2   = 0x42f93224, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x00000000
r6   = 0x00010000, r7   = 0x000000a2
r8   = 0xbeed81f8, r9   = 0x44044c10
r10  = 0x44061958, fp   = 0x00000001
ip   = 0x00000000, sp   = 0xbeed8060
lr   = 0x403b8bd0, pc   = 0x4037b484
cpsr = 0x80000010

Memory Information
MemTotal:   491948 KB
MemFree:     45820 KB
Buffers:     47460 KB
Cached:     166560 KB
VmPeak:     109748 KB
VmSize:     106816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18840 KB
VmRSS:       18836 KB
VmData:      48832 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       26820 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20298 TID = 20298
20298 20299 20300 20324 

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40005000 40009000 r-xp /usr/lib/libsys-assert.so
40013000 40030000 r-xp /lib/ld-2.13.so
4003a000 4003d000 rw-p [stack:20300]
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
4368a000 43e89000 rw-p [stack:20299]
441d0000 441d1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
443a9000 443aa000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
44400000 44407000 r-xp /usr/lib/libfeedback.so.0.1.4
44410000 44411000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
44419000 4441b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
44423000 4442d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
44435000 4443c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
44444000 4445a000 r-xp /usr/lib/libmmfsound.so.0.1.0
4446c000 44471000 r-xp /usr/lib/libmmfsession.so.0.0.0
44479000 44483000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4448f000 44493000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4449c000 444b1000 r-xp /usr/lib/libavsysaudio.so.0.0.1
444b9000 4451a000 r-xp /usr/lib/libasound.so.2.0.0
44524000 44527000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4452f000 44567000 r-xp /usr/lib/libpulse.so.0.16.2
44568000 4456b000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
44573000 445a4000 r-xp /usr/lib/libmdm.so.1.1.86
445ac000 445b1000 r-xp /usr/lib/libjson.so.0.0.1
445b9000 44601000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
44602000 44649000 r-xp /usr/lib/libsndfile.so.1.0.26
44655000 4465d000 r-xp /usr/lib/libmdm-common.so.1.0.89
4465e000 44680000 r-xp /usr/lib/libvorbis.so.0.4.3
44688000 4468c000 r-xp /usr/lib/libogg.so.0.7.1
44695000 44e94000 rw-p [stack:20324]
beeb8000 beed9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20298)
Call Stack Count: 18
 0: nanosleep + 0x44 (0x4037b484) [/lib/libc.so.6] + 0x94484
 1: sleep + 0xd0 (0x4037b244) [/lib/libc.so.6] + 0x94244
 2: clicked_recording_stop + 0x72 (0x40001fdb) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1fdb
 3: evas_object_smart_callback_call + 0x88 (0x40228725) [/usr/lib/libevas.so.1] + 0x35725
 4: (0x40971ad9) [/usr/lib/libedje.so.1] + 0x45ad9
 5: (0x40975ac1) [/usr/lib/libedje.so.1] + 0x49ac1
 6: (0x40972431) [/usr/lib/libedje.so.1] + 0x46431
 7: (0x409727e3) [/usr/lib/libedje.so.1] + 0x467e3
 8: (0x4097291d) [/usr/lib/libedje.so.1] + 0x4691d
 9: (0x409093f5) [/usr/lib/libecore.so.1] + 0xb3f5
10: (0x40906e53) [/usr/lib/libecore.so.1] + 0x8e53
11: (0x4090a46b) [/usr/lib/libecore.so.1] + 0xc46b
12: ecore_main_loop_begin + 0x30 (0x4090a879) [/usr/lib/libecore.so.1] + 0xc879
13: appcore_efl_main + 0x20a (0x40477523) [/usr/lib/libappcore-efl.so.1] + 0x3523
14: ui_app_main + 0xb0 (0x4004e421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
15: main + 0x10e (0x4000167b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x167b
16: __libc_start_main + 0x114 (0x402fe82c) [/lib/libc.so.6] + 0x1782c
17: (0x400013e4) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x13e4
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
otePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-12 17:56:12.341+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.346+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:18126]   [MUSIC_PLAYER_EVENT][0m
10-12 17:56:12.346+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-12 17:56:12.346+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-12 17:56:12.346+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(18126): preference.c: preference_get_int(1132) > preference_get_int(18126) : key(music-control-service_native/playing_diration) error
10-12 17:56:12.346+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:18126]   preference_get_int() .. [0xfef00030][0m
10-12 17:56:12.346+0200 W/W_HOME  (17973): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-12 17:56:12.346+0200 E/W_HOME  (17973): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.346+0200 W/W_HOME  (17973): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-12 17:56:12.346+0200 E/W_HOME  (17973): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-12 17:56:12.346+0200 I/TIZEN_N_SOUND_MANAGER(18126): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-12 17:56:12.346+0200 E/TIZEN_N_SOUND_MANAGER(18126): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-12 17:56:12.346+0200 W/MUSIC_CONTROL_SERVICE(18126): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:18126]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-12 17:56:12.346+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.351+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.396+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-12 17:56:12.396+0200 W/KEYROUTER(  407): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-12 17:56:12.396+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=11090704
10-12 17:56:12.396+0200 W/STARTER (  718): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-12 17:56:12.396+0200 W/STARTER (  718): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-12 17:56:12.406+0200 W/STARTER (  718): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-12 17:56:12.406+0200 W/STARTER (  718): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-12 17:56:12.406+0200 E/STARTER (  718): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-12 17:56:12.406+0200 W/AUL     (  718): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-12 17:56:12.406+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:56:12.406+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 718
10-12 17:56:12.416+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 17973
10-12 17:56:12.416+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:56:12.416+0200 I/APP_CORE(17973): appcore-efl.c: __do_app(429) > [APP 17973] Event: RESET State: RUNNING
10-12 17:56:12.416+0200 I/CAPI_APPFW_APPLICATION(17973): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-12 17:56:12.421+0200 W/AUL_AMD (  533): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(17973), cmd(0)
10-12 17:56:12.421+0200 W/W_HOME  (17973): main.c: _app_control(1704) > Service value : powerkey
10-12 17:56:12.421+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-12 17:56:12.421+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-12 17:56:12.421+0200 W/W_HOME  (17973): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-12 17:56:12.421+0200 E/W_HOME  (17973): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-12 17:56:12.421+0200 W/W_HOME  (17973): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-12 17:56:12.421+0200 W/AUL     (  718): launch.c: app_request_to_launchpad(282) > request cmd(0) result(17973)
10-12 17:56:12.421+0200 W/W_HOME  (17973): move.c: move_move_to_apps(220) > move to apps
10-12 17:56:12.421+0200 E/AUL     (  718): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:56:12.421+0200 W/W_HOME  (17973): move.c: _create_fake_apps(823) > fake image position : 432
10-12 17:56:12.421+0200 W/W_HOME  (17973): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:56:12.421+0200 I/APP_CORE(17973): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:56:12.421+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:56:12.421+0200 W/W_HOME  (17973): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-12 17:56:12.421+0200 W/W_HOME  (17973): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-12 17:56:12.421+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-12 17:56:12.421+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-12 17:56:12.721+0200 W/W_HOME  (17973): move.c: _transit_del_cb(115) > transit end
10-12 17:56:12.721+0200 W/W_HOME  (17973): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-12 17:56:12.721+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-12 17:56:12.741+0200 W/W_HOME  (17973): move.c: _scroller_up_done(515) > up signal done
10-12 17:56:12.746+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-12 17:56:12.746+0200 W/W_HOME  (17973): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-12 17:56:12.746+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-12 17:56:12.746+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-12 17:56:12.746+0200 W/W_HOME  (17973): main.c: home_pause(766) > clock/widget paused
10-12 17:56:12.746+0200 W/W_HOME  (17973): clock_indicator.c: clock_indicator_pause(554) > 
10-12 17:56:12.751+0200 W/W_HOME  (17973): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-12 17:56:12.751+0200 W/W_HOME  (17973): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-12 17:56:12.751+0200 W/W_HOME  (17973): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-12 17:56:12.751+0200 I/wnotib  (17973): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-12 17:56:12.751+0200 I/wnotib  (17973): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-12 17:56:12.751+0200 E/APPS    (17973): apps_main.c: apps_main_resume(636) >  resumed already
10-12 17:56:12.776+0200 W/WATCH_CORE(18014): appcore-watch.c: __widget_pause(1028) > widget_pause
10-12 17:56:12.781+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.781+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.781+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:56:12.781+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:56:12.791+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.791+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.791+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:56:12.791+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:56:12.796+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.796+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.796+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:56:12.796+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:56:12.806+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.806+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.806+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:56:12.806+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:56:12.816+0200 W/SHealth_Common(  825): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-12 17:56:12.816+0200 I/MESSAGE_PORT(  487): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-12 17:56:12.816+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-12 17:56:12.816+0200 I/CAPI_WIDGET_APPLICATION(  825): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-12 17:56:12.826+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-12 17:56:13.001+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11091309 button=1
10-12 17:56:13.001+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.001+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:56:13.001+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-12 17:56:13.006+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.021+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.021+0200 W/APPS    (17973): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-12 17:56:13.031+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.046+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.061+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11091367 button=1
10-12 17:56:13.061+0200 E/APPS    (17973): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-12 17:56:13.416+0200 W/AUL_AMD (  533): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-12 17:56:13.416+0200 W/AUL_AMD (  533): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-12 17:56:13.906+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11092214 button=1
10-12 17:56:13.906+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.906+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:56:13.906+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-12 17:56:13.976+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:13.986+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11092297 button=1
10-12 17:56:13.986+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-12 17:56:13.986+0200 E/APPS    (17973): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-12 17:56:13.986+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-12 17:56:13.991+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-12 17:56:13.996+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:56:13.996+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 17973
10-12 17:56:13.996+0200 I/AUL_AMD (  533): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-12 17:56:14.011+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 20298
10-12 17:56:14.021+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:56:14.571+0200 E/EFL     (  533): ecore_x<533> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11092879 button=1
10-12 17:56:14.706+0200 E/EFL     (  533): ecore_x<533> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11093012 button=1
10-12 17:56:16.381+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-12 17:56:16.386+0200 I/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-12 17:56:16.386+0200 I/CAPI_WATCH_APPLICATION(18014): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-12 17:56:16.461+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-12 17:56:16.486+0200 W/STARTER (  718): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-12 17:56:16.486+0200 W/STARTER (  718): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-12 17:56:16.486+0200 E/STARTER (  718): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-12 17:56:16.486+0200 W/STARTER (  718): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-12 17:56:16.486+0200 W/STARTER (  718): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-12 17:56:16.841+0200 W/STARTER (  718): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-12 17:56:16.841+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-12 17:56:16.841+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-12 17:56:16.841+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-12 17:56:16.841+0200 E/ALARM_MANAGER(  718): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(12-10-2017, 17:56:37), repeat(1), interval(20), type(-1073741822)
10-12 17:56:16.861+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [718].
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 872621424, next duetime: 1507823797
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(872621424)
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1507841252), due_time(1507823797)
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 12-10-2017, 15:56:37 (UTC).
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-12 17:56:16.916+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-12 17:56:16.921+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-12 17:56:16.931+0200 W/SHealth_Common( 1074): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-12 17:56:16.931+0200 W/SHealth_Service( 1074): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-12 17:56:16.931+0200 W/SHealth_Common(  825): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-12 17:56:17.291+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-12 17:56:17.291+0200 I/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-12 17:56:17.296+0200 I/CAPI_WATCH_APPLICATION(18014): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-12 17:56:17.326+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-12 17:56:17.326+0200 I/WATCH_CORE(18014): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-12 17:56:17.326+0200 I/CAPI_WATCH_APPLICATION(18014): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-12 17:56:17.336+0200 W/STARTER (  718): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [gesture] after screen off time [894]ms
10-12 17:56:17.336+0200 W/STARTER (  718): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [718].
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(872621424)
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 12-10-2017, 20:47:32 (UTC).
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-12 17:56:17.366+0200 E/ALARM_MANAGER(  482): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[872621424] is removed.
10-12 17:56:17.371+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-12 17:56:17.376+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-12 17:56:17.376+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-12 17:56:17.376+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_boolean(1173) > preference_get_boolean(1074) : test_healthy_pace error
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_double(1214) > preference_get_double(1074) : pedometer_inactive_period error
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_double(1214) > preference_get_double(1074) : inactive_10min_precaution_millisec error
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-12 17:56:17.426+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_double(1214) > preference_get_double(1074) : inactive_before_10min_precaution_millisec error
10-12 17:56:17.566+0200 W/STARTER (  718): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
10-12 17:56:17.566+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-12 17:56:17.576+0200 W/SHealth_Common(  825): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-12 17:56:17.581+0200 W/SHealth_Common( 1074): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-12 17:56:17.581+0200 W/SHealth_Service( 1074): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-12 17:56:19.016+0200 E/AUL_AMD (  533): amd_launch.c: __recv_timeout_handler(941) > application is not responding : pid(20298) cmd(0)
10-12 17:56:19.016+0200 W/AUL_AMD (  533): amd_launch.c: __send_watchdog_signal(425) > send a watchdog signal done: 20298
10-12 17:56:19.036+0200 E/RESOURCED(  536): proc-monitor.c: proc_dbus_watchdog_handler(782) > Receive watchdog signal to pid: 20298(dataextraction)
10-12 17:56:19.041+0200 E/RESOURCED(  536): proc-monitor.c: proc_dbus_watchdog_handler(793) > just kill watchdog process when debug enabled pid: 20298(dataextraction)
10-12 17:56:19.066+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-12 17:56:19.066+0200 I/WATCH_CORE(18014): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-12 17:56:19.066+0200 I/CAPI_WATCH_APPLICATION(18014): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-12 17:56:19.141+0200 W/WATCH_CORE(18014): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-12 17:56:19.171+0200 W/STARTER (  718): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [gesture]
10-12 17:56:19.171+0200 W/STARTER (  718): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-12 17:56:19.176+0200 E/STARTER (  718): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-12 17:56:19.176+0200 W/STARTER (  718): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-12 17:56:19.176+0200 W/STARTER (  718): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-12 17:56:19.221+0200 E/AUL     (17973): app_sock.c: __app_send_raw(324) > recv timeout : cmd(0) Resource temporarily unavailable
10-12 17:56:19.221+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(282) > request cmd(0) result(-6)
10-12 17:56:19.221+0200 E/CAPI_APPFW_APP_CONTROL(17973): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11093377 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11093510 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11093632 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11093753 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11093864 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11093985 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11094096 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11094204 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11096635 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11096759 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11096944 button=1
10-12 17:56:19.366+0200 E/EFL     (17973): ecore_x<17973> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11097058 button=1
10-12 17:56:19.371+0200 W/SHealth_Common( 1074): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-12 17:56:19.371+0200 W/SHealth_Service( 1074): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-12 17:56:19.371+0200 W/SHealth_Common(  825): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-12 17:56:19.381+0200 W/STARTER (  718): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [gesture]
10-12 17:56:19.381+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-12 17:56:19.381+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-12 17:56:19.381+0200 W/STARTER (  718): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-12 17:56:19.381+0200 E/ALARM_MANAGER(  718): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(12-10-2017, 17:56:39), repeat(1), interval(20), type(-1073741822)
10-12 17:56:19.391+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:19.391+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:56:19.391+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-12 17:56:19.396+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-12 17:56:19.396+0200 E/APPS    (17973): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-12 17:56:19.396+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-12 17:56:19.396+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-12 17:56:19.396+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [718].
10-12 17:56:19.401+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:56:19.401+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 17973
10-12 17:56:19.401+0200 I/AUL_AMD (  533): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-12 17:56:19.416+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(2119) > Sending to legacy launchpad because process-pool launchpad is not initialized.
10-12 17:56:19.416+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(2124) > pad pid(-1)
10-12 17:56:19.416+0200 W/AUL_AMD (  533): amd_launch.c: start_process(580) > child process: 20401
10-12 17:56:19.416+0200 E/RESOURCED(  536): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-12 17:56:19.416+0200 E/RESOURCED(  536): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2115265157, next duetime: 1507823799
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(2115265157)
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1507841252), due_time(1507823799)
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 12-10-2017, 15:56:39 (UTC).
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-12 17:56:19.466+0200 E/ALARM_MANAGER(  482): alarm-manager.c: __save_module_log(1765) > The file is not ready.
10-12 17:56:19.466+0200 W/AUL_AMD (  533): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 20401
10-12 17:56:19.466+0200 E/AUL     (  533): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-12 17:56:19.471+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(282) > request cmd(0) result(20401)
10-12 17:56:19.471+0200 E/W_HOME  (17973): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-12 17:56:19.471+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:19.471+0200 E/W_HOME  (17973): move.c: _mouse_down_cb(384) > apps move is not allowed
10-12 17:56:19.471+0200 W/APPS    (17973): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-12 17:56:19.471+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:19.471+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:19.471+0200 E/W_HOME  (17973): move.c: _mouse_move_cb(546) > apps move is not allowed
10-12 17:56:19.471+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-12 17:56:19.471+0200 E/APPS    (17973): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-12 17:56:19.471+0200 W/APPS    (17973): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-12 17:56:19.471+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-12 17:56:19.471+0200 W/AUL_AMD (  533): amd_request.c: __request_handler(645) > __request_handler: 0
10-12 17:56:19.476+0200 W/AUL_AMD (  533): amd_launch.c: _start_app(1710) > caller pid : 17973
10-12 17:56:19.476+0200 I/AUL_AMD (  533): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-12 17:56:19.481+0200 W/AUL_AMD (  533): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 20401
10-12 17:56:19.481+0200 E/AUL     (  533): app_sock.c: __connect_client_sock(196) > connect error: 2
10-12 17:56:19.481+0200 E/AUL     (  533): app_sock.c: __create_client_sock(162) > cannot connect the client socket: 2
10-12 17:56:19.556+0200 W/CRASH_MANAGER(20402): worker.c: worker_job(1205) > 0620298646174150782377
