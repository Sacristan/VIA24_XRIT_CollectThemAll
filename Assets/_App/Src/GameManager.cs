using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    List<Prize> uncollectedToys;

    bool hasWon = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        uncollectedToys = new(FindObjectsOfType<Prize>());
    }

    public void CollectedToy(Prize toy)
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
        Invoke(nameof(RestartGame), 3f);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
