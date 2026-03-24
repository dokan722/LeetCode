#ifndef PROBLEM_2185_H
#define PROBLEM_2185_H

#include "../problem.h"
#include <string>
#include <vector>
#include <algorithm>

class problem_2185 : public problem {
public:
    bool test() override;

    int prefixCount(std::vector<std::string>& words, std::string pref);
};

#endif //PROBLEM_2185_H
