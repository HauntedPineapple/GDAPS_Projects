Audrey Main
IGME 105-06

Theme: Club Pangolin sign up(or sign in)
	I like pangolins, they're cute
	They're also super endangered
	And I wanted to use the pun (club penguin-club pangolin: haha)

Description:
	The beginning form is the join screen, from there you can fill in info to create a new account or 
if you already have an existing account, log in using that button. If you choose to continue making 
a new account, you will eventually get a pop up form that requires you to get your parent's permission 
and unless you have that, you cannot use the join button.
ALL LABELS: When the mouse goes over them, the background color changes randomly and they move around
~~Join~~
	AgeDropDown_SelectedIndexChanged: if the given age is greater than 20, alerts the user they are not
					  eligible to join. If they are 20 years or younger and 
					  the Pangolin gender is selected, displays the permisssion form
	InputUser_TextChanged: unless the pangolin option is selsected for gender every time you try to 
			       input data into the username area it forces you to type in the password box
			       NOTE you can still input data in the correct spots if you use the log in form
	PermissionBox_CheckedChanged: when the permission box is checked, allows the join button to be clicked
	InputPass_TextChanged &	
	ConfirmInput_TextChanged: checks to see if the passwords "match"
        			  in order to "match" they must have exactly opposite casings
	LogBackIn_Click: Takes you to the log in form
	JoinButton_Click: if the right conditions are met, continues to the confirmation menu
~~Log In~~
	Forgot_LinkClicked: Gives a helpful message
	Help_LinkClicked: Directs you to a "helpful" video
	Log_Click: logs you into club pangolin
	When the username and password are input, it changes the input text in the main form to match
~~Permission~~
	When the ok button is clicked, checks the permission box on the main form,
		note that this is the only way to access that control
	Only allows the user to allow permission if dad or mom pangolin options are chosen
	Everytime the user inputs a character, an error message pops up to tell the user they have
		caps lock enabled, and only allows them to type in capital letters
~~Confirmation~~
	Prints out the given information in an uneven and incomplete format