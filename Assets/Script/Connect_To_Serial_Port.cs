using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Connect_To_Serial_Port : MonoBehaviour
{
    public static bool startConnection = false;
    public TMP_InputField com_serialport;
    public TMP_InputField password;

    // public GameObject serialGameObject;
    
    public SerialController serialController;

    // Start is called before the first frame update
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();

        Debug.Log("Press A or Z to execute some actions");
        
    }

    // Update is called once per frame
    void Update()
    {
                //---------------------------------------------------------------------
        // Send data
        //---------------------------------------------------------------------

        // If you press one of these keys send it to the serial device. A
        // sample serial device that accepts this input is given in the README.
        if(startConnection == true){
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Sending A");
                serialController.SendSerialMessage("A");
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Sending Z");
                serialController.SendSerialMessage("Z");
            }
        }


        //---------------------------------------------------------------------
        // Receive data
        //---------------------------------------------------------------------

        // string message = serialController.ReadSerialMessage();

        // if (message == null)
        //     return;

        // // Check if the message is plain data or a connect/disconnect event.
        // if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
        //     Debug.Log("Connection established");
        // else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
        //     Debug.Log("Connection attempt failed or disconnection detected");
        // else
        //     Debug.Log("Message arrived: " + message);
    }

    public void ChangeCom(){
        serialController.portName = com_serialport.text;
        serialController.StartThread();
        startConnection = true;
        // serialGameObject.SetActive(false);
        // Debug.Log(com_serialport.text);
    }
}
