using UnityEngine;

public class Crate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Prize prize))
        {
            Debug.Log("Collected: " + prize.gameObject.name);
        }
    }

}
