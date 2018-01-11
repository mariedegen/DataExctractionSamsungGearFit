S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 2131
Date: 2017-12-09 11:15:21+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2131, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4059d250, r3   = 0x41744d59
r4   = 0xbef77504, r5   = 0x41541980
r6   = 0x00000249, r7   = 0xbef77440
r8   = 0xbef774d4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x41757588, sp   = 0xbef77428
lr   = 0x41744d75, pc   = 0x417462a8
cpsr = 0x80000030

Memory Information
MemTotal:   491948 KB
MemFree:     94956 KB
Buffers:     26588 KB
Cached:     153424 KB
VmPeak:      98844 KB
VmSize:      97368 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20436 KB
VmRSS:       20432 KB
VmData:      41404 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25044 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 2131 TID = 2131
2131 2225 2232 2233 

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
41793000 41798000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a0000 417a4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417ad000 417ce000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d7000 41811000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
4181a000 41833000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
4183b000 41840000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41848000 41872000 r-xp /usr/lib/libsensor.so.1.9.6
4187b000 41933000 r-xp /usr/lib/libcairo.so.2.11200.14
4193e000 41941000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41949000 4194f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41958000 41960000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41968000 41972000 r-xp /usr/lib/libsensord-shared.so
4197b000 41989000 r-xp /usr/lib/libGLESv2.so.2.0
41992000 41993000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4199c000 419a2000 r-xp /usr/lib/libxcb-render.so.0.0.0
419aa000 419ad000 r-xp /usr/lib/libEGL.so.1.4
419b5000 419c2000 r-xp /usr/lib/libail.so.0.1.0
419cb000 41b08000 r-xp /usr/lib/libicui18n.so.51.1
41b18000 41bfc000 r-xp /usr/lib/libicuuc.so.51.1
4319a000 431b6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
431bf000 431c6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
431cf000 431d1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
431d9000 431e0000 r-xp /usr/lib/libminizip.so.1.0.0
431e8000 432b2000 r-xp /usr/lib/libCOREGL.so.4.0
435c5000 43dc4000 rw-p [stack:2225]
43dc4000 43dcf000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dd8000 43ddd000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43deb000 43df3000 r-xp /usr/lib/libdrm.so.2.4.0
43dfb000 43e02000 r-xp /usr/lib/libtbm.so.1.0.0
43e0a000 43e0c000 r-xp /usr/lib/libdri2.so.0.0.0
43eaf000 43eb0000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
43fb9000 447b8000 rw-p [stack:2232]
447b9000 44fb8000 rw-p [stack:2233]
458cc000 458cd000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
458d5000 458d8000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
458e8000 458ef000 r-xp /usr/lib/libfeedback.so.0.1.4
458f8000 458f9000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45901000 45903000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
4590b000 45915000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.51
4591d000 45924000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4592c000 45942000 r-xp /usr/lib/libmmfsound.so.0.1.0
45954000 45959000 r-xp /usr/lib/libmmfsession.so.0.0.0
45961000 4596b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
45977000 4597b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
45984000 45999000 r-xp /usr/lib/libavsysaudio.so.0.0.1
459a1000 45a02000 r-xp /usr/lib/libasound.so.2.0.0
45a0c000 45a0f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
45a17000 45a4f000 r-xp /usr/lib/libpulse.so.0.16.2
45a50000 45a81000 r-xp /usr/lib/libmdm.so.1.1.86
45a89000 45a8e000 r-xp /usr/lib/libjson.so.0.0.1
45a96000 45ade000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
45adf000 45b26000 r-xp /usr/lib/libsndfile.so.1.0.26
45b32000 45b3a000 r-xp /usr/lib/libmdm-common.so.1.0.89
45b3b000 45b5d000 r-xp /usr/lib/libvorbis.so.0.4.3
45b65000 45b69000 r-xp /usr/lib/libogg.so.0.7.1
45ccd000 45cce000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
bef57000 bef78000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2131)
Call Stack Count: 9
 0: stop_bt_server + 0x27 (0x417462a8) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x32a8
 1: app_terminate + 0x1c (0x41744d75) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d75
 2: (0x41540af9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1af9
 3: appcore_efl_main + 0x280 (0x40044599) [/usr/lib/libappcore-efl.so.1] + 0x3599
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x66 (0x41744d07) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d07
 6: bluetooth_screen + 0xda (0x4000199b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x199b
 7: __libc_start_main + 0x114 (0x4048e82c) [/lib/libc.so.6] + 0x1782c
 8: main + 0x6f (0x40001d10) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1d10
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
13:57.350+0200 E/EFL     ( 2131): ecore_x<2131> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=284717 button=1
12-09 11:13:57.515+0200 E/RECORDING_TAG( 2131): sensor_listener_unset_event_cb error: -38010874
12-09 11:13:57.525+0200 E/EFL     ( 2131): elementary<2131> elc_naviframe.c:2878 elm_naviframe_item_pop() naviframe item pop
12-09 11:13:57.525+0200 E/EFL     ( 2131): elementary<2131> elc_naviframe.c:2158 _pop_transition_cb() pop transition cb
12-09 11:13:57.655+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 3
12-09 11:13:57.655+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
12-09 11:13:57.715+0200 E/EFL     ( 2131): elementary<2131> elc_naviframe.c:1211 _on_item_show_finished() item show finished
12-09 11:13:57.955+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 64
12-09 11:13:57.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:13:58.950+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 67
12-09 11:13:58.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:13:59.950+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:13:59.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:00.090+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:14:00.090+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:00.095+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:14:00.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:01.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:01.950+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 75
12-09 11:14:01.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 75
12-09 11:14:02.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 77
12-09 11:14:03.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 77
12-09 11:14:03.950+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 78
12-09 11:14:03.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 78
12-09 11:14:04.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 79
12-09 11:14:05.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 79
12-09 11:14:05.950+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 79
12-09 11:14:05.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 79
12-09 11:14:06.955+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 77
12-09 11:14:06.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 77
12-09 11:14:07.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 76
12-09 11:14:07.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 76
12-09 11:14:08.955+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 75
12-09 11:14:08.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 75
12-09 11:14:09.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 73
12-09 11:14:09.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 73
12-09 11:14:10.955+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:10.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:11.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:11.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:12.955+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:12.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:13.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:13.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:14.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:14.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:15.955+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:15.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:16.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:17.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:17.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:18.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:18.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:19.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:19.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:20.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:20.960+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 67
12-09 11:14:20.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:14:21.960+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 67
12-09 11:14:21.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:14:22.960+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 67
12-09 11:14:22.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:14:23.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 68
12-09 11:14:24.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 68
12-09 11:14:24.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:24.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:25.965+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:25.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:26.820+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:14:26.825+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:14:26.825+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:14:26.825+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:14:26.825+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:14:26.825+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:14:26.825+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:14:26.825+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
12-09 11:14:26.825+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:14:26.830+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:14:26.830+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:14:26.835+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:14:27.035+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:14:27.055+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:14:27.135+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 73
12-09 11:14:27.145+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
12-09 11:14:27.145+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:14:27.145+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 73
12-09 11:14:27.145+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:14:27.150+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:14:27.150+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:14:47), repeat(1), interval(20), type(-1073741822)
12-09 11:14:27.160+0200 I/APP_CORE( 2131): appcore-efl.c: __do_app(429) > [APP 2131] Event: PAUSE State: RUNNING
12-09 11:14:27.160+0200 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:14:27.170+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:14:27.175+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:14:27.240+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1377995421, next duetime: 1512810887
12-09 11:14:27.240+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1377995421)
12-09 11:14:27.240+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512810887)
12-09 11:14:27.245+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:14:27.245+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:14:47 (UTC).
12-09 11:14:27.245+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:14:27.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 75
12-09 11:14:28.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 75
12-09 11:14:28.815+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:14:28.815+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:14:28.815+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:14:28.825+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:14:28.825+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:14:28.825+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:14:28.825+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:14:28.825+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:1887
12-09 11:14:28.825+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:14:28.825+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:14:28.825+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:14:28.835+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [1887]ms
12-09 11:14:28.835+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:14:28.875+0200 W/W_HOME  (  779): gesture.c: _widget_updated_cb(194) > widget updated
12-09 11:14:28.875+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:14:28.875+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:14:28.905+0200 I/APP_CORE( 2131): appcore-efl.c: __do_app(429) > [APP 2131] Event: RESUME State: PAUSED
12-09 11:14:28.905+0200 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:14:28.980+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:14:28.990+0200 I/MALI    (  779): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4427f090] swap changed from sync to async
12-09 11:14:28.995+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:14:29.010+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:14:29.015+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:14:29.015+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:14:29.035+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:14:29.035+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(1377995421)
12-09 11:14:29.035+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:14:29.035+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:14:29.035+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:14:29.035+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[1377995421] is removed.
12-09 11:14:29.050+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:14:29.060+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:29.060+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:14:29.060+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:14:29.060+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:14:29.065+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-09 11:14:29.065+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:14:29.065+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:14:29.080+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 76
12-09 11:14:29.085+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 76
12-09 11:14:29.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:29.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:30.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:30.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:31.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:31.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:32.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:32.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:33.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:33.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:34.970+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:34.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:35.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:35.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:36.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:37.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:37.715+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(934) > [_dynamic_wifi_state_changed_cb:934] wifi state : 2, strength : 4
12-09 11:14:37.715+0200 W/W_INDICATOR(  708): windicator_dynamic.c: _dynamic_wifi_state_changed_cb(937) > [_dynamic_wifi_state_changed_cb:937] SHOW Wifi icon!
12-09 11:14:37.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:37.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:38.455+0200 E/WMS     (  497): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
12-09 11:14:38.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:38.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:39.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:40.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:40.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:41.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:41.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:41.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:42.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:43.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:43.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:44.010+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:44.975+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:14:44.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:14:45.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:46.010+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:46.980+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:46.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:47.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:48.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:48.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:49.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:50.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:50.030+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:50.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:51.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:51.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:14:52.010+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:14:52.210+0200 W/SHealth_Common( 1081): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1512777600000,000000[0;m
12-09 11:14:52.275+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (376089)]][0;m
12-09 11:14:52.375+0200 W/SHealthWidget(  839): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (376089), msgName: timeline_summary_updated[0;m
12-09 11:14:52.375+0200 W/SHealth_Common(  839): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
12-09 11:14:52.390+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
12-09 11:14:52.415+0200 I/HealthDataService(  783): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-09 11:14:52.460+0200 I/healthData( 1081): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-09 11:14:52.470+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 11:14:52.470+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 11:14:52.470+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 11:14:52.470+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 11:14:52.500+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_update_cb(281) > received updating signal
12-09 11:14:52.500+0200 E/EFL     (  839): edje<839> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-09 11:14:52.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:53.030+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:53.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:14:54.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:14:55.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 64
12-09 11:14:55.035+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:14:56.010+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 63
12-09 11:14:56.045+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:14:56.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 63
12-09 11:14:57.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:14:57.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 63
12-09 11:14:58.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:14:58.210+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 11:14:58.210+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
12-09 11:14:58.210+0200 W/W_HOME  (  779): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
12-09 11:14:58.210+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:14:58.210+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 1
12-09 11:14:58.210+0200 W/W_HOME  (  779): event_manager.c: _lcd_off_cb(704) > lcd state: 0
12-09 11:14:58.210+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:14:58.215+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
12-09 11:14:58.215+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
12-09 11:14:58.215+0200 E/STARTER (  696): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 11:14:58.215+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
12-09 11:14:58.215+0200 W/STARTER (  696): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
12-09 11:14:58.465+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:14:58.480+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
12-09 11:14:58.565+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
12-09 11:14:58.565+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:14:58.565+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
12-09 11:14:58.565+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
12-09 11:14:58.565+0200 E/ALARM_MANAGER(  696): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(9-12-2017, 11:15:19), repeat(1), interval(20), type(-1073741822)
12-09 11:14:58.590+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:14:58.595+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:14:58.620+0200 I/APP_CORE( 2131): appcore-efl.c: __do_app(429) > [APP 2131] Event: PAUSE State: RUNNING
12-09 11:14:58.620+0200 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:14:58.675+0200 E/ALARM_MANAGER(  485): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 542182817, next duetime: 1512810919
12-09 11:14:58.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(542182817)
12-09 11:14:58.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1512823500), due_time(1512810919)
12-09 11:14:58.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:14:58.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 09:15:19 (UTC).
12-09 11:14:58.675+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:14:58.985+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 63
12-09 11:14:59.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:14:59.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 63
12-09 11:15:00.035+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:15:00.185+0200 W/SHealth_Service( 1081): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(678) > [1;35mpedometerMode: 0, length of Array [1][0;m
12-09 11:15:00.215+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: pedo_update client list: [2:com.samsung.shealth.steps_widget (879715)]][0;m
12-09 11:15:00.280+0200 W/SHealth_Common( 1081): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_int(1132) > preference_get_int(1081) : key(pedometer_goal_achieve_percents) error
12-09 11:15:00.285+0200 W/SHealthWidget(  839): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.steps_widget (879715), msgName: pedo_update[0;m
12-09 11:15:00.285+0200 W/SHealth_Common(  839): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: pedo_update[0;m
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
12-09 11:15:00.285+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 11:15:00.285+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 11:15:00.285+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 11:15:00.285+0200 E/TIZEN_N_SYSTEM_SETTINGS(  839): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:00.285+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_int(1132) > preference_get_int(1081) : key(best_step_goal) error
12-09 11:15:00.285+0200 W/SHealthWidget(  839): VisualTriangleProgress.cpp: SetRate(227) > [1;40;33mmRate == percent[0;m
12-09 11:15:00.285+0200 I/CAPI_WIDGET_APPLICATION(  839): widget_app.c: __provider_update_cb(281) > received updating signal
12-09 11:15:00.290+0200 E/EFL     (  839): edje<839> edje_util.c:3770 edje_object_size_min_restricted_calc() group steps_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-09 11:15:00.305+0200 I/HealthDataService(  783): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-09 11:15:00.340+0200 I/healthData( 1081): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-09 11:15:00.345+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:15:00.345+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:00.345+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:15:00.350+0200 W/SHealth_Service( 1081): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
12-09 11:15:00.915+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
12-09 11:15:00.915+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
12-09 11:15:00.920+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:15:00.930+0200 W/W_HOME  (  779): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 11:15:00.930+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_set(165) > timer set
12-09 11:15:00.930+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:15:00.930+0200 W/W_HOME  (  779): gesture.c: _apps_status_get(126) > apps status:0
12-09 11:15:00.930+0200 W/W_HOME  (  779): gesture.c: _lcd_on_cb(312) > move_to_clock:0 clock_visible:0 info->offtime:2647
12-09 11:15:00.930+0200 W/W_HOME  (  779): gesture.c: _manual_render_schedule(212) > schedule, manual render
12-09 11:15:00.930+0200 W/W_HOME  (  779): event_manager.c: _lcd_on_cb(696) > lcd state: 1
12-09 11:15:00.930+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:00.935+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [2647]ms
12-09 11:15:00.935+0200 W/STARTER (  696): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:15:00.975+0200 W/W_HOME  (  779): gesture.c: _widget_updated_cb(194) > widget updated
12-09 11:15:00.975+0200 W/W_HOME  (  779): gesture.c: _manual_render_disable_timer_del(155) > timer del
12-09 11:15:00.975+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:15:01.010+0200 W/W_HOME  (  779): gesture.c: _manual_render(180) > 
12-09 11:15:01.025+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 63
12-09 11:15:01.070+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 63
12-09 11:15:01.085+0200 W/SHealth_Common(  839): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:15:01.090+0200 W/W_HOME  (  779): gesture.c: _manual_render_enable(136) > 0
12-09 11:15:01.100+0200 I/APP_CORE( 2131): appcore-efl.c: __do_app(429) > [APP 2131] Event: RESUME State: PAUSED
12-09 11:15:01.100+0200 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-09 11:15:01.105+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [696].
12-09 11:15:01.105+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __alarm_remove_from_list(562) > [alarm-server]:Remove alarm id(542182817)
12-09 11:15:01.105+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 11:15:01.105+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 9-12-2017, 12:45:00 (UTC).
12-09 11:15:01.105+0200 E/ALARM_MANAGER(  485): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 11:15:01.105+0200 E/ALARM_MANAGER(  485): alarm-manager.c: alarm_manager_alarm_delete(2426) > alarm_id[542182817] is removed.
12-09 11:15:01.130+0200 W/SHealth_Common( 1081): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
12-09 11:15:01.130+0200 W/SHealth_Service( 1081): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
12-09 11:15:01.145+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
12-09 11:15:01.145+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:01.145+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_boolean(1173) > preference_get_boolean(1081) : test_healthy_pace error
12-09 11:15:01.150+0200 W/STARTER (  696): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
12-09 11:15:01.150+0200 W/STARTER (  696): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
12-09 11:15:01.160+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 11:15:01.165+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:01.165+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : pedometer_inactive_period error
12-09 11:15:01.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:15:01.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:01.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_10min_precaution_millisec error
12-09 11:15:01.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 11:15:01.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 11:15:01.170+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1081): preference.c: preference_get_double(1214) > preference_get_double(1081) : inactive_before_10min_precaution_millisec error
12-09 11:15:02.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 62
12-09 11:15:02.025+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 62
12-09 11:15:02.990+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 64
12-09 11:15:03.010+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:15:04.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 69
12-09 11:15:04.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 69
12-09 11:15:05.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 72
12-09 11:15:05.030+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 72
12-09 11:15:06.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 71
12-09 11:15:06.025+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 71
12-09 11:15:06.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 72
12-09 11:15:07.025+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 72
12-09 11:15:08.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 72
12-09 11:15:08.030+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 72
12-09 11:15:09.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 70
12-09 11:15:09.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 70
12-09 11:15:09.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 68
12-09 11:15:10.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 68
12-09 11:15:11.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 67
12-09 11:15:11.040+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 67
12-09 11:15:11.995+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 66
12-09 11:15:12.025+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 66
12-09 11:15:13.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 64
12-09 11:15:13.030+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:15:14.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 64
12-09 11:15:14.015+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:15:15.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 65
12-09 11:15:15.035+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:15:16.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 66
12-09 11:15:16.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 66
12-09 11:15:17.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 66
12-09 11:15:17.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 66
12-09 11:15:18.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 65
12-09 11:15:18.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:15:19.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 66
12-09 11:15:19.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 66
12-09 11:15:20.005+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 65
12-09 11:15:20.025+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 65
12-09 11:15:21.000+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 HEART RATE : 64
12-09 11:15:21.020+0200 I/INFO_TAG( 2131): SENSOR_EVENT2 TAB VALUE : 64
12-09 11:15:21.635+0200 E/EFL     ( 2131): ecore_x<2131> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=369001 button=1
12-09 11:15:21.740+0200 E/EFL     ( 2131): ecore_x<2131> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=369107 button=1
12-09 11:15:21.745+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(645) > __request_handler: 22
12-09 11:15:21.745+0200 W/AUL_AMD (  530): amd_request.c: __request_handler(916) > app status : 4
12-09 11:15:21.800+0200 E/APP_CORE( 2131): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
12-09 11:15:21.800+0200 I/APP_CORE( 2131): appcore-efl.c: __after_loop(1087) > Legacy lifecycle: 0
12-09 11:15:21.800+0200 I/APP_CORE( 2131): appcore-efl.c: __after_loop(1089) > [APP 2131] PAUSE before termination
12-09 11:15:21.800+0200 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-09 11:15:21.800+0200 I/CAPI_APPFW_APPLICATION( 2131): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
12-09 11:15:22.215+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 2131 pgid = 2131
12-09 11:15:22.385+0200 W/PROCESSMGR(  409): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-09 11:15:22.545+0200 W/W_HOME  (  779): event_manager.c: _ecore_x_message_cb(414) > state: 1 -> 0
12-09 11:15:22.545+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.565+0200 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 11:15:22.565+0200 W/AUL_AMD (  530): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
12-09 11:15:22.575+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.580+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.595+0200 W/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1190) > process_manager_signal
12-09 11:15:22.595+0200 I/WATCH_CORE(  812): appcore-watch.c: __signal_process_manager_handler(1206) > Call the time_tick_cb
12-09 11:15:22.595+0200 I/CAPI_WATCH_APPLICATION(  812): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 11:15:22.610+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(453) > Window [0x2600003] is now visible(0)
12-09 11:15:22.640+0200 W/W_HOME  (  779): event_manager.c: _window_visibility_cb(463) > state: 0 -> 1
12-09 11:15:22.640+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.650+0200 W/W_HOME  (  779): main.c: _window_visibility_cb(1211) > Window [0x2600003] is now visible(0)
12-09 11:15:22.650+0200 I/APP_CORE(  779): appcore-efl.c: __do_app(429) > [APP 779] Event: RESUME State: PAUSED
12-09 11:15:22.655+0200 I/CAPI_APPFW_APPLICATION(  779): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 11:15:22.655+0200 W/W_HOME  (  779): main.c: _appcore_resume_cb(687) > appcore resume
12-09 11:15:22.655+0200 W/W_HOME  (  779): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
12-09 11:15:22.655+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.670+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.670+0200 W/W_HOME  (  779): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-09 11:15:22.715+0200 W/wnotib  (  779): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(417) > fully_obscured: 0
12-09 11:15:22.845+0200 W/AUL_PAD ( 1231): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
12-09 11:15:22.850+0200 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2131
12-09 11:15:22.860+0200 E/RESOURCED(  532): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.190
12-09 11:15:22.875+0200 I/MALI    (  779): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4427f090] swap changed from async to sync
12-09 11:15:22.915+0200 W/CRASH_MANAGER( 2349): worker.c: worker_job(1205) > 1102131646174151281092
