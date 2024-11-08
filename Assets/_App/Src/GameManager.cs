using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    List<Toy> uncollectedToys;

    [SerializeField] float restartGameTime = 5f;

    bool hasWon = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        uncollectedToys = new(FindObjectsOfType<Toy>());
    }

    public void CollectedToy(Toy toy)
    {
        if (hasWon) return;

        uncollectedToys.Remove(toy);

        if (uncollectedToys.Count == 0)
        {
            Victory();
        }
    }

    void Victory()
    {
        hasWon = true;
        Debug.Log(nameof(Victory));
        Invoke(nameof(RestartGame), restartGameTime);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
