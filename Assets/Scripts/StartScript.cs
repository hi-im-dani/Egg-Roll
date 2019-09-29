using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    int count = 0;
    bool changeSceneLS = false, changeSceneES = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (changeSceneLS)
        {
            if (count >= 30)
            {
                SceneManager.LoadScene("LevelSelect");
                count = -1;
                changeSceneLS = false;
            }
            count++;
        }
        if (changeSceneES)
        {
            if (count >= 30)
            {
                SceneManager.LoadScene("EggSelect");
                count = -1;
                changeSceneES = false;
            }
            count++;
        }
    }

    public void onPress() {

        changeSceneLS = true;
        
    }

    public void loadEggSelect() {

        changeSceneES = true;

    }

    public void loadGame() {

        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();
        if(gv.player1Egg != -1)
            SceneManager.LoadScene("Level" + gv.level);

    }

    public void exit() {

        Application.Quit();
           
    }

    public void incrLevel() {

        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();

        if (gv.level < GlobalVariables.LEVELS - 1)
        {
            gv.level += 1;
        }

    }

    public void decrLevel() {

        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();

        if (gv.level > 0) {

            gv.level -= 1;
        }

    }

    public void selectEgg(int egg) {


        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();
        gv.player1Egg = (gv.eggPage * 6) + egg;

    }

    public void incrPage() {

        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();
        if (gv.eggPage <= 10) {

            gv.eggPage++;

        }

    }

    public void decrPage() {

        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();
        if (gv.eggPage > 0) {

            gv.eggPage--;

        }

    }
}
