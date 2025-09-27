#include "problem_1593.h"

bool problem_1593::test() {
    std::string s = "ababccc";

    int expected = 5;

    auto result = maxUniqueSplit(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1593::maxUniqueSplit(std::string s) {
    std::unordered_set<std::string> set;
    return splitFurther(s, "", 0, set);
}

int problem_1593::splitFurther(std::string s, std::string curr, int index, std::unordered_set<std::string>& present) {
    if (index >= s.size())
    {
        if (curr == "")
            return present.size();
        if (present.contains(curr))
            return -1;
        return present.size() + 1;
    }

    curr += s[index];
    int withInsert = -1;
    if (!present.contains(curr))
    {
        present.insert(curr);
        withInsert = splitFurther(s, "", index + 1, present);
        present.erase(curr);
    }

    int noInsert = splitFurther(s, curr, index + 1, present);

    return std::max(withInsert, noInsert);
}
