using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    private GroundPiece[] allGroundPieces;
    public Animator transition;
    public float transitionTime = 1f;
    public GameObject ball;
    int sceneIndex, levelPassed;
    
    void Start()
    {
        SetupNewLevel();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }


    private void SetupNewLevel()
    {
        allGroundPieces = FindObjectsOfType<GroundPiece>();
    }

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }else if (singleton != this)
        {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        SetupNewLevel();
    }

    public void CheckComplete()
    {
        bool isFinished = true;

        for (int i = 0; i < allGroundPieces.Length; i++)
        {
            if (allGroundPieces[i].isColored == false)
            {
                isFinished = false;
                break;
            }
        }

        if (isFinished)
        {
            NextLevel();
        }
    }

    private void NextLevel()
    {
        ball.GetComponent<BallController>().enabled = false;
        
        if(SceneManager.GetActiveScene().buildIndex >= 9)
        {
            StartCoroutine(LevelStart(0));
        }
        else
        {
            if(levelPassed<sceneIndex)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            StartCoroutine(LevelStart(SceneManager.GetActiveScene().buildIndex + 1));
            
        }
    }

    public IEnumerator LevelStart(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
    
}
