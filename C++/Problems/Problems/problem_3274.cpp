#include "problem_3274.h"

bool problem_3274::test() {
    std::string coordinate1 = "a1";
    std::string coordinate2 = "c3";

    return checkTwoChessboards(coordinate1, coordinate2);
}

bool problem_3274::checkTwoChessboards(std::string coordinate1, std::string coordinate2) {
    return (coordinate1[0] % 2 == coordinate1[1] % 2) == (coordinate2[0] % 2 == coordinate2[1] % 2);
}
