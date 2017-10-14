/*
 * recording.h
 *
 *  Created on: Oct 7, 2017
 *      Author: Marie
 */

#ifndef RECORDING_H_
#define RECORDING_H_

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

void create_HRM_listener(void *data);
void clicked_recording_start(void *data, Evas_Object *obj, void *event_info);
void clicked_recording_stop(void *data, Evas_Object *obj, void *event_info);


#endif /* RECORDING_H_ */
