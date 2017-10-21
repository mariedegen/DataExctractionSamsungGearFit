/*
 * client_network.h
 *
 *  Created on: Oct 21, 2017
 *      Author: Marie
 */

#include <bluetooth.h>

#ifndef CLIENT_NETWORK_H_
#define CLIENT_NETWORK_H_

void socket_connection_state_changed(int result, bt_socket_connection_state_e connection_state, bt_socket_connection_s *connection, void *user_data);
void connection_to_server();

#endif /* CLIENT_NETWORK_H_ */
