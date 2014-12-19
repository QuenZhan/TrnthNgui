using UnityEngine;
using System.Collections;

public class TrnthRadioNguiProgressbar : TrnthRadio {
	public UIProgressBar bar;
	public string uiProgressBar;
	public void find(){
		if(!bar){
			var ggg=GameObject.Find(uiProgressBar);
			if(ggg)bar=ggg.GetComponent<UIProgressBar>();
		}
	}
	// Update is called once per frame
	void Start(){
		find();
	}
	void Update () {
		if(bar)bar.value=rate;
	}
}
