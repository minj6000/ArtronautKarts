using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InstantiateDeco : MonoBehaviour
{
    private Gamemanager_film manager;
    [SerializeField] Camera arCam;
    // Start is called before the first frame update
    void Start()
    {
        manager = this.GetComponent<Gamemanager_film>();
    }

    public void Onclick(GameObject objToInstantiate)
    {
        manager.instantiatedObj = objToInstantiate.gameObject;
    }
    // Start is called before the first frame update


    public void LutChange(Texture texture)
    {
        arCam.GetComponent<AmplifyColorEffect>().LutTexture = texture;
    }
}
