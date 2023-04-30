using BepInEx;
using System;
using UnityEngine;

namespace OpeningSkip
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            SceneHelper.LoadScene("Main Menu", true);
        }
        void OnEnable()
        {
            SceneHelper.LoadScene("Main Menu", true);
        }
        void Update()
        {
            SceneHelper.LoadScene("Main Menu", true);
            FindObjectOfType<InitGame>().enabled = false;
            GameObject.Find("Init").SetActive(false);
            GameObject.Find("Canvas").SetActiveRecursively(false);
            Camera.main.gameObject.SetActive(false);
            SceneHelper.LoadScene("Main Menu", true);
            if(SceneHelper.CurrentScene == "Main Menu")
            {
                Destroy(this);
            }
        }
        void OnDisable()
        {
            Destroy(this);
        }
    }
}
