/*
 * recording.c
 * Created on: Oct 2, 2017
 * Author: Marie DEGEN
 */

#include <sensor.h>
#include <recording.h>
#include <dataextraction.h>

/*
 * Callback for the clicked signal
 * Called when the button is clicked by the user
 */

void clicked_recording_start(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;
	sensor_recorder_start(SENSOR_HRM,NULL);
	elm_naviframe_item_pop(ad->nf);
}

void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info) {
//	appdata_s *ad = (appdata_s*)data;
	sensor_recorder_stop(SENSOR_HRM);
}
