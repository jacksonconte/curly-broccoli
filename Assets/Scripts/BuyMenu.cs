using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BuyMenu : MonoBehaviour {

    UIDocument buttonDocument;
    Button uiButton;
    VisualElement vElement;
    public Sprite sprite;
    VisualElement room1;

    void OnEnable() {
        buttonDocument = GetComponent<UIDocument>();
        room1 = buttonDocument.rootVisualElement.Q("Room1") as VisualElement;

        if (buttonDocument == null ) {
            Debug.LogError("No Button document found");
        }

        uiButton = buttonDocument.rootVisualElement.Q("SkeletonButton") as Button;

        if(uiButton != null) {
            Debug.Log("Button Found");
        }

        uiButton.RegisterCallback<ClickEvent>(OnButtonClick);
    }

    public void OnButtonClick(ClickEvent evt) {
        Debug.Log("The UI Button has been clicked on");

        if(vElement == null) {
            Debug.LogError("No VisualElement Found");
        }
        room1.RegisterCallback<ClickEvent>(OnRoom1Clicked);
    }

    public void OnRoom1Clicked(ClickEvent evt) {
        room1.style.backgroundImage = new StyleBackground(sprite);
    }

    public void PurchaseSkeleton() {
        Debug.Log("Standard Skeleton Purchased");
    }
}
