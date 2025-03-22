using System;
using System.Collections.Generic;

public class RandomizedSet {
    // قائمة لتخزين العناصر
    private List<int> data;
    // قاموس لتخزين الفهرس لكل عنصر
    private Dictionary<int, int> indexMap;
    // مولد أرقام عشوائية
    private Random rand;

    /** Initializes the RandomizedSet object. */
    public RandomizedSet() {
        data = new List<int>();
        indexMap = new Dictionary<int, int>();
        rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(indexMap.ContainsKey(val))
            return false; // العنصر موجود مسبقًا

        // إضافة العنصر للقائمة وتخزين موقعه في القاموس
        indexMap[val] = data.Count;
        data.Add(val);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(!indexMap.ContainsKey(val))
            return false; // العنصر غير موجود

        // الحصول على الفهرس للعنصر الذي نريد حذفه
        int idxToRemove = indexMap[val];
        // الحصول على آخر عنصر في القائمة
        int lastElement = data[data.Count - 1];

        // استبدال العنصر الذي سيتم حذفه بآخر عنصر
        data[idxToRemove] = lastElement;
        indexMap[lastElement] = idxToRemove;

        // حذف آخر عنصر (المكرر) من القائمة وإزالة العنصر من القاموس
        data.RemoveAt(data.Count - 1);
        indexMap.Remove(val);
        
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        int index = rand.Next(data.Count);
        return data[index];
    }
}