/*
 * heartrate.c
 *
 *  Created on: Oct 14, 2017
 *      Author: Marie
 */

#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include "heart_rate_screen.h"

void heart_rate_waiting(void *data) {
	appdata_s *ad = (appdata_s*)data;

	//Create the first window of the app
	//Add the box to the naviframe
	ad->box_heart_rate = elm_box_add(ad->nf);
	evas_object_show(ad->box_heart_rate);

	//Add the label to the box
	ad->label_heart_rate = elm_label_add(ad->label_heart_rate);

	//Define the text of the label and his properties
	elm_object_text_set(ad->label_heart_rate, style_text(HEART_RATE_SCREEN));
	elm_label_wrap_width_set(ad->label_heart_rate, 150);
	elm_label_line_wrap_set(ad->label_heart_rate,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label_heart_rate,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label_heart_rate, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label_heart_rate);
	elm_box_pack_end(ad->box_heart_rate,ad->label_heart_rate);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box_heart_rate, NULL);
}
