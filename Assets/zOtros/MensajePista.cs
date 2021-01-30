using UnityEngine;

public class MensajePista : MonoBehaviour
{
    [SerializeField] private GameObject textoMensaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoMensaje.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoMensaje.SetActive(false);
        }
    }
}
