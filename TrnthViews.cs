using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class TrnthViews : TrnthMonoBehaviour {
	public int width;
	public int height;
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
}
