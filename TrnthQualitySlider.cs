using UnityEngine;
using System.Collections;

public class TrnthQualitySlider : TrnthQuality {
	public UISlider slider;
	public void apply(){
		int index=(int)(slider.value*6);
		setQuality(index);
	}
	void OnEnable(){
		slider.value=QualitySettings.GetQualityLevel()/6f;
	}
}
