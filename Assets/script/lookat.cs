using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lookat : MonoBehaviour
{
    // target that the camera should look at
    static public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {target = this.gameObject;
        Debug.Log(" Look at target target not specified. Defaulting to the parent GameObject");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target){
            transform.LookAt(target.transform);
        }
    }
}

