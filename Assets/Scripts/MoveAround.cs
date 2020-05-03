using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 pos2;
    private float speed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(-2,transform.position.y,transform.position.z);
        pos2 = new Vector3(2,transform.position.y,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1f));
    }
}
