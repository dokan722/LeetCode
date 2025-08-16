#include "problem_1323.h"

bool problem_1323::test() {
    auto num = 9669;

    auto expected = 9969;

    auto result = maximum69Number(num);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1323::maximum69Number(int num) {
    std::string sNum = std::to_string(num);
    int n = sNum.size();
    auto found = false;
    for (int i = 0; i < n; ++i)
    {
        if (sNum[i] == '6')
        {
            found = true;
            sNum[i] = '9';
            break;
        }
    }

    return found ? std::stoi(sNum) : num;
}
