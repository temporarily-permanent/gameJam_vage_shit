using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFish : MonoBehaviour
{

    public GameObject Fish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Fish.transform.position;
        transform.position = Fish.transform.position + new Vector3(0, 2, -15);
    }
}
