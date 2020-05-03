using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{
    public Transform aimTarget;
    public float intensity;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject ballObject = collision.gameObject;
        Vector3 dir = aimTarget.position - transform.position;
        if (ballObject.CompareTag("Ball"))
        {
            ballObject.GetComponent<Rigidbody>().velocity = dir.normalized * intensity + new Vector3(0, 1.5f, 0);
        }
    }

   
}
