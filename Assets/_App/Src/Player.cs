using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
    }

    public void TeleportBackToOrigin()
    {
        transform.position = initialPos;
    }
}
