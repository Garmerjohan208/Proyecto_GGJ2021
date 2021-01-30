using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;


public class PlayerName : MonoBehaviour
{
    const string playerNamePrefKey = "PlayerName";

    private void Start()
    {
        InputField inputField = GetComponent<InputField>();
        string name = string.Empty;
        
        if (inputField != null)
        {
            if (PlayerPrefs.HasKey(playerNamePrefKey))
            {
                name = PlayerPrefs.GetString(playerNamePrefKey);
                inputField.text = name;
            }
        }
        PhotonNetwork.NickName = name;
    }

    public void SetPlayerName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return;
        }
        else
            PhotonNetwork.NickName = value;

        PlayerPrefs.SetString(playerNamePrefKey, value);
    }
}
