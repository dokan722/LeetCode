#include "problem_3890.h"


bool problem_3890::test() {
    int n = 4104;

    std::vector expected { 1729, 4104 };

    auto result = findGoodIntegers(n);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3890::findGoodIntegers(int n) {
    int root = (int)std::cbrt(n);
    std::unordered_map<long long, int> present;
    std::vector<int> res;
    for (long i = 0; i <= root; ++i)
    {
        long long sf = i * i * i;
        for (long j = i; j <= root; ++j)
        {
            long long sl = sf + j * j * j;
            if (sl <= n)
            {
                int s = (int)sl;
                if (present.contains(s) && present[s] == 1)
                {
                    res.push_back(s);
                    present[s]++;
                }
                else
                    present[s] = 1;
            }
            else
                break;
        }
    }
    std::sort(res.begin(), res.end());
    return res;
}
