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
        Debug.Log("Cannon spawned");
    }
}
