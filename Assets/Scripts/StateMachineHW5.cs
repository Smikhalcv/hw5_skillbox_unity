using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachineHW5 : MonoBehaviour
{ 
    [SerializeField] private GameObject firstScene;

    private GameObject currectScene;

    // Start is called before the first frame update
    void Start()
    {
        firstScene.SetActive(true);
        currectScene = firstScene;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChangeScene(GameObject nextScene)
    {
        currectScene.SetActive(false);
        nextScene.SetActive(true);
        currectScene = nextScene;
    }
}
