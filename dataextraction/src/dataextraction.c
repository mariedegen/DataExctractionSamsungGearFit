 /**  Created on: Sep 25, 2017
 *      Author: Marie DEGEN
 **/

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <sensor.h>
#include "bluetooth_screen.h"
#include "start_button_screen.h"
#include "stop_button_screen.h"
#include "heart_rate_screen.h"
#include "dataextraction.h"
#include "recording.h"
#include "constants.h"
#include "server_network.h"
#include "exit_screen.h"


static void win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;

	//Let window go to hide state.
	elm_win_lower(ad->win);
}

void create_base_gui(appdata_s *ad)
{
	//Window
	//Create and initialize elm_win.
	//elm_win is mandatory to manipulate window.
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	//Conformant
	//Create and initialize elm_conformant.
	//elm_conformant is mandatory for base gui to have proper size when indicator or virtual keypad is visible.
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	//Add the naviframe
    ad->nf = elm_naviframe_add(ad->conform);
    evas_object_show(ad->nf);
    elm_naviframe_prev_btn_auto_pushed_set(ad->nf, EINA_TRUE);
    elm_object_content_set(ad->conform, ad->nf);

    //Add the different box into the naviframe
    end_choice(ad);
    bluetooth_screen(ad);
    stop_button_screen(ad);
    start_button_screen(ad);
    heart_rate_waiting(ad);

	//Show window after base gui is set up
	evas_object_show(ad->win);
}

bool app_create(void *data)
{
	//Hook to take necessary actions before main event loop starts
	//Initialize UI resources and application's data
	//If this function returns true, the main loop of application starts
	//If this function returns false, the application is terminated
	appdata_s *ad = (appdata_s*)data;

	if (!initialize_bluetooth())
		dlog_print(DLOG_ERROR, "Bluetooth", "Bluetooth activation error.");
	if(!is_enbaled())
		dlog_print(DLOG_ERROR, "Bluetooth", "Bluetooth activation error.");

	//Initialize the result array and the counter
	ad->tab_result = NULL;
	ad->tab_result_counter = 0;
	ad->tab_result = malloc(ad->tab_result_counter * sizeof(float));
	if(ad->tab_result == NULL) {
		//Deal with the memory error
		dlog_print(DLOG_ERROR, LOG_TAG, "Out of memory for tab->result");
	}

	//Initialize the start duration of the timer
	ad->start = -1;

	//Initialize the GUI
	create_base_gui(ad);

	//Initialize of the listener for the HRM sensor
	create_HRM_listener(ad);

	return true;
}

static void app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
//	elm_exit();
}

static void app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data)
{
	appdata_s *ad = data;

	//Release all the resources
	free(ad->tab_result);
	stop_bt_server(ad->server);
	free(ad->server);
	free(ad->win);
	free(ad->conform);
	free(ad->nf);
}

int main(int argc, char *argv[])
{
	int ret = 0;
	appdata_s ad = {0,};

	ui_app_lifecycle_callback_s event_callback = {0,};

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}

