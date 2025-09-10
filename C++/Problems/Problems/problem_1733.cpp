#include "problem_1733.h"

#include <algorithm>

bool problem_1733::test() {
    int n = 2;
    std::vector<std::vector<int>> languages { { 1 }, { 2 }, { 1, 2 } };
    std::vector<std::vector<int>> friendships { { 1, 2 }, { 1, 3 }, { 2, 3 } };

    int expected = 1;

    int result = minimumTeachings(n, languages, friendships);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1733::minimumTeachings(int n, std::vector<std::vector<int>> &languages,
    std::vector<std::vector<int>> &friendships) {
    int numPeople = languages.size();
    std::unordered_set<int> nonCommon;
    std::vector<std::unordered_set<int>> languagesSets(numPeople, std::unordered_set<int>());
    for (int i = 0; i < numPeople; ++i)
    {
        languagesSets[i] = std::unordered_set<int>(languages[i].begin(), languages[i].end());
    }
    for (auto friendship : friendships)
    {
        if (isCommonLanguage(languagesSets[friendship[0] - 1], languagesSets[friendship[1] - 1]))
            continue;
        nonCommon.insert(friendship[0] - 1);
        nonCommon.insert(friendship[1] - 1);
    }

    std::vector counts(n, 0);
    for (int non : nonCommon)
    {
        for (int language : languages[non])
        {
            counts[language - 1]++;
        }
    }

    return nonCommon.size() - *std::ranges::max_element(counts);
}


bool problem_1733::isCommonLanguage(std::unordered_set<int> languagesFirst, std::unordered_set<int> languagesSecond) {
    for (int lang : languagesFirst)
    {
        if (languagesSecond.contains(lang))
            return true;
    }

    return false;
}
