/*
 * recording.c
 * Created on: Oct 2, 2017
 * Author: Marie DEGEN
 */

#include <sensor.h>
#include <recording.h>
#include <dataextraction.h>


sensor_type_e type = SENSOR_HRM;
int error;

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
    	  	  	  	dlog_print(DLOG_INFO, "INFO_TAG", "HEART RATE >20 : %.0f" , event->values[0]);
    	            } else {
    	            	dlog_print(DLOG_INFO, "INFO_TAG", "HEART RATE < 40 : %.0f" , event->values[0]);
    	            }
                	break;
            default:
                    dlog_print(DLOG_ERROR, "ERROR_TAG", "Not an HRM event");
   }
}


void on_sensor_event_2(sensor_h sensor, sensor_event_s *event, void *user_data)
{
	appdata_s *ad = (appdata_s*)user_data;

	// Select a specific sensor with a sensor handle
	// This example uses sensor type, assuming there is only 1 sensor for each type
   sensor_get_type(sensor, &type);
   switch (type) {
      case SENSOR_HRM:
      {
    	   dlog_print(DLOG_INFO, "INFO_TAG_SENSOR_EVENT2", "HEART RATE : %.0f" , event->values[0]);
          	char a[100];
          	if(fabsf(event->values[0]) <= 0.0000001) {
          		sprintf(a,"<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>hpm : ...</color></font/></align>");
          	}else {
          		sprintf(a,"<align=center><font=Tizen:style=regular font_size=25><color=#fafafa>hpm : %.0f</color></font/></align>", event->values[0]);
          	}
          	elm_object_text_set(ad->label4, a);
//          	ad->tab_result_counter ++;
//          	ad->tab_result = realloc(ad->tab_result, ad->tab_result_counter*sizeof(float));
//          	ad->tab_result[(ad->tab_result_counter)-1] = event->values[0];
      }
      break;
      default:
              dlog_print(DLOG_ERROR, LOG_TAG, "Not an HRM event");
   }
}

void create_HRM_listener(void *data) {
	appdata_s *ad = (appdata_s*)data;
	bool supported;
	error = sensor_is_supported(type, &supported);

	//deal with the default sensor


	//Create an event listener
	error = sensor_get_default_sensor(type, &ad->sensor);
	error = sensor_create_listener(ad->sensor, &ad->listener);
	error = sensor_listener_set_event_cb(ad->listener, 1000, on_sensor_event, data);

	error = sensor_listener_start(ad->listener);

	error = sensor_listener_set_option(ad->listener, SENSOR_OPTION_ALWAYS_ON);
	sensor_event_s event;
	error = sensor_listener_read_data(ad->listener, &event);
}

/*
 * Callback for the clicked signal
 * Called when the button is clicked by the user
 */

void clicked_recording_start(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;

	error = sensor_listener_unset_event_cb(ad->listener);
	error = sensor_listener_set_event_cb(ad->listener, 1000, on_sensor_event_2, data);

	elm_naviframe_item_pop(ad->nf);
}

void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s*)data;

	//deal with the default sensor

	error = sensor_listener_unset_event_cb(ad->listener);

	error = sensor_listener_stop(ad->listener);

	error = sensor_destroy_listener(ad->listener);

	elm_naviframe_item_pop(ad->nf);
}
