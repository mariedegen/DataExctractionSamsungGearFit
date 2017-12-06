/**
 * \brief start_button_screen.c
 * \author DEGEN Marie
 * \date Oct 18, 2017
 */

#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include "start_button_screen.h"

/**
* @brief The function for the start button screen
* @param data appdata structure is being given
**/
void start_button_screen(void *data){
	appdata_s *ad = (appdata_s*)data;

	//Add the box for the start button
	ad->box = elm_box_add(ad->nf);
	evas_object_show(ad->box);

	//Add the label
	ad->label = elm_label_add(ad->box);
	elm_object_text_set(ad->label, style_text(START_BUTTON_LABEL));
	elm_label_wrap_width_set(ad->label, 150);
	elm_label_line_wrap_set(ad->label,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label);
	elm_box_pack_end(ad->box,ad->label);

	//Add the start button
	ad->start_button = elm_button_add(ad->box);

	//Set the start button's style
	elm_object_style_set(ad->start_button, "bottom");
	elm_object_text_set(ad->start_button, START_BUTTON);
	evas_object_show(ad->start_button);
	elm_box_pack_end(ad->box, ad->start_button);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box, NULL);

	//Disable the autorepeat feature
	elm_button_autorepeat_set(ad->start_button, EINA_FALSE);

	//clicked_button function callback when click on the button
	evas_object_smart_callback_add(ad->start_button, "clicked", clicked_recording_start, (void*)ad);
}
