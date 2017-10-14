/*
 * heartrate.c
 *
 *  Created on: Oct 14, 2017
 *      Author: Marie
 */

#include <heartrate.h>

void heart_rate_waiting(void *data) {
	appdata_s *ad = (appdata_s*)data;

	//Create the first window of the app
	//Add the box to the naviframe
	ad->box_heartrate = elm_box_add(ad->nf);
	evas_object_show(ad->box_heartrate);

	//Add the label to the box
	ad->label_heartrate = elm_label_add(ad->box_heartrate);

	//Define the text of the label and his properties
	elm_object_text_set(ad->label_heartrate, "<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>Searching for your heart rate, please wait. </color></font/></align>");
	elm_label_wrap_width_set(ad->label_heartrate, 150);
	elm_label_line_wrap_set(ad->label_heartrate,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label_heartrate,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label_heartrate, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label_heartrate);
	elm_box_pack_end(ad->box_heartrate,ad->label_heartrate);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, "<font=Tizen:style=condensed font_size=30>Heart Recording</font/>", NULL, NULL, ad->box_heartrate, NULL);
}
