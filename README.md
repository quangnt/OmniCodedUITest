OmniCodedUITest
===============
Project link:
https://github.com/quangnt/OmniCodedUITest.git

===============
Note
	1. Create UIMap class for each Personify GUI dialog(Separte Main dialog and sub dialog in 2 different UIMap file) and put it in UIMap folder
		a. How to create UIMap class: Right click in UIMap folder, choose Add->New
		->Select "Test" in left panel -> Select "Coded UI Test Map" in right Panel
		b. Name the UIMap as <FeatureDialog>+UIMap.uitest ( EX: LoginUIMap.uitest)
		c. Add common functions for each class in UIMap.uitest in file <FeatureDialog>UIMap.cs
		(Ex: login(username,pass) in LoginUIMap.cs(not add function code to LoginUIMap.Design.cs 
		it will be lost each time generate test code)
		d. Created some common class SignUpUIMap.uitest, LoginUIMap.uitest, InstallerUIMap.uitest,
		MainControlPanel.uitest	corresponding to new GUI design(Build 27-11-2014 receive from Huy)
	
			
