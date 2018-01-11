/**
 * \brief stop_button_screen.c
 * \author DEGEN Marie
 * \date Oct 18, 2017
 */

#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include "stop_button_screen.h"
#include "exit_screen.h"

/**
* @brief The function for the stop button screen, when the record need to be stopped
* @param data appdata structure is being given
**/
void stop_button_screen(void *data){
	appdata_s *ad = (appdata_s*)data;

	//Add the recording box
	ad->box_recording = elm_box_add(ad->nf);
	evas_object_show(ad->box_recording);

	//Add the HPM label
	ad->label4 = elm_label_add(ad->box_recording);
	elm_object_text_set(ad->label4, style_text(STOP_BUTTON_HPM));
	elm_label_wrap_width_set(ad->label4, 150);
	elm_label_line_wrap_set(ad->label4,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label4,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label4, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label4);
	elm_box_pack_end(ad->box_recording,ad->label4);

	//Add the timer label
	ad->label3 = elm_label_add(ad->box_recording);
	elm_object_text_set(ad->label3, style_text(STOP_BUTTON_TIMER));
	elm_label_wrap_width_set(ad->label3, 150);
	elm_label_line_wrap_set(ad->label3,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label3,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label3, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label3);
	elm_box_pack_end(ad->box_recording,ad->label3);

	//Add the recording label
	ad->label2 = elm_label_add(ad->box_recording);
	elm_object_text_set(ad->label2, style_text(STOP_BUTTON_RECORDING));
	elm_label_wrap_width_set(ad->label2, 150);
	elm_label_line_wrap_set(ad->label2,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label2,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label2);
	elm_box_pack_end(ad->box_recording,ad->label2);

	//Add the progress bar
	ad->progress_bar = elm_progressbar_add(ad->box_recording);
	elm_object_style_set(ad->progress_bar, "process");
	elm_progressbar_pulse_set(ad->progress_bar, EINA_TRUE);
	elm_progressbar_pulse(ad->progress_bar, EINA_TRUE);
	evas_object_show(ad->progress_bar);
	elm_box_pack_end(ad->box_recording, ad->progress_bar);

	//Add the stop button
	ad->stop_button = elm_button_add(ad->box_recording);

	//Set the button's style
	elm_object_style_set(ad->stop_button, "bottom");
	elm_object_text_set(ad->stop_button, STOP_BUTTON);
	evas_object_show(ad->stop_button);
	elm_box_pack_end(ad->box_recording, ad->stop_button);

	//Exit button
	ad->exit_button = elm_button_add(ad->box_recording);

	//Set the button's style
	elm_object_style_set(ad->exit_button, "bottom");
	elm_object_text_set(ad->exit_button, EXIT_BUTTON);
	evas_object_show(ad->exit_button);
	elm_box_pack_end(ad->box_recording, ad->exit_button);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box_recording, NULL);

	//Disable the autorepeat feature
	elm_button_autorepeat_set(ad->stop_button, EINA_FALSE);

	//clicked_button function callback when click on the button
	evas_object_smart_callback_add(ad->stop_button, "clicked", clicked_recording_stop, (void*)ad);

	//clicked_button function callback when click on the exit button
	evas_object_smart_callback_add(ad->exit_button, "clicked", clicked_end_app, (void*)ad);
}
