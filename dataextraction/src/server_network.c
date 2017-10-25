#include <system_info.h>
#include <bluetooth.h>
#include <bluetooth_type.h>
#include "dataextraction.h"
#include <dlog.h>
#include "constants.h"

int error;
bt_advertiser_h advertiser;

/**
* @brief Check the different type of error you can have for a given function
* @param int error
* @param functionName the function we are trying
**/
void checkBtError(int error, const char* functionName)
{
	switch(error)
	{
		case BT_ERROR_CANCELLED:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] CANCELLED", functionName);
			break;
		case BT_ERROR_OUT_OF_MEMORY:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_OUT_OF_MEMORY", functionName);
			break;
		case BT_ERROR_RESOURCE_BUSY :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_RESOURCE_BUSY ", functionName);
			break;
		case BT_ERROR_TIMED_OUT :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_TIMED_OUT", functionName);
			break;
		case BT_ERROR_NOW_IN_PROGRESS :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOW_IN_PROGRESS ", functionName);
			break;
		case BT_ERROR_NOT_SUPPORTED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_SUPPORTED ", functionName);
			break;
		case BT_ERROR_PERMISSION_DENIED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_PERMISSION_DENIED ", functionName);
			break;
		case BT_ERROR_QUOTA_EXCEEDED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_QUOTA_EXCEEDED ", functionName);
			break;
		case BT_ERROR_NO_DATA:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NO_DATA", functionName);
			break;
		case BT_ERROR_NOT_INITIALIZED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_INITIALIZED ", functionName);
			break;
		case BT_ERROR_NOT_ENABLED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_ENABLED ", functionName);
			break;
		case BT_ERROR_ALREADY_DONE :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_ALREADY_DONE ", functionName);
			break;
		case BT_ERROR_NOT_IN_PROGRESS :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_NOT_IN_PROGRESS ", functionName);
			break;
		case BT_ERROR_REMOTE_DEVICE_NOT_BONDED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_REMOTE_DEVICE_NOT_BONDED ", functionName);
			break;
		case BT_ERROR_AUTH_REJECTED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_AUTH_REJECTED ", functionName);
			break;
		case BT_ERROR_AUTH_FAILED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_AUTH_FAILED ", functionName);
			break;
		case BT_ERROR_INVALID_PARAMETER:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] INVALIDE PARAM", functionName);
			break;
		case BT_ERROR_OPERATION_FAILED:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] OPERATION FAILED", functionName);
			break;
		case BT_ERROR_REMOTE_DEVICE_NOT_FOUND :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_REMOTE_DEVICE_NOT_FOUND ", functionName);
			break;
		case BT_ERROR_SERVICE_SEARCH_FAILED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_SERVICE_SEARCH_FAILED ", functionName);
			break;
		case BT_ERROR_REMOTE_DEVICE_NOT_CONNECTED :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_REMOTE_DEVICE_NOT_CONNECTED ", functionName);
			break;
		case BT_ERROR_AGAIN :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_AGAIN ", functionName);
			break;
		case BT_ERROR_SERVICE_NOT_FOUND :
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] BT_ERROR_SERVICE_NOT_FOUND ", functionName);
			break;
		case BT_ERROR_NONE:
			dlog_print(DLOG_INFO, "Bluetooth", "[%s] success.", functionName);
			break;
		default:
			dlog_print(DLOG_ERROR, "Bluetooth", "[%s] unknown error code : %d.", functionName, error);
			break;
	}
}

/**
* @brief initialize the bluetooth
**/
void initialize_bluetooth()
{
	//Initialize the bluetooth
	error = bt_initialize();
	checkBtError(error, "bt_initialize");
}


/**
* @brief detinitialize the bluetooth
**/
void bt_common_finalize()
{
	error = bt_deinitialize();
	checkBtError(error, "bt_deinitialize");
}

/**
* @brief Check wether the bluetooth of the device is activated or not
* @return true if the bluetooth is enable, false otherwise
**/
void is_enbaled()
{
	//Check if the bluetooth is enabled or not
	bt_adapter_state_e adapter_state;

	//Bluetooth adapter is enabled
	error = bt_adapter_get_state(&adapter_state);
	checkBtError(error, "bt_adapter_get_state");

	//Bluetooth adapter is not enabled
	if (adapter_state != BT_ADAPTER_ENABLED)
	{
	   dlog_print(DLOG_ERROR, "Bluetooth", "Bluetooth adapter is not enabled. You should enable the Bluetooth before doing the test.");
	}
}

/**
* @brief Callback function to monitor the state of the bluetooth
* @param state_cb the state of the bluetooth adapter
**/
void set_state_change_callback(bt_adapter_state_changed_cb state_cb)
{
	error = bt_adapter_set_state_changed_cb(state_cb, NULL);
	checkBtError(error, "bt_adapter_set_state_changed_cb");
}

/**
* @brief Callback function unset the function on the bluetooth adapter
**/
void unset_state_cb()
{
	error = bt_adapter_unset_state_changed_cb();
	checkBtError(error, "bt_adapter_unset_state_changed_cb");
}

