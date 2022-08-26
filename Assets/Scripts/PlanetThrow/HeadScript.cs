using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadScript : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] float rotation_damping = 4f;
    [SerializeField] Camera ARcamera;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.3f, 0.8f);
        ARcamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var rotation = Quaternion.LookRotation(ARcamera.transform.position - transform.position);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotation_damping);

        this.transform.position = transform.position + direction * speed * Time.deltaTime;

    }
}
