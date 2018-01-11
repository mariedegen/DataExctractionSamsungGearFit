/**
 * \brief recording.h
 * \author DEGEN Marie
 * \date Oct 7, 2017
 */
#include <sensor.h>
#include <Elementary.h>

#ifndef RECORDING_H_
#define RECORDING_H_

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "RECORDING_TAG"

/* Sensor event for when the hearbeat is higher than 40bpm goes to the next screen */
void on_sensor_event(sensor_h sensor, sensor_event_s *event, void *user_data);

/* Sensor event that start recording data */
void on_sensor_event_2(sensor_h sensor, sensor_event_s *event, void *user_data);

/* Create the HRM listener */
void create_HRM_listener(void *data);

/* Callback function for the start button event */
void clicked_recording_start(void *data, Evas_Object *obj, void *event_info);

/* Callback function for the stop button event */
void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info);


#endif /* RECORDING_H_ */
