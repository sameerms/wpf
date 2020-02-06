using System.Collections.Generic;

namespace Receive
{
    public class UserSaveFeedback
    {

        public int successCount { get; set; }

        public int failedCount { get; set; }

        public List <User> failedList { get; set; }
    }
}