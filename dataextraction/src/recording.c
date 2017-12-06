/**
 * \brief Sensor part, and recording of the heart rate
 * \author DEGEN Marie
 * \date Oct 2, 2017
 */

#include <sensor.h>
#include <dlog.h>
#include <server_network.h>
#include "recording.h"
#include "dataextraction.h"
#include "timer.h"

/**
 * The type of the sensor used
 */
sensor_type_e type = SENSOR_HRM;

/**
 * The error that is print in the log
 */
int error;

/**
 * @brief Sensor event, if the heartbeat is higher than 40bpm than the next screen is displayed
 * @param sensor, the sensor
 * @param *event, a pointer on the sensor event
 * @param *user_data, a pointer on the user_data
 */
void on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data)
{
	appdata_s *ad = (appdata_s*)user_data;

	// Select a specific sensor with a sensor handle
	// This example uses sensor type, assuming there is only 1 sensor for each type
   sensor_get_type(ad->sensor, &type);
   switch (type) {
      case SENSOR_HRM:
    	  	  	  	if(event->values[0] >= 40) {
    	  	  	  		elm_naviframe_item_pop(ad->nf);
    	  	  	  		sensor_listener_unset_event_cb(ad->listener);
    	  	  	  		break;
    	  	  	  		dlog_print(DLOG_INFO, "INFO_TAG", "SENSOR_EVENT HEART RATE >= 40 : %0.0f" , event->values[0]);
    	            } else {
    	            	dlog_print(DLOG_INFO, "INFO_TAG", "SENSOR_EVENT HEART RATE < 40 : %0.0f" , event->values[0]);
    	            }
                	break;
      default:
    	  dlog_print(DLOG_ERROR, "ERROR_TAG", "Not an HRM event");
   }
}

/**
 * @brief Sensor event for the start button, start to record the data
 * @param sensor, the sensor
 * @param *event, a pointer on the sensor event
 * @param *user_data, a pointer on the user_data
 */
void on_sensor_event_2(sensor_h sensor, sensor_event_s *event, void *user_data)
{
	appdata_s *ad = (appdata_s*)user_data;

	//Select a specific sensor with a sensor handle
	//This example uses sensor type, assuming there is only 1 sensor for each type
	sensor_get_type(sensor, &type);
	switch (type) {
		case SENSOR_HRM:
		{
			dlog_print(DLOG_INFO, "INFO_TAG", "SENSOR_EVENT2 HEART RATE : %0.0f" , event->values[0]);
			char a[100];

			//Update the label everytime the hpm change
			sprintf(a,"<align=center><font=Tizen:style=regular font_size=25>HPM : %0.0f</font/></align>", event->values[0]);
			elm_object_text_set(ad->label4, a);

			//Update the timer's label
			char* s = timer_sensor(ad->start);
			sprintf(a,"<align=center><font=Tizen:style=regular font_size=25>Timer : %s</font/></align>", s);
			free(s);
			elm_object_text_set(ad->label3, a);

			//Retrive the data and record them into an array
			ad->tab_result_counter ++;
			ad->tab_result = realloc(ad->tab_result, ad->tab_result_counter*sizeof(float));
			ad->tab_result[(ad->tab_result_counter)-1] = event->values[0];
			dlog_print(DLOG_INFO, "INFO_TAG", "SENSOR_EVENT2 TAB VALUE : %0.0f" , ad->tab_result[(ad->tab_result_counter)-1] );
		}
		break;
		default:
			dlog_print(DLOG_ERROR, LOG_TAG, "Not an HRM event");
	}
}

/**
 * @brief Create the sensor listener for the recording
 * @param *user_data, a pointer on the user_data
 */
void create_HRM_listener(void *data) {
	appdata_s *ad = (appdata_s*)data;
	bool supported;

	//Check if the sensor is supported
	error = sensor_is_supported(type, &supported);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_is_supported error: %d", error);
        return;
    }

	//Get the default sensor
	error = sensor_get_default_sensor(type, &ad->sensor);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_get_default_sensor error: %d", error);
        return;
    }

	//Create a listener for the sensor
	error = sensor_create_listener(ad->sensor, &ad->listener);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_create_listener error: %d", error);
        return;
    }

	//Callback function for the listener
	error = sensor_listener_set_event_cb(ad->listener, 1000, on_sensor_event, data);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_set_event_cb error: %d", error);
        return;
    }

	//Start the listener
	error = sensor_listener_start(ad->listener);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_start error: %d", error);
        return;
    }

    //Option for the sensor
	error = sensor_listener_set_option(ad->listener, SENSOR_OPTION_ALWAYS_ON);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_set_option error: %d", error);
        return;
    }

    //Need to check if it's really necessary
    sensor_event_s event;
	error = sensor_listener_read_data(ad->listener, &event);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_read_data error: %d", error);
        return;
    }
}

/**
 * @brief Callback for the clicked signal, Called when the button is clicked by the user
 * @param *data, a pointer on the user_data
 * @param *obj, the object
 * @param *event, a pointer on the sensor event
 */
void clicked_recording_start(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;

	//Unset the old back function
	error = sensor_listener_unset_event_cb(ad->listener);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_unset_event_cb error: %d", error);
    }

    //Callback the new function
	error = sensor_listener_set_event_cb(ad->listener, 1000, on_sensor_event_2, data);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_set_event_cb error: %d", error);
        return;
    }

    ad->start = time(NULL);

	//Pop the next screen
	elm_naviframe_item_pop(ad->nf);
}

/**
 * @brief Callback for the clicked signal, Called when the button is clicked by the user
 * @param *data, a pointer on the user_data
 * @param *obj, the object
 * @param *event, a pointer on the sensor event
 */
void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;

	//Unset the callback function in order to destroy the listener
	error = sensor_listener_unset_event_cb(ad->listener);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_unset_event_cb error: %d", error);
    }

    //Stop the listener
	error = sensor_listener_stop(ad->listener);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_listener_stop error: %d", error);
    }

    //Destroy the listener
	error = sensor_destroy_listener(ad->listener);
    if (error != SENSOR_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "sensor_destroy_listener error: %d", error);
    }

    //Pop the next screen
	elm_naviframe_item_pop(ad->nf);

	//Start the bluetooth server
	start_bt_server(ad);
}
