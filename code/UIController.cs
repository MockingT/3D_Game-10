
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController {
    public Text centerText;
	public void loseGame()
    {
        centerText.text = "LOSE!";
    }
    public void resetGame()
    {
        centerText.text = "";
    }
}
