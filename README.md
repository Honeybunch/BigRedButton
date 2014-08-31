BigRedButton
============

A tiny C# .Net client for applying macros to the DreamCheeky Big Red Button

Working
-------

1. Can Set Macro to fire when a given application is in focus
2. Can give a specific VID and PID to work with; will provide message if not available
3. Can read and even edit the states of the button that macros get fired on

To Do
-----

1. Get it so that multiple macros can be defined
2. Add the ability to fire off external shell script on button press
3. Add the ability to remove macros
4. Fix crash on close when the timer is running
5. Save / Load settings and macro to a file; maybe JSON, maybe YAML, maybe plaintext
