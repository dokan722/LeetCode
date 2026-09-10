#include "problem_940.h"

bool problem_940::test() {
    std::string s = "abc";

    int expected = 7;

    auto result = distinctSubseqII(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_940::distinctSubseqII(std::string s) {
    long long result = 0;
    std::vector<long long> prev(26, 0);
    int mod = 1000000007;
    for (auto c : s)
    {
        int id = c - 'a';
        long long next = (result + 1 - prev[id] + mod) % mod;
        result = (result + next) % mod;
        prev[id] = (prev[id] + next) % mod;
    }

    return (int)result;
}
