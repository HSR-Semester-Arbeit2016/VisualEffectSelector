using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class BlurViewModel : MonoBehaviour {
	
	public void setBlurSize(float newValue) {
		this.setBlurSizeText (newValue);
		this.setBlurSizeValue (newValue);
	}

	private void setBlurSizeText(float value) {
		Text blurValueText = GameObject.Find ("SliderValueText").GetComponent<Text> ();
		blurValueText.text = value.ToString();
	}

	private void setBlurSizeValue(float newValue) {
		BlurOptimized cameraLeftBlur = GameObject.Find ("StereoCameraLeft").GetComponent<BlurOptimized> ();
		cameraLeftBlur.blurSize = newValue;
		BlurOptimized cameraRightBlur = GameObject.Find ("StereoCameraRight").GetComponent<BlurOptimized> ();
		cameraRightBlur.blurSize = newValue;
   }
}