using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenClicked : MonoBehaviour
{
    public GameObject Token;
    public GameManager_GrowingTree gameManager;
    float position;
    // Start is called before the first frame update
    void Start()
    {
        position = Random.Range(5, 8);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onclick()
    {
        Token.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
