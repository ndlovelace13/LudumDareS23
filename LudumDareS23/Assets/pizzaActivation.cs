using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaActivation : MonoBehaviour
{
    public bool holdingPizza;
    public GameObject pizza;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        holdingPizza = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(holdingPizza){
            pizza.SetActive(true);
        }
        else{
            pizza.SetActive(false);
        }

    }



    void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "pizzaShop")
        {
            if(!holdingPizza){
                holdingPizza = true;
            }
        }
       if (other.tag == "House"){
            holdingPizza = false;
        }
    }

}
