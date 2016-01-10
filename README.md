## Overview
Distilled is a Unity-based exploration leveraging level-of-detail techniques to raise the ceiling on the scale of in-game automation mechanics.

## Motivation
In many games, especially in the part of the sandbox genre where manual resource acquisition is a central aspect of gameplay (e.g. Minecraft, ARK:Survival Evolved), automation is commonly introduced as a means of qualitative progress. Automation not only speeds up resource acquisition, but frees the player to do something other than toil to survive.

I love automation, but I know of no game at this time that introduces more than one layer. Part of this, I believe, is design purity: it's not obvious that a second (or higher) layer of automation would be enjoyable. Another part, the one this project targets, is simply computational feasibility. A complex Minecraft farm seems to tax the game a fair bit, so what would happen if you introduced a "farm of farms"? A "farm of farms of farms"?

## Goal(s)
**Distilled** is simultaneously a game, a research project, and a suite of prototypes.

 - The **game** serves as a sort of controlled toy problem in the space described above.
 - The **research** is into both:
   - How to apply LOD techniques to this space, and
   - Uncovering novel LOD techniques that may better suit the problem.
 - The **prototypes** are of the various techniques, to evaluate how well they mesh with the two (vaguely defined) rubrics of this project:
   - Scalability: a logarithmic measure of how many layers of scalability are possible, and
   - Enjoyment: a fuzzy measure of how much the fun of automation is impinged by a given solution

On this last note, it is my expectation that any solution to this problem will ultimately need to turn to approximation. As with the myrid other corner-cutting approximations employed in the game industry, these approximations will need to be evaluated for whether they impact player enjoyment.

## The Name

The name comes from my intuition that a solution to this problem will require that parts or all of a given player-made automation solution must be _distilled_ into pure, closed-form representations. These distillates can then be arrayed together to form higher-level automations, which can then be distilled again, so on and so forth.
