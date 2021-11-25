using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Connect_To_Serial_Port : MonoBehaviour
{
    public TMP_InputField com_port;
    public TMP_InputField password;

     public SerialController serialController;
    // Start is called before the first frame update
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
