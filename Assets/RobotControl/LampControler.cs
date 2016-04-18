using UnityEngine;
using System.Collections;

public class LampControler : MonoBehaviour {
	private GameObject directionLamp;
	private bool connected;
	private bool reversedDrive;

	private string smartDashTable = "/SmartDashboard/";

	
	// Use this for initialization
	void Start () {
		Debug.Log("Lamp Controler Active");
		directionLamp = GameObject.Find ("/Screen_Pos/Lamps/DirectionLamp");

	}
	
	// Update is called once per frame
	void Update () {
		if (NetworkTables.Instance.connected) {
			connected = true;
			NetworkTables.Instance.GetBool (smartDashTable+"Drive/backCamera", out reversedDrive);
		} else {
			connected = false;
		}

		if (connected) {
			if(reversedDrive){
				directionLamp.GetComponent<Renderer>().material.color = Color.red;
			}else{
				directionLamp.GetComponent<Renderer>().material.color = Color.green;
			}
		} else {
			directionLamp.GetComponent<Renderer>().material.color = Color.gray;
		}
	}
}
