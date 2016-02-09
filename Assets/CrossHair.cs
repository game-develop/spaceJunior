using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour {

    public Texture2D crosshairTexture;
    Rect position; 

	void Start () {
        Screen.showCursor = false; 
        position = new Rect((Screen.width - crosshairTexture.width) / 2, (Screen.height - crosshairTexture.height) / 2,
        crosshairTexture.width, crosshairTexture.height); 
	}

    void OnGUI()
    {
        GUI.DrawTexture(position, crosshairTexture);
    } 
}
