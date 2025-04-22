using System.Xml.Serialization;
using System;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;

namespace Task1 // Duplicates

public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> duplicates = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if (!duplicates.Add(nums[i])) {
                return true; // Duplicate found, return true
            }
        }

        return false; // No duplicates found after checking all elements
    }
}

namespace Task2 // anagram comparison

public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] anagramS = s.ToCharArray();
        char[] anagramT = t.ToCharArray();
        Array.Sort(anagramS);
        Array.Sort(anagramT);



        if (anagramS.SequenceEqual(anagramT)) {
            return true;
        }
        return false;
    }
}

namespace Task3 // Roman to integer

public class Solution {
    public int RomanToInt(string s) {

        int result = 0;
        char[] sChar = s.ToCharArray();

        var roman = new Dictionary<char, int>();
    
        roman['I'] = 1;
        roman['V'] = 5;
        roman['X'] = 10;
        roman['L'] = 50;
        roman['C'] = 100;
        roman['D'] = 500;
        roman['M'] = 1000;

        // Здесь мне нужно сделать так, чтобы итеративно проверялось следующее число и если оно больше предыдущего происходил Subtract

            for (int i = 0; i < sChar.Length;){

                if (i < sChar.Length - 1 && roman[sChar[i + 1]] > roman[sChar[i]]) {
                    result += roman[sChar[i + 1]] - roman[sChar[i]];
                    i += 2;
                }
                else if (i < sChar.Length - 1 && roman[sChar[i + 1]] < roman[sChar[i]]) {
                    result += roman[sChar[i]];
                    i++;
                }
                else {
                    result += roman[sChar[i]];
                    i++;
                }

            }
        
        return result;



        
    }
}

namesapce Task4

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var numsDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {

            int need = target - nums[i];

            if (numsDict.ContainsKey(need)) {

                return new int[] {numsDict[need], i};

            }

            numsDict[nums[i]] = i;

        }

        return null;


    }
}

namespace Task5

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> eachWord = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            char[] letterWord = word.ToCharArray();
            Array.Sort(letterWord);
            string sortedWord = new string(letterWord);
            
            if (eachWord.ContainsKey(sortedWord)) {
                eachWord[sortedWord].Add(word);
            }
            else {
                eachWord[sortedWord] = new List<string> { word };
            }
        }

        return eachWord.Values.ToList();

        
        
    }
}

namespace Task6


