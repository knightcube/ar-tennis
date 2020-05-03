using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeSpawner : MonoBehaviour
{
    public GameObject myCube;
    public int numberOfCubes = 10;
    // Start is called before the first frame update
    void Start()
    {
        CallCubes();
    }

    private void CallCubes()
    {
        int count = 0;
        //for (float i = 0; i < 10; i += 0.5f)
        //{

        //    for (float j = 0; j < 10; j++)
        //    {
        //        for (float k = 0; k < 20; k++)
        //        {
        //            Instantiate(myCube, new Vector3(j, i, k), Quaternion.identity);
        //            count++;
        //            Debug.Log("Number of Cubes = " + count);
        //        }
        //    }

        //}

        //float yPos = 0.0f;
        //for (float i = 0; i < 10; i++)
        //{

        //    for (float j = 0; j < 10; j++)
        //    {
        //        for (float k = 0; k < 20; k++)
        //        {
        //            Instantiate(myCube, new Vector3(j, yPos, k), Quaternion.identity);
        //            count++;
        //            Debug.Log("Number of Cubes = " + count);
        //            yPos += 0.5f;
        //        }
        //    }

        //}

        //for (float i = 0; i < 100; i+=0.5f)
        //{
        //    for (float j = 0; j < numberOfCubes; j++)
        //    {
        //        Instantiate(myCube, new Vector3(j, i, 0), Quaternion.identity);
        //        count++;
        //        Debug.Log("Number of Cubes = " + count);
        //    }
        //}

        //for (float i = 0; i < 100; i += 0.5f)
        //{
        //    for (float j = 0; j < numberOfCubes; j++)
        //    {
        //        Instantiate(myCube, new Vector3(0, i, j), Quaternion.identity);
        //        count++;
        //        Debug.Log("Number of Cubes = " + count);
        //    }
        //}

        for (float i = 0; i < numberOfCubes; i++)
        {

            int x = Random.Range(-5, 5);
            int z = Random.Range(-5, 5);
            Instantiate(myCube, new Vector3(x, i, z), Quaternion.identity);
            count++;
            Debug.Log("Number of Cubes = " + count);
           
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
