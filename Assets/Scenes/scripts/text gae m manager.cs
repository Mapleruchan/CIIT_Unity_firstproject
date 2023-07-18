using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textgaemmanager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storytext;
    public int hp, stam;
    public GameObject next,lv1choice,lv2choice,helt,stamy;
    
    // Start is called before the first frame update
    void Start()
    {
       lv1choice.SetActive(false);
        lv2choice.SetActive(false);
        storytext = "Oh chosen one you are to serve me and receive grate power. There is just some thing i ask,... kill for me. will you serve?";

    }

    // Update is called once per frame
    void Update()
    {
       storyTextMeshPro.text = storytext;
       hpTextMeshPro.text = hp.ToString();
       staminaTextMeshPro.text = stam.ToString();
    }
    public void go()
    {
        lv1choice.SetActive(true);
       
        stamy.SetActive(true);
        helt.SetActive(true);
    }
    public void sutop()
    { Application.Quit(); }

    public void gatlinggun()
    {
        storytext = "!You killed a bunch of them but you ran out of ammo, you got bitten... Good luck";
        lv1choice.SetActive(false);
        hp -= 3;
        next.SetActive(true);
    }
    public void Nuke()
    {
        storytext = "!You killed all of them but blasted yourself in the process";
        lv1choice.SetActive(false);
        hp -= 7;
        next.SetActive(true);
    }
    public void Grenade()
    {
        storytext = "!You fired your only grenade... it didn't hit much, their coming for you, suddenly the gas stations start exploding, killing all the zombies. You were so lucky that you were unscathed";
        lv1choice.SetActive(false);
        next.SetActive(true);

    }

    public void onward()
    {
        storytext = "!A POISONOUS MONSTER SHOWS UP, WHAT DO YOU DO?";
        lv2choice.SetActive(true);
        next.SetActive(false);

    }


}
