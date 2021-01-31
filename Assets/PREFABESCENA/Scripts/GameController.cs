using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController gameController;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject CanvasUI;

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
        animator.SetBool("activateStartAnim", true);
    }

    public void LoadEscenaPaisaje()
    {
        animator.SetBool("activateStartAnim", false);
        CanvasUI.SetActive(false);
        SceneManager.LoadScene("Escena paisaje");
    }

}
