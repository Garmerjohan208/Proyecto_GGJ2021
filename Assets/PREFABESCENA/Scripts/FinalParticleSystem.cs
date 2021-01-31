using UnityEngine;

public class FinalParticleSystem : MonoBehaviour
{
    [SerializeField] private ParticleSystem victoryParticleSystem;

    private void Start()
    {
        victoryParticleSystem.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            victoryParticleSystem.Play();
        }
    }
}
