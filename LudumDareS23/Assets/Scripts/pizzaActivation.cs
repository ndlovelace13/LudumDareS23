using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pizzaActivation : MonoBehaviour
{
    public bool holdingPizza;
    public GameObject pizza;
    public double score;
    public int target;
    public double bonus;

    public GameObject arrow;
    public GameObject house1;
    public GameObject house2;
    public GameObject house3;
    public GameObject house4;
    public GameObject house5;

    public GameObject pep1;
    public GameObject pep2;
    public GameObject pep3;
    public GameObject pep4;

    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        holdingPizza = false;
        target = -1;
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

        if(target == -1){
            arrow.SetActive(false);
            bonus = 0;
        }

    }



    void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if(other.tag == "pepperoni"){
            bonus += 0.5;
            other.gameObject.SetActive(false);
        }
        if (other.tag == "pizzaShop")
        {
            if(!holdingPizza){
                holdingPizza = true;
                arrow.SetActive(true);
                target = Random.Range(1, 6);
                if(target != -1){
                    pep1.SetActive(true);
                    pep2.SetActive(true);
                    pep3.SetActive(true);
                    pep4.SetActive(true);
                }
                if(target == 1){
                    arrow.transform.position = house1.transform.position;
                }
                else if(target == 2){
                    arrow.transform.position = house2.transform.position;
                }
                else if(target ==3){
                    arrow.transform.position = house3.transform.position;
                }
                else if(target == 4){
                    arrow.transform.position = house4.transform.position;
                }
                else if(target == 5){
                    arrow.transform.position = house5.transform.position;
                    }
                }
            }
        
       if (other.tag == "House"){
            if(other.name == "house5" && target == 5){
                holdingPizza = false;
                score += (2.25 + bonus);
                scoreText.text = "Tips: $" + score;
                target = -1;
            }
            if(other.name == "house1" && target == 1){
                holdingPizza = false;
                score += (2.25 + bonus);
                scoreText.text = "Tips: $" + score;
                target = -1;
            }
            if(other.name == "house2" && target == 2){
                holdingPizza = false;
                score += (2.25 + bonus);
                scoreText.text = "Tips: $" + score;
                target = -1;
            }
            if(other.name == "house3" && target == 3){
                holdingPizza = false;
                score += (2.25 + bonus);
                scoreText.text = "Tips: $" + score;
                target = -1;
            }
            if(other.name == "house4" && target == 4){
                holdingPizza = false;
                score += (2.25 + bonus);
                scoreText.text = "Tips: $" + score;
                target = -1;
            }

        }
    }

}
