using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSubtractController : MonoBehaviour
{
	private int userScore = 0; 
	private int setScore = 5;

	public int successIndex; 
	public int failureIndex;
	public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void addOnClick(){
    	userScore = userScore + 1;
    }

    void subtractOnClick(){
    	userScore = userScore - 1;
    }


    void submitObClick(){
    	if(userScore == setScore){
    		canvas.GetComponent<SwapImages>().swapToPage(successIndex);
    	}
    	else{
    		canvas.GetComponent<SwapImages>().swapToPage(failureIndex);
    	}
    }
}
