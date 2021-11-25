using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Connect_To_Serial_Port : MonoBehaviour
{
    public TMP_InputField com_port;
    public TMP_InputField password;
    public SerialController serialController;

    private bool pswSet = false;
    private bool comSet = false;
    // Start is called before the first frame update
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();   
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     Debug.Log("Sending A");
        //     serialController.SendSerialMessage("A");
        // }
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


//updates default port after button is clicked
    public void SetPort(){
        Debug.Log("Button clicked, set port");
        serialController.portName = com_port.text; 
        serialController.PortUpdated();
    }


//sets passwors to Arduino
    public void SetPassword(){
        Debug.Log("Button clicked, password set");
    }



}
