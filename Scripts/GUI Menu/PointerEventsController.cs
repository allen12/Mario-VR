using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class PointerEventsController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (this.gameObject.name == "Start Game Button")
        {
            // this.gameObject.GetComponent...
            // ...OR...

            GameObject.Find("Start Game Button").GetComponent<Button>().onClick.RemoveAllListeners();
            GameObject.Find("Start Game Button").GetComponent<Button>().onClick.AddListener(TransitionLevel);
        }

        if (this.gameObject.name == "Quit Button")
        {
            this.gameObject.GetComponent<Button>().onClick.RemoveAllListeners();
            this.gameObject.GetComponent<Button>().onClick.AddListener(QuitGame);
        }
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    void TransitionLevel()
    {
        Application.LoadLevel(1);
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
