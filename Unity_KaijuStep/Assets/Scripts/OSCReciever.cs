using UnityEngine;
using uOSC;

public class OSCReciever : MonoBehaviour
{
    private uOscServer server;

    void Start()
    {
        server = GetComponent<uOscServer>();
        server.onDataReceived.AddListener(ReceiveOSC);
    }

    public void ReceiveOSC(Message message)
    {
        string address = message.address;
        object[] values = message.values;

        string str = address;
        foreach (object value in values)
        {
            str += ", " + value.ToString();
        }

        Debug.Log(str);
    }
}
