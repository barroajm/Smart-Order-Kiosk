#if defined _dc_dccmd_included
  #endinput
#endif
#define _dc_dccmd_included

// Macros
#define SendDC  DCC_SendChannelMessage
#define DCMD    DCCMD
#define DC_CMD  DCCMD
#define DCCMD:%0(%1,%2,%3) forward dc_cmd_%0(%1,%2,%3[]); public dc_cmd_%0(%1,%2,%3[])

forward DCC_OnCommandPerformed(args[], success);

public DCC_OnMessageCreate(DCC_Message:message){
    new raw_message[2048];
    new bool:IsBot;
    new DCC_Channel:channel, DCC_User:author;

    DCC_GetMessageContent(message, raw_message);
    DCC_GetMessageChannel(message, channel);
    DCC_GetMessageAuthor(message, author);
    DCC_IsUserBot(author, IsBot);
    
    if(!IsBot){
        new dmsg[10][128];
        new command[16], args[50];

        explode(dmsg, raw_message, " ", 2);
        sscanf(raw_message, "s[16]S()[50]", command, args);

        if(strfind(command, "-", true) == 0){
            new funcdc[128];
            strdel(command, 0, 1);
            format(funcdc, sizeof(funcdc), "dc_cmd_%s", command);

            if(isnull(dmsg[1])) {
                CallLocalFunction("DCC_OnCommandPerformed", "si", raw_message, CallLocalFunction(funcdc, "iis", _: channel, _: author, "\1"));
            }
            else{
                CallLocalFunction("DCC_OnCommandPerformed", "si", raw_message, CallLocalFunction(funcdc, "iis", _: channel, _: author, args));
            }
        }
    }
    return 1;
}

static explode(aExplode[][], const sSource[], const sDelimiter[] = " ", iVertices = sizeof aExplode, iLength = sizeof aExplode[]){
    new iNode, iPointer, iPrevious = -1, iDelimiter = strlen(sDelimiter);

    while(iNode < iVertices){
        iPointer = strfind(sSource, sDelimiter, false, iPointer);
        if(iPointer == -1){
            strmid(aExplode[iNode], sSource, iPrevious, strlen(sSource), iLength);
            break;
        }
        else{
            strmid(aExplode[iNode], sSource, iPrevious, iPointer, iLength);
        }
        iPrevious = (iPointer += iDelimiter);
        ++iNode;
    }
    return iPrevious;
}