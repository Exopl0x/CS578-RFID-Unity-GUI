using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Connect_To_Serial_Port : MonoBehaviour
{
    public static bool startConnection = false;
    public static bool messageSent = false;
    public TMP_InputField com_serialport;
    public TMP_InputField password;

    // public GameObject serialGameObject;
    
    public SerialController serialController;

    // Start is called before the first frame update
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();      
    }

    // Update is called once per frame
    void Update()
    {
        //---------------------------------------------------------------------
        // Receive data
        //---------------------------------------------------------------------
        if(messageSent == true){
            
            string message = serialController.ReadSerialMessage();
            if (message == null)
                return;
            Debug.Log(message);

            // Check if the message is plain data or a connect/disconnect event.
            if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
                Debug.Log("Connection established");
            else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
                Debug.Log("Connection attempt failed or disconnection detected");
            else
                Debug.Log("Message arrived: " + message);

        }

    }

    public void ChangeCom(){
        //---------------------------------------------------------------------
        // Send data
        //---------------------------------------------------------------------
        serialController.portName = com_serialport.text;
        serialController.StartThread();
        startConnection = true;
    }

    public void SendPassword(){
        serialController.SendSerialMessage(password.text.ToString());
        messageSent = true;
    }
}
