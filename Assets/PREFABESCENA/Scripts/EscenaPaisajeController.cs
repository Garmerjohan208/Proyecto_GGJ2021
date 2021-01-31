using UnityEngine;

public class EscenaPaisajeController : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;


    void Start()
    {
        Vector3 playerSpawnPoint = new Vector3(360, 5.5f, 260);
        Instantiate(playerPrefab, playerSpawnPoint, Quaternion.identity);
    }
}
