#include "problem_2264.h"

bool problem_2264::test() {
    std::string num = "6777133339";

    std::string expected = "777";

    auto result = largestGoodInteger(num);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2264::largestGoodInteger(std::string num) {
    std::string result = "";
    for (int i = 2; i < num.size(); ++i)
    {
        if (num[i - 2] == num[i - 1] && num[i - 1] == num[i])
        {
            if (num[i] == '9')
                return "999";
            if (result == "" || num[i] > result[0])
                result = std::string(3, num[i]);
        }
    }

    return result;
}
