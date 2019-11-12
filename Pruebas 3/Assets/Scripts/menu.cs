using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour {
	// CAMPOS
	public Button btnMenu;
	GameObject tgSonido;
	GameObject tgLuz;
	GameObject dlLuz;
	GameObject mainCamera;
	GameObject sliderVolume;
	GameObject ddWeek;

	// Use this for initialization
	void Start () {
		// INSTANCIAMOS 
		// LUZ & SONIDO
		tgLuz = GameObject.Find("tgLuz");
		tgSonido = GameObject.Find("tgSonido");
		dlLuz = GameObject.Find("Directional Light");
		// CAMARA
		mainCamera = GameObject.Find("Main Camera");
		// VOLUMEN
		sliderVolume = GameObject.Find("slVolumen");
		// DROPDOWN
		ddWeek = GameObject.Find("ddWeek");
		ddWeek.GetComponent<Dropdown>().options.Clear();
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Lunes"));
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Martes"));
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Miércoles"));
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Jueves"));
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Viernes"));
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Sábado"));
		ddWeek.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Domingo"));
		ddWeek.GetComponent<Dropdown>().value = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape))
			Salir();
		// USO DE TOGGLE
		dlLuz.SetActive(tgLuz.GetComponent<Toggle>().isOn);
		if(tgSonido.GetComponent<Toggle>().isOn)
			mainCamera.GetComponent<Camera>().GetComponent<AudioSource>().UnPause();
		else 
		// CON 
			mainCamera.GetComponent<Camera>().GetComponent<AudioSource>().Pause();

		// USO DE SLIDER
		mainCamera.GetComponent<Camera>().GetComponent<AudioSource>().volume = sliderVolume.GetComponent<Slider>().value;	
	}


	// MENU
	// SALIR DEL PROGRAMA CON Application.Quit()
	public void Salir(){
		Application.Quit();
	}
	public void ShowMenu(){
		gameObject.SetActive((gameObject.active?false:true));
	}
	// CAMBIO DE ESCENA CON SceneManager.LoadScene
	public void ChangeScene1(){
		SceneManager.LoadScene("Escena_1");
	}

	public void ChangeScene2(){
		SceneManager.LoadScene("Escena_2");
	}
	
}
