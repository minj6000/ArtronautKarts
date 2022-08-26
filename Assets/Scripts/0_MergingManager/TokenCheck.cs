using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TokenCheck : ScriptableObject
{

    [SerializeField]
    private bool introFinish;

    public bool _introFinish
    {
        get { return introFinish; }
        set { introFinish = value; }
    }

    [SerializeField]
    private bool TheaterToken;

    public bool _TheaterToken
    {
        get { return TheaterToken; }
        set { TheaterToken = value; }
    }


}
