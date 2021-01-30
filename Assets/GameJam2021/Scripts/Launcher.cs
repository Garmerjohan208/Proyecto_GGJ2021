using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject controlPanel;
    [SerializeField] private GameObject progressPanel;
    [SerializeField] private string levelName = "";
    bool isConnecting;

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    private void Start()
    {
        progressPanel.SetActive(false);
        controlPanel.SetActive(true);
    }

    public override void OnConnectedToMaster()
    {
        if (isConnecting)
        {
            PhotonNetwork.JoinRandomRoom();
            isConnecting = false;
            Debug.Log("*** OnConnectedToMaster called ");
        }
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        progressPanel.SetActive(false);
        controlPanel.SetActive(true);
        isConnecting = false;
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("*** OnJoinRandomFailed()\nCalling: PhotonNetwork.CreateRoom");
        PhotonNetwork.CreateRoom(default, null);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(levelName);
    }

    public void OnPlayButtonClick()
    {
        progressPanel.SetActive(true);
        controlPanel.SetActive(false);
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            isConnecting = PhotonNetwork.ConnectUsingSettings();
        }
    }
}
