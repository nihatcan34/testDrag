using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slacePlaneX : MonoBehaviour
{
    public bool hide;
    public InputField xsize;
    public InputField zsize;
    public Text textx,textz;
    public GameObject odaGecbut;
    public GameObject tutorialOdaGec;
    public Button but;
    

    // Start is called before the first frame update
    void Start()
    {
        DataStore.init();
        DataStore.test();
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        textx.text = ((transform.localScale.x) * 10f).ToString()  + " " + "Metre";
        textz.text = ((transform.localScale.z) * 10F).ToString() + " " + "Metre";
    }

    // Update is called once per frame
    public void click()
    {
            transform.localScale = new Vector3(float.Parse(xsize.text) * 0.001f, 1, float.Parse(zsize.text) * 0.001f);
            odaGecbut.SetActive(!hide);
            tutorialOdaGec.SetActive(!hide);
    }
}
