using UnityEngine;

public class EscenaPaisajeController : MonoBehaviour
{
    //[SerializeField] private AudioSource environmentAudio;
    //[SerializeField] private AudioSource churchAudio;
    //[SerializeField] private AudioSource forestAudio;
    //[SerializeField] private AudioSource waterpillarAudio;

    [SerializeField] private GameObject playerPrefab;

    void Start()
    {
        Vector3 playerSpawnPoint = new Vector3(340, 7, 197);
        Instantiate(playerPrefab, playerSpawnPoint, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
