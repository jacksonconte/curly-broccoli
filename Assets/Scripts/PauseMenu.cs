using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    UIDocument buttonDocument;
    public GameManager manager;

    // Update is called once per frame
    void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button buttonResume = root.Q<Button>("Resume");

        buttonResume.clicked += () => manager.Resume();

    }
}
