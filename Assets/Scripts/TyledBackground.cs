using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyledBackground : MonoBehaviour {
	// will only work with power of 2
	public int textureSize = 32;
	public bool scaleHorizontally = true;
	public bool scaleVertically = false;
	void Start () {
		var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil (Screen.width / (textureSize * PixelPerfectCam.scale));
		var newHeight = !scaleVertically ? 1 : Mathf.Ceil (Screen.height / (textureSize * PixelPerfectCam.scale));

		transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);
		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
	}
}
