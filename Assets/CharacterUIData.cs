using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUIData : MonoBehaviour {


    public delegate void OnClicked(GameObject obj);
   public event OnClicked OnClick;
    public GameObject Parent;
    
    // Use this for initialization
	void Start () {
        gameObject.GetComponent<Button>().onClick.AddListener(ClickFunction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void ClickFunction()
    {
        OnClick(Parent);
    }
}
