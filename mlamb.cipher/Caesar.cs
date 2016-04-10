using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mlamb.Cipher
{
/// <summary>
/// Implementation of a basic Caesar or Rotational cipher. Not intended to be secure by any means, use for
/// entertainment purposes only!
/// </summary>
    public static class Caesar
    {
        /// <summary>
        /// Returns a char rotated by position.
        /// </summary>
        /// <param name="letter">The char to rotate.</param>
        /// <param name="position">How many positions to rotate by. Should be positive.</param>
        /// <returns></returns>
        public static char Encrypt(char letter, int position)
        {
            position %= 26;
            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                    return (letter + position) > 90 ? (char)((letter + position) - 26) : (char)(letter + position);
                else
                    return (letter + position) > 122 ? (char)((letter + position) - 26) : (char)(letter + position);
            }
            return letter;
        }
        /// <summary>
        /// Returns a char reverse rotated by position.
        /// </summary>
        /// <param name="letter">The char to rotate.</param>
        /// <param name="position">How many positions to rotate by. Should be positive.</param>
        /// <returns></returns>
        public static char Decrypt(char letter, int position)
        {
            position %= 26;
            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                    return (letter - position) < 65 ? (char)((letter - position) + 26) : (char)(letter - position);
                else
                    return (letter - position) < 97 ? (char)((letter - position) + 26) : (char)(letter - position);
            }
            return letter;
        }
    }
}
