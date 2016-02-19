using LobbyManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LobbyManager.App_Start
{
    public static class API_Variables
    {
        
        #region SMS Account
            public static string SMS_API = ConfigKey.DecodeConfigEnvironmentVariable("TwilioAPI");
            public static string SMS_Phrase = ConfigKey.DecodeConfigEnvironmentVariable("TwilioPhrase");
            public static string SMS_Number = ConfigKey.DecodeConfigEnvironmentVariable("TwilioNumber");
        #endregion
        #region Email Account
            public static string Sendgrid_API = ConfigKey.DecodeConfigEnvironmentVariable("SendgridAPI");
            public static string EmailAddress = ConfigKey.DecodeConfigEnvironmentVariable("EmailAddress");
        #endregion
        #region GoogleOAuth
            public static string GoogleOAuth = ConfigKey.DecodeConfigEnvironmentVariable("GoogleOAuth");
            public static string GooglePhrase = ConfigKey.DecodeConfigEnvironmentVariable("GooglePhrase");
        #endregion
        #region FacebookOAuth
            public static string FacebookOAuth = ConfigKey.DecodeConfigEnvironmentVariable("FacebookOAuth");
            public static string FacebookPhrase = ConfigKey.DecodeConfigEnvironmentVariable("FacebookPhrase");
        #endregion


        /*
        bm9pZ2VyZG5lIyAgICAgICAgCg07KSI9RW1Oek1HTTFFRFoxVVRNaUJUWXpVak55TVdPd0VHWmxSMk54RVROMkVUWiIoZWRvY2VELnllS2dpZm5vQyA9IGVzYXJoUGtvb2JlY2FGIGduaXJ0cyBjaXRhdHMgY2lsYnVwICAgICAgICAKDTspInhrVE4xZ3pOeUF6TjBZak54QVRNIihlZG9jZUQueWVLZ2lmbm9DID0gaHR1QU9rb29iZWNhRiBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg1odHVBT2tvb2JlY2FGIG5vaWdlciMgICAgICAgIAoNbm9pZ2VyZG5lIyAgICAgICAgCg07KSIwZDNZTVZXWVJsVlFSRkRWRlZWVVF4a1UzWUZSVU5HVSIoZWRvY2VELnllS2dpZm5vQyA9IGVzYXJoUGVsZ29vRyBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg07KSIwRURPekF6TjJVRE93QURPdDBHY3dZek51aDJOMkVHY29SbmIxTkdNeWdXWnNKSGNrWmpkaUJIY21kRGJ1RUdjd05uTG45MmJueFdaMU5YWnlOMmJ1UlhadVJuTGo5V2IiKGVkb2NlRC55ZUtnaWZub0MgPSBodHVBT2VsZ29vRyBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg1odHVBT2VsZ29vRyBub2lnZXIjICAgICAgICAKDW5vaWdlcmRuZSMgICAgICAgIAoNOykiaFJXYnA1R1F0SjNiaTlHZHBOMmNzRm1MajlXYiIoZWRvY2VELnllS2dpZm5vQyA9IHNzZXJkZEFsaWFtRSBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg07KSJUZGtMSVpFUklSbll2WkZWS2xHYTVBRFV2aG1hdDAwWTM1Q1p5MDBOWkowTlZablcxUWpZQjlWUXROVk1XcFZhM0JUWUlSVGR1VjBOckJGU29Ka1Z4a0hldElYUyIoZWRvY2VELnllS2dpZm5vQyA9IElQQV9kaXJnZG5lUyBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg10bnVvY2NBIGxpYW1FIG5vaWdlciMgICAgICAgIAoNbm9pZ2VyZG5lIyAgICAgICAgCg07KSJyRWpNd0VETzBrRE80UUROIihlZG9jZUQueWVLZ2lmbm9DID0gcmVibXVOX1NNUyBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg07KSI9UVdOeVVUWXhZbU5tQlRNMkVUT3dnalkzQVROa2RUWmpCVE4wTVdPa1ZXWSIoZWRvY2VELnllS2dpZm5vQyA9IGVzYXJoUF9TTVMgZ25pcnRzIGNpdGF0cyBjaWxidXAgICAgICAgIAoNOykiPT1RUURKR05sbGpNNGNEWmxKRE8zWXpNeGd6TjJRMk5tTldaaVJEWmxGek1oRnpZIihlZG9jZUQueWVLZ2lmbm9DID0gSVBBX1NNUyBnbmlydHMgY2l0YXRzIGNpbGJ1cCAgICAgICAgCg10bnVvY2NBIFNNUyBub2lnZXIj
        */
    }
}