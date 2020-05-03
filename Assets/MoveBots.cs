using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBots : MonoBehaviour
{

    private Vector3 pos1;
    private Vector3 pos2;

    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = new Vector3(-1f, transform.position.y, transform.position.z);
        pos2 = new Vector3(1f, transform.position.y, transform.position.z);
        //botPos1 = new Vector3(enemybot.transform.position.x, enemybot.transform.position.y, enemybot.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1f));

    }
}
