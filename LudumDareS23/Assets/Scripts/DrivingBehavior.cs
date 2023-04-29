using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class DrivingBehavior : MonoBehaviour
{
    [SerializeField]PathCreator pathCreator;
    [SerializeField] float speed = 5;
    float distanceTravelled;
    [SerializeField] float startingLocation;
    void Start()
    {
        distanceTravelled = startingLocation;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += speed * Time.deltaTime; //* direction;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }
}
