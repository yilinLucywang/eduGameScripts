using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomButtonController : MonoBehaviour
{
	public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick(){
    	canvas.GetComponent<SwapImages>().swap();
    }
}
