using UnityEngine;
using System.Collections;

public class TrnthRadioProgressbar : TrnthRadio {
	public UIProgressBar bar;
	public string uiProgressBar;
	// Update is called once per frame
	void Start(){
		if(!bar){
			var ggg=GameObject.Find(uiProgressBar);
			if(ggg)bar=ggg.GetComponent<UIProgressBar>();
		}
	}
	void Update () {
		if(bar)bar.value=rate;
	}
}
