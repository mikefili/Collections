﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Deck<T> : IEnumerable<T>
    {
        public T[] cardsInDeck = new T[1];
        int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex > cardsInDeck.Length - 1)
            {
                Array.Resize(ref cardsInDeck, cardsInDeck.Length + 1);
            }
            cardsInDeck[currentIndex] = item;
            currentIndex++;
        }

        public void Remove(T item)
        {
            cardsInDeck[currentIndex] = item;
        }

        public int Count(T item)
        {
            return currentIndex;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < cardsInDeck.Length; i++)
            {
                yield return cardsInDeck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
