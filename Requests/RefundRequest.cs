﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Integration.PragmaticPlay.Requests
{
    public class RefundRequest : Request
    {
        /// <summary>
        /// Identifier of the user within the Casino Operator’s system.
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// Unique reference of this transaction.
        /// </summary>
        public string Reference { get; set; }
        
        
        //mandatory FRB
        /// <summary>
        /// Id of the bonus in Casino Operator system.
        /// (*is mandatory in case of FRB API is implemented)
        /// </summary>
        public string BonusCode { get; set; }


        //dedi
        /*
        /// <summary>
        /// Hash code of the request.
        /// </summary>
        public string Hash { get; set; }
        /// <summary>
        /// Game Provider ID.
        /// </summary>
        public string ProviderId { get; set; }
        /// <summary>
        /// Token of the player from Authenticate response.
        /// </summary>
        public string Token { get; set; }
        */


        //nepotrebne
        /*
        //optional
        /// <summary>
        /// The platform type (channel) on which the game is played.
        /// Possible values: “MOBILE” – mobile device, “WEB” – desktop device, “DOWNLOAD” – downloadable client.
        /// </summary>
        public string Platform { get; set; }
        /// <summary>
        /// Amount of the win.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// ID of the game.
        /// </summary>
        public string GameId { get; set; }
        /// <summary>
        /// ID of the round.
        /// </summary>
        public long RoundId { get; set; }
        /// <summary>
        /// Date and time when the transaction is processed on the Pragmatic Playside.
        /// (Unix epoch time in milliseconds, for example : 1470926696715)
        /// </summary>
        public long TimeStamp { get; set; }
        /// <summary>
        /// Additional information about the current game round.
        /// </summary>
        public string RoundDetails { get; set; }
        */
    }
}
