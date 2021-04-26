using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using WindowsInput;

public class control_change : MonoBehaviour
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

    	var colors = B.GetComponent<Image> ().color;
        colors = new Color32(255, 255, 255, 200);
        B.GetComponent<Image> ().color = colors;
    }
    void makedeActive( string a)
    {
    	 B=GameObject.Find(a);

	   	var colors = B.GetComponent<Image> ().color;
        colors = new Color32(255, 255, 255, 45);
        B.GetComponent<Image> ().color = colors;    }

    void LaunchProjectile()
    {
    	// B=GameObject.Find("RestartButton");
    	// if( B!=null )  return;

    	if(count%3 == 0)
    	{
    		// Debug.Log("play");
    		sss = "left";
    		makeActive(sss);
    		makedeActive("right");
    		makedeActive("forward");
    		
    	}
    	else if( count%3 == 1 )
    	{

    		sss = "forward";
    		makeActive(sss);
    		makedeActive("left");
    		makedeActive("right");
    	}
    	else
    	{
    		sss = "right";
    		makeActive(sss);
    		makedeActive("left");
    		makedeActive("forward");

    	}

    	count++;
    	
    }
    void Clickit()
    {

    	// GameObject B11=GameObject.Find("ControlsImage");
    	// B=GameObject.Find(sss);
    	
    	if(sss == "forward")
    		{  
    			// InputSimulator.SimulateKeyPress(VirtualKeyCode.FORWARD);
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
