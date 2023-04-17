using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinText : GameManager 

{

	public TextMeshProUGUI  coinsText;

	void Update()
	{
	if (coinsText != null) {coinsText.text = "" + coins.ToString();}
	}
}