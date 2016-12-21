using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintText : MonoBehaviour {

    private Text sourceText;
    private List<char> charList;
    private int index;
    private string phrase;

    public float speed;

	void Start () {


        sourceText = GetComponent<Text>();
        charList = new List<char>();
        foreach (char c in sourceText.text)
        {
            charList.Add(c);
           
        }
       
        index = 0;
        sourceText.text = null;
        Print();
	}
	
	private void Print()
    {
        if(index != charList.Count)
        {
            phrase = sourceText.text;

            sourceText.text = phrase.Insert(index, charList[index].ToString());
            index++;
            Invoke("Print", speed * Time.deltaTime);
        }
        else
        {
            Destroy(this);
        }
    }
}
