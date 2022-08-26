using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RotationSpeedAdjust : MonoBehaviour
{
    [SerializeField] Texture tex;
    [SerializeField] GameObject skybox;
    public GameObject[] rotateAround;
    public SpaceRockMovement SelfRotation;
    [SerializeField] AudioSource[] TalAu;
    [SerializeField] AudioSource AuToPlay;
    [SerializeField] AudioSource VoiceToPlay;
    [SerializeField] float rotateAroundSpeed;
    [SerializeField] float SelfrotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotateAround = GameObject.FindGameObjectsWithTag("RotateAroundPlanet");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick()
    {
        skybox.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", tex);
        transform.DORotate(new Vector3(0, 2, 360), 1, RotateMode.FastBeyond360);
        foreach (AudioSource au in TalAu)
        {
            au.DOFade(0, 5f);
        }
        AuToPlay.Play();
        AuToPlay.DOFade(1, 5f);
        VoiceToPlay.Play();
        foreach (GameObject p in rotateAround)
        {
            if (p.GetComponent<PlanetRotateMovement>() != null)
            {
                p.GetComponent<PlanetRotateMovement>().rotateSpeed = rotateAroundSpeed;
            }
        }
        SelfRotation.speed = SelfrotationSpeed;
    }
}
