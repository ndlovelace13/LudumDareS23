using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class parentText : MonoBehaviour
{
    public TMP_Text parent;
     public TMP_Text self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        self.text = parent.text;
    }
}
