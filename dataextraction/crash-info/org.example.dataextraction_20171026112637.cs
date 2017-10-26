S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 3457
Date: 2017-10-26 11:26:37+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3457, uid 5000)

Register Information
r0   = 0x36302e35, r1   = 0x403bb469
r2   = 0x000000e4, r3   = 0x00000000
r4   = 0x4170c90c, r5   = 0x36302e35
r6   = 0x00000249, r7   = 0xbefa13f8
r8   = 0xbefa14a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40452304, sp   = 0xbefa13a0
lr   = 0x403bb469, pc   = 0x404e6150
cpsr = 0x20000010

Memory Information
MemTotal:   490928 KB
MemFree:     67540 KB
Buffers:     28728 KB
Cached:     158568 KB
VmPeak:     100508 KB
VmSize:      99032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21036 KB
VmRSS:       21036 KB
VmData:      42168 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25564 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3457 TID = 3457
3457 3628 

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
41643000 41647000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
41653000 416f8000 rw-p [heap]
416f8000 416fd000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
4170d000 41715000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
41819000 4184b000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41854000 41875000 r-xp /usr/lib/libefl-extension.so.0.1.0
4187e000 418b8000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
418c1000 418da000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
418e2000 418e7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
418ef000 41919000 r-xp /usr/lib/libsensor.so.1.9.6
41922000 41934000 r-xp /usr/lib/libefl-assist.so.0.1.0
4193c000 419f4000 r-xp /usr/lib/libcairo.so.2.11200.14
419ff000 41a02000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41a0a000 41a10000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41a19000 41a21000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41a29000 41a33000 r-xp /usr/lib/libsensord-shared.so
41a3c000 41a4e000 r-xp /usr/lib/libtts.so
41a56000 41a78000 r-xp /usr/lib/libui-extension.so.0.1.0
41a81000 41a88000 r-xp /usr/lib/libtbm.so.1.0.0
41a90000 41a9e000 r-xp /usr/lib/libGLESv2.so.2.0
41aa7000 41aa8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41ab1000 41ab7000 r-xp /usr/lib/libxcb-render.so.0.0.0
41abf000 41ac2000 r-xp /usr/lib/libEGL.so.1.4
41aca000 41ad7000 r-xp /usr/lib/libail.so.0.1.0
41ae0000 41c1d000 r-xp /usr/lib/libicui18n.so.51.1
41c2d000 41d11000 r-xp /usr/lib/libicuuc.so.51.1
432af000 432cb000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
432d4000 432d7000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
432df000 432e0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
432e9000 432f1000 r-xp /usr/lib/libdrm.so.2.4.0
432f9000 432fb000 r-xp /usr/lib/libdri2.so.0.0.0
43303000 4330a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43313000 43315000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4331d000 43324000 r-xp /usr/lib/libminizip.so.1.0.0
4332c000 43332000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
4333a000 4333f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43347000 43368000 r-xp /usr/lib/libexif.so.12.3.3
4337b000 4337d000 r-xp /usr/lib/libttrace.so.1.1
43385000 4338a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43392000 4345c000 r-xp /usr/lib/libCOREGL.so.4.0
4366f000 43e6e000 rw-p [stack:3628]
43e6e000 43e79000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e82000 43e87000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43e9e000 43e9f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43ea7000 43ea9000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43eb1000 43eb2000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
43eba000 43ebd000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43ecd000 43ed4000 r-xp /usr/lib/libfeedback.so.0.1.4
43edd000 43ede000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
43ee6000 43ee8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
43ef0000 43ef7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45afc000 45b06000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
45b0e000 45b24000 r-xp /usr/lib/libmmfsound.so.0.1.0
45b36000 45b3b000 r-xp /usr/lib/libmmfsession.so.0.0.0
45b43000 45b4d000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45b59000 45b5d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45b66000 45b7b000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45b83000 45be4000 r-xp /usr/lib/libasound.so.2.0.0
45bee000 45bf1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45bf9000 45c31000 r-xp /usr/lib/libpulse.so.0.16.2
45c32000 45c63000 r-xp /usr/lib/libmdm.so.1.1.86
45c6b000 45c70000 r-xp /usr/lib/libjson.so.0.0.1
45c78000 45cc0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45cc1000 45d08000 r-xp /usr/lib/libsndfile.so.1.0.26
45d14000 45d1c000 r-xp /usr/lib/libmdm-common.so.1.0.89
45d1d000 45d3f000 r-xp /usr/lib/libvorbis.so.0.4.3
45d47000 45d4b000 r-xp /usr/lib/libogg.so.0.7.1
4600b000 4600c000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
bef81000 befa2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3457)
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
ssage
10-26 11:25:40.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:25:40.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:40.785+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:25:40.785+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:25:40.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:25:40.785+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:40.790+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 11:25:40.790+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 11:25:40.790+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:25:40.790+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:40.790+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 11:25:40.790+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 11:25:40.795+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 11:25:40.795+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 11:25:40.795+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 11:25:40.795+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:25:40.800+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:40.865+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 11:25:40.865+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 11:25:40.865+0200 W/STARTER (  732): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-26 11:25:40.865+0200 W/STARTER (  732): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-26 11:25:40.880+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-26 11:25:40.880+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-26 11:25:40.880+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1335218
10-26 11:25:40.885+0200 E/STARTER (  732): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-26 11:25:40.885+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 11:25:40.885+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:25:40.885+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 11:25:40.890+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 11:25:40.895+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(769), cmd(0)
10-26 11:25:40.895+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 11:25:40.895+0200 E/AUL     (  732): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:25:40.895+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: RUNNING
10-26 11:25:40.895+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 11:25:40.895+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : powerkey
10-26 11:25:40.895+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-26 11:25:40.895+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-26 11:25:40.895+0200 W/W_HOME  (  769): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-26 11:25:40.895+0200 E/W_HOME  (  769): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-26 11:25:40.895+0200 W/W_HOME  (  769): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-26 11:25:40.895+0200 W/W_HOME  (  769): move.c: move_move_to_apps(220) > move to apps
10-26 11:25:40.895+0200 W/W_HOME  (  769): move.c: _create_fake_apps(823) > fake image position : 432
10-26 11:25:40.900+0200 W/W_HOME  (  769): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-26 11:25:40.900+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-26 11:25:40.900+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:40.900+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:40.900+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:25:40.900+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 11:25:40.900+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-26 11:25:40.900+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 11:25:40.900+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:40.905+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:40.905+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:40.905+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-26 11:25:40.905+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-26 11:25:40.905+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-26 11:25:40.905+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-26 11:25:40.995+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:25:41.005+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:25:41.005+0200 W/AUL     (  494): launch.c: app_request_to_launchpad(268) > request cmd(26) to(com.samsung.shealth-service)
10-26 11:25:41.005+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 26
10-26 11:25:41.005+0200 W/AUL     (  494): launch.c: app_request_to_launchpad(282) > request cmd(26) result(0)
10-26 11:25:41.015+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_expired(1432) > alarm_id[2020572498] is expired.
10-26 11:25:41.015+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(2020572498)
10-26 11:25:41.020+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/alarm-server, ret : 0
10-26 11:25:41.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:25:41.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:26:01 (UTC).
10-26 11:25:41.020+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:25:41.025+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:25:41.030+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:25:41.030+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/alarm-server, ret : 0
10-26 11:25:41.030+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 11:25:41.030+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 494
10-26 11:25:41.040+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 26, pid: 1085
10-26 11:25:41.040+0200 W/SHealth_Service( 1085): SHealthServiceMain.cpp: app_control(124) > [1;35m ###[0;m
10-26 11:25:41.045+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(1085), cmd(26)
10-26 11:25:41.050+0200 W/SHealth_Service( 1085): ExerciseHeartrate.cpp: OnExerciseHrStopDelayAlarmTriggered(239) > [1;40;33mSTOP EXERCISE HEARTRATE[0;m
10-26 11:25:41.050+0200 I/SCONTEXT-LIB( 1085): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 38
10-26 11:25:41.050+0200 W/SHealth_Service( 1085): ContextHRMProxy.cpp: StopImpl(66) > [1;35mHRM unset is successful[0;m
10-26 11:25:41.215+0200 W/W_HOME  (  769): move.c: _transit_del_cb(115) > transit end
10-26 11:25:41.215+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-26 11:25:41.215+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 11:25:41.230+0200 W/W_HOME  (  769): move.c: _scroller_up_done(515) > up signal done
10-26 11:25:41.235+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-26 11:25:41.255+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-26 11:25:41.255+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:41.255+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:41.255+0200 W/W_HOME  (  769): main.c: home_pause(766) > clock/widget paused
10-26 11:25:41.255+0200 W/W_HOME  (  769): clock_indicator.c: clock_indicator_pause(554) > 
10-26 11:25:41.265+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:41.265+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-26 11:25:41.265+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-26 11:25:41.265+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-26 11:25:41.265+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-26 11:25:41.265+0200 E/APPS    (  769): apps_main.c: apps_main_resume(636) >  resumed already
10-26 11:25:41.305+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
10-26 11:25:41.605+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1335955 button=1
10-26 11:25:41.605+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 11:25:41.605+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-26 11:25:41.615+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:41.615+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 11:25:41.635+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:41.645+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:41.665+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1336015 button=1
10-26 11:25:41.665+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:41.670+0200 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-26 11:25:41.895+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 11:25:41.895+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 11:25:44.530+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1338878 button=1
10-26 11:25:44.530+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:44.530+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 11:25:44.530+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 11:25:44.540+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:44.585+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 11:25:44.600+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1338949 button=1
10-26 11:25:44.600+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 11:25:44.600+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 11:25:44.600+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 11:25:44.600+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 11:25:44.605+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 11:25:44.605+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 11:25:44.605+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 11:25:44.640+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 11:25:44.640+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 11:25:44.640+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 11:25:44.640+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 11:25:44.640+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 11:25:44.685+0200 I/efl-extension( 3457): efl_extension.c: eext_mod_init(40) > Init
10-26 11:25:44.685+0200 I/UXT     ( 3457): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 11:25:44.690+0200 I/CAPI_APPFW_APPLICATION( 3457): app_main.c: ui_app_main(704) > app_efl_main
10-26 11:25:44.690+0200 I/CAPI_APPFW_APPLICATION( 3457): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 11:25:44.725+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 11:25:44.740+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:25:44.745+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(3457)
10-26 11:25:44.745+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 11:25:44.770+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 11:25:44.810+0200 I/Bluetooth( 3457): [bt_initialize] success.
10-26 11:25:44.815+0200 I/Bluetooth( 3457): [bt_adapter_le_create_advertiser] success.
10-26 11:25:44.835+0200 I/Bluetooth( 3457): [bt_adapter_le_set_advertising_mode] success.
10-26 11:25:44.840+0200 I/Bluetooth( 3457): [bt_adapter_le_set_advertising_connectable] success.
10-26 11:25:44.840+0200 I/Bluetooth( 3457): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:25:44.840+0200 I/Bluetooth( 3457): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:25:44.890+0200 I/APP_CORE( 3539): appcore-efl.c: __do_app(429) > [APP 3539] Event: MEM_FLUSH State: PAUSED
10-26 11:25:44.940+0200 I/Bluetooth( 3457): [bt_adapter_le_start_advertising_new] success.
10-26 11:25:44.940+0200 I/Bluetooth( 3457): Heart Rate Measurement advertiser started.
10-26 11:25:44.970+0200 I/Bluetooth( 3457): [bt_adapter_le_stop_advertising] success.
10-26 11:25:44.970+0200 I/Bluetooth( 3457): [bt_adapter_le_clear_advertising_data] success.
10-26 11:25:44.970+0200 I/Bluetooth( 3457): [bt_adapter_le_set_advertising_device_name] success.
10-26 11:25:44.970+0200 I/Bluetooth( 3457): [bt_adapter_le_add_advertising_service_solicitation_uuid] success.
10-26 11:25:45.070+0200 I/Bluetooth( 3457): [bt_adapter_le_start_advertising_new] success.
10-26 11:25:45.120+0200 E/EFL     ( 3457): ecore_evas<3457> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
10-26 11:25:45.345+0200 W/W_HOME  (  769): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-26 11:25:45.345+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.345+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.345+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.360+0200 I/APP_CORE( 3457): appcore-efl.c: __do_app(429) > [APP 3457] Event: RESET State: CREATED
10-26 11:25:45.360+0200 I/CAPI_APPFW_APPLICATION( 3457): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
10-26 11:25:45.380+0200 I/APP_CORE( 3457): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-26 11:25:45.380+0200 I/APP_CORE( 3457): appcore-efl.c: __do_app(474) > [APP 3457] Initial Launching, call the resume_cb
10-26 11:25:45.380+0200 I/CAPI_APPFW_APPLICATION( 3457): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
10-26 11:25:45.385+0200 W/APP_CORE( 3457): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.435+0200 W/W_HOME  (  769): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-26 11:25:45.435+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: PAUSE State: RUNNING
10-26 11:25:45.435+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 11:25:45.435+0200 W/W_HOME  (  769): main.c: _appcore_pause_cb(696) > appcore pause
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.435+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:25:45.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 11:25:45.455+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 11:25:45.455+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 11:25:45.455+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [false][0m
10-26 11:25:45.465+0200 I/APP_CORE( 3457): appcore-efl.c: __do_app(429) > [APP 3457] Event: RESUME State: RUNNING
10-26 11:25:45.500+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:45.500+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:45.520+0200 W/wnotib  (  769): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-26 11:25:45.740+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:25:45.740+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:25:45.795+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.263
10-26 11:25:45.810+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 11:25:45.830+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:25:45.840+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3457
10-26 11:25:45.840+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:25:45.845+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3457
10-26 11:25:45.845+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:25:45.850+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:25:45.860+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 11:25:45.870+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3457
10-26 11:25:45.870+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 11:25:45.925+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 11:25:45.925+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 11:25:45.955+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 11:25:45.955+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 11:25:45.960+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:25:46.005+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 11:25:46.010+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 11:25:46.015+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 11:25:46.015+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 11:25:46.015+0200 E/EFL     ( 3640): elementary<3640> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 11:25:46.035+0200 E/EFL     ( 3640): elementary<3640> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 11:25:46.040+0200 E/EFL     ( 3640): elementary<3640> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 11:25:46.040+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 11:25:46.085+0200 E/EFL     ( 3640): elementary<3640> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 11:25:46.090+0200 E/EFL     ( 3640): elementary<3640> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 11:25:46.090+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 11:25:46.095+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 11:25:46.095+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 11:25:46.095+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 11:25:46.095+0200 E/EFL     ( 3640): elementary<3640> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 11:25:46.095+0200 I/AUL_PAD ( 3640): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 11:25:46.305+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:47.310+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:47.810+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:25:48.315+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:49.315+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:50.320+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:50.475+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: MEM_FLUSH State: PAUSED
10-26 11:25:51.320+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:52.320+0200 I/INFO_TAG( 3457): SENSOR_EVENT HEART RATE < 40 : 0
10-26 11:25:53.315+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 11:25:53.385+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 11:25:53.735+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:26:00.680+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 11:26:00.680+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 11:26:00.700+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 11:26:00.710+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 11:26:00.710+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 11:26:00.725+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 11:26:00.725+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 11:26:00.730+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 11:26:00.740+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 11:26:01.000+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1471) > Lock the display not to enter LCD OFF
10-26 11:26:01.100+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_lock_state(1869) > Lock LCD OFF is successfully done
10-26 11:26:01.165+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(510993396)
10-26 11:26:01.170+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:26:01.170+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 12:45:00 (UTC).
10-26 11:26:01.170+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:26:01.170+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_handler_idle(1497) > Unlock the display from LCD OFF
10-26 11:26:01.200+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __display_unlock_state(1912) > Unlock LCD OFF is successfully done
10-26 11:26:01.700+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
10-26 11:26:01.710+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:26:04.395+0200 E/EFL     ( 3457): ecore_x<3457> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1358745 button=1
10-26 11:26:04.465+0200 E/EFL     ( 3457): ecore_x<3457> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1358815 button=1
10-26 11:26:04.660+0200 E/RECORDING_TAG( 3457): sensor_listener_unset_event_cb error: -38010874
10-26 11:26:04.665+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 11:26:04.670+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 11:26:04.820+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:26:05.320+0200 I/INFO_TAG( 3457): SENSOR_EVENT2 HEART RATE : 62
10-26 11:26:05.370+0200 I/INFO_TAG( 3457): SENSOR_EVENT2 TAB VALUE : 62
10-26 11:26:06.325+0200 I/INFO_TAG( 3457): SENSOR_EVENT2 HEART RATE : 62
10-26 11:26:06.355+0200 I/INFO_TAG( 3457): SENSOR_EVENT2 TAB VALUE : 62
10-26 11:26:07.050+0200 E/EFL     ( 3457): ecore_x<3457> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=1361399 button=1
10-26 11:26:07.130+0200 E/EFL     ( 3457): ecore_x<3457> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=1361482 button=1
10-26 11:26:07.150+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
10-26 11:26:07.165+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
10-26 11:26:07.520+0200 E/EFL     ( 3457): elementary<3457> elc_naviframe.c:1211 _on_item_show_finished() item show finished
10-26 11:26:11.685+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
10-26 11:26:11.690+0200 W/W_INDICATOR(  735): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
10-26 11:26:16.615+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:26:28.530+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 11:26:29.010+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 11:26:29.150+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 11:26:29.270+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 11:26:29.270+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 11:26:29.280+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 11:26:29.310+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 11:26:29.350+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 11:26:29.365+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 11:26:29.365+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 11:26:29.365+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 11:26:29.365+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 11:26:29.395+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 11:26:29.400+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 11:26:36.605+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 11:26:36.625+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 11:26:36.635+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 11:26:36.640+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 11:26:36.640+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 11:26:36.640+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 11:26:36.640+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 11:26:36.640+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 11:26:36.640+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 11:26:36.645+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 11:26:36.645+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 11:26:36.645+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 11:26:36.870+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:26:36.870+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 11:26:36.955+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 11:26:36.955+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
10-26 11:26:36.955+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 11:26:36.955+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 11:26:36.960+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 11:26:57), repeat(1), interval(20), type(-1073741822)
10-26 11:26:36.965+0200 I/APP_CORE( 3457): appcore-efl.c: __do_app(429) > [APP 3457] Event: PAUSE State: RUNNING
10-26 11:26:36.970+0200 I/CAPI_APPFW_APPLICATION( 3457): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
10-26 11:26:36.980+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 11:26:37.055+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 973952221, next duetime: 1509010017
10-26 11:26:37.055+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(973952221)
10-26 11:26:37.055+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509010017)
10-26 11:26:37.055+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 11:26:37.055+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 09:26:57 (UTC).
10-26 11:26:37.060+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 11:26:37.070+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:26:37.080+0200 W/SHealth_Common( 2616): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 11:26:37.080+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 11:26:37.080+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 11:26:37.140+0200 I/APP_CORE( 3457): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
10-26 11:26:37.140+0200 I/CAPI_APPFW_APPLICATION( 3457): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
10-26 11:26:37.505+0200 I/MALI    (  769): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
10-26 11:26:37.535+0200 W/CRASH_MANAGER( 3750): worker.c: worker_job(1205) > 1103457646174150900999
