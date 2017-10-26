S/W Version Information
Model: SM-R360
Tizen-Version: 2.3.1.8
Build-Number: R360XXU1BPK6
Build-Date: 2016.11.25 10:01:34

Crash Information
Process Name: dataextraction
PID: 18491
Date: 2017-10-26 13:09:05+0200
Executable File Path: /opt/usr/apps/org.example.dataextraction/bin/dataextraction
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x55

Register Information
r0   = 0x43f016f0, r1   = 0x00000001
r2   = 0x43f00010, r3   = 0x3f4fc900
r4   = 0xbe8c34d4, r5   = 0x4154ad30
r6   = 0x00000233, r7   = 0xbe8c3400
r8   = 0xbe8c34a4, r9   = 0x4004dc84
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e5a00, sp   = 0xbe8c33d0
lr   = 0x404e5ab4, pc   = 0x41746754
cpsr = 0x60000030

Memory Information
MemTotal:   490928 KB
MemFree:     18824 KB
Buffers:     44004 KB
Cached:     174936 KB
VmPeak:      66752 KB
VmSize:      66748 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11972 KB
VmRSS:       11968 KB
VmData:      13500 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23472 KB
VmPTE:          42 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18491 TID = 18491
18491 18511 

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
41759000 4178b000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41794000 41798000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
417a1000 417a9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
417aa000 417cb000 r-xp /usr/lib/libefl-extension.so.0.1.0
417d4000 4180e000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41817000 41830000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
41838000 4183d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41845000 4186f000 r-xp /usr/lib/libsensor.so.1.9.6
41878000 4188a000 r-xp /usr/lib/libefl-assist.so.0.1.0
41892000 4194a000 r-xp /usr/lib/libcairo.so.2.11200.14
41955000 41958000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
41960000 41966000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4196f000 41977000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4197f000 41989000 r-xp /usr/lib/libsensord-shared.so
41992000 419a4000 r-xp /usr/lib/libtts.so
419ac000 419ce000 r-xp /usr/lib/libui-extension.so.0.1.0
419d7000 419de000 r-xp /usr/lib/libtbm.so.1.0.0
419e6000 419f4000 r-xp /usr/lib/libGLESv2.so.2.0
419fd000 419fe000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a07000 41a0d000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a15000 41a18000 r-xp /usr/lib/libEGL.so.1.4
41a20000 41a2d000 r-xp /usr/lib/libail.so.0.1.0
41a36000 41b73000 r-xp /usr/lib/libicui18n.so.51.1
41b83000 41c67000 r-xp /usr/lib/libicuuc.so.51.1
43205000 43221000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4322a000 4322d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43235000 43236000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
4323f000 43247000 r-xp /usr/lib/libdrm.so.2.4.0
4324f000 43251000 r-xp /usr/lib/libdri2.so.0.0.0
43259000 43260000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43269000 4326b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43273000 4327a000 r-xp /usr/lib/libminizip.so.1.0.0
43282000 43288000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43290000 43295000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
4329d000 432be000 r-xp /usr/lib/libexif.so.12.3.3
432d1000 432d3000 r-xp /usr/lib/libttrace.so.1.1
432db000 432e0000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
433e8000 434b2000 r-xp /usr/lib/libCOREGL.so.4.0
436c5000 43f00000 rw-p [stack:18511]
be8a3000 be8c4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18491)
Call Stack Count: 9
 0: start_bt_server + 0x13 (0x41746754) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x3754
 1: app_create + 0x38 (0x41745039) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x2039
 2: (0x415409c1) [/usr/lib/libcapi-appfw-application.so.0] + 0x19c1
 3: appcore_efl_main + 0x13e (0x40044457) [/usr/lib/libappcore-efl.so.1] + 0x3457
 4: ui_app_main + 0xb0 (0x41541421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 5: main + 0x10e (0x41744f9b) [/opt/usr/apps/org.example.dataextraction/bin/dataextraction] + 0x1f9b
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
st.cpp: onTouchEventCancel(661) >  touch cancel
10-26 13:08:53.755+0200 W/APPS    (  769): AppsItem.cpp: onLanguageChange(303) >  text length [Health Reacording][213,37]
10-26 13:08:53.920+0200 E/EFL     (18415): elementary<18415> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:08:53.920+0200 E/EFL     (18415): elementary<18415> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:08:53.950+0200 E/EFL     (18415): elementary<18415> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:08:54.000+0200 E/EFL     (18415): elementary<18415> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:08:54.115+0200 E/EFL     (18415): elementary<18415> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:08:54.115+0200 E/EFL     (18415): elementary<18415> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:08:54.130+0200 E/EFL     (18415): elementary<18415> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:08:54.155+0200 E/EFL     (18415): elementary<18415> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:08:54.160+0200 E/EFL     (18415): elementary<18415> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:08:54.295+0200 E/EFL     (18415): elementary<18415> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:08:54.305+0200 E/EFL     (18415): elementary<18415> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:08:54.325+0200 E/EFL     (18415): elementary<18415> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:08:54.465+0200 E/EFL     (18416): elementary<18416> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:08:54.490+0200 E/EFL     (18416): elementary<18416> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:08:54.580+0200 E/EFL     (18415): elementary<18415> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:08:54.590+0200 E/EFL     (18415): elementary<18415> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:08:54.590+0200 E/EFL     (18415): elementary<18415> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:08:54.590+0200 E/EFL     (18415): elementary<18415> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:08:54.590+0200 E/EFL     (18415): elementary<18415> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:08:54.590+0200 E/EFL     (18415): elementary<18415> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:08:54.590+0200 E/EFL     (18415): elementary<18415> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:08:54.590+0200 I/AUL_PAD (18415): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:08:54.650+0200 E/PKGMGR_SERVER(18402): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=0, queue_status=1] 
10-26 13:08:54.740+0200 E/EFL     (18416): elementary<18416> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:08:54.745+0200 I/UXT     (18416): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:08:54.750+0200 E/EFL     (18416): elementary<18416> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:08:54.815+0200 E/rpm-installer(18403): rpm-appcore-intf.c: main(273) > ------------------------------------------------
10-26 13:08:54.815+0200 E/rpm-installer(18403): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
10-26 13:08:54.815+0200 E/rpm-installer(18403): rpm-appcore-intf.c: main(275) > ------------------------------------------------
10-26 13:08:54.830+0200 E/PKGMGR_SERVER(18402): pkgmgr-server.c: sighandler(409) > child NORMAL exit [18403]
10-26 13:08:54.870+0200 E/EFL     (18416): elementary<18416> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:08:54.870+0200 E/EFL     (18416): elementary<18416> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:08:54.875+0200 E/EFL     (18416): elementary<18416> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:08:54.875+0200 E/EFL     (18416): elementary<18416> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:08:54.875+0200 E/EFL     (18416): elementary<18416> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:08:54.900+0200 E/EFL     (18416): elementary<18416> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:08:54.905+0200 E/EFL     (18416): elementary<18416> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:08:54.905+0200 E/EFL     (18416): elementary<18416> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:08:54.915+0200 E/RESOURCED(  566): procfs.c: proc_get_oom_score_adj(126) > fopen /proc/18403/oom_score_adj failed
10-26 13:08:54.915+0200 E/RESOURCED(  566): proc-main.c: resourced_proc_status_change(865) > Empty pid or process not exists. 18403
10-26 13:08:54.950+0200 E/EFL     (18416): elementary<18416> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:08:54.965+0200 E/EFL     (18416): elementary<18416> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:08:54.965+0200 E/EFL     (18416): elementary<18416> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:08:54.965+0200 E/EFL     (18416): elementary<18416> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:08:54.965+0200 E/EFL     (18416): elementary<18416> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:08:54.970+0200 E/EFL     (18416): elementary<18416> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:08:54.970+0200 E/EFL     (18416): elementary<18416> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:08:54.970+0200 I/AUL_PAD (18416): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:08:55.670+0200 W/WECONN  (  589): <__bt_lo_device_connection_state_changed_cb:1242> conn_info->link : 0
10-26 13:08:56.655+0200 E/PKGMGR_SERVER(18402): pkgmgr-server.c: exit_server(1360) > exit_server Start [backend_status=1, queue_status=1] 
10-26 13:08:56.655+0200 E/PKGMGR_SERVER(18402): pkgmgr-server.c: main(2221) > package manager server terminated.
10-26 13:08:56.710+0200 W/AUL     (18476): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:08:56.715+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:08:56.730+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
10-26 13:08:56.745+0200 I/AUL_AMD (  564): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
10-26 13:08:56.745+0200 E/AUL_AMD (  564): amd_launch.c: _start_app(1700) > no caller appid info, ret: -1
10-26 13:08:56.745+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 18476
10-26 13:08:56.760+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:08:56.765+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:08:56.765+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:08:56.765+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:08:56.765+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:08:56.845+0200 I/efl-extension(18415): efl_extension.c: eext_mod_init(40) > Init
10-26 13:08:56.850+0200 I/UXT     (18415): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:08:56.855+0200 I/CAPI_APPFW_APPLICATION(18415): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:08:56.860+0200 I/CAPI_APPFW_APPLICATION(18415): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:08:56.865+0200 W/AUL     (18476): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18415)
10-26 13:08:56.910+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:08:57.035+0200 I/Bluetooth(18415): [bt_initialize] success.
10-26 13:08:57.310+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 11184156461741509016137
10-26 13:08:57.870+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:08:57.870+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:08:57.920+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18415 pgid = 18415
10-26 13:08:57.925+0200 E/RESOURCED(  836): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:08:57.925+0200 E/AUL     (  836): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:08:57.930+0200 E/CAPI_APPFW_APP_MANAGER(  836): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:08:57.945+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.499
10-26 13:08:58.005+0200 W/AUL_PAD ( 1167): sigchild.h: __launchpad_process_sigchld(196) > after __sigchild_action
10-26 13:08:58.015+0200 I/AUL_AMD (  564): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18415
10-26 13:08:58.030+0200 E/RESOURCED(  566): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(349) > Does not exist in busname hash: :1.500
10-26 13:08:58.060+0200 E/RESOURCED( 1085): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:08:58.065+0200 E/AUL     ( 1085): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:08:58.065+0200 E/CAPI_APPFW_APP_MANAGER( 1085): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:08:58.070+0200 E/RESOURCED( 5342): proc-stat.c: send_socket_with_repy(767) > send_socket_with_repy: read failed
10-26 13:08:58.070+0200 E/AUL     ( 5342): pkginfo.c: __get_id_bypid(212) > Failed to get the cmdline of pid, error: -1
10-26 13:08:58.070+0200 E/CAPI_APPFW_APP_MANAGER( 5342): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
10-26 13:08:58.355+0200 E/EFL     (18491): elementary<18491> elm_main.c:558 elm_quicklaunch_init() eet_init done.
10-26 13:08:58.355+0200 E/EFL     (18491): elementary<18491> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
10-26 13:08:58.380+0200 E/EFL     (18491): elementary<18491> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
10-26 13:08:58.380+0200 E/EFL     (18491): elementary<18491> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
10-26 13:08:58.430+0200 E/EFL     (18491): elementary<18491> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
10-26 13:08:58.435+0200 E/EFL     (18491): elementary<18491> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
10-26 13:08:58.435+0200 E/EFL     (18491): elementary<18491> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
10-26 13:08:58.440+0200 E/EFL     (18491): elementary<18491> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
10-26 13:08:58.445+0200 E/EFL     (18491): elementary<18491> elm_config.c:2759 _elm_config_init() _elm_config_init step 1 done.
10-26 13:08:58.475+0200 E/EFL     (18491): elementary<18491> elm_config.c:2767 _elm_config_init() _elm_config_init step 2 done.
10-26 13:08:58.485+0200 E/EFL     (18491): elementary<18491> elm_config.c:2771 _elm_config_init() _elm_config_init step 3 done.
10-26 13:08:58.515+0200 E/EFL     (18491): elementary<18491> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
10-26 13:08:58.605+0200 E/EFL     (18491): elementary<18491> elm_config.c:2811 _elm_config_sub_init() ecore_x_init done.
10-26 13:08:58.630+0200 E/EFL     (18491): elementary<18491> elm_config.c:2866 _elm_config_sub_init() _config_sub_apply done.
10-26 13:08:58.630+0200 E/EFL     (18491): elementary<18491> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
10-26 13:08:58.630+0200 E/EFL     (18491): elementary<18491> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
10-26 13:08:58.630+0200 E/EFL     (18491): elementary<18491> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
10-26 13:08:58.635+0200 E/EFL     (18491): elementary<18491> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
10-26 13:08:58.655+0200 E/EFL     (18491): elementary<18491> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
10-26 13:08:58.655+0200 I/AUL_PAD (18491): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
10-26 13:09:01.420+0200 W/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1157) > signal_lcd_status_signal: LCDOn
10-26 13:09:01.420+0200 I/WATCH_CORE(  806): appcore-watch.c: __signal_lcd_status_handler(1176) > Call the time_tick_cb
10-26 13:09:01.420+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:09:01.425+0200 W/W_HOME  (  769): dbus.c: _dbus_message_recv_cb(186) > LCD on
10-26 13:09:01.425+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_set(165) > timer set
10-26 13:09:01.425+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:09:01.425+0200 W/W_HOME  (  769): gesture.c: _apps_status_get(126) > apps status:0
10-26 13:09:01.425+0200 W/W_HOME  (  769): gesture.c: _lcd_on_cb(312) > move_to_clock:1 clock_visible:1 info->offtime:68896
10-26 13:09:01.425+0200 W/W_HOME  (  769): gesture.c: _manual_render_schedule(212) > schedule, manual render
10-26 13:09:01.425+0200 W/W_HOME  (  769): event_manager.c: _lcd_on_cb(696) > lcd state: 1
10-26 13:09:01.425+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:01.425+0200 W/W_HOME  (  769): event_manager.c: _state_control(353) > appcore resumed manually
10-26 13:09:01.425+0200 W/W_HOME  (  769): main.c: home_appcore_resume(714) > Home Appcore Resumed
10-26 13:09:01.425+0200 W/W_HOME  (  769): event_manager.c: _app_resume_cb(366) > state: 2 -> 1
10-26 13:09:01.425+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:01.425+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:01.425+0200 W/W_HOME  (  769): main.c: home_resume(735) > journal_appcore_app_fully_loaded called
10-26 13:09:01.425+0200 W/W_HOME  (  769): main.c: home_resume(739) > clock/widget resumed
10-26 13:09:01.425+0200 W/W_HOME  (  769): clock_indicator.c: clock_indicator_resume(537) > 
10-26 13:09:01.435+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:01.435+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1626) > [_on_lcd_signal_receive_cb:1626] _on_lcd_signal_receive_cb, 1626, Pre LCD on by [powerkey] after screen off time [68896]ms
10-26 13:09:01.435+0200 W/STARTER (  732): clock-mgr.c: _pre_lcd_on(1346) > [_pre_lcd_on:1346] Will LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:09:01.450+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESUME State: RUNNING
10-26 13:09:01.455+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_resume(1039) > widget_resume
10-26 13:09:01.460+0200 I/CAPI_WATCH_APPLICATION(  806): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
10-26 13:09:01.465+0200 W/W_HOME  (  769): gesture.c: _widget_updated_cb(194) > widget updated
10-26 13:09:01.465+0200 W/W_HOME  (  769): gesture.c: _manual_render_disable_timer_del(155) > timer del
10-26 13:09:01.465+0200 W/W_HOME  (  769): gesture.c: _manual_render(180) > 
10-26 13:09:01.500+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 13:09:01.505+0200 E/EFL     (  769): evas_main<769> evas_object_smart.c:755 evas_object_smart_need_recalculate_set() Object 0x46e7a640 is not stable during recalc loop
10-26 13:09:01.560+0200 W/W_HOME  (  769): gesture.c: _manual_render(180) > 
10-26 13:09:01.585+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
10-26 13:09:01.585+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:01.585+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_boolean(1173) > preference_get_boolean(1085) : test_healthy_pace error
10-26 13:09:01.585+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
10-26 13:09:01.585+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : pedometer_inactive_period error
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_10min_precaution_millisec error
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
10-26 13:09:01.590+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1085): preference.c: preference_get_double(1214) > preference_get_double(1085) : inactive_before_10min_precaution_millisec error
10-26 13:09:01.605+0200 W/W_HOME  (  769): gesture.c: _manual_render_enable(136) > 0
10-26 13:09:01.650+0200 W/SHealth_Common(  836): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:09:01.670+0200 W/SHealth_Common( 5342): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:09:01.685+0200 W/STARTER (  732): clock-mgr.c: _on_lcd_signal_receive_cb(1637) > [_on_lcd_signal_receive_cb:1637] _on_lcd_signal_receive_cb, 1637, Post LCD on by [powerkey]
10-26 13:09:01.685+0200 W/STARTER (  732): clock-mgr.c: _post_lcd_on(1392) > [_post_lcd_on:1392] LCD ON as reserved app[(null)] alpm mode[0] charger[0]
10-26 13:09:01.810+0200 W/SHealth_Common( 1085): SystemUtil.cpp: OnDeviceStatusChanged(1039) > [1;35mlcdState:1[0;m
10-26 13:09:01.825+0200 W/SHealth_Service( 1085): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
10-26 13:09:01.920+0200 W/SHealth_Common( 1085): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1508976000000,000000[0;m
10-26 13:09:02.030+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.today_widget (643869)]][0;m
10-26 13:09:02.115+0200 W/SHealthWidget(  836): WidgetMain.cpp: widget_update(142) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.today_widget (643869), msgName: timeline_summary_updated[0;m
10-26 13:09:02.120+0200 W/SHealth_Common(  836): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
10-26 13:09:02.135+0200 W/SHealth_Common( 1085): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.2.5][0;m
10-26 13:09:02.200+0200 I/HealthDataService(  777): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
10-26 13:09:02.240+0200 I/healthData( 1085): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:02.435+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:02.445+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.455+0200 E/CAPI_APPFW_APP_CONTROL( 1061): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
10-26 13:09:02.455+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-service.c: _music_control_service_pasre_request(462) > [33m[TID:1061]   [com.samsung.w-home]register msg port [true][0m
10-26 13:09:02.460+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 14
10-26 13:09:02.465+0200 W/AUL_AMD (  564): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 769
10-26 13:09:02.505+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3197) > Deliver KeyPress to focus window
10-26 13:09:02.505+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3208) > Deliver KeyPress as shared grab
10-26 13:09:02.505+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1332) > [_key_press_cb:1332] POWER Key is pressed
10-26 13:09:02.505+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1335) > [_key_press_cb:1335] LCD state : 1
10-26 13:09:02.505+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1342) > [_key_press_cb:1342] PM state : 1
10-26 13:09:02.505+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=7536854
10-26 13:09:02.505+0200 E/STARTER (  732): hw_key.c: _key_press_cb(1348) > [_key_press_cb:1348] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
10-26 13:09:02.505+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1351) > [_key_press_cb:1351] Simple Clock state : 0
10-26 13:09:02.505+0200 W/STARTER (  732): hw_key.c: _key_press_cb(1356) > [_key_press_cb:1356] powerkey count : 1
10-26 13:09:02.580+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:09:02.665+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 13:09:02.665+0200 W/KEYROUTER(  406): e_mod_main.c: DeliverDeviceKeyEvents(3235) > Deliver KeyRelease
10-26 13:09:02.665+0200 W/STARTER (  732): hw_key.c: _key_release_cb(1256) > [_key_release_cb:1256] POWER Key is released
10-26 13:09:02.670+0200 W/STARTER (  732): hw_key.c: _is_enable_to_launch_home_directly(1217) > [_is_enable_to_launch_home_directly:1217] launching home directly
10-26 13:09:02.680+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(880) > [_powerkey_timer_cb:880] _powerkey_timer_cb, powerkey count[1]
10-26 13:09:02.680+0200 W/STARTER (  732): hw_key.c: _powerkey_timer_cb(1078) > [_powerkey_timer_cb:1078] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
10-26 13:09:02.685+0200 E/STARTER (  732): dbus-util.c: dbus_request_cpu_boost(355) > [dbus_request_cpu_boost:355] failed to _invoke_dbus_method_sync
10-26 13:09:02.685+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(268) > request cmd(0) to(com.samsung.w-home)
10-26 13:09:02.690+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:02.690+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 732
10-26 13:09:02.690+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=7537017
10-26 13:09:02.695+0200 W/AUL_AMD (  564): amd_launch.c: __nofork_processing(1152) > __nofork_processing, cmd: 0, pid: 769
10-26 13:09:02.700+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:02.700+0200 W/AUL_AMD (  564): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(769), cmd(0)
10-26 13:09:02.700+0200 W/AUL     (  732): launch.c: app_request_to_launchpad(282) > request cmd(0) result(769)
10-26 13:09:02.705+0200 E/AUL     (  732): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:02.705+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(429) > [APP 769] Event: RESET State: RUNNING
10-26 13:09:02.705+0200 I/CAPI_APPFW_APPLICATION(  769): app_main.c: app_appcore_reset(245) > app_appcore_reset
10-26 13:09:02.710+0200 W/W_HOME  (  769): main.c: _app_control(1704) > Service value : powerkey
10-26 13:09:02.710+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x40001
10-26 13:09:02.710+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_delete_detail_view_objects_for_home_key(822) > 
10-26 13:09:02.710+0200 W/W_HOME  (  769): noti_broker.c: _noti_broker_home_cb(782) > continue the home key execution
10-26 13:09:02.710+0200 E/W_HOME  (  769): cs_broker.c: _cs_broker_home_cb(254) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
10-26 13:09:02.710+0200 W/W_HOME  (  769): main.c: _home_key_cb(1637) > Home Key operation tutorial:0 window:1 clock:1 apps:0
10-26 13:09:02.710+0200 W/W_HOME  (  769): move.c: move_move_to_apps(220) > move to apps
10-26 13:09:02.715+0200 W/W_HOME  (  769): move.c: _create_fake_apps(823) > fake image position : 432
10-26 13:09:02.715+0200 W/W_HOME  (  769): move.c: _create_fake_apps(847) > move_info.current_y_coord: 432
10-26 13:09:02.715+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_start_cb(640) > state: 0 -> 1
10-26 13:09:02.715+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:02.715+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:02.720+0200 I/APP_CORE(  769): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
10-26 13:09:02.720+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show,start
10-26 13:09:02.720+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 0
10-26 13:09:02.720+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:02.720+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:02.725+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:02.725+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show,start
10-26 13:09:02.725+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80002
10-26 13:09:02.725+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80002
10-26 13:09:02.725+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(867) > Unhandled type: 0x80002
10-26 13:09:02.745+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_add_data(64) > [31m[TID:1061]   bundle_add_str() .. [0xffffffea][0m
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:02.750+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:02.765+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.780+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:1061]   [MUSIC_PLAYER_EVENT][0m
10-26 13:09:02.800+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:09:02.800+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:02.810+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:02.820+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.825+0200 I/TIZEN_N_SOUND_MANAGER( 1061): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=0, ret=0x80000241
10-26 13:09:02.835+0200 W/W_HOME  (  769): clock_shortcut.c: _music_service_messageport_cb(372) > mode:local state:paused 
10-26 13:09:02.835+0200 E/W_HOME  (  769): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
10-26 13:09:02.845+0200 E/TIZEN_N_SOUND_MANAGER( 1061): sound_manager_private.c: __convert_sound_manager_error_code(157) > [sound_manager_get_volume] INTERNAL (0xfe6a0001): mm_error(0x80000241)
10-26 13:09:02.845+0200 W/MUSIC_CONTROL_SERVICE( 1061): music-control-sound-manager.c: music_control_sound_mgr_get_volume(108) > [31m[TID:1061]   sound_manager_get_volume() .. [0xfe6a0001][0m
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
10-26 13:09:02.855+0200 I/MESSAGE_PORT(  508): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
10-26 13:09:03.020+0200 W/W_HOME  (  769): move.c: _transit_del_cb(115) > transit end
10-26 13:09:03.020+0200 W/W_HOME  (  769): event_manager.c: _move_module_anim_end_cb(654) > state: 1 -> 0
10-26 13:09:03.020+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
10-26 13:09:03.040+0200 W/W_HOME  (  769): move.c: _scroller_up_done(515) > up signal done
10-26 13:09:03.040+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(583) > apps,show
10-26 13:09:03.045+0200 W/W_HOME  (  769): event_manager.c: _apptray_visibility_cb(601) > state: 1 -> 1
10-26 13:09:03.045+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:03.045+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:03.045+0200 W/W_HOME  (  769): main.c: home_pause(766) > clock/widget paused
10-26 13:09:03.045+0200 W/W_HOME  (  769): clock_indicator.c: clock_indicator_pause(554) > 
10-26 13:09:03.045+0200 W/W_HOME  (  769): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
10-26 13:09:03.050+0200 W/W_HOME  (  769): noti_broker.c: _apptray_visibility_cb(789) > apps,show
10-26 13:09:03.050+0200 W/W_HOME  (  769): noti_broker.c: noti_broker_event_fire_to_plugin(1004) > source:1 event:80000
10-26 13:09:03.050+0200 I/wnotib  (  769): w-notification-board-broker-main.c: _wnb_view_event_handler(828) > Home view event: 0x80000
10-26 13:09:03.050+0200 I/wnotib  (  769): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed(1473) > is_app_tray_displayed: 1
10-26 13:09:03.050+0200 E/APPS    (  769): apps_main.c: apps_main_resume(636) >  resumed already
10-26 13:09:03.065+0200 W/WATCH_CORE(  806): appcore-watch.c: __widget_pause(1028) > widget_pause
10-26 13:09:03.115+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
10-26 13:09:03.155+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
10-26 13:09:03.155+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
10-26 13:09:03.160+0200 E/TIZEN_N_SYSTEM_SETTINGS(  836): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
10-26 13:09:03.265+0200 I/CAPI_WIDGET_APPLICATION(  836): widget_app.c: __provider_update_cb(281) > received updating signal
10-26 13:09:03.275+0200 E/EFL     (  836): edje<836> edje_util.c:3770 edje_object_size_min_restricted_calc() group today_widget_summary_item has a non-fixed part 'left_pad'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
10-26 13:09:03.700+0200 W/AUL_AMD (  564): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
10-26 13:09:03.700+0200 W/AUL_AMD (  564): amd_launch.c: __grab_timeout_handler(1376) > back key ungrab error
10-26 13:09:04.385+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7538735 button=1
10-26 13:09:04.385+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.385+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:04.385+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,242,216,124]
10-26 13:09:04.395+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.410+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.420+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.420+0200 W/APPS    (  769): AppsViewList.cpp: onTouchEventCancel(661) >  touch cancel
10-26 13:09:04.440+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.475+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.475+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.480+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:04.490+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7538833 button=1
10-26 13:09:04.490+0200 E/APPS    (  769): AppsViewList.cpp: _scrollerMouseUp(937) >  (__bTouchCanceled) -> _scrollerMouseUp() return
10-26 13:09:05.140+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=7539490 button=1
10-26 13:09:05.140+0200 E/W_HOME  (  769): move.c: _mouse_move_cb(546) > apps move is not allowed
10-26 13:09:05.140+0200 E/W_HOME  (  769): move.c: _mouse_down_cb(384) > apps move is not allowed
10-26 13:09:05.140+0200 W/APPS    (  769): AppsViewList.cpp: _scrollerMouseDown(876) >  Find item [0,253,216,173]
10-26 13:09:05.200+0200 E/EFL     (  769): ecore_x<769> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=7539551 button=1
10-26 13:09:05.200+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(428) >  onItemClicked[0,11]
10-26 13:09:05.200+0200 E/APPS    (  769): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
10-26 13:09:05.200+0200 W/APPS    (  769): AppsItem.cpp: onItemClicked(440) >  item(Health Reacording) launched, open(0)
10-26 13:09:05.205+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(268) > request cmd(0) to(org.example.dataextraction)
10-26 13:09:05.205+0200 W/AUL_AMD (  564): amd_request.c: __request_handler(645) > __request_handler: 0
10-26 13:09:05.205+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(1710) > caller pid : 769
10-26 13:09:05.205+0200 I/AUL_AMD (  564): amd_launch.c: __check_app_control_privilege(1599) > Skip the privilege check in case of preloaded apps
10-26 13:09:05.220+0200 W/AUL_AMD (  564): amd_launch.c: _start_app(2124) > pad pid(-5)
10-26 13:09:05.220+0200 E/RESOURCED(  566): block.c: block_prelaunch_state(134) > insert data org.example.dataextraction, table num : 2
10-26 13:09:05.220+0200 E/RESOURCED(  566): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
10-26 13:09:05.220+0200 W/AUL_PAD ( 1167): launchpad.c: __launchpad_main_loop(601) > Launch on type-based process-pool
10-26 13:09:05.220+0200 W/AUL_PAD ( 1167): launchpad.c: __send_result_to_caller(272) > Check app launching
10-26 13:09:05.270+0200 I/efl-extension(18491): efl_extension.c: eext_mod_init(40) > Init
10-26 13:09:05.270+0200 I/UXT     (18491): Uxt_ObjectManager.cpp: OnInitialized(733) > Initialized.
10-26 13:09:05.275+0200 I/CAPI_APPFW_APPLICATION(18491): app_main.c: ui_app_main(704) > app_efl_main
10-26 13:09:05.275+0200 I/CAPI_APPFW_APPLICATION(18491): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
10-26 13:09:05.325+0200 W/AUL     (  769): launch.c: app_request_to_launchpad(282) > request cmd(0) result(18491)
10-26 13:09:05.325+0200 E/W_HOME  (  769): util.c: apps_util_launch_main_operation(740) > (NULL == layout) -> apps_util_launch_main_operation() return
10-26 13:09:05.325+0200 E/RESOURCED(  566): proc-main.c: proc_add_program_list(233) > not found ppi : org.example.dataextraction
10-26 13:09:05.330+0200 E/AUL     (  564): app_signal.c: __app_dbus_signal_filter(94) > reject by security issue - no interface
10-26 13:09:05.415+0200 I/Bluetooth(18491): [bt_initialize] success.
10-26 13:09:05.510+0200 W/CRASH_MANAGER(18479): worker.c: worker_job(1205) > 1118491646174150901614
