# 2016 Oculus Rift
[Robot Code](https://github.com/frc1418/2016-robot) | [UI](https://github.com/frc1418/2016-UI) | [Image Processing](https://github.com/frc1418/2016-vision) | **Oculus Rift**

We used this code to power the Oculus Rift which we used for driving during the 2016 FIRST World Championship in St. Louis.

Most of this code was developed last year, however, we were not allowed to use the Oculus in competition due to a FIRST rule against objects covering the driver's eyes.

This year, to get around this rule, we mounted the Oculus on a pole on our driverstation, and our driver bent down and looked into it whenever necesary. Since we were treating the device as a secondary display, this was completely legal.

This code  was developed in the 3D game development platform Unity, which ships with good Oculus integration.

This project requires Unity Pro for compilation. Unity Pro licenses were generously provided to our team by Unity Technologies.

**If you do not own a Unity Pro license you are in luck! See our 1.0 release that has compiled binaries: [here](https://github.com/frc1418/2015-oculus/releases/tag/1.0)**

**Checkout our whitepaper for pictures and video [here](https://docs.google.com/document/d/1-8BB0rzydTxpMA9buoe7J2LLSpy6g8wTbeJXNPeNb_0/).**

## Features
Features and technical explanation TODO

## Simulation

If you would like to run this program to see some moving parts it does work with
the PyFRC simulator. To make this work you must have pyfrc installed (through pip3),
python3, and you must clone our [UI](https://github.com/frc1418/2016-UI) and [Robot code](https://github.com/frc1418/2016-robot). Once you have all of this installed
you can run our simulated robot code with:

	cd 2016-robot/robot/
	python3 robot.py sim

You must also run our driverstation client/server with:

	cd 2016-UI/
	python3 driverStationServer.py

If you would like this simulation to work with joysticks you must install a python
module called PyGame. This any joysticks plugged into the computer to be accessed.


## Authors
* [Carter Fendley](https://github.com/CarterFendley)
* [Dustin Spicuzza](https://github.com/virtuald), mentor
