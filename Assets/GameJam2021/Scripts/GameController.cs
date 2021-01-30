using UnityEngine;
using Photon.Pun;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;

    private void Start()
    {
        if (PhotonNetwork.IsConnectedAndReady)
        {
            if (playerPrefab != null)
            {
                int randomNumber = Random.Range(10, -10);
                Vector3 randomPoint = new Vector3(randomNumber, 0.5f, randomNumber);
                PhotonNetwork.Instantiate(playerPrefab.name, randomPoint, Quaternion.identity);
            }
            else
                Debug.Log("*** playerPrefab is missing...");
        }
    }
}
