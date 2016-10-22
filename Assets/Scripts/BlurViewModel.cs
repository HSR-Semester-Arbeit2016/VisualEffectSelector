using UnityEngine;
using UnityEngine.UI;
using System;
using UnityStandardAssets.ImageEffects;

public class BlurViewModel : MonoBehaviour {
	private readonly String soberLevel ="Sober";
	private readonly String intoxicatedLevel = "Slightly intoxicated";
	private readonly String drunkLevel = "Drunk";
	private readonly string veryDrunkLevel = "Very drunk";

	public void setBlurSize(float newValue) {
		this.setBlurSizeText (newValue);
		this.setDrunkLevelText(newValue);
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

	private void setDrunkLevelText(float newValue) {
		Text blurValueText = GameObject.Find ("SelectedAlcoholLevelText").GetComponent<Text> ();
		String value = newValue.ToString();
		switch (value)
		{
		case "0":
			blurValueText.text = this.soberLevel;
			break;
		case "1":
			blurValueText.text = this.intoxicatedLevel;
			break;
		case "2":
			blurValueText.text = this.drunkLevel;
			break;
		case "3":
			blurValueText.text = this.veryDrunkLevel;
			break;
		case "4":
			blurValueText.text = this.veryDrunkLevel;
			break;
		default:
			blurValueText.text = this.soberLevel;
			break;
		
		}
	}
}