using System.Collections.Generic;
using UnityEngine;

public class HQ : MonoBehaviour, IModel {

    private ButtonFunctions bf;


    void Start() {
        DontDestroyOnLoad(gameObject);
        bf = GetComponent<ButtonFunctions>();
    }

    public List<IView> listeners
    {
        get
        {
            return listeners;
        }

        set
        {
            listeners = value;
        }
    }

    public void RegisterListener(IView listener)
    {
        listeners.Add(listener);
    }
    public ButtonFunctions BF {get{return bf;} set{bf = value;}}
}
