/**
 * \brief timer.c
 * \author DEGEN Marie
 * \date Oct 17, 2017
 */

#include "timer.h"

/**
* @brief Timer in order to know how much time it record the heart beat
* @param start
* @return time the time since it started recording
**/
char* timer_sensor(unsigned int start)
{
	unsigned int end = time(NULL);
	unsigned int duration = end - start;
	unsigned int seconds = 0;
	unsigned int minutes = 0;
	char * time = malloc(100 * sizeof(char));

	if(duration > 59){
		minutes = duration/60;
		seconds = duration%60;
		sprintf(time,"%02u:%02u", minutes, seconds);
	}else {
		sprintf(time,"00:%02u", duration);
	}

	return time;
}
