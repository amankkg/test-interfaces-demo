using System;

namespace Domain
{
    public interface IInputOutput
    {
        /// <summary>
        /// Caution!!! This method may throw any exception!
        /// </summary>
        /// <returns></returns>
        string Read()
        {
            throw new NotImplementedException();
        }

        void Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
