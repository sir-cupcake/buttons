using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oaoa : MonoBehaviour
{
    [SerializeField] private Button _JumpPP;
    [SerializeField] private GameObject _MyImage;
    [SerializeField] private List<GameObject> _ImageBad;
    private void OnEnable()
    {
        _JumpPP.onClick.AddListener(jump);
        Debug.Log("ENABLE");
    }
    private void OnDisable()
    {
        _JumpPP.onClick.RemoveAllListeners();
    }
    private void jump()
    {
        _MyImage.SetActive(true);
        foreach (GameObject item in _ImageBad)
        {
            item.SetActive(false);
        }
    }

}
