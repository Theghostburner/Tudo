using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_win : MonoBehaviour
{
	int count = 0;
	public GameObject B;
	public Button B1;
	public string sss;
    void Start()
    {
    	LaunchProjectile();
        InvokeRepeating("LaunchProjectile", 2.0f, 2f);
    }
    void makeActive( string a)
    {
    	B=GameObject.Find(a);
    	var colors = B.GetComponent<Button> ().colors;
        colors.normalColor = new Color32(72, 185, 243, 255);
        B.GetComponent<Button> ().colors = colors;
    }
    void makedeActive( string a)
    {
    	 B=GameObject.Find(a);
    	var colors = B.GetComponent<Button> ().colors;
        colors.normalColor = Color.white;
        B.GetComponent<Button> ().colors = colors;
    }

    void LaunchProjectile()
    {
    	// B=GameObject.Find("RestartButton");
    	// if( B!=null )  return;

    	if(count%2 == 0)
    	{
    		// Debug.Log("play");
    		sss = "RestartButton";
    		makeActive(sss);
    		makedeActive("MenuButton");
    		
    	}
    	else
    	{
    		// Debug.Log("exit");
    		sss = "MenuButton";
    		makedeActive("RestartButton");
    		makeActive(sss);

    	}

    	count++;
    	
    }
    void Clickit()
    {

    	// GameObject B11=GameObject.Find("ControlsImage");
    	B=GameObject.Find(sss);
    // 	if( B11!=null )  
    // 	{ 
    	
    // 	GameObject B111=GameObject.Find("CloseButton");
    // 	B111.GetComponent<Button> ().onClick.Invoke();
    // 	// yield return new WaitForSeconds(0.5f);
    // }
    // 	else 
    	{
    		B.GetComponent<Button> ().onClick.Invoke();
    	// Debug.Log("hmm");
    	}
    }
    void Update()
    {
    		  if (Input.GetKeyDown("space"))
    	    {
    	        Clickit();
    	    }
    }
}
