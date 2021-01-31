using UnityEngine;

public class MensajePista : MonoBehaviour
{
    [SerializeField] private GameObject textoMensaje;
    [SerializeField] private ParticleSystem explosionParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoMensaje.SetActive(true);
            explosionParticle.Play();
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
