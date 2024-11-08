using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject victoryFX;

    Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
        GameManager.Instance.OnGameWon.AddListener(OnGameWon);
    }

    public void TeleportBackToOrigin()
    {
        transform.position = initialPos;
    }

    void OnGameWon()
    {
        victoryFX.SetActive(true);
    }
}
