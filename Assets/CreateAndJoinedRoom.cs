using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CreateAndJoinedRoom : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Photon master server");
    }

    public void CreateRoom()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.CreateRoom(createInput.text);
        }
        else
        {
            Debug.LogError("Not connected to Photon master server");
        }
    }

    public void JoinRoom()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRoom(joinInput.text);
        }
        else
        {
            Debug.LogError("Not connected to Photon master server");
        }
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("game");
    }
}
