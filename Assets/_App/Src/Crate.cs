using UnityEngine;

public class Crate : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Toy toy))
        {
            Debug.Log("Collected: " + toy.gameObject.name);

            GameManager.Instance.CollectedToy(toy);
        }
    }

}
