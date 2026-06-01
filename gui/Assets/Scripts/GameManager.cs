using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        MenuPrincipal,
        Gameplay
    }

    public GameState CurrentState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeState(GameState.MenuPrincipal);

        SceneManager.LoadScene("MenuPrincipal");
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado: " + CurrentState);
    }

    public void StartGame()
    {
        ChangeState(GameState.Gameplay);

        SceneManager.LoadScene("SampleScene");
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SampleScene")
        {
            SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
        }
    }
}
