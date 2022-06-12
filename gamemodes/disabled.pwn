#include <a_samp>

public OnPlayerCommandText(playerid, cmdtext[])
{
	if(!strcmp(cmdtext, "/r", true))
    {
        SendClientMessage(playerid, 0xFFFFFFFF, "SERVER: Paintball is Currently Disabled.");
        return 1;
    }
    if(!strcmp(cmdtext, "/radio", true))
    {
        SendClientMessage(playerid, 0xFFFFFFFF, "SERVER: Paintball is Currently Disabled.");
        return 1;
    }
    return 0;
}