using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Networking : MonoBehaviour
{
    [SerializeField] string Version;
    [SerializeField] GameObject player;
    [SerializeField] Transform[] spawns;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings(Version);
    }

    public virtual void OnJoinedRoom()
    {
        Debug.Log("<color=orange>Initialized Player");
        int random = Random.Range(0, spawns.Length);
        PhotonNetwork.Instantiate(player.name, spawns[random].position, spawns[random].rotation, 0);
    }

    public virtual void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("meme", null, null);
    }
}
