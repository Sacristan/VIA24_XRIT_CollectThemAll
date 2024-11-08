using UnityEngine;

public class SafetyNet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Toy toy))
        {
            GameManager.Instance.CollectedToy(toy);
        }
        else if (other.TryGetComponent(out Player player))
        {
            player.TeleportBackToOrigin();
        }
    }

}