#include "problem_1773.h"

bool problem_1773::test() {
    std::vector<std::vector<std::string>> items { {"phone", "blue", "pixel"},  {"computer", "silver", "lenovo"}, {"phone", "gold", "iphone"}};
    std::string ruleKey = "color";
    std::string ruleValue = "silver";

    int expected = 1;

    auto result = countMatches(items, ruleKey, ruleValue);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1773::countMatches(std::vector<std::vector<std::string>> &items, std::string ruleKey,
    std::string ruleValue) {
    int result = 0;
    int rule = 0;
    if (ruleKey == "color")
        rule = 1;
    else if (ruleKey == "name")
        rule = 2;
    for (auto& item : items)
    {
        if (item[rule] == ruleValue)
            result++;
    }
    return result;
}
