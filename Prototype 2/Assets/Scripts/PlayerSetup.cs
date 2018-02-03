using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour {

    //public GameObject cam;
    public GameObject[] toDisable;
    public MonoBehaviour[] toDisableCode;

    PhotonView photonView;

    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (photonView.isMine)
        {

        }
        else
        {
            foreach (MonoBehaviour script in toDisableCode)
            {
                script.enabled = false;
            }

            foreach (GameObject go in toDisable)
            {
                go.SetActive(false);
            }
        }
    }
}
