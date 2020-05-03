using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public GameObject myBall;
    public GameObject myBot;
    GameObject ballObject;
    public GameObject spawnPoint;
    //public Transform aimTarget;
    public float intensity =3f;

    private Vector3 pos1;
    private Vector3 pos2;
    public float speed;
    public float horizontalDistance;
    // variable to check whether ball is in the scene or board or in play
    public bool isBallInPlay;

    //public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        //pos1 = new Vector3(-2, aimTarget.transform.position.y, aimTarget.transform.position.z);
        //pos2 = new Vector3(2, aimTarget.transform.position.y, aimTarget.transform.position.z);
        pos1 = new Vector3(-0.5f, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
        pos2 = new Vector3(4.5f, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
    }

    private void FixedUpdate()
    {
        //float h = Input.GetAxis("Horizontal");
        //spawnPoint.transform.position += Vector3.right * h * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!isBallInPlay)
        //{
        //    //MoveAimTarget();
        //}

        ////spawnPoint.transform.LookAt(aimTarget.transform.position);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    if(ballObject!=null)
        //        Destroy(ballObject);


        //    //ballObject = Instantiate(myBall, Camera.main.transform.position, Quaternion.identity) as GameObject;
        //    ballObject = Instantiate(myBall, spawnPoint.transform.position, Quaternion.identity) as GameObject;
        //    Debug.Log("New ball launched at " + ballObject.transform.position);

        //    ballObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * intensity, ForceMode.VelocityChange);
        //    //ballObject.GetComponent <Rigidbody>().AddForce(aimTarget.transform.position * intensity, ForceMode.Impulse);
        //    //StopTheAimTarget();


        //}

       

        //if (ballObject != null)
        //    myBot.transform.position = Vector3.MoveTowards(myBot.transform.position, new Vector3(ballObject.transform.position.x, myBot.transform.position.y, myBot.transform.position.z), 2f * Time.deltaTime);


        ////if (Input.GetMouseButtonDown(0))
        ////{

        ////    myBall.GetComponent<Rigidbody>().AddForce(Vector3.forward * 50f, ForceMode.Impulse);

        ////} 


    }

    private void MoveAimTarget()
    {
        spawnPoint.transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1f));
    }

    private void StopTheAimTarget()
    {
        speed = 0f;
        isBallInPlay = !isBallInPlay;

    }
}
