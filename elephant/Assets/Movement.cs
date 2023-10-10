using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int variable=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey("d"))
       { 
        GetComponent<Transform>().position=new Vector3((float)-0.43,(float)0.70,1);
        }
        if (Input.GetKey("f"))
       { 
        GetComponent<Transform>().position=new Vector3((float)-0.43,(float)0.70,2);
        }
        if (Input.GetKey("g"))
       { 
        GetComponent<Transform>().position=new Vector3((float)-0.43,(float)0.70,3);
        }
        if (Input.GetKey("h"))
       { 
        GetComponent<Transform>().position=new Vector3((float)-0.43,(float)0.70,4);
        }
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Movement : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         new Vector3() vec=gameObject<Transform>().position;
//         if (Input.KeyDown("d"))
//         {Debug.Log(vec);}
//     }
// }
