S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2047
Date: 2017-10-26 14:24:21+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x415318c8, r1   = 0x00000001
r2   = 0x4059d250, r3   = 0x3c378f00
r4   = 0xbef0a4d4, r5   = 0x4154ad30
r6   = 0x00000233, r7   = 0xbef0a3f8
r8   = 0xbef0a4a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e5a00, sp   = 0xbef0a3c8
lr   = 0x404e5ab4, pc   = 0x41745c3c
cpsr = 0x60000030

Memory Information
MemTotal:   491948 KB
MemFree:     99996 KB
Buffers:     25308 KB
Cached:     154756 KB
VmPeak:      66748 KB
VmSize:      66744 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12016 KB
VmRSS:       12012 KB
VmData:      13500 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2047 TID = 2047
2047 2140 

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
436c4000 43f00000 rw-p [stack:2140]
beeea000 bef0b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2047)
Call Stack Count: 9
 0: start_bt_server + 0x13 (0x41745c3c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2c3c
 1: app_create + 0x5e (0x41744b37) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1b37
 2: (0x415409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x41744a73) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1a73
 6: main + 0x36 (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: create_base_gui + 0x8f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
s_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 14:24:18.461+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 14:24:18.461+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 14:24:18.461+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 14:24:18.476+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 14:24:18.476+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 14:24:18.476+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 14:24:18.481+0200 E/TIZEN_N_SYSTEM_SETTINGS(  835): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 14:24:18.511+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:18.516+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:18.536+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-26 14:24:18.566+0200 W/STARTER (  723): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [gesture]
10-26 14:24:18.566+0200 W/STARTER (  723): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 14:24:18.601+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-26 14:24:18.601+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:18.601+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:18.606+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:18.606+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-26 14:24:18.631+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:18.631+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:18.636+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-26 14:24:18.646+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:18.646+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:18.651+0200 W/SHealth_Common( 1074): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 14:24:18.656+0200 W/SHealth_Service( 1074): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 14:24:18.656+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-26 14:24:18.661+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
10-26 14:24:18.666+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-26 14:24:18.666+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-26 14:24:18.671+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-26 14:24:18.671+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-26 14:24:18.671+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
10-26 14:24:18.676+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 14:24:18.686+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 14:24:18.686+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_boolean(1173) > preference_get_boolean(1074) : test_healthy_pace error
10-26 14:24:18.686+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_double(1214) > preference_get_double(1074) : pedometer_inactive_period error
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_double(1214) > preference_get_double(1074) : inactive_10min_precaution_millisec error
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 14:24:18.691+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1074): preference.c: preference_get_double(1214) > preference_get_double(1074) : inactive_before_10min_precaution_millisec error
10-26 14:24:18.706+0200 W/SHealth_Common(  835): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 14:24:19.316+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.326+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 14:24:19.331+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:19.331+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:19.331+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.331+0200 E/CAPI_APPFW_APP_CONTROL( 1079): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 14:24:19.331+0200 W/MUSIC_CONTROL_SERVICE( 1079): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1079]   [com.samsung.w-home]register msg port [true][0m
10-26 14:24:19.336+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 14:24:19.366+0200 W/AUL_AMD (  509): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 766
10-26 14:24:19.386+0200 W/MUSIC_CONTROL_SERVICE( 1079): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1079]   [MUSIC_PLAYER_EVENT][0m
10-26 14:24:19.396+0200 W/MUSIC_CONTROL_SERVICE( 1079): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1079]   bundle_add_str() .. [0xffffffea][0m
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 14:24:19.401+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:19.406+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.411+0200 W/W_HOME  (  766): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 14:24:19.411+0200 E/W_HOME  (  766): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 14:24:19.426+0200 W/MUSIC_CONTROL_SERVICE( 1079): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1079]   [MUSIC_PLAYER_EVENT][0m
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:19.436+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.446+0200 W/W_HOME  (  766): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 14:24:19.446+0200 E/W_HOME  (  766): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 14:24:19.456+0200 I/TIZEN_N_SOUND_MANAGER( 1079): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 14:24:19.461+0200 E/TIZEN_N_SOUND_MANAGER( 1079): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 14:24:19.461+0200 W/MUSIC_CONTROL_SERVICE( 1079): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1079]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 14:24:19.461+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:19.466+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:19.681+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-26 14:24:19.681+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-26 14:24:19.681+0200 W/STARTER (  723): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-26 14:24:19.681+0200 W/STARTER (  723): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-26 14:24:19.686+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=235577
10-26 14:24:19.686+0200 W/STARTER (  723): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-26 14:24:19.691+0200 E/STARTER (  723): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-26 14:24:19.701+0200 W/STARTER (  723): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-26 14:24:19.701+0200 W/STARTER (  723): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-26 14:24:19.776+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 14:24:19.776+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 14:24:19.776+0200 W/STARTER (  723): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-26 14:24:19.776+0200 W/STARTER (  723): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-26 14:24:19.791+0200 W/STARTER (  723): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-26 14:24:19.796+0200 W/STARTER (  723): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-26 14:24:19.796+0200 E/STARTER (  723): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-26 14:24:19.796+0200 W/AUL     (  723): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 14:24:19.806+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:19.811+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 723
10-26 14:24:19.816+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=235671
10-26 14:24:19.816+0200 W/AUL_AMD (  509): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 766
10-26 14:24:19.821+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:19.821+0200 W/AUL_AMD (  509): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(766), cmd(0)
10-26 14:24:19.821+0200 W/AUL     (  723): launch.c: app_request_to_launchpad(282) > request cmd(0) result(766)
10-26 14:24:19.821+0200 E/AUL     (  723): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:19.821+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(429) > [APP 766] Event: RESET State: RUNNING
10-26 14:24:19.821+0200 I/CAPI_APPFW_APPLICATION(  766): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 14:24:19.821+0200 W/W_HOME  (  766): main.c: _app_control(1704) > Service value : powerkey
10-26 14:24:19.821+0200 I/wnotib  (  766): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-26 14:24:19.821+0200 I/wnotib  (  766): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-26 14:24:19.821+0200 W/W_HOME  (  766): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-26 14:24:19.821+0200 E/W_HOME  (  766): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-26 14:24:19.826+0200 W/W_HOME  (  766): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-26 14:24:19.826+0200 W/W_HOME  (  766): move.c: move_move_to_apps(220) > move to apps
10-26 14:24:19.826+0200 W/W_HOME  (  766): move.c: _create_fake_apps(823) > fake image position : 432
10-26 14:24:19.826+0200 W/W_HOME  (  766): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-26 14:24:19.826+0200 W/W_HOME  (  766): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-26 14:24:19.826+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:24:19.826+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:24:19.831+0200 I/APP_CORE(  766): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 14:24:19.831+0200 W/W_HOME  (  766): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-26 14:24:19.831+0200 W/W_HOME  (  766): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 14:24:19.831+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:24:19.831+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:24:19.831+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:24:19.831+0200 W/W_HOME  (  766): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-26 14:24:19.831+0200 W/W_HOME  (  766): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-26 14:24:19.831+0200 I/wnotib  (  766): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-26 14:24:19.831+0200 I/wnotib  (  766): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-26 14:24:20.146+0200 W/W_HOME  (  766): move.c: _transit_del_cb(115) > transit end
10-26 14:24:20.146+0200 W/W_HOME  (  766): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-26 14:24:20.146+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 14:24:20.156+0200 W/W_HOME  (  766): move.c: _scroller_up_done(515) > up signal done
10-26 14:24:20.161+0200 W/W_HOME  (  766): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-26 14:24:20.161+0200 W/W_HOME  (  766): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-26 14:24:20.161+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 14:24:20.166+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 14:24:20.166+0200 W/W_HOME  (  766): main.c: home_pause(766) > clock/widget paused
10-26 14:24:20.166+0200 W/W_HOME  (  766): clock_indicator.c: clock_indicator_pause(554) > 
10-26 14:24:20.166+0200 W/W_HOME  (  766): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 14:24:20.166+0200 W/W_HOME  (  766): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-26 14:24:20.166+0200 W/W_HOME  (  766): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-26 14:24:20.166+0200 I/wnotib  (  766): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-26 14:24:20.166+0200 I/wnotib  (  766): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-26 14:24:20.166+0200 E/APPS    (  766): apps_main.c: apps_main_resume(636) >  resumed already
10-26 14:24:20.181+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
10-26 14:24:20.186+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:20.186+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:20.186+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-26 14:24:20.191+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-26 14:24:20.196+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:20.201+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:20.201+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-26 14:24:20.211+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:20.211+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:20.216+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-26 14:24:20.216+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-26 14:24:20.221+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:20.221+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:20.226+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-26 14:24:20.231+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-26 14:24:20.236+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:20.236+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:20.236+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-26 14:24:20.246+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-26 14:24:20.246+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-26 14:24:20.246+0200 W/SHealth_Common(  835): SHealthMessagePortConnection.cpp: Send(515) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 14:24:20.246+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 14:24:20.251+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __provider_pause_cb(298) > widget obj was paused
10-26 14:24:20.251+0200 W/SHealth_Common( 1074): SHealthMessagePortConnection.cpp: OnPortMessageReceived(143) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
10-26 14:24:20.251+0200 I/CAPI_WIDGET_APPLICATION(  835): widget_app.c: __check_status_for_cgroup(145) > enter background group
10-26 14:24:20.451+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236351 button=1
10-26 14:24:20.451+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.451+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:20.451+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,366,216,136]
10-26 14:24:20.486+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.501+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.501+0200 W/APPS    (  766): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 14:24:20.511+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.526+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.536+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.551+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.561+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.576+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:20.586+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236484 button=1
10-26 14:24:20.586+0200 E/APPS    (  766): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-26 14:24:20.826+0200 W/AUL_AMD (  509): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 14:24:20.826+0200 W/AUL_AMD (  509): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 14:24:21.561+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=237462 button=1
10-26 14:24:21.561+0200 E/W_HOME  (  766): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 14:24:21.566+0200 E/W_HOME  (  766): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 14:24:21.566+0200 W/APPS    (  766): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 14:24:21.651+0200 E/EFL     (  766): ecore_x<766> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=237544 button=1
10-26 14:24:21.651+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 14:24:21.656+0200 E/APPS    (  766): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 14:24:21.656+0200 W/APPS    (  766): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 14:24:21.656+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 14:24:21.656+0200 W/AUL_AMD (  509): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 14:24:21.661+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(1710) > caller pid : 766
10-26 14:24:21.661+0200 I/AUL_AMD (  509): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 14:24:21.676+0200 W/AUL_AMD (  509): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 14:24:21.676+0200 W/AUL_PAD ( 1136): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 14:24:21.676+0200 W/AUL_PAD ( 1136): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 14:24:21.706+0200 E/RESOURCED(  510): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 1
10-26 14:24:21.706+0200 E/RESOURCED(  510): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 14:24:21.741+0200 I/efl-extension( 2047): efl_extension.c: eext_mod_init(40) > Init
10-26 14:24:21.746+0200 I/UXT     ( 2047): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 14:24:21.746+0200 I/CAPI_APPFW_APPLICATION( 2047): app_main.c: ui_app_main(704) > app_efl_main
10-26 14:24:21.751+0200 I/CAPI_APPFW_APPLICATION( 2047): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 14:24:21.781+0200 E/AUL     (  509): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 14:24:21.781+0200 W/AUL     (  766): launch.c: app_request_to_launchpad(282) > request cmd(0) result(2047)
10-26 14:24:21.781+0200 E/W_HOME  (  766): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 14:24:21.781+0200 E/RESOURCED(  510): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 14:24:21.871+0200 I/Bluetooth( 2047): [bt_initialize] success.
10-26 14:24:21.911+0200 I/Bluetooth( 2047): [bt_adapter_get_state] success.
10-26 14:24:22.116+0200 W/CRASH_MANAGER( 2141): worker.c: worker_job(1205) > 1102047646174150902066
