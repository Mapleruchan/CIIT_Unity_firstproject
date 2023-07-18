using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textgaemmanager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storytext;
    public int hp, stam;
    public GameObject onward2, onward3, onward4, onward5, evo, onward, menu, succumb, lv1choice, lv2choice, lv3choice, lv4choice, lv5choice, helt, stamy, end1, end2, end3, end4, end5;

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
        menu.SetActive(false);
        storytext = "Stage 1:\r\nA horde of zombies is coming at you. Let the bloodbath begin";
        stamy.SetActive(true);
        helt.SetActive(true);
    }
    public void sutop()
    { Application.Quit(); }

    public void gatlinggun()
    {
        storytext = "!You killed a bunch of them but you ran out of ammo, you got bitten... Good luck";
        lv1choice.SetActive(false);
        hp -= 6;
        onward.SetActive(true);
    }
    public void Nuke()
    {
        storytext = "!You killed all of them but blasted yourself in the process";
        lv1choice.SetActive(false);

        end1.SetActive(true);
    }
    public void Grenade()
    {
        storytext = "!You fired your only grenade... it didn't hit much, their coming for you, suddenly the gas stations start exploding, killing all the zombies. You were so lucky that you were unscathed";
        lv1choice.SetActive(false);
        onward.SetActive(true);

    }

    public void next()
    {
        storytext = "!A POISONOUS MONSTER SHOWS UP, WHAT DO YOU DO?";
        lv2choice.SetActive(true);
        onward.SetActive(false);

    }

    public void excalibur()
    {
        storytext = "!You grab the excalibur and unleashed its full power and slashed it down to the monster. The monster has already sneaked on you while you were charging power";
        lv2choice.SetActive(false);
        hp -= 2;
        onward2.SetActive(true);
    }
    public void bladeworks()
    {
        storytext = "!You unleashed infinite sword rains upon the monsters but it just absorbs them and fired them back to you";
        lv2choice.SetActive(false);
        hp -= 3;
        onward2.SetActive(true);
    }
    public void eat()
    {
        storytext = "!This is the stupidest choice one could ever make. Why try eating a live and poisonous monster…\r\n…You actually absorbed its power and healed yourself., HOWW?";
        lv2choice.SetActive(false);
        end2.SetActive(true);

    }

    public void next2()
    {
        storytext = "Stage: 3\r\nA vampire appears and hovers above you, how will you kill?";
        lv3choice.SetActive(true);
        onward3.SetActive(false);

    }

    public void zawarudo()
    {
        storytext = "!You grab the excalibur and unleashed its full power and slashed it down to the monster. The monster has already sneaked on you while you were charging power";
        lv3choice.SetActive(false);
        hp -= 3;
        onward3.SetActive(true);
    }
    public void nigerun()
    {
        storytext = "!You unleashed infinite sword rains upon the monsters but it just absorbs them and fired them back to you";
        lv3choice.SetActive(false);
        hp += 3;
        onward3.SetActive(true);
    }
    public void hamon()
    {
        storytext = "!This is the stupidest choice one could ever make. Why try eating a live and poisonous monster…\r\n…You actually absorbed its power and healed yourself., HOWW?";
        lv3choice.SetActive(false);
        onward3.SetActive(true);

    }

    public void next3()
    {
        storytext = "Stage: 4\r\nAssassins come for your head but isn't it you who itches to kill?";
        lv4choice.SetActive(true);
        onward3.SetActive(false);

    }

    public void aot()
    {
        storytext = "You realize these are only strong against giants since they are slow. The assassins dodge and you hit a wall. pain";

        lv4choice.SetActive(false);
        hp -= 2;
        end3.SetActive(true);
    }


    public void smasssh()
    {
        storytext = "!You use 100% of your power and overkilled the assassins however the backlash of the power hits you.\r\n";
        lv4choice.SetActive(false);
        hp -= 3;
        onward4.SetActive(true);
    }
    public void himeko()
    {
        storytext = "!Based on your experience you figured this is gonna damage you too, surprisingly it only affected the assassins. “Hmm thought i was a goner”\r\n";
        lv4choice.SetActive(false);
        onward4.SetActive(true);

    }

    public void next4()
    {
        storytext = "Stage: 5 \r\nA fallen angel stands before you. How will you beat the immortal?";
        lv5choice.SetActive(true);
        onward4.SetActive(false);

    }

    public void cqc()
    {
        storytext = "With space CQC you begin throwing grenades and chainsaws. “You think this is enough to kill a being like me”. The thing you threw fell on the abyss and caused a rip which sucked the angel in.\r\n";

        lv4choice.SetActive(false);

        end4.SetActive(true);
    }


    public void heart()
    {
        storytext = "!You launch a thunder javelin towards its heart but it just goes through. The angel uses retribution on you";
        lv4choice.SetActive(false);
        hp -= 5;
        onward5.SetActive(true);
    }
    public void chasm()
    {
        storytext = "You try to push it towards the void but it pushed you instead\r\n";
        lv4choice.SetActive(false);
        hp -= 5;
        onward5.SetActive(true);

    }

    public void next5()
    {
        storytext = "Stage: EVO( if player chooses ‘eat it ’ in stage 2 ) \r\nThe  POISONOUS MONSTER that you eat is beginning to react in your body. An army suddenly shows up…";
        evo.SetActive(true);
        onward5.SetActive(false);

    }

    public void spit()
    {
        storytext = "The poison turns you into a dragon that allows you to spit fire at them";

        evo.SetActive(false);

        end2.SetActive(true);
    }


    public void jump()
    {
        storytext = "!You launch a thunder javelin towards its heart but it just goes through. The angel uses retribution on you";
        lv4choice.SetActive(false);
        hp -= 2;
        end2.SetActive(true);
    }
    public void crave()
    {
        storytext = "You try to push it towards the void but it pushed you instead\r\n";
        lv4choice.SetActive(false);
        hp -= 3;
        end2.SetActive(true);

    }


    public void worship()
    {
        storytext = "Blessings of the beast- the poison that has mixed with your body caused you to transform to an uncontrollable beast. The goddess, being impressed with the way you ate the monster to death caused her to give you full control of your new power.";

        end2.SetActive(false);
    }


    public void explosion()
    {
        storytext = "upon killing yourself along with the whole horde of zombies and the rest of existence, the god of killings have been amazed on how you reaped destruction that she revived you and gave you the power to explode and disintegrate planets however, it leaves you immobile for a while after you use it and hurts everytime you activates you";

        lv1choice.SetActive(false);


    }

    public void tyrant()
    {
        storytext = "Ending 2: Blessings of tyrant- you cause an explosion around you and gain the power to transform to a tyrant. You have impressed the goddess that she decides to save you to wreak havoc for her";
        lv4choice.SetActive(false);



    }
}