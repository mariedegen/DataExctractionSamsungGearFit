S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 10163
Date: 2017-10-14 17:00:10+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10163, uid 5000)

Register Information
r0   = 0x00200000, r1   = 0x401d4e58
r2   = 0xbe818ea4, r3   = 0xbe818f09
r4   = 0x401d4e58, r5   = 0x00200000
r6   = 0x402cfb88, r7   = 0xbe818f18
r8   = 0x00000041, r9   = 0x40452824
r10  = 0x41f5a008, fp   = 0x00000000
ip   = 0x401ebc20, sp   = 0xbe818e38
lr   = 0x4019d13f, pc   = 0x4022df5e
cpsr = 0x20000030

Memory Information
MemTotal:   491948 KB
MemFree:     25536 KB
Buffers:     61088 KB
Cached:     163440 KB
VmPeak:      96468 KB
VmSize:      95728 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17192 KB
VmRSS:       17188 KB
VmData:      39496 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25100 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10163 TID = 10163
10163 10184 10185 10186 10187 

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
41869000 419a6000 r-xp /usr/lib/libicui18n.so.51.1
419b6000 41a9a000 r-xp /usr/lib/libicuuc.so.51.1
41aaf000 41ab7000 r-xp /usr/lib/libdrm.so.2.4.0
41abf000 41ac1000 r-xp /usr/lib/libdri2.so.0.0.0
41ac9000 41acf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41ad7000 41adc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41ae4000 41afd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41b05000 41b26000 r-xp /usr/lib/libexif.so.12.3.3
41b39000 41b3b000 r-xp /usr/lib/libttrace.so.1.1
41b43000 41b48000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
41b50000 41b56000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41b5f000 41b67000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41b6f000 41b8b000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41b94000 41b9b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41ba4000 41ba6000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41bae000 41bb5000 r-xp /usr/lib/libminizip.so.1.0.0
41bbd000 41bca000 r-xp /usr/lib/libail.so.0.1.0
41bd3000 41c9d000 r-xp /usr/lib/libCOREGL.so.4.0
41eaf000 41eba000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41ec6000 41ecb000 rw-p [heap]
41ecb000 41fe2000 rw-p [heap]
4356b000 43570000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43713000 43714000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4371d000 43f1c000 rw-p [stack:10184]
43f1d000 4471c000 rw-p [stack:10185]
4471d000 44f1c000 rw-p [stack:10186]
44f1d000 4571c000 rw-p [stack:10187]
45778000 45779000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45794000 4579b000 r-xp /usr/lib/libfeedback.so.0.1.4
457a4000 457a5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
457ad000 457af000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
457b7000 457c1000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
457c9000 457cc000 r-xp /usr/lib/libpulse-simple.so.0.0.4
458d4000 458db000 r-xp /usr/lib/libmmfcommon.so.0.0.0
458e3000 458f9000 r-xp /usr/lib/libmmfsound.so.0.1.0
4590b000 45910000 r-xp /usr/lib/libmmfsession.so.0.0.0
45918000 45922000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4592e000 45932000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4593b000 45950000 r-xp /usr/lib/libavsysaudio.so.0.0.1
45958000 459b9000 r-xp /usr/lib/libasound.so.2.0.0
459c3000 459fb000 r-xp /usr/lib/libpulse.so.0.16.2
459fc000 459ff000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
45a07000 45a38000 r-xp /usr/lib/libmdm.so.1.1.86
45a40000 45a45000 r-xp /usr/lib/libjson.so.0.0.1
45a4d000 45a95000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45a96000 45add000 r-xp /usr/lib/libsndfile.so.1.0.26
45ae9000 45af1000 r-xp /usr/lib/libmdm-common.so.1.0.89
45af2000 45b14000 r-xp /usr/lib/libvorbis.so.0.4.3
45b1c000 45b20000 r-xp /usr/lib/libogg.so.0.7.1
be7f9000 be81a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10163)
Call Stack Count: 17
 0: evas_object_smart_type_check_ptr + 0xd (0x4022df5e) [/usr/lib/libevas.so.1] + 0x34f5e
 1: elm_widget_text_part_set + 0x12 (0x4019d13f) [/usr/lib/libelementary.so.1] + 0xf513f
 2: on_sensor_event_2 + 0x96 (0x4146beef) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1eef
 3: (0x4165782f) [/usr/lib/libcapi-system-sensor.so.0] + 0x182f
 4: (0x416aaaf0) [/usr/lib/libsensor.so.1] + 0x14af0
 5: (0x403b5fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 6: g_main_context_dispatch + 0xbc (0x403b77a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 7: (0x402fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
 8: (0x402f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
 9: (0x402f94d5) [/usr/lib/libecore.so.1] + 0xc4d5
10: ecore_main_loop_begin + 0x30 (0x402f9879) [/usr/lib/libecore.so.1] + 0xc879
11: appcore_efl_main + 0x20a (0x40044523) [/usr/lib/libappcore-efl.so.1] + 0x3523
12: ui_app_main + 0xb0 (0x41441421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
13: main + 0x10e (0x4146b65b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x165b
14: create_base_gui + 0x1ea (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
15: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
16: create_base_gui + 0x55f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
00 W/WG-CONSUMER(10242): [34m[F:PeerList.cpp     L:  159][_HIGH][TX]CPeerList::CPeerList(0x42e8a844)[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:   48][_HIGH]Creating SAP Proxy Object. 0x42e8a880[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:   75][_HIGH][TX]Bind(). ASP=/app/gallery/receiver SPF=SAGalleryReceiverService Role=Consumer Channel=4444[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:ReceiverCtrl.cpp L:   65][_HIGH]CReceiverCtrl::CReceiverCtrl()[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:AutoTransfer.cpp L:  104][_HIGH]Set Event Handler. 0x40037d50[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:SAPClient.cpp    L:   79][_HIGH][RX]CSAPClient::BindPeer(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService nChannel=4444[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:PeerList.cpp     L:  159][_HIGH][RX]CPeerList::CPeerList(0x42e8c9d4)[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:   75][_HIGH][RX]Bind(). ASP=/app/gallery/transfer SPF=SAGalleryTransferService Role=Consumer Channel=4444[0m
10-14 17:00:19.805+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_NULL->SM_STATE_INITIATE[0m
10-14 17:00:19.820+0200 W/WG-CONSUMER(10242): [34m[F:consumer-app.cpp L:  135][_HIGH]Gallery file consumer SVC is started[0m
10-14 17:00:19.820+0200 I/CAPI_CONTENT_MEDIA_CONTENT(10242): media_content.c: media_content_connect(870) > [32m[10242]ref count : 0
10-14 17:00:19.820+0200 I/CAPI_CONTENT_MEDIA_CONTENT(10242): media_content.c: media_content_connect(902) > [32m[10242]ref count changed to: 1
10-14 17:00:19.820+0200 W/WG-CONSUMER(10242): [34m[F:TransferCtrl.cpp L:  115][_HIGH][TX]Connect to Peer[0m
10-14 17:00:19.830+0200 W/WG-CONSUMER(10242): [34m[F:UserNotification L:  185][_HIGH]WIPC Service Created[0m
10-14 17:00:19.830+0200 W/WG-CONSUMER(10242): [34m[F:SAPClient.cpp    L:   95][_HIGH][TX]CSAPClient::Connect()[0m
10-14 17:00:19.830+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  122][_HIGH][TX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 17:00:19.830+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=0 pConnection=0x42e8b878[0m
10-14 17:00:19.830+0200 E/WG-CONSUMER(10242): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 17:00:19.830+0200 E/WG-CONSUMER(10242): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 17:00:19.845+0200 E/WG-CONSUMER(10242): [31m[F:consumer-app.cpp L:  147][ERROR]TX Connection Error[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:ReceiverCtrl.cpp L:  493][_HIGH][RX]Connect to Peer[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:SAPClient.cpp    L:   95][_HIGH][RX]CSAPClient::Connect()[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  122][_HIGH][RX]CConnection::Connect() State:SM_STATE_INITIATE[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:  131][_HIGH]CSAPProxy::Connect. Size=1 pConnection=0x42e8c928[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:  134][_HIGH]  Connection : [TX] LocalAgentID:0 ServiceHandle:0[0m
10-14 17:00:19.845+0200 E/WG-CONSUMER(10242): [31m[F:SAPProxy.cpp     L:  149][ERROR]Previous pCurrent(0x42e8b878) is exist[0m
10-14 17:00:19.845+0200 E/WG-CONSUMER(10242): [31m[F:SAPProxy.cpp     L:  272][ERROR]SAP disconnected[0m
10-14 17:00:19.845+0200 E/WG-CONSUMER(10242): [31m[F:SAPProxy.cpp     L:  330][ERROR]All connection is disconnected[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:  174][_HIGH]Device dis-connected. WMS=0 BT=0 [0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  143][_HIGH]SAP is not conneced.[0m
10-14 17:00:19.845+0200 E/WG-CONSUMER(10242): [31m[F:consumer-app.cpp L:  153][ERROR]RX Connection Error[0m
10-14 17:00:19.845+0200 W/WG-CONSUMER(10242): [34m[F:consumer-app.cpp L:  192][_HIGH]Gallery consumer SVC on Param. Handle=0x42eb3e48[0m
10-14 17:00:19.845+0200 W/CAPI_APPFW_APP_CONTROL(10242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 17:00:19.845+0200 W/CAPI_APPFW_APP_CONTROL(10242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-14 17:00:19.890+0200 W/WG-CONSUMER(10242): [34m[F:consumer-app.cpp L:  307][_HIGH]exit from volt[0m
10-14 17:00:19.890+0200 I/CAPI_APPFW_APPLICATION(10242): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 17:00:19.900+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 17:00:19.900+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:consumer-app.cpp L:  166][_HIGH]Gallery consumer SVC is terminated[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:TransferCtrl.cpp L:  125][_HIGH][TX]Disconnect to Peer[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  154][_HIGH][TX]CConnection::Disconnect()[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  635][_HIGH][TX]SAPManager(0x42e8b878) Disconnect(155)[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 17:00:19.900+0200 E/WIPC_SERVER(10242): wipc_server.c: wipc_server_final(658) > [0;31m* Critical * __dbus_conn is null[0;m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:UserNotification L:  207][_HIGH]WIPC Service Delete[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ReceiverCtrl.cpp L:  500][_HIGH][RX]Disconnect to Peer[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  154][_HIGH][RX]CConnection::Disconnect()[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  635][_HIGH][RX]SAPManager(0x42e8c928) Disconnect(155)[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  636][_HIGH]  SM_STATE_INITIATE LocalAgentID=0 ServiceHandle=0 ChannelID=4444[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  637][_HIGH]  FTSTATE_INIT PeerCount=0 bTryingWFD=0 RetryTimer=0 nPeerTimer=0[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=0 pConnected=(nil)[0m
10-14 17:00:19.900+0200 W/WG-CONSUMER(10242): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_INITIATE->SM_STATE_INITIATE[0m
10-14 17:00:19.905+0200 I/CAPI_CONTENT_MEDIA_CONTENT(10242): media_content.c: media_content_disconnect(958) > [32m[10242]ref count changed to: 0
10-14 17:00:20.000+0200 W/MUSIC_TRANSFER(10245): mt-service.c: main(142) > [33m[TID:10245]   service start[0m
10-14 17:00:20.005+0200 W/MUSIC_TRANSFER(10245): mt-service.c: _service_app_create(65) > [33m[TID:10245]   [0m
10-14 17:00:20.010+0200 E/WG-CONSUMER(10242): [31m[F:consumer-app.cpp L:  407][ERROR]Terminate main. nRet=0[0m
10-14 17:00:20.010+0200 W/WG-CONSUMER(10242): [34m[F:ReceiverCtrl.cpp L:   76][_HIGH]CReceiverCtrl::~CReceiverCtrl()[0m
10-14 17:00:20.010+0200 W/WG-CONSUMER(10242): [34m[F:PeerList.cpp     L:  163][_HIGH][RX]CPeerList::~CPeerList(0x42e8c9d4)[0m
10-14 17:00:20.010+0200 W/WG-CONSUMER(10242): [34m[F:TransferCtrl.cpp L:   87][_HIGH]CTransferCtrl::~CTransferCtrl()[0m
10-14 17:00:20.010+0200 W/WG-CONSUMER(10242): [34m[F:AlarmSvc.cpp     L:   86][_HIGH]CAlarmSvc::~CAlarmSvc() hAlarm:0x00000000[0m
10-14 17:00:20.010+0200 W/WG-CONSUMER(10242): [34m[F:SAPProxy.cpp     L:   62][_HIGH]Destroying SAP Proxy Object. 0x42e8a880[0m
10-14 17:00:20.010+0200 W/WG-CONSUMER(10242): [34m[F:PeerList.cpp     L:  163][_HIGH][TX]CPeerList::~CPeerList(0x42e8a844)[0m
10-14 17:00:20.025+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(305) > [windicator_battery_icon_update:305] 100%
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:00:20.080+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:20.105+0200 E/EFL     (  714): <714> elm_main.c:1180 elm_object_part_text_set() safety check failed: obj == NULL
10-14 17:00:20.105+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(315) > [windicator_battery_icon_update:315] battery_level: 100, isCharging: 1
10-14 17:00:20.105+0200 W/W_INDICATOR(  714): windicator_battery.c: windicator_battery_icon_update(342) > [windicator_battery_icon_update:342] [SIGNAL] battery file : change_level_100
10-14 17:00:20.105+0200 E/W_INDICATOR(  714): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(128) > [wnidicator_moment_view_battery_image_update:128] Debugging mode!, Clicked!!
10-14 17:00:20.105+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(177) > [_battery_charger_status_changed_cb:177] TA connected or abnormal
10-14 17:00:20.105+0200 W/W_INDICATOR(  714): windicator_battery.c: _battery_charger_status_changed_cb(195) > [_battery_charger_status_changed_cb:195] Show Moment View to display charging animation
10-14 17:00:20.160+0200 W/MUSIC_PLAYER(10245): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:10245]   W_SERVICE_TYPE_BT[1][0m
10-14 17:00:20.160+0200 W/MUSIC_PLAYER(10245): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:10245]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-14 17:00:20.165+0200 W/MUSIC_TRANSFER(10245): mt-service.c: _service_app_create(88) > [31m[TID:10245]   SAP is disconnected.. Terminate process[0m
10-14 17:00:20.165+0200 I/CAPI_APPFW_APPLICATION(10245): service_app_main.c: service_app_exit(441) > service_app_exit
10-14 17:00:20.210+0200 W/AUL_AMD (  532): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-14 17:00:20.210+0200 W/AUL_AMD (  532): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-14 17:00:20.230+0200 W/MUSIC_PLAYER(10245): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:10245]   vendor : LO[0m
10-14 17:00:20.250+0200 W/MUSIC_PLAYER(10245): mp-conf.c: mp_conf_init(262) > [33m[TID:10245]   iOS  connected..[0m
10-14 17:00:20.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(10245): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-14 17:00:20.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(10245): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-14 17:00:20.255+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(10245): preference.c: preference_get_int(1132) > preference_get_int(10245) : key(tutorial_complete) error
10-14 17:00:20.260+0200 E/RESOURCED(  536): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/10242/oom_score_adj failed
10-14 17:00:20.260+0200 E/RESOURCED(  536): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 10242
10-14 17:00:20.260+0200 E/RESOURCED(  536): proc-main.c: proc_add_app_list(272) > not found previous pai : com.samsung.w-music-transfer.consumer
10-14 17:00:20.270+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 22
10-14 17:00:20.270+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(916) > app status : 4
10-14 17:00:20.270+0200 W/MUSIC_TRANSFER(10245): mt-service.c: _service_app_terminate(104) > [33m[TID:10245]   [0m
10-14 17:00:20.395+0200 E/RESOURCED( 1156): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 17:00:20.405+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.2790
10-14 17:00:20.410+0200 E/RESOURCED(  536): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.2792
10-14 17:00:20.420+0200 E/AUL     ( 1156): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 17:00:20.420+0200 W/AUL     (10259): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-gallery.consumer]
10-14 17:00:20.425+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 17:00:20.425+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 17:00:20.425+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10242
10-14 17:00:20.425+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 17:00:20.440+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 17:00:20.485+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10242
10-14 17:00:20.510+0200 E/W_INDICATOR(  714): windicator_moment_view.c: windicator_moment_view_show(1505) > [windicator_moment_view_show:1505] Show Moment View : type(1)
10-14 17:00:20.520+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1648) > [windicator_init_battery_rect:1648] battery level 100, index 20, bg level 100
10-14 17:00:20.535+0200 W/W_INDICATOR(  714): windicator_moment_view.c: windicator_init_battery_rect(1652) > [windicator_init_battery_rect:1652] Battery signal emit : bg_level_90
10-14 17:00:20.590+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] PRE LCD ON - charge
10-14 17:00:20.605+0200 E/ALARM_MANAGER(  484): alarm-manager.c: __is_cached_cookie(219) > No cached cookie for [10189]
10-14 17:00:20.605+0200 W/ALARM_MANAGER(  484): alarm-manager.c: __check_privilege_by_cookie(1643) > Try to read procfs status
10-14 17:00:20.605+0200 W/ALARM_MANAGER(  484): alarm-manager.c: __check_privilege_by_cookie(1647) > Read procfs status successfully
10-14 17:00:20.630+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_get_angle(613) > [_windicator_get_angle:613] Unknown state(0)
10-14 17:00:20.675+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:00:20.690+0200 W/W_HOME  ( 1063): event_manager.c: _ecore_x_message_cb(414) > state: 0 -> 1
10-14 17:00:20.770+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(650) > [_windicator_rotation_changed_cb:650] invliad state, Add timer :0 angle:-1
10-14 17:00:20.770+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.770+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.770+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.775+0200 W/APP_CORE(  714): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000a
10-14 17:00:20.780+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:00:20.780+0200 W/AUL     (10261): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-14 17:00:20.785+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 23
10-14 17:00:20.785+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-14 17:00:20.785+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 10245
10-14 17:00:20.785+0200 W/AUL_AMD (  532): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-14 17:00:20.795+0200 I/AUL_AMD (  532): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10245
10-14 17:00:20.800+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [true][0m
10-14 17:00:20.810+0200 I/SCONTEXT-LIB(10189): feature_wearable.cpp: cx_is_feature_supported(97) > Initializing the feature map
10-14 17:00:20.815+0200 I/SCONTEXT-LIB(10189): comm.c: cx_connect_dbus(123) > Connecting Dbus
10-14 17:00:20.845+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(1)
10-14 17:00:20.845+0200 W/W_HOME  ( 1063): event_manager.c: _window_visibility_cb(463) > state: 1 -> 0
10-14 17:00:20.845+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.845+0200 W/W_HOME  ( 1063): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(1)
10-14 17:00:20.850+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: PAUSE State: RUNNING
10-14 17:00:20.850+0200 I/CAPI_APPFW_APPLICATION( 1063): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-14 17:00:20.850+0200 W/W_HOME  ( 1063): main.c: _appcore_pause_cb(696) > appcore pause
10-14 17:00:20.850+0200 W/W_HOME  ( 1063): event_manager.c: _app_pause_cb(383) > state: 1 -> 2
10-14 17:00:20.850+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.850+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.850+0200 W/W_HOME  ( 1063): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:00:20.860+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:00:20.865+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:20.870+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:00:20.875+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:00:20.875+0200 E/W_INDICATOR(  714): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-14 17:00:20.875+0200 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESUME State: PAUSED
10-14 17:00:20.875+0200 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:00:20.930+0200 W/wnotib  ( 1063): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 1
10-14 17:00:20.950+0200 I/SCONTEXT-LIB(10189): comm.c: cx_connect_dbus(148) > Dbus connected: ':1.2794'
10-14 17:00:20.950+0200 I/SCONTEXT-LIB(10189): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 45 (req_id=1)
10-14 17:00:20.950+0200 I/SCONTEXT-LIB(10189): scontext.c: context_get_context(108) > [SUCCESS] Get Context: 45 (req_id=2)
10-14 17:00:21.025+0200 W/W_CLOCK_VIEWER(10189): clock-viewer-util-dbus.c: clock_viewer_util_dbus_get_device_angle(152) >  Get device angle[2]
10-14 17:00:21.025+0200 W/W_CLOCK_VIEWER(10189): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-14 17:00:21.030+0200 I/APP_CORE(10189): appcore-efl.c: __do_app(429) > [APP 10189] Event: RESET State: CREATED
10-14 17:00:21.030+0200 I/W_INDICATOR(  714): windicator_brightness.c: _current_device_brightness_level_get(143) > [_current_device_brightness_level_get:143] Brightness level : 80
10-14 17:00:21.030+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(818) > [windicator_brightness_update:818] current device brightness level : 80 / isOutdoorMode : 0
10-14 17:00:21.030+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_update(827) > [windicator_brightness_update:827] NOT Outdoor mode
10-14 17:00:21.030+0200 I/CAPI_APPFW_APPLICATION(10189): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-14 17:00:21.030+0200 W/W_INDICATOR(  714): windicator_brightness.c: windicator_brightness_icon_set_by_level(771) > [windicator_brightness_icon_set_by_level:771] layout(0x443f5e30) signal name : brightness.icon.7
10-14 17:00:21.050+0200 W/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1219) > _signal_context_handler: type: 0, state: 3
10-14 17:00:21.050+0200 I/WATCH_CORE( 1130): appcore-watch.c: __signal_context_handler(1236) > Call the time_tick_cb
10-14 17:00:21.050+0200 I/CAPI_WATCH_APPLICATION( 1130): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-14 17:00:21.055+0200 E/EFL     (  714): edje<714> edje_util.c:3770 edje_object_size_min_restricted_calc() group windicator/brightness/small_layout has a non-fixed part 'txt.brightness'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-14 17:00:21.060+0200 E/WMS     (  499): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(21860) > wear_monitor_status update[0] = 2 -> 2
10-14 17:00:21.060+0200 E/wnoti-service(  838): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 2 
10-14 17:00:21.070+0200 W/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(657) > [_windicator_rotation_changed_cb:657] Got specific angle, so delete timer!
10-14 17:00:21.070+0200 E/W_INDICATOR(  714): windicator_dbus.c: _windicator_rotation_changed_cb(664) > [_windicator_rotation_changed_cb:664] Debugging mode ON, and clicked Charging watch.
10-14 17:00:21.085+0200 I/APP_CORE(10189): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
10-14 17:00:21.085+0200 I/APP_CORE(10189): appcore-efl.c: __do_app(474) > [APP 10189] Initial Launching, call the resume_cb
10-14 17:00:21.085+0200 I/CAPI_APPFW_APPLICATION(10189): app_main.c: app_appcore_resume(223) > app_appcore_resume
10-14 17:00:21.100+0200 W/APP_CORE(10189): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000002
10-14 17:00:21.170+0200 E/RESOURCED( 1156): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 17:00:21.180+0200 W/SHealth_Common( 1005): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-14 17:00:21.190+0200 W/SHealth_Service( 1005): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-14 17:00:21.200+0200 E/DATA_PROVIDER_MASTER(  706): package.c: package_alter_instances_to_client(1695) > Failed to load a buffer
10-14 17:00:21.205+0200 W/W_CLOCK_VIEWER(10189): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(194) >  get_info_cb called err[0], context[45], data[{ "Time" : 1507993221031, "Reason" : 0, "Status" : 2 }], req_id[2]
10-14 17:00:21.205+0200 W/W_CLOCK_VIEWER(10189): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_get_info_cb(214) >  status[2] Wear OFF
10-14 17:00:21.205+0200 W/W_CLOCK_VIEWER(10189): clock-viewer.c: __clock_viewer_lcdon_completed_cb(471) >  event lcdon completed[1]
10-14 17:00:21.205+0200 W/W_CLOCK_VIEWER(10189): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[1]
10-14 17:00:21.205+0200 W/W_CLOCK_VIEWER(10189): clock-viewer.c: clock_viewer_hide(1298) >  reservied[0], gesture[0], clock visible[0]
10-14 17:00:21.205+0200 W/W_CLOCK_VIEWER(10189): clock-viewer.c: _clock_viewer_send_clock_changed(919) >  clock changed <<
10-14 17:00:21.220+0200 E/WIDGET_VIEWER(10189): client.c: master_created(1712) > [31,331347] pkgname: com.samsung.idle-clock-volt_sparkle, id: file:///opt/usr/share/live_magazine/com.samsung.idle-clock-volt_sparkle_1063_31,331347.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 216, widget_h: 432, cluster: user,created, category: default, widget_fname: "pixmap://29360130:4", gbar_fname: "", auto_launch: , priority: 0,000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0,000000, title: [], is_pinned_up: 0
10-14 17:00:21.225+0200 E/DATA_PROVIDER_MASTER(  706): shared_fd_service.c: direct_hello_handler(66) > Client is not exists: 
10-14 17:00:21.225+0200 E/AUL     ( 1156): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 17:00:21.225+0200 E/CAPI_APPFW_APP_MANAGER( 1156): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 17:00:21.235+0200 E/WIDGET_EVAS(10189): widget_viewer_evas.c: __widget_resize(5444) > Failed to get box size
10-14 17:00:21.235+0200 W/W_CLOCK_VIEWER(10189): clock-viewer-dbox.c: __clock_viewer_widget_raw_event_cb(257) >  DBOX Created[com.samsung.idle-clock-volt_sparkle] it should be [com.samsung.idle-clock-volt_sparkle]
10-14 17:00:21.235+0200 W/W_CLOCK_VIEWER(10189): clock-viewer-dbox.c: _clock_viewer_widget_list_append(128) >  >>>Append to list[com.samsung.idle-clock-volt_sparkle][0x4177af38]
10-14 17:00:21.245+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-14 17:00:21.245+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-14 17:00:21.250+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1005): preference.c: preference_get_boolean(1173) > preference_get_boolean(1005) : test_healthy_pace error
10-14 17:00:21.250+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
10-14 17:00:21.310+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:00:21.320+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1063
10-14 17:00:21.380+0200 I/APP_CORE( 1063): appcore-efl.c: __do_app(429) > [APP 1063] Event: MEM_FLUSH State: PAUSED
10-14 17:00:21.385+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:00:21.400+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:00:21.400+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:00:21.400+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:00:21.400+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:00:21.400+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:00:21.425+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:21.425+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:00:21.425+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:00:21.430+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:00:21.430+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:00:21.440+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:00:21.440+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:00:21.440+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:00:21.445+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:00:21.465+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:21.465+0200 W/W_HOME  ( 1063): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-14 17:00:21.465+0200 E/W_HOME  ( 1063): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-14 17:00:21.485+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:00:21.485+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:00:21.485+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-14 17:00:21.485+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-14 17:00:21.490+0200 I/MESSAGE_PORT(  489): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-14 17:00:21.500+0200 E/CAPI_APPFW_APP_CONTROL( 1814): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-14 17:00:21.505+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1814]   [com.samsung.w-home]register msg port [false][0m
10-14 17:00:21.525+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-14 17:00:21.530+0200 E/CAPI_NETWORK_BLUETOOTH( 1814): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-14 17:00:21.535+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1814]   bt_gatt_client_get_service Error[-22][0m
10-14 17:00:21.535+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1814]   remote mode[0][0m
10-14 17:00:21.545+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:00:21.545+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1814]   [MUSIC_PLAYER_EVENT][0m
10-14 17:00:21.550+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
10-14 17:00:21.555+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
10-14 17:00:21.555+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1814): preference.c: preference_get_int(1132) > preference_get_int(1814) : key(music-control-service_native/playing_diration) error
10-14 17:00:21.560+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:1814]   preference_get_int() .. [0xfef00030][0m
10-14 17:00:21.560+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1814]   bundle_add_str() .. [0xffffffea][0m
10-14 17:00:21.620+0200 I/TIZEN_N_SOUND_MANAGER( 1814): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-14 17:00:21.620+0200 E/TIZEN_N_SOUND_MANAGER( 1814): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-14 17:00:21.620+0200 W/MUSIC_CONTROL_SERVICE( 1814): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1814]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-14 17:00:21.630+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:00:21.640+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10189
10-14 17:00:21.650+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:00:21.760+0200 W/SHealth_Service( 1005): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1142) > [1;40;33mOnNotWearingStart[0;m
10-14 17:00:21.900+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 17:00:21.990+0200 I/APP_CORE( 4604): appcore-efl.c: __do_app(429) > [APP 4604] Event: MEM_FLUSH State: PAUSED
10-14 17:00:22.180+0200 E/RESOURCED( 1005): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 17:00:22.180+0200 E/AUL     ( 1005): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 17:00:22.180+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 17:00:22.180+0200 W/SHealth_Common( 1005): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1507939200000,000000[0;m
10-14 17:00:22.240+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:00:22.250+0200 E/RESOURCED( 1005): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-14 17:00:22.250+0200 E/AUL     ( 1005): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-14 17:00:22.250+0200 E/CAPI_APPFW_APP_MANAGER( 1005): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-14 17:00:22.260+0200 W/SHealth_Common( 1005): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
10-14 17:00:22.270+0200 W/AUL_AMD (  532): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-14 17:00:22.310+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 14
10-14 17:00:22.325+0200 W/AUL_AMD (  532): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10189
10-14 17:00:22.325+0200 W/AUL_AMD (  532): amd_request.c: __request_handler(645) > __request_handler: 12
10-14 17:00:22.340+0200 I/HealthDataService(  770): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-14 17:00:22.375+0200 I/healthData( 1005): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-14 17:00:22.535+0200 W/CRASH_MANAGER(10125): worker.c: worker_job(1205) > 1110163646174150799321
