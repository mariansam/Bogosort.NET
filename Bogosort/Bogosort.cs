using System;
using System.Collections.Generic;

namespace Bogosort
{
    public static class Bogosorter
    {
        /// <summary>
        /// The best sorting algorithm ever created!
        /// </summary>
        /// <param name="list">The list you want to sort</param>
        /// <typeparam name="T">An IComparable, usally int</typeparam>
        public static void Bogosort<T>(this IList<T> list) where T : IComparable
        {
            if (list is null)
                throw new ArgumentNullException(nameof(list));

            while (!list.IsSorted())
                list.Shuffle();
        }

        private static bool IsSorted<T>(this IList<T> list) where T : IComparable
        {
            if (list.Count <= 1)
                return true;
            
            for (int i = 1; i < list.Count; i++)
                if (list[i].CompareTo(list[i - 1]) < 0)
                    return false;

            return true;
        }

        private static void Shuffle<T>(this IList<T> list) where T : IComparable
        {
            Random ran = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                int index = ran.Next(list.Count);
                T value = list[index];
                list[index] = list[i];
                list[i] = value;
            }
        }
    }
}