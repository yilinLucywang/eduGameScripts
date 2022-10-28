using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyButtonController : MonoBehaviour
{
	private bool p1Ready = false; 
	private bool p2Ready = false;

	public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(p1Ready == true && p2Ready == true){
        	canvas.GetComponent<SwapImages>().waitAndSwap();
        	p1Ready = false; 
        	p2Ready = false;
        }
    }


    void p1OnClick(){
    	p1Ready = true;
    }

    void p2OnClick(){
    	p2Ready = true;
    }
}
