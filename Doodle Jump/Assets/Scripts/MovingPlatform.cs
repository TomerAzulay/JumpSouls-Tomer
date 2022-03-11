using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform player;
    public Vector3 playerTransform;
    public Vector3 position1 = new Vector3(-2.85f, 0, 0);
    public float speed;
    public Vector3 position2 = new Vector3(2.85f, 0, 0);

    Vector3 currentTargetDestination;
    public float distanceTolerance = 0.5f;

    void Start()
    {
        //set the initial position
        transform.position = position1;
        currentTargetDestination = position2;
        position1 =  new Vector3(2.85f,player.transform.position.y,transform.position.z);
        position2 = new Vector3(-2.85f, player.transform.position.y, transform.position.z);
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTargetDestination, 2 * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentTargetDestination) <= distanceTolerance)
        {
            //once we reach the current destination, set the other location as our new destination
            if (currentTargetDestination == position1)
            {
                currentTargetDestination = position2;
            }
            else
            {
                currentTargetDestination = position1;
            }
        }
        }
}
