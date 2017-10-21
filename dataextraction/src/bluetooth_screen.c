/*
 * bluetooth_screen.c
 *
 *  Created on: Oct 18, 2017
 *      Author: Marie
 */

#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include "bluetooth.h"
#include "client_network.h"

void bluetooth_screen(void *data){
	appdata_s *ad = (appdata_s*)data;

	//Add the box to the naviframe
	ad->box_bluetooth = elm_box_add(ad->nf);
	evas_object_show(ad->box_bluetooth);

	//Add the label to the box
	ad->label_bluetooth = elm_label_add(ad->box_bluetooth);
	elm_object_text_set(ad->label_bluetooth, style_text(BLUETOOTH_SCREEN));

	//Set the label's style
	elm_label_wrap_width_set(ad->label_bluetooth, 150);
	elm_label_line_wrap_set(ad->label_bluetooth,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label_bluetooth,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label_bluetooth, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label_bluetooth);
	elm_box_pack_end(ad->box_bluetooth,ad->label_bluetooth);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box_bluetooth, NULL);

	connection_to_server();

}
