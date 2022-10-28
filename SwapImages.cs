using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapImages : MonoBehaviour
{
	private RawImage m_RawImage;
	private int currentIndex = 0;
	public List<Texture> textures = new List<Texture>();

	private IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        m_RawImage = GetComponent<RawImage>();
    }

    public void swap(){
    	currentIndex = currentIndex + 1;
    	Texture curTexture = textures[currentIndex];
    	m_RawImage.texture = curTexture;
    }

	public void waitAndSwap() 
	{
	    StartCoroutine(waitSwapPrivate());
	} 

    IEnumerator waitSwapPrivate()
    {
        yield return new WaitForSeconds(1.0F);
        swap();
    }

    public void swapToPage(int index){
    	Texture curTexture = textures[index];
    	m_RawImage.texture = curTexture;
    }
}
