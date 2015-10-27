# Contents #



There are also [screenshots](ScoreKeeperScreenshots.md).

# Introduction #

This software is intended for scoring FLL tournaments.  It is currently designed for the 2008 tournament (Climate Connections).  There are likely to be versions for future years.

This software is not associated with the FIRST organization.  It was written as a purely personal effort to assist in local scoring the the NCaFLL area.


# Install #

  1. Download the [latest zip file](http://code.google.com/p/scorer/downloads/list).
  1. Unzip; there should be ScoreKeeper.exe along with a scoresheet for use by referees.
  1. Make sure a minimum of .NET framework 2.0 is installed.  You can get the latest version of the .NET framework from [Microsoft](http://msdn.microsoft.com/en-us/netframework/default.aspx).

No additional setup should be necessary; just run `ScoreKeeper.exe` to start the application.


# Running ScoreKeeper #

On startup, you will be prompted with the two modes ScoreKeeper can run in.  Your primary machine, where you enter scores, is the server.  If you use a second machine for display scores, it is the client.

Port 80 is used by default for all communications.  If you have an issue with this port, try another port value, such as 8000 or 8080.

# Score Entry (Server) #

## Event Setup ##

Generally, this should be done prior to an event.  This prepares the information so that you'll be able to use it later.

  1. Choose a file to save team and score information to.
    1. Click on "Select File..." to open the file dialog.
    1. Choose a name for the new .xml file for your event (eg, `RegionalChampionship.xml`)
      * Each file should only contain information for one event.  If moving between events, change files.
    1. Click on "Open" to create the file.
    * This process can also be used to re-open a file you were using previously.
    * Once the file is selected, data will be saved automatically after each change.
  1. Add teams for your event.
    1. Click on "Add/Remove Teams..." to open the team dialog.
    1. For each team:
      1. Click on "Add".
      1. Add the team number and name.
    1. Once you're done adding teams, click on "OK".
    * Once the team entry is finished, the "Team" dropdown should have the complete list of teams.
  1. Choose the number of rounds for your event.
    * Events may be 3 to 5 rounds.
    * Scores for all rounds are counted when determining ranking.

## Entering Scores ##

  1. Select the team whose scores will be entered.
    * Question marks ("?") will show up on rounds where teams don't have scores.
  1. For each item on the scoresheet, make the corresponding selection on the event list.
    * As you click on items, you can watch the score field change as appropriate.
    * The red message at the bottom of the score entry indicates missing or invalid score data.
    * You will know you are done entering scores because no red message will show at the bottom.
  1. Once the score entry is complete, the "Set Score" buttons will enable on the left side of the window, beneath the teams.  Click on the button for the appropriate round.
    * After setting the score, inputs will automatically reset to zero.

## Auditing Scores ##

  * You may load scores in order to verify correct entry using the "Load" button for a round.
    * This loads previous input into the score entry.
    * If changes are made, use the "Set Score" button to save changes to a round.
  * You may also use the "Clear" button to remove a round's input from a team.


# Scoreboard (Client) #

## Connecting to the Score Entry (Server) ##

  1. From the startup page, click on the "Scoreboard (Client)" radio button.
  1. In the "Host" field, enter the name or IP of the machine the server is running on.
    * If you're not sure what to enter:
      1. Go to the Score Entry (Server) application on the primary machine.
      1. Click on "Show IP..."
      1. Both your Hostname and one or more IPs will be listed here.  The IPs will look like "192.168.1.102".
      1. Try the various Hostname and IP values in the "Host" field you see on the client.  You'll know it's working if you see the teams show up when the scoreboard starts.
  1. In the "Port" field, make sure it matches what was selected on the server.

## Scoreboard Display ##

The scoreboard display can be accessed one of two ways; either running in "Scoreboard (Client)" mode, or clicking on the "Scoreboard..." button while in "Scoreboard (Server)" mode.

To customize the display mode, use the right mouse button to click anywhere on the scoreboard.  This displays the following options:

  * **Full Screen**:  If checked, the scoreboard will display full screen.  It is recommended you check this as part of setting up the scoreboard.
  * **Refresh Now**:  If the automatic refresh appears to be taking too long, you may use this to force an immediate refresh.
  * **Font Size**:  This modifies the font size of the scoreboard, which changes how many teams will be displayed at once.
  * **Cycle Time**:  If there are too many teams to see everyone at once, the scoreboard will slowly cycle through them.  This modifies the speed of the rotation.
  * **Logo Size**: May be used to change the size of the corner logos for differently sized screens, if preferred.
  * **Corner Logos**:  If checked, the FLL logo will show in the top left and right corners.  If unchecked, a flat color will be displayed instead, to allow for chroma key based overlays.
  * **Corner Color...**:  This opens up a dialog to select a new chroma key for the corners.  By default, the corners are R=0, G=254, B=0.
  * **Show Status**:  If checked, a small status message noting the last time the scoreboard got scores from the server will be shown at the bottom of the window.  Normally, scores will be fetched roughly once per minute.  If this message is black, everything is fine.  If this message is orange, the connection may have been lost.


# Scores over HTTP #

ScoreKeeper uses an HTTP server for its main port.  People on your network can access the scores via `http://<host>:<port>`.