using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityStandardAssets.ImageEffects;
using System.Collections.Generic;
using System.Linq;

public class TiltViewModel : MonoBehaviour {
	private readonly String soberLevel ="Sober";
	private readonly String intoxicatedLevel = "Slightly intoxicated";
	private readonly String drunkLevel = "Drunk";
	private readonly string veryDrunkLevel = "Very drunk";

	public void setTiltShiftSize(float newValue) {
		this.setBlurAreaText (newValue);
		this.setDrunkLevelText(newValue);
		this.setTiltShiftAreaSizeValue (newValue);
	}
		
	private void setBlurAreaText(float value) {
		Text blurValueText = GameObject.Find ("SliderValueText").GetComponent<Text> ();
		blurValueText.text = value.ToString();
	}
	private void setTiltShiftAreaSizeValue(float newValue) {
		AlcoholTiltShift cameraLeft = GameObject.Find ("StereoCameraLeft").GetComponent<AlcoholTiltShift> ();
		cameraLeft.blurArea= newValue;
		AlcoholTiltShift cameraRight = GameObject.Find ("StereoCameraRight").GetComponent<AlcoholTiltShift> ();
		cameraRight.blurArea = newValue;
	}

	private void setDrunkLevelText(float newValue) {
		Text selectedAlcoholLevelText = GameObject.Find ("SelectedAlcoholLevelText").GetComponent<Text> ();
		var myswitch = new Dictionary <Func<float,bool>, Action>{ 
			{ x => x < 4 ,    () => selectedAlcoholLevelText.text = this.soberLevel}, 
			{ x => x < 8 ,    () => selectedAlcoholLevelText.text = this.intoxicatedLevel},
			{ x => x < 12,    () =>  selectedAlcoholLevelText.text = this.drunkLevel },
			{ x => x < 15 ,   () => selectedAlcoholLevelText.text = this.veryDrunkLevel}  
		};
		myswitch.First(sw => sw.Key(newValue)).Value();
	}
}

