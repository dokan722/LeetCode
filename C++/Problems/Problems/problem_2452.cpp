#include "problem_2452.h"

bool problem_2452::test() {
    std::vector<std::string> queries { "word", "note", "ants", "wood" };
    std::vector<std::string> dictionary { "wood", "joke", "moat" };

    std::vector<std::string> expected { "word", "note", "wood" };

    auto result = twoEditWords(queries, dictionary);

    print1DVector(result);

    return expected == result;
}

std::vector<std::string> problem_2452::twoEditWords(std::vector<std::string> &queries,
    std::vector<std::string> &dictionary) {
    int n = dictionary.size();
    std::vector<std::string> result;
    for (auto query : queries)
    {
        bool found = false;
        for (auto word : dictionary)
        {
            if (query.size() != word.size())
                continue;
            int l = query.size();
            int diff = 0;
            for (int i = 0; i < l && diff <= 2; ++i)
            {
                if (word[i] != query[i])
                    diff++;
            }
            if (diff <= 2)
            {
                found = true;
                break;
            }
        }
        if (found)
            result.push_back(query);
    }
    return result;
}
