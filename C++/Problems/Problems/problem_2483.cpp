#include "problem_2483.h"

bool problem_2483::test() {
    std::string customers = "YYNY";

    int expected = 2;

    auto result = bestClosingTime(customers);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2483::bestClosingTime(std::string customers) {
    int n = customers.size();
    int ys = 0;
    for (auto c : customers)
        if (c == 'Y')
            ys++;
    int ns = 0;
    int minPen = ys;
    int result = 0;
    for (int i = 0; i <n; ++i)
    {
        if (customers[i] == 'N')
            ns++;
        else
            ys--;
        int pen = ns + ys;
        if (pen < minPen)
        {
            minPen = pen;
            result = i + 1;
        }
    }

    return result;
}
