using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrnthUiTextureNetwork : MonoBehaviour {
    static public Dictionary<string,Texture> cache=new Dictionary<string,Texture>();
	public UITexture uitex;
	public Texture2D texLoading;
    public bool cacheUsing=true;
	public void texWithUrl(string url){
		this.url=url;
        has=false;
        if(cacheUsing&&cache.ContainsKey(url)){
            uitex.mainTexture=cache[url];
            has=true;
        }else if(gameObject.activeInHierarchy)StartCoroutine(textureWithUrl(url));
	}
	string url;
	bool has=false;
	IEnumerator textureWithUrl(string url) {
        WWW www = new WWW(url);
        if(texLoading)uitex.mainTexture=texLoading;

        yield return www;
        
        if(www.error!=null){
        	// Debug.Log(www.error);
        }
        else  {
            uitex.mainTexture = www.texture;
            cache[url]=www.texture;
        }
        has=true;
    }
    void OnEnable(){
    	if(!has)StartCoroutine(textureWithUrl(url));
    }
}
