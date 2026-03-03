using UnityEngine;

public class Cointrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Coin collected");
            Destroy(gameObject);
        }
    }
}


