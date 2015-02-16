using UnityEngine;
using System.Collections;

public class TrnthConstraintNguiPosition : TrnthConstraint {
	public Transform alignTo;
	// public Camera mainCamera;
	public override void update(){
		base.update();
		if(!alignTo){
			// Destroy(this);
			enabled=false;
			return;
		}
		var coor=Camera.main.WorldToScreenPoint(alignTo.position);
		target.localPosition=new Vector3(coor.x-Screen.width*0.5f,coor.y-Screen.height*0.5f,0);
	}
}
