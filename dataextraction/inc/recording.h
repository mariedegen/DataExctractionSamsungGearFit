/*
 * recording.h
 *
 *  Created on: Oct 7, 2017
 *      Author: Marie
 */

#include <sensor.h>
#include <Elementary.h>

#ifndef RECORDING_H_
#define RECORDING_H_

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "RECORDING_TAG"

void on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data);
void on_sensor_event_2(sensor_h sensor, sensor_event_s *event, void *user_data);
void create_HRM_listener(void *data);
void clicked_recording_start(void *data, Evas_Object *obj, void *event_info);
void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info);


#endif /* RECORDING_H_ */
