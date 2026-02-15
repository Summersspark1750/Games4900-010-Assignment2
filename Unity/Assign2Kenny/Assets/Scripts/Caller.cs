using UnityEngine;

public class Caller : MonoBehaviour
{
    public Receiver receiver;   //

    void Start()
    {
        Debug.Log("Calling...");
        receiver.OnCalled();
    }
}