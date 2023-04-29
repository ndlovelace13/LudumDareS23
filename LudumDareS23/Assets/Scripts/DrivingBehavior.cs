using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class DrivingBehavior : MonoBehaviour
{
    [SerializeField]PathCreator pathCreator;
    [SerializeField] float speed = 5;
    [SerializeField] float startingLocation;
    float distanceTravelled;
    // Start is called before the first frame update
    void Start()
    {
        distanceTravelled = startingLocation;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
