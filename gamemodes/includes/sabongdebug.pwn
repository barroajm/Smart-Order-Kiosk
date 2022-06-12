/*

                   "Sabong System"

				BY: South Gaming
	(created by South Development Team)

	* Copyright (c) 2021, South Gaming
	*
	* All rights reserved.
	*
	* Redistribution and use in source and binary forms, with or without modification,
	* are not permitted in any case.
	*
	*
	* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
	* "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
	* LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
	* A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
	* CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
	* EXEMPLARY, OR CONSEQUENTIAL DAMAGES (playeridNCLUDING, BUT NOT LIMITED TO,
	* PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
	* PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
	* LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (playeridNCLUDING
	* NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
	* SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

#include <a_samp>
#include <Pawn.CMD>
#include <foreach>
#include <sscanf2>

new PlayerText:SabongTD[MAX_PLAYERS][13];

enum sData 
{
   sTotalBetToRed,
   sTotalBetToBlue,
   sPlayerRed,
   sPlayerBlue,
   sRedPercentage,
   sBluePercentage
};
new SabongData[sData];

UpdatePercentage(playerid) // Credits Drizzy
{
    new string[128], string2[128];
    new bluepercent = GetPercentage(SabongData[sTotalBetToRed], SabongData[sTotalBetToBlue]);
    new redpercent = GetPercentage(SabongData[sTotalBetToBlue], SabongData[sTotalBetToRed]);
    
    SabongData[sRedPercentage] = floatround(redpercent, floatround_ceil);
    SabongData[sBluePercentage] = floatround(bluepercent, floatround_ceil);
    
    format(string, sizeof(string), "%i%", floatround(redpercent, floatround_ceil));
    PlayerTextDrawSetString(playerid, SabongTD[playerid][9], string);

    format(string2, sizeof(string2), "%i%", floatround(bluepercent, floatround_ceil));
    PlayerTextDrawSetString(playerid, SabongTD[playerid][12], string2);
    return 1;
}

ResetSabong(playerid)
{
    new string[48], str_2[48];
    
    SabongData[sTotalBetToRed] = 0;
    SabongData[sTotalBetToBlue] = 0;
    SabongData[sPlayerRed] = 0;
    SabongData[sPlayerBlue] = 0;
    SabongData[sRedPercentage] = 0;
    SabongData[sRedPercentage] = 0;
    new bluepercent = GetPercentage(SabongData[sTotalBetToRed], SabongData[sTotalBetToBlue]);
    new redpercent = GetPercentage(SabongData[sTotalBetToBlue], SabongData[sTotalBetToRed]);
	format(string, sizeof(string), "$%i", SabongData[sTotalBetToRed]);
	PlayerTextDrawSetString(playerid, SabongTD[playerid][8], string);
	
	format(string, sizeof(string), "Firstname Lastname #1");
    PlayerTextDrawSetString(playerid, SabongTD[playerid][7], string);
    
    format(string, sizeof(string), "PAYOUT = %i%", floatround(redpercent, floatround_ceil));
	PlayerTextDrawSetString(playerid, SabongTD[playerid][9], string);
	
	format(string, sizeof(string), "$%i", SabongData[sTotalBetToBlue]);
	PlayerTextDrawSetString(playerid, SabongTD[playerid][11], string);
	
	format(string, sizeof(string), "Firstname Lastname #2");
    PlayerTextDrawSetString(playerid, SabongTD[playerid][10], string);
    
    format(str_2, sizeof(str_2), "PAYOUT = $%i", floatround(bluepercent, floatround_ceil));
	PlayerTextDrawSetString(playerid, SabongTD[playerid][12], str_2);
}

GetPercentage(value, tvalue)
{     
	return floatround(floatmul(float(value) / float(tvalue) , 100.0));
}

// Commands
CMD:sfighter(playerid, params[]) return callcmd::setfighter(playerid, params);
CMD:setfighter(playerid, params[])
{
    new targetid, string[256], option[32];
    if(PlayerInfo[playerid][pAdmin] < 7 && !IsPlayerAdmin(playerid))
	{
	    return SCM(playerid, COLOR_SYNTAX, "You are not authorized to use this command.");
	}
	if(!PlayerInfo[targetid][pLogged])
	{
	    return SCM(playerid, COLOR_SYNTAX, "That player hasn't logged in yet.");
	}
	if(targetid == INVALID_PLAYER_ID)
	{
	    return SCM(playerid, COLOR_GREY, "Error:"WHITE" Invalid player specified.");
	}
	if(PlayerInfo[targetid][pMeron] > 1 || PlayerInfo[targetid][pWala] > 1)
	{
	    return SendClientMessage(playerid, COLOR_GREY2, "That player is already a cock");
	}
    if(sscanf(params, "us[10]S()[32]", targetid, option))
	{
	    SCM(playerid, COLOR_SYNTAX, "Tips: /setfighter [playerid] [option]");
	    SCM(playerid, COLOR_WHITE, "Available Options: Meron, Wala");
	}
	else if(!strcmp(option, "meron", true))
	{
	     SabongData[sPlayerRed] = 1;
	     SetPlayerHealth(targetid, 100);
	     SetScriptArmour(targetid, 100);
	     SetPlayerSkin(targetid, 167);
	     TeleportToCoords(targetid, 834.666503, -2044.881469, 15.193875, 0.0000, 0, 0);
	     SendMessageToAll(COLOR_YELLOW, "%s has been set as Meron Manok by admin", GetRPName(targetid));
	     SendClientMessage(targetid, COLOR_WHITE, "Don't make any damage to your enemy, unless admin start the game");
	
	     foreach(new i : Player)
		 {
		     format(string, sizeof(string), "%s", GetRPName(targetid));
		     PlayerTextDrawSetString(playerid, SabongTD[playerid][7], string);
		 }
	}
	else if(!strcmp(option, "wala", true))
	{
	     SabongData[sPlayerBlue] = 1;
	     SetPlayerHealth(targetid, 100);
	     SetScriptArmour(targetid, 100);
	     SetPlayerSkin(targetid, 167);
	     TeleportToCoords(targetid, 837.887023, -2045.058349, 15.193875, 0.0000, 0, 0);
	     SendMessageToAll(COLOR_YELLOW, "%s has been set as Wala Manok by admin", GetRPName(targetid));
	
	     foreach(new i : Player)
		 {
		     format(string, sizeof(string), "%s", GetRPName(targetid));
		     PlayerTextDrawSetString(playerid, SabongTD[playerid][10], string);
		 }
	}
	return 1;
}

CMD:ssabong(playerid, params[]) return callcmd::startsabong(playerid, params);
CMD:startsabong(playerid, params[])
{
    if(PlayerInfo[playerid][pAdmin] < 5)
	{
	    return SCM(playerid, COLOR_SYNTAX, "You are not authorized to use this command.");
	}
	
	if(!startsabong)
	{
	    SendMessageToAll(COLOR_YELLOW, "The Sabong Event has been enabled follow the checkpoint on your map.");
	    foreach(new i : Player)
		{
		    startsabong = 1;
		    betstatus = 0;
		    SetPlayerCheckpoint(playerid, 836.184082,-2019.534301,12.867187, 3.0);
		}
	}
	else
	{
	    SendMessageToAll(COLOR_YELLOW, "The Sabong Event has been disabled by Admin.");
	    foreach(new i : Player)
		{
		    startsabong = 0;
		    betstatus = 0;
		    CancelActiveCheckpoint(playerid);
		    ResetSabong(playerid);
		}
	}
	return 1;
}

CMD:taya(playerid, params[])
{
    if(!startsabong)
    {
	    SendClientMessage(playerid, COLOR_SYNTAX, "The Sabong Event is disabled");   
        betstatus = 1;
        startsabong = 1;
	    PlayerTextDrawShow(playerid, SabongTD[playerid][0]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][1]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][2]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][3]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][4]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][5]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][6]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][7]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][8]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][9]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][10]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][11]);
	    PlayerTextDrawShow(playerid, SabongTD[playerid][12]);
	    }
	}
	else
	{
	    betstatus = 0;
        startsabong = 0;
		PlayerTextDrawHide(playerid, SabongTD[playerid][0]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][1]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][2]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][3]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][4]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][5]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][6]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][7]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][8]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][9]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][10]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][11]);
	    PlayerTextDrawHide(playerid, SabongTD[playerid][12]);
    }
	return 1;
}

CMD:bet(playerid, params[])
{
    new option[32], string[256];
    new amount;
    
    if(!startsabong)
	{
	    return SCM(playerid, COLOR_SYNTAX, "The Sabong Event is disabled at the moment.");
	}
	        
	if(!betstatus)
	{
	    return SCM(playerid, COLOR_SYNTAX, "The Betting command is disabled at the moment.");
	}
	if(PlayerInfo[playerid][pMeron] > 1 && PlayerInfo[playerid][pWala] > 1)
	{
	    return SendClientMessage(playerid, COLOR_SYNTAX, "You're a chicken, Therefore you cant bet");
	}
	if(sscanf(params, "s[14]i", option, amount))    
    {
	    SCM(playerid, COLOR_SYNTAX, "Tips: /bet [option] [amount]");
	    SCM(playerid, COLOR_WHITE, "Available Options: Meron/Wala");
	    SCM(playerid, COLOR_WHITE, "To Toggle Textdraws use /taya");
	}
	
    else if(!strcmp(option, "meron", true))
	{
	    if(amount > PlayerInfo[playerid][pCash])
	    { 
		    SendClientMessage(playerid, COLOR_SYNTAX, "You don't have that much.");
		}
		if(!(1 <= amount <= 1000000))
	    {
		    SendClientMessage(playerid, COLOR_SYNTAX, "Don't go below $1, or above $1,000,000 at once.");
		}
	    if(amount < 1)
	    {
	       SendClientMessage(playerid, COLOR_SYNTAX, "Invalid amount");
	    }
		PlayerInfo[playerid][pCash] -= amount;
		SabongData[sTotalBetToRed] += amount;
		PlayerBetSaMeron[playerid] = amount;
		PlayerRefundSaMeron[playerid] = amount;
		nakabetsameron[playerid] = 1;
		SendMessage(playerid, COLOR_YELLOW, "You've place your bet to "RED"Meron "YELLOW"for $%d", amount);
		
		foreach(new i : Player)
		{
		    format(string, sizeof(string), "$%i", SabongData[sTotalBetToRed]);
			PlayerTextDrawSetString(playerid, SabongTD[playerid][8], string);
		}
		UpdatePercentage(playerid);
	}
	else if(!strcmp(option, "wala", true))
	{
	    if(amount > PlayerInfo[playerid][pCash])
	    { 
		    SendClientMessage(playerid, COLOR_SYNTAX, "You don't have that much.");
		}
		if(!(1 <= amount <= 1000000))
	    {
		    SendClientMessage(playerid, COLOR_SYNTAX, "Don't go below $1, or above $1,000,000 at once.");
		}
	    if(amount < 1)
	    {
	       SendClientMessage(playerid, COLOR_SYNTAX, "Invalid amount");
	    }
	    PlayerInfo[playerid][pCash] -= amount;
	    SabongData[sTotalBetToBlue] += amount;
		PlayerBetSaWala[playerid] = amount;
		PlayerRefundSaWala[playerid] = amount;
		nakabetsawala[playerid] = 1;
		SendMessage(playerid, COLOR_YELLOW, "You've place your bet to "BLUE"Wala "YELLOW"for $%d", amount);
		
		foreach(new i : Player)
		{
		    format(string, sizeof(string), "$%i", SabongData[sTotalBetToBlue]);
			PlayerTextDrawSetString(playerid, SabongTD[playerid][11], string);
		}
		UpdatePercentage(playerid);
	}
	return 1;
}

CMD:betstatus(playerid, params[])
{
	if(PlayerInfo[playerid][pAdmin] < 5)
    {
		return SCM(playerid, COLOR_SYNTAX, "You are not authorized to use this command.");
    }
    if(!startsabong)
    {
	    SendClientMessage(playerid, COLOR_SYNTAX, "The Sabong Event is disabled");
	}
	
	if(!betstatus)
	{
	    betstatus = 1;
	    SMA(SERVER_COLOR, "(( Administrator %s enabled the betting system. ))", GetRPName(playerid));
	    SendMessageToAll(COLOR_YELLOW, "The Betting system has been open by Administrator, you can now place your bet");
	}
	else
	{
	    betstatus = 0;
	    SMA(SERVER_COLOR, "(( Administrator %s disabled the betting system. ))", GetRPName(playerid));
	    SendMessageToAll(COLOR_YELLOW, "The betting system has been closed by Administrator, Goodluck");
	}
    return 1;
}