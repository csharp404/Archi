﻿namespace RESProject.Models.Models
{
    
    
        public class Favorite
        {

            public string UserID { get; set; }
            public User User { get; set; }

            public string RealESID { get; set; }
            public RealES RealES { get; set; }
        }
    

}
