using UnityEngine;
using System.Collections;

public class FolowCamera : MonoBehaviour {

	float vertical;
	float horizontal;
	float verticalMouse;
	float horizontalMouse;

	public Camera mainCamera;
	public GameObject viever;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Vertical")>0||Input.GetAxis("Vertical")<0)
			{
			vertical += Input.GetAxis ("Vertical");
			mainCamera.transform.position =new Vector3(mainCamera.transform.position.x,
				mainCamera.transform.position.y,
				vertical);
			viever.transform.position =new Vector3(viever.transform.position.x,
				viever.transform.position.y,
				vertical);
			}
		if(Input.GetAxis("Horizontal")>0||Input.GetAxis("Horizontal")<0)
		{
			horizontal += Input.GetAxis ("Horizontal");
			mainCamera.transform.position =new Vector3(horizontal,
				mainCamera.transform.position.y,
				mainCamera.transform.position.z);
			viever.transform.position =new Vector3(horizontal,
				viever.transform.position.y,
				viever.transform.position.z);
		}
//		if(Input.GetAxis("Mouse X")>0||Input.GetAxis("Mouse X")<0)
//		{
//			verticalMouse += Input.GetAxis ("Mouse X");
//			mainCamera.transform.rotation =new Quaternion(mainCamera.transform.position.x,
//				mainCamera.transform.position.y,
//				vertical,100);
//		}
//		if(Input.GetAxis("Mouse Y")>0||Input.GetAxis("Mouse Y")<0)
//		{
//			horizontalMouse += Input.GetAxis ("Mouse Y");
//			mainCamera.transform.rotation =new Quaternion(horizontal,
//				mainCamera.transform.position.y,
//				mainCamera.transform.position.z,100);
//		}
	}
}
