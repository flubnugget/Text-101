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






    void state_lock_0()
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






    void state_cell_mirror()
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





    void state_sheets_1()
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





    void state_lock_1()
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






    void state_freedom()
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



}








