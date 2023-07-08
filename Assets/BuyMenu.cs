using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BuyMenu : MonoBehaviour {

    UIDocument buttonDocument;
    Button uiButton;

    void OnEnable() {
        buttonDocument = GetComponent<UIDocument>();

        if (buttonDocument == null ) {
            Debug.LogError("No Button document found");
        }

        uiButton = buttonDocument.rootVisualElement.Q("skeleton") as Button;

        if(uiButton != null) {
            Debug.Log("Button Found");
        }

        uiButton.RegisterCallback<ClickEvent>(OnButtonClick);
    }

    public void OnButtonClick(ClickEvent evt) {
        Debug.Log("The UI Button has been clicked on");
    }

    public void PurchaseSkeleton() {
        Debug.Log("Standard Skeleton Purchased");
    }
}
