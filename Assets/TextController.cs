using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextController : MonoBehaviour {

    public Text text;

    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom}
    private States myState;

    // Use this for initialization
    void Start() {
        myState = States.cell;
    }
	   
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell) 
            {
            state_cell(); 
            }



            else if (myState == States.sheets_0)
            {
            state_sheets_0();
             }



            else if (myState == States.mirror)
            {
            state_mirror();
            }



            else if (myState == States.lock_0)
            {
            state_lock_0();
            }



            else if (myState == States.cell_mirror)
            {
            state_cell_mirror();
            }



            else if (myState == States.sheets_1)
            {
            state_sheets_1();
            }



            else if (myState == States.lock_1)
            {
            state_lock_1();
            }



            else if (myState == States.freedom)
            {
            state_freedom();
            }
    }







    void state_cell ()
    {
        text.text = "The Day is August 17, 4569.The world " +
                    "is at war with itself, primarily the  " +
                    "Epsilon AI Race against the last of the humans. " +
                    "You are Hal Gorgon, General of the Last Legion. Your time is now... \n\n" +
                    "You have been captured and placed in a maximum security prison " +
                    "by the Epsilonians. Being the General, your people need you, so you must escape. " +
                    "You see the bloody stained sheets on your bunk and a mirror on the wall. " +
                    "The door is heavily padlocked. What will you do? \n\n" +
                    "Press S to view sheets, M to view Mirror, and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }

    }






    void state_sheets_0()
    {
        text.text = "These sheets are where you have lain for the past " +
                    "year and a half. They are soaked with your blood and " +
                    "the blood of those before you. However, you will not die here. \n\n" +
                    "You take one last look at the bed and understand you must achieve vengeance" +
                    "for your fellow brethren. This is where you make your stand, warrior. \n\n" +
                    " Press R to return and continue roaming your prison cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }






    void state_mirror()
    {
        text.text = "You look at the mirror and begin to examine it. You begin " +
                    "to stare at yourself through the jagged edges, wondering " +
                    "where everything went wrong. You become sad, but not sad enough to continue sulking here. \n\n" +
                    "However, you cannot stop the feeling of rage that wells up inside of you." +
                    "You clench your fists, ready to strike at the weak glass infrastructure. What will you do? \n\n" +
                    " Press R to return and continue roaming your prison cell, P to punch the mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell_mirror;
        }
    }






    void state_lock_0()
    {
        text.text = "You stare at the lock that has held you in place for the past year and a half. " +
                    "The chains are stained with your blood and skin from months of trying to break the chains. " +
                    "The maroon, caked blood reminds you that your efforts are futile here. \n\n" +
                    " Press R to return and continue roaming your prison cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }






    void state_cell_mirror()
    {
        text.text = "SKRRSSHHHHHH!! The glass shatters before your mighty fist and " +
                    "falls to the ground in a million pieces. To your surprise, the " +
                    "pain isn't the first thing you notice. Behind the mirror is a high-powered quasar handgun, humming with life. \n\n" +
                    " After turning the device around in your hand and examining it, you conclude it only has enough juice for one blast. " +
                    " This opens up new doors of possibilities. What will you do now warrior?\n\n" +
                    " Press L to view Lock, S to view sheets.";
          
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
    }





    void state_sheets_1()
    {
        text.text = "They're the same sheets, but now, with the soft glow of quasar gel " +
                    "illuminating them, you see your blood in a deeper red than you ever have before. " +
                    "It reminds you that you must escape, before any more is lost here. \n\n" +
                    " Press R to return and continue roaming your prison cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }





    void state_lock_1()
    {
        text.text = "You view the lock that has held you prisoner for the last time. " +
                    "There's no time to waste. You lift the quasar gun and aim it at the lock. " +
                    "The humming vibrates throughout your bones. All that's left to do is pull the trigger. \n\n" +
                    " Press B to Blast the lock to Freedom";

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.freedom;
        }
    }






    void state_freedom()
    {
        text.text = "SKDOOOMMMMMM. The shot echoes throughout your tiny cell and blasts the lock head on. " +
                    "You open your eyes and...\n\n " +
                    "Nothing. The lock is still as daunting as ever, with the chains looking even more secure. " +
                    "You slowly start to realize that you'll never get out, that you'll never be able to save the human race." +
                    "The world is doomed to annihilation, and there's nothing you can do about it. \n\n" +
                    " LOL";
    }



}








