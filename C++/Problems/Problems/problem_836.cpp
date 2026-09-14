#include "problem_836.h"

bool problem_836::test() {
    std::vector rec1 { 0, 0, 2, 2 };
    std::vector rec2  { 1, 1, 3, 3 };

    bool expected = true;

    auto result = isRectangleOverlap(rec1, rec2);

    return result == expected;
}

bool problem_836::isRectangleOverlap(std::vector<int> &rec1, std::vector<int> &rec2) {
    return rec1[0] < rec2[2] && rec1[2] > rec2[0] && rec1[1] < rec2[3] && rec1[3] > rec2[1];
}
