using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Descentify : MonoBehaviour {

	public Animator Anime;
	public float MyTime = 0f;
	public Transform RadialProgress;

	void Start ()
	{
		Anime = GetComponent<Animator>();
		RadialProgress.GetComponent<Image>().fillAmount = MyTime;
	}

	public void Update()
	{
		MyTime += Time.deltaTime;

		RadialProgress.GetComponent<Image>().fillAmount = MyTime/3;

		if (MyTime >=3f)
		{
			changeSpot ();
		}
	}

	public void Resetinator()
	{
		MyTime = 0f;
		RadialProgress.GetComponent<Image>().fillAmount = MyTime;
	}

	public void changeSpot()
	{
	 Anime.Play("Descentify");
		
	}
}
