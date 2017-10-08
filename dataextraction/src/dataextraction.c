 /**  Created on: Sep 25, 2017
 *      Author: Marie DEGEN
 **/

#include "dataextraction.h"
#include "recording.h"

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/*Add naviframe*/
    ad->nf = elm_naviframe_add(ad->conform);
    evas_object_show(ad->nf);
    elm_naviframe_prev_btn_auto_pushed_set(ad->nf, EINA_TRUE);
    elm_object_content_set(ad->conform, ad->nf);

	/*Add the box*/
	ad->box = elm_box_add(ad->nf);
	evas_object_show(ad->box);

	/*Add the label*/
	ad->label = elm_label_add(ad->box);
	elm_object_text_set(ad->label, "<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>Press the start button to begin the heart rate recording.</color></font/></align>");
	elm_label_wrap_width_set(ad->label, 150);
	elm_label_line_wrap_set(ad->label,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label);
	elm_box_pack_end(ad->box,ad->label);

	/*Add the start button*/
	ad->start_button = elm_button_add(ad->box);

	/*Set the button's style*/
	elm_object_style_set(ad->start_button, "bottom");
	elm_object_text_set(ad->start_button, "START");
	evas_object_show(ad->start_button);
	elm_box_pack_end(ad->box, ad->start_button);

	/*Add the box2*/
	ad->box_recording = elm_box_add(ad->nf);
	evas_object_show(ad->box_recording);

	/*Add the label3*/
	ad->label3 = elm_label_add(ad->box_recording);
	elm_object_text_set(ad->label3, "<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>00:00</color></font/></align>");
	elm_label_wrap_width_set(ad->label3, 150);
	elm_label_line_wrap_set(ad->label3,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label3,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label3, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label3);
	elm_box_pack_end(ad->box_recording,ad->label3);

	/*Add the label*/
	ad->label2 = elm_label_add(ad->box_recording);
	elm_object_text_set(ad->label2, "<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>Recording...</color></font/></align>");
	elm_label_wrap_width_set(ad->label2, 150);
	elm_label_line_wrap_set(ad->label2,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label2,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label2);
	elm_box_pack_end(ad->box_recording,ad->label2);

	/*Add the progress bar*/
	ad->progress_bar = elm_progressbar_add(ad->box_recording);
	elm_object_style_set(ad->progress_bar, "process");
	elm_progressbar_pulse_set(ad->progress_bar, EINA_TRUE);
	elm_progressbar_pulse(ad->progress_bar, EINA_TRUE);
	evas_object_show(ad->progress_bar);
	elm_box_pack_end(ad->box_recording, ad->progress_bar);

	/*Add the stop button*/
	ad->stop_button = elm_button_add(ad->box_recording);

	/*Set the button's style*/
	elm_object_style_set(ad->stop_button, "bottom");
	elm_object_text_set(ad->stop_button, "STOP");
	evas_object_show(ad->stop_button);
	elm_box_pack_end(ad->box_recording, ad->stop_button);


	/*Add the box for the bluetooth sending*/
	ad->box_bluetooth = elm_box_add(ad->nf);
	evas_object_show(ad->box_bluetooth);

	/*Add the label*/
	ad->label_bluetooth = elm_label_add(ad->box_bluetooth);
	elm_object_text_set(ad->label_bluetooth, "<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>The data are being sent to the main application please wait...</color></font/></align>");
	elm_label_wrap_width_set(ad->label_bluetooth, 150);
	elm_label_line_wrap_set(ad->label_bluetooth,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label_bluetooth,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label_bluetooth, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label_bluetooth);
	elm_box_pack_end(ad->box_bluetooth,ad->label_bluetooth);

	//Disable the autorepeat feature
	elm_button_autorepeat_set(ad->stop_button, EINA_FALSE);

	//Disable the autorepeat feature
	elm_button_autorepeat_set(ad->start_button, EINA_FALSE);

	//clicked_button function callback when click on the button
	evas_object_smart_callback_add(ad->start_button, "clicked", clicked_recording_start, (void*)ad);

	//clicked_button function callback when click on the button
	evas_object_smart_callback_add(ad->stop_button, "clicked", clicked_recording_stop, (void*)ad);

	elm_naviframe_item_push(ad->nf, "<font=Tizen:style=condensed font_size=30>Heart Recording</font/>", NULL, NULL, ad->box_bluetooth, NULL);
	elm_naviframe_item_push(ad->nf, "<font=Tizen:style=condensed font_size=30>Heart Recording</font/>", NULL, NULL, ad->box_recording, NULL);
	elm_naviframe_item_push(ad->nf, "<font=Tizen:style=condensed font_size=30>Heart Recording</font/>", NULL, NULL, ad->box, NULL);
	/* Show window after base gui is set up */
	evas_object_show(ad->win);


}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
	elm_exit();
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