/**
* @brief Create the advertizer for the Low Energy Bluetooth
* @param advertizer
**/
void create_advertizer(bt_advertiser_h *advertizer)
{
	error = bt_adapter_le_create_advertiser(advertizer);
	checkBtError(error, "bt_adapter_le_create_advertiser");
}

/**
* @brief Destroy the advertizer for the Low Energy Bluetooth
* @param advertizer
**/
void delete_advertizer(bt_advertiser_h advertizer)
{
	error = bt_adapter_le_destroy_advertiser(advertizer);
	checkBtError(error, "bt_adapter_le_destroy_advertiser");
}

 /**
* @brief Set the bluetooth LE advertizer mode
* @param advertizer
* @param the advertizer's mode
			Available modes are:
			- BT_ADAPTER_LE_ADVERTISING_MODE_BALANCED,
			- BT_ADAPTER_LE_ADVERTISING_MODE_LOW_LATENCY,
			- BT_ADAPTER_LE_ADVERTISING_MODE_LOW_ENERGY.
**/
void advertizer_mode(bt_advertiser_h advertizer, bt_adapter_le_advertising_mode_e mode)
{
	error = bt_adapter_le_set_advertising_mode(advertizer, mode);
	checkBtError(error, "bt_adapter_le_set_advertising_mode");
}

 /**
* @brief Set the Bluetooth LE advertiser connectable
* @param advertizer
**/
void set_connection_advertizer(bt_advertiser_h advertizer)
{
	error = bt_adapter_le_set_advertising_connectable(advertizer, true);
	checkBtError(error, "bt_adapter_le_set_advertising_connectable");
}

/**
* @brief whether the bluetooth ad'name should be included or not into the transmitted packets.
* @param advertizer
* @param pkt_type
* @param flag true is you want to include the device name into the packets false otherwise
**/
void device_name(bt_advertiser_h advertizer, bt_adapter_le_packet_type_e pkt_type, bool flag)
{
	error = bt_adapter_le_set_advertising_device_name(advertizer, pkt_type, flag);
	checkBtError(error, "bt_adapter_le_set_advertising_device_name");
}

/**
* @brief Identifie the data that is carried by the packet
* @param advertizer
* @param pkt_type
* @param uuid identifier of the data
**/
void uuid_service(bt_advertiser_h advertizer, bt_adapter_le_packet_type_e pkt_type, const char *uuid)
{
	error = bt_adapter_le_add_advertising_service_solicitation_uuid(advertizer, pkt_type, uuid);
	checkBtError(error, "bt_adapter_le_add_advertising_service_solicitation_uuid");
}

/**
* @brief Check if the data in relation with the previous UUID was successfully set
* @param advertizer
* @param pkt_type
* @param uuid identifier of the data
* @param service_data
* @param service_data_len
**/
void set_data_service(bt_advertiser_h advertiser, bt_adapter_le_packet_type_e pkt_type, const char *uuid, const char *service_data, int service_data_len)
{
	error = bt_adapter_le_add_advertising_service_data(advertiser, pkt_type, uuid, service_data, service_data_len);
	checkBtError(error, "bt_adapter_le_add_advertising_service_data");
}

/**
* @brief Start the sevice's data broadcastinf by the BLE advertizer
* @param advertizer
* @param state_cb
**/
void start_advertising(bt_advertiser_h advertizer, bt_adapter_le_advertising_state_changed_cb state_cb)
{
	error = bt_adapter_le_start_advertising_new(advertizer, state_cb, NULL);
	checkBtError(error, "bt_adapter_le_start_advertising_new");
}

 /**
* @brief Stop the sevice's data broadcastinf by the BLE advertizer
* @param advertizer
**/
void stop_advertising(bt_advertiser_h advertizer)
{
	error = bt_adapter_le_stop_advertising(advertizer);
	checkBtError(error, "bt_adapter_le_stop_advertising");
}

/**
* @brief Clear all the advertizer's settings and data
* @param advertizer
* @param pkt_type
**/
void clear_advertizer(bt_advertiser_h advertizer, bt_adapter_le_packet_type_e pkt_type)
{
	error = bt_adapter_le_clear_advertising_data(advertizer, pkt_type);
	checkBtError(error, "bt_adapter_le_clear_advertising_data");
}

/**
* @brief Take all the Heart data (float) and put them into a const char
* @param tab_result a tab of float
* @param tab_result_length size of tab_result
* @return const char* with the heart data
**/
void configure_data(float *tab_result, int tab_result_length)
{
	//Then send the data from the tab
	int counter = 0;

	char *tab = malloc(counter + sizeof(char));
	if(tab == NULL)
	{
		//Deal with the memory error
		dlog_print(DLOG_ERROR, LOG_TAG, "Out of memory for tab->result");
	}
	while(counter != tab_result_length)
	{
		counter++;

		//Put the float into a string
		char a[128];
		sprintf(a, "%f ",tab_result[counter]);

		//Realloc the tab from the init size + a size
		tab = realloc(tab, (strlen(tab) + strlen(a)) * sizeof(char));

		//Concatenate tab and a
		strcat(tab, a);

	}
	//Function not done yet
	set_data_service(&advertiser, UUID, tab, sizeof(tab));
}

}
