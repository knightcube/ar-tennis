using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlaceBotController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Instantiates this prefab on a plane at the touch location.")]
    GameObject m_PlacedPrefab;

    /// <summary>
    /// The prefab to instantiate on touch.
    /// </summary>
    public GameObject placedPrefab
    {
        get { return m_PlacedPrefab; }
        set { m_PlacedPrefab = value; }
    }

    /// <summary>
    /// The object instantiated as a result of a successful raycast intersection with a plane.
    /// </summary>
    public GameObject spawnedObject { get; private set; }
    public GameObject myBall;
    GameObject ballObject;
    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    ARRaycastManager m_RaycastManager;

    void Awake()
    {
        m_RaycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
 
        if (m_RaycastManager.Raycast(Input.GetTouch(0).position, s_Hits, TrackableType.PlaneWithinPolygon))
        {
            // Raycast hits are sorted by distance, so the first one
            // will be the closest hit.
            var hitPose = s_Hits[0].pose;

            if (spawnedObject == null)
            {
                spawnedObject = Instantiate(m_PlacedPrefab, hitPose.position, hitPose.rotation);
            }
            else
            {
                //spawnedObject.transform.position = hitPose.position;
                //Vector3.MoveTowards(spawnedObject.transform.position, hitPose.position, 2f*Time.deltaTime);
            }
        }

        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                if (raycastHit.collider.CompareTag("Bot"))
                {
                    raycastHit.collider.GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    spawnedObject.GetComponent<Renderer>().material.color = Color.green;
                }

            }
            if (GameObject.FindGameObjectWithTag("Ball") == null)
            {
                ballObject = Instantiate(myBall, Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position), Quaternion.identity) as GameObject;

                ballObject.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 10f, ForceMode.Impulse);


            }
            
        }

        //if(ballObject != null)
        //{
        //    spawnedObject.transform.position = Vector3.MoveTowards(spawnedObject.transform.position, new Vector3(ballObject.transform.position.x, spawnedObject.transform.position.y, spawnedObject.transform.position.z), 10f * Time.deltaTime);
        //    Destroy(ballObject, 1.0f);

        //}

    }

}