using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailScript : MonoBehaviour
{
    public Vector3 head;
    [SerializeField] float speed = 5f;
    [SerializeField] float rotation_damping = 4f;
    [SerializeField] float rotation_Speed = 80f;

    [SerializeField] Transform HeadOBJ;
    // Start is called before the first frame update
    void Start()
    {
        rotation_Speed = Random.Range(20, 100);
        GameObject[] HeadOBJs = GameObject.FindGameObjectsWithTag("head");
        int Chosenobj = Random.Range(0, HeadOBJs.Length);
        HeadOBJ = HeadOBJs[Chosenobj].GetComponent<Transform>();
        //HeadOBJ = GameObject.FindGameObjectWithTag("head").GetComponent<Transform> ();
    }

    // Update is called once per frame
    void Update()
    {
        head = new Vector3(HeadOBJ.transform.position.x, HeadOBJ.transform.position.y + 8, HeadOBJ.transform.position.z);
        var rotation = Quaternion.LookRotation(HeadOBJ.transform.position - transform.position);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotation_damping);

        this.transform.position = Vector3.MoveTowards(transform.position, head, speed * Time.deltaTime);
        transform.RotateAround(HeadOBJ.transform.position, new Vector3(0,1,0), rotation_Speed * Time.deltaTime);
    }
}
