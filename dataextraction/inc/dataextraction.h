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
	Evas_Object *nf;
	Evas_Object *start_button;
	Evas_Object *stop_button;
	Evas_Object *box;
	Evas_Object *box_recording;
	Evas_Object *box_bluetooth;
	Evas_Object *progress_bar;
	Evas_Object *label;
	Evas_Object *label2;
	Evas_Object *label3;
	Evas_Object *label_bluetooth;
} appdata_s;

void _add_entry_text(const char *text);
Evas_Object *_new_button(appdata_s *ad, Evas_Object *display, char *name, void *cb);
void _create_new_cd_display(appdata_s *ad, char *name, void *cb);
Eina_Bool _pop_cb(void *data, Elm_Object_Item *item);

#endif /* __dataextraction_H__ */
