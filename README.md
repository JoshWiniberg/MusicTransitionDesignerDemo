MUSIC TRANSITION DESIGNER - SAMPLE SCENE

This project contains a very simple sample scene to demonstrate how Music Transition Designer can be used to implement dynamic music in your game.
It requires Music Transition Designer to be installed in order for the music system to run.

-----

OVERVIEW

The scene consists of three locations, each showcasing different genres and MTD features.
The starting area is Cyberpunk, which consists of two area variations (blue and green), and a tension variation (red).
Directly ahead is the Adventure area, which features exploration and combat, with a riser overlay (with a cooldown timer) to bridge the transition.
To the right is the Platformer area, which is a single track. There is a group of coins in this area, with SFX triggers that are quantised to the beat callback.
In each area you can also see beat visualisers which move and change colour in time to the music.

-----

IMPLEMENTATION

Open Tools -> Music Transition Designer -> Asset manager to see how the music is implemented.
Check MtdSceneInitialiser to see how the music system, first SoundBank, and initial States are set on load.
Look at components in the AudioTriggers found in the SampleScene to see how SoundBanks are loaded/unloaded, StateTrees are switched, and how audio can be 
manipulated by changing States.
You can also check the component on the beat visualisers and the coin group to see how to use the beat callback for movement and event synchronisation.

-----

MUSIC LICENSE

All music is copyright and distributed with a for the sole purpose of demoing Music Transition Designer.
It may not be used in other projects, commercial or otherwise, or in any way distributed.

Cyberpunk music by Dave Milln
Adventure music by Josh Winiberg
Platformer music by Josh Winiberg

-----

SUPPORT

If you have any questions or feedback, please get in touch:
contact@joshwiniberg.co.uk

-----

www.musictransitiondesigner.com
www.scoutaudio.co.uk
www.x.com/_scoutaudio
www.instagram.com/scoutaudio
