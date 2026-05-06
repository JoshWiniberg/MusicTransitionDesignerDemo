<b>MUSIC TRANSITION DESIGNER - SAMPLE PROJECT</b>

This project contains a very simple sample scene to demonstrate how Music Transition Designer can be used to implement dynamic music in your game.<br>
<br>
It requires Music Transition Designer to be installed in order for the music system to run.

-----

<b>INSTALLATION</b>

Install Unity 6000.3.8f1<br>
<br>
Clone the repo. When you try to open it you will get a warning to say that a package is missing. Ignore and dismiss the warnings and open the project normally.<br>
<br>
Next, install Music Transition Designer. The broken references will be fixed and the project should compile.<br>
<br>
You can now open the Sample Scene.

-----

<b>OVERVIEW</b>

The scene consists of three locations, each showcasing different genres and MTD features.<br>
<br>
The starting area is Cyberpunk, which consists of two area variations (blue and green), and a tension variation (red).<br>
<br>
Directly ahead is the Adventure area, which features exploration and combat, with a riser overlay (with a cooldown timer) to bridge the transition.<br>
<br>
To the right is the Platformer area, which is a single track. There is a group of coins in this area, with SFX triggers that are quantised to the beat callback.<br>
<br>
In each area you can also see beat visualisers which move and change colour in time to the music.

-----

<b>REVIEW IMPLEMENTATION</b>

Open Tools -> Music Transition Designer -> Asset Manager to see how the music is implemented.<br>
<br>
Check MtdSceneInitialiser to see how the music system, first SoundBank, and initial States are set to load when the scene first initialises.<br>
<br>
Look at components in the AudioTriggers found in the SampleScene to see how SoundBanks are loaded/unloaded, StateTrees are switched, and how audio can be manipulated by changing States.<br>
<br>
You can also check the components on the beat visualisers and the coin group to see how to use the beat callback for movement and event synchronisation.

-----

<b>MUSIC LICENSE</b>

All music is copyright and distributed with for the sole purpose of demoing Music Transition Designer.<br>
It may not be used in other projects, commercial or otherwise, or in any way distributed.<br>
<br>
Cyberpunk music by Dave Milln<br>
Adventure music by Josh Winiberg<br>
Platformer music by Josh Winiberg

-----

<b>SUPPORT</b>

If you have any questions or feedback, please get in touch:<br>
contact@joshwiniberg.co.uk

-----

www.musictransitiondesigner.com<br>
www.scoutaudio.co.uk<br>
www.x.com/_scoutaudio<br>
www.instagram.com/scoutaudio
