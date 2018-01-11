 /**
 * \brief bluetooth_screen.c
 * \author DEGEN Marie
 * \date Oct 18, 2017
 */

#include <server_network.h>
#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include "bluetooth.h"
#include "exit_screen.h"

/**
* @brief The function for the bluetooth sending data screen
* @param data appdata structure is being given
**/
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

	//Exit button
	ad->exit_button = elm_button_add(ad->box_bluetooth);

	//Set the button's style
	elm_object_style_set(ad->exit_button, "bottom");
	elm_object_text_set(ad->exit_button, EXIT_BUTTON);
	evas_object_show(ad->exit_button);
	elm_box_pack_end(ad->box_bluetooth, ad->exit_button);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box_bluetooth, NULL);

	//clicked_button function callback when click on the exit button
	evas_object_smart_callback_add(ad->exit_button, "clicked", clicked_end_app, (void*)ad);

}
