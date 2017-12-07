/**
 * \brief heart_rate_screen.c
 * \author DEGEN Marie
 * \date Oct 14, 2017
 */

#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include "heart_rate_screen.h"
#include "exit_screen.h"

/**
* @brief The function for the heart rate searching screen
* @param data appdata structure is being given
**/
void heart_rate_waiting(void *data) {
	appdata_s *ad = (appdata_s*)data;

	//Add the box to the naviframe
	ad->box_heart = elm_box_add(ad->nf);
	evas_object_show(ad->box_heart);

	//Add the label to the box
	ad->label_heart = elm_label_add(ad->box_heart);

	//Define the text of the label and his properties
	elm_object_text_set(ad->label_heart, style_text(HEART_RATE_SCREEN));
	elm_label_wrap_width_set(ad->label_heart, 150);
	elm_label_line_wrap_set(ad->label_heart,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label_heart,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label_heart, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label_heart);
	elm_box_pack_end(ad->box_heart,ad->label_heart);

	//Exit button
	ad->exit_button = elm_button_add(ad->box_heart);

	//Set the button's style
	elm_object_style_set(ad->exit_button, "bottom");
	elm_object_text_set(ad->exit_button, EXIT_BUTTON);
	evas_object_show(ad->exit_button);
	elm_box_pack_end(ad->box_heart, ad->exit_button);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box_heart, NULL);

	//clicked_button function callback when click on the exit button
	evas_object_smart_callback_add(ad->exit_button, "clicked", clicked_end_app, (void*)ad);
}
