using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpbutton : MonoBehaviour
{
/*    [SerializeField] private Button _JumpPP;
    [SerializeField] private GameObject _Image1;
    [SerializeField] private GameObject _Image2;
    [SerializeField] private GameObject _Image3;*/
    [SerializeField] private GameObject _MyImage;
  //  [SerializeField] private List<GameObject> _ImageGood;
    [SerializeField] private List<GameObject> _ImageBad;



    public void jump()
    {
        _MyImage.SetActive(true);
        foreach (GameObject item in _ImageBad )
        {
            item.SetActive(false);
        }
    }
}
