#include "problem_679.h"

bool problem_679::test() {
    std::vector cards =  { 1, 9, 1, 2 };

    auto expected = true;

    auto result = judgePoint24(cards);

    return expected ==  result;
}

bool problem_679::judgePoint24(std::vector<int> &cards) {
    std::vector<double> cards2;
    for (auto card : cards)
        cards2.push_back(card);
    return judgePoint24Rec(cards2);
}

bool problem_679::judgePoint24Rec(std::vector<double> &cards) {
    auto n = cards.size();
    if (n == 1)
    {
        if (std::abs(cards[0] - 24) < 1e-5)
            return true;
        return false;
    }

    for (int i = 0; i < n; ++i)
    {
        auto a = cards[i];
        for (int j = 0; j < n; ++j) {
            if (i == j)
                continue;
            auto b = cards[j];
            std::vector<double> possibleResults;
            std::vector<double> remaining;
            for (int k = 0; k < n; ++k)
            {
                if (k != i && k != j)
                    remaining.push_back(cards[k]);
            }
            possibleResults.push_back(a + b);
            possibleResults.push_back(a - b);
            possibleResults.push_back(a * b);
            if (a != 0)
                possibleResults.push_back(a / b);
            if (b != 0)
                possibleResults.push_back(b/ a);
            for (auto poss : possibleResults)
            {
                remaining.push_back(poss);
                if (judgePoint24Rec(remaining))
                    return true;
                remaining.pop_back();
            }
        }
    }

    return false;
}
