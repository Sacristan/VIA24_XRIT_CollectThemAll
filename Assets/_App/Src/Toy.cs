using UnityEngine;

public class Toy : MonoBehaviour
{
    AudioSource _audioSource;

    bool isCollected = false;

    [SerializeField] [Range(0.1f, 2f)] float minPitch = 0.8f;
    [SerializeField] [Range(0.1f, 2f)] float maxPitch = 1.2f;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Collected()
    {
        if (isCollected) return;

        isCollected = true;

        _audioSource.pitch = Random.Range(minPitch, maxPitch);
        _audioSource.Play();

        GameManager.Instance.CollectedToy(this);
    }
}
