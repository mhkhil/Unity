using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class information : MonoBehaviour
{
    [SerializeField] string title;
    [SerializeField] string description;

    private Text titleText;
    private Text descriptionText;

    private void Awake()
    {
        titleText = transform.GetChild(0).GetComponent<Text>();
        descriptionText = transform.GetChild(1).GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        titleText.text = title;
        descriptionText.text = description;
    }
}
