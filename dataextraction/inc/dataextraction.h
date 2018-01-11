 /**
 * \brief dataextraction.h
 * \author DEGEN Marie
 * \date Sep 25, 2017
 */

#ifndef __dataextraction_H__
#define __dataextraction_H__

#include <Elementary.h>
#include <sensor.h>
#include <app.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "dataextraction"

#if !defined(PACKAGE)
#define PACKAGE "org.example.dataextraction"
#endif

struct bt_server_s;
typedef struct bt_server bt_server_s;

/** @struct Structure with all the elements
 */

struct appdata {
	//Heart searching screen
	Evas_Object *box_heart;
	Evas_Object *label_heart;

	//Start button screen
	Evas_Object *start_button;
	Evas_Object *box;
	Evas_Object *label;

	//Stop Button screen
	Evas_Object *stop_button;
	Evas_Object *box_recording;
	Evas_Object *label2;
	Evas_Object *label3;
	Evas_Object *label4;
	Evas_Object *progress_bar;
	Evas_Object *end_button;

	//Bluetooth screen
	Evas_Object *box_bluetooth;
	Evas_Object *label_bluetooth;

	//Exit screen
	Evas_Object *box_end;
	Evas_Object *label_end;

	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *nf;

	//Exit Button
	Evas_Object *exit_button;

	//Data
	float *tab_result;
	unsigned int tab_result_counter;

	//Listener & Sensor
	sensor_listener_h listener;
	sensor_h sensor;
	bt_server_s* server;
	unsigned int start;
};
typedef struct appdata appdata_s;

/* Create the app */
bool app_create(void *data);

/* Create the GUI */
void create_base_gui(appdata_s *ad);

#endif /* __dataextraction_H__ */
