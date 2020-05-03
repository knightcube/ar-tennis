using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject myBall;
    GameObject ballObject;
    public GameObject spawnPoint;
    //public Transform aimTarget;
    public float intensity = 3f;

    public Transform aimTarget;
    public float speed;
    public GameObject myBot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        spawnPoint.transform.position += Vector3.right * h * speed;
    }

    // Update is called once per frames
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ballObject != null)
                Destroy(ballObject);


            //ballObject = Instantiate(myBall, Camera.main.transform.position, Quaternion.identity) as GameObject;
            ballObject = Instantiate(myBall, spawnPoint.transform.position, Quaternion.identity) as GameObject;
            Debug.Log("New ball launched at " + ballObject.transform.position);

            ballObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * intensity, ForceMode.VelocityChange);
            //ballObject.GetComponent <Rigidbody>().AddForce(aimTarget.transform.position * intensity, ForceMode.Impulse);
            //StopTheAimTarget();

        }

        if (ballObject != null)
            myBot.transform.position = Vector3.MoveTowards(myBot.transform.position, new Vector3(ballObject.transform.position.x, myBot.transform.position.y, myBot.transform.position.z), 2f * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject ballObject = collision.gameObject;
        Vector3 dir = aimTarget.position - transform.position;
        if (ballObject.CompareTag("Ball"))
        {
            ballObject.GetComponent<Rigidbody>().velocity = dir.normalized * intensity + new Vector3(0,1.5f,0);
        }
        float randx = Random.Range(-1.0f,1.0f);
        spawnPoint.transform.position =Vector3.MoveTowards(spawnPoint.transform.position, new Vector3(randx,spawnPoint.transform.position.y,spawnPoint.transform.position.z),1.5f);
    }
}
