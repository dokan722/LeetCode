#include "problem_1138.h"

bool problem_1138::test() {
    std::string target = "leet";

    std::string expected = "DDR!UURRR!!DDD!";

    auto result = alphabetBoardPath(target);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1138::alphabetBoardPath(std::string target) {
    int x = 0;
    int y = 0;
    std::string result = "";
    for (auto c : target)
    {
        int ti = c - 'a';
        int xt = ti / 5;
        int yt = ti % 5;
        int mv = x - xt;
        int mh = y - yt;
        std::string vertical = "";
        std::string horizontal = "";
        if (mv > 0)
            vertical = std::string(mv, 'U');
        else if (mv < 0)
            vertical = std::string(std::abs(mv), 'D');
        if (mh > 0)
            horizontal = std::string(mh, 'L');
        else if (mh < 0)
            horizontal = std::string(std::abs(mh), 'R');
        if (xt == 5)
            result += horizontal + vertical;
        else
            result += vertical + horizontal;
        result += "!";
        x = xt;
        y = yt;
    }

    return result;
}
