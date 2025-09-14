#include "problem_966.h"

#include <algorithm>
#include <unordered_map>
#include <unordered_set>

bool problem_966::test() {
    std::vector<std::string> wordlist { "KiTe", "kite", "hare", "Hare" };
    std::vector<std::string>  queries { "kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto" };

    std::vector<std::string>  expected { "kite", "KiTe", "KiTe", "Hare", "hare", "", "", "KiTe", "", "KiTe" };

    auto result = spellchecker(wordlist, queries);

    print1DVector(result);

    return result == expected;
}

std::vector<std::string> problem_966::spellchecker(std::vector<std::string> &wordlist,
    std::vector<std::string> &queries) {
    std::unordered_set<std::string> exactMatches;
    std::unordered_map<std::string, std::string> caseMatches;
    std::unordered_map<std::string, std::string> vowelMatches;
    for (std::string word : wordlist)
    {
        exactMatches.insert(word);
        std::string lower = word;
        std::transform(lower.begin(), lower.end(), lower.begin(),[](unsigned char c){ return std::tolower(c); });
        if (!caseMatches.contains(lower))
            caseMatches[lower] = word;
        std::string wildcard = wildcardVowels(word);
        if (!vowelMatches.contains(wildcard))
            vowelMatches[wildcard] = word;
    }

    int n = queries.size();
    std::vector<std::string> result(n);
    for (int i = 0; i < n; i++)
    {
        if (exactMatches.contains(queries[i])) {
            result[i] = queries[i];
            continue;
        }
        std::string lower = queries[i];
        std::transform(lower.begin(), lower.end(), lower.begin(),[](unsigned char c){ return std::tolower(c); });
        if (caseMatches.contains(lower)) {
            result[i] = caseMatches[lower];
            continue;
        }
        std::string wildcard = wildcardVowels(queries[i]);
        if (vowelMatches.contains(wildcard)) {
            result[i] = vowelMatches[wildcard];
            continue;
        }
        result[i] = "";
    }

    return result;
}

std::string problem_966::wildcardVowels(std::string word) {
    std::string result = "";
    for (auto c : word)
    {
        c = std::tolower(c);
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            result += '_';
        else
            result += c;
    }

    return result;
}
