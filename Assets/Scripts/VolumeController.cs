using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class VolumeController : MonoBehaviour {

	public Slider volumeSlider;
	public Text volumeText;
	private static VolumeController instance;
	private float masterVolume;
	// Use this for initialization
	void Start () {

		if (instance == null) {
			instance = new VolumeController ();
		}
		if (!PlayerPrefs.HasKey ("MasterVolume")) {
			PlayerPrefs.SetFloat ("MasterVolume", 1);
			volumeSlider.value = 1f;
			volumeText.text = "Volume: 100%";
		} else {
			volumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
			volumeText.text = "Volume: " + (int) (volumeSlider.value * 100) + " %";
		}
	}
	public static VolumeController GetInstance() {
		if (instance == null) {
			instance = new VolumeController ();
		}
		return instance;
	}
	private VolumeController() {
	}
	public void SetMasterVolume(float volume) {
		PlayerPrefs.SetFloat ("MasterVolume",volume);
		volumeSlider.value = volume;
		volumeText.text = "Volume: " +  (int) (volume * 100) + "%";
	}

	public float GetMasterVolume() {
		return PlayerPrefs.GetFloat ("MasterVolume");
	}


	public void VolumeUpdated() {
		SetMasterVolume (volumeSlider.value);
		volumeText.text = "Volume: " + (int) (volumeSlider.value * 100) + " %";
	}
	// Update is called once per frame
	void Update () {

	}

}
