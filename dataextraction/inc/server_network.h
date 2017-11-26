/*
 * SERVER_NETWORK.h
 *
 *  Created on: Oct 21, 2017
 *      Author: Marie
 */

#include <bluetooth.h>
#include "dataextraction.h"

#ifndef SERVER_NETWORK_H_
#define SERVER_NETWORK_H_

/* Bluetooth server management. */
/* Bluetooth server client. */
struct bt_server_client
{
	int client_socket_fd;
	const char* remote_address;
};
typedef struct bt_server_client bt_server_client_s;

/* Bluetooth server. */
struct bt_server
{
	const char* uuid;
	int server_socket_fd;
	bt_server_client_s* clients[5]; // The server can have at maximum 5 clients.
};
typedef struct bt_server bt_server_s;

bool checkBtError(int error, const char* functionName);
bool initialize_bluetooth();
bool finalize_bluetooth();
bool is_enbaled();

/* Starts a bluetooth server and returns a pointer to it. */
bt_server_s* start_bt_server(appdata_s *ad);

/* Frees a bluetooth server. */
void stop_bt_server(bt_server_s* server);

/* Function called when a new client connects to the server. */
void bt_server_new_client_connected(int result, bt_socket_connection_state_e connection_state, bt_socket_connection_s *connection, void *user_data);

void writeFile(const char *data);

#endif /* SERVER_NETWORK_H_ */
