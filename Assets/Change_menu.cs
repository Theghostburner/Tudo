using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Change_menu : MonoBehaviour
{
	int count = 0;
	public GameObject B;
	public Button B1;
	public string sss;
	public int x = 1;
    void Start()
    {
    	LaunchProjectile();
        InvokeRepeating("LaunchProjectile", 2.0f, 2f);
    }
    void makeActive( string a)
    {
    	B=GameObject.Find(a);
    	if(B!=null)
    	{
    	var colors = B.GetComponent<Button> ().colors;
        colors.normalColor = new Color32(72, 185, 243, 255);
        B.GetComponent<Button> ().colors = colors;
 	   }
	}
    void makedeActive( string a)
    {
    	 B=GameObject.Find(a);
    	 if(B!=null)
    	 {
    	var colors = B.GetComponent<Button> ().colors;
        colors.normalColor = Color.white;
        B.GetComponent<Button> ().colors = colors;
    	}
	}
    void LaunchProjectile()
    {
    	// B=GameObject.Find("Controlsimage");
    	// if( B!=null )  return;
    	if(x==1)
    	{
    	if(count%4 == 0)
    	{
    		// Debug.Log("play");
    		sss = "inst";
    		makeActive(sss);
    		makedeActive("ControlsButton");
    		makedeActive("StartButton");
    		makedeActive("exit");
    	}
    	else if(count%4 == 1)
    	{
    		// Debug.Log("play");
    		sss = "ControlsButton";
    		makeActive(sss);	
    		makedeActive("StartButton");
    		makedeActive("inst");
    		makedeActive("exit");
    	}
    	else if(count%4 == 2)
    	{
    		// Debug.Log("play");
    		sss = "StartButton";
    		makeActive(sss);
    		makedeActive("ControlsButton");
    		makedeActive("inst");
    		makedeActive("exit");
    		
    	}
    	
    	else
    	{
    		// Debug.Log("exit");
    		sss = "exit";
    		makeActive(sss);
    		makedeActive("StartButton");
    		makedeActive("ControlsButton");
    		makedeActive("inst");

    	}

    	count++;
    	}
    	else
    	{
    		return;
    	}
    	
    }
    void Clickit()
    {


		if(x==1)
		{
		x =0;
		B=GameObject.Find(sss);
		B.GetComponent<Button> ().onClick.Invoke();
		
    	print("1");
		}
		else
		{

  //   	GameObject B11=GameObject.Find(sss);

		// if(B11==null)
		// {
		GameObject B111=GameObject.Find("CloseButton");
		if(B111!=null)
    	B111.GetComponent<Button> ().onClick.Invoke();
    	x = 1;
    	print("0");
    	// }

		}
    }
    void Update()
    {
    		  if (Input.GetKey(KeyCode.Mouse0))
    	    {
    	        Clickit();
    	    }
    }
}
