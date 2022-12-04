using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Settings()
    {
        Panel.GetComponent<Animator>().SetTrigger("panel");
    }
        

    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSite()
    {
        Application.OpenURL("https://aaaaaaaaaaa.com");
    }
}
