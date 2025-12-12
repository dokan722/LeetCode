#include "problem_383.h"

bool problem_383::test() {
    std::string ransomNote = "a";
    std::string magazine = "b";

    bool expected = false;

    auto result = canConstruct(ransomNote, magazine);

    return expected == result;
}

bool problem_383::canConstruct(std::string ransomNote, std::string magazine) {
    std::vector ransomCount(26, 0);
    std::vector magazineCount(26, 0);
    for (auto c : ransomNote)
        ransomCount[c - 'a']++;
    for (auto c : magazine)
        magazineCount[c - 'a']++;
    for (int i = 0; i < 26; ++i)
    {
        if (ransomCount[i] > magazineCount[i])
            return false;
    }

    return true;
}
