/**
 * \brief server_network.c
 * \author DEGEN Marie
 * \date Oct 21, 2017
 */

#include <system_info.h>
#include <bluetooth.h>
#include <bluetooth_type.h>
#include "dataextraction.h"
#include <dlog.h>
#include "constants.h"
#include "server_network.h"
#include "exit_screen.h"

/* For the code error */
int error;

/**
* @brief Check the different type of error you can have for a given function
* @param int error
* @param functionName the function we are trying
**/
bool checkBtError(int error, const char* functionName)
{
	switch(error)
	{
		case BT_ERROR_CANCELLED:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] CANCELLED", functionName);
			return false;
		case BT_ERROR_OUT_OF_MEMORY:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_OUT_OF_MEMORY", functionName);
			return false;
		case BT_ERROR_RESOURCE_BUSY :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_RESOURCE_BUSY ", functionName);
			return false;
		case BT_ERROR_TIMED_OUT :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_TIMED_OUT", functionName);
			return false;
		case BT_ERROR_NOW_IN_PROGRESS :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOW_IN_PROGRESS ", functionName);
			return false;
		case BT_ERROR_NOT_SUPPORTED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_SUPPORTED ", functionName);
			return false;
		case BT_ERROR_PERMISSION_DENIED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_PERMISSION_DENIED ", functionName);
			return false;
		case BT_ERROR_QUOTA_EXCEEDED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_QUOTA_EXCEEDED ", functionName);
			return false;
		case BT_ERROR_NO_DATA:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NO_DATA", functionName);
			return false;;
		case BT_ERROR_NOT_INITIALIZED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_INITIALIZED ", functionName);
			return false;
		case BT_ERROR_NOT_ENABLED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_ENABLED ", functionName);
			return false;
		case BT_ERROR_ALREADY_DONE :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_ALREADY_DONE ", functionName);
			return false;
		case BT_ERROR_NOT_IN_PROGRESS :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_IN_PROGRESS ", functionName);
			return false;
		case BT_ERROR_REMOTE_DEVICE_NOT_BONDED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_REMOTE_DEVICE_NOT_BONDED ", functionName);
			return false;
		case BT_ERROR_AUTH_REJECTED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_AUTH_REJECTED ", functionName);
			return false;
		case BT_ERROR_AUTH_FAILED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_AUTH_FAILED ", functionName);
			return false;
		case BT_ERROR_INVALID_PARAMETER:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] INVALIDE PARAM", functionName);
			return false;
		case BT_ERROR_OPERATION_FAILED:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] OPERATION FAILED", functionName);
			return false;
		case BT_ERROR_REMOTE_DEVICE_NOT_FOUND :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_REMOTE_DEVICE_NOT_FOUND ", functionName);
			return false;
		case BT_ERROR_SERVICE_SEARCH_FAILED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_SERVICE_SEARCH_FAILED ", functionName);
			return false;
		case BT_ERROR_REMOTE_DEVICE_NOT_CONNECTED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_REMOTE_DEVICE_NOT_CONNECTED ", functionName);
			return false;
		case BT_ERROR_AGAIN :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_AGAIN ", functionName);
			return false;
		case BT_ERROR_SERVICE_NOT_FOUND :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_SERVICE_NOT_FOUND ", functionName);
			return false;
		case BT_ERROR_NONE:
			dlog_print(DLOG_INFO, "Bluetooth", "[%s] success.", functionName);
			return true;
		default:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] unknown error code : %d.", functionName, error);
			return false;
	}
}

/**
* @brief initialize the bluetooth
**/
bool initialize_bluetooth()
{
	//Initialize the bluetooth
	error = bt_initialize();
	return checkBtError(error, "bt_initialize");
}


/**
* @brief detinitialize the bluetooth
**/
bool finalize_bluetooth()
{
	error = bt_deinitialize();
	return checkBtError(error, "bt_deinitialize");
}

/**
* @brief Check wether the bluetooth of the device is activated or not
* @return true if the bluetooth is enable, false otherwise
**/
bool is_enbaled()
{
	//Check if the bluetooth is enabled or not
	bt_adapter_state_e adapter_state;

	//Bluetooth adapter is enabled
	error = bt_adapter_get_state(&adapter_state);
	return checkBtError(error, "bt_adapter_get_state");

	//Bluetooth adapter is not enabled
	if (adapter_state != BT_ADAPTER_ENABLED)
	{
	   dlog_print(DLOG_ERROR, "Bluetooth", "Bluetooth adapter is not enabled. You should enable the Bluetooth before doing the test.");
	}
}

/**
* @brief Bluetooth server management : start the server
* @param appdata structure
**/
bt_server_s* start_bt_server(appdata_s *ad)
{
	// Create a server and initializes it.
	ad->server = malloc(sizeof(bt_server_s));
	ad->server->uuid = "00001101-0000-1000-8000-00805F9B34FB";
	ad->server->server_socket_fd = -1;

	// We have no client, so we set the clients pointers to NULL.
	for(int i = 0 ; i < 5 ; ++i)
	{
		ad->server->clients[i] = NULL;
	}

	// Create a RFCOMM socket for the server and check for error.
	bt_error_e error;
	error = bt_socket_create_rfcomm(ad->server->uuid, &ad->server->server_socket_fd);
	checkBtError(error, "bt_socket_create_rfcomm");

	// Set the callback function.
	// This function is called when a client connects to the server.
	bt_socket_set_connection_state_changed_cb(bt_server_new_client_connected, (void*)ad);

	// Launch the server => ask the server to listen and accept any new client.
	// We can accept a maximum of 5 client at once.
	error = bt_socket_listen_and_accept_rfcomm(ad->server->server_socket_fd, 5);
	if (error != BT_ERROR_NONE)
	{
	    checkBtError(error, "bt_socket_listen_and_accept_rfcomm");
	}
	else
	{
	    dlog_print(DLOG_INFO, "BluetoothServer", "[bt_socket_listen_and_accept_rfcomm] Succeeded. bt_socket_connection_state_changed_cb will be called.");
	}

	// Return the newly created server.
	return ad->server;
}

