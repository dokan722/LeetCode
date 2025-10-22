#include "problem_1769.h"

bool problem_1769::test() {
    std::string boxes = "001011";

    std::vector expected { 11, 8, 5, 4, 3, 4 };

    auto result = minOperations(boxes);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_1769::minOperations(std::string boxes) {
    int n = boxes.size();
    std::vector result(n, 0);
    int curr = 0;
    int balls = 0;
    for (int i = 0; i < n; ++i)
    {
        curr += balls;
        result[i] += curr;
        if (boxes[i] == '1')
            balls++;
    }

    curr = 0;
    balls = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        curr += balls;
        result[i] += curr;
        if (boxes[i] == '1')
            balls++;
    }

    return result;
}
