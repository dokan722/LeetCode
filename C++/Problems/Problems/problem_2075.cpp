#include "problem_2075.h"

bool problem_2075::test() {
    std::string encodedText = "ch   ie   pr";
    int rows = 3;

    std::string expected = "cipher";

    auto result = decodeCiphertext(encodedText, rows);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2075::decodeCiphertext(std::string encodedText, int rows) {
    if (rows == 1)
        return encodedText;
    std::string result = "";
    int rl = encodedText.size() / rows;
    for (int i = 0; i < rl; ++i)
    {
        bool full = true;
        int col = i;
        for (int j = 0; j < rows; ++j)
        {
            if (col + j >= rl)
            {
                full = false;
                break;
            }
            result.push_back(encodedText[j * rl + j + col]);
        }
        if (full == false)
            break;
    }
    int m = result.size() - 1;
    while (m >= 0 && result[m] == ' ')
        m--;
    return result.substr(0, m + 1);
}
