/*
 * recording.c
 * Created on: Oct 2, 2017
 * Author: Marie DEGEN
 */

#include <sensor.h>
#include <recording.h>
#include <dataextraction.h>

void on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data)
{
   // Select a specific sensor with a sensor handle
   // This example uses sensor type, assuming there is only 1 sensor for each type
   sensor_type_e type;
   sensor_get_type(sensor, &type);
   switch (type)
   {
      case SENSOR_HRM:
          	dlog_print(DLOG_INFO, LOG_TAG, "%d" , event->values[0]);
          	char a[100];
          	sprintf(a,"%f", event->values[0]);
          	elm_object_text_set(&event, a);
          	break;
      default:
              dlog_print(DLOG_ERROR, LOG_TAG, "Not an HRM event");
   }
}

/*
 * Callback for the clicked signal
 * Called when the button is clicked by the user
 */

void clicked_recording_start(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;
	int error;
	bool supported;

	sensor_type_e type = SENSOR_HRM;
	error = sensor_is_supported(type, &supported);

	//deal with the error if not supported

	sensor_h sensor;

	error = sensor_get_default_sensor(type, &sensor);

	//deal with the default sensor


	//Create an event listener

	sensor_listener_h listener;
	error = sensor_create_listener(sensor, &listener);

	error = sensor_listener_set_event_cb(listener, 1000, on_sensor_event, NULL);

	error = sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON);

	error = sensor_listener_start(listener);

	sensor_event_s event;
	error = sensor_listener_read_data(listener, &event);

	error = sensor_listener_unset_event_cb(listener);

	elm_naviframe_item_pop(ad->nf);
}

void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;
	int error;
	bool supported;

	sensor_type_e type = SENSOR_HRM;
	error = sensor_is_supported(type, &supported);

	//deal with the error if not supported

	sensor_h sensor;

	error = sensor_get_default_sensor(type, &sensor);

	//deal with the default sensor


	//Create an event listener

	sensor_listener_h listener;
	error = sensor_create_listener(sensor, &listener);

	error = sensor_listener_set_event_cb(listener, 1000, on_sensor_event, NULL);

	error = sensor_listener_set_option(listener, SENSOR_OPTION_ALWAYS_ON);

	error = sensor_listener_unset_event_cb(listener);

	error = sensor_listener_stop(listener);

	error = sensor_destroy_listener(listener);

	elm_naviframe_item_pop(ad->nf);
}
