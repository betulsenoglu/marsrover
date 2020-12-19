using System;

namespace MarsRover.Utility.Shared
{
    public class Guard
    {
        /// <summary>
        /// Parametre değeri null gelirse ArgumentNullException fırlatır.
        /// </summary>
        /// <param name="param"></param>
        /// <param name="message"></param>
        public static void AgainstNullArgument(object param, string message)
        {
            if (param == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}