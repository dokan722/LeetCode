#include "problem_1111.h"

bool problem_1111::test() {
    std::string seq = "(()())";

    std::vector expected { 0, 1, 0, 0, 1, 0 };

    auto result = maxDepthAfterSplit(seq);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1111::maxDepthAfterSplit(std::string seq) {
    int n = seq.size();
    int os = 0;
    int es = 0;
    std::vector result(n , 0);
    for (int i = 0; i < n; ++i)
    {
        if (seq[i] == '(')
        {
            if ((os & 1) == 1)
                result[i] = 1;
            os++;
        }
        else
        {
            if ((es & 1) == 1)
                result[i] = 1;
            es++;
        }
    }

    return result;
}
