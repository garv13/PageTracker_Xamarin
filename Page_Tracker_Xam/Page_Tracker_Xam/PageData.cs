using System;
using System.Collections.Generic;
using System.Text;

namespace Page_Tracker_Xam
{
    class PageData
    {
        public string Checksum { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

        public int RefreshMinutes { get; set; }

        public DateTime LastRefreshTime { get; set; }

        public bool IsRefresh {
            get {
                if (LastRefreshTime.AddMinutes(RefreshMinutes) >= DateTime.Now)
                    return true;
                else
                    return false;
            }
            set {
                throw new Exception("Not Settable");
            }
        }
    }
}
