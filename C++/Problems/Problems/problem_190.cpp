#include "problem_190.h"

bool problem_190::test() {
    int n = 43261596;

    int expected = 964176192;

    auto result = reverseBits(n);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_190::reverseBits(int n) {
    return reverseRec(n, 32);
}

int problem_190::reverseRec(int n, int l) {
    if (l == 1)
        return n & 1;

    int half = l >> 1;
    int mask = (1 << half) - 1;
    int lo = n & mask;
    int hi = n >> half;

    return (reverseRec(lo, half) << half) | reverseRec(hi, half);
}
