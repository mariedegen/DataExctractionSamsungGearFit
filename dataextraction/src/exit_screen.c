/*
 * exit_screen.c
 *
 *  Created on: Nov 4, 2017
 *      Author: Marie
 */

#include "recording.h"
#include "dataextraction.h"
#include "constants.h"

void clicked_end_app()
{
	elm_exit();
}

void clicked_redo_app(void *data)
{
	appdata_s *ad = (appdata_s*)data;
	app_create(ad);
}

void end_choice(void *data)
{
	appdata_s *ad = (appdata_s*)data;

	//Add the box for the 2 last buttons
	ad->box_end = elm_box_add(ad->nf);
	evas_object_show(ad->box_end);

	//Add the label
	ad->label_end = elm_label_add(ad->box_end);
	elm_object_text_set(ad->label_end, style_text(END_SCREEN_MESSAGE));
	elm_label_wrap_width_set(ad->label_end, 150);
	elm_label_line_wrap_set(ad->label_end,ELM_WRAP_WORD);
	evas_object_size_hint_align_set(ad->label_end,EVAS_HINT_FILL,0.5);
	evas_object_size_hint_weight_set(ad->label_end, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->label_end);
	elm_box_pack_end(ad->box_end,ad->label_end);

	//Add the redo button
	ad->redo_button = elm_button_add(ad->box_end);

	//Set the start button's style
	elm_object_style_set(ad->redo_button, "bottom");
	elm_object_text_set(ad->redo_button, "YES");
	evas_object_show(ad->redo_button);
	elm_box_pack_end(ad->box_end, ad->redo_button);

	//Add the end button
	ad->end_button = elm_button_add(ad->box_end);

	//Set the start button's style
	elm_object_style_set(ad->end_button, "bottom");
	elm_object_text_set(ad->end_button, "NO");
	evas_object_show(ad->end_button);
	elm_box_pack_end(ad->box_end, ad->end_button);

	//Push this window into the naviframe
	elm_naviframe_item_push(ad->nf, style_header(HEART_RECORDING), NULL, NULL, ad->box_end, NULL);

	//Disable the autorepeat feature
	elm_button_autorepeat_set(ad->redo_button, EINA_FALSE);

	//clicked_button function callback when click on the button
	evas_object_smart_callback_add(ad->redo_button, "clicked", clicked_redo_app, (void*)ad);

	//Disable the autorepeat feature
	elm_button_autorepeat_set(ad->end_button, EINA_FALSE);

	//clicked_button function callback when click on the button
	evas_object_smart_callback_add(ad->end_button, "clicked", clicked_end_app, (void*)ad);
}
