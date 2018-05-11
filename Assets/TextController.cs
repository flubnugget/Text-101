using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextController : MonoBehaviour {

    public Text text;

    private enum States {begin, EEEbegin, SSSbegin, CCCbegin, begin_1, begin_2, ACCEPT_begin_3, DECLINE_begin_3, WARRIORfirstbattle, WARRIORfirstbattle_1, WARRIORfirstbattle_fail, WARRIORfirstbattle_2, WARRIORsecondbattle, WARRIORsecondbattle_2,
                          WARRIORsecondbattle_1, WARRIORsecondbattle_3, WARRIORsecondbattle_fail, WARRIORfinalbattle, WARRIORfinalbattle_1, WARRIORfinalbattle_fail, YWARRIORfinalbattle, YWARRIORfinalbattle_1, YWARRIORfinalbattle_2, YWARRIORfinalbattle_3, YWARRIORfinalbattle_4, YWARRIORfinalbattle_5, YWARRIORfinalbattle_fail, NOtoDaveth, end, end_1, end_Death, end_Daveth, end_Kill  }
    private States myState;

    // Use this for initialization
    void Start() {
        myState = States.begin;
    }
	   
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.begin)
        {
            state_begin();
        }

        else if (myState == States.EEEbegin)
        {
            state_EEEbegin();
        }

        else if (myState == States.SSSbegin)
        {
            state_SSSbegin();
        }

        else if (myState == States.CCCbegin)
        {
            state_CCCbegin();
        }

        else if (myState == States.begin_1)
        {
            state_begin_1();
        }

        else if (myState == States.begin_2)
        {
            state_begin_2();
        }

        else if (myState == States.ACCEPT_begin_3)
        {
            state_ACCEPT_begin_3();
        }

        else if (myState == States.DECLINE_begin_3)
        {
            state_DECLINE_begin_3();
        }

        else if (myState == States.WARRIORfirstbattle)
        {
            state_WARRIORfirstbattle();
        }

        else if (myState == States.WARRIORfirstbattle_1)
        {
            state_WARRIORfirstbattle_1();
        }

        else if (myState == States.WARRIORfirstbattle_fail)
        {
            state_WARRIORfirstbattle_fail();
        }

        else if (myState == States.WARRIORsecondbattle)
        {
            state_WARRIORsecondbattle();
        }

        else if (myState == States.WARRIORsecondbattle_1)
        {
            state_WARRIORsecondbattle_1();
        }

        else if (myState == States.WARRIORsecondbattle_fail)
        {
            state_WARRIORsecondbattle_fail();
        }

        else if (myState == States.end)
        {
            state_end();
        }

        else if (myState == States.end_1)
        {
            state_end_1();
        }

        else if (myState == States.WARRIORfirstbattle_2)
        {
            state_WARRIORfirstbattle_2();
        }

        else if (myState == States.WARRIORsecondbattle_2)
        {
            state_WARRIORsecondbattle_2();
        }

        else if (myState == States.WARRIORsecondbattle_3)
        {
            state_WARRIORsecondbattle_3();
        }

        else if (myState == States.YWARRIORfinalbattle)
        {
            state_YWARRIORfinalbattle();
        }


        else if (myState == States.YWARRIORfinalbattle_1)
        {
            state_YWARRIORfinalbattle_1();
        }


        else if (myState == States.YWARRIORfinalbattle_2)
        {
            state_YWARRIORfinalbattle_2();
        }

        else if (myState == States.YWARRIORfinalbattle_3)
        {
            state_YWARRIORfinalbattle_3();
        }

        else if (myState == States.YWARRIORfinalbattle_4)
        {
            state_YWARRIORfinalbattle_4();
        }

        else if (myState == States.YWARRIORfinalbattle_5)
        {
            state_YWARRIORfinalbattle_5();
        }

        else if (myState == States.NOtoDaveth)
        {
            state_NOtoDaveth();
        }

        else if (myState == States.YWARRIORfinalbattle_fail)
        {
            state_YWARRIORfinalbattle_fail();
        }

        else if (myState == States.end_Daveth)
        {
            state_end_Daveth();
        }

        else if (myState == States.end_Death)
        {
            state_end_Death();
        }

        else if (myState == States.end_Kill)
        {
            state_end_Kill();
        }









    }









    void state_begin ()
    {
        text.text = " I wake up to the sound of an ear-slamming gong noise. I'm not uncomfortable, though. I know exactly why District 46 — and every other district — has been woken up. Today is the day I've been waiting for my entire life.\n\n" +
                    " Today is my first, and quite possibly my last, Ingrham tournament. \n\n " + "The Ingrham tournament is a ferocious battle between the most majestic and powerful bionic magi and warriors from all across" +
                    " the continent of Wellham. I — and everyone else that'll be there — am fighting for the wish that the Old Gods grant the winner every year. I can wish for anything, from power and riches to fame and glory. The possibilities are endless.\n\n" +
                    " As I finish putting on my armor, I can't help but feel... \n\n" + " Press E for excited, S for Scared, C for calm";

            

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.EEEbegin;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.SSSbegin;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.CCCbegin;
        }

    }

    void state_EEEbegin()
    {
        text.text = "...excited. I've have always looked forwards to adventure, particularly this day. Even though I knew that I had no choice but to participate, I always sang like a bard about the day when I was going to defeat" +
                    " Ocelot, Bionic Titan of the Fjords, in one foul swoop. Sure, people laughed at me, but that never stopped me from believing that I would. Now, it's my time to prove them wrong. \n\n" +
                    "  As I sheathe my sword, I             do a final check of my items and gear, then head down to my teleportation system. I step in and plot a course for Ingrham, closing my eyes and letting my machine take me to where I'll either win and live a glorious life...\n\n" +
                    " or die.\n\n" +
                    "Press C to continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.begin_1;
        }


    }

    void state_SSSbegin()
    {
        text.text = "...scared. After all, I'm plotting a course to land that's unfamiliar to me, and I've heard the legends of the mythical beasts that reside on the continent of Ingrham, such as manticores. Not to mention, warriors such as Raime, Bionic Warrior of the North will be there." +
                    " Then again, I never had a choice, with me being drafted by the Bionics Selective system and all. I shake my head to attempt to get rid of my negative mindset. That's the kind of thinking that'll get me killed in a tournament like this.\n\n" +
                    " As I sheathe my sword, I do a final check of my items and gear, then head down to my teleportation system. I step in and plot a course for Ingrham, closing my eyes and letting my machine take me to where I'll either win and live a glorious life...\n\n" +
                    "or die. \n\n" +
                    "Press C to continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.begin_1;
        }


    }

    void state_CCCbegin()
    {
        text.text = "...calm. I knew this day was coming a year ago, and ever since the Annual Announcement, I've studied day and night on how to succeed in this tournament. From where a manticore's heart is to the exact range of a Level 2 Bionic Ripslash, I know the tournament and its duelists like the back of my hand." + 
                    " Hopefully, I'll be able to use this knowledge against any and all of my opponents. \n\n" +
                    " As I sheathe my sword, I do a final check of my items and gear, then head down to my teleportation system. I step in and plot a course for Ingrham, closing my eyes and letting my machine take med to where I'll either win and live a glorious life...\n\n " +
                    "or die\n\n" +
                    "Press C to continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.begin_1;
        }

    }

    void state_begin_1()
    {
        text.text = " I open my eyes and step out of the teleportation pod. It seems I've arrived in one piece, which is good. I look around, and without any doubt in my mind, I know I've landed in the right continent.\n\n" +
                    " I look down from the cliff I teleported to and see tens of thousands of warriors and magi from all over the world. I notice some of the big names from the tournament roster, such as Krul, Warp Mage of the South. I also see Vol, the 7'3 behemoth that's"+
                    " infamous for being the man who killed a Chimera with just one punch. \n\n"+
                    " However, before I can continue to gaze at the amazing bionic warriors and mages that are gathered here, I hear a voice from behind me.\n\n"+
                    " ''Hello there, fellow warrior!''\n\n" +
                    "Press C to continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.begin_2;
        }

    }


    void state_begin_2()
    {
        text.text = " I turn around and see the person that was calling me. Before me stands a 6'1 man with a toned, muscular physique and short golden hair. He has a longsword and shield attached to his back and is dressed in enchanted leather armor." +
                    " I can tell he's from one of the richer districts because of the rings on his hands. \n\n" + " ''The name's Daveth! Sorry to startle you like that, but I was hoping to find allies as soon as I landed here. Considering that you were the closest person to my pod, I've decided to ask you! Whaddya say?''\n\n" +
                    " I look the warrior up and down one more time. He seems harmless enough, and I could definitely get all the help I could get. However, I did only just meet him. \n\n" +
                    " Press A to accept his offer, D to decline.";

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.ACCEPT_begin_3;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.DECLINE_begin_3;
        }

    }
        void state_ACCEPT_begin_3()
        {
            text.text = " ''Sure man. I could use all the help I could get.'' \n\n" + "''Ah, splendid! As I already told you, the name's Daveth. As you might've been able to tell, I'm a noble warrior from District 3, and I specialize in sword and shield combat. How about you? Would you consider yourself a warrior? Or possibly a mage?'' \n\n" +
                        " Press W for Warrior";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.WARRIORfirstbattle;
        }

        }

    void state_DECLINE_begin_3()
    {
        text.text = " 'No thanks, I like to work by myself.' \n\n" + " Daveth's look of jolliness starts to slowly fade away, and he adopts a much more serious and solemn demeanor.\n\n" +
                    " ''Ah, well I'm sad to hear that. Unfortunately, if you cannot be my ally, then you must be my enemy.'' With no time to react, I see the warrior detach his sword from his back and slash at me, slicing my throat open in one quick, fluid motion." +
                    " I fall to my knees and grasp at my neck, desperately trying to stop the river of blood coming from my throat. However, it's no use. The last thing I see before I die is Daveth walking away, wiping the blood off of his sword with a towel. \n\n" +
                    " Press R to restart the game, B to go back to the previous scene.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.begin;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.begin_2;
        }

    }

    void state_WARRIORfirstbattle()
    {
            text.text = " ''A fellow warrior? Amazing! Well then warrior, how about you put your swordsmanship to the test? Behind you!'' \n\n" + "I quickly turn around and see a group of two warriors with a mage. I had been so focused on me and Daventh's conversation, I hadn't even heard the resounding Horn Of The Arena signal the start of the tournament." + 
            " The mage and warriors look battle hardened and ready to fight. The largest of the three begin to speak first. \n\n" + " ''Well then! I guess we can't ambush the lads like we planned too. Ah well, it doesn't matter. Prepare to fight!'' \n\n" + 
            " Daveth begins to speak again. ''Well, what do you think we should do ally? Should we rush them and try to kill them first? Or would you prefer to wait and counterattack?'' \n\n" + "Press A to Attack, W to Wait";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.WARRIORfirstbattle_fail;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.WARRIORfirstbattle_1;
        }

    }

    void state_WARRIORfirstbattle_fail()
    {
        text.text = " ''Let's wait for them to atta—'' Before I can finish my sentence, roots from the ground quickly engulf my arms and legs. I look over to see that Daveth is in the same position, unable to move. \n\n" + 
                    " ''AHAHAA! Great work Leila! They didn't even know what hit em! She's been preparing that spell for quite some time lads. Anyways, I'll spare you the semantics. Prepare to die!'' Both of the warriors begin to walk over to me and Daveth's position while I'm struggling to move." +
                    " Eventually, the warriors are standing in front of me and Daveth. I see the smaller warrior take his knife out and stab Daveth's throat, killing him instantly. I barely have time to look back as the leader takes out his axe and, with one swift motion, beheads me. \n\n" +
                    " Press R to Restart the game, B to go Back to the previous scene."; 

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.begin;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.WARRIORfirstbattle;
        }
    }

    void state_WARRIORfirstbattle_1()
    {
        text.text = " We both look at each other and nod. I rush from where I'm standing and draw my longsword from its hilt. Thankfully, Daveth had the same idea as me as I see him also rush from where he's standing. Just as we both begin to run, I glance back and see that where we were standing " +
                    " has been quickly engulfed in roots. I'm glad I chose to rush them. \n\n" + " I turn ahead again and prepare to attack the mage with a level 2 Bionic Ripslash. However, before I get the chance to do anything, I see Daveth put on a burst of speed and slash at the mage, decapitating her and killing her instantly. He wastes no time and stabs the smaller warrior in the heart. \n\n" +
                    " The larger warrior attempts to parry Daveth's next attack, but it's no use. Daveth's last slash collides with the warrior's battleaxe and breaks it, continuing down and cutting the warrior in half. They never stood a chance. \n\n " + "Press C to Continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.WARRIORfirstbattle_2;
        }
    }

    void state_WARRIORfirstbattle_2()
    {
        text.text = " I'm glad I deceided to side with this guy. \n\n" + " Daveth takes a towel out of his pack and proceeds to wipe the blood off of his sword. As he sheathes it, I see a solemn look in his eyes, as if he were almost sorry that he had to kill them. Once he sees me looking at him, however, he immediately adopts an expression of joyfuness. ''Well then, let's not waste anymore time here!" +
                    " We should find a cave to sleep in. How does the Milldew Mountains sound, ally?'' \n\n" + " ''Alright, that seems like a good idea.'' I say. The next few hours are spent walking beside Daveth, engaged in conversation with him about his family, his district, and his noble status. I tried to ask him about his training and how he learned to fight, but he dodges my questions. \n\n" +
                    " Eventually, we finally get to the cave and get to sleep. However, it's only a few hours before we're woken up by a deafening roar. \n\n" + " Press C to continue";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.WARRIORsecondbattle;
        }
    }

    void state_WARRIORsecondbattle()
    {
        text.text = " Daveth and I both wake up and run outside to see what's happening. In front of us, we see a 20 foot Manticore, a mythical beast indigenous to Ingrham. It has the head of a lion, the body of a lizard, and the wings of a dragon. It sets his eyes on us and snarls his razor-sharp teeth, black venom dripping from its fangs. \n\n" + 
                    " ''Well, it seems we're in a bit of a tum-tigger, aren't we ally?'' says Daveth in a suprisingly calm tone. ''I've never read anything on Manticores, so I hope you know what to do! You were right the last time we were up against an enemy, so I trust you.'' I look over at Daveth and see a genuine smile on his face. He's really leaving his life in my hands. \n\n" +
                    " Press R to Run, W to Wait to counterattack the Manticore.";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.WARRIORsecondbattle_1;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.WARRIORsecondbattle_fail;
        }
    }

    void state_WARRIORsecondbattle_fail()
    {
        text.text = " ''Look, Daveth. There's no way we can take on a Manticore. We have to run, NOW!'' \n\n" + " Daveth and I begin to run away from the Manticore at full speed. As we're running, we hear another deafening roar from the Manticore. I look behind us and see that the Manticore has began to pursue us, also running at its full speed. It leaps into the air and begins to gain altitude rapidly. \n\n " +
                    "After about 20 seconds of running, the Manticore decides to dive at full speed — 250 m per hour. Daveth may have been strong, but he was no match for the impact of the Manticore. It sent him flying straight into me, knocking me off my feet and sending me tumbling into a rock wall with Daveth. With one last roar, the Manticore shoots a massive fireball at us, incenirating us and everything in a 250ft radius. \n\n" +
                    " Press R to Restart the game, B to go Back to the previous scene.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.begin;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.WARRIORsecondbattle;
        }
    }

    void state_WARRIORsecondbattle_1()
    {
        text.text = "''Look, Daveth. There's no way we'll outrun that thing. We have to fight it. I say we wait until it flies up, then when it comes down, I'll put all my energy into a Bionic Whirlwind. It should keep me safe. Then, you'll pierce its skull from the back. Got it?'' \n\n" + 
                    "''Understood''. \n\n" + " The Manticore sees that we're going to fight. In response, it flaps its wings, creating a large gust of air and accelerating upwards at an alarming speed. Even Manticores shouldn't be that fast. It circles the skies, then, as expected, it soars down at me. \n\n" +
                    " I concenrate my energy as Daveth dashes away to get into position. I begin to spin in a 360 degree rotation, slashing my sword in random directions. By the time the manticore reaches me, I'm at full power. \n\n" + " Press C to continue.";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.WARRIORsecondbattle_2;
        }
    }

    void state_WARRIORsecondbattle_2()
    {
        text.text = " One of my swings slash against the Manticore's face, ripping apart its left eye. It screams in pain and attempts to fly back up, but it's much too late. I see Daveth soar from the top of a tree, his longsword glowing with power. I catch a glimpse of another sorrowful look in his eyes as he pierces the Manticore's skull. \n\n" +
                    " The Manticore drops to the ground and doesn't make another sound. A large pool of blood starts to soak the grass around me and Daveth. He pulls his sword out of the Manticore, making a gory, wet noise. We jump back from the dead Manticore. Before I can say anything though, Daveth speaks. \n\n" +
                    " ''Do you know why I adopt a solemn look in my eyes before I kill something, ally?'' He's looking directly at me now, and I see that he's crying. His voice cracks as he continues to speak. ''It's because I hate death. With a passion.'' \n\n" +
                    " Press C to Continue.";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.WARRIORsecondbattle_3;
        }
    }

    void state_WARRIORsecondbattle_3()
    {
        text.text = "''When I was seven years old, I was in the woods with my older brother. As we were coming back from a fishing adventure, we were ambushed by some lowly District 42 thugs. They killed my older brother without hesitation, ransacking our gold and food in the process. They would've killed me too, but...'' He pauses before he begins to speak again. His voice carries more strength now. \n\n" + " ''I was saved by the one and only, Raime, Bionic Warrior of the North. He defeated them in the blink of an eye. He had a solemn look in his eyes also. He looked at me and told me to train, to work so hard that I bled, to ensure that this never happened again.'' \n\n" +
                    "''From then, I became the strongest noble in the Noble Districts. I was always honored in the tournaments for winning, but I never had to kill anybody or anything. That is, until I was chosen to participate in this hellish tournament." +
                    " I've had to kill four times today. But it is a necessary sacrifice. When I win, I will ask the Old Gods to abolish death, to make everything live forever.'' He's now looking at the stars while he's telling me this, the same solemn look in his eyes. ''After I win, no more will die'' He then looks at me, more serious. ''Do you agree with my philosophy?'' " +
                    " Press Y to say Yes, N to say No";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = States.YWARRIORfinalbattle;
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.NOtoDaveth;
        }
    }

    void state_NOtoDaveth()
        {
            text.text = "'' Honestly, I don't think that's right Daveth. Sure, what happened to you is horrible and I wouldn't wish it upon anyone, but to abolish death completely? That seems kind of far-fetched. Death is a necessary part of life.'' \n\n" +
                        " Daveth doesn't say anything for a long while and starts to wipe the blood off of his blade. By the time he finishes, he begins to speak again, this time in a much happier, jollier tone." +
                        " ''Well, moping around here won't do us any good! I say we should get some rest and prepare for the tournament! Whaddya say, ally?'' ''That sounds amazing'' I say with a smile. This Daveth guy is something else. \n\n" + " Once we wake up, we continue on in the tournament. Throughout the days, we meet more enemies, but we manage to take care of them fairly easily. As we fight more and more people and monsters, it only becomes easier to take them out as Daveth and I upgrade our teamwork skills and awareness. Eventually, we end up getting to the end of the tournament after a week of fighting. Then, we come upon our last enemy. \n\n" +
                    " Press C to continue ";

            if (Input.GetKeyDown(KeyCode.C))
            {
                myState = States.YWARRIORfinalbattle_1;
            }


        }

    

    void state_YWARRIORfinalbattle()
    {
        text.text = " ''I honestly couldn't agree with you more Daveth. I wish that death wasn't a part of our lives.'' \n\n" + " Daveth looks at me and smiles. ''Ah, that's good to hear. I was afraid I was the only one who though the way I did. Anyways, I think its finally time that we get some well-deserved sleep ally! Whaddya say?''" +
                    " ''That sounds amazing'' I say with a smile. This Daveth guy is something else. \n\n" + " Once we wake up, we continue on in the tournament. Throughout the days, we meet more enemies, but we manage to take care of them fairly easily. As we fight more and more people and monsters, it only becomes easier to take them out as Daveth and I upgrade our teamwork skills and awareness. Eventually, we end up getting to the end of the tournament after a week of fighting. Then, we come upon our last enemy. \n\n" +
                    " Press C to continue ";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.YWARRIORfinalbattle_1;
        }
    }

    void state_YWARRIORfinalbattle_1()
    {
        text.text = " ''Well, I guess this is the end of tournament then! Whichever enemy we meet, I'm sure we'll be able to take them on all—''. He pauses for a second, before he begins to speak again. ''You know, I never got your name. What was it again? \n\n" +
                    " I chuckle a little bit before answering him. ''The name's Timothy. Timothy Blackwell''. \n\n " + "''Ahhh, well okay then Timothy! Let's meet in the final area to challenge our last opponent!'' \n\n" + " Press C to Continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.YWARRIORfinalbattle_2;
        }
    }

    void state_YWARRIORfinalbattle_2()
    {
        text.text = "We walk into the final arena and stop right in the middle of the field. Whoever — or whatever — appears, I feel like we can take them on. \n\n " + "Daveth and I feel a massive rumble in the arena and a quick change in the atmosphere suddenly. We draw our swords and stand back-to-back. Then, I hear a sudden ear-piercing CRACK. In the next second, a resounding BOOM signals the explosion that happens 20 meters away from us. As the dust clears, we see none other than... \n\n" +
                    " Raime, Bionic Warrior Of The North, standing in front of us. \n\n" + " Press C to Continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.YWARRIORfinalbattle_3;
        }
    }

    void state_YWARRIORfinalbattle_3()
    {
        text.text = "Raime is a 6'9 old, muscular man with long, braided silver hair and a braided silver beard. He's wearing a leather harness and pants with an enormous hammer made out of Valadium metal strapped to his back. I see Bionic Power emitting from him, and his eyes are completely white. When he speaks, it's a low, resonating voice that sounds like it's endured too much pain. \n\n" +
                    "''I will try to make your deaths as quick and painless as possible. Please know that your sacrifices will lead to a better world. I will not waste time with idle talk, however, so prepare to meet your Maker. And Daveth,'' he says as he turns to look at him, ''I am truly sorry things have to end this way.''" + " I look over at Daveth and see a look of pure shock and horror on his face. This is the man who saved his life. \n\n" +
                    "Raime unsheathes his hammer, and the air around him begins to crackle. However, before I can react, Raime teleports in front of Daveth. Without a word, he raises his hammer and brings it down on him, crushing the area around Daveth and killing him instantly. \n\n" +  "Press C to Continue";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.YWARRIORfinalbattle_4;
        }
    }

    void state_YWARRIORfinalbattle_4()
    {
        text.text = "Raime has the same look in his eyes as Daveth before he has to kill something. He turns to look at me as I stand there in complete and utter shock, unable to comprehend what just happened. No, I can comprehend it. Raime just killed Daveth. In cold blood, and without mercy. He'll pay for that. I don't care who he is, or what types of morals he has. I grip my sword and unsheathe it, my knuckles turning white against the hilt of my blade. I feel angrier than I ever have before. Daveth was my friend, and I'll be damned if I let someone like Raime stop me from avenging him. \n\n" +
                    " I feel more power surging through me than I ever have before as tears roll down my eyes. My aura is fluctuating at a level I've never felt before. Now, I have to choose between rushing at him or letting him come to me. \n\n" + " Press R to Rush, W to Wait";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.YWARRIORfinalbattle_fail;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.YWARRIORfinalbattle_5;
        }
    }

    void state_YWARRIORfinalbattle_fail()
    {
        text.text = "''I'LL KILL YOUU!!!'' I scream at Raime. I rush towards him and slash at him, attempting to decapitate his head in one motion. However, he teleports behind me with ease and at a blinding speed. I have just enough time to look back as he kills me the same way he killed Daveth. He brings his hammer down and crushes me, killing me insantly. \n\n" +
                    " Press R to Retsart, B to go Back to the previous scene.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.begin;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.YWARRIORfinalbattle_4;
        }
    }

    void state_YWARRIORfinalbattle_5()
    {
        text.text = " I decide to wait for him to teleport to me. He shivers, and in an instant, he's in front of me. He raises his hammer and brings it down, just like how he did with Daveth. However, I'm able to parry it, sending out a shockwave of energy. He looks genuinely surprised, as if he's never had that happen to him before. He disengages and leaps back, sending out a Bionic Freball. I slash through it and cut it in half, sending out another shockwave." +
                    " Again, he seems to be surprised. \n\n" + "''You have the power of the Ancient One within you boy. Nobody has seen my Bionic Crash or Warp Fireball and lived to tell the tale.'' He drops his hammer, and his power seems to decrease exponentially. ''I will not be able to win this fight. I am yours to kill. At least then, I will be able to see Daveth again.'' He drops to his knees and bows his head, waiting for me to kill him. \n\n" +
                    " Press K to Kill Raime";

        if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.end;
        }
    }



    void state_end()
    {
        text.text = " I take out my longsword and walk up to Raime. I place the tip of my sword at his neck, letting all my rage and sadness flow through me. ''This is for Daveth and your sick, twisted dream.'' I let out an involuntary battle cry as I bring my sword down, splitting Raime's head in two. His body goes limp, and I see the reknowned warrior fall to the ground with a thud. \n\n" +
                    " Press C to Continue";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.end_1;
        }
    }

    void state_end_1()
    {
        text.text = " Suddenly, a loud crack resounds throughout the Arena as I look up and see the sky splitting in two. Three people — two older looking men and a young woman — float down in front of me wearing celestial robes and glowing with a powerful, resonating aura. The young woman begins to speak. \n\n " +
                    " ''Congratulations, Timothy Blackwell, warrior of District 42. You have officially won the 75th Ingrham Tournament. You look like a man who's been through a lot, so we'll spare you the formalities. As you know, you have one wish. What do you wish for, hmm? Power? Riches? Immortality? Just say the word, warrior.'' She smiles a beautiful, radiating smile. \n\n" +
                    " Press R to wish to Revive Daveth \n\n"   +    "Press D to wish to abolish Death \n\n" +         "Press K to Kill the Ancient Ones";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.end_Daveth;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.end_Death;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.end_Kill;
        }
    }

    void state_end_Daveth()
    {
        text.text = " ''Revive my friend, Daveth.'' \n\n" + " ''Ahhh, yes, he was a good fellow that one'' says the older man on the left. ''Very well.'' They all snap their fingers simultaneously, and a white bright light envelops Daveth. \n\n" +
                    " In a flash, I see Daveth standing in front of me, all of his wounds healed. However, he has a sad look on his face. Then, he begins to speak. \n\n" + "''What point is there in living if we all die, Timothy? The world is no closer to being better than it was before.'' With those words, he turns and walks away, leaving me standing there speechless. \n\n " +
                    "                                                       Thank you for playing!!!";

        
    }

    void state_end_Death()
    {
        text.text = " '' I want to abolish death.'' \n\n" + " The Ancient Ones look at me quizically, but don't say anything. Instead, they all snap their fingers simultaneously. I'm blinded by a white. bright light, and in the next moment, they're gone. Nothing feels different, but I can sense that my wish has been fulfilled. \n\n" + "I look up to the sky and hope that what I did was right. \n\n" +
                    "                                                       Thank you for playing!!!";

    }

    void state_end_Kill()
    {
        text.text = " '' I want to kill you. I want to kill you all. You're the ones who started this sick, twisted tournament, and you'll be the ones to end it. I lost my friend to you monsters. So die.'' \n\n" + 
                    " I draw my longsword and walk up to them slowly. They have shocked looks on their faces, but they can't say no to me. In one quick, fluid motion, I slit all of their throats. They slump over and fall to their deaths with a thud. A pool of blood forms around them. I turn around and walk away from the scene, wiping the blood off of my blade as I do so. \n\n" +
                    "                                                       Thank you for playing!!!";

    }




}

















    



