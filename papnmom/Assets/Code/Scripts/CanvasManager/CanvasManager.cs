using System.Collections.Generic; //Author: Axel S. Stenkrona
using UnityEngine;

public class CanvasManager : MonoBehaviour {

    private GameObject splashScreen;
    private GameObject mainMenu;
    private Dictionary<string, GameObject> panels;
    private Dictionary<string, GameObject> mainMenuLayers;
    private Dictionary<string, GameObject> stepTwoLayers;


    public bool debugLog;
   
    void Awake() {
        if (debugLog) Debug.Log("CanvasManager Start");

        PanelLayersSetup();
        MM_LayersSetup();

        if (debugLog) Debug.Log("CanvasManager Start Done!");
    }

    public void SetActivePanel(string s)
    {
        if (debugLog) Debug.Log("Running SetActivePanel");

        foreach(KeyValuePair<string,GameObject> go in panels)
        {
            go.Value.SetActive(false);
        }
        panels[s].SetActive(true);

        if (debugLog) Debug.Log("SetActivePanel Done!");
    }
    public void SetActiveMainMenuLayer(string s)
    {
        if (debugLog) Debug.Log("Running SetActiveMainMenuLayer");

        foreach (KeyValuePair<string, GameObject> go in mainMenuLayers)
        {
            go.Value.SetActive(false);
        }
        mainMenuLayers[s].SetActive(true);

        if (debugLog) Debug.Log("SetActiveMainMenuLayer Done!");
    }
    public void SetStepTwoLayers(string s)
    {
        if (debugLog) Debug.Log("Running SetStepTwoLayers...");

        foreach (KeyValuePair<string, GameObject> go in mainMenuLayers)
        {
            go.Value.SetActive(false);
        }
        mainMenuLayers[s].SetActive(true);

        if (debugLog) Debug.Log("SetStepTwoLayers Done!");
    }
    private void PanelLayersSetup()
    {
        if (debugLog) Debug.Log("Running PanelLayerSetup...");

        panels = new Dictionary<string, GameObject>();
        panels.Add("splashscreen", transform.GetChild(0).gameObject);
        panels.Add("mainmenu", transform.GetChild(1).gameObject);
        panels.Add("ingame", transform.GetChild(2).gameObject);
        panels.Add("pause", transform.GetChild(3).gameObject);

        if (debugLog) Debug.Log("PanelLayerSetUp Done");
    }
    private void MM_LayersSetup()
        
    {
        if (debugLog) Debug.Log("Running MM_LayersSetup...");

        mainMenuLayers = new Dictionary<string, GameObject>();
        mainMenuLayers.Add("stepone", transform.GetChild(1).GetChild(0).gameObject);
        mainMenuLayers.Add("steptwo", transform.GetChild(1).GetChild(1).gameObject);
        mainMenuLayers.Add("areyousure", transform.GetChild(1).GetChild(2).gameObject);

        if (debugLog) Debug.Log("MM_LayerSetup Done!");
    }
    //Propery
    public Dictionary<string, GameObject> Panels { get { return panels; } set { panels = value; } }
    public Dictionary<string, GameObject> MainMenuLayers { get { return mainMenuLayers; } set { mainMenuLayers = value; } }

}
