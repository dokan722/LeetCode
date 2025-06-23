#include "problem_2081.h"

#include <algorithm>
#include <cmath>
#include <iostream>
#include <bits/ostream.tcc>

bool problem_2081::test() {
    auto k = 3;
    auto n = 7;

    auto expected = 499;

    auto result = kMirror(k, n);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2081::kMirror(int k, int n) {
    auto found = 0;
    auto len = 1;
    long long result = 0;
    while (found < n)
    {
        if (len % 2 == 0)
        {
            auto half = len / 2;
            auto start = (long long)std::pow(10, half - 1);
            auto end = start * 10;
            for (long long i = start; i < end && found < n; i++)
            {
                auto s = std::to_string(i);
                auto r = s;
                std::ranges::reverse(r);
                auto numS = s + r;
                auto num = std::stoll(numS);
                if (IsPalindrome(numS) && IsPalindrome(ConvertToBaseReversed(num, k)))
                {
                    found++;
                    result += num;
                }
            }
        }
        else
        {
            auto half = (len + 1) / 2;
            auto start = (long long)std::pow(10, half - 1);
            auto end = start * 10;
            for (long long i = start; i < end && found < n; i++)
            {
                auto s = std::to_string(i);
                auto r = s.substr(0, s.length() - 1);
                std::ranges::reverse(r);
                auto numS = s + r;
                auto num = std::stoll(numS);
                if (IsPalindrome(numS) && IsPalindrome(ConvertToBaseReversed(num, k)))
                {
                    found++;
                    result += num;
                }
            }
        }

        len++;
    }

    return result;
}

bool problem_2081::IsPalindrome(std::string s) {
    for (int i = 0; i < s.size() / 2; ++i)
    {
        if (s[i] != s[s.size() - i - 1])
            return false;
    }

    return true;
}

std::string problem_2081::ConvertToBaseReversed(long long n, long long b) {
    std::string result = "";
    while (n > 0)
    {
        auto next = n % b;
        result += std::to_string(next);
        n = n / b;
    }

    return result;
}
