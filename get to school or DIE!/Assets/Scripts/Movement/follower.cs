using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{

    [SerializeField] Transform[] Waypoints;
    int CurrentWaypointIndex = 0;




    [SerializeField] float speed = 1f;



    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        var delta = (Waypoints[CurrentWaypointIndex].position - transform.position);
        if ( delta.magnitude < 0.1f)
        {
            CurrentWaypointIndex = (CurrentWaypointIndex + 1) % Waypoints.Length;
        }
        transform.position += delta.normalized * speed * Time.deltaTime;

        
    }
}
