using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textgaemmanager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storytext;
    public int hp, stam;
    public GameObject lv1choice,lv2choice;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       storyTextMeshPro.text = storytext;
       hpTextMeshPro.text = hp.ToString();
       staminaTextMeshPro.text = stam.ToString();
    }

    public void gatlinggun()
    {
        storytext = "!You killed a bunch of them but you ran out of ammo, you got bitten... Good luck";
        lv1choice.SetActive(false);
        hp -= 3;
        lv2choice.SetActive(true);
    }
    public void Nuke()
    {
        storytext = "!You killed all of them but blasted yourself in the process";
        lv1choice.SetActive(false);
        hp -= 7;
        lv2choice.SetActive(true);
    }
    public void Grenade()
    {
        storytext = "!You fired your only grenade... it didn't hit much, their coming for you, sudenly the gas stations start exploding, killing all the zombies. You were so lucky that you were unscathed";
        lv1choice.SetActive(false);
        lv2choice.SetActive(true);

    }
}
