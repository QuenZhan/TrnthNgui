using UnityEngine;
using System.Collections;

public class TrnthUiTextureNetwork : MonoBehaviour {
	public UITexture uitex;
	public bool has=false;
	public string url;
	public void texWithUrl(string url){
		this.url=url;
		if(gameObject.activeInHierarchy)StartCoroutine(textureWithUrl(url));
		else has=false;
	}
	IEnumerator textureWithUrl(string url) {
        WWW www = new WWW(url);
        yield return www;
        
        if(www.error!=null)Debug.Log(www.error);
        else  uitex.mainTexture = www.texture;
        has=true;
    }
    void OnEnable(){
    	if(!has)StartCoroutine(textureWithUrl(url));
    }
}
