using UnityEngine;
using System.Collections;

public class TargetControler : MonoBehaviour {
	private GameObject[] targetComponents = new GameObject[3];
	private GameObject target;

	private Vector3 initalPos;

	private string smartDashTable = "/SmartDashboard/";

	// Use this for initialization
	void Start () {
		Debug.Log ("TargetControler Active");

		target = GameObject.Find ("Target");

		targetComponents [0] = GameObject.Find ("Target/Bottom");
		targetComponents [1] = GameObject.Find ("Target/Right");
		targetComponents [2] = GameObject.Find ("Target/Left");

		initalPos = target.transform.localPosition;

		NetworkTables.Instance.AddListener (smartDashTable + "/components/autoaim/target_angle", setTargetAngle);
		NetworkTables.Instance.AddListener(smartDashTable+"/components/autoaim/present", setPresent);
	}

	public void setTargetAngle(){
		double targetAngle;
		NetworkTables.Instance.GetNumber(smartDashTable+"/components/autoaim/target_angle", out targetAngle);

		targetAngle /= 10;

		if (Mathf.Abs (targetAngle) < 3) {
			changeColor (Color.green);
		} else {
			changeColor (Color.yellow);
		}

		target.transform.localPosition.x = initalPos.x + targetAngle;
	}

	public void setPresent(){
		bool present;
		NetworkTables.Instance.GetBool (smartDashTable + "/components/autoaim/present", out present);

		if (present) {
			target.transform.localPosition.z = initalPos.z + 3;
		} else {
			target.transform.localPosition.z = initalPos.z;
		}
	}

	private void changeColor(Color color){
		for (int i = 0; i < targetComponents.Length; i++) {
			Renderer rend = targetComponents [i].GetComponent<Renderer>;
			rend.material.color = color;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
