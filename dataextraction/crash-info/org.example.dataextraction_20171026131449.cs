S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 20795
Date: 2017-10-26 13:14:49+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x430b43e0, r1   = 0x00000001
r2   = 0x4044b250, r3   = 0x6c89cb00
r4   = 0xbea3f45c, r5   = 0x4005ad30
r6   = 0x00000233, r7   = 0xbea3f378
r8   = 0xbea3f42c, r9   = 0x404bec84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40393a00, sp   = 0xbea3f348
lr   = 0x40393ab4, pc   = 0x4000376c
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     13472 KB
Buffers:     46308 KB
Cached:     168764 KB
VmPeak:      65196 KB
VmSize:      65192 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11740 KB
VmRSS:       11740 KB
VmData:      12584 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23428 KB
VmPTE:          40 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20795 TID = 20795
20795 20799 

Maps Information
40000000 40005000 r-xp /opt/usr/apps/org.example.dataextraction/bin/dataextraction
40007000 4000b000 r-xp /usr/lib/libsys-assert.so
40016000 40033000 r-xp /lib/ld-2.13.so
4004f000 40053000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005b000 4008d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
40096000 4009a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
400a3000 400ab000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
400ac000 400ae000 r-xp /usr/lib/libdlog.so.0.0.0
400b6000 400d7000 r-xp /usr/lib/libefl-extension.so.0.1.0
400e0000 4021a000 r-xp /usr/lib/libelementary.so.1.7.99
40231000 402ff000 r-xp /usr/lib/libevas.so.1.7.99
40325000 40440000 r-xp /lib/libc-2.13.so
4044e000 40456000 r-xp /lib/libgcc_s-4.6.so.1
40457000 40462000 r-xp /lib/libunwind.so.8.0.1
4048f000 40491000 r-xp /lib/libdl-2.13.so
4049a000 4049e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404a7000 404a9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
404b2000 404b7000 r-xp /usr/lib/libappcore-efl.so.1.1
404bf000 404c4000 r-xp /usr/lib/libappcore-common.so.1.1
404cc000 404d8000 r-xp /usr/lib/libaul.so.0.1.0
404e2000 40504000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4050c000 4054d000 r-xp /usr/lib/libeina.so.1.7.99
40556000 4056a000 r-xp /lib/libpthread-2.13.so
40575000 405af000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
405b8000 405d1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
405d9000 405de000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
405e6000 406b6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
406b7000 406bd000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406c6000 406f0000 r-xp /usr/lib/libsensor.so.1.9.6
406f9000 4078d000 r-xp /usr/lib/libstdc++.so.6.0.16
407a0000 40809000 r-xp /lib/libm-2.13.so
40812000 40862000 r-xp /usr/lib/libecore_x.so.1.7.99
40864000 40886000 r-xp /usr/lib/libecore_evas.so.1.7.99
4088f000 40898000 r-xp /usr/lib/libvconf.so.0.2.45
408a0000 408c8000 r-xp /usr/lib/libfontconfig.so.1.8.0
408c9000 40995000 r-xp /usr/lib/libxml2.so.2.7.8
409a2000 409b4000 r-xp /usr/lib/libefl-assist.so.0.1.0
409bc000 409d3000 r-xp /usr/lib/libecore.so.1.7.99
409ea000 40a48000 r-xp /usr/lib/libedje.so.1.7.99
40a51000 40b09000 r-xp /usr/lib/libcairo.so.2.11200.14
40b14000 40bf5000 r-xp /usr/lib/libX11.so.6.3.0
40c00000 40c09000 r-xp /usr/lib/libXi.so.6.1.0
40c11000 40c2a000 r-xp /usr/lib/libeet.so.1.7.99
40c3b000 40c40000 r-xp /usr/lib/libecore_file.so.1.7.99
40c48000 40c59000 r-xp /usr/lib/libecore_input.so.1.7.99
40c61000 40c6a000 r-xp /usr/lib/libedbus.so.1.7.99
40c72000 40c9c000 r-xp /usr/lib/libdbus-1.so.3.8.12
40ca5000 40cbf000 r-xp /usr/lib/libecore_con.so.1.7.99
40cc8000 40cdb000 r-xp /usr/lib/libfribidi.so.0.3.1
40ce3000 40d20000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d29000 40d7f000 r-xp /usr/lib/libfreetype.so.6.11.3
40d8b000 40de1000 r-xp /usr/lib/libpixman-1.so.0.28.2
40dee000 40df4000 r-xp /usr/lib/libappsvc.so.0.1.0
40dfc000 40dff000 r-xp /usr/lib/libbundle.so.0.1.22
40e07000 40e0d000 r-xp /usr/lib/libecore_imf.so.1.7.99
40e16000 40e4a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40e53000 40e55000 r-xp /usr/lib/libiniparser.so.0
40e5e000 40e75000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40e7d000 40e82000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e8a000 40ec6000 r-xp /usr/lib/libsystemd.so.0.4.0
40ed0000 40ed4000 r-xp /usr/lib/libproc-stat.so.0.2.86
40edd000 40ef3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40efc000 40f71000 r-xp /usr/lib/libsqlite3.so.0.8.6
40f7b000 40f81000 r-xp /lib/librt-2.13.so
40f8a000 40fb8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40fc2000 41095000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
410a0000 410a3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
410ab000 410ad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410b6000 410bc000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
410c5000 410cd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
410d6000 410e0000 r-xp /usr/lib/libsensord-shared.so
410e9000 410f0000 r-xp /usr/lib/libXcursor.so.1.0.2
410f8000 410fa000 r-xp /usr/lib/libXdamage.so.1.1.0
41102000 41104000 r-xp /usr/lib/libXcomposite.so.1.0.0
4110c000 4110e000 r-xp /usr/lib/libXgesture.so.7.0.0
41117000 4111a000 r-xp /usr/lib/libXfixes.so.3.1.0
41122000 41123000 r-xp /usr/lib/libXinerama.so.1.0.0
4112c000 41132000 r-xp /usr/lib/libXrandr.so.2.2.0
4113a000 41140000 r-xp /usr/lib/libXrender.so.1.3.0
41148000 4114c000 r-xp /usr/lib/libXtst.so.6.1.0
41154000 4115e000 r-xp /usr/lib/libXext.so.6.4.0
41168000 4116d000 r-xp /usr/lib/libecore_fb.so.1.7.99
41176000 4117a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
41183000 41186000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4118e000 411a4000 r-xp /lib/libexpat.so.1.5.2
411ae000 411c4000 r-xp /lib/libz.so.1.2.5
411cd000 411df000 r-xp /usr/lib/libtts.so
411e7000 41209000 r-xp /usr/lib/libui-extension.so.0.1.0
41212000 41219000 r-xp /usr/lib/libtbm.so.1.0.0
41221000 41228000 r-xp /usr/lib/libembryo.so.1.7.99
41230000 41247000 r-xp /usr/lib/liblua-5.1.so
41251000 41252000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
4125a000 41268000 r-xp /usr/lib/libGLESv2.so.2.0
41271000 41289000 r-xp /usr/lib/libpng12.so.0.50.0
41291000 41292000 r-xp /usr/lib/libxcb-shm.so.0.0.0
4129b000 412a1000 r-xp /usr/lib/libxcb-render.so.0.0.0
412aa000 412bd000 r-xp /usr/lib/libxcb.so.1.1.0
412c6000 412c9000 r-xp /usr/lib/libEGL.so.1.4
412d1000 412f4000 r-xp /usr/lib/libjpeg.so.8.0.2
4130c000 41350000 r-xp /usr/lib/libcurl.so.4.3.0
4135a000 4135b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41363000 41368000 r-xp /usr/lib/libffi.so.5.0.10
41370000 41388000 r-xp /usr/lib/liblzma.so.5.0.3
41390000 4140c000 r-xp /usr/lib/libgcrypt.so.20.0.3
41418000 41428000 r-xp /lib/libresolv-2.13.so
4142d000 4142f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41437000 4143b000 r-xp /usr/lib/libsmack.so.1.0.0
41444000 41461000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4146a000 4146c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41474000 41481000 r-xp /usr/lib/libail.so.0.1.0
4148b000 415c8000 r-xp /usr/lib/libicui18n.so.51.1
415d8000 416bc000 r-xp /usr/lib/libicuuc.so.51.1
42c5a000 42c76000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42c80000 42c83000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
42c8b000 42c8c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
42c95000 42c9d000 r-xp /usr/lib/libdrm.so.2.4.0
42ca5000 42ca7000 r-xp /usr/lib/libdri2.so.0.0.0
42cb0000 42cb2000 r-xp /usr/lib/libXau.so.6.0.0
42cba000 42cc3000 r-xp /usr/lib/libcares.so.2.1.0
42ccc000 42cfa000 r-xp /usr/lib/libidn.so.11.5.44
42d02000 42d49000 r-xp /usr/lib/libssl.so.1.0.0
42d55000 42efe000 r-xp /usr/lib/libcrypto.so.1.0.0
42f20000 42f2b000 r-xp /usr/lib/libgpg-error.so.0.15.0
42f33000 42f35000 r-xp /usr/lib/libiri.so
42f3d000 42f40000 r-xp /lib/libcap.so.2.21
42f48000 42f4f000 r-xp /lib/libcrypt-2.13.so
42f7f000 42f86000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42f90000 42f92000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42f9a000 42fa1000 r-xp /usr/lib/libminizip.so.1.0.0
42fa9000 42faf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42fb7000 42fbc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42fc5000 42fc8000 r-xp /lib/libattr.so.1.1.0
42fd0000 42ff1000 r-xp /usr/lib/libexif.so.12.3.3
43004000 43006000 r-xp /usr/lib/libttrace.so.1.1
4300e000 43013000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43122000 431ec000 r-xp /usr/lib/libCOREGL.so.4.0
431fe000 43222000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4322b000 432fa000 r-xp /usr/lib/libscim-1.0.so.8.2.3
43310000 4331a000 r-xp /lib/libnss_files-2.13.so
43524000 43e00000 rw-p [stack:20799]
bea1f000 bea40000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20795)
Call Stack Count: 8
 0: start_bt_server + 0x13 (0x4000376c) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x376c
 1: app_create + 0x38 (0x40002039) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2039
 2: (0x400509c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x404b5457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x40051421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x40001f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
 6: __libc_start_main + 0x114 (0x4033c82c) [/lib/libc.so.6] + 0x1782c
 7: (0x40001ab0) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1ab0
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
ed updating signal
10-26 13:14:25.425+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:14:26.165+0200 W/MUSIC_PLAYER(20475): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(43) > [33m[TID:20475]   W_SERVICE_TYPE_BT[1][0m
10-26 13:14:26.165+0200 W/MUSIC_PLAYER(20475): mp-weconn.c: mp_weconn_is_bt_and_wms_connected(51) > [33m[TID:20475]   VCONFKEY_WMS_WMANAGER_CONNECTED[0][0m
10-26 13:14:26.170+0200 W/MUSIC_TRANSFER(20475): mt-service.c: _service_app_create(88) > [31m[TID:20475]   SAP is disconnected.. Terminate process[0m
10-26 13:14:26.175+0200 I/CAPI_APPFW_APPLICATION(20475): service_app_main.c: service_app_exit(441) > service_app_exit
10-26 13:14:26.455+0200 W/MUSIC_PLAYER(20475): mp-conf.c: mp_conf_is_ios_connected(187) > [33m[TID:20475]   vendor : LO[0m
10-26 13:14:26.475+0200 W/MUSIC_PLAYER(20475): mp-conf.c: mp_conf_init(262) > [33m[TID:20475]   iOS  connected..[0m
10-26 13:14:26.480+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20475): preference.c: _preference_check_retry_err(507) > key(tutorial_complete), check retry err: -21/(2/No such file or directory).
10-26 13:14:26.485+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20475): preference.c: _preference_get_key(1101) > _preference_get_key(tutorial_complete) step(-17825744) failed(2 / No such file or directory)
10-26 13:14:26.490+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE(20475): preference.c: preference_get_int(1132) > preference_get_int(20475) : key(tutorial_complete) error
10-26 13:14:26.495+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_remote_mode_changed_cb(81) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT]remote mode = [0][0m
10-26 13:14:26.500+0200 E/CAPI_NETWORK_BLUETOOTH( 1061): bluetooth-gatt.c: bt_gatt_client_get_service(2830) > [bt_gatt_client_get_service] INVALID_PARAMETER(0xffffffea)
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __gatt_client_get_service(512) > [31m[TID:1061]   bt_gatt_client_get_service Error[-22][0m
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: music_control_ams_media_changed_ind_request(805) > [33m[TID:1061]   remote mode[0][0m
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-ams.c: __unregister_entity_update(400) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:14:26.505+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:14:26.510+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:14:26.535+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:14:26.535+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:14:26.535+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:14:26.540+0200 W/MUSIC_TRANSFER(20475): mt-service.c: _service_app_terminate(104) > [33m[TID:20475]   [0m
10-26 13:14:26.540+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 22
10-26 13:14:26.540+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(916) > app status : 4
10-26 13:14:26.795+0200 W/AUL     (20507): daemon-manager-release-agent.c: main(12) > release agent : [2:/com.samsung.w-music-transfer.consumer]
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20475
10-26 13:14:26.800+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:14:26.815+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20475
10-26 13:14:27.100+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(21920) > _wms_event_handler_cb_nomove_detector is called
10-26 13:14:28.545+0200 W/AUL_AMD (  564): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
10-26 13:14:28.570+0200 W/CRASH_MANAGER(20356): worker.c: worker_job(1205) > 11204496461741509016453
10-26 13:14:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:14:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:14:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:14:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:14:30.500+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:14:30.510+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:14:30.510+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:14:30.510+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:14:30.510+0200 W/SHealthWidget(  836): HeartRateSummaryItem.cpp: UpdateHRValue(100) > [1;35mheatrRateString:[<color=#fc3319ff font_size=32 font=Tizen:style=normal:width=condensed:weight=Regular><color=#fc3319ff font_size=105 font=SFit\ Num:style=Regular>81</color> bpm</color>][0;m
10-26 13:14:30.515+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:14:30.515+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:14:30.515+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:14:30.515+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:14:34.310+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:14:35.770+0200 E/PKGMGR_SERVER(20578): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:14:35.880+0200 E/PKGMGR_SERVER(20578): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1190986688], req_type=[12], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[], cookie=[pg8Foz+wjcTXQBGhLH5gHqKTr10=], backend_flag=[0]
10-26 13:14:35.900+0200 E/PKGMGR  (20576): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.dataextraction, -1]
10-26 13:14:35.940+0200 E/PKGMGR_SERVER(20579): pkgmgr-server.c: queue_job(1976) > KILL/CHECK APP, pkgid=[org.example.dataextraction]
10-26 13:14:36.015+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:36.025+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
10-26 13:14:36.040+0200 E/PKGMGR_SERVER(20579): pkgmgr-server.c: queue_job(1998) > KILL/CHECK_APP end.
10-26 13:14:36.060+0200 E/PKGMGR_SERVER(20578): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20579]
10-26 13:14:37.650+0200 E/PKGMGR_SERVER(20578): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:14:37.650+0200 E/PKGMGR_SERVER(20578): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:14:38.275+0200 E/PKGMGR  (20663): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
10-26 13:14:38.510+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: main(2167) > package manager server start
10-26 13:14:38.680+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: req_cb(674) > req_id=[org.example.dataextraction_1193708233], req_type=[1], pkg_type=[rpm], pkgid=[org.example.dataextraction], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.dataextraction_1193708233' '-r' 'org.example.dataextraction'], cookie=[DhIq86F8pkImR7cQtWnYVxpdYzA=], backend_flag=[0]
10-26 13:14:38.685+0200 E/PKGMGR  (20665): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.dataextraction]
10-26 13:14:38.690+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.dataextraction 
10-26 13:14:38.695+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:14:38.695+0200 E/PKGMGR_SERVER(20666): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[org.example.dataextraction]
10-26 13:14:38.695+0200 E/PKGMGR  (20663): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[206630002]
10-26 13:14:38.705+0200 E/PKGMGR_SERVER(20667): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:14:38.810+0200 E/PKGMGR_OBSERVER(20667): pkg_observer.c: main(601) > OBSERVER start
10-26 13:14:38.855+0200 E/rpm-installer(20666): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:14:38.855+0200 E/rpm-installer(20666): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:14:38.855+0200 E/rpm-installer(20666): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:14:39.100+0200 E/PKGMGR_OBSERVER(20667): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[206670002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[update]
10-26 13:14:39.130+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(update)
10-26 13:14:39.130+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(913) > __amd_pkgmgrinfo_start_handler
10-26 13:14:39.140+0200 E/PKGMGR_OBSERVER(20667): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[206670002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:14:39.145+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.dataextraction is being updateded:0
10-26 13:14:39.165+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, STARTED]
10-26 13:14:39.225+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, PROCESSING]
10-26 13:14:39.490+0200 W/CERT_SVC(20666): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:14:39.525+0200 E/rpm-installer(20666): coretpk-parser.c: _coretpk_parser_get_manifest_info(1726) > (doc == NULL) xmlParseFile() failed.
10-26 13:14:39.525+0200 E/rpm-installer(20666): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1639) > (pkg_file_info == NULL) pkg_file_info is NULL.
10-26 13:14:39.525+0200 E/rpm-installer(20666): coretpk-installer.c: _coretpk_installer_package_reinstall(6735) > _coretpk_installer_verify_privilege_list failed
10-26 13:14:39.560+0200 E/PKGMGR_PARSER(20666): pkgmgr_parser_signature.c: __ps_check_mdm_policy_by_pkgid(1056) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-CLIENT(20666): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: mainloop(227) > Got incoming connection
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(253) > Starting connection thread
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketStream.h: SocketStream(31) > Created
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketConnection.h: SocketConnection(44) > Created
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-CLIENT(20666): SocketStream.h: SocketStream(31) > Created
10-26 13:14:39.615+0200 I/PRIVACY-MANAGER-CLIENT(20666): SocketConnection.h: SocketConnection(44) > Created
10-26 13:14:39.620+0200 I/PRIVACY-MANAGER-CLIENT(20666): SocketClient.cpp: connect(62) > Client connected
10-26 13:14:39.620+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(304) > Calling service
10-26 13:14:39.625+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(307) > Removing client
10-26 13:14:39.625+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionService(311) > Call served
10-26 13:14:39.625+0200 I/PRIVACY-MANAGER-SERVER(  505): SocketService.cpp: connectionThread(262) > Client serviced
10-26 13:14:39.625+0200 I/PRIVACY-MANAGER-CLIENT(20666): SocketClient.cpp: disconnect(72) > Client disconnected
10-26 13:14:39.640+0200 E/PKGMGR_CERT(20666): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
10-26 13:14:39.655+0200 E/PKGMGR_CERT(20666): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
10-26 13:14:39.680+0200 E/PKGMGR_CERT(20666): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
10-26 13:14:39.745+0200 E/rpm-installer(20666): coretpk-installer.c: _coretpk_installer_package_reinstall(6789) > _coretpk_installer_package_reinstall(org.example.dataextraction) failed.
10-26 13:14:39.760+0200 E/PKGMGR_OBSERVER(20667): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[206670002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[fail]
10-26 13:14:39.770+0200 E/APPS    (  769): pkgmgr.c: _end(826) >  (strcasecmp(val, "ok")) -> _end() return
10-26 13:14:39.770+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[6].func has errors.
10-26 13:14:39.780+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(fail)
10-26 13:14:39.795+0200 E/PKGMGR_OBSERVER(20667): pkg_observer.c: main(620) > OBSERVER end
10-26 13:14:39.795+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [UPDATE, COMPLETED]
10-26 13:14:39.795+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:14:39.795+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:14:39.795+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:14:39.800+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:14:39.800+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20667]
10-26 13:14:39.825+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_mainappid(96) > [_pkg_monitor_get_mainappid:96] Failed to get pkginfo[-1]
10-26 13:14:40.650+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:14:40.690+0200 E/rpm-installer(20666): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:14:40.690+0200 E/rpm-installer(20666): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:14:40.690+0200 E/rpm-installer(20666): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:14:40.740+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20666]
10-26 13:14:40.740+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/20666/oom_score_adj failed
10-26 13:14:40.740+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 20666
10-26 13:14:41.870+0200 E/PKGMGR  (20718): pkgmgr.c: pkgmgr_client_install(1546) > install pkg start.
10-26 13:14:41.930+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: req_cb(674) > req_id=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1197261084], req_type=[1], pkg_type=[tpk], pkgid=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk], args=[arg-start '-k' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk_1197261084' '-i' '/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk' '-G'], cookie=[CS4KDD9OPak9XJy5wHQptp4RsNc=], backend_flag=[0]
10-26 13:14:41.935+0200 E/PKGMGR  (20665): pkgmgr-internal.c: _get_type_from_zip(769) > /opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk is core
10-26 13:14:41.945+0200 E/PKGMGR  (20718): pkgmgr.c: pkgmgr_client_install(1663) > install pkg finish, ret=[207180002]
10-26 13:14:41.950+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: __set_recovery_mode(201) > rev_file[/opt/share/packages/.recovery/pkgmgr/] is null
10-26 13:14:41.955+0200 E/PKGMGR_SERVER(20720): pkgmgr-server.c: queue_job(1842) > INSTALL start, pkg path=[/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk]
10-26 13:14:41.960+0200 E/PKGMGR_SERVER(20721): pkgmgr-server.c: queue_job(2063) > COMM_REQ_OBSERVER start, pkgid=[]
10-26 13:14:42.040+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: main(601) > OBSERVER start
10-26 13:14:42.080+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(120) > ------------------------------------------------
10-26 13:14:42.080+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(121) >  [START] rpm-installer: version=[201610629.1]
10-26 13:14:42.080+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(122) > ------------------------------------------------
10-26 13:14:42.265+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(207) > [/opt/usr/apps/tmp/org.example.dataextraction-1.0.0-arm.tpk] is tpk package.
10-26 13:14:42.300+0200 E/rpm-installer(20720): coretpk-parser.c: __coretpk_parser_get_value(1688) > (result_value == NULL) [install-location] is empty.
10-26 13:14:42.315+0200 E/rpm-installer(20720): coretpk-parser.c: _coretpk_parser_is_widget(1562) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
10-26 13:14:42.330+0200 E/rpm-installer(20720): coretpk-parser.c: _coretpk_parser_is_custom_clock(1461) > (ret == 1) metadata(watchface) is empty.
10-26 13:14:42.335+0200 E/rpm-installer(20720): installer-util.c: _installer_util_delete_dir(416) > (dp == NULL) opendir(/opt/usr/data/pkgmgr/org.example.dataextraction/) failed. [2][No such file or directory]
10-26 13:14:42.335+0200 E/rpm-installer(20720): coretpk-installer.c: _coretpk_installer_install_package(3573) > Deletion failed: [/opt/usr/data/pkgmgr/org.example.dataextraction/]
10-26 13:14:42.475+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207210002] pkg_type[tpk] pkgid[org.example.dataextraction] key[start] val[install]
10-26 13:14:42.490+0200 E/APPS    (  769): pkgmgr.c: _start(529) >  (_exist_request_in_list(package)) -> _start() return
10-26 13:14:42.490+0200 E/APPS    (  769): pkgmgr.c: _pkgmgr_cb(895) >  pkgmgr_cbs[0].func has errors.
10-26 13:14:42.510+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(start), value(install)
10-26 13:14:42.515+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207210002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[30]
10-26 13:14:42.550+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, STARTED]
10-26 13:14:42.595+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:14:42.650+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:14:42.880+0200 W/CERT_SVC(20720): XmlsecAdapter.cpp: validateFile(286) > [38;5;202;1m## [validate]: uriList does not exist[0m
10-26 13:14:42.910+0200 E/rpm-installer(20720): coretpk-parser.c: __coretpk_parser_check_ese_metadata(1314) > (ret == 1) metadata(watchface) is empty.
10-26 13:14:42.915+0200 E/rpm-installer(20720): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
10-26 13:14:42.915+0200 E/rpm-installer(20720): coretpk-parser.c: __coretpk_parser_append_path(330) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
10-26 13:14:42.915+0200 E/rpm-installer(20720): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(454) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
10-26 13:14:43.000+0200 E/PKGMGR_PARSER(20720): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2136) > Manifest is Valid
10-26 13:14:43.015+0200 E/PKGMGR_PARSER(20720): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
10-26 13:14:43.040+0200 E/PKGMGR_PARSER(20720): pkgmgr_parser_db.c: __verify_label_cb(470) > package_label is PKGMGR_PARSER_EMPTY_STR
10-26 13:14:43.135+0200 I/PRIVACY-MANAGER-CLIENT(20720): SocketClient.cpp: SocketClient(37) > Client created
10-26 13:14:43.310+0200 I/efl-extension(20720): efl_extension.c: eext_mod_init(40) > Init
10-26 13:14:43.315+0200 I/efl-extension(20720): efl_extension.c: eext_mod_shutdown(46) > Shutdown
10-26 13:14:43.500+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
10-26 13:14:43.500+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 62
10-26 13:14:43.505+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 62
10-26 13:14:43.505+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 10 1
10-26 13:14:43.505+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 11 1
10-26 13:14:43.505+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 12 1
10-26 13:14:43.505+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 13 1
10-26 13:14:43.520+0200 E/PKGMGR_CERT(20720): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
10-26 13:14:43.530+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207210002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[60]
10-26 13:14:43.575+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:14:43.660+0200 E/rpm-installer(20720): installer-util.c: _installer_util_get_configuration_value(597) > [signature]=[on]
10-26 13:14:43.680+0200 E/rpm-installer(20720): coretpk-installer.c: _coretpk_installer_apply_smack(3194) > groupid = [FTlJWGfZwavztdrCBk+czX2kZz4xBNLUVdQKS#7YPHs=] for shared/trusted.
10-26 13:14:43.685+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20443 pgid = 20443
10-26 13:14:43.790+0200 E/rpm-installer(20720): coretpk-installer.c: __post_install_for_mmc(742) > (handle == NULL) handle is NULL.
10-26 13:14:43.855+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20443
10-26 13:14:43.865+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.667
10-26 13:14:43.885+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207210002] pkg_type[tpk] pkgid[org.example.dataextraction] key[install_percent] val[100]
10-26 13:14:43.960+0200 E/rpm-installer(20720): coretpk-installer.c: __set_softreset_script(127) > (ret != PMINFO_R_OK) dont have SUPPORT_SOFTRESET_SCRIPT_METADATA_KEY
10-26 13:14:43.990+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:14:43.990+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20295 pgid = -1
10-26 13:14:43.990+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:14:43.995+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20295
10-26 13:14:44.015+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.668
10-26 13:14:44.040+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, PROCESSING]
10-26 13:14:44.650+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:14:45.300+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[207210002] pkg_type[tpk] pkgid[org.example.dataextraction] key[end] val[ok]
10-26 13:14:45.310+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(246) > Pkg:org.example.dataextraction is updated, need to check validation
10-26 13:14:45.310+0200 W/W_HOME  (  769): clock_event.c: _pkgmgr_event_cb(250) > attacheck clock:com.samsung.idle-clock-volt_sparkle
10-26 13:14:45.350+0200 W/AUL_AMD (  564): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(900) > pkgid(org.example.dataextraction), key(end), value(ok)
10-26 13:14:45.370+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_log_package(4826) > package [_________] callback : [INSTALL, COMPLETED]
10-26 13:14:45.370+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7166) > package install complete
10-26 13:14:45.370+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5059) > 
10-26 13:14:45.370+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1995) > Found in install_req_list?[0], index[-1]
10-26 13:14:45.370+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_package_install_event(5085) > triggered from Gear itself.
10-26 13:14:45.370+0200 E/WMS     (  519): wms_db.c: wms_db_package_event_insert_record(177) > 
10-26 13:14:45.430+0200 E/WMS     (  519): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2739) > send_install_response completed : END
10-26 13:14:45.495+0200 E/PKGMGR_INFO(20721): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(981) > callback is stopped.
10-26 13:14:45.525+0200 E/PKGMGR_OBSERVER(20721): pkg_observer.c: main(620) > OBSERVER end
10-26 13:14:45.545+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: __unset_recovery_mode(218) > pkgid is null
10-26 13:14:45.545+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20721]
10-26 13:14:45.580+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 13:14:45.585+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 13:14:45.585+0200 E/STARTER (  732): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
10-26 13:14:45.705+0200 E/PKGMGR_INFO(  516): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(877) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
10-26 13:14:46.050+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:14:46.135+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: __clock_viewer_lcdoff_cb(499) >  event pre lcdoff[1]
10-26 13:14:46.135+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: __clock_viewer_lcdoff_cb(510) >  Enter to charger alpm mode
10-26 13:14:46.135+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[1] ani[0]
10-26 13:14:46.135+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: _clock_viewer_show_charging(946) >  clock start in charging >> [0]
10-26 13:14:46.160+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOff
10-26 13:14:46.165+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(204) > LCD off
10-26 13:14:46.165+0200 W/W_HOME  (  769): gesture.c: _manual_render_cancel_schedule(229) > cancel schedule, manual render
10-26 13:14:46.165+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:14:46.165+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 1
10-26 13:14:46.165+0200 W/W_HOME  (  769): event_manager.c: _lcd_off_cb(704) > lcd state: 0
10-26 13:14:46.165+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:14:46.175+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1648) > [_on_lcd_signal_receive_cb:1648] _on_lcd_signal_receive_cb, 1648, Pre LCD off by [timeout]
10-26 13:14:46.175+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] Will LCD OFF as wake_up_setting[1]
10-26 13:14:46.175+0200 E/STARTER (  732): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
10-26 13:14:46.175+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_popup_status(321) > [_check_reserved_popup_status:321] Current reserved apps status : 0
10-26 13:14:46.175+0200 W/STARTER (  732): clock-mgr.c: _check_reserved_apps_status(357) > [_check_reserved_apps_status:357] Current reserved apps status : 0
10-26 13:14:46.330+0200 W/W_INDICATOR(  735): windicator_util.c: _pm_state_changed_cb(805) > [_pm_state_changed_cb:805] Charger connected, so show charger watch
10-26 13:14:46.415+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: PAUSE State: RUNNING
10-26 13:14:46.415+0200 I/CAPI_APPFW_APPLICATION(  735): app_main.c: app_appcore_pause(202) > app_appcore_pause
10-26 13:14:46.420+0200 I/APP_CORE(  735): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
10-26 13:14:46.420+0200 E/W_INDICATOR(  735): windicator_util.c: _ecore_event_client_message_cb(1004) > [_ecore_event_client_message_cb:1004] _ecore_event_client_message_cb
10-26 13:14:46.430+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:14:46.430+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 13:14:46.435+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:14:46.435+0200 W/AUL_AMD (  564): amd_launch.c: __e17_status_handler(2292) > back key ungrab error
10-26 13:14:46.445+0200 I/MALI    (20468): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x42e15840] swap changed from async to sync
10-26 13:14:46.525+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:14:46.540+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:14:46.545+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:14:46.550+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:3[0;m
10-26 13:14:46.565+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: __clock_viewer_clockend_timer_cb(235) >  clock end << [1]
10-26 13:14:46.605+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1659) > [_on_lcd_signal_receive_cb:1659] _on_lcd_signal_receive_cb, 1659, Post LCD off by [timeout]
10-26 13:14:46.605+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1558) > [_post_lcd_off:1558] LCD OFF as reserved app[(null)] alpm mode[0] charger[1]
10-26 13:14:46.605+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1565) > [_post_lcd_off:1565] Current reserved apps status : 0
10-26 13:14:46.605+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_off(1583) > [_post_lcd_off:1583] raise homescreen after 20 sec. home_visible[0]
10-26 13:14:46.605+0200 E/ALARM_MANAGER(  732): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(20), start(26-10-2017, 13:15:07), repeat(1), interval(20), type(-1073741822)
10-26 13:14:46.620+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(598) >  event lcdoff completed[1][0]
10-26 13:14:46.620+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(611) >  Enter to charger alpm mode
10-26 13:14:46.625+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [732].
10-26 13:14:46.650+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:14:46.660+0200 E/ALARM_MANAGER(20468): alarm-lib.c: alarmmgr_add_alarm_withcb(1174) > trigger_at_time(74), start(26-10-2017, 13:16:01), repeat(1), interval(120), type(-1073741822)
10-26 13:14:46.675+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1021246559, next duetime: 1509016507
10-26 13:14:46.675+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1021246559)
10-26 13:14:46.675+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509021900), due_time(1509016507)
10-26 13:14:46.675+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:14:46.675+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:15:07 (UTC).
10-26 13:14:46.675+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:14:46.685+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __is_cached_cookie(228) > Find cached cookie for [20468].
10-26 13:14:46.725+0200 E/ALARM_MANAGER(  494): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1021246560, next duetime: 1509016561
10-26 13:14:46.725+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_add_to_list(483) > [alarm-server]: After add alarm_id(1021246560)
10-26 13:14:46.725+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __alarm_create(1048) > [alarm-server]:alarm_context.c_due_time(1509016507), due_time(1509016561)
10-26 13:14:46.725+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(323) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
10-26 13:14:46.725+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(330) > Setted RTC Alarm date/time is 26-10-2017, 11:15:07 (UTC).
10-26 13:14:46.725+0200 E/ALARM_MANAGER(  494): alarm-manager.c: __rtc_set(345) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
10-26 13:14:47.070+0200 I/efl-extension(20734): efl_extension.c: eext_mod_init(40) > Init
10-26 13:14:47.120+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: __clock_viewer_black_cover_timer_cb(214) >  Remove black screen
10-26 13:14:47.120+0200 W/W_CLOCK_VIEWER(20468): clock-viewer.c: _clock_viewer_set_black_cover(801) >  Set black cover[0] ani[0]
10-26 13:14:47.165+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:14:47.165+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:14:47.165+0200 E/rpm-installer(20720): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:14:47.195+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: sighandler(409) > child NORMAL exit [20720]
10-26 13:14:47.255+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/20720/oom_score_adj failed
10-26 13:14:47.255+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 20720
10-26 13:14:47.320+0200 E/EFL     (20733): elementary<20733> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:14:47.320+0200 E/EFL     (20733): elementary<20733> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:14:47.855+0200 E/EFL     (20734): elementary<20734> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:14:47.870+0200 E/EFL     (20734): elementary<20734> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:14:47.980+0200 E/EFL     (20734): elementary<20734> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:14:48.010+0200 I/UXT     (20734): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:14:48.015+0200 E/EFL     (20734): elementary<20734> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:14:48.025+0200 E/EFL     (20733): elementary<20733> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:14:48.075+0200 E/EFL     (20733): elementary<20733> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:14:48.195+0200 E/EFL     (20734): elementary<20734> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:14:48.200+0200 E/EFL     (20734): elementary<20734> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:14:48.200+0200 E/EFL     (20733): elementary<20733> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:14:48.200+0200 E/EFL     (20733): elementary<20733> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:14:48.210+0200 E/EFL     (20733): elementary<20733> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:14:48.210+0200 E/EFL     (20734): elementary<20734> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:14:48.210+0200 E/EFL     (20734): elementary<20734> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:14:48.215+0200 E/EFL     (20734): elementary<20734> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:14:48.215+0200 E/EFL     (20733): elementary<20733> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:14:48.215+0200 E/EFL     (20733): elementary<20733> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:14:48.360+0200 E/EFL     (20733): elementary<20733> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:14:48.365+0200 E/EFL     (20734): elementary<20734> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:14:48.370+0200 E/EFL     (20733): elementary<20733> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:14:48.375+0200 E/EFL     (20734): elementary<20734> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:14:48.380+0200 E/EFL     (20734): elementary<20734> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:14:48.380+0200 E/EFL     (20733): elementary<20733> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:14:48.515+0200 W/AUL     (20794): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:14:48.520+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:14:48.535+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 13:14:48.550+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 13:14:48.550+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:14:48.550+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 20794
10-26 13:14:48.570+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:14:48.570+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(620) > Candidate is not prepared, enter legacy logic
10-26 13:14:48.570+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:14:48.570+0200 E/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(278) > launching failed
10-26 13:14:48.570+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 3
10-26 13:14:48.570+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:14:48.570+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2135) > Launch with legacy way : no launchpad
10-26 13:14:48.575+0200 W/AUL_AMD (  564): amd_launch.c: start_process(580) > child process: 20795
10-26 13:14:48.590+0200 E/EFL     (20734): elementary<20734> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:14:48.610+0200 E/EFL     (20734): elementary<20734> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:14:48.610+0200 E/EFL     (20734): elementary<20734> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:14:48.610+0200 E/EFL     (20734): elementary<20734> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:14:48.610+0200 E/EFL     (20734): elementary<20734> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:14:48.610+0200 E/EFL     (20734): elementary<20734> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:14:48.610+0200 E/EFL     (20734): elementary<20734> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:14:48.610+0200 I/AUL_PAD (20734): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:14:48.630+0200 W/AUL_AMD (  564): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 20795
10-26 13:14:48.630+0200 W/AUL     (20794): launch.c: app_request_to_launchpad(282) > request cmd(0) result(20795)
10-26 13:14:48.635+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:14:48.650+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:14:48.650+0200 E/PKGMGR_SERVER(20665): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:14:48.815+0200 I/efl-extension(20795): efl_extension.c: eext_mod_init(40) > Init
10-26 13:14:48.835+0200 I/CAPI_APPFW_APPLICATION(20795): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:14:48.855+0200 E/EFL     (20795): elementary<20795> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:14:48.855+0200 E/EFL     (20795): elementary<20795> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:14:48.885+0200 E/EFL     (20795): elementary<20795> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:14:48.890+0200 I/UXT     (20795): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:14:48.890+0200 E/EFL     (20795): elementary<20795> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:14:48.940+0200 E/EFL     (20795): elementary<20795> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:14:48.940+0200 E/EFL     (20795): elementary<20795> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:14:48.945+0200 E/EFL     (20795): elementary<20795> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:14:48.945+0200 E/EFL     (20795): elementary<20795> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:14:48.945+0200 E/EFL     (20795): elementary<20795> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:14:48.975+0200 E/EFL     (20795): elementary<20795> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:14:48.980+0200 E/EFL     (20795): elementary<20795> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:14:48.980+0200 E/EFL     (20795): elementary<20795> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:14:49.025+0200 E/EFL     (20795): elementary<20795> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:14:49.035+0200 E/EFL     (20795): elementary<20795> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:14:49.035+0200 E/EFL     (20795): elementary<20795> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:14:49.035+0200 E/EFL     (20795): elementary<20795> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:14:49.035+0200 E/EFL     (20795): elementary<20795> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:14:49.035+0200 E/EFL     (20795): elementary<20795> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:14:49.035+0200 E/EFL     (20795): elementary<20795> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:14:49.065+0200 E/EFL     (20733): elementary<20733> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:14:49.125+0200 I/CAPI_APPFW_APPLICATION(20795): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:14:49.130+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:49.145+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20795
10-26 13:14:49.165+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:49.165+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:49.175+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20795
10-26 13:14:49.235+0200 E/EFL     (20733): elementary<20733> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:14:49.235+0200 E/EFL     (20733): elementary<20733> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:14:49.235+0200 E/EFL     (20733): elementary<20733> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:14:49.235+0200 E/EFL     (20733): elementary<20733> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:14:49.235+0200 E/EFL     (20733): elementary<20733> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:14:49.235+0200 E/EFL     (20733): elementary<20733> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:14:49.235+0200 I/AUL_PAD (20733): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:14:49.240+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:49.255+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:14:49.265+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20795
10-26 13:14:49.275+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 12
10-26 13:14:49.355+0200 I/Bluetooth(20795): [bt_initialize] success.
10-26 13:14:49.630+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:14:49.630+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:14:49.835+0200 W/AUL     (20803): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.dataextraction]
10-26 13:14:49.835+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 23
10-26 13:14:49.835+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
10-26 13:14:49.835+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(949) > pkg_status: installed, dead pid: 20795
10-26 13:14:49.835+0200 W/AUL_AMD (  564): amd_request.c: __send_app_termination_signal(510) > send dead signal done
10-26 13:14:49.845+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20795
10-26 13:14:51.420+0200 I/APP_CORE(  735): appcore-efl.c: __do_app(429) > [APP 735] Event: MEM_FLUSH State: PAUSED
10-26 13:14:51.935+0200 W/CRASH_MANAGER(20356): worker.c: worker_job(1205) > 1120795646174150901648
