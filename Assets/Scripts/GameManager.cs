using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ------ Singleton Setup ------
    private static GameManager instance;
    public static GameManager GetInstance()
    {
        return instance;
    }

    void SetSingleton()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    void Awake() 
    {
        SetSingleton();
    }

    // ------ End Singleton Setup ------

    [SerializeField] private GameObject cannonPrefab;
    [SerializeField] private Vector2 startPosition;

    int score;

    bool isPlaying;

    void Start() 
    {
        ResetGame();
    }


    public void IncrementScore() 
    {
        score++;
    }

    void ResetGame() 
    {
        score = 0;
        isPlaying = true;
        SpawnCannon();
    }

    void SpawnCannon() 
    {
        Instantiate(cannonPrefab, startPosition, Quaternion.identity);
    }
}