/**
* @brief Bluetooth server management : stop the server
* @param server the bluetooth server to stop
**/
void stop_bt_server(bt_server_s* server)
{
	int error = -1;

	//Free all the clients
	for(int i = 0 ; i < 5 ; ++i)
	{
		if(server->clients[i] != NULL)
		{
			error = bt_socket_disconnect_rfcomm(server->clients[i]->client_socket_fd);
			checkBtError(error, "bt_socket_disconnect_rfcomm");

			free(server->clients[i]);
		}
	}

	//Destroy server's socket
	error = bt_socket_destroy_rfcomm(server->server_socket_fd);
	checkBtError(error, "bt_socket_destroy_rfcomm");
}

/**
* @brief Let the client connecting to the server and then send the data to them
* @param result for the error code
* @param connection_state
* @param connection
* @param user_data here appdata is given as an argument
**/
void bt_server_new_client_connected(int result, bt_socket_connection_state_e connection_state, bt_socket_connection_s *connection, void *user_data)
{
	appdata_s *ad = (void*)user_data;

	// In case of error, we check the error.
	if (result != BT_ERROR_NONE)
		checkBtError(result, "bt_server_new_client_connected");

	// A new client is connected !
	if(connection_state == BT_SOCKET_CONNECTED)
	{
		dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Connected.");

		if(connection != NULL)
		{
			dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Socket of connection - %d.", connection->socket_fd);
			dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Role of connection - %d.", connection->local_role);
			dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Address of connection - %s.", connection->remote_address);

			/* socket_fd is used for sending data and disconnecting a device */
			// We want to store the client data into a client struct.

			bt_server_client_s* client = malloc(sizeof(bt_server_client_s));
			client->client_socket_fd = connection->socket_fd;
			client->remote_address = connection->remote_address;

			// Find a free client slot and store the client data in it.
			for(int i = 0 ; i < 5 ; ++i)
			{
				// We found a free client slot in our server, so we store our new client in it.
				if(ad->server->clients[i] == NULL)
				{
					ad->server->clients[i] = client;
				}
			}

			//Then send the data from the tab
			int counter = 0;

			char *arrayOfFloatsAsStrings = malloc(counter * sizeof(char));
			if(arrayOfFloatsAsStrings == NULL)
			{
				//Deal with the memory error
				dlog_print(DLOG_ERROR, "BluetoothServer", "Out of memory for tab->result");
			}

			while(counter != ad->tab_result_counter)
			{
				counter++;

				//Put the float into a string
				char tempBuffer[128] = {0,};
				sprintf(tempBuffer, "%f ", ad->tab_result[counter]);

				//Realloc the tab from the init size + a size
				arrayOfFloatsAsStrings = realloc(arrayOfFloatsAsStrings, (strlen(arrayOfFloatsAsStrings) + strlen(tempBuffer)) * sizeof(char));

				//Concatenate tab and a
				strcat(arrayOfFloatsAsStrings, tempBuffer);
			}

			dlog_print(DLOG_INFO, "BluetoothServer", "Sent: '%s'", arrayOfFloatsAsStrings);

			//Sending the tab
			error = bt_socket_send_data(client->client_socket_fd, arrayOfFloatsAsStrings, strlen(arrayOfFloatsAsStrings) * sizeof(char));
			checkBtError(error, "bt_socket_send_data");

			//Sent the end of the process
			char end[] = "END";
			error = bt_socket_send_data(client->client_socket_fd, end, strlen(end) * sizeof(char));
			checkBtError(error, "bt_socket_send_data");

			dlog_print(DLOG_INFO, "BluetoothServer", "All data sent");

			elm_naviframe_item_pop(ad->nf);
		}

		else
		{
			dlog_print(DLOG_INFO, "BluetoothServer", "Callback: No connection data");
		}
	}
	// A client disconnected itself from the server.
	else
	{
		dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Disconnected.");

		if(connection != NULL)
		{
			dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Socket of disconnection - %d.", connection->socket_fd);
			dlog_print(DLOG_INFO, "BluetoothServer", "Callback: Address of connection - %s.", connection->remote_address);

			// Find the client who disconnected, delete its data and free its slot.
			for(int i = 0 ; i < 5 ; ++i)
			{
				// if the client pointer is not NULL, we compare its remote address to the remote address of the client who just disconnected.
				if(ad->server->clients[i] != NULL && strcmp(ad->server->clients[i]->remote_address, connection->remote_address) == 0)
				{
					free(ad->server->clients[i]); // free the client
					ad->server->clients[i] = NULL; // free the client slot
				}
			}
		}
		else
		{
			dlog_print(DLOG_INFO, LOG_TAG, "Callback: No connection data");
		}
	}
}
