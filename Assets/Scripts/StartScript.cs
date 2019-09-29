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
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("EggSelect"))
        {
            for (int i = 0; i < 12; i++)
            {

                GameObject.Find("Egg" + i + " (1)").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("Egg" + i).GetComponent<MeshRenderer>().enabled = (i >= 0 && i < 6);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {


        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();

        for (int i = 0; i < 12; i++)
        {

            GameObject.Find("Egg" + i + " (1)").GetComponent<MeshRenderer>().enabled = (gv.player1Egg == i);
            GameObject.Find("Egg" + i).GetComponent<MeshRenderer>().enabled = (i >= gv.eggPage * 6 && i < (gv.eggPage + 1) * 6);

        }
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

    public void loadGamemodeSelect() {


        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();
        if (gv.player1Egg != -1)
            SceneManager.LoadScene("GamemodeSelect");

    }

    public void loadGame(string gamemode) {

        GlobalVariables gv = GameObject.Find("Carton").GetComponent<GlobalVariables>();
        SceneManager.LoadScene("Level" + gv.level + gamemode);

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
        if ((gv.eggPage * 6) + egg < gv.MAX_EGG)
        {
            gv.player1Egg = (gv.eggPage * 6) + egg;
        }
        else {

            gv.player1Egg = -1;

        }

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
