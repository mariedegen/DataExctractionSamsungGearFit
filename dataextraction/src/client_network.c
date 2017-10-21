/*
 * client_network.c
 *
 *  Created on: Oct 21, 2017
 *      Author: Marie
 */

#include "client_network.h"
#include "recording.h"
#include "dataextraction.h"
#include "constants.h"
#include <bluetooth.h>
#include <dlog.h>

void socket_connection_state_changed(int result, bt_socket_connection_state_e connection_state, bt_socket_connection_s *connection, void *user_data)
{
	appdata_s *ad = (appdata_s*)user_data;
	bt_error_e error;

	if (result != BT_ERROR_NONE)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "[socket_connection_state_changed_cb] Failed. result =%d.", result);

		return;
	}

	if (connection_state == BT_SOCKET_CONNECTED)
	{
		dlog_print(DLOG_INFO, LOG_TAG, "Callback: Connected.");
		if (connection != NULL)
		{
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: Socket of connection - %d.", connection->socket_fd);
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: Role of connection - %d.", connection->local_role);
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: Address of connection - %s.", connection->remote_address);

			//Socket_fd is used for sending data and disconnecting a device
			int server_socket_fd = connection->socket_fd;

			//Sending a char* for notify the begining of the data
			int client_socket_fd = 0;
			char begin[] = "Send the data";

			error = bt_socket_send_data(client_socket_fd, begin, sizeof(begin));
			if (error != BT_ERROR_NONE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_send_data] failed.");
			}

			//Then send the data from the tab
			int counter = 0;

			char *tab = malloc(counter + sizeof(char));
			if(tab == NULL)
			{
				//Deal with the memory error
				dlog_print(DLOG_ERROR, LOG_TAG, "Out of memory for tab->result");
			}

			while(counter != ad->tab_result_counter)
			{
				counter++;

				//Put the float into a string
				char a[128];
				sprintf(a, "%f ",ad->tab_result[counter]);

				//Realloc the tab from the init size + a size
				tab = realloc(tab, (strlen(tab) + strlen(a)) * sizeof(char));

				//Concatenate tab and a
				strcat(tab, a);

			}
			error = bt_socket_send_data(client_socket_fd, tab, sizeof(tab));
			if (error != BT_ERROR_NONE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_send_data] failed.");
			}

			//Sending a char* for notify the end
			char end[] = "End of data";

			error = bt_socket_send_data(client_socket_fd, end, sizeof(end));
			if (error != BT_ERROR_NONE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_send_data] failed.");
			}

			dlog_print(DLOG_INFO, "DATA_SENDING", "All the data is sent");

			//Disconnect from the main application
			error = bt_socket_disconnect_rfcomm(client_socket_fd);
			if (error != BT_ERROR_NONE)
			{
			   dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_destroy_rfcomm] Failed. server_socket_fd = %d.", server_socket_fd);
			}
			else
			{
			   dlog_print(DLOG_INFO, LOG_TAG, "[bt_socket_destroy_rfcomm] Succeeded. server_socket_fd = %d.", server_socket_fd);
			}
		}
		else
		{
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: No connection data");
		}
	}
	else
	{
		dlog_print(DLOG_INFO, LOG_TAG, "Callback: Disconnected.");
		if (connection != NULL)
		{
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: Socket of disconnection - %d.", connection->socket_fd);
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: Address of connection - %s.", connection->remote_address);
		}
		else
		{
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: No connection data");
		}
	}
}

void connection_to_server()
{

	//Initialize bluetooth
	bt_error_e error;

	error = bt_initialize();
	if (error != BT_ERROR_NONE)
	{
	   dlog_print(DLOG_ERROR, LOG_TAG, "[bt_initialize] Failed.");
	}

	//Bluetooth SPP
	//To establish a connection with your device acting as a client
	error = bt_socket_set_connection_state_changed_cb(socket_connection_state_changed, NULL);
	if(error != BT_ERROR_NONE)
	{
	   dlog_print(DLOG_ERROR, LOG_TAG, "[bt_socket_set_connection_state_changed_cb] failed.");
	   return;
	}
}
