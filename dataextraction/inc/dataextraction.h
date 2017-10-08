#ifndef __dataextraction_H__
#define __dataextraction_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "dataextraction"

#if !defined(PACKAGE)
#define PACKAGE "org.example.dataextraction"
#endif

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *start_button;
	Evas_Object *box;
	Evas_Object *box_recording;
	Evas_Object *stop_button;
	Evas_Object *progress_bar;
	Evas_Object *label2;
	Evas_Object *label3;
	Evas_Object *nf;
} appdata_s;

#endif /* __dataextraction_H__ */
