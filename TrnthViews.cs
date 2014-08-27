using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class TrnthViews : TrnthMonoBehaviour {
	public int width=640;
	public int height=1136;
	public Transform lookAt;
	[ContextMenu ("execute")]
	public void execute(){
		foreach(Transform e in transform){
			var widget=e.GetComponent<UIWidget>();
			if(!widget)continue;
			widget.SetDimensions(width,height);
			// var vec=widget.drawRegion;
			// vec.z=width;
			// vec.w=height;
			// widget.drawRegion=vec;
			// Debug.Log("ddd");
		}
	}
	[ContextMenu ("look")]
	public void look(){
		if(!lookAt)return;
		pos-=lookAt.position;
	}
}
