using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController gameController;

    private void OnEnable()
    {
        if (gameController == null)
            gameController = this;
        else
        {
            if(gameController != this)
            {
                Destroy(gameController.gameObject);
                gameController = this;
            }

        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        
    }

    public void LoadEscenaPaisaje()
    {
        SceneManager.LoadScene("Escena paisaje");
    }

}
